//============================================================================================
// ES Mulitplayer Region reserves tags  2 mil to 2.1 mil
// 
//============================================================================================

IDMULT_RGN_BEG                      = 02000000, "";

IDMULT_SECOND                       = 02000001, "second";
IDMULT_SECONDS                      = 02000002, "seconds";
IDMULT_MINUTE                       = 02000003, "minute";
IDMULT_MINUTES                      = 02000004, "minutes";

IDMULT_CHANGING_TEAM_BLUE           = 02000005, "<F5>NOTICE: Human vehicles must join the Blue team. Your team has been set to Blue.";
IDMULT_CHANGING_TEAM_PURPLE         = 02000006, "<F5>NOTICE: Cybrid vehicles must join the Purple team. Your team has been set to Purple.";
IDMULT_CHANGING_TEAM_UNKNOWN        = 02000007, "<F5>NOTICE: Unknown techknowledgy base. Your team has been set to Blue.";
IDMULT_SPANKED                      = 02000008, "<F5>NOTICE: You have been penalized for attacking a teammate.";

IDMULT_READY                        = 02000010, "Ready, shutdown to use.";
IDMULT_NOT_READY                    = 02000011, "Not ready.";
IDMULT_READY_IN_1                   = 02000012, "\nReady in ";
IDMULT_READY_IN_2                   = 02000013, ".";
IDMULT_DEPLETED                     = 02000014, "Pad energy depleted -- recharging.";
IDMULT_RECHARGED                    = 02000015, "Pad recharged.";

IDMULT_YELLOW                       = 02000016, "YELLOW";
IDMULT_BLUE                         = 02000017, "BLUE";
IDMULT_RED                          = 02000018, "RED";
IDMULT_PURPLE                       = 02000019, "PURPLE";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Generic Game Info Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_RULES_WELCOME                = 02000800, "Welcome to Starsiege";
IDMULT_STD_ITEMS                    = 02000805, "<F2>ITEMS OF INTEREST:\n\n";
IDMULT_STD_HEAL                     = 02000806, "<Jl><bmp1.bmp><F3>Heal Pads:<F0> Power down while on "
                                                @ "or under one of these structures to heal your vehicle. A pad with no "
                                                @ "generator will operate less efficiently.\n\n\n\n";
IDMULT_STD_RELOAD_1                 = 02000807, "<Jl><bmp2.bmp><F3>Reload Pads:<F0> Power down while on "
                                                @ "or under these structures to reload your vehicle's weapons. "
                                                @ "Reload pads may only be used once every <F3>";
IDMULT_STD_RELOAD_2                 = 02000808, "<F0> seconds. A pad with no generator will operate less efficiently.\n\n\n"
                                                @ "<F5>NOTE: While healing or reloading, your vehicle is vulnerable to "
                                                @ "enemy fire. It is considered proper and encouraged practice to take advantage "
                                                @ "of a foe while they heal or reload their vehicle.\n\n\n";



IDMULT_STD_ZEN_1                    = 02000809, "<bzen1.bmp><F3>Zen Pads:<F0> Power down while on "
                                                @ "one of these structures to reload <F3>AND<F0> heal your vehicle. "
                                                @ "This pad type may only be used once every <F3>";                                                 
IDMULT_STD_ZEN_2                    = 02000810, "<F0> seconds. A pad with no generator will operate less efficiently.\n\n\n\n";
IDMULT_STD_TELEPORTER               = 02000811, "<btele1.bmp><F3>Teleporter Gate:<F0> Walking through one of these gates "
                                                @ "will teleport your vehicle to another location on the map.\n\n\n\n\n";
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// DeathMatch Game Info Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_DM                           = 02000900, "Deathmatch";
IDMULT_DM_GAMETYPE                  = 02000901, "<F2>GAME TYPE: \n<F0>DeathMatch\n\n";
IDMULT_DM_MAPNAME                   = 02000902, "<F2>MISSION: \n<F0>";
IDMULT_DM_SYNOPSIS                  = 02000903, "\n\n<F2>SYNOPSIS:\n"
                                                @ "<F0>Kill or be killed. All players are hostile towards eachother.\n\n";
