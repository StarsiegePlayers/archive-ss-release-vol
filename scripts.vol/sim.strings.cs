//============================================================================================
// ES Sim Region reserves tags  300,000- 399,999
// 
// *IMPORTANT, PLEASE READ*
//     Do not define SimTag id zero.  Darkstar relies on the fact 
//     that SimTag id zero is never defined.
//
//     The SimTags are grouped into 3 sections: REGION, RESOURCE, and DATA.
//     A REGION holds one more more RESOURCE and DATA sections.
//     Tags in a DATA group will be translated during a foriegn language conversion.
//     Tags in the RESOURCE group will NOT.
//
//============================================================================================
// NOTE TO TRANSLATORS: You do not need to translate the comments in these files. 
// Comments are preceeded by 2 slash characters
// You also do not need to translate the "Descriptions (blah blah) DATA group resevers tags (Number-Number) lines"

//IDRGN_BEG_SIM 

///////////////////////////////////////////////////////////////////////////////
// Vehicle DESCRIPTION TAGS ( IDVEH )                                          //
///////////////////////////////////////////////////////////////////////////////
//IDDAT_BEG_VEHICLE_DESCRIP   	= 00300001, "-- Vehicle Descriptions DATA group reserves tags 300,001 - 300,999 -";

// Terran vehicles
IDVEH_TR_APOC             		= 00300100, "Apocalypse";
IDVEH_TR_MINO             		= 00300101, "Minotaur";
IDVEH_TR_GORG             		= 00300102, "Gorgon";
IDVEH_TR_TALO             		= 00300103, "Talon";
IDVEH_TR_BASL             		= 00300104, "Basilisk";
IDVEH_TR_BANS                 = 00300105, "Banshee";

IDVEH_KN_APOC             		= 00300110, "Knight's Apocalypse";
IDVEH_KN_MINO             		= 00300111, "Knight's Minotaur";
IDVEH_KN_GORG             		= 00300112, "Knight's Gorgon";
IDVEH_KN_TALO             		= 00300113, "Knight's Talon";
IDVEH_KN_BASL             		= 00300114, "Knight's Basilisk";
IDVEH_KN_MYRM                 = 00300115, "Knight's Myrmidon";
IDVEH_KN_PALA                 = 00300116, "Knight's Paladin";
IDVEH_KN_DISR                 = 00300117, "Knight's Disruptor";
IDVEH_KN_BANS                 = 00300118, "Knight's Banshee";
IDVEH_KN_DROP                 = 00300119, "Knight's Drop Ship";

IDVEH_TR_PALA             		= 00300120, "Paladin";
IDVEH_TR_MYRM             		= 00300121, "Myrmidon";
IDVEH_TR_DISR             		= 00300122, "Disrupter";

IDVEH_TR_CARG                 = 00300123, "Cargo Ship";
IDVEH_TR_ESCAPE               = 00300124, "Escape Ship";
IDVEH_TR_CONV                 = 00300125, "Conveyor";
IDVEH_TR_DROP                 = 00300126, "Dropship";
IDVEH_TR_DRAC                 = 00300127, "Draco Bomber";

IDVEH_TR_NIKE                 = 00300129, "Nike";
IDVEH_TR_SUPR                 = 00300130, "Suppressor";
IDVEH_TR_SOVE                 = 00300131, "Sovereign";
IDVEH_TR_SURV                 = 00300132, "Surveyor";
IDVEH_TR_STAR                 = 00300133, "Starfield";

// Cybrid Vehicles
IDVEH_CY_SEEK                 = 00300200, "Seeker";
IDVEH_CY_GOAD                 = 00300201, "Goad";
IDVEH_CY_SHEP                 = 00300202, "Shepherd";
IDVEH_CY_ADJU                 = 00300203, "Adjudicator";
IDVEH_CY_EXEC                 = 00300204, "Executioner";
IDVEH_PL_ADJU                 = 00300205, "Platinum Guard Adjudicator";
IDVEH_PL_EXEC                 = 00300206, "Platinum Guard Executioner";
IDVEH_CY_BOLO                 = 00300210, "Bolo";
IDVEH_CY_RECL                 = 00300211, "Recluse";
IDVEH_CY_PROM                 = 00300212, "Prometheus";
IDVEH_CY_ARTL                 = 00300213, "Artillery";
IDVEH_CY_ADVO                 = 00300214, "Advocate";
IDVEH_CY_CONS                 = 00300215, "Consul Bomber";
IDVEH_CY_DROP                 = 00300216, "Cybrid Dropship";

IDVEH_CY_PROT                 = 00300217, "Cybrid Protector";
IDVEH_CY_JAMM                 = 00300218, "Cybrid Jammer";

//Cybrd Metagen Vehicles
IDVEH_MG_SEEK                 = 00300220, "Metagen Seeker";
IDVEH_MG_GOAD                 = 00300221, "Metagen Goad";
IDVEH_MG_SHEP                 = 00300222, "Metagen Shepherd";
IDVEH_MG_ADJU                 = 00300223, "Metagen Adjudicator";
IDVEH_MG_EXEC                 = 00300224, "Metagen Executioner";


// Rebel Vehicles
IDVEH_RB_EMAN             		= 00300300, "Emancipator";
IDVEH_RB_AVEN             		= 00300310, "Avenger";
IDVEH_RB_DREA             		= 00300311, "Dreadlock";
IDVEH_RB_OLY              		= 00300312, "Olympian";
IDVEH_RB_ARTL                 = 00300313, "Artillery";
IDVEH_RB_THUM                 = 00300314, "Thumper";
IDVEH_RB_PNCR                 = 00300315, "Pouncer Assault Bike";

// Pirate Vehicles
IDVEH_PI_APOC                 = 00300320, "Outrider Apocalypse";
IDVEH_PI_EMAN                 = 00300321, "Outrider Emancipator";
IDVEH_PI_DREA                 = 00300322, "Outrider Dreadlock";

// Misc Vehicles
IDVEH_HA_APOC             		= 00300400, "Harabec's Apocalypse";
IDVEH_HA_PRED             		= 00300401, "Harabec's Predator";
IDVEH_HA_SUPER_PRED        		= 00300402, "Bek Storm's Predator";
IDVEH_SS_BUS             		= 00300409, "Starsiege Magic Bus";
IDVEH_CA_MINO             		= 00300410, "Caanon's Basilisk";

//Gerald's "Special" Cinematic Vehicles

IDVEH_CIN_APOC             		= 00300411, "Cinematic Apocalypse";
IDVEH_CIN_MINO             		= 00300412, "Cinematic Basilisk";

// Drone Vehicles
IDVEH_CY_OMNI                 = 00300420, "Mobile Nexus";
IDVEH_TR_FLTB                 = 00300421, "Terran Empty Cargo";
IDVEH_TR_FLTB_AMMO            = 00300422, "Terran Ammo Cargo";
IDVEH_TR_FLTB_BIG_AMMO        = 00300423, "Terran Big Ammo Cargo";
IDVEH_TR_FLTB_BIG_PERSONNEL   = 00300424, "Terran Personnel Cargo";
IDVEH_TR_FLTB_FUEL            = 00300425, "Terran Fuel Cargo";
IDVEH_TR_FLTB_MINO            = 00300426, "Terran Minotaur Cargo";
IDVEH_TR_UTIL_TRUCK           = 00300427, "Terran Utility Truck";
IDVEH_RB_FLTB                 = 00300435, "Rebel Empty Cargo";
IDVEH_RB_FLTB_AMMO            = 00300428, "Rebel Ammo Cargo";
IDVEH_RB_FLTB_BIG             = 00300429, "Rebel Big Cargo";
IDVEH_RB_FLTB_BIG_BOX         = 00300430, "Rebel Big Box Cargo";
IDVEH_RB_FLTB_BOX             = 00300431, "Rebel Box Cargo";

// Turrets
IDTRT_C_LAS               		= 00300450, "Laser Turret";
IDTRT_C_MSSL              		= 00300451, "Missile Turret";
IDTRT_X_LAS               		= 00300452, "Laser Turret";
IDTRT_D_EARTH_LAS_SHORT   		= 00300453, "Turret";
IDTRT_D_EARTH_LAS_TALL    		= 00300454, "Turret";
IDTRT_H_EARTH_LAS_SHORT   		= 00300455, "Turret";
IDTRT_H_EARTH_LAS_TALL    		= 00300456, "Turret";
IDTRT_H_MARS_LAS_SHORT    		= 00300457, "Turret";
IDTRT_H_MARS_LAS_TALL     		= 00300458, "Turret";
IDTRT_H_MOON_LAS_SHORT    		= 00300459, "Turret";
IDTRT_H_MOON_LAS_TALL     		= 00300460, "Turret";
IDTRT_H_VENUS_LAS_SHORT   		= 00300461, "Turret";
IDTRT_H_VENUS_LAS_TALL    		= 00300462, "Turret";
IDTRT_D_EARTH_MSSL_SHORT  		= 00300463, "Missile Turret";
IDTRT_D_EARTH_MSSL_TALL   		= 00300464, "Missile Turret";
IDTRT_H_EARTH_MSSL_SHORT  		= 00300465, "Missile Turret";
IDTRT_H_EARTH_MSSL_TALL   		= 00300466, "Missile Turret";
IDTRT_H_MARS_MSSL_SHORT   		= 00300467, "Missile Turret";
IDTRT_H_MARS_MSSL_TALL    		= 00300468, "Missile Turret";
IDTRT_H_MOON_MSSL_SHORT   		= 00300469, "Missile Turret";
IDTRT_H_MOON_MSSL_TALL    		= 00300470, "Missile Turret";
IDTRT_H_VENUS_MSSL_SHORT  		= 00300471, "Missile Turret";
IDTRT_H_VENUS_MSSL_TALL   		= 00300472, "Missile Turret";
IDTRT_H_TITAN_LAS_SHORT   		= 00300473, "Turret";
IDTRT_H_TITAN_LAS_TALL    		= 00300474, "Turret";
IDTRT_H_TITAN_MSSL_SHORT  		= 00300475, "Missile Turret";
IDTRT_H_TITAN_MSSL_TALL   		= 00300476, "Missile Turret";
IDTRT_R_GUN                   = 00300477, "Rebel Gun";
IDTRT_H_CANNON            		= 00300478, "Cannon";
IDTRT_M_CANNON            		= 00300479, "Cannon";
IDTRT_T_CANNON            		= 00300480, "Cannon";
IDTRT_D_CANNON            		= 00300481, "Cannon";


///////////////////////////////////////////////////////////////////////////////
// MARS SHAPES
///////////////////////////////////////////////////////////////////////////////
IDACS_APARTMENT 				   = 00300501, "Apartment";
IDACS_HATMOS              		= 00300502, "Atmospheric Controller";
IDACS_BARRACKS                = 00300503, "Barracks";
IDACS_COMMTOWER               = 00300504, "Communications Tower";
IDACS_HCRANE              		= 00300505, "Crane";
IDACS_CIVGARAGE               = 00300506, "Civilian Garage";
IDACS_FARMHOUSE				   = 00300507, "Farm House";
IDACS_HFERTILLIZER        		= 00300508, "Fertilizer";
IDACS_FUSIONREACTOR			   = 00300509, "Fusion Reactor";
IDACS_HGARAGE             		= 00300510, "Garage";
IDACS_HANGER                  = 00300511, "Hangar";
IDACS_LANDMINE                = 00300512, "Land Mine";
IDACS_MASSDRIVER			   	= 00300513, "Mass Driver";
IDACS_HMEETHALL           		= 00300514, "Meeting Hall";
IDACS_MINETRAIN               = 00300515, "Mine Train";
IDACS_MINETRAINCARGO          = 00300516, "Mine Train Cargo";
IDACS_PILEDRIVER              = 00300517, "Piledriver";
IDACS_HPOLICEFLAG             = 00300518, "Police Flag";
IDACS_HPERIMETER          		= 00300519, "Perimeter Post";
IDACS_HPOLICEFIN          		= 00300520, "Police Power Fin";
IDACS_HPOLICEHQ           		= 00300521, "Police HQ";
IDACS_HPOWERFIN           		= 00300522, "Power Fin";
IDACS_REBELFLAG               = 00300523, "Rebel Flag";
IDACS_HREFINERY           		= 00300524, "Refinery";
IDACS_RESIDENTIALBIG			   = 00300525, "Residence";
IDACS_RESIDENTIALSMALL    		= 00300526, "Residence";
IDACS_XMARSROCK1          		= 00300527, "Rock";
IDACS_XMARSROCK2          		= 00300528, "Rock";
IDACS_XMARSROCK3          		= 00300529, "Rock";
IDACS_STREETLIGHT				   = 00300530, "Street Light";
IDACS_SUPPLYDUMP		   		= 00300531, "Supply Depot";
IDACS_HTRACKING           		= 00300532, "Tracking Station";
IDACS_HUPLINK             		= 00300533, "Uplink Center";
IDACS_HWALLCORN           		= 00300534, "Wall";
IDACS_HWALLDOOR           		= 00300535, "Wall";
IDACS_HWALL               		= 00300536, "Wall";
IDACS_WATERTOWER				   = 00300537, "Water Tower";
IDACS_WATERCONVERTOR      		= 00300538, "Water Converter";
IDACS_ABANDONED                 = 00300539, "Abandoned Building";

/////////////////////////////////////////////////////////////////////////////////
// MERCURY SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_XMERCURYROCK1			   = 00300550, "Rock";
IDACS_XMERCURYROCK2			   = 00300551, "Rock";
IDACS_XMERCURYROCK3			   = 00300552, "Rock";

////////////////////////////////////////////////////////////////////////////////
// MOON SHAPES
////////////////////////////////////////////////////////////////////////////////
IDACS_MOONBARRACK				   = 00300570, "Barrack";
IDACS_MOONBIGDISH				   = 00300571, "Big Dish";
IDACS_MOONGATHER				   = 00300572, "Gathering Hall";
IDACS_MOONLISTEN				   = 00300573, "Listening Station";
IDACS_MOONPLANETDEF           = 00300574, "Anti-Orbital Gun";
IDACS_MOONPOWER					= 00300575, "Power Generator";
IDACS_MOONREFINERY				= 00300576, "Refinery";
IDACS_MOONRESIDENCE				= 00300577, "Residence";
IDACS_MOONSILOS					= 00300578, "Silo";
IDACS_MOONUPLINK				   = 00300579, "Uplink Station";
IDACS_MOONWALL					   = 00300580, "Wall";
IDACS_MOONWALLCAP				   = 00300581, "Wall";
IDACS_MOONWALLDOOR				= 00300582, "Wall";
IDACS_MOONTROOPERCOM				= 00300583, "Imperial Comm Tower";
IDACS_MOONGUNBUNKER				= 00300584, "Gun Bunker";
IDACS_MOONTROOPERHQ				= 00300585, "Imperial HQ";
IDACS_MOONTROOPERSILOS			= 00300586, "Imperial Silo";
IDACS_MOONTROOPERSTORAGE  		= 00300587, "Imperial Supply Depot";
IDACS_MOONTROOPERTRACKING 		= 00300588, "Imperial Tracking Station";
IDACS_XMOONROCK1					= 00300589, "Rock";
IDACS_XMOONROCK2					= 00300590, "Rock";
IDACS_XMOONROCK3					= 00300591, "Rock";
IDACS_XAPOLLO						= 00300592, "Apollo";
IDACS_XMOONFLAG					= 00300593, "Flag";

/////////////////////////////////////////////////////////////////////////////////
// PLUTO SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_XPLUTOROCK1				= 00300600, "Rock";
IDACS_XPLUTOROCK2				= 00300601, "Rock";
IDACS_XPLUTOROCK3				= 00300602, "Rock";

////////////////////////////////////////////////////////////////////////////////
// TEMPERATE SHAPES
////////////////////////////////////////////////////////////////////////////////
IDACS_KONGCIVIL				= 00300610, "Civil Center";
IDACS_KONGGATHERING			= 00300611, "Gathering Building";
IDACS_KONGHOUSE				= 00300612, "House";
IDACS_KONGOFFICE			   = 00300613, "Office Building";
IDACS_KONGPAGODA			   = 00300614, "Pagoda";
IDACS_KONGSLUDGE			   = 00300615, "Sewage Treatment";
IDACS_KONGTEMPLE			   = 00300616, "Temple";
IDACS_KONGLGTEMPLE			= 00300617, "High Temple";
IDACS_KONGDECKHOUSE			= 00300618, "Deck House";
IDACS_KONGGATE				   = 00300619, "Gate";

////////////////////////////////////////////////////////////////////////////////
// TITAN SHAPES//
////////////////////////////////////////////////////////////////////////////////
IDACS_TITANBIGDISH		   = 00300634, "Radar Dish";
IDACS_TITANDIESIRAE		   = 00300635, "Launch Facility";
IDACS_TITANGATHER				= 00300636, "Gathering Hall";
IDACS_TITANLISTEN				= 00300637, "Listening Station"; 
IDACS_TITANMICROWAVE		   = 00300638, "Microwave Dish";
IDACS_TITANPOWER				= 00300639, "Power Generator";
IDACS_XTITANROCK1				= 00300640, "Rock";
IDACS_XTITANROCK2				= 00300641, "Rock";
IDACS_XTITANROCK3				= 00300642, "Rock";
IDACS_TITANREFINERY			= 00300644, "Refinery";
IDACS_TITANRESIDENCE			= 00300645, "Residence";
IDACS_TITANSILOS				= 00300646, "Silo";
IDACS_TITANUPLINK				= 00300647, "Uplink";
IDACS_TITANWALL				= 00300648, "Wall";
IDACS_TITANWALLCAP			= 00300649, "Wall";
IDACS_TITANWALLDOOR			= 00300650, "Wall";
IDACS_TITANTROOPERCOM		= 00300651, "Imperial Communications";
IDACS_TITANTROOPERHQ			= 00300652, "Imperial HQ";
IDACS_TITANTROOPERRES		= 00300653, "Imperial Residence";
IDACS_TITANTROOPERSILOS		= 00300654, "Imperial Silo";

