//---------------------------------------------------------------------

function NewMission::setValues()
{
   // do 'WorldType'
   Popup::clear(WorldType);
   for(%i = 0; $worldTypes[%i, type] != ""; %i++)
      Popup::addLine(WorldType, $worldTypes[%i, type], %i);
   Popup::setSelected(WorldType, $NM::worldIndex);
   
   // do 'skytype'
   Popup::clear(SkyType);
   %wi = $NM::worldIndex;
   for(%i = 0; $worldTypes[%wi, skyname, %i] != ""; %i++)
      Popup::addLine(SkyType, $worldTypes[%wi, skyname, %i], %i);
   Popup::setSelected(SkyType, $NM::skyIndex);
   
   // do 'terraintype'
   Popup::clear(TerrainType);
   for(%i = 0; $terrainTypes[%i, type] != ""; %i++)
      Popup::addLine(TerrainType, $terrainTypes[%i, description], %i);
   Popup::setSelected(TerrainType, $NM::terrainIndex);
}

//---------------------------------------------------------------------
// callbacks

function WorldType::onSelect(%string, %level)
{
   if($NM::worldIndex != %level)
   {
      $NM::worldIndex = %level;
      $NM::skyIndex = 0;
   }
   
   NewMission::setValues();
}

function SkyType::onSelect(%string, %level)
{
   $NM::skyIndex = %level;
   NewMission::setValues();
}

function TerrainType::onSelect(%string, %level)
{
   $NM::terrainIndex = %level;
   NewMission::setValues();
}

//-----------------------------------------------------------------------

function NewMission::create()
{
   %si          = $NM::skyIndex;
   %wi          = $NM::worldIndex;
   %ti          = $NM::terrainIndex;
   %missionName = convertSpaces($NM::missionName);
   %palette     = $worldTypes[%wi, palette, %si];
   %world       = $worldTypes[%wi, type];
   %simVol      = strcat( %world, ".sim.vol" );
   %dmlName     = strcat( %world, ".terrain.dml" );
   %gridName    = strcat( %world, ".grid.dat" );
   %rulesName   = strcat( %missionName, ".rules.dat" );
   %terrainDTF  = strcat( %missionName, ".ted.dtf" );
   %tedVol      = strcat( $Ted::currPath, %missionName, ".ted.vol" );
   %scriptName    = strcat( $Ted::currPath, %missionName, ".cs" );
   $server::MissionFileName = strcat( $Ted::currPath, %missionName @ ".mis" );
   $server::Mission           = %missionName;

   UnFocusCamera( $ME::camera );
   unfocus(TedObject);
   unfocus(MissionEditor);
   GuiLoadContentCtrl("simCanvas", "play.gui");
   MissionObjectList::ClearDisplayGroups();
   focusServer();
   deleteObject("MissionGroup");
   deleteObject("MissionCleanup");
   purgeDebris();
   resetPlayerManager();
   setGameInfo("");
   flushPilots();
   flushDustManager();
   purgeResources();
   focusClient();
   purgeResources();
   
   focusServer();

   deleteFunctions("*::vehicle::*");
   deleteFunctions("vehicle::*");
   deleteFunctions("*::structure::*");
   deleteFunctions("structure::*");
   deleteFunctions("*::turret::*");
   deleteFunctions("turret::*");
   deleteFunctions("*::trigger::*");
   deleteFunctions("trigger::*");
   deleteFunctions("onSPClientInit");

   exec( "missionStdLib.cs" );
   $server::HudMapViewOffsetX = 0;
   $server::HudMapViewOffsetY = 0;
   setHudMapViewOffset($server::HudMapViewOffsetX, $server::HudMapViewOffsetY);

   // --------------- default objects ------------------

   newObject( "MissionGroup", SimGroup );
   newObject( "MissionCleanup", SimGroup );
   newObject( "Volumes", SimGroup );
   newObject( "World", SimGroup );
   newObject( "DropPoints", SimGroup );
   addToSet( "MissionGroup", "Volumes", "World", "DropPoints" );

   newObject( terrainVol, SimVolume, %simVol );
   addToSet( "MissionGroup\\Volumes", "terrainVol" );

   newObject( "terrainPal", "ESPalette", %palette );
   newObject( "sky", "SimSky", 0,0,0, $worldTypes[%wi,skydml,%si], 0, $worldTypes[%wi,panels,%si] );
   newObject( "planet", "SimPlanet", $worldTypes[%wi, planet, %si], 0, 30, t, t, 1, 1, 1, 0, 0, 0 );

   // ---------------- create terrain ------------------

   newObject( "terrain", "SimTerrain", "Create", %terrainDTF, 12, 5, 64, 0, 2, -12288, -12288, 0, 0, 0, 0 );

   // apply the terrains
   LS::Create();
   LS::flushCommands();
   exec( %world @ ".terrain.cs");
	appendSearchPath();
   eval(Terrain:: @ %world @ "::createGridFile();");
   eval(Terrain:: @ %world @ "::setRules();");
   eval(Terrain:: @ $terrainTypes[%ti, type] @ "::create();");

	appendSearchPath();
   LS::Textures( %dmlName, %gridName );
   LS::parseCommands();
   LS::ApplyLandscape();
   LS::ApplyTextures();

   saveTerrain( "terrain", %tedVol );

   reCalcCRC();

   newObject( tedVol, SimVolume, %tedVol );
   addToSet( "MissionGroup\\Volumes", "tedVol" );

   deleteObject(8);
   newObject( "terrain", "SimTerrain", "Load", %terrainDTF, -12288, -12288, 0, 0, 0, 0  );
   setTerrainDetail( "terrain", 120.0, 140 );
   setTerrainVisibility( "terrain", $terrainTypes[%ti, visDistance], $terrainTypes[%ti, hazeDistance], 1000, 2000 );

   addToSet( "MissionGroup\\World","terrainPal","terrain","sky","planet" );
   if ( $worldTypes[%wi, stars, %si] == "true" )
   {
      newObject( "stars", StarField );
      addToSet( "MissionGroup\\World", "stars" );
   }

   reCalcCRC();

   saveMission( $server::MissionFileName );

   //--------------------------------------------------------------

//   exec( $server::MissionFileName );
   onMissionPreLoad();
   preLoadExplosionTables();
   preLoad();
   resetGhostManager();

   serverResetScores();
   initScoreBoard();
   onMissionLoad();

   focusClient();

   GuiLoadContentCtrl("simCanvas", "play.gui");

   drop();
}