IDMULT_DM_OBJECTIVES                = 02000904, "\n\n<F2>RULES/OBJECTIVES:\n"
                                                @ "<F0>1) All players are assigned to the red team.\n\n"
                                                @ "2) To score, destroy enemy vehicles.\n\n"
                                                @ "3) Consider all targets hostile.\n\n";
IDMULT_DM_SCORING_1                 = 02000905, "<F2>SCORING:\n";
IDMULT_DM_SCORING_2                 = 02000906, "<F0>Killing an enemy is worth <F3>";
IDMULT_DM_SCORING_3                 = 02000907, " <F0>point(s).\n\n";
IDMULT_DM_SCORING_4                 = 02000908, "If you are killed, you lose <F3>";
IDMULT_DM_SCORING_5                 = 02000909, " <F0>point(s).\n\n";
IDMULT_DM_WELCOME                   = 02000910, "<F1>Welcome to DeathMatch! Check the Game Info tab for rules and scoring information.";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Team DeathMatch Game Info Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_TDM                          = 02000915, "Team Deathmatch";
IDMULT_TDM_GAMETYPE                 = 02000916, "<F2>GAME TYPE: \n<F0>Team DeathMatch\n\n";
IDMULT_TDM_MAPNAME                  = 02000917, "<F2>MISSION: \n<F0>";
IDMULT_TDM_SYNOPSIS                 = 02000918, "\n\n<F2>SYNOPSIS:\n"
                                                @ "<F0>Team warfare. Each team tries to destroy members of the other team(s).\n\n";
IDMULT_TDM_OBJECTIVES               = 02000919, "\n\n<F2>RULES/OBJECTIVES:\n"
                                                @ "<F0>1) Locate and destroy enemy vehicles.\n\n"
                                                @ "2) Protect your base's heal and reload pad generators.\n\n";
IDMULT_TDM_SCORING_1                = 02000920, "<F2>SCORING:\n";
IDMULT_TDM_SCORING_2                = 02000921, "<F0>Killing an enemy is worth <F3>";
IDMULT_TDM_SCORING_3                = 02000922, " <F0>point(s).\n\n";
IDMULT_TDM_SCORING_4                = 02000923, "If you are killed, you lose <F3>";
IDMULT_TDM_SCORING_5                = 02000924, " <F0>point(s).\n\n";
IDMULT_TDM_SCORING_6                = 02000925, "<F5>NOTE: Killing a teammate is -1 kill. Continued team killing may result in being kicked from the server.\n\n";
IDMULT_TDM_WELCOME                  = 02000926, "<F1>Welcome to Team DeathMatch! Check the Game Info tab for rules and scoring information.";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Capture the Flag Game Info Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_CTF                          = 02000930, "Capture The Flag";
IDMULT_CTF_GAMETYPE                 = 02000931, "<F2>GAME TYPE: \n<F0>Capture The Flag\n\n";
IDMULT_CTF_MAPNAME                  = 02000932, "<F2>MISSION: \n<F0>";
IDMULT_CTF_SYNOPSIS                 = 02000933, "\n\n<F2>SYNOPSIS:\n"
                                                @ "<F0>One team must steal the enemy flag and return it to their own.\n\n";
IDMULT_CTF_OBJECTIVES               = 02000934, "\n\n<F2>RULES/OBJECTIVES:\n"
                                                @ "<F0>1) \"Capture\" the enemy flag by moving over it with your vehicle.\n\n"
                                                @ "2) Return the captured flag to your own team's flag.<L0>\n\n"
                                                @ "3) You may not return an enemy flag unless your own team's flag resides at your base.\n\n";