////////////////////////////////////////////////////////////////////////////////
// VENUS SHAPES
////////////////////////////////////////////////////////////////////////////////
IDACS_VENUSARRAY				= 00300660, "Array";
IDACS_VENUSARBOR				= 00300661, "Arbor";
IDACS_VENUSBIGDISH			= 00300662, "Radar";
IDACS_VENUSCOM					= 00300663, "Communications Tower";
IDACS_VENUSCONVERTOR1		= 00300664, "Convertor";
IDACS_VENUSCONVERTOR2      = 00300665, "Convertor";
IDACS_VENUSCONVERTOR3     	= 00300666, "Convertor";
IDACS_VENUSDISPERTION		= 00300667, "Dispertion Tower";
IDACS_VENUSDRILL				= 00300668, "Drill";
IDACS_VENUSFLAME				= 00300669, "Eternal Flame";
IDACS_VENUSGARAGE				= 00300670, "Garage";
IDACS_VENUSGATHERING			= 00300671, "Gathering Hall";
IDACS_VENUSGEOTHERM			= 00300672, "Geothermal Station";
IDACS_VENUSGUNMOUNT			= 00300673, "Gun Mount";
IDACS_VENUSLIGHTROD			= 00300674, "Lightning Rod";
IDACS_VENUSLISTENING			= 00300675, "Listening Station";
IDACS_VENUSMICROWAVE			= 00300676, "Microwave";
IDACS_VENUSPERIMWALL			= 00300677, "Wall";
IDACS_VENUSREFINERY			= 00300678, "Refinery";
IDACS_VENUSSMGARAGE			= 00300679, "Garage";
IDACS_VENUSSMWALL				= 00300680, "Wall";
IDACS_VENUSSTORAGE			= 00300681, "Storage";
IDACS_VENUSTRHQ				= 00300682, "Imperial HQ";
IDACS_VENUSTRLINK				= 00300683, "Imperial Link";
IDACS_XVENUSROCK1				= 00300684, "Rock";
IDACS_XVENUSROCK2				= 00300685, "Rock";
IDACS_XVENUSROCK3				= 00300686, "Rock";

/////////////////////////////////////////////////////////////////////////////////
// GENERIC SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_XBOXES				   = 00300690, "Boxes";
IDACS_CONTAINER				= 00300691, "Container";
IDACS_XTROOPERCONTAINER		= 00300692, "Trooper Cargo Container";
IDACS_MONUMENT					= 00300693, "Monument";
IDACS_FUELTANK             = 00300694, "Fuel Tank";
IDACS_HUMANDROPPOD         = 00300695, "Human Drop Pod";
IDACS_OBSTACLE             = 00300696, "Obstacle";
IDACS_YELLOWFLAG           = 00300697, "YELLOW Flag";
IDACS_BLUEFLAG             = 00300698, "BLUE Flag";	
IDACS_REDFLAG              = 00300699, "RED Flag";	
IDACS_PURPLEFLAG           = 00300700, "PURPLE Flag";	
IDACS_HEAL                 = 00300701, "Repair Pad Generator";	
IDACS_AMMO                 = 00300702, "Reload Pad Generator";	

/////////////////////////////////////////////////////////////////////////////////
// EUROPA SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_XEUROPAROCK1			= 00300710, "Rock";
IDACS_XEUROPAROCK2			= 00300711, "Rock";
IDACS_XEUROPAROCK3			= 00300712, "Rock";

/////////////////////////////////////////////////////////////////////////////////
// ICE SHAPES 
/////////////////////////////////////////////////////////////////////////////////
IDACS_HOFFICE             	= 00300720, "Office";
IDACS_HSNOWCHURCH         	= 00300721, "Church";
IDACS_HSNOWCOM            	= 00300722, "Communications Station";
IDACS_HSNOWLLAND          	= 00300723, "Power Relay Station";
IDACS_HSNOWRESIDENCE      	= 00300724, "Residence";
IDACS_HSNOWSTORAGE        	= 00300725, "Storehouse";
IDACS_HSNOWUPLINK         	= 00300726, "Uplink Station";
IDACS_HSOLARSTATION       	= 00300727, "Solar Station";
IDACS_XSNOWMAN            	= 00300728, "Frosty T";
IDACS_HGATHERING          	= 00300729, "Gathering Hall";
IDACS_XSNOWROCK1          	= 00300730, "Rock";
IDACS_XSNOWROCK2          	= 00300731, "Rock";
IDACS_XSNOWROCK3          	= 00300732, "Rock";
IDACS_XTREE               	= 00300733, "Tree";

/////////////////////////////////////////////////////////////////////////////////
// GENERIC EARTH SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_TROOPERBARRACKS		= 00300750, "Trooper Barracks";
IDACS_TROOPERBIGDISH		   = 00300751, "Trooper Big Dish";
IDACS_TROOPERCOMM			   = 00300752, "Trooper Communications";
IDACS_TROOPERGARAGE       	= 00300753, "Trooper Garage";
IDACS_TROOPERGUNTOWER		= 00300754, "Trooper Gun Tower";
IDACS_TROOPERHALL			   = 00300755, "Trooper Gathering Hall";
IDACS_TROOPERHQ				= 00300756, "Trooper HQ";
IDACS_TROOPERLISTEN			= 00300757, "Trooper Listening Tower";
IDACS_TROOPERPOWER			= 00300758, "Trooper Power Generator";
IDACS_TROOPERSUPPLY			= 00300759, "Trooper Supply";
IDACS_TROOPERTRACKDISH		= 00300760, "Trooper Tracking Dish";
IDACS_TROOPERTRACKBASE		= 00300761, "Trooper Tracking Base";
IDACS_TROOPERUPLINK			= 00300762, "Trooper Uplink";
IDACS_TROOPERPLANTDEF      = 00300763, "Trooper Planetary Defense";
IDACS_TROOPERPOWERPRO      = 00300764, "Trooper Energy-Projection Unit";

///////////////////////////////////////////////////////////////////////////////
// Desert Shapes                                                             //
///////////////////////////////////////////////////////////////////////////////
IDACS_DBIGDISH             = 00300781, "Big Dish";
IDACS_DCHURCH              = 00300782, "Church";
IDACS_DDEFENSE             = 00300783, "Planetary Defense";
IDACS_DDWELLING            = 00300784, "Dwelling";
IDACS_DGARAGE              = 00300785, "Garage";
IDACS_DGATHERING           = 00300786, "Gathering";
IDACS_DPOWER               = 00300787, "Power Generator";
IDACS_DSILO                = 00300788, "Silo";
IDACS_DSLUDGE              = 00300789, "Sludge Processor";
IDACS_DUPLINK              = 00300790, "Uplink";
IDACS_DVAPOR               = 00300791, "Vapor Collector";
IDACS_DWATERTOWER          = 00300792, "Water Tower";
IDACS_DBARRACKS            = 00300793, "Barracks";
IDACS_DCOMM                = 00300794, "Communications";
IDACS_DTROOPGARAGE         = 00300795, "Troop Garage";
IDACS_DTROOPHALL           = 00300796, "Troop Hall";
IDACS_DTROOPHQ             = 00300797, "Troop HQ";

///////////////////////////////////////////////////////////////////////////////
// Cybrid Shapes                                               `             //
///////////////////////////////////////////////////////////////////////////////
IDACS_CBOMBERBAY           = 00300810, "Cybrid Bomberbay";
IDACS_CCOMM                = 00300811, "Cybrid Communications";
IDACS_CDROPPOD             = 00300812, "Cybrid Drop Pod";
IDACS_CENTRANCE            = 00300813, "Cybrid Entrance";
IDACS_CGENERATOR           = 00300814, "Cybrid Generator";
IDACS_CMOTION              = 00300815, "Cybrid Motion Detector";
IDACS_CNEXUS               = 00300816, "Cybrid Nexus";
IDACS_CPOST                = 00300817, "Cybrid Perimeter Post";
IDACS_CPOWER               = 00300818, "Cybrid Power Generator";
IDACS_CRELAY               = 00300819, "Cybrid Relay Station";
IDACS_CSEARCH              = 00300820, "Cybrid Search Array";
IDACS_CSTORAGE             = 00300821, "Cybrid Storage";
IDACS_CTRACKING            = 00300822, "Cybrid Tracking Station";
IDACS_CUPLINK              = 00300823, "Cybrid Uplink";
IDACS_CWALL                = 00300824, "Cybrid Wall";
IDACS_CTEMPLEWALL          = 00300825, "Cybrid Temple Wall";


/////////////////////////////////////////////////////////////////////////////////
// Mission Specific Structure Names
/////////////////////////////////////////////////////////////////////////////////
IDACS_COMMAND              = 00300838, "Sa Thauri Command";
IDACS_XXBARRACKS           = 00300839, "Barracks";
IDACS_IMPTURRET            = 00300840, "Imperial Defense Turret";
IDACS_POWERGENERATOR       = 00300841, "Power Generator";
IDACS_TURRET1              = 00300842, "Northern Turret";
IDACS_TURRET2              = 00300843, "Eastern Turret";
IDACS_TURRET3              = 00300844, "Southern Turret";
IDACS_TURRET4              = 00300845, "Western Turret";
IDACL_RESIDENTIALSMALL1    = 00300846, "Civilian Small Residential";
IDACL_NAVARESHOUSE         = 00300847, "Navarre's Headquarters";
IDACL_HMEETHALL1           = 00300848, "Maruschak Lodge";
IDACL_HPOLICEHQ1           = 00300849, "Secondary Police Headquarters";
IDACL_HGARAGE1             = 00300850, "Imperial Liquor supply";
IDACL_HGARAGE2             = 00300851, "Munitions dump";
IDACL_HREFINERY1           = 00300852, "Weapons refinery";
IDACL_CAANONDROPPOD        = 00300853, "Icehawk's Drop Pod";
IDACL_IMPERIALCACHE        = 00300854, "Imperial Weapons Cache";
IDACL_HEADQUARTERS         = 00300855, "Headquarters";
IDACS_AMMOBOX              = 00300856, "Ammunition container";
IDACL_WEAPONBOX            = 00300857, "Weapon container";
IDACS_HIGHTEMPLE           = 00300858, "worship\\\\temple-construct";
IDACS_IDOL                 = 00300859, "Primary Creed\\\\Idol";

IDDAT_END_ACTOR_DESCRIP    = 00300999, "-- Actor Descriptions DATA group reserves tags 300,001 - 300,999 -";

IDDAT_BEG_C_ACTOR_DESCRIP        = 00304500, "-- Actor Descriptions DATA group reserves tags 303,501 - 303,999 -";

///////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED MARS SHAPES
///////////////////////////////////////////////////////////////////////////////
IDACS_C_APARTMENT 				   = 00304501, "Hub\\\\Nest";
IDACS_C_HATMOS              	   = 00304502, "Gas-Conversion\\\\Construct";
IDACS_C_BARRACKS                 = 00304503, "Combatant Hub\\\\Macro-Nest";
IDACS_C_COMMTOWER                = 00304504, "Communication\\\\Facility";
IDACS_C_HCRANE              		= 00304505, "Crane\\\\Construct";
IDACS_C_CIVGARAGE                = 00304506, "Noncombatant Vehicle Bay";
IDACS_C_FARMHOUSE				      = 00304507, "Rural Macro-Nest";
IDACS_C_HFERTILLIZER        		= 00304508, "Tiller\\\\Construct";
IDACS_C_FUSIONREACTOR			   = 00304509, "Fusion\\\\Construct";
IDACS_C_HGARAGE             		= 00304510, "Vehicle Bay";
IDACS_C_HANGER                   = 00304511, "Vessel Bay";
IDACS_C_LANDMINE                 = 00304512, "Dissimulated Explosive";
IDACS_C_MASSDRIVER			   	= 00304513, "Supply-Projectile\\\\Construct";
IDACS_C_HMEETHALL           		= 00304514, "Convergence\\\\Facility";
IDACS_C_MINETRAIN                = 00304515, "Linked Chassis";
IDACS_C_MINETRAINCARGO           = 00304516, "Linked Chassis Content";
IDACS_C_PILEDRIVER               = 00304517, "Piledriver\\\\Construct";
IDACS_C_HPOLICEFLAG              = 00304518, "Authority-Totem\\\\Construct";
IDACS_C_HPERIMETER          		= 00304519, "Boundary Signifier";
IDACS_C_HPOLICEFIN          		= 00304520, "Secondary Command\\\\Facility";
IDACS_C_HPOLICEHQ           		= 00304521, "Secondary Command\\\\Facility";
IDACS_C_HPOWERFIN           		= 00304522, "Power\\\\Construct";
IDACS_C_REBELFLAG                = 00304523, "Authority-Totem\\\\Construct";
IDACS_C_HREFINERY           		= 00304524, "Conversion\\\\Construct";
IDACS_C_RESIDENTIALBIG			   = 00304525, "Hub\\\\Macro-Nest";
IDACS_C_RESIDENTIALSMALL    		= 00304526, "Hub\\\\Nest";
IDACS_C_XMARSROCK1          		= 00304527, "Rock";
IDACS_C_XMARSROCK2          		= 00304528, "Rock";
IDACS_C_XMARSROCK3          		= 00304529, "Rock";
IDACS_C_STREETLIGHT				   = 00304530, "Illumination";
IDACS_C_SUPPLYDUMP		   		= 00304531, "Supply\\\\Construct";
IDACS_C_HTRACKING           		= 00304532, "Surveillance\\\\Facility";
IDACS_C_HUPLINK             		= 00304533, "Uplink\\\\Facility";
IDACS_C_HWALLCORN           		= 00304534, "Impediment";
IDACS_C_HWALLDOOR           		= 00304535, "Impediment";
IDACS_C_HWALL               		= 00304536, "Impediment";
IDACS_C_WATERTOWER				   = 00304537, "H2O\\\\Construct";
IDACS_C_WATERCONVERTOR      		= 00304538, "H2O-Converter\\\\Construct";
IDACS_C_ABANDONED                = 00304539, "Null-Occupancy";
                                 
/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED MERCURY SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_XMERCURYROCK1			   = 00304550, "Rock";
IDACS_C_XMERCURYROCK2			   = 00304551, "Rock";
IDACS_C_XMERCURYROCK3			   = 00304552, "Rock";

////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED MOON SHAPES
////////////////////////////////////////////////////////////////////////////////
IDACS_C_MOONBARRACK				   = 00304570, "Combatant Hub\\\\Macro-Nest";
IDACS_C_MOONBIGDISH				   = 00304571, "Uplink\\\\Construct";
IDACS_C_MOONGATHER				   = 00304572, "Gathering";
IDACS_C_MOONLISTEN				   = 00304573, "Surveillance\\\\Facility";
IDACS_C_MOONPLANETDEF            = 00304574, "Anti-Orbital Gun";
IDACS_C_MOONPOWER					   = 00304575, "Generator\\\\Construct";
IDACS_C_MOONREFINERY				   = 00304576, "Refinery\\\\Construct";
IDACS_C_MOONRESIDENCE				= 00304577, "Hub\\\\Macro-Nest";
IDACS_C_MOONSILOS					   = 00304578, "Storage\\\\Construct";
IDACS_C_MOONUPLINK				   = 00304579, "Uplink\\\\Construct";
IDACS_C_MOONWALL					   = 00304580, "Impediment";
IDACS_C_MOONWALLCAP				   = 00304581, "Impediment";
IDACS_C_MOONWALLDOOR				   = 00304582, "Impediment";
IDACS_C_MOONTROOPERCOM				= 00304583, "Communication\\\\Facility";
IDACS_C_MOONGUNBUNKER				= 00304584, "Defense\\\\Construct";
IDACS_C_MOONTROOPERHQ				= 00304585, "Command\\\\Facility";
IDACS_C_MOONTROOPERSILOS			= 00304586, "Storage\\\\Construct";
IDACS_C_MOONTROOPERSTORAGE  		= 00304587, "Supply\\\\Construct";
IDACS_C_MOONTROOPERTRACKING 		= 00304588, "Surveillance\\\\Facility";
IDACS_C_XMOONROCK1					= 00304589, "Rock";
IDACS_C_XMOONROCK2					= 00304590, "Rock";
IDACS_C_XMOONROCK3					= 00304591, "Rock";
IDACS_C_XAPOLLO						= 00304592, "Artifact\\\\Refuse";
IDACS_C_XMOONFLAG				      = 00304593, "Authority-Totem\\\\Construct";

/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED PLUTO SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_XPLUTOROCK1			= 00304600, "Rock";
IDACS_C_XPLUTOROCK2			= 00304601, "Rock";
IDACS_C_XPLUTOROCK3			= 00304602, "Rock";

////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED TEMPERATE SHAPES
////////////////////////////////////////////////////////////////////////////////
IDACS_C_KONGCIVIL				= 00304610, "Convergence\\\\Facility";
IDACS_C_KONGGATHERING		= 00304611, "Convergence\\\\Facility";
IDACS_C_KONGHOUSE				= 00304612, "Hub\\\\Nest";
IDACS_C_KONGOFFICE			= 00304613, "Hub\\\\Macro-Nest";
IDACS_C_KONGPAGODA			= 00304614, "Hub\\\\Nest";
IDACS_C_KONGSLUDGE			= 00304615, "Refuse\\\\Facility";
IDACS_C_KONGTEMPLE			= 00304616, "Creed\\\\Construct";
IDACS_C_KONGLGTEMPLE			= 00304617, "Creed-Authority\\\\Construct";
IDACS_C_KONGDECKHOUSE		= 00304618, "Hub\\\\Nest";
IDACS_C_KONGGATE				= 00304619, "Threshold\\\\Totem";

