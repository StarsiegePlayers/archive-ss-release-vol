#--------------------------------------------------------------------------------------------------------------------------------
#--------------------------------------------------------------------------------------------------------------------------------

$separator = "-----------------------";

#--------------------------------------------------------------------------------------------------------------------------------
#  To add commands to the Mission Editor's "Objects" menu
#
#  ME::RegisterObject menuCategory menuText consoleCommand
#  ME::RegisterObject menuCategory $separator
#  ME::RegisterObject $separator
#
#--------------------------------------------------------------------------------------------------------------------------------

ME::RegisterObject( Environment, Sky,                            ME::CreateObject, sky, SimSky );
ME::RegisterObject( Environment, Planet,                         ME::CreateObject, planet, SimPlanet, _B_O_G_U_S_, 0, 30, f, f, 1, 1, 1, 0, 0, 0  );
ME::RegisterObject( Environment, Stars,                          ME::CreateObject, starField, SimStarField );
ME::RegisterObject( Environment, Snowfall,                       ME::CreateObject, snowfall, Snowfall, 1, 0, 0, 0 );
ME::RegisterObject( Environment, Rain,                           ME::CreateObject, snowfall, Snowfall, 1, 0, 0, 1 );
ME::RegisterObject( Environment, $separator );
ME::RegisterObject( Environment, "ESPalette",                    ME::CreateObject, Palette, ESPalette );

#--------------------------------------------------------------------------------------------------------------------------------

ME::RegisterObject( "Mission Logic", "Sim Group",                 ME::CreateObject, Group, SimGroup );
ME::RegisterObject( "Mission Logic", "Sim Set",                   ME::CreateObject, Set, SimSet );
ME::RegisterObject( "Mission Logic", $separator );                 
ME::RegisterObject( "Mission Logic", "Shape Group",               ME::CreateObject, shapeGroup, SimShapeGroup );
ME::RegisterObject( "Mission Logic", "Shape Group Rep",           ME::CreateObject, shapeGroupRep_, ShapeGroupRep );
ME::RegisterObject( "Mission Logic", $separator );
ME::RegisterObject( "Mission Logic", "Camera Path Group",         ME::CreateObject, cameraPathGroup, SimCameraPathGroup );
ME::RegisterObject( "Mission Logic", "Camera Path Rep",           ME::CreateObject, cameraPathRep, SimCameraPathRep );
ME::RegisterObject( "Mission Logic", "Camera Waypoint",           ME::CreateObject, cameraWaypoint, SimCameraWaypoint );
ME::RegisterObject( "Mission Logic", $separator );
ME::RegisterObject( "Mission Logic", "Drop Point Group",          ME::CreateObject, DropPointGroup, ESDropPointGroup );
ME::RegisterObject( "Mission Logic", "Drop Point",                ME::CreateObject, dropPoint, SimDropPoint );
ME::RegisterObject( "Mission Logic", "Path Marker",               ME::CreateObject, marker, SimMarker );
ME::RegisterObject( "Mission Logic", "Navigation Point",          ME::CreateObject, navigationMarker, ESNavMarker );
ME::RegisterObject( "Mission Logic", $separator );
ME::RegisterObject( "Mission Logic", "Trigger",                   ME::CreateObject, trigger, SimTrigger );
ME::RegisterObject( "Mission Logic", "Magnet",                    ME::CreateObject, simMagnet, SimMagnet );
ME::RegisterObject( "Mission Logic", $separator );
ME::RegisterObject( "Mission Logic", "Sound Source",              ME::CreateObject, simSoundSource, SimSoundSource );
ME::RegisterObject( "Mission Logic", "Sound Cockpit",             ME::CreateObject, simSoundCockpit, SimSoundCockpit );

#--------------------------------------------------------------------------------------------------------------------------------
ME::RegisterObject( $separator );

ME::RegisterObject( "Terran Vehicles", "Terran Apocalypse",                ME::CreateObject, Herc, Herc, 1 );
ME::RegisterObject( "Terran Vehicles", "Terran Minotaur",                  ME::CreateObject, Herc, Herc, 2 );
ME::RegisterObject( "Terran Vehicles", "Terran Gorgon",                    ME::CreateObject, Herc, Herc, 3 );
ME::RegisterObject( "Terran Vehicles", "Terran Talon",                     ME::CreateObject, Herc, Herc, 4 );
ME::RegisterObject( "Terran Vehicles", "Terran Basilisk",                  ME::CreateObject, Herc, Herc, 5 );
ME::RegisterObject( "Terran Vehicles", "Paladin Tank",                     ME::CreateObject, Tank, Tank, 6 );
ME::RegisterObject( "Terran Vehicles", "Myrmidon Tank",                    ME::CreateObject, Tank, Tank, 7 );
ME::RegisterObject( "Terran Vehicles", "Disruptor Tank",                   ME::CreateObject, Tank, Tank, 8 );
ME::RegisterObject( "Terran Vehicles", "Nike Artillery",                   ME::CreateObject, Tank, Tank, 133 );
ME::RegisterObject( "Terran Vehicles", "Supressor Tank",                   ME::CreateObject, Tank, Tank, 134 );

ME::RegisterObject( "Terran Vehicles", "Banshee Flyer",                    ME::CreateObject, Flyer, Flyer, 9 );
ME::RegisterObject( "Terran Vehicles", "Cargo ship",                       ME::CreateObject, Flyer, Flyer, 18 );
ME::RegisterObject( "Terran Vehicles", "Escape ship",                      ME::CreateObject, Flyer, Flyer, 19 );
ME::RegisterObject( "Terran Vehicles", "Drop ship",                        ME::CreateObject, Flyer, Flyer, 130 );
ME::RegisterObject( "Terran Vehicles", "Draco Bomber",                     ME::CreateObject, Flyer, Flyer, 131 );
ME::RegisterObject( "Terran Vehicles", "Conveyor",                         ME::CreateObject, Flyer, Flyer, 132 );
 

ME::RegisterObject( "Knight Vehicles", "Knight's Apocalypse",             ME::CreateObject, Herc, Herc, 10 );
ME::RegisterObject( "Knight Vehicles", "Knight's Minotaur",               ME::CreateObject, Herc, Herc, 11 );
ME::RegisterObject( "Knight Vehicles", "Knight's Gorgon",                 ME::CreateObject, Herc, Herc, 12 );
ME::RegisterObject( "Knight Vehicles", "Knight's Talon",                  ME::CreateObject, Herc, Herc, 13 );
ME::RegisterObject( "Knight Vehicles", "Knight's Basilisk",               ME::CreateObject, Herc, Herc, 14 );
ME::RegisterObject( "Knight Vehicles", "Knight's Paladin",                ME::CreateObject, Tank, Tank, 15 );
ME::RegisterObject( "Knight Vehicles", "Knight's Myrmidon",               ME::CreateObject, Tank, Tank, 16 );
ME::RegisterObject( "Knight Vehicles", "Knight's Disruptor",              ME::CreateObject, Tank, Tank, 17 );
ME::RegisterObject( "Knight Vehicles", "Knight's Banshee",                ME::CreateObject, Flyer, Flyer, 110 );
ME::RegisterObject( "Knight Vehicles", "Knight's Drop Ship",              ME::CreateObject, Flyer, Flyer, 111 );