IDMULT_CTF_OBJECTIVES_2             = 02000935, "4) The flag carrier has <F3>";
IDMULT_CTF_OBJECTIVES_3             = 02000936, " <F0>to return the enemy flag after which the flag will return to your opponent's base.\n\n";
IDMULT_CTF_SCORING_1                = 02000937, "<F2>SCORING:\n";
IDMULT_CTF_SCORING_2                = 02000938, "<F0>Capturing an enemy flag is worth <F3>";
IDMULT_CTF_SCORING_3                = 02000939, " <F0>point(s).\n\n";
IDMULT_CTF_SCORING_4                = 02000940, "<F0>Killing an enemy flag carrier is worth <F3>";
IDMULT_CTF_SCORING_5                = 02000941, " <F0>point(s).\n\n";
IDMULT_CTF_SCORING_6                = 02000942, "If you are killed, you lose <F3>";
IDMULT_CTF_SCORING_7                = 02000943, " <F0>point(s).\n\n";
IDMULT_CTF_SCORING_8                = 02000944, "Killing other enemies (non flag-carriers) is worth <F3>";
IDMULT_CTF_SCORING_9                = 02000945, " <F0>point(s).\n\n";
IDMULT_CTF_SCORING_10               = 02000946, "First team to capture <F3>";
IDMULT_CTF_SCORING_11               = 02000947, " <F0>flag(s) wins.\n\n";
IDMULT_CTF_WELCOME                  = 02000948, "<F1>Welcome to CTF! Check the Game Info tab for rules and scoring information.";
IDMULT_CTF_FLAGS                    = 02000949, "<bctf1.bmp><F3>Flags:<F0> Capture an enemy flag by moving your "
                                                 @ "vehicle over the flag. Only enemy flags may be captured.\n\n\n\n\n";
IDMULT_CTF_GLOW                     = 02000950, "<bctf2.bmp><F3>Flag Carrier:<F0> When a flag is captured, the flag carrier's "
                                                 @ "vehicle will glow with the color of the captured flag.\n\n\n\n\n";


// special tags
IDMULT_STD_CYBRID_VS_HUMAN_1        = 02000951, "<F5>NOTE: This special variant of Capture the Flag pits Human against Cybrid. All "
                                                @ "Human vehicles must join the Blue team, all Cybrid vehicles must join "
                                                @ "the Purple team.<F0>\n\n";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Starsiege Football Game Info Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_FOOTBALL                     = 02000960, "Starsiege Football";
IDMULT_FOOTBALL_GAMETYPE            = 02000961, "<F2>GAME TYPE: \n<F0>Starsiege Football\n\n";
IDMULT_FOOTBALL_MAPNAME             = 02000962, "<F2>MISSION: \n<F0>";
IDMULT_FOOTBALL_SYNOPSIS            = 02000963, "\n\n<F2>SYNOPSIS:\n"
                                                @ "<F0>Football with a unique Starsiege twist.\n\n";
IDMULT_FOOTBALL_OBJECTIVES          = 02000964, "\n\n<F2>RULES/OBJECTIVES:\n"
                                                @ "<F0>1) The first player to enter the game receives the \"ball\". While the ball is "
                                                @ "carried, the ball carrier will glow.\n\n"
                                                @ "2) To score touchdowns, the ball carrier must carry the ball to the enemy end zone.\n\n"
                                                @ "3) Once a touchdown is scored, all units on the field are destroyed and returned to "
                                                @ "their appropriate sides. A random member of the other team will receive the ball.\n\n"
                                                @ "4) If the ball carrier is attacked or rammed, there is a random chance that they will \"fumble\" "
                                                @ "the ball. In this case, the ball is given to the attacker that caused the fumble.\n\n"   
                                                @ "5) All vehicles on the field must stay within the bounds designated by the yellow "
                                                @ "and black striped lines surrounding the field. Each time a player violates "
                                                @ "these boundaries, they are penalized with a foul.\n\n"
                                                @ "6) When a player has fouled three times, they are sent to the \"Penalty Box\" where they "
                                                @ "must remain for 1 minute. During this time, the player may not move their vehicle "
                                                @ "out of the box, however they may cheer their teammates on by providing support fire from "
                                                @ "the box.\n\n";
IDMULT_FOOTBALL_SCORING_1           = 02000967, "<F2>SCORING:\n";
IDMULT_FOOTBALL_SCORING_2           = 02000968, "<F0>Touchdowns are worth <F3>";
IDMULT_FOOTBALL_SCORING_3           = 02000969, " <F0>point(s).\n\n";
IDMULT_FOOTBALL_SCORING_4           = 02000970, "<F0>The first team to <F3>";
IDMULT_FOOTBALL_SCORING_5           = 02000971, " <F0>point(s) wins the game.\n\n";
IDMULT_FOOTBALL_WELCOME             = 02000978, "<F1>Welcome to Starsiege Football! Check the Game Info tab for rules and scoring information.";
IDMULT_FOOTBALL_ENDZONE             = 02000979, "<bfb1.bmp><F3>End Zone:<F0> The ball carrier must run the ball to the enemy "
                                                 @ "team's end zone to score a touchdown.\n\n\n\n\n";
