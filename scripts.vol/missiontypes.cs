// -------------------------------------------------
// declare the mission types here
// -------------------------------------------------

$missionTypes[0, type]        = "CTF";
$missionTypes[0, description] = "Capture The Flag";
$missionTypes[0, minTeams]    = 2;
$missionTypes[0, maxTeams]    = 4;
 
$missionTypes[1, type]        = "DM";
$missionTypes[1, description] = "Death Match";
$missionTypes[1, minTeams]    = 1;
$missionTypes[1, maxTeams]    = 1;

$missionTypes[2, type]        = "TDM";
$missionTypes[2, description] = "Team Death Match";
$missionTypes[2, minTeams]    = 2;
$missionTypes[2, maxTeams]    = 4;

$missionTypes[3, type]        = "SWARM";
$missionTypes[3, description] = "Tag your it";
$missionTypes[3, minTeams]    = 1;
$missionTypes[3, maxTeams]    = 1;

$missionTypes[4, type]        = "FB";
$missionTypes[4, description] = "Football";
$missionTypes[4, minTeams]    = 2;
$missionTypes[4, maxTeams]    = 2;

$missionTypes[5, type]        = "WAR";
$missionTypes[5, description] = "destroy the base";
$missionTypes[5, minTeams]    = 2;
$missionTypes[5, maxTeams]    = 2;

$missionTypes[6, type]        = "KOTH";
$missionTypes[6, description] = "King of the Hill";
$missionTypes[6, minTeams]    = 1;
$missionTypes[6, maxTeams]    = 1;

// -------------------------------------------------
// create all the variables needed
// -------------------------------------------------

for(%i = 0; $missionTypes[%i, type] != ""; %i++)
   for(%j = 0; $missionTypes[%i, varName, %j] != ""; %j++)
      eval("$" @ $missionTypes[%i, type] @ "::" @ $missionTypes[%i, varName, %j] @ "=" @ $missionTypes[%i, varVal, %j] @ ";");

// -------------------------------------------------
// create functions - add stuff to the mission
// -------------------------------------------------

function Mission::CTF::create(%numTeams)
{
//   // add in the objectives
//   for(%i = 0; %i < $CandH::numObjectives; %i++)
//   {
//   }
//  
//   // add lines to the mission file...
//   addExportText("$teamScoreLimit = " @ $CandH::scoreLimit  @ ";");
//   addExportText("exec(objectives);");
//   addExportText("$Game::missionType = \"C&H\";");
}

function Mission::DM::create(%numTeams)
{
}

function Mission::TDM::create(%numTeams)
{
}

function Mission::SWARM::create(%numTeams)
{
}

function Mission::FB::create(%numTeams)
{
}

function Mission::WAR::create(%numTeams)
{
}

function Mission::KOTH::create(%numTeams)
{
}

