//------------------------------------------------------------------------------
//
// Repository for common script functions
//

//------------------------------------------------------------------------------
// Gui Mouse
//
function winMouse()
{
   inputDeactivate("mouse0");
   windowsMouseEnable("simCanvas");
}

function guiMouse()
{
   inputActivate("mouse0");
   windowsMouseDisable("simCanvas");
}

function editGui()
{
   winMouse();
   GuiEditMode( "simCanvas" );
   GuiInspect( "simCanvas" );
   GuiToolbar( "simCanvas" );
}

//------------------------------------------------------------------------------
function saveDefaultPrefs()
{
   export("$pref::*","defaultPrefs.cs");
   export("$IRC::*", "defaultPrefs.cs", true);   
}

//------------------------------------------------------------------------------

function ted(%window)
{
   if( %window == "" )
   {
      $TED::mainWindow = "simCanvas";
   }
   else
   {
      $TED::mainWindow = %window;
   }

   // ---------------------------
   // TED Variables
   // ---------------------------
   // flags
   $TED::flagCorner                 = false;
   $TED::flagEdit                   = false;
   $TED::flagEmpty1                 = false;
   $TED::flagEmpty2                 = false;
   $TED::flagEmpty3                 = false;
   $TED::flagFlipX                  = false;
   $TED::flagFlipY                  = false;
   $TED::flagRotate                 = false;
    
    // paste
   $TED::pasteMaterial              = true;
   $TED::pasteHeight                = true;
    
   // values
   $TED::heightVal                  = 50;
   $TED::adjustVal                  = 5;
   $TED::scaleVal                   = 1;
   $TED::pinDetailVal               = 0;
   $TED::pinMaxVal                  = 6;
   $TED::matIndexVal                = 0;
   $TED::smoothVal                  = 0.5;

   // display
   $TED::selectionDisplayFrame      = true;
   $TED::selectionDisplayOutline    = false;
   $TED::selectionDisplayFill       = true;
   $TED::selectionColorFrame        = 3;
   $TED::selectionColorFill         = 4;
   $TED::hilightDisplayFrame        = true;
   $TED::hilightDisplayOutline      = false;
   $TED::hilightDisplayFill         = true;
   $TED::hilightColorFrame          = 2;
   $TED::hilightColorFill           = 8;
   $TED::shadowDisplayFrame         = true;
   $TED::shadowDisplayOutline       = false;
   $TED::shadowDisplayFill          = true;
   $TED::shadowColorFrame           = 6;
   $TED::shadowColorFill            = 12;
   $TED::blockDisplayOutline        = false;

   // misc
   $TED::brushSnap                  = true;    
   $TED::brushFeather               = true;
   $SimTerrain::InteriorMask        = ( 1 << 13 ); // from defs.h

   // system
   $TED::castInteriorShadows        = true;
   $TED::success                    = false;
   $TED::diskName                   = "";
   $TED::currFile                   = "";
   $TED::currPath                   = "";
   $TED::terrainNameChange          = false;
   $TED::terrainExt                 = "ted.vol";
   $TED::editValue                  = "";

   Ted::initTed();
   Ted::attachToTerrain();

   // ---------------------------
   // set the default values
   // ---------------------------
   Ted::setHeightVal( $TED::heightVal );
   Ted::setAdjustVal( $TED::adjustVal );
   Ted::setScaleVal( $TED::scaleVal );
   Ted::setPinDetailVal( $TED::pinDetailVal );
   Ted::setPinDetailMax( $TED::pinMaxVal );
   Ted::setSmoothVal( $TED::smoothVal );
   Ted::setMatIndexVal( $TED::matIndexVal );
   
   Ted::setSelectShow( $TED::selectionDisplayFrame, $TED::selectionDisplayFill, $TED::selectionDisplayOutline );
   Ted::setSelectFrameColor( $TED::selectionColorFrame );
   Ted::setSelectFillColor( $TED::selectionColorFill );
   Ted::setHilightShow( $TED::hilightDisplayFrame, $TED::hilightDisplayFill, $TED::hilightDisplayOutline );
   Ted::setHilightFrameColor( $TED::hilightColorFrame );
   Ted::setHilightFillColor( $TED::hilightColorFill );
   Ted::setShadowShow( $TED::shadowDisplayFrame, $TED::shadowDisplayFill, $TED::shadowDisplayOutline );
   Ted::setShadowFrameColor( $TED::shadowColorFrame );
   Ted::setShadowFillColor( $TED::shadowColorFill );
   
   Ted::setSnap( $TED::brushSnap );
   Ted::setFeather( $TED::brushFeather );
   
   Ted::setBlockOutline( $TED::blockDisplayOutline );

   focus( "TedObject" );
   Ted::window( $Ted::mainWindow );

   setMainWindow( $Ted::mainWindow );

   winMouse();
   clientCursorOn();
}