IDMULT_FOOTBALL_GLOW                = 02000980, "<bfb3.bmp><F3>Ball Carrier:<F0> The vehicle carrying the ball will glow purple.\n\n\n\n\n\n";
IDMULT_FOOTBALL_PENALTY_1           = 02000981, "<bfb2.bmp><F3>Penalty Box:<F0> If a player has committed <F3>";
IDMULT_FOOTBALL_PENALTY_2           = 02000982, " <F0>foul(s), <F0>they will be sent to the penalty box for <F3>";
IDMULT_FOOTBALL_PENALTY_3           = 02000983, "<F0>. During that time, they may not move from the box, but may aid their team with support fire.\n\n\n\n";
IDMULT_FOOTBALL_MARKERS             = 02000984, "<bfb4.bmp><F3>Bounds Markers: <F0>These floating markers represent the edge boundaries on the field.\n\n\n\n\n";


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// War Game Info Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_WAR                          = 02000990, "WAR";
IDMULT_WAR_GAMETYPE                 = 02000991, "<F2>GAME TYPE: \n<F0>WAR\n\n";
IDMULT_WAR_MAPNAME                  = 02000992, "<F2>MISSION: \n<F0>";
IDMULT_WAR_SYNOPSIS                 = 02000993, "\n\n<F2>SYNOPSIS:\n"
                                                @ "<F0>One team must destroy the other team's base.\n\n";
IDMULT_WAR_OBJECTIVES_1             = 02000994, "\n\n<F2>RULES/OBJECTIVES:\n"
                                                @ "<F0>1) In order to win, one team must lay waste to the other team's base by "
                                                @ "destroying all enemy power generators and the enemy headquarters.\n\n"
                                                @ "2) Each turret is powered by a nearby generator. If the turret's generator is destroyed, "
                                                @ "the turret will go off-line.\n\n"
                                                @ "3) Each base is guarded by three AI units. If the enemy headquarters remains, the enemy AI will respawn every <F3>";
IDMULT_WAR_OBJECTIVES_2             = 02000996, " <F0>. If the headquarters is destroyed, the AI will respawn every <F3>";
IDMULT_WAR_OBJECTIVES_3             = 02000997, " <F0>.\n\n";
IDMULT_WAR_OBJECTIVES_4             = 02000998, "4) The first team to destroy <F3>";
IDMULT_WAR_OBJECTIVES_5             = 02000999, " <F0>of their enemies' structures wins the game.\n\n";
IDMULT_WAR_SCORING_1                = 02001000, "<F2>SCORING:\n";
IDMULT_WAR_SCORING_2                = 02001001, "<F0>Kills are worth <F3>1<F0> point.\n\n";
IDMULT_WAR_HQ                       = 02001002, "<bwar1.bmp><F3>Headquarters: <F0>The enemy headquarters must be destroyed in order "
                                                @ "to win (in addition to all enemy power generators). Destroy the enemy HQ to "
                                                @ "cripple the enemy AI base defenders.\n\n\n";
IDMULT_WAR_GENERATORS               = 02001003, "<bwar2.bmp><F3>Power Generator: <F0>All enemy power generators must be destroyed in order "
                                                @ "to win (in addition to the enemy headquarters). Destroy enemy generators to off-line turrets.\n\n\n";
IDMULT_WAR_TURRETS                  = 02001004, "<bmp3.bmp>Turrets: <F0>Each base is defended by AI turrets. Destroy nearby power generators "
                                                @ "to bring the turrets off-line.\n\n\n\n\n";