ME::RegisterObject( "Cybrid Vehicles", "Cybrid Seeker",                   ME::CreateObject, Herc, Herc, 20 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Goad",                     ME::CreateObject, Herc, Herc, 21 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Shepherd",                 ME::CreateObject, Herc, Herc, 22 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Adjudicator",              ME::CreateObject, Herc, Herc, 23 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Executioner",              ME::CreateObject, Herc, Herc, 24 );
ME::RegisterObject( "Cybrid Vehicles", "Bolo Tank",                       ME::CreateObject, Tank, Tank, 25 );
ME::RegisterObject( "Cybrid Vehicles", "Recluse Tank",                    ME::CreateObject, Tank, Tank, 26 );
ME::RegisterObject( "Cybrid Vehicles", "Platinum Adjudicator",            ME::CreateObject, Herc, Herc, 27 );
ME::RegisterObject( "Cybrid Vehicles", "Platinum Executioner",            ME::CreateObject, Herc, Herc, 28 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Artillery",                ME::CreateObject, Tank, Tank, 90 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Advocate",                 ME::CreateObject, Flyer, Flyer, 91 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Drop Ship",                ME::CreateObject, Flyer, Flyer, 92 );
ME::RegisterObject( "Cybrid Vehicles", "Cybrid Consul Bomber",            ME::CreateObject, Flyer, Flyer, 93 );


ME::RegisterObject( "Metagen Vehicles", "Metagen Seeker",                 ME::CreateObject, Herc, Herc, 35 );
ME::RegisterObject( "Metagen Vehicles", "Metagen Goad",                   ME::CreateObject, Herc, Herc, 36 );
ME::RegisterObject( "Metagen Vehicles", "Metagen Shepherd",               ME::CreateObject, Herc, Herc, 37 );
ME::RegisterObject( "Metagen Vehicles", "Metagen Adjudicator",            ME::CreateObject, Herc, Herc, 38 );
ME::RegisterObject( "Metagen Vehicles", "Metagen Executioner",            ME::CreateObject, Herc, Herc, 39 );


ME::RegisterObject( "Rebel Vehicles", "Rebel Emancipator",               ME::CreateObject, Herc, Herc, 30 );
ME::RegisterObject( "Rebel Vehicles", "Avenger Tank",                    ME::CreateObject, Tank, Tank, 31 );
ME::RegisterObject( "Rebel Vehicles", "Dreadnought Tank",                ME::CreateObject, Tank, Tank, 32 );
ME::RegisterObject( "Rebel Vehicles", "Rebel Olympian",                  ME::CreateObject, Herc, Herc, 33 );
ME::RegisterObject( "Rebel Vehicles", "Rebel Thumper",                   ME::CreateObject, Tank, Tank, 72 );
ME::RegisterObject( "Rebel Vehicles", "Rebel Artillery",                 ME::CreateObject, Tank, Tank, 137 );


ME::RegisterObject( "Special Vehicles", "Harabec's Apocalypse",            ME::CreateObject, Herc, Herc, 40 );
ME::RegisterObject( "Special Vehicles", "Harabec's Apocalypse, cin",      ME::CreateObject, Herc, Herc, 43 );
ME::RegisterObject( "Special Vehicles", "Harabec's Predator",              ME::CreateObject, Tank, Tank, 41 );
ME::RegisterObject( "Special Vehicles", "Harabec's Super Predator",        ME::CreateObject, Tank, Tank, 45 );
ME::RegisterObject( "Special Vehicles", "Caanan's Basilisk",               ME::CreateObject, Herc, Herc, 42 );
ME::RegisterObject( "Special Vehicles", "Caanan's Basilisk, cin",         ME::CreateObject, Herc, Herc, 44 );
ME::RegisterObject( "Special Vehicles", "Prometheus",                    ME::CreateObject, Herc, Herc, 29 );


ME::RegisterObject( "Pirate Vehicles", "Pirate's Apocalypse",            ME::CreateObject, Herc, Herc, 50 );
ME::RegisterObject( "Pirate Vehicles", "Pirate's Dreadlock",             ME::CreateObject, Tank, Tank, 51 );
ME::RegisterObject( "Pirate Vehicles", "Pirate's Emancipator",           ME::CreateObject, Herc, Herc, 52 );

ME::RegisterObject( "Drone Vehicles", "Terran Empty Cargo",               ME::CreateObject, Drone, Tank, 60 );
ME::RegisterObject( "Drone Vehicles", "Terran Ammo Cargo",                ME::CreateObject, Drone, Tank, 61 );
ME::RegisterObject( "Drone Vehicles", "Terran Big Ammo Cargo",            ME::CreateObject, Drone, Tank, 62 );
ME::RegisterObject( "Drone Vehicles", "Terran Big Personnel Cargo",       ME::CreateObject, Drone, Tank, 63 );
ME::RegisterObject( "Drone Vehicles", "Terran Fuel Cargo",                ME::CreateObject, Drone, Tank, 64 );
ME::RegisterObject( "Drone Vehicles", "Terran Minotaur Cargo",            ME::CreateObject, Drone, Tank, 65 );
ME::RegisterObject( "Drone Vehicles", "Terran Utility Truck",             ME::CreateObject, Drone, Tank, 71 );
ME::RegisterObject( "Drone Vehicles", "Terran Sovereign",                 ME::CreateObject, Tank, Tank, 135 );
ME::RegisterObject( "Drone Vehicles", "Terran Surveyor",                  ME::CreateObject, Tank, Tank, 136 );
ME::RegisterObject( "Drone Vehicles", "Terran Starefield",                ME::CreateObject, Tank, Tank,  73 );
ME::RegisterObject( "Drone Vehicles", "Rebel Empty Cargo",                ME::CreateObject, Drone, Tank, 66 );
ME::RegisterObject( "Drone Vehicles", "Rebel Ammo Cargo",                 ME::CreateObject, Drone, Tank, 67 );
ME::RegisterObject( "Drone Vehicles", "Rebel Big Cargo Transport",        ME::CreateObject, Drone, Tank, 68 );
ME::RegisterObject( "Drone Vehicles", "Rebel Bix Box Cargo Transport",    ME::CreateObject, Drone, Tank, 69 );
ME::RegisterObject( "Drone Vehicles", "Rebel Box Cargo Transport",        ME::CreateObject, Drone, Tank, 70 );
ME::RegisterObject( "Drone Vehicles", "Cybrid Omnicrawler",               ME::CreateObject, Drone, Tank, 94 );
ME::RegisterObject( "Drone Vehicles", "Cybrid Protector",                 ME::CreateObject, Drone, Tank, 95 );
ME::RegisterObject( "Drone Vehicles", "Cybrid Jamma",                     ME::CreateObject, Drone, Tank, 96 );

#--------------------------------------------------------------------------------------------------------------------------------
ME::RegisterObject( $separator );

#---Turrets-------------------
ME::RegisterObject( Turrets, "Cybrid Laser Turret",              ME::CreateObject, Turret_CY_LS, Turret, 1 );
ME::RegisterObject( Turrets, "Cybrid Missle Turret",             ME::CreateObject, Turret_CY_MS, Turret, 2 );
ME::RegisterObject( Turrets, $separator );
ME::RegisterObject( Turrets, "Mars Big Cannon",                  ME::CreateObject, Turret_H_CN,   Turret, 3 );
ME::RegisterObject( Turrets, "Moon Cannon",                      ME::CreateObject, Turret_M_CN,   Turret, 25 );
ME::RegisterObject( Turrets, "Trooper Cannon",                   ME::CreateObject, Turret_T_CN,   Turret, 26 );
ME::RegisterObject( Turrets, "Desert Cannon",                    ME::CreateObject, Turret_D_CN,   Turret, 31 );
ME::RegisterObject( Turrets, $separator );
ME::RegisterObject( Turrets, "Human Desert Laser Short",         ME::CreateObject, Turret_H_D_LS, Turret, 27 );
ME::RegisterObject( Turrets, "Human Desert Laser Tall",          ME::CreateObject, Turret_H_D_LS, Turret, 28 );
ME::RegisterObject( Turrets, "Human Earth Laser Short",          ME::CreateObject, Turret_H_E_LS, Turret, 4 );
ME::RegisterObject( Turrets, "Human Earth Laser Tall",           ME::CreateObject, Turret_H_E_LS, Turret, 5 );
ME::RegisterObject( Turrets, "Human Mars Laser Short",           ME::CreateObject, Turret_H_M_LS, Turret, 6 );
ME::RegisterObject( Turrets, "Human Mars Laser Tall",            ME::CreateObject, Turret_H_M_LS, Turret, 7 );
ME::RegisterObject( Turrets, "Human Moon Laser Short",           ME::CreateObject, Turret_H_M_LS, Turret, 8 );
ME::RegisterObject( Turrets, "Human Moon Laser Tall",            ME::CreateObject, Turret_H_M_LS, Turret, 9 );
ME::RegisterObject( Turrets, "Human Titan Laser Short",          ME::CreateObject, Turret_H_T_LS, Turret, 10 );
ME::RegisterObject( Turrets, "Human Titan Laser Tall",           ME::CreateObject, Turret_H_T_LS, Turret, 11 );
ME::RegisterObject( Turrets, "Human Venus Laser Short",          ME::CreateObject, Turret_H_V_LS, Turret, 12 );
ME::RegisterObject( Turrets, "Human Venus Laser Tall",           ME::CreateObject, Turret_H_V_LS, Turret, 13 );
ME::RegisterObject( Turrets, $separator );
ME::RegisterObject( Turrets, "Human Desert Missle Short",        ME::CreateObject, Turret_H_D_MS, Turret, 29 );
ME::RegisterObject( Turrets, "Human Desert Missle Tall",         ME::CreateObject, Turret_H_D_MS, Turret, 30 );
ME::RegisterObject( Turrets, "Human Earth Missle Short",         ME::CreateObject, Turret_H_E_MS, Turret, 14 );
ME::RegisterObject( Turrets, "Human Earth Missle Tall",          ME::CreateObject, Turret_H_E_MS, Turret, 15 );
ME::RegisterObject( Turrets, "Human Mars Missle Short",          ME::CreateObject, Turret_H_M_MS, Turret, 16 );
ME::RegisterObject( Turrets, "Human Mars Missle Tall",           ME::CreateObject, Turret_H_M_MS, Turret, 17 );
ME::RegisterObject( Turrets, "Human Moon Missle Short",          ME::CreateObject, Turret_H_M_MS, Turret, 18 );
ME::RegisterObject( Turrets, "Human Moon Missle Tall",           ME::CreateObject, Turret_H_M_MS, Turret, 19 );
ME::RegisterObject( Turrets, "Human Titan Missle Short",         ME::CreateObject, Turret_H_T_MS, Turret, 20 );
ME::RegisterObject( Turrets, "Human Titan Missle Tall",          ME::CreateObject, Turret_H_T_MS, Turret, 21 );
ME::RegisterObject( Turrets, "Human Venus Missle Short",         ME::CreateObject, Turret_H_V_MS, Turret, 22 );
ME::RegisterObject( Turrets, "Human Venus Missle Tall",          ME::CreateObject, Turret_H_V_MS, Turret, 23 );

ME::RegisterObject( Turrets, $separator );
ME::RegisterObject( Turrets, "Human Desert Laser Short Rearm",   ME::CreateObject, Turret_H_D_LS, Turret, 32 );
ME::RegisterObject( Turrets, "Human Titan Laser Short Rearm",    ME::CreateObject, Turret_H_D_LS, Turret, 34 );
ME::RegisterObject( Turrets, "Trooper Cannon Rearm",             ME::CreateObject, Turret_T_CN,   Turret, 35 );
ME::RegisterObject( Turrets, "Cybrid Laser Turret Rearm",        ME::CreateObject, Turret_CY_LS,  Turret, 33 );

#---CYBRID SHAPES----------------
ME::RegisterObject( $separator );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Bomberbay",         ME::CreateObject, cBomberBay,         StaticShape, true, "cBomberbay.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Comm",              ME::CreateObject, cComm,              StaticShape, true, "cComm.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Drop Pod",          ME::CreateObject, cDropPod,           StaticShape, true, "cDropPod.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Entrance",          ME::CreateObject, cEntrance,          StaticShape, true, "cEntrance.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Generator",         ME::CreateObject, cGenerator,         StaticShape, true, "cGenerator.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Motion Detector",   ME::CreateObject, cMotiondetector,    StaticShape, true, "cMotionDetector.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Nexus",             ME::CreateObject, cNexus,             StaticShape, true, "cNexus.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Perimeter",         ME::CreateObject, cPerimeter,         StaticShape, false, "cPerimeter.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Power",             ME::CreateObject, cPower,             StaticShape, true,  "cPower.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Relay Station",     ME::CreateObject, cRelay,             StaticShape, true,  "cRelay.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Search Array",      ME::CreateObject, cSearcharray,       StaticShape, true, "cSearchArray.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Storage",           ME::CreateObject, cStorage,           StaticShape, true, "cStorage.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Tracking",          ME::CreateObject, cTracking,          StaticShape, true, "cTracking.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Uplink",            ME::CreateObject, cUplink,            StaticShape, true, "cUplink.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Wall",              ME::CreateObject, cWall,              StaticShape, true, "cWall.dts" );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Temple Wall",       ME::CreateObject, cTempleWall,        StaticShape, true, "cTempleWall.dts" );
ME::RegisterObject( "Cybrid Shapes", "Prometheus' Hut(ZED)",     ME::CreateObject, cTemple,            StaticShape, true, "cTemple.dts" );
ME::RegisterObject( "Cybrid Shapes", $separator );
ME::RegisterObject( "Cybrid Shapes", "Beacon         (ZED)",     ME::CreateObject, cbeacon,            StaticInterior, "cBeacon.dis" );
ME::RegisterObject( "Cybrid Shapes", "Landing Pad    (ZED)",     ME::CreateObject, clandpad,           StaticInterior, "clandpad.dis" );
ME::RegisterObject( "Cybrid Shapes", "Large Platform (ZED)",     ME::CreateObject, cbrid_p1,           StaticInterior, "cbrid_p1.dis" );
ME::RegisterObject( "Cybrid Shapes", "Prometheus Base(ZED)",     ME::CreateObject, cprombase,          StaticInterior, "cPromBase.dis" );
ME::RegisterObject( "Cybrid Shapes", "Small Platform (ZED)",     ME::CreateObject, cbrid_p2,           StaticInterior, "cbrid_p2.dis" );
ME::RegisterObject( "Cybrid Shapes", "Silo           (ZED)",     ME::CreateObject, csilo,              StaticInterior, "csilo.dis" );
ME::RegisterObject( "Cybrid Shapes", "Silo Platform  (ZED)",     ME::CreateObject, csilo_p1,           StaticInterior, "csilo_p1.dis" );
ME::RegisterObject( "Cybrid Shapes", "Tunnels        (ZED)",     ME::CreateObject, cbrid,              StaticInterior, "cbrid.dis" );
ME::RegisterObject( "Cybrid Shapes", $separator );
ME::RegisterObject( "Cybrid Shapes", "Cybrid Tower 1",           ME::CreateObject, cbig1,              StaticInterior, "cbig1.dis");