//------------------------------------------------------------------------------

function loadMission(%mission)
{
   deleteObject("MissionGroup");
   deleteObject("MissionCleanup");
	purgeDebris();
   resetPlayerManager();
   setGameInfo("");

   $server::MissionFileName = %mission @ ".mis";

   $server::Mission = %mission;
   flushPilots();
   flushDustManager();
   deleteFunctions("*::vehicle::*");
   deleteFunctions("vehicle::*");
   deleteFunctions("*::structure::*");
   deleteFunctions("structure::*");
   deleteFunctions("*::turret::*");
   deleteFunctions("turret::*");
   deleteFunctions("*::trigger::*");
   deleteFunctions("trigger::*");
   deleteFunctions("onSPClientInit");

   if ($CmdLineServer) {
      resetSimTimer();
      flushConsoleScheduler();
   }

   exec( "missionStdLib.cs" );
   $server::HudMapViewOffsetX = 0;
   $server::HudMapViewOffsetY = 0;
	setAllowedItems();
   exec( strcat( %mission, ".cs" ) );
   loadMissionSoundVolume();
   setHudMapViewOffset($server::HudMapViewOffsetX, $server::HudMapViewOffsetY);
   loadObject( "MissionGroup", $server::MissionFileName );
   newObject( "MissionCleanup", "SimSet" );   
   onMissionPreLoad();
   preLoadExplosionTables();
   preLoad();
   resetGhostManager();

   serverResetScores();
   initScoreBoard();
   onMissionLoad();
	$ME::Loaded=false;
}

//------------------------------------------------------------------------------

function saveMission( %missionFile )
{
	if( %missionFile == "" )
    	%missionFile = $Ted::currPath @ $server::MissionFileName;
        
    missionSaveObject( "MissionGroup", %missionFile );
}

//------------------------------------------------------------------------------

function missionSaveObject( %objName, %fileName )
{
	focusServer();
	missionSaveObjectPersist( %objName, %fileName );
}

//------------------------------------------------------------------------------

function missionLoadObject( %objParentName, %fileName )
{
	focusServer();
    $MED::loadedObj = "";
 	missionLoadObjectPersist( %objParentName, %fileName );
}

//------------------------------------------------------------------------------

function terrain(%a, %b)
{
   $terrainDtf = strcat( %a, ".dtf" );
   $simVol     = strcat( %a, ".sim.vol" );
   $tedVol     = strcat( %b, ".ted.vol" );
   $Rulesvar   = strcat( %a, ".rules.dat" );
   $terraindml = strcat( %a, ".terrain.dml" );
   $gridvar    = strcat( %a, ".grid.dat" );
   $palvar     = strcat( %a, ".d.ppl" );
   $scriptvar  = strcat( %b, ".pls" );

   GuiLoadContentCtrl( "simCanvas", "Play.gui" );
   newObject( "Terrain", "SimTerrain", "Create", $terrainDtf, 12, 5, 64, 0, 2, -12288, -12288, 0, 0, 0, 0 );
   setTerrainDetail( "Terrain", 120.0, 0.1 );
   newObject( "tempVol", "SimVolume", $simVol );
   newObject( "tempPalette", "ESPalette", $palvar );

   LSCreate();
   LSRules( $Rulesvar );
   LSTextures( $terraindml, $gridvar );

   LSScript( $scriptvar );
   LSApplyLandScape();
   LSApplyTextures();

   newObject( "light", "SimLight", "Directional", 1, 1, 1, 0, 0, -1 );
   lightTerrain( "Terrain" );

   saveTerrain( "Terrain", $tedVol );

   flushTextureCache();

   newObject( "sky", "SimSky" );
}

//------------------------------------------------------------------------------