IDMULT_WAR_WELCOME                  = 02001005, "<F1>Welcome to WAR! Check the Game Info tab for rules and scoring information.";
IDMULT_WAR_YELLOW_DEFENDER          = 02001006, "Yellow Base Defender";
IDMULT_WAR_RED_DEFENDER             = 02001007, "Red Base Defender";
IDMULT_WAR_RED_HQ_DESTROYED         = 02001010, "Red Team's headquarters destroyed! Red AI units respawn time set to ";
IDMULT_WAR_YELLOW_HQ_DESTROYED      = 02001011, "Yellow Team's headquarters destroyed! Yellow AI units respawn time set to ";
IDMULT_WAR_RED_FL_GEN_DESTROYED     = 02001012, " demolishes the Red team's front left turret generator!";
IDMULT_WAR_RED_FR_GEN_DESTROYED     = 02001013, " demolishes the Red team's front right turret generator!";
IDMULT_WAR_RED_BL_GEN_DESTROYED     = 02001014, " demolishes the Red team's back left turret generator!";
IDMULT_WAR_RED_BR_GEN_DESTROYED     = 02001015, " demolishes the Red team's back right turret generator!";
IDMULT_WAR_RED_CEN_GEN_DESTROYED    = 02001016, " demolishes the Red team's center turret generator!";
IDMULT_WAR_YELLOW_FL_GEN_DESTROYED  = 02001017, " demolishes the Yellow team's front left turret generator!";
IDMULT_WAR_YELLOW_FR_GEN_DESTROYED  = 02001018, " demolishes the Yellow team's front right turret generator!";
IDMULT_WAR_YELLOW_BL_GEN_DESTROYED  = 02001019, " demolishes the Yellow team's back left turret generator!";
IDMULT_WAR_YELLOW_BR_GEN_DESTROYED  = 02001020, " demolishes the Yellow team's back right turret generator!";
IDMULT_WAR_YELLOW_CEN_GEN_DESTROYED = 02001021, " demolishes the Yellow team's center turret generator!";
IDMULT_WAR_DESTROYED_RED_STRUCTURE  = 02001022, " demolishes a red structure.";
IDMULT_WAR_DESTROYED_YELLOW_STRUCTURE = 02001023, " demolishes a yellow structure.";
IDMULT_WAR_SPANKED_BUILDING         = 02001024, "<F5>NOTICE: You have been penalized for attacking a friendly structure.";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Scoreboard Tags
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
IDMULT_SCORE_TEAM                   = 02002000, "Team";
IDMULT_SCORE_SQUAD                  = 02002001, "Squad";
IDMULT_SCORE_SCORE                  = 02002002, "Score";
IDMULT_SCORE_KILLS                  = 02002003, "Kills";
IDMULT_SCORE_DEATHS                 = 02002004, "Deaths";
IDMULT_SCORE_PING                   = 02002005, "Ping";
IDMULT_SCORE_AVERAGEPING            = 02002006, "Average Ping";
IDMULT_SCORE_FLAGS                  = 02002007, "Flags";
IDMULT_SCORE_CARRIER_KILLS          = 02002008, "Carrier Kills";
IDMULT_SCORE_KING_KILLS             = 02002009, "King Kills";
IDMULT_SCORE_CROWNS                 = 02002010, "Crowns";
IDMULT_SCORE_TAXES                  = 02002011, "Taxes";
IDMULT_SCORE_EXECUTIONS             = 02002012, "Executions";
IDMULT_SCORE_SACKS                  = 02002013, "Sacks";
IDMULT_SCORE_SNUFFS                 = 02002014, "Snuffs";
IDMULT_SCORE_CHOKES                 = 02002015, "Chokes";
IDMULT_SCORE_CLAIMS                 = 02002016, "Claims";
IDMULT_SCORE_HOLDS                  = 02002017, "Holds";
IDMULT_SCORE_PLAYERS                = 02002018, "Players";


// generic chat messages
IDMULT_CHAT_HEALPAD                 = 02003000, "Entering repair area.";
IDMULT_CHAT_AMMOPAD                 = 02003001, "Entering reload area.";
IDMULT_CHAT_ALLPAD                  = 02003002, "Entering repair & reload area.";
IDMULT_CHAT_RUN_THE_GAUNTLET        = 02003005, "Run the gauntlet for reloading and repair.";