#---DESERT EARTH SHAPES---------
ME::RegisterObject( "Desert Shapes", "Desert Big Dish",          ME::CreateObject, hDesertBigDish,     StaticShape, true, "hDesertBigDish.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Church",            ME::CreateObject, hDesertchurch,      StaticShape, true, "hDesertchurch.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Defense",           ME::CreateObject, hDesertDefense,     StaticShape, true, "hDesertDefense.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Dwelling",          ME::CreateObject, hDesertdwelling,    StaticShape, true, "hDesertdwelling.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Garage",            ME::CreateObject, hDesertgarage,      StaticShape, true, "hDesertgarage.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Gathering",         ME::CreateObject, hDesertgathering,   StaticShape, true, "hDesertgathering.dts" );
ME::RegisterObject( "Desert Shapes", "Desert LandMine",          ME::CreateObject, hDesertMine,        StaticShape, true, "hDesertMine.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Power",             ME::CreateObject, hDesertpower,       StaticShape, true, "hDesertpower.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Silo",              ME::CreateObject, hDesertsilo,        StaticShape, true, "hDesertsilo.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Sludge",            ME::CreateObject, hDesertsludge,      StaticShape, true, "hDesertsludge.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Uplink",            ME::CreateObject, hDesertuplink,      StaticShape, true, "hDesertuplink.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Vapor",             ME::CreateObject, hDesertvapor,       StaticShape, true, "hDesertvapor.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Water Tower",       ME::CreateObject, hDesertWaterTower,  StaticShape, true, "hDesertWaterTower.dts" );
ME::RegisterObject( "Desert Shapes", $separator);
ME::RegisterObject( "Desert Shapes", "Desert Troop Barracks",    ME::CreateObject, hDesertTroopBarracks,       StaticShape, true, "hDesertTroopBarracks.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Troop Barracks, sm", ME::CreateObject, hDesertSmallTroopBarracks,  StaticShape, true, "hDesertSmallTroopBarracks.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Troop Com, sm",      ME::CreateObject, hDesertSmallTroopCom,   StaticShape, true, "hDesertSmallTroopCom.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Troop Garage",      ME::CreateObject, hDesertTroopGarage,     StaticShape, true, "hDesertTroopGarage.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Troop Hall",        ME::CreateObject, hDesertTroopHall,       StaticShape, true, "hDesertTroopHall.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Troop HQ, sm",      ME::CreateObject, hDesertSmallTroopHQ,    StaticShape, true, "hDesertSmallTroopHQ.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Pillar1",           ME::CreateObject, hdesertpillar1,         StaticShape, true, "hdesertpillar_1.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Pillar2",           ME::CreateObject, hdesertpillar2,         StaticShape, true, "hdesertpillar_2.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Pillar3",           ME::CreateObject, hdesertpillar3,         StaticShape, true, "hdesertpillar_3.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Pillar4",           ME::CreateObject, hdesertpillar4,         StaticShape, true, "hdesertpillar_4.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Pillar5",           ME::CreateObject, hdesertpillar5,         StaticShape, true, "hdesertpillar_5_tall.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Pillar6",           ME::CreateObject, hdesertpillar6,         StaticShape, true, "hdesertpillar_6_tall.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Altar",             ME::CreateObject, hdesertaltar,           StaticShape, true, "hdesertpillar_altar.dts" );
ME::RegisterObject( "Desert Shapes", "Desert Hall",              ME::CreateObject, hdeserthall,            StaticShape, true, "hdesertpillar_hall.dts" );

ME::RegisterObject( "Desert Shapes", $separator);
ME::RegisterObject( "Desert Shapes", "Pyramid 1(ZED)",           ME::CreateObject, hpyramid,           StaticInterior, "hpyramid.dis" );
ME::RegisterObject( "Desert Shapes", "Pyramid 2(ZED)",           ME::CreateObject, hpyramid2,          StaticInterior, "hpyramid2.dis" );
ME::RegisterObject( "Desert Shapes", "Pyramid 3(ZED)",           ME::CreateObject, hpyramid3,          StaticInterior, "hpyramid3.dis" );
ME::RegisterObject( "Desert Shapes", $separator);
ME::RegisterObject( "Desert Shapes", "Desert Tower 1",    ME::CreateObject, hbigsand1m,	       StaticInterior, "hbigsand1d.dis");
ME::RegisterObject( "Desert Shapes", "Desert Tower 2",    ME::CreateObject, hbigsand2m,	       StaticInterior, "hbigsand2d.dis");
ME::RegisterObject( "Desert Shapes", "Desert Tower 3",    ME::CreateObject, hbigsand3m,	       StaticInterior, "hbigsand3d.dis");
ME::RegisterObject( "Desert Shapes", "Desert Tower 4",    ME::CreateObject, hbigsand4m,	       StaticInterior, "hbigsand4d.dis");
ME::RegisterObject( "Desert Shapes", "Desert Tower 5",    ME::CreateObject, hbigsand5m,	       StaticInterior, "hbigsand5d.dis");
ME::RegisterObject( "Desert Shapes", "Desert Tower 6",    ME::CreateObject, hbigsand6m,	       StaticInterior, "hbigsand6d.dis");
ME::RegisterObject( "Desert Shapes", "Desert Ruins 1",    ME::CreateObject, hruinsd1,	           StaticInterior, "hruinsd1.dis");
ME::RegisterObject( "Desert Shapes", "Desert Ruins 2",    ME::CreateObject, hruinsd2,	           StaticInterior, "hruinsd2.dis");
ME::RegisterObject( "Desert Shapes", "Desert Ruins 3",    ME::CreateObject, hruinsd3,	           StaticInterior, "hruinsd3.dis");
ME::RegisterObject( "Desert Shapes", "Desert Ruins 4",    ME::CreateObject, hruinsd4,	           StaticInterior, "hruinsd4.dis");