function world(%a)
{
   $PlanetDTF     = strcat( %a, ".dtf" );
   $PlanetPal     = strcat( %a, ".d.ppl" );

   #make a server...
   GuiLoadContentCtrl( "simCanvas", "Play.gui" );
   newServer();
   focusServer();

   # Create the terrain
   newObject( "terrainSimVol", "SimVolume", $PlanetSimVol );
   newObject( "terrainTedVol", "SimVolume", $PlanetTedVol );
   newObject( "terrain", "SimTerrain", "Load", $PlanetDTF );

   # Create lights
   newObject( "simPalette", "ESPalette", $PlanetPal );
   newObject( "light", "SimLight", "Directional", 1, 1, 1, 0, 0, -1 );

   # Create network delegate
   newObject( "serverDelegate", "ESCSDelegate", 28002 );

   # Set up for rendering...
   focusClient();
   cycleCamera();
   flushTextureCache( "simCanvas" );

   # Start a client
   connect("IP:127.0.0.1:28002");
}

//------------------------------------------------------------------------------

function loadSinglePlayMission(%mission)
{
   campaignInfo.nextMission = %mission;
   MissionBriefFlush();
   guiLoad("SPMain.gui");
}

//------------------------------------------------------------------------------

function loadPlayerPref()
{
   if( isFile("playerPrefs.cs"))
   {
      exec( "playerPrefs.cs" );
   }
}

//------------------------------------------------------------------------------

function loadServerPref()
{
   if( isFile("serverPrefs.cs"))
   {
      exec( "serverPrefs.cs" );
   }
}


//------------------------------------------------------------------------------
function loadAddressBook()
{
   if( isFile("tempAddrBook.cs"))
   {
      exec( "tempAddrBook.cs" );
   }
   else
   {
      exec( "addrBook.cs" );
   }
}

//------------------------------------------------------------------------------
function kick(%playerId, %reason)
{
   net::kick(%playerId, %reason);
}

//------------------------------------------------------------------------------
function lse(%world)
{
   $rulesVar   = strcat( %world, ".rules.dat" );
   $terrainVar = strcat( %world, ".terrain.dml" );
   $gridVar    = strcat( %world, ".grid.dat" );

   LSCreate();
   LSRules( $rulesVar );
   LSTextures( $terrainVar, $gridVar );
   ME();

   LSEditor( "simCanvas" );
}

//------------------------------------------------------------------------------
function ppStart()
{
   $ESBasePlugin::postProduction = true;

   bind( "keyboard", "make", 1, "TO", "$SimGame::TimeScale = 0.0;"  );
   bind( "keyboard", "make", 2, "TO", "$SimGame::TimeScale = 0.05;" );
   bind( "keyboard", "make", 3, "TO", "$SimGame::TimeScale = 0.1;"  );
   bind( "keyboard", "make", 4, "TO", "$SimGame::TimeScale = 0.2;"  );
   bind( "keyboard", "make", 5, "TO", "$SimGame::TimeScale = 0.4;"  );
   bind( "keyboard", "make", 6, "TO", "$SimGame::TimeScale = 1.0;"  );
   bind( "keyboard", "make", 7, "TO", "$SimGame::TimeScale = 2.0;"  );
   bind( "keyboard", "make", 8, "TO", "$SimGame::TimeScale = 5.0;"  );
   bind( "keyboard", "make", 9, "TO", "$SimGame::TimeScale = 10.0;" );
   bind( "keyboard", "make", 0, "TO", "$SimGame::TimeScale = 0.0;"  );
}


//------------------------------------------------------------------------------
function ppStop()
{
   $ESBasePlugin::postProduction = false;

   bind( "keyboard", "make", 1);
   bind( "keyboard", "make", 2);
   bind( "keyboard", "make", 3);
   bind( "keyboard", "make", 4);
   bind( "keyboard", "make", 5);
   bind( "keyboard", "make", 6);
   bind( "keyboard", "make", 7);
   bind( "keyboard", "make", 8);
   bind( "keyboard", "make", 9);
   bind( "keyboard", "make", 0);
}


//------------------------------------------------------------------------------
function guiEdit()
{
   GuiEditMode("simCanvas");
   GuiToolbar("simCanvas");
   GuiInspect("simCanvas");
}

//------------------------------------------------------------------------------
function guiNewContent(%a)
{
   GuiNewContentCtrl("simCanvas", %a);
}

//------------------------------------------------------------------------------
function guiSave(%a)
{
   GuiSaveContentCtrl("simCanvas", %a);
}

//------------------------------------------------------------------------------
function guiLoad(%a)
{
   GuiLoadContentCtrl("simCanvas", %a);
}

//------------------------------------------------------------------------------
function guiNewCtrl(%a)
{
   GuiEditNewControl("simCanvas", %a);
}