IDMULT_CHAT_BLUE_PAD_REFUSE         = 02003007, "Only Blue Team can use this pad.";
IDMULT_CHAT_RED_PAD_REFUSE          = 02003008, "Only Red Team can use this pad.";
IDMULT_CHAT_YELLOW_PAD_REFUSE       = 02003009, "Only Yellow Team can use this pad.";
IDMULT_CHAT_PURPLE_PAD_REFUSE       = 02003010, "Only Purple Team can use this pad.";
IDMULT_CHAT_KING_DEAD_THRONE_EMPTY  = 02003011, "The King is dead, the throne is empty!";
IDMULT_CHAT_KING_WARNING            = 02003012, "Sire, you are at the edge of your domain -- stay near the throne.";
IDMULT_CHAT_KING_TOO_FAR            = 02003013, "The King has abdicated the throne.";
IDMULT_CHAT_KING_STILL_ALIVE        = 02003014, "Pretender! The King still lives!";
IDMULT_CHAT_KING_THRONE_COUNTDOWN   = 02003015, "Throne Countdown";
IDMULT_CHAT_KING_RETURNED           = 02003016, "Thank goodness you have returned. Your reign is once again secure.";
IDMULT_CHAT_TIE_GAME                = 02003017, "The game is over -- it's a tie!";
IDMULT_CHAT_RED_FLAG                = 02003018, "Red Flag";
IDMULT_CHAT_BLUE_FLAG               = 02003019, "Blue Flag";
IDMULT_CHAT_YELLOW_FLAG             = 02003020, "Yellow Flag";
IDMULT_CHAT_PURPLE_FLAG             = 02003021, "Purple Flag";
IDMULT_CHAT_RED_TURRETS_OFFLINE     = 02003022, "Red Turrets no longer have enough power to function.";
IDMULT_CHAT_BLUE_TURRETS_OFFLINE    = 02003023, "Blue Turrets no longer have enough power to function.";
IDMULT_CHAT_TEAM_KILL_WARN          = 02003024, "You just killed a teammate.  Do it again and be kicked from the game.";
IDMULT_CHAT_TEAM_KILL_KICK          = 02003025, "Kicked for team killing after being warned.";

// paired chat messages
IDMULT_CHAT_SHOW_PERCENTAGE_1       = 02005000, "Functioning at ";
IDMULT_CHAT_SHOW_PERCENTAGE_2       = 02005001, " percent capacity.";

IDMULT_CHAT_SURRENDER_FLAG_1        = 02005002, "";
IDMULT_CHAT_SURRENDER_FLAG_2        = 02005003, " surrenders ";
IDMULT_CHAT_SURRENDER_FLAG_3        = 02005004, "'s flag!";

IDMULT_CHAT_CAPTURE_FLAG_1          = 02005005, "";
IDMULT_CHAT_CAPTURE_FLAG_2          = 02005006, " captures ";
IDMULT_CHAT_CAPTURE_FLAG_3          = 02005007, "'s flag!";

IDMULT_CHAT_STEAL_FLAG_1            = 02005008, "";
IDMULT_CHAT_STEAL_FLAG_2            = 02005009, " steals ";
IDMULT_CHAT_STEAL_FLAG_3            = 02005010, "'s flag!";

IDMULT_CHAT_KING_CROWNED_1          = 02005011, "";
IDMULT_CHAT_KING_CROWNED_2          = 02005012, " is King. Long live ";
IDMULT_CHAT_KING_CROWNED_3          = 02005013, "!";

IDMULT_CHAT_KING_KILLED_1           = 02005014, "";
IDMULT_CHAT_KING_KILLED_2           = 02005015, " has killed the King.";

IDMULT_CHAT_KING_TIMER_1            = 02005016, "Sire, you have strayed too far! You must reach the throne in ";
IDMULT_CHAT_KING_TIMER_2            = 02005017, "!";

IDMULT_CHAT_WON_GAME_1              = 02005018, "";
IDMULT_CHAT_WON_GAME_2              = 02005019, " won the game!";

IDMULT_CHAT_SWARM_IT_1              = 02005020, "";
IDMULT_CHAT_SWARM_IT_2              = 02005021, " is now IT!";
              