#---GENERIC EARTH SHAPES----
ME::RegisterObject( "Earth Shapes", "Troop Barracks",            ME::CreateObject, hTroopbarracks,     StaticShape, true, "hTroopbarracks.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Barracks, Small",     ME::CreateObject, hTroopbarrackssm,   StaticShape, true, "hTroopbarrackssm.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Bigdish",             ME::CreateObject, hTroopbigdish,      StaticShape, true, "hTroopbigdish.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Comm",                ME::CreateObject, hTroopcomm,         StaticShape, true, "hTroopcomm.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Energy Projector",    ME::CreateObject, htroop_orbital_power,   StaticShape, true, "htroop_orbital_power.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Garage",              ME::CreateObject, hTroopgarage,       StaticShape, true, "hTroopgarage.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Garage, Small",       ME::CreateObject, hTroopgaragesm,     StaticShape, true, "hTroopgaragesm.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Generator",           ME::CreateObject, hTroopgenerator,    StaticShape, true, "hTroopgenerator.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Hall",                ME::CreateObject, hTroophall,         StaticShape, true, "hTroophall.dts" );
ME::RegisterObject( "Earth Shapes", "Troop HQ",                  ME::CreateObject, hTroophq,           StaticShape, true, "hTroophq.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Listen",              ME::CreateObject, hTrooplisten,       StaticShape, true, "hTrooplisten.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Power",               ME::CreateObject, hTrooppower,        StaticShape, true, "hTrooppower.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Supply",              ME::CreateObject, hTroopsupply,       StaticShape, true, "hTroopsupply.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Supply Dump",         ME::CreateObject, hTroop_supply_dump, StaticShape, true, "hTroop_supply_dump.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Trackbase",           ME::CreateObject, hTrooptrackbase,    StaticShape, true, "hTrooptrackbase.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Trackdish",           ME::CreateObject, hTrooptrackdish,    StaticShape, true, "hTrooptrackdish.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Uplink",              ME::CreateObject, hTroopuplink,       StaticShape, true, "hTroopuplink.dts" );
ME::RegisterObject( "Earth Shapes", "Troop Planet Defense",      ME::CreateObject, hTroopPlanetDefense,    StaticShape, true, "hTroopPlanetDefense.dts" );
ME::RegisterObject( "Earth Shapes", $separator);
ME::RegisterObject( "Earth Shapes", "Bridge           (ZED)",     ME::CreateObject, hbridgee,           StaticInterior, "hbridgee.dis" );
ME::RegisterObject( "Earth Shapes", "Garage           (ZED)",     ME::CreateObject, hgaragee,           StaticInterior, "hgaragee.dis" );
ME::RegisterObject( "Earth Shapes", "Landing Pad      (ZED)",     ME::CreateObject, hlandpade,          StaticInterior, "hlandpade.dis" );
ME::RegisterObject( "Earth Shapes", "Landpad Platform (ZED)",     ME::CreateObject, hlandpade_p1,       StaticInterior, "hlandpade_p1.dis" );
ME::RegisterObject( "Earth Shapes", "Hangar           (ZED)",     ME::CreateObject, hhangare,           StaticInterior, "hhangare.dis" );
ME::RegisterObject( "Earth Shapes", "Hangar Platform  (ZED)",     ME::CreateObject, hhangare_p1,        StaticInterior, "hhangare_p1.dis" );
ME::RegisterObject( "Earth Shapes", "Airport          (ZED)",     ME::CreateObject, hairporte,          StaticInterior, "hairporte.dis" );
ME::RegisterObject( "Earth Shapes", "Airport Platform (ZED)",     ME::CreateObject, hairporte_p1,       StaticInterior, "hairporte_p1.dis" );
ME::RegisterObject( "Earth Shapes", "Huge Wall        (ZED)",     ME::CreateObject, hwallhuge,          StaticInterior, "hwallhuge.dis" );

#---EUROPA SHAPES------------
ME::RegisterObject( "Europa Shapes", "Europa Rock2",          ME::CreateObject, xeuroparock2,       StaticShape, "xeuroparock02.dts" );
ME::RegisterObject( "Europa Shapes", "Europa Rock3",          ME::CreateObject, xeuroparock3,       StaticShape, "xeuroparock03.dts" );
ME::RegisterObject( "Europa Shapes", $separator);
ME::RegisterObject( "Europa Shapes", "Heal (ZED)", 			ME::CreateObject, hheale,       	StaticInterior, "hheale.dis" );
ME::RegisterObject( "Europa Shapes", "Ammo (ZED)", 			ME::CreateObject, hammoe,       	StaticInterior, "hammoe.dis" );
ME::RegisterObject( "Europa Shapes", "Trooper Hanger (ZED)", 	ME::CreateObject, hTroophouseE,	StaticInterior, "hTroophouseE.dis" );
ME::RegisterObject( "Europa Shapes", "Ruins1 (ZED)", 	        ME::CreateObject, hRuinsT,	    StaticInterior, "hRuinsT.dis" );
ME::RegisterObject( "Europa Shapes", "Ruins2 (ZED)", 	        ME::CreateObject, hRuinsT2,	    StaticInterior, "hRuinsT2.dis" );
ME::RegisterObject( "Europa Shapes", "Ruins3 (ZED)", 	        ME::CreateObject, hRuinsT3,	    StaticInterior, "hRuinsT3.dis" );


#---SNOW SHAPES--------------
ME::RegisterObject( "Ice Shapes", "Office",                      ME::CreateObject, hOffice,            StaticShape, true, "hOffice.dts" );
ME::RegisterObject( "Ice Shapes", "Solar Station",               ME::CreateObject, hSnowSolar,         StaticShape, true, "hSolarStation.dts" );
ME::RegisterObject( "Ice Shapes", "Gathering Hall",              ME::CreateObject, hSnowGath,          StaticShape, true, "hSnowGathering.dts" );
ME::RegisterObject( "Ice Shapes", "Snowlland",                   ME::CreateObject, hSnowLand,          StaticShape, true, "hSnowlland.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Church",                 ME::CreateObject, hSnowChurch,        StaticShape, true, "hSnowChurch.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Com",                    ME::CreateObject, hSnowCom,           StaticShape, true, "hSnowCom.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Residence",              ME::CreateObject, hSnowRes,           StaticShape, true, "hSnowResidence.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Storage",                ME::CreateObject, hSnowStor,          StaticShape, true, "hSnowStorage.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Uplink",                 ME::CreateObject, hSnowUplink,        StaticShape, true, "hSnowUplink.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Rock1",                  ME::CreateObject, hSnowRock1,         StaticShape, false,"xSnowRock1.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Rock2",                  ME::CreateObject, hSnowRock2,         StaticShape, false,"xSnowRock2.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Rock3",                  ME::CreateObject, hSnowRock3,         StaticShape, false,"xSnowRock3.dts" );
ME::RegisterObject( "Ice Shapes", "Snow Tree",                   ME::CreateObject, hTree,              StaticShape, false,"xTree.dts" );
ME::RegisterObject( "Ice Shapes", "SnowMan",                     ME::CreateObject, hSnowMan,           StaticShape, false,"xSnowMan.dts" );
ME::RegisterObject( "Ice Shapes", $separator );
ME::RegisterObject( "Ice Shapes", "Airport     (ZED)",           ME::CreateObject, hairporta,          StaticInterior, "hairporta.dis" );
ME::RegisterObject( "Ice Shapes", "Gate        (ZED)",           ME::CreateObject, hgatea,             StaticInterior, "hgatea.dis" );
ME::RegisterObject( "Ice Shapes", "Landing Pad (ZED)",           ME::CreateObject, hlandpada,          StaticInterior, "hlandpada.dis" );
ME::RegisterObject( "Ice Shapes", "Pad Office  (ZED)",           ME::CreateObject, hpadofficea,        StaticInterior, "hpadofficea.dis" );
ME::RegisterObject( "Ice Shapes", "Heal Pad    (ZED)",           ME::CreateObject, hheal2a,            StaticInterior, "hheal2a.dis" );
ME::RegisterObject( "Ice Shapes", "Reload Pad  (ZED)",           ME::CreateObject, hammo2a,            StaticInterior, "hammo2a.dis" );
ME::RegisterObject( "Ice Shapes", "Heal        (ZED)",           ME::CreateObject, hheal2a,       StaticInterior, "hheal2a.dis" );
ME::RegisterObject( "Ice Shapes", "Ammo        (ZED)",           ME::CreateObject, hammo2a,       StaticInterior, "hammo2a.dis" );