//-----------------------------------------------------------------------

function NewMission::exit(%mission)
{
   focusClient();

   // get rid of the dialog and do mouse things
   if(!$NM::cursorOn)
      cursorOff(simCanvas);
   
   // check if hit cancel
   if(%mission != "")
      schedule("NewMission::doCreate(\"" @ %mission @ "\");", 1); 
   else
      GuiPopDialog(simCanvas, 0);
}

//-----------------------------------------------------------------------
// this needs to be scheduled because the create is called through
// a buttons onaction (the button gets destroyed by this function)
function NewMission::doCreate(%mission)
{
   $ConnectedToServer = false;
   deleteServer();
//   purgeResources();
   deleteObject(ConsoleScheduler);
   newObject(ConsoleScheduler, SimConsoleScheduler);
   exec(editor);  // pre-load the editor
   createServer(%mission, false);
}

//-----------------------------------------------------------------------

function NewMission::reset()
{
   // initialize all the tables...
   exec(worlds);
   exec(terrains);

   // set the defaults 'NM for NewMission'
   if($NewMissionName != "")
   {
      $NM::missionName = $NewMissionName;
      $NewMissionName = "";
   }
   else
      $NM::missionName        = "NewMission";
   $NM::missionIndex       = 0;
   $NM::worldIndex         = 0;
   $NM::skyIndex           = 0;
   $NM::terrainIndex       = 0;
   $NM::terrainSeed        = 0;

   NewMission::setValues();

   // get the mouse setup
   $NM::cursorOn = isCursorOn(simCanvas);
   if(!$NM::cursorOn)
      cursorOn(simCanvas);
}

//-----------------------------------------------------------------------
// initialization

GuiPushDialog(simCanvas, "newmission.gui");
NewMission::reset();
   
// end initialization
//-----------------------------------------------------------------------

function NewMission::createServer()
{
   focusServer();
   deleteServer();
//   purgeResources();
   newServer();
   focusServer();
   initializeServer();

   // Create network delegate
   if ($server::UDPPortNumber == "")
   {
      $server::UDPPortNumber = 29001;
   }

   newObject( serverDelegate, ESCSDelegate, true, "IP", $server::UDPPortNumber);

   newObject( "", SimConsoleScheduler );
   newObject( "", ChatDispatcher );

   if (isObject(serverDelegate))
   {
      $Gui::ServerCreated = true;
   }

   # Set up for rendering...
   focusClient();
   cycleCamera();
   flushTextureCache( "simCanvas" );

   # Start a client
   connect("IP:127.0.0.1:29001");
}