IDMULT_CHAT_IT_WARNING_1            = 02005022, "You need to stay within ";
IDMULT_CHAT_IT_WARNING_2            = 02005023, " meters of the center.";

IDMULT_CHAT_TOWER_CLAIMED_1         = 02005024, "The ";
IDMULT_CHAT_TOWER_CLAIMED_2         = 02005025, " tower is now owned by ";
IDMULT_CHAT_TOWER_CLAIMED_3         = 02005026, "!";

IDMULT_CHAT_TOWER_RESET_1           = 02005027, "";
IDMULT_CHAT_TOWER_RESET_2           = 02005028, " has lost ownership of the ";
IDMULT_CHAT_TOWER_RESET_3           = 02005029, " tower.";

 


// building names
IDMULT_TRANSPORTER_CELL             = 02010000, "Transporter Cell";

IDMULT_TUNNEL_ENTRANCE              = 02010001, "Tunnel Entrance";

IDMULT_QUEENS_PYRAMID               = 02010002, "Queens Pyramid";
IDMULT_TOMB                         = 02010003, "Tomb";
IDMULT_VALLEY_TEMPLE                = 02010004, "Valley Temple";
IDMULT_MORTUARY_TEMPLE              = 02010005, "Mortuary Temple";
IDMULT_BOAT_PITS                    = 02010006, "Boat Pits";

IDMULT_AMMUNITION                   = 02010007, "Ammunition";
IDMULT_GUARDIAN_DROP_POD            = 02010008, "Guardian Drop Pod";
IDMULT_AMERICAN_FLAG                = 02010009, "American Flag";
IDMULT_APOLLO_13                    = 02010010, "Apollo 13";
IDMULT_UPLINK                       = 02010011, "Uplink";
IDMULT_COMMUNICATIONS               = 02010012, "Communications";
IDMULT_COMMUNICATION_DISH           = 02010013, "Communication Dish";
IDMULT_LUNAR_DEFENSE                = 02010014, "Lunar Defense";
IDMULT_BARRACKS                     = 02010015, "Barracks";
IDMULT_RESIDENCE                    = 02010016, "Residence";
IDMULT_LISTENING_STATION            = 02010017, "Listening Station";
IDMULT_POWER_STATION                = 02010018, "Power Station";
IDMULT_SPECIAL_OPS_BUILDING         = 02010019, "Special Ops Building";
IDMULT_LUNAR_HQ                     = 02010020, "Lunar HQ";
IDMULT_SILOS                        = 02010021, "Silos";
IDMULT_CHURCH			               = 02010022, "Temple of NHMK";
IDMULT_STORAGE_CENTER               = 02010023, "Storage Center";
IDMULT_MEETING_HALL                 = 02010024, "Meeting Hall";
IDMULT_FUEL_TANK                    = 02010025, "Fuel Tank";
IDMULT_LUNAR_MONUMENT               = 02010026, "Lunar Monument";

IDMULT_SOLAR_STATION                = 02010027, "Solar Station";
IDMULT_AMMO_CONTAINER               = 02010028, "Ammunition Container";
IDMULT_CANNON                       = 02010029, "Cannon";
IDMULT_TRANSPORTER_TO_YELLOW_BASE   = 02010030, "Transporter to Yellow Base";
IDMULT_TRANSPORTER_TO_RED_BASE      = 02010031, "Transporter to Red Base";
IDMULT_TRANSPORTER_TO_BLUE_BASE     = 02010032, "Transporter to Blue Base";
IDMULT_TRANSPORTER_TO_PURPLE_BASE   = 02010033, "Transporter to Purple Base";
IDMULT_TRANSPORTER_TO_MOUNTAIN      = 02010034, "Transporter to Mountain";

IDMULT_POLICE                       = 02010040, "Police";
IDMULT_POLICE_HQ                    = 02010041, "Police HQ";
IDMULT_FUSION_REACTOR               = 02010042, "Fusion Reactor";
IDMULT_REFINERY                     = 02010043, "Refinery";
IDMULT_WATER_CONVERTER              = 02010044, "Water Converter";
IDMULT_WATER_TOWER                  = 02010045, "Water Tower";