#---MARS SHAPES (A-N) ---------------
ME::RegisterObject( "Mars Shapes A-N", "Atmosphere",             ME::CreateObject, hAtmos,             StaticShape, true, "hAtmos.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Barracks",               ME::CreateObject, hMarsBarracks,      StaticShape, true, "hMarsBarracks.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Crane",                  ME::CreateObject, hCrane,             StaticShape, true, "hCrane.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Civilian Garage",        ME::CreateObject, hMarsCivGarage,     StaticShape, true, "hMarsCivGarage.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Comm Tower",             ME::CreateObject, hMarsCommTower,     StaticShape, true, "hMarsCommTower.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Farm House",             ME::CreateObject, hMarsFarmHouse,     StaticShape, true, "hMarsFarmHouse.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Fertillizer",            ME::CreateObject, hFertillizer,       StaticShape, true, "hFertillizer.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Fusion Reactor",         ME::CreateObject, hMarsFusionReactor, StaticShape, true, "hMarsFusionReactor.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Garage",                 ME::CreateObject, hGarage,            StaticShape, true, "hGarage.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Hanger",                 ME::CreateObject, hMarsHanger,        StaticShape, true, "hMarsHanger.dts" );
ME::RegisterObject( "Mars Shapes A-N", "LandMine",               ME::CreateObject, hMarsMine,          StaticShape, true, "hMarsMine.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Mass Driver",            ME::CreateObject, hMarsMassDriver,    StaticShape, true, "hMarsMassDriver.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Meeting Hall",           ME::CreateObject, hMeethall,          StaticShape, true, "hMeethall.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Mine Train",             ME::CreateObject, hMarsMineTrain,     StaticShape, true, "hMarsMineTrain.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Mine Train Cargo",       ME::CreateObject, hMarsMineTrain_cargo,     StaticShape, true, "hMarsMineTrain_cargo.dts" );
ME::RegisterObject( "Mars Shapes A-N", "Monument",               ME::CreateObject, XMonument,          StaticShape, true,"xMonument.dts" );

#---MARS SHAPES (P-Z) ---------------
ME::RegisterObject( "Mars Shapes P-Z", "Perimeter Fence",            ME::CreateObject, hPerimeter,         StaticShape, true, "hPerimeter.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "PileDriver",                 ME::CreateObject, hMarsPileDriver,    StaticShape, true, "hMarsPiledriver.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Police Flag",            	   ME::CreateObject, xMarsFlag_Police,   StaticShape, true, "xMarsFlag_Police.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Police (FIN)",               ME::CreateObject, hPolicefin,         StaticShape, true, "hPolicefin.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Police (HQ)",                ME::CreateObject, hPolicehq,          StaticShape, true, "hPolicehq.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Power (FIN)",                ME::CreateObject, hPowerfin,          StaticShape, true, "hPowerfin.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Rebel Flag",            	   ME::CreateObject, xMarsFlag_Rebel,    StaticShape, true, "xMarsFlag_Rebel.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Refinery",                   ME::CreateObject, hRefinery,          StaticShape, true, "hRefinery.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Residential Big",            ME::CreateObject, hMarsResidentialBig,    StaticShape, true, "hMarsResidentialBig.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Residential Small",          ME::CreateObject, hMarsResidentialSmall,  StaticShape, true, "hMarsResidentialSmall.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Residential Small NODOOR",   ME::CreateObject, hMarsResidentialSmall_NODOOR,  StaticShape, true, "hMarsResidentialSmall_NODOOR.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "StreetLight",            	   ME::CreateObject, hMarsStreetlight,   StaticShape, true, "hMarsStreetlight.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Supply Dump",                ME::CreateObject, hMarsSupplyDump ,   StaticShape, true, "hMarsSupplyDump.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Tracking Station",           ME::CreateObject, hTracking,          StaticShape, true, "hTracking.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Water Tower",                ME::CreateObject, hMarsWaterTower,        StaticShape, true, "hMarsWaterTower.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Water Converter",            ME::CreateObject, hMarsWaterConverter,    StaticShape, true, "hMarsWaterConverter.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Uplink Station",             ME::CreateObject, hUplink,            StaticShape, true, "hUplink.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Wall (NORMAL)",              ME::CreateObject, hWall,              StaticShape, true,"hWall.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Big Wall 1",            	   ME::CreateObject, hMarsBigWall_1,     StaticShape, true, "hMarsBigWall_1.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Big Wall 2",            	   ME::CreateObject, hMarsBigWall_2,     StaticShape, true, "hMarsBigWall_2.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Big Wall 3",            	   ME::CreateObject, hMarsBigWall_3,     StaticShape, true, "hMarsBigWall_3.dts" );
ME::RegisterObject( "Mars Shapes P-Z", $separator);
ME::RegisterObject( "Mars Shapes P-Z", "Mars Rock, 1",               ME::CreateObject, xMarsrock1,         StaticShape, false,"xMarsrock1.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Mars Rock, 2",               ME::CreateObject, xMarsrock2,         StaticShape, false,"xMarsrock2.dts" );
ME::RegisterObject( "Mars Shapes P-Z", "Mars Rock, 3",               ME::CreateObject, xMarsrock3,         StaticShape, false,"xMarsrock3.dts" );

#--Mars Interior Shapes
ME::RegisterObject( "Mars Interior Shapes", "Bridge, sm",         ME::CreateObject, hbridge2m,          StaticInterior, "hbridge2m.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Bridge, lg",         ME::CreateObject, hbridgem,           StaticInterior, "hbridgem.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Bridge, post",          ME::CreateObject, hbridgepostm,       StaticInterior, "hbridgepostm.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Garage",               ME::CreateObject, hgaragem,           StaticInterior, "hgaragem.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Hangar ",              ME::CreateObject, hhangarm,           StaticInterior, "hhangarm.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Landing Pad       ",   ME::CreateObject, hLandPadM,	       StaticInterior, "hLandPadM.dis");
ME::RegisterObject( "Mars Interior Shapes", "Landing Pad, lg ",   ME::CreateObject, hLandPad2M,	       StaticInterior, "hLandPad2M.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mass Platform     ",   ME::CreateObject, hmassplatm,	       StaticInterior, "hmassplatm.dis");
ME::RegisterObject( "Mars Interior Shapes", "Platform" ,            ME::CreateObject, hplatformm,         StaticInterior, "hplatformm.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Quarry ",              ME::CreateObject, hquarrym,           StaticInterior, "hquarrym.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Heal Pad ",            ME::CreateObject, hheal2m,            StaticInterior, "hheal2m.dis" );
ME::RegisterObject( "Mars Interior Shapes", "Ammo Pad ",            ME::CreateObject, hammo2m,            StaticInterior, "hammo2m.dis" );
ME::RegisterObject( "Mars Interior Shapes", $separator );
ME::RegisterObject( "Mars Interior Shapes", "Fertillizer Ruin1 ",   ME::CreateObject, hfertruinm,	       StaticInterior, "hfertruinm.dis");
ME::RegisterObject( "Mars Interior Shapes", "Fertillizer Ruin2 ",   ME::CreateObject, hfertruin2m,        StaticInterior, "hfertruin2m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Fertillizer Ruin3 ",   ME::CreateObject, hfertruin3m,	       StaticInterior, "hfertruin3m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Building Ruin1 ",   ME::CreateObject, hruinsm,	       	   StaticInterior, "hRuinsM.dis");
ME::RegisterObject( "Mars Interior Shapes", "Building Ruin2 ",   ME::CreateObject, hruinsm2,	       StaticInterior, "hRuinsM2.dis");
ME::RegisterObject( "Mars Interior Shapes", "Building Ruin3 ",   ME::CreateObject, hruinsm3,	       StaticInterior, "hRuinsM3.dis");
ME::RegisterObject( "Mars Interior Shapes", "Building Ruin4 ",   ME::CreateObject, hruinsm4,	       StaticInterior, "hRuinsM4.dis");
ME::RegisterObject( "Mars Interior Shapes", "Building Ruin6 ",   ME::CreateObject, hruinsm6,	       StaticInterior, "hRuinsM6.dis");
ME::RegisterObject( "Mars Interior Shapes", $separator );
ME::RegisterObject( "Mars Interior Shapes", "Big House  ",   ME::CreateObject, hbighousem,	       StaticInterior, "hbighousem.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Hump   ",   ME::CreateObject, hBigHumpm,	       StaticInterior, "hbighumpm.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big House2 ",   ME::CreateObject, hbighouse2m,	       StaticInterior, "hbighouse2m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Gully  ",   ME::CreateObject, hBigGullym,	       StaticInterior, "hBigGullym.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Cargo  ",   ME::CreateObject, hBigCargom,	       StaticInterior, "hBigCargom.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Wall   ",   ME::CreateObject, hbigwall1m,	       StaticInterior, "hbigwall1m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Ammo   ",   ME::CreateObject, hBigAmmo,	       StaticInterior, "hBigAmmo.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Healing",   ME::CreateObject, hBigHealing,	       StaticInterior, "hBigHealing.dis");
ME::RegisterObject( "Mars Interior Shapes", "Big Mole   ",         ME::CreateObject, hBigMolem,	       StaticInterior, "hbigmolem.dis");
ME::RegisterObject( "Mars Interior Shapes", $separator );
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower 1",        ME::CreateObject, hbigmars1m,	       StaticInterior, "hbigmars1m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower 2",        ME::CreateObject, hbigmars2m,	       StaticInterior, "hbigmars2m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower 3",        ME::CreateObject, hbigmars3m,	       StaticInterior, "hbigmars3m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower 4",        ME::CreateObject, hbigmars4m,	       StaticInterior, "hbigmars4m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower 5",        ME::CreateObject, hbigmars5m,	       StaticInterior, "hbigmars5m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower 6",        ME::CreateObject, hbigmars6m,	       StaticInterior, "hbigmars6m.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower Ruin 2",        ME::CreateObject, hbigmars2mruin,	       StaticInterior, "hbigmars2mruin.dis");
ME::RegisterObject( "Mars Interior Shapes", "Mars Tower Ruin 3",        ME::CreateObject, hbigmars3mruin,	       StaticInterior, "hbigmars3mruin.dis");