////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED TITAN SHAPES                                        
////////////////////////////////////////////////////////////////////////////////
IDACS_C_TITANBIGDISH		   = 00304634, "Scanning\\\\Construct";
IDACS_C_TITANDIESIRAE		= 00304635, "Dies Irae\\\\Facility";
IDACS_C_TITANGATHER			= 00304636, "Convergence\\\\Facility";
IDACS_C_TITANLISTEN			= 00304637, "Surveillance\\\\Facility"; 
IDACS_C_TITANMICROWAVE		= 00304638, "Scanning\\\\Construct";
IDACS_C_TITANPOWER			= 00304639, "Generator\\\\Construct";
IDACS_C_XTITANROCK1			= 00304640, "Rock";
IDACS_C_XTITANROCK2			= 00304641, "Rock";
IDACS_C_XTITANROCK3			= 00304642, "Rock";
IDACS_C_TITANREFINERY		= 00304644, "Refinery\\\\Construct";
IDACS_C_TITANRESIDENCE		= 00304645, "Hub\\\\Macro-Nest";
IDACS_C_TITANSILOS			= 00304646, "Storage\\\\Construct";
IDACS_C_TITANUPLINK			= 00304647, "Uplink\\\\Construct";
IDACS_C_TITANWALL				= 00304648, "Impediment";
IDACS_C_TITANWALLCAP			= 00304649, "Impediment";
IDACS_C_TITANWALLDOOR		= 00304650, "Impediment";
IDACS_C_TITANTROOPERCOM		= 00304651, "Communication\\\\Facility";
IDACS_C_TITANTROOPERHQ		= 00304652, "Command\\\\Facility";
IDACS_C_TITANTROOPERRES		= 00304653, "Hub\\\\Macro-Nest";
IDACS_C_TITANTROOPERSILOS	= 00304654, "Storage\\\\Construct";

////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED VENUS SHAPES
////////////////////////////////////////////////////////////////////////////////
IDACS_C_VENUSARRAY			= 00304660, "Array\\\\Construct";
IDACS_C_VENUSARBOR			= 00304661, "Arbor\\\\Construct";
IDACS_C_VENUSBIGDISH			= 00304662, "Scanning\\\\Construct";
IDACS_C_VENUSCOM				= 00304663, "Communication\\\\Facility";
IDACS_C_VENUSCONVERTOR1		= 00304664, "Gas-Conversion\\\\Construct";
IDACS_C_VENUSCONVERTOR2    = 00304665, "Gas-Conversion\\\\Construct";
IDACS_C_VENUSCONVERTOR3    = 00304666, "Gas-Conversion\\\\Construct";
IDACS_C_VENUSDISPERTION		= 00304667, "Expulsion\\\\Construct";
IDACS_C_VENUSDRILL			= 00304668, "Drill\\\\Construct";
IDACS_C_VENUSFLAME			= 00304669, "Creed\\\\Totem";
IDACS_C_VENUSGARAGE			= 00304670, "Garage";
IDACS_C_VENUSGATHERING		= 00304671, "Convergence\\\\Facility";
IDACS_C_VENUSGEOTHERM		= 00304672, "Geothermal\\\\Facility";
IDACS_C_VENUSGUNMOUNT		= 00304673, "Defense-Mount\\\\Construct";
IDACS_C_VENUSLIGHTROD		= 00304674, "Conductor\\\\Construct";
IDACS_C_VENUSLISTENING		= 00304675, "Surveillance\\\\Facility";
IDACS_C_VENUSMICROWAVE		= 00304676, "Scanning\\\\Construct";
IDACS_C_VENUSPERIMWALL		= 00304677, "Impediment";
IDACS_C_VENUSREFINERY		= 00304678, "Refinery\\\\Construct";
IDACS_C_VENUSSMGARAGE		= 00304679, "Bay\\\\Construct";
IDACS_C_VENUSSMWALL			= 00304680, "Impediment";
IDACS_C_VENUSSTORAGE			= 00304681, "Storage\\\\Construct";
IDACS_C_VENUSTRHQ				= 00304682, "Command\\\\Facility";
IDACS_C_VENUSTRLINK			= 00304683, "Link\\\\Construct";
IDACS_C_XVENUSROCK1			= 00304684, "Rock";
IDACS_C_XVENUSROCK2			= 00304685, "Rock";
IDACS_C_XVENUSROCK3			= 00304686, "Rock";

/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED GENERIC SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_XBOXES				   = 00304690, "Micro-Container";
IDACS_C_CONTAINER				= 00304691, "Macro-Container";
IDACS_C_XTROOPERCONTAINER	= 00304692, "Cargo\\\\Construct";
IDACS_C_MONUMENT				= 00304693, "Creed\\\\Totem";
IDACS_C_FUELTANK           = 00304694, "Fuel\\\\Construct";
IDACS_C_HUMANDROPPOD       = 00304695, "Animal Drop Pod";
IDACS_C_OBSTACLE           = 00304696, "Impediment";
IDACS_C_YELLOWFLAG         = 00304697, "YELLOW-Totem\\\\Construct";
IDACS_C_BLUEFLAG           = 00304698, "BLUE-Totem\\\\Construct";	
IDACS_C_REDFLAG            = 00304699, "RED-Totem\\\\Construct";	
IDACS_C_PURPLEFLAG         = 00304700, "PURPLE-Totem\\\\Construct";	
IDACS_C_HEAL               = 00304701, "Repair\\\\Construct";	
IDACS_C_AMMO               = 00304702, "Reload\\\\Construct";	

/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED EUROPA SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_XEUROPAROCK1			= 00304710, "Rock";
IDACS_C_XEUROPAROCK2			= 00304711, "Rock";
IDACS_C_XEUROPAROCK3			= 00304712, "Rock";

/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED ICE SHAPES 
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_HOFFICE            = 00304720, "Hub\\\\Macro-Nest";
IDACS_C_HSNOWCHURCH        = 00304721, "Creed\\\\Facility";
IDACS_C_HSNOWCOM           = 00304722, "Communication\\\\Facility";
IDACS_C_HSNOWLLAND         = 00304723, "Docking\\\\Construct";
IDACS_C_HSNOWRESIDENCE     = 00304724, "Hub\\\\Nest";
IDACS_C_HSNOWSTORAGE       = 00304725, "Storage\\\\Construct";
IDACS_C_HSNOWUPLINK        = 00304726, "Uplink\\\\Facility";
IDACS_C_HSOLARSTATION      = 00304727, "Solar\\\\Facility";
IDACS_C_XSNOWMAN           = 00304728, "Creed-Totem\\\\Construct";
IDACS_C_HGATHERING         = 00304729, "Convergence\\\\Facility";
IDACS_C_XSNOWROCK1         = 00304730, "Rock";
IDACS_C_XSNOWROCK2         = 00304731, "Rock";
IDACS_C_XSNOWROCK3         = 00304732, "Rock";
IDACS_C_XTREE              = 00304733, "Flora";

/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED GENERIC EARTH SHAPES
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_TROOPERBARRACKS		= 00304750, "Hub\\\\Macro-Nest";
IDACS_C_TROOPERBIGDISH		= 00304751, "Uplink\\\\Construct";
IDACS_C_TROOPERCOMM			= 00304752, "Communication\\\\Facility";
IDACS_C_TROOPERGARAGE      = 00304753, "Bay\\\\Construct";
IDACS_C_TROOPERGUNTOWER		= 00304754, "Defense\\\\Construct";
IDACS_C_TROOPERHALL			= 00304755, "Convergence\\\\Facility";
IDACS_C_TROOPERHQ				= 00304756, "Command\\\\Facility";
IDACS_C_TROOPERLISTEN		= 00304757, "Surveillance\\\\Facility";
IDACS_C_TROOPERPOWER			= 00304758, "Generator\\\\Construct";
IDACS_C_TROOPERSUPPLY		= 00304759, "Storage\\\\Construct";
IDACS_C_TROOPERTRACKDISH	= 00304760, "Scanning\\\\Construct";
IDACS_C_TROOPERTRACKBASE	= 00304761, "Surveillance\\\\Facility";
IDACS_C_TROOPERUPLINK		= 00304762, "Uplink\\\\Construct";
IDACS_C_TROOPERPLANTDEF    = 00304763, "Planetary-Defense\\\\Construct";
IDACS_C_TROOPERPOWERPRO    = 00304764, "Energy-Projection\\\\Construct";

///////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED Desert Shapes                                                             //
///////////////////////////////////////////////////////////////////////////////
IDACS_C_DBIGDISH           = 00304781, "Uplink\\\\Construct";
IDACS_C_DCHURCH            = 00304782, "Creed\\\\Facility";
IDACS_C_DDEFENSE           = 00304783, "Planetary-Defense\\\\Construct";
IDACS_C_DDWELLING          = 00304784, "Hub\\\\Nest";
IDACS_C_DGARAGE            = 00304785, "Bay\\\\Construct";
IDACS_C_DGATHERING         = 00304786, "Convergence\\\\Facility";
IDACS_C_DPOWER             = 00304787, "Generator\\\\Construct";
IDACS_C_DSILO              = 00304788, "Storage\\\\Construct";
IDACS_C_DSLUDGE            = 00304789, "Refuse\\\\Construct";
IDACS_C_DUPLINK            = 00304790, "Uplink\\\\Construct";
IDACS_C_DVAPOR             = 00304791, "H2O-Converter\\\\Construct";
IDACS_C_DWATERTOWER        = 00304792, "H2O\\\\Construct";
IDACS_C_DBARRACKS          = 00304793, "Combatant Hub\\\\Macro-Nest";
IDACS_C_DCOMM              = 00304794, "Communication\\\\Facility";
IDACS_C_DTROOPGARAGE       = 00304795, "Bay\\\\Construct";
IDACS_C_DTROOPHALL         = 00304796, "Hub\\\\Macro-Nest";
IDACS_C_DTROOPHQ           = 00304797, "Command\\\\Facility";

///////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED Cybrid Shapes                                               `             //
///////////////////////////////////////////////////////////////////////////////
IDACS_C_CBOMBERBAY         = 00304810, "NEXT Bomber\\\\Bay";
IDACS_C_CCOMM              = 00304811, "NEXT Communications\\\\Construct";
IDACS_C_CDROPPOD           = 00304812, "NEXT Drop Pod";
IDACS_C_CENTRANCE          = 00304813, "NEXT Entrance\\\\Construct";
IDACS_C_CGENERATOR         = 00304814, "NEXT Generator\\\\Construct";
IDACS_C_CMOTION            = 00304815, "NEXT Motion Detector\\\\Construct";
IDACS_C_CNEXUS             = 00304816, "NEXT Mobile Nexus";
IDACS_C_CPOST              = 00304817, "NEXT Boundary-Totem";
IDACS_C_CPOWER             = 00304818, "NEXT Generator\\\\Construct";
IDACS_C_CRELAY             = 00304819, "NEXT Relay\\\\Construct";
IDACS_C_CSEARCH            = 00304820, "NEXT Array\\\\Construct";
IDACS_C_CSTORAGE           = 00304821, "NEXT Storage\\\\Construct";
IDACS_C_CTRACKING          = 00304822, "NEXT Surveillance\\\\Construct";
IDACS_C_CUPLINK            = 00304823, "NEXT Uplink\\\\Construct";
IDACS_C_CWALL              = 00304824, "NEXT Impediment";
IDACS_C_CTEMPLEWALL        = 00304825, "NEXT Creed\\\\Impediment";


/////////////////////////////////////////////////////////////////////////////////
// CYBRIDIZED Mission Specific Structure Names
/////////////////////////////////////////////////////////////////////////////////
IDACS_C_COMMAND            = 00304838, "Command\\\\Facility";
IDACS_C_XXBARRACKS         = 00304839, "Combatant Hub\\\\Macro-Nest";
IDACS_C_IMPTURRET          = 00304840, "Turret\\\\Construct";
IDACS_C_POWERGENERATOR     = 00304841, "Generator\\\\Construct";
IDACS_C_TURRET1            = 00304842, "Turret\\\\Construct";
IDACS_C_TURRET2            = 00304843, "Turret\\\\Construct";
IDACS_C_TURRET3            = 00304844, "Turret\\\\Construct";
IDACS_C_TURRET4            = 00304845, "Turret\\\\Construct";
IDACL_C_RESIDENTIALSMALL1  = 00304846, "Noncombatant Hub\\\\Nest";
IDACL_C_NAVARESHOUSE       = 00304847, "Navare Command\\\\Facility";
IDACL_C_HMEETHALL1         = 00304848, "Marushak Hub\\\\Macro-Nest";
IDACL_C_HPOLICEHQ1         = 00304849, "Secondary Command\\\\Facility";
IDACL_C_HGARAGE1           = 00304850, "Intoxicant\\\\Depository";
IDACL_C_HGARAGE2           = 00304851, "Refuse\\\\Depository";
IDACL_C_HREFINERY1         = 00304852, "Munitions-Refinery\\\\Facility";
IDACL_C_CAANONDROPPOD      = 00304853, "Icehawk\\\\Predator Drop Pod";
IDACL_C_IMPERIALCACHE      = 00304854, "Munitions\\\\Depository";
IDACL_C_HEADQUARTERS       = 00304855, "Command\\\\Facility";
IDACS_C_AMMOBOX            = 00304856, "Ammunition\\\\Construct";
IDACL_C_WEAPONBOX          = 00304857, "Weapon\\\\Construct";
IDACS_C_NOPOWERTURRET      = 00304858, "Turret\\\\Offline";
IDACS_C_TURRETCONTROL      = 00304959, "Turret-Control\\\\Construct";

IDDAT_END_C_ACTOR_DESCRIP  = 00304999, "-- Actor Descriptions DATA group reserves tags 304,501 - 304,999 -";


///////////////////////////////////////////////////////////////////////////////
// COMPONENT DESCRIPTION TAGS ( IDCOM )                                      //
///////////////////////////////////////////////////////////////////////////////
IDDAT_BEG_COMPONENT       		= 00301000, "-- Vehicle Component Descriptions DATA group reserves tags 301,000 - 301,099 --";
IDCOM_PILOT               		= 00301001, "Pilot";
IDCOM_ENGINE              		= 00301002, "Engine";
IDCOM_POWERPLANT          		= 00301003, "Power Plant";
IDCOM_SHIELDGEN           		= 00301004, "Shield Generator";
IDCOM_TRANSMISSION        		= 00301005, "Transmission";
IDCOM_SENSORS             		= 00301006, "Sensors";
IDCOM_COMPUTER            		= 00301007, "Computer";
IDCOM_CHASSIS             		= 00301008, "Chassis";
IDCOM_SKIRT               		= 00301009, "Skirt";
IDCOM_ARMOR               		= 00301010, "Armor";
IDCOM_LEFT_LEG_SERVOS     		= 00301011, "Left Leg Servos";
IDCOM_RIGHT_LEG_SERVOS    		= 00301012, "Right Leg Servos";
IDCOM_LEFT_TREAD_SERVOS   		= 00301013, "Left Tread Servos";
IDCOM_RIGHT_TREAD_SERVOS  		= 00301014, "Right Tread Servos";
IDCOM_LEFT_WING_SERVOS    		= 00301015, "Left Wing Servos";
IDCOM_RIGHT_WING_SERVOS   		= 00301016, "Right Wing Servos";
IDCOM_CLOAK               		= 00301017, "Cloak Mechanism";

IDCOM_HEAD                		= 00301021, "Head";
IDCOM_PELVIS              		= 00301022, "Pelvis";
IDCOM_LEFT_POD            		= 00301023, "Left_Pod1";
IDCOM_RIGHT_POD           		= 00301024, "Right_Pod1";
IDCOM_LEFT_THIGH          		= 00301025, "Left_Thigh";
IDCOM_RIGHT_THIGH         		= 00301026, "Right_Thig";
IDCOM_LEFT_LEG            		= 00301027, "Left_Leg";
IDCOM_RIGHT_LEG           		= 00301028, "Right_Leg";
IDCOM_LEFT_CALF           		= 00301029, "Left_Calf";
IDCOM_RIGHT_CALF          		= 00301030, "Right_Calf";
IDCOM_LEFT_FOOT           		= 00301031, "Left_Foot";
IDCOM_RIGHT_FOOT          		= 00301032, "Right_Foot";
IDCOM_BODY                		= 00301040, "Body";
IDCOM_LEFT_TREAD          		= 00301041, "Left_Tread";
IDCOM_RIGHT_TREAD         		= 00301042, "Right_Tread";
IDCOM_REAR_TREAD          		= 00301043, "Rear_Tread";
IDCOM_BUMPER              		= 00301044, "Bumper";
IDCOM_LEFT_WING           		= 00301045, "Left_Wing";
IDCOM_RIGHT_WING          		= 00301046, "Right_Wing";
IDCOM_LEFT_ENGINE         		= 00301047, "Left_Engine";
IDCOM_RIGHT_ENGINE        		= 00301048, "Right_Engine";
IDCOM_TAIL                		= 00301049, "Tail";
IDCOM_CARGOA                	= 00301050, "Cargo_A";
IDCOM_CARGOB                	= 00301051, "Cargo_B";

IDDAT_END_COMPONENT       		= 00301099, "-- Vehicle Component Descriptions DATA group reserves tags 301,000 - 301,099 --";

///////////////////////////////////////////////////////////////////////////////
// WEAPON DESCRIPTION TAGS ( IDWEA )
///////////////////////////////////////////////////////////////////////////////
IDDAT_BEG_WEAPON          		= 00301200, "-- Weapon Descriptions DATA group reserves tags 301,200 - 301,699 --";