//------------------------------------------------------------------------------
function registerObjectIcons(%cs)
{
   #************************************************************************
   # Register objects to be used with the TreeView in this file
   #************************************************************************
   #
   #  To add your own bitmaps, starting at index 0 use:
   #  simTreeRegBitmaps treeName bitmap1.bmp bitmap2.bmp bitmap3.bmp bitmapN.bmp...
   #
   #************************************************************************
   #

   simTreeRegBitmaps( %cs, "Herc.bmp", "HercOpen.bmp" );
   simTreeRegBitmaps( %cs, "static.bmp", "staticOpen.bmp" );
   simTreeRegBitmaps( %cs, "interior.bmp", "interiorOpen.bmp" );
   simTreeRegBitmaps( %cs, "dropPt.bmp", "dropPtOpen.bmp" );
   simTreeRegBitmaps( %cs, "GUI.bmp", "GUIOpen.bmp" );

   #************************************************************************
   #  To Associate class types with bitmaps use:
   #  simTreeRegClass treeName className NormalBmpIndex SelectedBmpIndex
   #

   simTreeRegClass( %cs, "Herc", 6, 7 );
   simTreeRegClass( %cs, "StaticShape", 8, 9 );
   simTreeRegClass( %cs, "StaticInterior", 10, 11 );
   simTreeRegClass( %cs, "DropPoint", 12, 13 );
   simTreeRegClass( %cs, "SimGui::Responder", 14, 15 );

   #************************************************************************
   #  To add commands to the ClientList's "Scripts" menu
   #
   #  simTreeRegScript treeName menuText consoleCommand
   #  simTreeRegScript treeName separator
   #
}

//------------------------------------------------------------------------------

function clientTree()
{
   focusClient();
   simTreeCreate( "clientList", "simCanvas" );
   registerObjectIcons( "clientList" );

   clientCursorOn();              
   simTreeAddSet( "clientList", "manager" );
}

//------------------------------------------------------------------------------

function serverTree()
{
   simTreeCreate( "serverList", "simCanvas", "server" );

   registerObjectIcons( "serverList" );

   clientCursorOn();
   simTreeAddSet( "serverList", "manager" );
}

//-----------------------------------------------------------------------
function sp(%x, %y, %z, %camera)  // set position
{
	if (%camera == "")
	{
		%camera = "easyCamera";
	}
	setPosition(%camera, %x, %y, %z);
}

//------------------------------------------------------------------------------
function setDefaultMissionOptions()
{
//   $server::MaxPlayers = 8;
//   $server::TeamPlay = true;
//   $server::AllowDeathmatch = true;
//   $server::AllowTeamPlay = true;
//   $server::FragLimit = 99;
//   $server::TimeLimit = 99;
//   $server::SpawnLimit = 99;
//   $server::DropInProgress = true;
//   $server::TechLevelLimit = 99;
//   $server::CombatValueLimit = 99;
//   $server::MassLimit = 99;
//   $server::TeamCombatValueLimit = 99;
//   $server::TeamMassLimit = 99;
//   $server::AllowTeamRed = true;
//   $server::AllowTeamBlue = true;
//   $server::AllowTeamYellow = true;
//   $server::AllowTeamPurple = true;
}

//-----------------------------------------------------------------
//defining some global variables that make TED terrain .bmps work right
$FP                    =  1;			// 0x1;      // plane only
$FX                    =  4;			// 0x4;      // flip x
$FY                    =  16;			// 0x10;     // flip y
$FXY                   =  64;			// 0x40;     // flip x and y
$FR                    =  2;			// 0x2;      // rotate
$FYR                   =  32;			// 0x20;     // flip y and rotate
$FXR                   =  8;			// 0x8;      // flip x and rotate
$FXYR                  =  128;			// 0x80;     // flip x, y, and rotate
$FALL                  =  255;			// 0xff;     // allow any combo
$FNONE                 =  0;       // do not allow flipping or rotating
$TS3_DefaultType       =  0x0;
$TS3_ConcreteType      =  0x1;
$TS3_CarpetType        =  0x2;
$TS3_MetalType         =  0x3;
$TS3_GlassType         =  0x4;
$TS3_PlasticType       =  0x5;
$TS3_WoodType          =  0x6;
$TS3_MarbleType        =  0x7;
$TS3_SnowType          =  0x8;
$TS3_IceType           =  0x9;
$TS3_SandType          =  0xA;
$TS3_MudType           =  0xB;
$TS3_StoneType         =  0xC;
$TS3_SoftEarthType     =  0xD;
$TS3_PackedEarthType   =  0xE;
                                                        m