#---MERCURY SHAPES------------
ME::RegisterObject( "Mercury Shapes", "Mercury LandMine",        ME::CreateObject, hMercuryMine,       StaticShape, true, "hMercuryMine.dts" );
ME::RegisterObject( "Mercury Shapes", "Mercury Rock1",           ME::CreateObject, xmercuryrock1,      StaticShape, false,"xmercuryrock01.dts" );
ME::RegisterObject( "Mercury Shapes", "Mercury Rock2",           ME::CreateObject, xmercuryrock2,      StaticShape, false,"xmercuryrock02.dts" );
ME::RegisterObject( "Mercury Shapes", "Mercury Rock3",           ME::CreateObject, xmercuryrock3,      StaticShape, false,"xmercuryrock03.dts" );

#---MOON SHAPES--------------
ME::RegisterObject( "Moon Shapes", "Moon Barracks",              ME::CreateObject, hMoonbarracks,      StaticShape, true, "hMoonbarracks.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Bigdish",               ME::CreateObject, hMoonbigdish,       StaticShape, true, "hMoonbigdish.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Gather",                ME::CreateObject, hMoongather,        StaticShape, true, "hMoongather.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Generator",             ME::CreateObject, hMoongenerator,     StaticShape, true, "hMoongenerator.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Listen",                ME::CreateObject, hMoonlisten,        StaticShape, true, "hMoonlisten.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Power",                 ME::CreateObject, hMoonpower,         StaticShape, true, "hMoonpower.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Refinery",              ME::CreateObject, hMoonrefinery,      StaticShape, true, "hMoonrefinery.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Residence",             ME::CreateObject, hMoonresidence,     StaticShape, true, "hMoonresidence.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Silos",                 ME::CreateObject, hMoonsilos,         StaticShape, true, "hMoonsilos.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Uplink",                ME::CreateObject, hMoonuplink,        StaticShape, true, "hMoonuplink.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Wall",                  ME::CreateObject, hMoonwall,          StaticShape, false,"hMoonwall.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Wallcap",               ME::CreateObject, hMoonwallcap,       StaticShape, false,"hMoonwallcap.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Walldoor",              ME::CreateObject, hMoonwalldoor,      StaticShape, false,"hMoonwalldoor.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Planet Defense",        ME::CreateObject, hMoonPlanetDefense, StaticShape, true, "hMoonPlanetDefense.dts" );
ME::RegisterObject( "Moon Shapes", $separator );
ME::RegisterObject( "Moon Shapes", "Moon Trooper Com",           ME::CreateObject, hMoonCom,           StaticShape, true, "hMoontroopercom.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Trooper HQ",            ME::CreateObject, hMoonHQ,            StaticShape, true, "hMoontrooperhq.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Trooper Silos",         ME::CreateObject, hMoonSilos,         StaticShape, true, "hMoontroopersilos.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Trooper Storage",       ME::CreateObject, hMoonStorage,       StaticShape, true, "hMoontrooperstorage.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Trooper Tracking",      ME::CreateObject, hMoontracking,      StaticShape, true, "hMoontrooptracking.dts" );
ME::RegisterObject( "Moon Shapes", $separator );
ME::RegisterObject( "Moon Shapes", "Landing Pad  (ZED)",         ME::CreateObject, hlandpadl,          StaticInterior, "hlandpadl.dis" );
ME::RegisterObject( "Moon Shapes", "Mine Hallway (ZED)",         ME::CreateObject, hminel,             StaticInterior, "hminel.dis" );
ME::RegisterObject( "Moon Shapes", "Mine Lift    (ZED)",         ME::CreateObject, hmineliftl,         StaticInterior, "hmineliftl.dis" );
ME::RegisterObject( "Moon Shapes", "Silo         (ZED)",         ME::CreateObject, hsilol,             StaticInterior, "hsilol.dis" );
ME::RegisterObject( "Moon Shapes", "Spaceport    (ZED)",         ME::CreateObject, hlunaport,          StaticInterior, "hlunaport.dis" );
ME::RegisterObject( "Moon Shapes", $separator );
ME::RegisterObject( "Moon Shapes", "Moon Tower 1 (ZED)",         ME::CreateObject, hbigluna1,          StaticInterior, "hbigluna1.dis" );
ME::RegisterObject( "Moon Shapes", "Moon Tower 2 (ZED)",         ME::CreateObject, hbigluna2,          StaticInterior, "hbigluna2.dis" );
ME::RegisterObject( "Moon Shapes", "Moon Tower 3 (ZED)",         ME::CreateObject, hbigluna3,          StaticInterior, "hbigluna3.dis" );
ME::RegisterObject( "Moon Shapes", "Moon Tower 4 (ZED)",         ME::CreateObject, hbigluna4,          StaticInterior, "hbigluna4.dis" );
ME::RegisterObject( "Moon Shapes", "Moon Tower 5 (ZED)",         ME::CreateObject, hbigluna5,          StaticInterior, "hbigluna5.dis" );
ME::RegisterObject( "Moon Shapes", "Moon Tower 6 (ZED)",         ME::CreateObject, hbigluna6,          StaticInterior, "hbigluna6.dis" );
ME::RegisterObject( "Moon Shapes", $separator );
ME::RegisterObject( "Moon Shapes", "Moon Rock1",                 ME::CreateObject, xmoonrock1,         StaticShape, false,"xmoonrock01.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Rock2",                 ME::CreateObject, xmoonrock2,         StaticShape, false,"xmoonrock02.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Rock3",                 ME::CreateObject, xmoonrock3,         StaticShape, false,"xmoonrock03.dts" );
ME::RegisterObject( "Moon Shapes", $separator );
ME::RegisterObject( "Moon Shapes", "Apollo",                       ME::CreateObject, xApollo,          StaticShape, true, "xApollo.dts" );
ME::RegisterObject( "Moon Shapes", "Moon Flag",                  ME::CreateObject, xMoonflag,          StaticShape, false,"xMoonflag.dts" );

#---PLUTO SHAPES------------
ME::RegisterObject( "Pluto Shapes", "Pluto Rock1",               ME::CreateObject, xplutorock1,        StaticShape, false,"xplutorock01.dts" );
ME::RegisterObject( "Pluto Shapes", "Pluto Rock2",               ME::CreateObject, xplutorock2,        StaticShape, false,"xplutorock02.dts" );
ME::RegisterObject( "Pluto Shapes", "Pluto Rock3",               ME::CreateObject, xplutorock3,        StaticShape, false,"xplutorock03.dts" );