// energy weapons first
IDWEA_LAS                 		= 00301201, "LAS";
IDWDESC_LAS               		= 00301202, "Laser";
IDWEA_HLAS                		= 00301203, "HLAS";
IDWDESC_HLAS              		= 00301204, "Heavy Laser";
IDWEA_CLAS                		= 00301205, "CLAS";
IDWDESC_CLAS              		= 00301206, "Compression Laser";
IDWEA_TLAS                		= 00301207, "TLAS";
IDWDESC_TLAS              		= 00301208, "Twin Laser";
IDWEA_EMP                 		= 00301209, "EMP";
IDWDESC_EMP               		= 00301210, "Electro-Magnetic Pulse Cannon";
IDWEA_ELF                 		= 00301211, "ELF";
IDWDESC_ELF               		= 00301212, "Electron Flux Whip";
IDWEA_BLAS                		= 00301213, "BLAS";
IDWDESC_BLAS              		= 00301214, "Blaster";
IDWEA_HBLA                		= 00301215, "HBLA";
IDWDESC_HBLA              		= 00301216, "Heavy Blaster";
IDWEA_PBW                 		= 00301217, "PBW";
IDWDESC_PBW               		= 00301218, "Particle Beam Weapon";
       
// quantum weapons
IDWEA_PLAS                		= 00301240, "PLAS";
IDWDESC_PLAS              		= 00301241, "Plasma";
IDWEA_BLNK                		= 00301242, "BLNK";
IDWDESC_BLNK              		= 00301243, "Blink Gun";
IDWEA_QGUN                		= 00301244, "QGUN";
IDWDESC_QGUN              		= 00301245, "Quantum Gun";
IDWEA_MFAC                		= 00301246, "MFAC";
IDWDESC_MFAC              		= 00301247, "Magneto-Fusion Assault Cannon";
IDWEA_NANO                		= 00301248, "NANO";
IDWDESC_NANO              		= 00301249, "Nano-Infuser";
IDWEA_NCAN                		= 00301250, "NCAN";
IDWDESC_NCAN              		= 00301251, "Nanite Cannon";
IDWEA_SGUN                    = 00301252, "SGUN";
IDWDESC_SGUN             		= 00301253, "Smart Gun";


// ballistic weapons
IDWEA_ATC                 		= 00301280, "ATC";
IDWDESC_ATC               		= 00301281, "Autocannon";
IDWEA_HATC                		= 00301282, "HATC";
IDWDESC_HATC              		= 00301283, "Heavy Autocannon";
IDWEA_EMC                 		= 00301284, "EMC";
IDWDESC_EMC               		= 00301285, "Electro-Mag Autocannon";
IDWEA_BC                  		= 00301286, "BC";
IDWDESC_BC                		= 00301287, "Blast Cannon";
IDWEA_HBC                 		= 00301288, "HBC";
IDWDESC_HBC               		= 00301289, "Heavy Blast Cannon";
IDWEA_RAIL                		= 00301290, "RAIL";
IDWDESC_RAIL              		= 00301291, "Railgun";

// bombs
IDWEA_LGB                 		= 00301320, "LGB";
IDWDESC_LGB               		= 00301321, "Laser-guided Bomb";
IDWEA_HAD                 		= 00301322, "HAD";
IDWDESC_HAD               		= 00301323, "Hades";

// missles
IDWEA_VIP8                		= 00301360, "VIP8";
IDWDESC_VIP8              		= 00301361, "Pit Viper Missile 8-Pack";
IDWEA_VIP12               		= 00301362, "VIP12";
IDWDESC_VIP12             		= 00301363, "Pit Viper Missile 12-Pack";
IDWEA_SPR6                		= 00301364, "SPR6";
IDWDESC_SPR6              		= 00301365, "Sparrow Missile 6-Pack";
IDWEA_SPR10               		= 00301366, "SPR10";
IDWDESC_SPR10             		= 00301367, "Sparrow Missile 10-Pack";
IDWEA_SWRM                		= 00301368, "SWRM";
IDWDESC_SWRM              		= 00301369, "SWARM Missile 6-Pack";
IDWEA_MIN                 		= 00301370, "MIN";
IDWDESC_MIN               		= 00301371, "Minion Missile 10-Pack";
IDWEA_SHRK                		= 00301372, "SHRK";
IDWDESC_SHRK              		= 00301373, "Shrike Missile 8-Pack";
IDWEA_APHID               		= 00301374, "APHID";
IDWDESC_APHID             		= 00301375, "APHID Agile Missile 10-Pack";


// mines
IDWEA_ARA4                		= 00301400, "ARA6";
IDWDESC_ARA4              		= 00301401, "Arachnitron 6-Pack Mine";
IDWEA_ARA8                		= 00301402, "ARA10";
IDWDESC_ARA8              		= 00301403, "Arachnitron 10-Pack Mine";
IDWEA_ARA12               		= 00301404, "ARA14";
IDWDESC_ARA12             		= 00301405, "Arachnitron 14-Pack Mine";
IDWEA_PRX6                		= 00301406, "PRX6";
IDWDESC_PRX6              		= 00301407, "HHG Proximity Charge 6";
IDWEA_PRX10               		= 00301408, "PRX8";
IDWDESC_PRX10             		= 00301409, "HHG Proximity Charge 8";
IDWEA_PRX15               		= 00301410, "PRX10";
IDWDESC_PRX15             		= 00301411, "HHG Proximity Charge 10";
IDWEA_CMD10               		= 00301412, "CMD10";
IDWDESC_CMD10             		= 00301413, "Command Detonated 10-Pack";
IDWEA_CMD15               		= 00301414, "CMD15";
IDWDESC_CMD15             		= 00301415, "Command Detonated 15-Pack";
IDWEA_CMD20               		= 00301416, "CMD20";
IDWDESC_CMD20             		= 00301417, "Command Detonated 20-Pack";
       
// artillery weapons
IDWEA_NIKE                		= 00301440, "NIKE";
IDWDESC_NIKE              		= 00301441, "Nike Siege Gun";
IDWEA_AML                 		= 00301442, "AML";
IDWDESC_AML               		= 00301443, "Artillery Missile Launcher";
IDWEA_CYART                   = 00301444, "CYARTL";
IDWDESC_CYART                 = 00301445, "Cybrid Artillery Gun";
IDWEA_RBART                   = 00301446, "RBARTL";
IDWDESC_RBART                 = 00301447, "Rebel Artillery Gun";

// special effect weapons
IDWEA_RAD                 		= 00301480, "RAD";
IDWDESC_RAD               		= 00301481, "Radiation Gun";
IDWEA_DIS                 		= 00301482, "DIS";
IDWDESC_DIS               		= 00301483, "Disrupter";
IDWEA_EHUL                		= 00301484, "EHUL";
IDWDESC_EHUL              		= 00301485, "Electrohull";
IDWEA_PROB                		= 00301486, "PROB";
IDWDESC_PROB              		= 00301487, "Seismic Probe";
IDWEA_FOG                 		= 00301488, "FOG";
IDWDESC_FOG               		= 00301489, "Finger of God";


// turret-only (oversize) weapons
IDWEA_TUR_HLAS                = 00301700, "TUR HLAS";
IDWDESC_TUR_HLAS           	  = 00301701, "Turret Heavy Laser";
IDWEA_TUR_IVIP1           	  = 00301702, "TUR IVIP1";
IDWDESC_TUR_IVIP1         	  = 00301703, "Turret Internal Pit Viper Single-Shot";
IDWEA_TUR_IHLAS            	  = 00301704, "TUR IHLAS";
IDWDESC_TUR_IHLAS          	  = 00301705, "Turret Internal Heavy Laser";
IDWEA_TUR_CAN             	  = 00301706, "TUR CAN";
IDWDESC_TUR_CAN           	  = 00301707, "Turret Cannon";
IDWEA_TUR_ARTL            	  = 00301708, "TUR ARTL";
IDWDESC_TUR_ARTL          	  = 00301709, "Turret Artillery";
IDWEA_TUR_ISENT           	  = 00301710, "TUR ISENT";
IDWDESC_TUR_ISENT         	  = 00301711, "Turret Internal Sentry";
IDWEA_TUR_HATC           	  = 00301712, "TUR HATC";
IDWDESC_TUR_HATC         	  = 00301713, "Turret Heavy Autocannon";
IDWEA_TUR_MFAC                = 00301714, "TUR MFAC";
IDWDESC_TUR_MFAC           	  = 00301715, "Turret MFAC Retrofit";

IDDAT_END_WEAPON          		= 00301999, "-- Weapon Descriptions DATA group reserves tags 301,200 - 301,999 --";

//reactors
//NOTE TO TRANSLATORS The first entry for each item (the one with out the _L) can only 
//be about 6-8 characters in length	maximum or it won't fit in the required space
IDDAT_BEG_REACTOR         		= 00302000, "-- Reactor Descriptions DATA group reserves tags 302,000 - 302,099 --";
IDREA_HUM						   = 00302001, "Placeholder";
IDREA_HUM_L					      = 00302002, "Placeholder Reactor";
IDREA_HUM1				   		= 00302003, "Micro";
IDREA_HUM1_L					   = 00302004, "Micro Reactor";
IDREA_HUM2				   		= 00302005, "Small";
IDREA_HUM2_L					   = 00302006, "Small Reactor";
IDREA_HUM3				   		= 00302007, "Standard";
IDREA_HUM3_L					   = 00302008, "Standard Reactor";
IDREA_HUM4				   		= 00302009, "Medium";
IDREA_HUM4_L					   = 00302010, "Medium Reactor";
IDREA_HUM5				   		= 00302011, "Large";
IDREA_HUM5_L					   = 00302012, "Large Reactor";
IDREA_HUM6				   		= 00302013, "Maxim";
IDREA_HUM6_L					   = 00302014, "Maxim Reactor";
IDREA_HUM7				   		= 00302015, "Extra1 h";
IDREA_HUM7_L					   = 00302016, "Extra1 Human Reactor";
IDREA_HUM8				   		= 00302017, "Extra2 h";
IDREA_HUM8_L					   = 00302018, "Extra2 Human Reactor";
IDREA_HUM9				   		= 00302019, "Extra3 h";
IDREA_HUM9_L					   = 00302020, "Extra3 Human Reactor";
IDREA_HUM10					      = 00302021, "Extra4 h";
IDREA_HUM10_L				      = 00302022, "Extra4 Human Reactor";
IDREA_HUM11					      = 00302023, "Extra5 h";
IDREA_HUM11_L				      = 00302024, "Extra5 Human Reactor";
IDREA_HUM12					      = 00302025, "Extra6 h";
IDREA_HUM12_L				      = 00302026, "Extra6 Human Reactor";
IDREA_HUM13					      = 00302027, "Extra7 h";
IDREA_HUM13_L				      = 00302028, "Extra7 Human Reactor";
IDREA_HUM14					      = 00302029, "Extra8 h";
IDREA_HUM14_L				      = 00302030, "Extra8 Human Reactor";
IDREA_HUM15					      = 00302031, "Extra9 h";
IDREA_HUM15_L				      = 00302032, "Extra9 Human Reactor";
IDREA_HUM16					      = 00302033, "Extra10 h";
IDREA_HUM16_L				      = 00302034, "Extra10 Human Reactor";
IDREA_HUM17					      = 00302035, "Extra11 h";
IDREA_HUM17_L				      = 00302036, "Extra11 Human Reactor";
IDREA_HUM18					      = 00302037, "Extra12 h";
IDREA_HUM18_L				      = 00302038, "Extra12 Human Reactor";
IDREA_HUM19					      = 00302039, "Extra13 h";
IDREA_HUM19_L				      = 00302040, "Extra13 Human Reactor";
IDREA_HUM24					      = 00302049, "Gimp";
IDREA_HUM24_L					   = 00302050, "iCutChOO Reactor";
//Cybrid Reactors
IDREA_CYB1				   	   = 00302051, "Alpha";
IDREA_CYB1_L					   = 00302052, "Alpha Reactor";
IDREA_CYB2				   	   = 00302053, "Beta";
IDREA_CYB2_L					   = 00302054, "Beta Reactor";
IDREA_CYB3				   	   = 00302055, "Gamma";
IDREA_CYB3_L					   = 00302056, "Gamma Reactor";
IDREA_CYB4				   	   = 00302057, "Delta";
IDREA_CYB4_L					   = 00302058, "Delta Reactor";
IDREA_CYB5				   	   = 00302059, "Epsilon";
IDREA_CYB5_L					   = 00302060, "Epsilon Reactor";
IDREA_CYB6				   	   = 00302061, "Zeta";
IDREA_CYB6_L					   = 00302062, "Zeta Reactor";
IDDAT_END_REACTOR				   = 00302099, "-- Reactor Descriptions DATA group reserves tags 302,000 - 302,099 --";

//Sensors
//NOTE TO TRANSLATORS The first entry for each item (the one with out the _L) can only 
//be about 6-8 characters in length	maximum or it won't fit in the required space
IDDAT_BEG_SENSOR         	= 00302100, "-- Sensor Descriptions DATA group reserves tags 302,100 - 302,199 --";
IDSEN_HUM1				   	    = 00302101, "Basic";
IDSEN_HUM1_L					= 00302102, "Basic Sensor";
IDSEN_HUM2				   	    = 00302103, "Watch";
IDSEN_HUM2_L					= 00302104, "Watchdog Sensor";
IDSEN_HUM3				   	    = 00302105, "Sentinel";
IDSEN_HUM3_L					= 00302106, "Sentinel Sensor";
IDSEN_HUM4				   	    = 00302107, "Scout";
IDSEN_HUM4_L					= 00302108, "Scout Sensor";
IDSEN_HUM5				   	    = 00302109, "Tracker";
IDSEN_HUM5_L					= 00302110, "Tracker Sensor";
IDSEN_HUM6				   	    = 00302111, "Path";
IDSEN_HUM6_L					= 00302112, "Pathfinder Sensor";
IDSEN_HUM7				   	    = 00302113, "Ranger";
IDSEN_HUM7_L					= 00302114, "Ranger Sensor";
IDSEN_HUM8				   	    = 00302115, "Emiss";
IDSEN_HUM8_L					= 00302116, "Emission Scanning Sensor";
IDSEN_HUM9				   	    = 00302117, "Standard";
IDSEN_HUM9_L					= 00302118, "Standard Sensor";
IDSEN_HUM10 			   	    = 00302119, "Longbow";
IDSEN_HUM10_L					= 00302120, "Longbow Sensor";
IDSEN_HUM11			   		    = 00302121, "Inflt";
IDSEN_HUM11_L					= 00302122, "Infiltrator Sensor";
IDSEN_HUM12			   		    = 00302123, "Cross";
IDSEN_HUM12_L					= 00302124, "Crossbow Sensor";
IDSEN_HUM13			   		    = 00302125, "Utlight";
IDSEN_HUM13_L					= 00302126, "Ultralight Sensor";
IDSEN_HUM14			   		    = 00302127, "Hound";
IDSEN_HUM14_L					= 00302128, "Bloodhound Sensor";
IDSEN_HUMXX			   		    = 00302147, "Bogus";
IDSEN_HUMXX_L					= 00302148, "Placeholder Sensor";
IDSEN_HUM25					    = 00302149, "ICU";
IDSEN_HUM25_L					= 00302150, "U can run but U  can't hide";
//Cybrid Sensors
IDSEN_CYB1						= 00302151, "Alpha";
IDSEN_CYB1_L					= 00302152, "Cybrid Basic Sensor";
IDSEN_CYB2						= 00302153, "Beta";
IDSEN_CYB2_L					= 00302154, "Cybrid Enhanced Range Sensor";
IDSEN_CYB3						= 00302155, "Gamma";
IDSEN_CYB3_L					= 00302156, "Cybrid Intermediate Sensor";
IDSEN_CYB4						= 00302157, "Delta";
IDSEN_CYB4_L					= 00302158, "Cybrid Long-Range Sensor";
IDSEN_CYB5						= 00302159, "Epsilon";
IDSEN_CYB5_L					= 00302160, "Cybrid Enhanced Passive Sensor";
IDSEN_CYB6						= 00302161, "Zeta";
IDSEN_CYB6_L					= 00302162, "Cybrid Extended Range Sensor";
IDSEN_CYB7						= 00302163, "Eta";
IDSEN_CYB7_L					= 00302164, "Cybrid Compact Sensor";
IDSEN_CYB8						= 00302165, "Theta";
IDSEN_CYB8_L					= 00302166, "Cybrid Enhanced Tracker Sensor";
IDSEN_CYB9						= 00302167, "Iota";
IDSEN_CYB9_L					= 00302168, "Cybrid Motion Sensor";
IDSEN_CYB10					    = 00302169, "AA";
IDSEN_CYB10_L				    = 00302170, "Anti-air Sensor";
IDSEN_CYB11					    = 00302171, "Advanced";
IDSEN_CYB11_L				    = 00302172, "Advanced Sensor";
IDSEN_CYB12					    = 00302173, "Compact";
IDSEN_CYB12_L				    = 00302174, "Compact Sensor";
IDSEN_CYB13					    = 00302175, "Emiss";
IDSEN_CYB13_L				    = 00302176, "Emission Scanner";

IDDAT_END_SENSOR         	= 00302199, "-- Sensor Descriptions DATA group reserves tags 302,100 - 302,199 --";

//NOTE TO TRANSLATORS The first entry for each item (the one with out the _L) can only 
//be about 6-8 characters in length	maximum or it won't fit in the required space