IDMULT_MAIN_POWER_STATION           = 02010050, "Main Power Station";
IDMULT_HEADQUARTERS                 = 02010051, "Headquarters";
IDMULT_COMMUNICATIONS_DISH          = 02010052, "Communications Dish";

IDMULT_ATMOSPHERIC_CONVERTER        = 02010060, "Atmospheric Converter";
IDMULT_ATMOSPHERIC_POWER_ARRAY      = 02010061, "Atmospheric Power Array";
IDMULT_STREET_LIGHT                 = 02010062, "Street Light";
IDMULT_GARAGE                       = 02010063, "Garage";

IDMULT_MESS_HALL			            = 02010064, "Mess Hall";
IDMULT_TRANSPORT_KEY		            = 02010065, "Transporter Key";
IDMULT_FROSTYS_HOUSE		            = 02010066, "Frosty's House";
IDMULT_PET_ROCK			            = 02010067, "My Pet Rock";
IDMULT_BUDDHA			               = 02010068, "The Buddha";
IDMULT_THRONE			               = 02010069, "King's Throne";

IDMULT_HEAL_POWER					      = 02020000, "Repair Power Generator";
IDMULT_AMMO_POWER				         = 02020001, "Reload Power Generator";
IDMULT_ZEN_POWER					      = 02020002, "Reload/Repair Power Generator";

IDMULT_YOU_KILLED_BUDDHA		      = 02020003, "Your foolishness has fated you to meet the Buddha!";
IDMULT_MOON_LANDER_FOUND		      = 02020004, "DANGER:  High radiation levels detected!";

IDMULT_FOOTY_ENTER_PENALTY_BOX      = 02020014, " is a team killer!\nThrowing them in the penalty box!";
IDMULT_FOOTY_FUMBLES_THE_BALL	      = 02022015, " fumbles the ball!";
IDMULT_FOOTY_OUT_OF_BOUNDS			   = 02022016, "You went out of Bounds!";
IDMULT_FOOTY_PERSONAL_FOUL			   = 02022017, "You are penalized.  This is personal foul number ";
IDMULT_FOOTY_PENALTY_BOX		      = 02022018, " has been thrown in The Penalty Box!";
IDMULT_FOOTY_TOO_MANY_FOULS		   = 02022019, "You've committed too many fouls!\nWelcome to The Penalty Box!";
IDMULT_FOOTY_PENALTY_OVER_IN		   = 02022020, "Penalty Over in:";
IDMULT_FOOTY_LEAVING_PENALTY_BOX    = 02022021, "Leaving penalty box.";
IDMULT_FOOTY_MADE_TOUCHDOWN  		   = 02022022, " Team made a touchdown!\nRed Team Score: ";
IDMULT_FOOTY_BLUE_SCORE				   = 02022023, "Blue Team Score: ";
IDMULT_FOOTY_GAME_OVER			      = 02022024, "Game Over!";
IDMULT_FOOTY_WINS_THE_GAME		      = 02022025, " wins the game!";
IDMULT_FOOTY_FINAL_SCORES		      = 02022026, "Final Scores:";
IDMULT_FOOTY_END1					      = 02022027, " Team made a touchdown!\nRed Team Score: ";
IDMULT_FOOTY_END2					      = 02022028, " wins!!!\n\n";
IDMULT_FOOTY_END3					      = 02022029, "Congratulations to ";
IDMULT_FOOTY_END4					      = 02022030, "\nthis game's Most Valuable Player.";
IDMULT_FOOTY_TAKE_UPS			      = 02022031, "Take Ups";
IDMULT_FOOTY_TOUCHDOWNS			      = 02022032, "Touchdowns";
IDMULT_FOOTY_NUM_FUMBLES 		      = 02022033, "# of Fumbles";
IDMULT_FOOTY_HAS_THE_BALL		      = 02022034, " has the ball!";
IDMULT_FOOTY_HAS_BALL               = 02022035, "Ball Carrier";

IDMULT_AIR_CHINA					= 02022040, "Thank you for flying Inner Martian Airlines!";

IDMULT_RGN_END                      = 02099999, "";
      
      
      
      
      
      
      
      
       