#---TEMPERATE SHAPES---------
ME::RegisterObject( "Temperate Shapes", "Kong Civil",            ME::CreateObject, hKongcivil,         StaticShape, true, "hKongcivil.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Gate",             ME::CreateObject, hKonggate,          StaticShape, true, "hKonggate.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Gathering",        ME::CreateObject, hKonggathering,     StaticShape, true, "hKonggathering.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong House",            ME::CreateObject, hKonghouse,         StaticShape, true, "hKonghouse.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Deck House",       ME::CreateObject, hKongdeckhouse,     StaticShape, true, "hKongdeckhouse.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Office",           ME::CreateObject, hKongoffice,        StaticShape, true, "hKongoffice.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Pagoda",           ME::CreateObject, hKongpagoda,        StaticShape, true, "hKongpagoda.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Sludge",           ME::CreateObject, hKongsludge,        StaticShape, true, "hKongsludge.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong Temple",           ME::CreateObject, hKongtemple,        StaticShape, true, "hKongtemple.dts" );
ME::RegisterObject( "Temperate Shapes", "Kong High Temple",      ME::CreateObject, hKonglgtemple,      StaticShape, true, "hKonglgtemple.dts" );
ME::RegisterObject( "Temperate Shapes", $separator );
ME::RegisterObject( "Temperate Shapes", "Hong Temple (ZED)",	   ME::CreateObject, hHongTemple,		StaticInterior, "hHongTemple.dis" );
ME::RegisterObject( "Temperate Shapes", "Kong Heal   (ZED)",	   ME::CreateObject, heal,				StaticInterior, "hkongheal.dis" );
ME::RegisterObject( "Temperate Shapes", "Kong Reload (ZED)",	   ME::CreateObject, reload,				StaticInterior, "hkongammo.dis" );
ME::RegisterObject( "Temperate Shapes", $separator );
ME::RegisterObject( "Temperate Shapes", "Kong Tower 1",          ME::CreateObject, hbigkong1t,	       StaticInterior,  "hbigkong1t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Tower 2",          ME::CreateObject, hbigkong2t,	       StaticInterior,  "hbigkong2t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Tower 3",          ME::CreateObject, hbigkong3t,	       StaticInterior,  "hbigkong3t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Tower 4",          ME::CreateObject, hbigkong4t,	       StaticInterior,  "hbigkong4t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Tower 5",          ME::CreateObject, hbigkong5t,	       StaticInterior,  "hbigkong5t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Tower 6",          ME::CreateObject, hbigkong6t,	       StaticInterior,  "hbigkong6t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Tower 7",          ME::CreateObject, hbigkong7t,	       StaticInterior,  "hbigkong7t.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Hide",             ME::CreateObject, hkonghidet,	       StaticInterior,  "hkonghide.dis");
ME::RegisterObject( "Temperate Shapes", "Kong Hide2",            ME::CreateObject, hkonghide2t,	   StaticInterior,  "hkonghide2.dis");


#---TITAN SHAPES-------------
ME::RegisterObject ( "Titan Shapes", "Titan Rock1",               ME::CreateObject, xtitanrock1,       StaticShape, false,"xtitanrock01.dts" );
ME::RegisterObject ( "Titan Shapes", "Titan Rock2",               ME::CreateObject, xtitanrock2,       StaticShape, false,"xtitanrock02.dts" );
ME::RegisterObject ( "Titan Shapes", "Titan Rock3",               ME::CreateObject, xtitanrock3,       StaticShape, false,"xtitanrock03.dts" );
ME::RegisterObject ("Titan Shapes",  "Titan Bigdish",             ME::CreateObject, hTitanbigdish,     StaticShape, true, "hTitanbigdish.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Gather",              ME::CreateObject, hTitangather,      StaticShape, true, "hTitangather.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Listen",     	        ME::CreateObject, hTitanlisten,         StaticShape, true, "hTitanlisten.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Power",               ME::CreateObject, hTitanpower,       StaticShape, true, "hTitanpower.DTS");
ME::RegisterObject( "Titan Shapes",  "Titan Microwave",           ME::CreateObject, hTitanMicrowave,    StaticShape, true,  "hTitanMicrowave.dts" );
ME::RegisterObject ("Titan Shapes",  "Titan Refinery",            ME::CreateObject, hTitanrefinery,    StaticShape, true, "hTitanrefinery.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Residence",           ME::CreateObject, hTitanresidence,   StaticShape, true, "hTitanresidence.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Silos",     	        ME::CreateObject, hTitansilos,          StaticShape, true, "hTitansilos.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Uplink",              ME::CreateObject, hTitanuplink,      StaticShape, true, "hTitanuplink.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Wall",     	        ME::CreateObject, hTitanwall,        StaticShape, false,"hTitanwall.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Wallcap",             ME::CreateObject, hTitanwallcap,     StaticShape, false,"hTitanwallcap.DTS");
ME::RegisterObject ("Titan Shapes",  "Titan Walldoor",            ME::CreateObject, hTitanwalldoor,    StaticShape, false,"hTitanwalldoor.DTS");
ME::RegisterObject ("Titan Shapes", $separator);
ME::RegisterObject ("Titan Shapes", "Titan Trooper Com",          ME::CreateObject, hTitantroopercom,  StaticShape, true, "hTitantroopercom.DTS");
ME::RegisterObject ("Titan Shapes", "Titan Trooper Command",      ME::CreateObject, hTitancommand,  	StaticShape, true, "hTitancommand.DTS");
ME::RegisterObject ("Titan Shapes", "Titan Trooper HQ",    	    ME::CreateObject, hTitantrooperhq,   StaticShape, true, "hTitantrooperhq.DTS");
ME::RegisterObject ("Titan Shapes", "Titan Trooper Residence",    ME::CreateObject, hTitantrooperresidenc,     StaticShape, true, "hTitantrooperresidence.DTS");
ME::RegisterObject ("Titan Shapes", "Titan Trooper Silos",        ME::CreateObject, hTitantroopsilos,  StaticShape, true, "hTitantroopsilos.DTS");
ME::RegisterObject ("Titan Shapes", "Titan Beam",                 ME::CreateObject, hTitanBeam,        StaticShape, true, "hTitanBEAM.DTS");
ME::RegisterObject ("Titan Shapes", "Titan Dias Irae",            ME::CreateObject, hTitanDiasIrae,    StaticShape, true, "hTitanDiasIrae.DTS");
ME::RegisterObject ("Titan Shapes", $separator);
ME::RegisterObject ("Titan Shapes", "Health Pad",    	          ME::CreateObject, hhealt,    	        StaticInterior,  "hhealt.dis");
ME::RegisterObject ("Titan Shapes", "Ammo Pad",    	          ME::CreateObject, hammot,    	        StaticInterior,  "hammot.dis");
ME::RegisterObject( "Titan Shapes", "Trooper Hanger (ZED)",	  ME::CreateObject, hTroophouseE,	    StaticInterior,  "hTroophouseE.dis" );

#---VENUS SHAPES-----------
ME::RegisterObject( "Venus Shapes", "Venus Array",               ME::CreateObject, hVenusarray,        StaticShape, true, "hVenusarray.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Arbor",               ME::CreateObject, hVenusarbor,        StaticShape, true,  "hVenusArbor.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Bigdish",             ME::CreateObject, hVenusbigdish,      StaticShape, true, "hVenusbigdish.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Com",                 ME::CreateObject, hVenuscom,          StaticShape, true, "hVenuscom.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Converter1",          ME::CreateObject, hVenusconverter1,   StaticShape, true, "hVenusconverter1.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Converter2",          ME::CreateObject, hVenusconverter2,   StaticShape, true, "hVenusconverter2.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Converter3",          ME::CreateObject, hVenusconverter3,   StaticShape, true, "hVenusconverter3.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Dispertion",          ME::CreateObject, hVenusdispertion,   StaticShape, true, "hVenusdispertion.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Drill",               ME::CreateObject, hVenusdrill,        StaticShape, true, "hVenusdrill.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Eternal Flame",       ME::CreateObject, hVenusEternalFlame, StaticShape, true, "hVenusEternalFlame.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Garage",              ME::CreateObject, hVenusgarage,       StaticShape, true, "hVenusgarage.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Gathering",           ME::CreateObject, hVenusgathering,    StaticShape, true, "hVenusgathering.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Geotherm",            ME::CreateObject, hVenusgeotherm,     StaticShape, true, "hVenusgeotherm.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Lightrod",            ME::CreateObject, hVenuslightrod,     StaticShape, true, "hVenuslightrod.dts" );
ME::RegisterObject( "Venus Shapes", "Venus listening",           ME::CreateObject, hVenuslistening,    StaticShape, true, "hVenuslistening.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Microwave",           ME::CreateObject, hVenusMicrowave,    StaticShape, true,  "hVenusMicrowave.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Perimwall",           ME::CreateObject, hVenusperimwall,    StaticShape, false,"hVenusperimwall.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Refinery",            ME::CreateObject, hVenusrefinery,     StaticShape, true, "hVenusrefinery.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Small Garage",        ME::CreateObject, hVenussmgarage,     StaticShape, true, "hVenussmgarage.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Small Wall",          ME::CreateObject, hVenussmwall,       StaticShape, false,"hVenussmwall.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Storage",             ME::CreateObject, hVenusstorage,      StaticShape, true, "hVenusstorage.dts" );
ME::RegisterObject( "Venus Shapes", "Venus TR HQ",               ME::CreateObject, hVenustrhq,         StaticShape, true, "hVenustrhq.dts" );
ME::RegisterObject( "Venus Shapes", "Venus TR Link",             ME::CreateObject, hVenustrlink,       StaticShape, true, "hVenustrlink.dts" );
ME::RegisterObject( "Venus Shapes", $separator );
ME::RegisterObject( "Venus Shapes", "Venus Rock1",               ME::CreateObject, xvenusrock1,        StaticShape, false,"xvenusrock01.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Rock2",               ME::CreateObject, xvenusrock2,        StaticShape, false,"xvenusrock02.dts" );
ME::RegisterObject( "Venus Shapes", "Venus Rock3",               ME::CreateObject, xvenusrock3,        StaticShape, false,"xvenusrock03.dts" );
#---Venus Interior Shapes------------
ME::RegisterObject( "Venus Interior Shapes", "Bridge        (ZED)",   ME::CreateObject, hbridgev,           StaticInterior, "hbridgev.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Convertor     (ZED)",   ME::CreateObject, hconv,              StaticInterior, "hconv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Small Bridge  (ZED)",   ME::CreateObject, hsmlbridgev,        StaticInterior, "hsmlbridgev.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Small Lift    (ZED)",   ME::CreateObject, hsmliftv,           StaticInterior, "hsmliftv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Small Oil Rig (ZED)",   ME::CreateObject, hsmloilv,           StaticInterior, "hsmloilv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Landing Pad   (ZED)",   ME::CreateObject, hlandpadv,          StaticInterior, "hlandpadv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Large Lift    (ZED)",   ME::CreateObject, hlgliftv,           StaticInterior, "hlgliftv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Large Oil Rig (ZED)",   ME::CreateObject, hlgoilv,            StaticInterior, "hlgoilv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Med Oil Rig   (ZED)",   ME::CreateObject, hmidoilv,           StaticInterior, "hmidoilv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Hub           (ZED)",   ME::CreateObject, hhubv,              StaticInterior, "hhubv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Heal          (ZED)",   ME::CreateObject, hhealv,             StaticInterior, "hhealv.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Ammo          (ZED)",   ME::CreateObject, hammov,             StaticInterior, "hammov.dis" );
ME::RegisterObject( "Venus Interior Shapes", "Monument      (ZED)",   ME::CreateObject, hmonumentv,         StaticInterior, "hmonumentv.dis" );