IDDAT_BEG_SHIELD         	    = 00302200, "-- SHIELD Descriptions DATA group reserves tags 302,200 - 302,299 --";
IDSHL_HUM1				   	    = 00302201, "Standard";
IDSHL_HUM1_L					= 00302202, "Standard Shield Generator";
IDSHL_HUM2				   	    = 00302203, "Protector";
IDSHL_HUM2_L					= 00302204, "Protector Shield Generator";
IDSHL_HUM3				   	    = 00302205, "Guardian";
IDSHL_HUM3_L					= 00302206, "Guardian Shield Generator";
IDSHL_HUM4				   	    = 00302207, "Fast";
IDSHL_HUM4_L					= 00302208, "FastCharge Shield Generator";
IDSHL_HUM5				   	    = 00302209, "Centurion";
IDSHL_HUM5_L					= 00302210, "Centurion Shield Generator";
IDSHL_HUM6				   	    = 00302211, "Repulsor";
IDSHL_HUM6_L					= 00302212, "Repulsor Shield Generator";
IDSHL_HUM7				   	    = 00302213, "Titan";
IDSHL_HUM7_L					= 00302214, "Titan Shield Generator";
IDSHL_HUM8				   	    = 00302215, "Medusa";
IDSHL_HUM8_L					= 00302216, "Medusa Shield Generator";
IDSHL_HUM9				   	    = 00302217, "H Extra1";
IDSHL_HUM9_L					= 00302218, "Human Extra1 Shield Generator";
IDSHL_HUM10			   		    = 00302219, "H Extra2";
IDSHL_HUM10_L					= 00302220, "Human Extra2 Shield Generator";
IDSHL_HUMXX			   		    = 00302247, "Bogus";
IDSHL_HUMXX_L					= 00302248, "Placeholder Shield Generator";
IDSHL_HUM25			   		    = 00302249, "Impervion";
IDSHL_HUM25_L					= 00302250, "Impervion Shield Generator";
//Cybrid Shield Generator
IDSHL_CYB1				   	    = 00302251, "Alpha";
IDSHL_CYB1_L					= 00302252, "Alpha Shield Generator";
IDSHL_CYB2				   	    = 00302253, "Beta";
IDSHL_CYB2_L					= 00302254, "Beta Shield Generator";
IDSHL_CYB3				   	    = 00302255, "Gamma";
IDSHL_CYB3_L					= 00302256, "Gamma Shield Generator";
IDSHL_CYB4				   	    = 00302257, "Delta";
IDSHL_CYB4_L					= 00302258, "Delta Shield Generator";
IDSHL_CYB5				   	    = 00302259, "Epsilon";
IDSHL_CYB5_L					= 00302260, "Epsilon Shield Generator";
IDSHL_CYB6				   	    = 00302261, "Zeta";
IDSHL_CYB6_L					= 00302262, "Zeta Shield Generator";
IDSHL_CYB7				   	    = 00302263, "Eta";
IDSHL_CYB7_L					= 00302264, "Eta Shield Generator";
IDSHL_CYB8				   	    = 00302265, "Theta";
IDSHL_CYB8_L					= 00302266, "Theta Shield Generator";

IDDAT_END_SHIELD         	= 00302299, "-- SHIELD Descriptions DATA group reserves tags 302,200 - 302,299 --";

//NOTE TO TRANSLATORS The first entry for each item (the one with out the _L) can only 
//be about 6-8 characters in length	maximum or it won't fit in the required space

IDDAT_BEG_ENGINE         	= 00302300, "-- ENGINE Descriptions DATA group reserves tags 302,300 - 302,399 --";
IDENG_HUM1				  		= 00302301, "Light";
IDENG_HUM1_L			  		= 00302302, "Light Engine";
IDENG_HUM2				  		= 00302303, "Med HO";
IDENG_HUM2_L			  		= 00302304, "Medium High Output Engine";
IDENG_HUM3				  		= 00302305, "H CRU";
IDENG_HUM3_L			  		= 00302306, "Heavy Cruise Engine";
IDENG_HUM4				  		= 00302307, "Lite HO";
IDENG_HUM4_L			  		= 00302308, "Light High Output Engine";
IDENG_HUM5				  		= 00302309, "M AGL";
IDENG_HUM5_L			  		= 00302310, "Medium Agility Engine";
IDENG_HUM6				  		= 00302311, "Hvy HO";
IDENG_HUM6_L			  		= 00302312, "Heavy High Output Engine";
IDENG_HUM7				  		= 00302313, "L AGL";
IDENG_HUM7_L			  		= 00302314, "Light Agility Engine";
IDENG_HUM8				  		= 00302315, "Heavy";
IDENG_HUM8_L			  		= 00302316, "Standard Heavy Engine";
IDENG_HUM9				  		= 00302317, "H AGL";
IDENG_HUM9_L			  		= 00302318, "Heavy Agility Engine";
IDENG_HUM10			  		    = 00302319, "Medium";
IDENG_HUM10_L			  		= 00302320, "Standard Medium Engine";
IDENG_HUM11			  		    = 00302321, "I Hvy";
IDENG_HUM11_L			  		= 00302322, "Improved Heavy Engine";
IDENG_HUM12			  		    = 00302323, "AST";
IDENG_HUM12_L			  		= 00302324, "Standard Assault Engine";
IDENG_HUM13			  		    = 00302325, "I AST";
IDENG_HUM13_L			  		= 00302326, "Improved Assault Engine";
IDENG_HUM14			  		    = 00302327, "S/H";
IDENG_HUM14_L			  		= 00302328, "Super Heavy Engine";
IDENG_HUM15			  		    = 00302329, "HT";
IDENG_HUM15_L			  		= 00302330, "Heavy Turbine Engine";
IDENG_HUM16			  		    = 00302331, "HOT";
IDENG_HUM16_L			  		= 00302332, "High Output Turbine Engine";
IDENG_HUM25			  		    = 00302349, "Rocket";
IDENG_HUM25_L			  		= 00302350, "Rocket Man Engine";

//Cybrid Engines
IDENG_CYB1				  		= 00302351, "Alpha";
IDENG_CYB1_L			  		= 00302352, "Alpha Light Vehicle Engine";
IDENG_CYB2				  		= 00302353, "Beta";
IDENG_CYB2_L			  		= 00302354, "Beta Light Agility Engine";
IDENG_CYB3				  		= 00302355, "Gamma";
IDENG_CYB3_L			  		= 00302356, "Gamma Standard Medium Engine";
IDENG_CYB4				  		= 00302357, "Delta";
IDENG_CYB4_L			  		= 00302358, "Delta Medium Cruise Engine";
IDENG_CYB5				  		= 00302359, "Epsilon";
IDENG_CYB5_L			  		= 00302360, "Epsilon Improved Medium Engine";
IDENG_CYB6				  		= 00302361, "Zeta";
IDENG_CYB6_L			  		= 00302362, "Zeta Medium High Output Engine";
IDENG_CYB7				  		= 00302363, "Eta";
IDENG_CYB7_L			  		= 00302364, "Eta Medium Agility Engine";
IDENG_CYB8				  		= 00302365, "Theta";
IDENG_CYB8_L			  		= 00302366, "Theta Standard Heavy Engine";
IDENG_CYB9				  		= 00302367, "Iota";
IDENG_CYB9_L			  		= 00302368, "Iota Heavy High Output Engine";
IDENG_CYB10			  		    = 00302369, "Kappa";
IDENG_CYB10_L			  		= 00302370, "Kappa Heavy Agility Engine";
IDENG_CYB11			  		    = 00302371, "Lamda";
IDENG_CYB11_L			  		= 00302372, "Lamda Standard Assault Engine";
IDENG_CYB12			  		    = 00302373, "Mu";
IDENG_CYB12_L			  		= 00302374, "Mu Improved Assault Engine";
IDENG_CYB13			  		    = 00302375, "Nu";
IDENG_CYB13_L			  		= 00302376, "Nu High Output Assault Engine";
IDENG_CYB14			  		    = 00302377, "Xi";
IDENG_CYB14_L			  		= 00302378, "Xi Heavy Assault Engine";
IDENG_CYB15			  		    = 00302379, "Omicron";
IDENG_CYB15_L			  		= 00302380, "Omicron Heavy Assault Turbine";
IDENG_CYB16			  		    = 00302381, "Pi";
IDENG_CYB16_L			  		= 00302382, "Pi Super Heavy Turbine";


IDDAT_END_ENGINE		  		= 00302399, "-- ENGINE Descriptions DATA group reserves tags 302,300 - 302,399 --";
//NOTE TO TRANSLATORS The first entry for each item (the one without the _L) can only 
//be about 6-8 characters in length	maximum or it won't fit in the required space


IDDAT_BEG_INTERNALMOUNTS 	= 00302400, "-- INTERNALMOUNTS Descriptions DATA group reserves tags 302,400 - 302,499 --";
IDMNT_PIL				  		= 00302401, "Pilot";
IDMNT_PIL_L			  		    = 00302402, "Pilot";
IDMNT_CMP_HUM1				  	= 00302403, "166";
IDMNT_CMP_HUM1_L			  	= 00302404, "Basic Computer Suite";
IDMNT_CMP_HUM2				  	= 00302405, "300";
IDMNT_CMP_HUM2_L			  	= 00302406, "Improved Computer Suite";
IDMNT_CMP_HUM3				  	= 00302407, "450";
IDMNT_CMP_HUM3_L			  	= 00302408, "Advanced Computer Suite";
IDMNT_CMP_CYB1				  	= 00302409, "Alpha";
IDMNT_CMP_CYB1_L			  	= 00302410, "Cybrid Basic Systems Control";
IDMNT_CMP_CYB2				  	= 00302411, "Beta";
IDMNT_CMP_CYB2_L			  	= 00302412, "Cybrid Enhanced System Control";
IDMNT_CMP_CYB3				  	= 00302413, "Gamma";
IDMNT_CMP_CYB3_L			  	= 00302414, "Cybrid Adv. System Control";
IDMNT_ECM1				  		= 00302415, "ECM-G";
IDMNT_ECM1_L			  		= 00302416, "Guardian ECM Jammer";
IDMNT_ECM2				  		= 00302417, "ECM-D";
IDMNT_ECM2_L			  		= 00302418, "Doppleganger ECM Jammer";
IDMNT_ECM3				  		= 00302419, "Alpha CM";
IDMNT_ECM3_L			  		= 00302420, "Cybrid Alpha ECM Jammer";
IDMNT_ECM4				  		= 00302421, "Beta CM";
IDMNT_ECM4_L			  		= 00302422, "Cybrid Beta ECM Jammer";
IDMNT_DIF1				  		= 00302423, "Therm";
IDMNT_DIF1_L			  		= 00302424, "Thermal Diffusion Jammer";
IDMNT_FLR				  		= 00302429, "Flares";
IDMNT_FLR_L			  		    = 00302430, "IR Flares";
IDMNT_CLK1				  		= 00302431, "Cham";
IDMNT_CLK1_L			  		= 00302432, "Chameleon Cloak";
IDMNT_CLK2				  		= 00302433, "Cut";
IDMNT_CLK2_L			  		= 00302434, "Cuttlefish Cloak";
IDMNT_SMOD				  		= 00302441, "SMOD";
IDMNT_SMOD_L			  		= 00302442, "Shield Modulator";
IDMNT_SCAP				  		= 00302443, "SCAP";
IDMNT_SCAP_L			  		= 00302444, "Shield Capacitor";
IDMNT_SAMP				  		= 00302445, "SAMP";
IDMNT_SAMP_L			  		= 00302446, "Shield Amplifier";
IDMNT_LTAD				  		= 00302451, "LTADS";
IDMNT_LTAD_L			  		= 00302452, "Laser Target Designator";
IDMNT_BAT				  		= 00302453, "Battery";
IDMNT_BAT_L			  		    = 00302454, "Auxiliary Power Storage";
IDMNT_CAP				  		= 00302455, "CAP";
IDMNT_CAP_L			  		    = 00302456, "Energy Capacitor";
IDMNT_FSTB				  		= 00302457, "Field";
IDMNT_FSTB_L			  		= 00302458, "Field Stabilizer";
IDMNT_RBST				  		= 00302459, "Rocket";
IDMNT_RBST_L			  		= 00302460, "Rocket Booster";
IDMNT_TBST				  		= 00302461, "Turbo";
IDMNT_TBST_L			  		= 00302462, "Turbine Booster";
IDMNT_NANO				  		= 00302463, "Repair";
IDMNT_NANO_L			  		= 00302464, "Nano-repair Module";
IDMNT_LIFE				  		= 00302465, "Life";
IDMNT_LIFE_L			  		= 00302466, "Angel Life Support System";
IDMNT_AGRV				  		= 00302467, "AGRAV";
IDMNT_AGRV_L			  		= 00302468, "Alien Anti-Gravity Module";
IDMNT_ARM1				  		= 00302471, "CARLAM";
IDMNT_ARM1_L			  		= 00302472, "Carbon Fiber Laminate Armor";
IDMNT_ARM2				  		= 00302473, "QBM";
IDMNT_ARM2_L			  		= 00302474, "Quad-Bonded Metaplas Armor";
IDMNT_ARM3				  		= 00302475, "DURAC";
IDMNT_ARM3_L			  		= 00302476, "Depleted Uranium Carapace";
IDMNT_ARM4				  		= 00302477, "Cerc";         
IDMNT_ARM4_L			  		= 00302478, "Ceramic Armor";
IDMNT_ARM5				  		= 00302479, "Cryst/AL";
IDMNT_ARM5_L			  		= 00302480, "Crystaluminum Armor";
IDMNT_ARM6				  		= 00302481, "Quick";          
IDMNT_ARM6_L			  		= 00302482, "Quicksilver Nano-Armor";
IDMNT_AMMOPACK             		= 00302490, "UAP";
IDMNT_AMMOPACK_L           		= 00302491, "Universal Ammo Pack";

IDDAT_END_INTERNALMOUNTS 	= 00302599, "-- INTERNALMOUNTS Descriptions DATA group reserves tags 302,400 - 302,499 --";


///////////////////////////////////////////////////////////////////////////////
// Internal Component Specification group reserves tags 303,000 - 303,500 --
///////////////////////////////////////////////////////////////////////////////
//
//PROGRAMMERS: PLEASE DON'T CHANGE THESE TAGS WITHOUT TALKING TO DAVE SELLE!!
//
//Note to translators: These are the formatting commands and are CASE SENSITIVE
//Formatting commands must be encased in <> (left and right angled brackets).
//<F#> == Specify font where # == a 1 digit parameter. Legal values are 0,1
//<Jr> == Right Justify Text
//<Jl> == Left Justify Text
//<Jc> == Center Text
//<S#> == Line Spacing where # == a 1 digit parameter which is double the desired spacing
//e.g., <S2> is single spaced, <S3> is 1.5 Spacing, <S4> is double spaced text, etc.
//<L##>== Left margin where ## == a 1 or 2 digit parameter indicating the number of SPACES to indent
//<R##>== Right margin where ## == a 1 or 2 digit parameter indicating the number of SPACES to indent
//<Bx.bmp> Inserts a bitmap. The string which follows MUST end in .bmp
// \n == Inserts a line break (does not use brackets) 
// \t == Inserts a tab (does not use brackets)
// Note: if you want to reset the margins for a new line you must do it before the \n
// <L0>/n == Correct way  /n<L0> == Wrong way
//
//IMPORTANT NOTE TO TRANSLATORS
//Only Translate the WORDS BETWEEN THE QUOTES. The notations after the # sign are just
//notes to me so that I can tell which component is which, you don't need to translate them.