#--------------------------------------------------------------------------------------------------------------------------------
ME::RegisterObject( $separator );


#----GENERIC SHAPES
ME::RegisterObject( "Generic Shapes", "Boxes",                 ME::CreateObject, xBoxes,            StaticShape, true, "xBoxes.dts");
ME::RegisterObject( "Generic Shapes", "Container",             ME::CreateObject, xContainer,        StaticShape, true, "xContainer.dts");
ME::RegisterObject( "Generic Shapes", "Fuel Tank",             ME::CreateObject, xfueltank,         StaticShape, true, "xFuelTank.dts");
ME::RegisterObject( "Generic Shapes", "Human Drop Pod",        ME::CreateObject, hDropPod,          StaticShape, true, "hDropPod.dts");
ME::RegisterObject( "Generic Shapes", "Monument",              ME::CreateObject, xMonument,         StaticShape, true, "xMonument.dts");
ME::RegisterObject( "Generic Shapes", "Target Drone",              ME::CreateObject, xObstacle,         StaticShape, true, "xobstacle.dts");
ME::RegisterObject( "Generic Shapes", "Trooper Container",     ME::CreateObject, xtroopercontainer, StaticShape, true, "xtroopercontainer.dts");
ME::RegisterObject( "Generic Shapes", $separator );
ME::RegisterObject( "Generic Shapes", "BridgeHub1 (ZED)",          ME::CreateObject, xbridgehub,         StaticInterior, "xbridgehub.dis");
ME::RegisterObject( "Generic Shapes", "BridgeHub2 (ZED)",          ME::CreateObject, xbridgehub2,        StaticInterior, "xbridgehub2.dis");
ME::RegisterObject( "Generic Shapes", "BridgeHub3 (ZED)",          ME::CreateObject, xbridgehub3,        StaticInterior, "xbridgehub3.dis");
ME::RegisterObject( "Generic Shapes", "BridgeHub4 (ZED)",          ME::CreateObject, xbridgehub4,        StaticInterior, "xbridgehub4.dis");
ME::RegisterObject( "Generic Shapes", $separator);
ME::RegisterObject( "Generic Shapes", "Yellow Flag",          ME::CreateObject, yellowFlag,       StaticShape, "team1.dts" );
ME::RegisterObject( "Generic Shapes", "Blue Flag",            ME::CreateObject, blueFlag,         StaticShape, "team2.dts" );
ME::RegisterObject( "Generic Shapes", "Red Flag",             ME::CreateObject, readFlag,         StaticShape, "team3.dts" );
ME::RegisterObject( "Generic Shapes", "Purple Flag",          ME::CreateObject, purpleFlag,       StaticShape, "team4.dts" );
ME::RegisterObject( "Generic Shapes", "Cryo Door",            ME::CreateObject, xCryodDoor,       StaticShape, "xCryodoor.dts" );
ME::RegisterObject( "Generic Shapes", $separator );
ME::RegisterObject( "Generic Shapes", "Movie House (ZED)",   ME::CreateObject, hmovie,           StaticInterior, "hmovie.dis" );
ME::RegisterObject( "Generic Shapes", $separator );
ME::RegisterObject( "Generic Shapes", "Tower 1",          ME::CreateObject, hhugescraper1,	       StaticInterior,  "hhugescraper1.dis");
ME::RegisterObject( "Generic Shapes", "Tower 2",          ME::CreateObject, hhugescraper2,	       StaticInterior,  "hhugescraper2.dis");
ME::RegisterObject( "Generic Shapes", "Tower 3",          ME::CreateObject, hhugescraper3,	       StaticInterior,  "hhugescraper3.dis");
ME::RegisterObject( "Generic Shapes", "Tower 4",          ME::CreateObject, hhugescraper4,	       StaticInterior,  "hhugescraper4.dis");
ME::RegisterObject( "Generic Shapes", "Tower 5",          ME::CreateObject, hhugescraper5,	       StaticInterior,  "hhugescraper5.dis");
ME::RegisterObject( "Generic Shapes", "Tower 6",          ME::CreateObject, hhugescraper6,	       StaticInterior,  "hhugescraper6.dis");
ME::RegisterObject( "Generic Shapes", "Tower 7",          ME::CreateObject, hhugescraper7,	       StaticInterior,  "hhugescraper7.dis");
ME::RegisterObject( "Generic Shapes", "Tower 8",          ME::CreateObject, hhugescraper8,	       StaticInterior,  "hhugescraper8.dis");

#----Heal/Ammo SHAPES
ME::RegisterObject( "Heal/Ammo Shapes", "Heal Lite",       ME::CreateObject, xheal_lite,          StaticShape, true, "xheal_lite.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "Heal Dark",       ME::CreateObject, xheal_dark,          StaticShape, true, "xheal_dark.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "Heal Venus",      ME::CreateObject, xheal_venus,         StaticShape, true, "xheal_venus.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "Ammo Lite",       ME::CreateObject, xammo_lite,          StaticShape, true, "xammo_lite.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "Ammo Dark",       ME::CreateObject, xammo_dark,          StaticShape, true, "xammo_dark.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "Ammo Venus",      ME::CreateObject, xammo_venus,         StaticShape, true, "xammo_venus.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "ZenAll Lite",     ME::CreateObject, xzen_lite,           StaticShape, true, "xzen_lite.dts");
ME::RegisterObject( "Heal/Ammo Shapes", "ZenAll Dark",     ME::CreateObject, xzen_dark,           StaticShape, true, "xzen_dark.dts");
ME::RegisterObject( "Heal/Ammo Shapes", $separator );
ME::RegisterObject( "Heal/Ammo Shapes", "Heal Lite (ZED)", ME::CreateObject, hHeallite,           StaticInterior, "hHeallite.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "Heal Dark (ZED)", ME::CreateObject, hHealdark,           StaticInterior, "hHealdark.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "Heal Venus(ZED)", ME::CreateObject, hHealvenus,          StaticInterior, "hHealvenus.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "Ammo Lite (ZED)", ME::CreateObject, hAmmolite,           StaticInterior, "hAmmolite.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "Ammo Dark (ZED)", ME::CreateObject, hAmmodark,           StaticInterior, "hAmmodark.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "Ammo Venus(ZED)", ME::CreateObject, hAmmovenus,          StaticInterior, "hAmmovenus.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "ZenAll Lite (ZED)", ME::CreateObject, hZenlite,           StaticInterior, "hZenlite.dis");
ME::RegisterObject( "Heal/Ammo Shapes", "ZenAll Dark (ZED)", ME::CreateObject, hZendark,           StaticInterior, "hZendark.dis");

#----Multiplayer SHAPES
ME::RegisterObject( "Multiplayer Shapes", "Low-Poly Monument",    ME::CreateObject, hLPMonument,        StaticShape,    "xMonument_LOW.dts");
ME::RegisterObject( "Multiplayer Shapes", $separator );
ME::RegisterObject( "Multiplayer Shapes", "Football Uprights (ZED)",   ME::CreateObject, football,   StaticInterior,   "football.dis");
ME::RegisterObject( "Multiplayer Shapes", "Teleporter (ZED)",    ME::CreateObject, teleport,         StaticInterior,   "teleport.dis");
ME::RegisterObject( "Multiplayer Shapes", "Teleporter Effect",   ME::CreateObject, fx_tele_t,        StaticShape, true, "fx_tele_t.dts");

o