IDDAT_BEGIN_COMSPECS = 00303000,"Internal Component Specification group reserves tags 303,000 - 303,500 --";
//HUMAN first, then CYBRID																												(Translators ignore these)
//Engines											
IDCSPEC_ENG_HUM1	= 00303001,	"Velocity Rating	<Jr>100	\n<Jl>Acceleration Rating	<Jr>300	\n<Jl>Max Recommended Tonnage	<Jr>30	"	;	//	# Human Light Vehicle Engine
IDCSPEC_ENG_HUM2	= 00303002,	"Velocity Rating	<Jr>200	\n<Jl>Acceleration Rating	<Jr>250	\n<Jl>Max Recommended Tonnage	<Jr>25	"	;	//	# Human High Output Light Engine
IDCSPEC_ENG_HUM3	= 00303003,	"Velocity Rating	<Jr>300	\n<Jl>Acceleration Rating	<Jr>300	\n<Jl>Max Recommended Tonnage	<Jr>30	"	;	//	# Human Agile Light Engine
IDCSPEC_ENG_HUM4	= 00303004,	"Velocity Rating	<Jr>200	\n<Jl>Acceleration Rating	<Jr>400	\n<Jl>Max Recommended Tonnage	<Jr>40	"	;	//	# Human Standard Medium Engine
IDCSPEC_ENG_HUM5	= 00303005,	"Velocity Rating	<Jr>350	\n<Jl>Acceleration Rating	<Jr>350	\n<Jl>Max Recommended Tonnage	<Jr>35	"	;	//	# Human High Output Medium Engine
IDCSPEC_ENG_HUM6	= 00303006,	"Velocity Rating	<Jr>400	\n<Jl>Acceleration Rating	<Jr>400	\n<Jl>Max Recommended Tonnage	<Jr>40	"	;	//	# Human Medium Agility Engine
IDCSPEC_ENG_HUM7	= 00303007,	"Velocity Rating	<Jr>400	\n<Jl>Acceleration Rating	<Jr>500	\n<Jl>Max Recommended Tonnage	<Jr>50	"	;	//	# Human Standard Heavy Engine
IDCSPEC_ENG_HUM8	= 00303008,	"Velocity Rating	<Jr>500	\n<Jl>Acceleration Rating	<Jr>450	\n<Jl>Max Recommended Tonnage	<Jr>50	"	;	//	# Human Improved Heavy Engine
IDCSPEC_ENG_HUM9	= 00303009,	"Velocity Rating	<Jr>500	\n<Jl>Acceleration Rating	<Jr>500	\n<Jl>Max Recommended Tonnage	<Jr>50	"	;	//	# Human Heavy Cruise Engine
IDCSPEC_ENG_HUM10	= 00303010,	"Velocity Rating	<Jr>500	\n<Jl>Acceleration Rating	<Jr>600	\n<Jl>Max Recommended Tonnage	<Jr>60	"	;	//	# Human High Output Heavy Engine
IDCSPEC_ENG_HUM11	= 00303011,	"Velocity Rating	<Jr>600	\n<Jl>Acceleration Rating	<Jr>600	\n<Jl>Max Recommended Tonnage	<Jr>60	"	;	//	# Human Agile Heavy Engine
IDCSPEC_ENG_HUM12	= 00303012,	"Velocity Rating	<Jr>600	\n<Jl>Acceleration Rating	<Jr>750	\n<Jl>Max Recommended Tonnage	<Jr>75	"	;	//	# Human Standard Assault Engine
IDCSPEC_ENG_HUM13	= 00303013,	"Velocity Rating	<Jr>700	\n<Jl>Acceleration Rating	<Jr>800	\n<Jl>Max Recommended Tonnage	<Jr>80	"	;	//	# Human Improved Assault Engine
IDCSPEC_ENG_HUM14	= 00303014,	"Velocity Rating	<Jr>800	\n<Jl>Acceleration Rating	<Jr>800	\n<Jl>Max Recommended Tonnage	<Jr>80	"	;	//	# Human heavy turbine engine
IDCSPEC_ENG_HUM15	= 00303015,	"Velocity Rating	<Jr>850	\n<Jl>Acceleration Rating	<Jr>900	\n<Jl>Max Recommended Tonnage	<Jr>90	"	;	//	# High Output Turbine (HOT)
IDCSPEC_ENG_HUM16	= 00303016,	"Velocity Rating	<Jr>900	\n<Jl>Acceleration Rating	<Jr>900	\n<Jl>Max Recommended Tonnage	<Jr>90	"	;	//	# Human super heavy engine
IDCSPEC_ENG_HUM25	= 00303025,	"Velocity Rating	<Jr>1000	\n<Jl>Acceleration Rating	<Jr>1000	\n<Jl>Max Recommended Tonnage	<Jr>100	"	;	//	# Human RocketMan Engine
IDCSPEC_ENG_CYB1	= 00303031,	"Velocity Rating	<Jr>150	\n<Jl>Acceleration Rating	<Jr>250	\n<Jl>Max Recommended Tonnage	<Jr>25	"	;	//	# Cybrid Alpha Light Vehicle Engine
IDCSPEC_ENG_CYB2	= 00303032,	"Velocity Rating	<Jr>250	\n<Jl>Acceleration Rating	<Jr>250	\n<Jl>Max Recommended Tonnage	<Jr>25	"	;	//	# Cybrid Beta Light Agility Engine
IDCSPEC_ENG_CYB3	= 00303033,	"Velocity Rating	<Jr>200	\n<Jl>Acceleration Rating	<Jr>350	\n<Jl>Max Recommended Tonnage	<Jr>35	"	;	//	# Cybrid Gamma Standard Medium Engine
IDCSPEC_ENG_CYB4	= 00303034,	"Velocity Rating	<Jr>300	\n<Jl>Acceleration Rating	<Jr>300	\n<Jl>Max Recommended Tonnage	<Jr>30	"	;	//	# Cybrid Delta Medium Cruise Engine
IDCSPEC_ENG_CYB5	= 00303035,	"Velocity Rating	<Jr>300	\n<Jl>Acceleration Rating	<Jr>350	\n<Jl>Max Recommended Tonnage	<Jr>35	"	;	//	# Cybrid Epsilon Improved Medium Engine
IDCSPEC_ENG_CYB6	= 00303036,	"Velocity Rating	<Jr>400	\n<Jl>Acceleration Rating	<Jr>350	\n<Jl>Max Recommended Tonnage	<Jr>40	"	;	//	# Cybrid Zeta Medium High Output Engine
IDCSPEC_ENG_CYB7	= 00303037,	"Velocity Rating	<Jr>400	\n<Jl>Acceleration Rating	<Jr>400	\n<Jl>Max Recommended Tonnage	<Jr>40	"	;	//	# Cybrid Eta Medium Agility Engine
IDCSPEC_ENG_CYB8	= 00303038,	"Velocity Rating	<Jr>400	\n<Jl>Acceleration Rating	<Jr>480	\n<Jl>Max Recommended Tonnage	<Jr>48	"	;	//	# Cybrid Theta Standard Heavy Engine
IDCSPEC_ENG_CYB9	= 00303039,	"Velocity Rating	<Jr>480	\n<Jl>Acceleration Rating	<Jr>430	\n<Jl>Max Recommended Tonnage	<Jr>48	"	;	//	# Cybrid Iota Heavy High Output Engine
IDCSPEC_ENG_CYB10	= 00303040,	"Velocity Rating	<Jr>480	\n<Jl>Acceleration Rating	<Jr>500	\n<Jl>Max Recommended Tonnage	<Jr>50	"	;	//	# Cybrid Kappa Heavy Agility Engine
IDCSPEC_ENG_CYB11	= 00303041,	"Velocity Rating	<Jr>500	\n<Jl>Acceleration Rating	<Jr>600	\n<Jl>Max Recommended Tonnage	<Jr>60	"	;	//	# Cybrid Lamda Standard Assault Engine
IDCSPEC_ENG_CYB12	= 00303042,	"Velocity Rating	<Jr>600	\n<Jl>Acceleration Rating	<Jr>700	\n<Jl>Max Recommended Tonnage	<Jr>70	"	;	//	# Cybrid Mu Improved Assault Engine
IDCSPEC_ENG_CYB13	= 00303043,	"Velocity Rating	<Jr>600	\n<Jl>Acceleration Rating	<Jr>800	\n<Jl>Max Recommended Tonnage	<Jr>80	"	;	//	# Cybrid Nu High Output Assault Engine
IDCSPEC_ENG_CYB14	= 00303044,	"Velocity Rating	<Jr>700	\n<Jl>Acceleration Rating	<Jr>900	\n<Jl>Max Recommended Tonnage	<Jr>90	"	;	//	# Cybrid Xi Heavy Assault Engine
IDCSPEC_ENG_CYB15	= 00303045,	"Velocity Rating	<Jr>800	\n<Jl>Acceleration Rating	<Jr>900	\n<Jl>Max Recommended Tonnage	<Jr>90	"	;	//	# Cybrid Omicron Heavy Assault Turbine 
IDCSPEC_ENG_CYB16	= 00303046,	"Velocity Rating	<Jr>900	\n<Jl>Acceleration Rating	<Jr>900	\n<Jl>Max Recommended Tonnage	<Jr>90	"	;	//	# Cybrid Pi Super Heavy Turbine
											
//Reactors											
IDCSPEC_REA_HUM1	= 00303051,	"Energy Reserve	<Jr>400	\n<Jl>Output per second	<Jr>60	\n<Jl>Detonation Damage	<Jr>345	"	;	//	# Human Micro Reactor
IDCSPEC_REA_HUM2	= 00303052,	"Energy Reserve	<Jr>450	\n<Jl>Output per second	<Jr>65	\n<Jl>Detonation Damage	<Jr>386	"	;	//	# Small Human Reactor 2 -- small
IDCSPEC_REA_HUM3	= 00303053,	"Energy Reserve	<Jr>600	\n<Jl>Output per second	<Jr>65	\n<Jl>Detonation Damage	<Jr>499	"	;	//	# Medium Human Reactor 1 Standard
IDCSPEC_REA_HUM4	= 00303054,	"Energy Reserve	<Jr>750	\n<Jl>Output per second	<Jr>70	\n<Jl>Detonation Damage	<Jr>615	"	;	//	# Medium Human Reactor 2 medium
IDCSPEC_REA_HUM5	= 00303055,	"Energy Reserve	<Jr>650	\n<Jl>Output per second	<Jr>80	\n<Jl>Detonation Damage	<Jr>548	"	;	//	# Large Human Reactor 1 -- large
IDCSPEC_REA_HUM6	= 00303056,	"Energy Reserve	<Jr>1000	\n<Jl>Output per second	<Jr>110	\n<Jl>Detonation Damage	<Jr>833	"	;	//	# Large Human Reactor 2-- Maxim
IDCSPEC_REA_HUM24	= 00303074,	"Energy Reserve	<Jr>2000	\n<Jl>Output per second	<Jr>1000	\n<Jl>Detonation Damage	<Jr>2250	"	;	//	# iCutChOO Reactor
IDCSPEC_REA_CYB1	= 00303081,	"Energy Reserve	<Jr>300	\n<Jl>Output per second	<Jr>65	\n<Jl>Detonation Damage	<Jr>274	"	;	//	# Small Cybrid Reactor 1 -- Alpha
IDCSPEC_REA_CYB2	= 00303082,	"Energy Reserve	<Jr>350	\n<Jl>Output per second	<Jr>70	\n<Jl>Detonation Damage	<Jr>315	"	;	//	# Small Cybrid Reactor 2-- Beta
IDCSPEC_REA_CYB3	= 00303083,	"Energy Reserve	<Jr>500	\n<Jl>Output per second	<Jr>75	\n<Jl>Detonation Damage	<Jr>431	"	;	//	# Medium Cybrid Reactor 1 -- Gamma
IDCSPEC_REA_CYB4	= 00303084,	"Energy Reserve	<Jr>650	\n<Jl>Output per second	<Jr>80	\n<Jl>Detonation Damage	<Jr>548	"	;	//	# Medium Cybrid Reactor 2--delta
IDCSPEC_REA_CYB5	= 00303085,	"Energy Reserve	<Jr>550	\n<Jl>Output per second	<Jr>85	\n<Jl>Detonation Damage	<Jr>476	"	;	//	# Large Cybrid Reactor 1--epsilon
IDCSPEC_REA_CYB6	= 00303086,	"Energy Reserve	<Jr>800	\n<Jl>Output per second	<Jr>100	\n<Jl>Detonation Damage	<Jr>675	"	;	//	# Large Cybrid Reactor 2--theta
											
//Shield Generators											
IDCSPEC_SHL_HUM1	= 00303101,	"Protection Factor	<Jr>1500	\n<Jl>Charge rate 	<Jr>25	\n<Jl>Efficiency	<Jr>1.60	"	;	//	# Human Standard Shield
IDCSPEC_SHL_HUM2	= 00303102,	"Protection Factor	<Jr>1800	\n<Jl>Charge rate 	<Jr>25	\n<Jl>Efficiency	<Jr>1.80	"	;	//	# Human Protector Shield
IDCSPEC_SHL_HUM3	= 00303103,	"Protection Factor	<Jr>2000	\n<Jl>Charge rate 	<Jr>30	\n<Jl>Efficiency	<Jr>1.67	"	;	//	# Human Guardian Shield
IDCSPEC_SHL_HUM4	= 00303104,	"Protection Factor	<Jr>2125	\n<Jl>Charge rate 	<Jr>50	\n<Jl>Efficiency	<Jr>2.50	"	;	//	# Human FastCharge Shield
IDCSPEC_SHL_HUM5	= 00303105,	"Protection Factor	<Jr>2300	\n<Jl>Charge rate 	<Jr>30	\n<Jl>Efficiency	<Jr>1.92	"	;	//	# Human Centurian Shield
IDCSPEC_SHL_HUM6	= 00303106,	"Protection Factor	<Jr>2880	\n<Jl>Charge rate 	<Jr>35	\n<Jl>Efficiency	<Jr>1.80	"	;	//	# Human Repulsor Shield
IDCSPEC_SHL_HUM7	= 00303107,	"Protection Factor	<Jr>2400	\n<Jl>Charge rate 	<Jr>35	\n<Jl>Efficiency	<Jr>2.00	"	;	//	# Human Titan Shield
IDCSPEC_SHL_HUM8	= 00303108,	"Protection Factor	<Jr>3600	\n<Jl>Charge rate 	<Jr>40	\n<Jl>Efficiency	<Jr>1.80	"	;	//	# Human Medusa Shield
IDCSPEC_SHL_HUM25	= 00303125,	"Protection Factor	<Jr>8000	\n<Jl>Charge rate 	<Jr>50	\n<Jl>Efficiency	<Jr>2.00	"	;	//	# Impervion Shield
IDCSPEC_SHL_CYB1	= 00303131,	"Protection Factor	<Jr>1500	\n<Jl>Charge rate 	<Jr>25	\n<Jl>Efficiency	<Jr>1.50	"	;	//	# Cybrid Alpha Shield
IDCSPEC_SHL_CYB2	= 00303132,	"Protection Factor	<Jr>1620	\n<Jl>Charge rate 	<Jr>25	\n<Jl>Efficiency	<Jr>1.80	"	;	//	# Cybrid Beta Shield
IDCSPEC_SHL_CYB3	= 00303133,	"Protection Factor	<Jr>1800	\n<Jl>Charge rate 	<Jr>30	\n<Jl>Efficiency	<Jr>1.64	"	;	//	# Cybrid Gamma Shield
IDCSPEC_SHL_CYB4	= 00303134,	"Protection Factor	<Jr>2160	\n<Jl>Charge rate 	<Jr>30	\n<Jl>Efficiency	<Jr>1.80	"	;	//	# Cybrid Delta Shield
IDCSPEC_SHL_CYB5	= 00303135,	"Protection Factor	<Jr>2470	\n<Jl>Charge rate 	<Jr>35	\n<Jl>Efficiency	<Jr>1.90	"	;	//	# Cybrid Epsilon Shield
IDCSPEC_SHL_CYB6	= 00303136,	"Protection Factor	<Jr>3120	\n<Jl>Charge rate 	<Jr>40	\n<Jl>Efficiency	<Jr>1.95	"	;	//	# Cybrid Zeta Shield
IDCSPEC_SHL_CYB7	= 00303137,	"Protection Factor	<Jr>2730	\n<Jl>Charge rate 	<Jr>35	\n<Jl>Efficiency	<Jr>1.95	"	;	//	# Cybrid Eta Shield
IDCSPEC_SHL_CYB8	= 00303138,	"Protection Factor	<Jr>3900	\n<Jl>Charge rate 	<Jr>35	\n<Jl>Efficiency	<Jr>2.60	"	;	//	# Cybrid Theta Shield

//Sensors
//NOTE TO TRANSLATORS: You are going to have to readjust the number of TABS [\t] in
//this section after you translate it so that it will look nice in the shell
//Sensors														

IDCSPEC_SEN_HUM1	= 00303151,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t900	\t\t0.50	\n<Jl>Passive	\t\t500	\t\t0.30	\n<Jl>Sweep Time (sec)	\t2.00	"	;	//	# Basic Human Sensor
IDCSPEC_SEN_HUM2	= 00303152,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1200	\t\t0.65	\n<Jl>Passive	\t\t500	\t\t0.30	\n<Jl>Sweep Time (sec)	\t3.00	"	;	//	# Long Range Sensor -- Ranger
IDCSPEC_SEN_HUM3	= 00303153,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1000	\t\t0.60	\n<Jl>Passive	\t\t700	\t\t0.35	\n<Jl>Sweep Time (sec)	\t2.00	"	;	//	#Standard Human Sensor
IDCSPEC_SEN_HUM4	= 00303154,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1350	\t\t0.70	\n<Jl>Passive	\t\t600	\t\t0.30	\n<Jl>Sweep Time (sec)	\t2.00	"	;	//	#Human Longbow Sensor
IDCSPEC_SEN_HUM5	= 00303155,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1200	\t\t0.70	\n<Jl>Passive	\t\t850	\t\t0.50	\n<Jl>Sweep Time (sec)	\t1.50	"	;	//	#Human Infiltrator Sensor
IDCSPEC_SEN_HUM6	= 00303156,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1500	\t\t0.75	\n<Jl>Passive	\t\t700	\t\t0.35	\n<Jl>Sweep Time (sec)	\t2.50	"	;	//	#Human Crossbow Sensor
IDCSPEC_SEN_HUM7	= 00303157,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t800	\t\t0.60	\n<Jl>Passive	\t\t500	\t\t0.30	\n<Jl>Sweep Time (sec)	\t2.00	"	;	//	#Human Ultralight Sensor
IDCSPEC_SEN_HUM8	= 00303158,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t900	\t\t0.55	\n<Jl>Passive	\t\t650	\t\t0.45	\n<Jl>Sweep Time (sec)	\t1.50	"	;	//	#Human Hound Dog Sensor
IDCSPEC_SEN_HUM9	= 00303159,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1000	\t\t0.35	\n<Jl>Passive	\t\t750	\t\t0.60	\n<Jl>Sweep Time (sec)	\t1.50	"	;	//	#Thermal Sensor
IDCSPEC_SEN_HUM25	= 00303175,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t2000	\t\t1.00	\n<Jl>Passive	\t\t1500	\t\t1.00	\n<Jl>Sweep Time (sec)	\t1.50	"	;	//	# U can Run But U can't Hide Sensor
IDCSPEC_SEN_CYB1	= 00303181,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t900	\t\t0.55	\n<Jl>Passive	\t\t500	\t\t0.35	\n<Jl>Sweep Time (sec)	\t2.50	"	;	//	# Basic Cybrid Sensor (Alpha)
IDCSPEC_SEN_CYB2	= 00303182,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1200	\t\t0.70	\n<Jl>Passive	\t\t500	\t\t0.35	\n<Jl>Sweep Time (sec)	\t3.50	"	;	//	# Long Range Cybrid Sensor (Beta)
IDCSPEC_SEN_CYB3	= 00303183,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1000	\t\t0.65	\n<Jl>Passive	\t\t700	\t\t0.40	\n<Jl>Sweep Time (sec)	\t2.50	"	;	//	#Standard Cybrid Sensor (Gamma)
IDCSPEC_SEN_CYB4	= 00303184,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1350	\t\t0.75	\n<Jl>Passive	\t\t600	\t\t0.35	\n<Jl>Sweep Time (sec)	\t2.50	"	;	//	#Cybrid Longbow Sensor (Delta)
IDCSPEC_SEN_CYB5	= 00303185,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1100	\t\t0.70	\n<Jl>Passive	\t\t850	\t\t0.55	\n<Jl>Sweep Time (sec)	\t2.00	"	;	//	#Cybrid Infiltrator Sensor (Epsilon)
IDCSPEC_SEN_CYB6	= 00303186,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1500	\t\t0.75	\n<Jl>Passive	\t\t700	\t\t0.40	\n<Jl>Sweep Time (sec)	\t3.00	"	;	//	#Cybrid Crossbow Sensor (Zeta)
IDCSPEC_SEN_CYB7	= 00303187,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t800	\t\t0.60	\n<Jl>Passive	\t\t500	\t\t0.35	\n<Jl>Sweep Time (sec)	\t2.50	"	;	//	#Cybrid Ultralight Sensor (Eta)
IDCSPEC_SEN_CYB8	= 00303188,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t900	\t\t0.55	\n<Jl>Passive	\t\t650	\t\t0.45	\n<Jl>Sweep Time (sec)	\t1.50	"	;	//	#Cybrid Hound Dog Sensor (Theta)
IDCSPEC_SEN_CYB9	= 00303189,	"MODE\t\t\tRANGE\t\tRESOLUTION	\n<jl>Active	\t\t1000	\t\t0.40	\n<Jl>Passive	\t\t750	\t\t0.60	\n<Jl>Sweep Time (sec)	\t1.00	"	;	//	#Motion Detector (Iota)

//Note to translators. Watch string length. If too long it won't fit.
//Formatting is also a real pain. 
//Computers									
IDCSPEC_CMP_HUM1	= 00303200,	"Basic Weapons and Targeting System				";//	#Human Basic Computer		
IDCSPEC_CMP_HUM2	= 00303201,	"Improved computer with Enhanced zoom, Lead indicator, and targeting.				";//	# Human Improved Computer		
IDCSPEC_CMP_HUM3	= 00303202,	"Advanced computer with Automatic Target Selection & Improved ID range				";//	# Human Advanced Computer		
IDCSPEC_CMP_CYB1	= 00303205,	"Basic Weapons and Targeting System				";//	# Cybrid Basic Systems Control		
IDCSPEC_CMP_CYB2	= 00303206,	"Improved computer with Enhanced zoom, Lead indicator, and targeting.				";//	# Cybrid Improved Systems Control		
IDCSPEC_CMP_CYB3	= 00303207,	"Advanced computer with Automatic Target Selection & Improved ID range				";//	# Cybrid Advanced Systems Control		
//ECM: Electronic Countermeasures (Jammers)									
IDCSPEC_ECM_HUM1	= 00303210,	"ECM Rating	<Jr>75	\n<Jl>Jam Range (meters)	<Jr>1000	\n<Jl>Intensity	<Jr>0.30	";//	# Guardian ECM
IDCSPEC_ECM_HUM2	= 00303211,	"ECM Rating	<Jr>120	\n<Jl>Jam Range (meters)	<Jr>1200	\n<Jl>Intensity	<Jr>0.50	";//	# Doppleganger ECM
IDCSPEC_ECM_CYB1	= 00303212,	"ECM Rating	<Jr>90	\n<Jl>Jam Range (meters)	<Jr>1050	\n<Jl>Intensity	<Jr>0.35	";//	# Cybrid Alpha ECM
IDCSPEC_ECM_CYB2	= 00303213,	"ECM Rating	<Jr>130	\n<Jl>Jam Range (meters)	<Jr>1250	\n<Jl>Intensity	<Jr>0.55	";//	#Cybrid Beta ECM
IDCSPEC_THERM	= 00303214,	"Thermal Rating	<Jr>100	\n<Jl>Jam Range (meters)	<Jr>1000	\n<Jl>Intensity	<Jr>0.55	";//	#Thermal Jammer
IDSPEC_CLK1	= 00303221,	"Makes vehicle very hard to detect visually or with sensors		\n<Jl>Mask Rating:	<Jr>1200	";//	#Chameleon Cloak		
IDSPEC_CLK2	= 00303222,	"Makes vehicle very hard to detect visually or with sensors.		\n<Jl>Mask Rating:	<Jr>1600	";//	#Cuttlefish Cloak		
IDSPEC_SMOD	= 00303225,	"Allows Shield Rotation and Focusing				";//	#Shield Modulator
IDSPEC_SCAP	= 00303226,	"Instantly recharges shields. Increasing risk of damage with each use.				";//	#Shield Capacitor
IDSPEC_SAMP	= 00303227,	"Improves shield protection factor by 25 percent.				";//	#Shield Amplifier
IDSPEC_LTAD	= 00303228,	"Range	<Jr>1500	\n<Jl>Enables vehicle to spot for artillery.		";//	#Laser Target Designation Module
IDSPEC_BAT	= 00303229,	"Increases energy storage capacity				";//	#Battery
IDSPEC_CAP	= 00303230,	"Instantly recharges reactor. Increasing risk of damage with each use.				";//	#Capacitor
IDSPEC_FSTB	= 00303231,	"Enhances Flexor Field Stability. Protects against Disrupter weapon.				";//	#Field Stabilizer
IDSPEC_RBST	= 00303232,	"Provides a burst of speed for extended duration. 				";//	#Rocket Booster
IDSPEC_TBST	= 00303233,	"Provides a short high speed burst				";//	#Turbine Booster
IDSPEC_NANO	= 00303234,	"Repairs Damage on the battlefield. Unit takes damage with use.				";//	#Nano Repair Module
IDSPEC_LIFE	= 00303235,	"Enhanced life support increases pilot stability. Protects against radiation.				";//	#Angel Life Support
IDSPEC_AGRV	= 00303236,	"Alien Tech Component increases vehicle capacity. Reduces falling damage.				";//	#Agrav Generator
IDSPEC_ARM1	= 00303241,	"Light scout armor.\n<Jl>Minimal Protection.\n<Jl>Reduces Radar Signature.				";//	#Carbon Fiber (CARLAM)
IDSPEC_ARM2	= 00303242,	"Standard Armor with good all-around protection against most weapon types.				";//	#Quad Bonded Metaplas (QBM)
IDSPEC_ARM3	= 00303243,	"Heavy armor with excellent ballistic protection.\n<Jl>Enhanced radiation protection.				";//	#DURAC (Depleted Uranium)
IDSPEC_ARM4	= 00303244,	"Somewhat weak against ballistic attacks, but excellent vs. all other weapon types.				";//	#Ceramic
IDSPEC_ARM5	= 00303245,	"Enhanced protection from ballistic and Electroplasmic attacks. Weaker vs. beam weapons.				";//	#Crystaluminum
IDSPEC_ARM6	= 00303246,	"Advanced armor which reallocates itself as damage is taken.\n<Jl>Protects against nano weapons.				";//	#Quicksilver
IDSPEC_EHUL	= 00303247,	"Inflicts heavy ramming damage.				";//	#Electrohull
IDSPEC_AMMOPACK	= 00303248,	"Doubles storage capacity of ammo weapons. 				";//	#Universal Ammo Pack
																
//weapons															
IDSPEC_WEA_LAS    	= 00303300 ,	"Range	\t750	\t\tEnergy	<Jr>15	\n<Jl>Shield	\t175	\t\tArmor	<Jr>114	\n<Jl>Reload/Lock Time 	<Jr>1.3	";//	Laser		
IDSPEC_WEA_HLAS   	= 00303301 ,	"Range	\t900	\t\tEnergy	<Jr>25	\n<Jl>Shield	\t300	\t\tArmor	<Jr>195	\n<Jl>Reload/Lock Time 	<Jr>1.6	";//	Heavy Laser		
IDSPEC_WEA_CLAS   	= 00303302 ,	"Range	\t950	\t\tEnergy	<Jr>27	\n<Jl>Shield	\t125 x3	\tArmor	<Jr>94 x3	\n<Jl>Reload/Lock Time 	<Jr>1.9		\n<Jl>Fires a triple burst	";//	Comp Laser
IDSPEC_WEA_TLAS   	= 00303303 ,	"Range	\t900	\t\tEnergy	<Jr>20	\n<Jl>Shield	\t150 x2	\tArmor	<Jr>98 x2	\n<Jl>Reload/Lock Time 	<Jr>1.8		\n<Jl>Fires 2 beams	";//	Twin Laser
IDSPEC_WEA_EMP    	= 00303304 ,	"Range	\t1000	\t\tEnergy	<Jr>20	\n<Jl>Shield	\t625	\t\tArmor	<Jr>63	\n<Jl>Reload/Lock Time 	<Jr>1.4	";//	Emp		
IDSPEC_WEA_ELF    	= 00303305 ,	"Range	\t150	\t\tEnergy	<Jr>50	\n<Jl>Shield	\t700	\t\tArmor	<Jr>700	\n<Jl>Reload/Lock Time 	<Jr>1.7	";//	ELF		
IDSPEC_WEA_BLAS   	= 00303306 ,	"Range	\t1200	\t\tEnergy	<Jr>35	\n<Jl>Shield	\t400	\t\tArmor	<Jr>360	\n<Jl>Reload/Lock Time 	<Jr>1.2	";//	Blaster		
IDSPEC_WEA_HBLA   	= 00303307 ,	"Range	\t1000	\t\tEnergy	<Jr>45	\n<Jl>Shield	\t535	\t\tArmor	<Jr>482	\n<Jl>Reload/Lock Time 	<Jr>1.6	";//	Heavy Blaster		
IDSPEC_WEA_PBW    	= 00303308 ,	"Range	\t1000	\t\tEnergy	<Jr>50	\n<Jl>Shield	\t600	\t\tArmor	<Jr>540	\n<Jl>Reload/Lock Time 	<Jr>2.0	";//	PBW		
IDSPEC_WEA_PLAS   	= 00303309 ,	"Range	\t500	\t\tEnergy	<Jr>50	\n<Jl>Shield	\t400	\t\tArmor	<Jr>400	\n<Jl>Reload/Lock Time 	<Jr>2.2		\n<Jl>Plasma Beams Seek Target	";//	Plasma
IDSPEC_WEA_BLNK   	= 00303310 ,	"Range	\t1000	\t\tEnergy	<Jr>45	\n<Jl>Shield	\tN/A	\t\tArmor	<Jr>180	\n<Jl>Reload/Lock Time 	<Jr>1.0		\n<Jl>Skips Shields, Hits Internals 	";//	Blink Gun 
IDSPEC_WEA_QGUN   	= 00303311 ,	"Range	\t850	\t\tEnergy	<Jr>60	\n<Jl>Shield	\t800	\t\tArmor	<Jr>800	\n<Jl>Reload/Lock Time 	<Jr>2.3	";//	Qgun		
IDSPEC_WEA_MFAC   	= 00303312 ,	"Range	\t1000	\t\tEnergy	<Jr>50	\n<Jl>Shield	\t1000	\t\tArmor	<Jr>1000	\n<Jl>Reload/Lock Time 	<Jr>3.1	";//	MFAC		
IDSPEC_WEA_NANO   	= 00303313 ,	"Range	\t400	\t\tAmmo	<Jr>30	\n<Jl>Shield	\t35	\t\t\tArmor	<Jr>350	\n<Jl>Reload/Lock Time 	<Jr>1.7		\n<Jl>Damages Internals.	";//	Nano Infuser
IDSPEC_WEA_NCAN   	= 00303314 ,	"Range	\t350	\t\tAmmo	<Jr>25	\n<Jl>Shield	\t40	\t\tArmor	<Jr>500	\n<Jl>Reload/Lock Time 	<Jr>1.7		\n<Jl>Damages Internals.	";//	Nanite Cannon	
IDSPEC_WEA_ATC    	= 00303315 ,	"Range	\t650	\t\tAmmo	<Jr>9000	\n<Jl>Shield	\t75	\t\t\tArmor	<Jr>150	\n<Jl>Reload/Lock Time 	<Jr>0.5	";//	Autocannon			
IDSPEC_WEA_HATC   	= 00303316 ,	"Range	\t500	\t\tAmmo	<Jr>4000	\n<Jl>Shield	\t113	\t\t\tArmor	<Jr>225	\n<Jl>Reload/Lock Time 	<Jr>0.7	";//	Hvy Autocannon			
IDSPEC_WEA_EMC    	= 00303317 ,	"Range	\t600	\t\tAmmo	<Jr>5000	\n<Jl>Shield	\t131	\t\t\tArmor	<Jr>175	\n<Jl>Reload/Lock Time 	<Jr>0.6	";//	EMC Autocannon			
IDSPEC_WEA_BC     	= 00303318 ,	"Range	\t1050	\t\tAmmo	<Jr>25	\n<Jl>Shield	\t90	\t\t\tArmor	<Jr>300	\n<Jl>Reload/Lock Time 	<Jr>1.7		\n<Jl>10m Blast radius	";//	Blast Cannon	
IDSPEC_WEA_HBC    	= 00303319 ,	"Range	\t900	\t\tAmmo	<Jr>15	\n<Jl>Shield	\t120	\t\tArmor	<Jr>400	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>10m Blast radius	";//	Hvy Blast Can	
IDSPEC_WEA_RAIL   	= 00303320 ,	"Range	\t1000	\t\tAmmo	<Jr>40	\n<Jl>Shield	\t300	\t\tArmor	<Jr>375	\n<Jl>Reload/Lock Time 	<Jr>1.2	";//	Rail Gun			
IDSPEC_WEA_LGB    	= 00303321 ,	"Range	\tN/A	\t\tAmmo	<Jr>5	\n<Jl>Shield	\t300	\t\tArmor	<Jr>600	\n<Jl>Reload/Lock Time 	<Jr>1.0	";//	Laser G. Bomb			
IDSPEC_WEA_HAD    	= 00303322 ,	"Range	\tN/A	\t\tAmmo	<Jr>5	\n<Jl>Shield	\t250	\t\tArmor	<Jr>500	\n<Jl>Reload/Lock Time 	<Jr>1.0	";//	Hades Bomb			
IDSPEC_WEA_VIP8   	= 00303323 ,	"Range	\t800	\t\tMin	<Jr>50	\n<Jl>Shield	\t160	\t\tArmor	<Jr>400	\n<Jl>Reload/Lock Time 	<Jr>3.0		\n<Jl>Missile tracking type:	<Jr>Thermal	";//	Pit Viper 8
IDSPEC_WEA_VIP12  	= 00303324 ,	"Range	\t800	\t\tMin	<Jr>50	\n<Jl>Shield	\t160	\t\tArmor	<Jr>400	\n<Jl>Reload/Lock Time 	<Jr>3.0		\n<Jl>Missile tracking type:	<Jr>Thermal	";//	Pit Viper 12
IDSPEC_WEA_SPR6   	= 00303325 ,	"Range	\t1000	\t\tMin	<Jr>20	\n<Jl>Shield	\t135	\t\tArmor	<Jr>450	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>Missile tracking type:	<Jr>Radar	";//	Sparrow 6
IDSPEC_WEA_SPR10  	= 00303326 ,	"Range	\t1000	\t\tMin	<Jr>20	\n<Jl>Shield	\t135	\t\tArmor	<Jr>450	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>Missile tracking type:	<Jr>Radar	";//	Sparrow 10
IDSPEC_WEA_SWRM   	= 00303327 ,	"Range	\t800	\t\tMin	<Jr>35	\n<Jl>Shield	\t220	\t\tArmor	<Jr>550	\n<Jl>Reload/Lock Time 	<Jr>2.5		\n<Jl>Missile tracking type:	<Jr>Radar	";//	SWARM 6
IDSPEC_WEA_MIN    	= 00303328 ,	"Range	\t1200	\t\tMin	<Jr>25	\n<Jl>Shield	\t225	\t\tArmor	<Jr>450	\n<Jl>Reload/Lock Time 	<Jr>4.0		\n<Jl>Missile tracking type:	<Jr>Radar	";//	Minion
IDSPEC_WEA_SHRK   	= 00303329 ,	"Range	\t750	\t\tMin	<Jr>40	\n<Jl>Shield	\t165	\t\tArmor	<Jr>550	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>Missile tracking type:	<Jr>Thermal	";//	Shrike 8
IDSPEC_WEA_APHID  	= 00303330 ,	"Range	\t3000	\t\tMin	<Jr>25	\n<Jl>Shield	\t45	\t\tArmor	<Jr>450	\n<Jl>Reload/Lock Time 	<Jr>3.0		\n<Jl>Missile tracking type:	<Jr>Radar	";//	Aphid
IDSPEC_WEA_ARA4   	= 00303331 ,	"Range	\tN/A	\t\tAmmo	<Jr>6	\n<Jl>Shield	\t250	\t\tArmor	<Jr>250	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>Mines Seek Target	";//	Arachnitron 4	
IDSPEC_WEA_ARA8   	= 00303332 ,	"Range	\tN/A	\t\tAmmo	<Jr>10	\n<Jl>Shield	\t250	\t\tArmor	<Jr>250	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>Mines Seek Target	";//	Arachnitron 8 	
IDSPEC_WEA_ARA12  	= 00303333 ,	"Range	\tN/A	\t\tAmmo	<Jr>14	\n<Jl>Shield	\t250	\t\tArmor	<Jr>250	\n<Jl>Reload/Lock Time 	<Jr>2.0		\n<Jl>Mines Seek Target	";//	Arachnitron 12 	
IDSPEC_WEA_PRX6   	= 00303334 ,	"Range	\tN/A	\t\tAmmo	<Jr>6	\n<Jl>Shield	\t350	\t\tArmor	<Jr>350	\n<Jl>Reload/Lock Time 	<Jr>1.5	";//	Proximity 6 			
IDSPEC_WEA_PRX10  	= 00303335 ,	"Range	\tN/A	\t\tAmmo	<Jr>8	\n<Jl>Shield	\t350	\t\tArmor	<Jr>350	\n<Jl>Reload/Lock Time 	<Jr>1.5	";//	Proximity 10 			
IDSPEC_WEA_PRX15  	= 00303336 ,	"Range	\tN/A	\t\tAmmo	<Jr>10	\n<Jl>Shield	\t350	\t\tArmor	<Jr>350	\n<Jl>Reload/Lock Time 	<Jr>1.5	";//	Proximity 15			
IDSPEC_WEA_CMD10  	= 00303337 ,	"Range	\tN/A	\t\tAmmo	<Jr>0	\n<Jl>Shield	\tN/A	\t\tArmor	<Jr>N/A	\n<Jl>Reload/Lock Time 	<Jr>0.0	";//	Command Det 10 			
IDSPEC_WEA_CMD15  	= 00303338 ,	"Range	\tN/A	\t\tAmmo	<Jr>0	\n<Jl>Shield	\tN/A	\t\tArmor	<Jr>N/A	\n<Jl>Reload/Lock Time 	<Jr>0.0	";//	Command Det 15 			
IDSPEC_WEA_CMD20  	= 00303339 ,	"Range	\tN/A	\t\tAmmo	<Jr>0	\n<Jl>Shield	\tN/A	\t\tArmor	<Jr>N/A	\n<Jl>Reload/Lock Time 	<Jr>0.0	";//	Command Det 20 			
IDSPEC_WEA_NIKE   	= 00303340 ,	"Range	\t5000	\t\tAmmo	<Jr>30	\n<Jl>Shield	\t638	\t\tArmor	<Jr>750	\n<Jl>Reload/Lock Time 	<Jr>3.5	";//	Nike			
IDSPEC_WEA_AML    	= 00303341 ,	"Range	\t5000	\t\tAmmo	<Jr>10	\n<Jl>Shield	\t638	\t\tArmor	<Jr>750	\n<Jl>Reload/Lock Time 	<Jr>5.0	";//	AML			
IDSPEC_WEA_RAD    	= 00303342 ,	"Range	\t250	\t\tEnergy	<Jr>75	\n<Jl>Shield	\t200	\t\tArmor	<Jr>200	\n<Jl>Reload/Lock Time 	<Jr>1.5		\n<Jl>Cockpit hits damge pilot	";//	Radiation Gun	
IDSPEC_WEA_DIS    	= 00303343 ,	"Range	\t750	\t\tEnergy	<Jr>70	\n<Jl>Shield	\t500	\t\tArmor	<Jr>250	\n<Jl>Reload/Lock Time 	<Jr>1.5		\n<Jl>Slows enemy	";//	Disrupter	
IDSPEC_WEA_EHUL   	= 00303344 ,	"Range	\tN/A	\t\tEnergy	<Jr>20	\n<Jl>Shield	\t250	\t\tArmor	<Jr>250	\n<Jl>Reload/Lock Time 	<Jr>10.0		\n<Jl>Extra Collision Damage	";//	Electrohull	
IDSPEC_WEA_PROB   	= 00303345 ,	"Range	\t250	\t\tEnergy	<Jr>20	\n<Jl>Shield	\t500	\t\tArmor	<Jr>500	\n<Jl>Reload/Lock Time 	<Jr>25.0	";//	Seismic Prob			
IDSPEC_WEA_FOG    	= 00303346 ,	"Range	\t1000	\t\tAmmo	<Jr>1	\n<Jl>Shield	\t750	\t\tArmor	<Jr>750	\n<Jl>Reload/Lock Time 	<Jr>1.0	";//	FOG		
IDSPEC_WEA_CYART    	= 00303347 ,	"Range	\t5000	\t\tAmmo	<Jr>30	\n<Jl>Shield	\t750	\t\tArmor	<Jr>750	\n<Jl>Reload/Lock Time 	<Jr>4.0	";//	Cyb Artillery		
IDSPEC_WEA_SGUN    	= 00303348 ,	"Range	\t500	\t\tEnergy	<Jr>25	\n<Jl>Shield	\t200	\t\tArmor	<Jr>200	\n<Jl>Reload/Lock Time 	<Jr>0.8		\n<Jl>Fires seeking projectiles	";//	Smart Gun

IDDAT_END_COMSPECS = 00303500,"";


///////////////////////////////////////////////////////////////////////////////
// Player manager messages
///////////////////////////////////////////////////////////////////////////////
IDSTR_PM_BEG         		= 00340300, "";
IDSTR_PM_JOINED      		= 00340301, "%s joined the game.";
IDSTR_PM_LEFT        		= 00340302, "%s left the game.";
IDSTR_PM_END_WARN    		= 00340303, "%d seconds to mission end.";
IDSTR_PM_END         		= 00340399, "";

///////////////////////////////////////////////////////////////////////////////
// STRUCTURES DTS SHAPE FILENAMES ( IDDTS )                                  //
///////////////////////////////////////////////////////////////////////////////
//NOTE TO TRANSLATORS: DON'T TRANSLATE ANYTHING AFTER THIS POINT

IDRES_BEG_DTS_FILENAMES   	= 00351000, "-- Structures DTS Shape Filenames  RESOURCE group reserves tags 351,000 - 351,999 --";

IDDTS_DEBRIS_MAN          	= 00351200, "debris_man.dts";
IDDTS_DEBRIS_SML1         	= 00351210, "debris_sml_1.dts";
IDDTS_DEBRIS_SML2         	= 00351211, "debris_sml_2.dts";
IDDTS_DEBRIS_SML3         	= 00351212, "debris_sml_3.dts";
IDDTS_DEBRIS_MED1         	= 00351220, "debris_med_1.dts";
IDDTS_DEBRIS_MED2         	= 00351221, "debris_med_2.dts";
IDDTS_DEBRIS_MED3         	= 00351222, "debris_med_3.dts";
IDDTS_DEBRIS_MED4         	= 00351223, "debris_med_4.dts";
IDDTS_DEBRIS_LRG1         	= 00351230, "debris_lrg_1.dts";
IDDTS_DEBRIS_LRG2         	= 00351231, "debris_lrg_2.dts";
IDDTS_DEBRIS_LRG3         	= 00351232, "debris_lrg_3.dts";
IDDTS_DEBRIS_LRG4         	= 00351233, "debris_lrg_4.dts";
IDDTS_DEBRIS_XL1          	= 00351240, "debris_xlrg_1.dts";
IDDTS_DEBRIS_XL2          	= 00351241, "debris_xlrg_2.dts";
IDDTS_DEBRIS_XL3          	= 00351242, "debris_xlrg_3.dts";
IDDTS_DEBRIS_PAN1         	= 00351250, "debris_pan_1.dts";
IDDTS_DEBRIS_PAN2         	= 00351251, "debris_pan_2.dts";
IDDTS_DEBRIS_PAN3         	= 00351252, "debris_pan_3.dts";

// normal explosions
IDDTS_EXP_S               	= 00351260, "fx_exp_sm.dts";
IDDTS_EXP_M               	= 00351261, "fx_exp_md.dts";
IDDTS_EXP_L               	= 00351262, "fx_exp_lg.dts";
IDDTS_EXP_S_T             	= 00351270, "fx_exp_smT.dts";
IDDTS_EXP_M_T             	= 00351271, "fx_exp_mdT.dts";
IDDTS_EXP_L_T             	= 00351272, "fx_exp_lgT.dts";

// fire
IDDTS_FLAME_S             	= 00351280, "fx_flame_sm.dts";
IDDTS_FLAME_M             	= 00351281, "fx_flame_md.dts";
IDDTS_FLAME_L             	= 00351282, "fx_flame_lg.dts";
IDDTS_FLAME_SMOKEONLY     	= 00351283, "";
IDDTS_FLAME_FIREONLY     	= 00351284, "";
IDDTS_FLAME_S_T           	= 00351290, "fx_flame_smT.dts";
IDDTS_FLAME_M_T           	= 00351291, "fx_flame_mdT.dts";
IDDTS_FLAME_L_T           	= 00351292, "fx_flame_lgT.dts";
IDDTS_FLAME_ELECTRIC       = 00351293, "fx_elec.dts";
IDDTS_FLAME_ELECTRIC_T     = 00351294, "fx_elec_T.dts";

// smoke
IDDTS_SMOKE_S             	= 00351300, "fx_smoke_sm.dts";
IDDTS_SMOKE_M             	= 00351301, "fx_smoke_md.dts";
IDDTS_SMOKE_L             	= 00351302, "fx_smoke_lg.dts";
IDDTS_SMOKE_TR             = 00351303, "fx_smoke_tr.dts";
IDDTS_SMOKE_S_T           	= 00351310, "fx_smoke_smT.dts";
IDDTS_SMOKE_M_T           	= 00351311, "fx_smoke_mdT.dts";
IDDTS_SMOKE_L_T           	= 00351312, "fx_smoke_lgT.dts";
IDDTS_SMOKE_TR_T           = 00351313, "fx_smoke_trT.dts";

// fireballs
IDDTS_FBALL_S             	= 00351320, "fx_fball_sm.dts";
IDDTS_FBALL_M             	= 00351321, "fx_fball_md.dts";
IDDTS_FBALL_S_T           	= 00351330, "fx_fball_smT.dts";
IDDTS_FBALL_M_T           	= 00351331, "fx_fball_mdT.dts";

// shockrings
IDDTS_SHOCK_S             	= 00351340, "fx_shock_sm.dts";
IDDTS_SHOCK_M             	= 00351341, "fx_shock_md.dts";
IDDTS_SHOCK_L             	= 00351342, "fx_shock_lg.dts";
IDDTS_SHOCK_S_T           	= 00351350, "fx_shock_smT.dts";
IDDTS_SHOCK_M_T           	= 00351351, "fx_shock_mdT.dts";
IDDTS_SHOCK_L_T           	= 00351352, "fx_shock_lgT.dts";
IDDTS_DROP_POD_EXPLOSION   = 00351353, "fx_exp_pod.dts";
IDDTS_DROP_POD_EXPLOSION_T = 00351354, "fx_exp_podT.dts";

// impacts (armor)
IDDTS_IMP_TN              	= 00351360, "fx_imp_tn.dts";
IDDTS_IMP_S               	= 00351361, "fx_imp_sm.dts";
IDDTS_IMP_M               	= 00351362, "fx_imp_md.dts";
IDDTS_IMP_L               	= 00351363, "fx_imp_lg.dts";
IDDTS_IMP_FB              	= 00351364, "fx_imp_fb.dts";
IDDTS_IMP_SP              	= 00351365, "fx_imp_sp.dts";
IDDTS_IMP_BULLET          	= 00351366, "";
IDDTS_IMP_TN_T            	= 00351370, "fx_imp_tnT.dts";
IDDTS_IMP_S_T             	= 00351371, "fx_imp_smT.dts";
IDDTS_IMP_M_T             	= 00351372, "fx_imp_mdT.dts";
IDDTS_IMP_L_T             	= 00351373, "fx_imp_lgT.dts";
IDDTS_IMP_FB_T            	= 00351374, "fx_imp_fbT.dts";
IDDTS_IMP_SP_T            	= 00351375, "fx_imp_spT.dts";

// impacts (shield)
IDDTS_SHIELD_ENG          	= 00351380, "fx_shield_eng.dts";
IDDTS_SHIELD_ELC          	= 00351381, "fx_shield_elc.dts";
IDDTS_SHIELD_EXP          	= 00351382, "fx_shield_exp.dts";
IDDTS_SHIELD_SSR          	= 00351383, "fx_shield_ssr.dts";
IDDTS_SHIELD_LSR          	= 00351384, "fx_shield_lsr.dts";
IDDTS_SHIELD_ENG_T        	= 00351390, "fx_shield_engT.dts";
IDDTS_SHIELD_ELC_T        	= 00351391, "fx_shield_elcT.dts";
IDDTS_SHIELD_EXP_T        	= 00351392, "fx_shield_expT.dts";
IDDTS_SHIELD_SSR_T        	= 00351393, "fx_shield_ssrT.dts";
IDDTS_SHIELD_LSR_T        	= 00351394, "fx_shield_lsrT.dts";

// hulks
IDDTS_HULK_10X10          	= 00351500, "hulk_10X10.dts";
IDDTS_HULK_10X20          	= 00351501, "hulk_10X20.dts";
IDDTS_HULK_20X30          	= 00351502, "hulk_20X30.dts";
IDDTS_HULK_20X40          	= 00351503, "hulk_20X40.dts";
IDDTS_HULK_40X40          	= 00351504, "hulk_40X40.dts";
IDDTS_HULK_45X30          	= 00351505, "hulk_45X30.dts";
IDDTS_HULK_4X5            	= 00351506, "hulk_4X5.dts";

// nav point
IDDTS_NAVMARKER            = 00351510, "xNavPoint.dts";

// drop pod
IDDTS_CY_DROP_POD_NEAR     = 00351511, "fx_cyPod.dts";
IDDTS_CY_DROP_POD_NEAR_T   = 00351512, "fx_cyPodT.dts";
IDDTS_CY_DROP_POD_FAR      = 00351513, "fx_cyPod_far.dts";
IDDTS_CY_DROP_POD_FAR_T    = 00351514, "fx_cyPod_farT.dts";

// footprint bitmaps -- ok, so not dts's, but this is most logical place
IDBMP_TR_FOOTPRINT         = 00351520, "tr_footprint.bmp";
IDBMP_TR_FOOTPRINT_3       = 00351521, "tr_footprint3.bmp";
IDBMP_CY_FOOTPRINT         = 00351522, "cy_footprint.bmp";
IDBMP_CY_FOOTPRINT_3       = 00351523, "cy_footprint3.bmp";

IDRES_END_DTS_FILENAMES   	= 00351999, "-- Structures DTS Shape Filenames RESOURCE group reserves tags 351,000 - 351,999 --";

///////////////////////////////////////////////////////////////////////////////
// SMACKER VIDEO FILENAMES (IDSMK)
///////////////////////////////////////////////////////////////////////////////
IDSMK_TEST                	= 00372000, "test.smk";
IDSMK_STORY               	= 00372001, "story.smk";
IDSMK_DYNAMIX             	= 00372002, "dynamix.smk";
IDSMK_INTRO               	= 00372003, "intro.smk";
IDSMK_SCANX_CYBRID         = 00372004, "scannex_cybrid.smk";
IDSMK_SCANX_REBEL          = 00372005, "scannex_rebel.smk";
IDSMK_SCANX_TERRAN         = 00372006, "scannex_terran.smk";
IDSMK_SCANX_ALLI           = 00372007, "scannex_alliance.smk";
IDSMK_SCANX_INQU           = 00372008, "scannex_inquisitor.smk";
IDSMK_SCANX_MACH           = 00372009, "scannex_machinator.smk";
IDSMK_SCANX_MELAN          = 00372010, "scannex_melanie.smk";
IDSMK_SCANX_NAVY           = 00372011, "scannex_navy.smk";
IDSMK_SCANX_ORBIT          = 00372012, "scannex_orbit.smk";
IDSMK_SCANX_VENUS          = 00372013, "scannex_venus.smk";
IDSMK_SCANX_POLICE         = 00372014, "scannex_police.smk";
IDSMK_SCANX_PROV           = 00372015, "scannex_pvorctr.smk";
IDSMK_SCANX_DYSTOPIAN      = 00372016, "scannex_dys_sno.smk";
IDSMK_SCANX_CARDINAL       = 00372017, "scannex_spear.smk";
IDSMK_SCANX_CAANON         = 00372018, "scannex_caanon.smk";
IDSMK_SCANX_HARABEC        = 00372019, "scannex_harabec.smk";
IDSMK_CREDITS              = 00372020, "credits.smk";

IDSMK_TUTORIAL0            = 00372030, "tutorial1.smk";
IDSMK_TUTORIAL1            = 00372031, "tutorial2.smk";
IDSMK_TUTORIAL2            = 00372032, "tutorial3.smk";
IDSMK_TUTORIAL3            = 00372033, "tutorial4.smk";
IDSMK_TUTORIAL4            = 00372034, "tutorial5.smk";
IDSMK_TUTORIAL5            = 00372035, "tutorial6.smk";

///////////////////////////////////////////////////////////////////////////////
// SQUADMATE ORDERS
///////////////////////////////////////////////////////////////////////////////
IDSTR_SQORDER_1            = 00372100, "Attack My Target";
IDSTR_SQORDER_2            = 00372101, "Join On Me";
IDSTR_SQORDER_3            = 00372102, "Defend My Target";
IDSTR_SQORDER_4            = 00372103, "Go To Nav Point";
IDSTR_SQORDER_5            = 00372104, "Hold Fire";
IDSTR_SQORDER_6            = 00372105, "Fire At Will";
IDSTR_SQORDER_7            = 00372106, "Halt!";


///////////////////////////////////////////////////////////////////////////////
// VARIOUS NON-STRING DEFINITIONS (stuff where we don't care what th string is)
///////////////////////////////////////////////////////////////////////////////
IDDEF_WEAPON_DEBRIS       	= 00385000, "matches creation of weapon debris into debris table";
IDDEF_HERC_S_DEBRIS        = 00385001, "";
IDDEF_HERC_M_DEBRIS        = 00385002, "";
IDDEF_HERC_L_DEBRIS        = 00385003, "";
IDDEF_HERC_S_NOEXP_DEBRIS  = 00385004, "";
IDDEF_BUILDING_S_DEBRIS    = 00385005, "";
IDDEF_BUILDING_M_DEBRIS    = 00385006, "";
IDDEF_BUILDING_L_DEBRIS    = 00385007, "";
IDDEF_BUILDING_XL_DEBRIS   = 00385008, "";
IDDEF_HERC_S_QUICK_DEBRIS  = 00385009, "";
IDDEF_HERC_M_QUICK_DEBRIS  = 00385010, "";
IDDEF_HERC_L_QUICK_DEBRIS  = 00385011, "";
IDDEF_HERC_S_NOEXP_QUICK_DEBRIS = 00385012, "";

//IDRGN_END_SIM TT