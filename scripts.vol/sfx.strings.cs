//============================================================================================
// ES Sfx Region reserves tags  400,000- 409,999
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

///////////////////////////////////////////////////////////////////////////////
// SFX ID CONSTANTS  ( IDSFX )
///////////////////////////////////////////////////////////////////////////////
//IDSFX_BEG_SFX                   00450000

// Profile Id's
IDPRF_2D                        = 00450001, "";
IDPRF_WEAPON                    = 00450002, "";
IDPRF_NEAR                      = 00450003, "";
IDPRF_MEDIUM                    = 00450004, "";
IDPRF_FAR                       = 00450005, "";
IDPRF_FIRE                      = 00450006, "";
IDPRF_EXP_SM                    = 00450007, "";
IDPRF_EXP_MED                   = 00450008, "";
IDPRF_EXP_LRG                   = 00450009, "";
IDPRF_TANK                      = 00450010, "";
IDPRF_COMP                      = 00450011, "";
IDPRF_2D_LOOPING                = 00450012, "";
IDPRF_ALARM                     = 00450013, "";
IDPRF_STREAMING                 = 00450014, "";
IDPRF_FLYER                     = 00450015, "";
IDPRF_FLYER_LOOPING             = 00450016, "";
 

// Channel Id's
IDCH_COMPUTER                   = 00455000, "";


//Weapons 0000-0499                 
IDSFX_LAS                       = 00460001, "";            
IDSFX_HLAS                      = 00460002, "";
IDSFX_CLAS                      = 00460003, "";
IDSFX_TLAS                      = 00460004, "";
IDSFX_EMP                       = 00460005, "";
IDSFX_ELF                       = 00460006, "";
IDSFX_BLAS                      = 00460007, "";
IDSFX_HBLA                      = 00460008, "";
IDSFX_PBW                       = 00460009, "";
IDSFX_PLAS                      = 00460010, "";
IDSFX_BLNK                      = 00460011, "";
IDSFX_QGUN                      = 00460012, "";
IDSFX_MFAC                      = 00460013, "";
IDSFX_NANO                      = 00460014, "";
IDSFX_NCAN                      = 00460015, "";
IDSFX_ATC                       = 00460016, "";
IDSFX_HATC                      = 00460017, "";
IDSFX_EMC                       = 00460018, "";
IDSFX_BC                        = 00460019, "";
IDSFX_HBC                       = 00460020, "";
IDSFX_RAIL                      = 00460021, "";
IDSFX_LGB                       = 00460022, "";
IDSFX_HAD                       = 00460023, "";
IDSFX_VIP8                      = 00460024, "";
IDSFX_VIP12                     = 00460025, "";
IDSFX_SPR6                      = 00460026, "";
IDSFX_SPR10                     = 00460027, "";
IDSFX_SWRM                      = 00460028, "";
IDSFX_MIN                       = 00460029, "";
IDSFX_SHRK                      = 00460030, "";
IDSFX_ARA4                      = 00460031, "";
IDSFX_ARA8                      = 00460032, "";
IDSFX_ARA12                     = 00460033, "";
IDSFX_PRX6                      = 00460034, "";
IDSFX_PRX10                     = 00460035, "";
IDSFX_PRX15                     = 00460036, "";
IDSFX_CMD10                     = 00460037, "";
IDSFX_CMD15                     = 00460038, "";
IDSFX_CMD20                     = 00460039, "";
IDSFX_NIKE                      = 00460040, "";
IDSFX_AML                       = 00460041, "";
IDSFX_RAD                       = 00460042, "";
IDSFX_DIS                       = 00460043, "";
IDSFX_EHUL                      = 00460044, "";
IDSFX_PROB                      = 00460045, "";
IDSFX_FOG                       = 00460046, "";
IDSFX_APH                       = 00460047, "";
IDSFX_SGUN                      = 00460048, "";

//Effects 0500-0999
IDSFX_EXP_SMALL                 = 00460500, "";
IDSFX_EXP_MED                   = 00460501, "";
IDSFX_EXP_LARGE                 = 00460502, "";
IDSFX_HITVEHICLE                = 00460503, "";
IDSFX_HITWALL                   = 00460504, "";
IDSFX_FIRE                      = 00460505, "";
IDSFX_CAMOUFLAGE                = 00460506, "";
IDSFX_REACTOR_ON                = 00460507, "";
IDSFX_REACTOR_OFF               = 00460508, "";
IDSFX_ENEMY_SELECT              = 00460509, "";
IDSFX_FRIENDLY_SELECT           = 00460510, "";
IDSFX_COMPUTER_ON               = 00460511, "";
IDSFX_COMPUTER_OFF              = 00460512, "";
IDSFX_NO_TARGET                 = 00460513, "";
IDSFX_BULLETARMOR               = 00460514, "";
IDSFX_HERC_DEBRIS_BOUNCE        = 00460515, "";
IDSFX_SHIELD_CAP_NOTREADY       = 00460516, "";
IDSFX_SHIELD_CAP_BACKFIRE       = 00460517, "";
IDSFX_SHIELD_CAP_USE            = 00460518, "";
IDSFX_REACTOR_CAP_NOTREADY      = 00460519, "";
IDSFX_REACTOR_CAP_BACKFIRE      = 00460520, "";
IDSFX_REACTOR_CAP_USE           = 00460521, "";
IDSFX_SHIELD_ON                 = 00460522, "";
IDSFX_SHIELD_OFF                = 00460523, "";
IDSFX_PILOT_HIT                 = 00460524, "";
IDSFX_SPOT_ON                   = 00460525, "";
IDSFX_SPOT_LOCK                 = 00460526, "";
IDSFX_ROCKET_BOOST_ON           = 00460527, "";
IDSFX_ROCKET_BOOST_OFF          = 00460528, "";
IDSFX_TURBINE_BOOST_ON          = 00460529, "";
IDSFX_TURBINE_BOOST_OFF         = 00460530, "";
IDSFX_INCOMING_ARTILLERY	  	= 00460531, "";
IDSFX_REACTOR_EXPLODE		 	= 00460532, "";
IDSFX_TELEPORTER				= 00460533, "";
IDSFX_ELECTRICAL_BZZT			= 00460534, "";
IDSFX_ALARM						= 00460535, "";
IDSFX_SIREN						= 00460536, "";
IDSFX_CYBRID_ALARM				= 00460537, "";

//Shell  1000-1499
IDSFX_ROLLOVER                  = 00461000, "";
IDSFX_BUTTON_DOWN               = 00461001, "";
IDSFX_BUTTON_UP                 = 00461002, "";
IDSFX_SHELL_MUSIC               = 00461003, "";

//misc   1500-1999
IDSFX_FOOTFALL_TERRAIN          = 00461500, "";
IDSFX_FOOTFALL_ZED              = 00461501, "";
IDSFX_DROP                      = 00461510, "";
IDSFX_BEEP                      = 00461511, "";
IDSFX_NEW_MESSAGE               = 00461512, "";
IDSFX_BIG_BEAM   	            = 00461513, "";
IDSFX_BIG_BEAM_FIRE             = 00461514, "";
IDSFX_ORBITAL_GUN               = 00461515, "";


// vehicle sounds
IDSFX_TANK_ENGINE_0             = 00462000, "";
IDSFX_TANK_ENGINE_1             = 00462001, "";
IDSFX_TANK_ENGINE_2             = 00462002, "";
IDSFX_TANK_ENGINE_3             = 00462003, "";
IDSFX_TANK_ENGINE_4             = 00462004, "";

IDSFX_HERC_ENGINE_0             = 00462010, "";
IDSFX_HERC_ENGINE_1             = 00462011, "";
IDSFX_HERC_ENGINE_2             = 00462012, "";

IDSFX_FLYER_ON	            	= 00462015, "";
IDSFX_FLYER_OFF 	            = 00462016, "";
IDSFX_FLYER_ENGINE              = 00462017, "";
IDSFX_FLYER_DAMAGED             = 00462018, "";

//Ambient Planet Sounds
//Ice Planet Sounds
IDSFX_AMBIENT_ICE1 	        	= 00463000, "";
IDSFX_AMBIENT_ICE2 	        	= 00463001, "";
IDSFX_AMBIENT_ICE3 	        	= 00463002, "";
IDSFX_AMBIENT_AVALANCHE			= 00463003, "";	

//Venus
IDSFX_AMBIENT_LAVA 	        	= 00463004, "";

//Titan
IDSFX_AMBIENT_METEOR	  		= 00463005, "";
IDSFX_AMBIENT_GLOOP				= 00463006, "";	

//Mercury
IDSFX_AMBIENT_QUAKE	  			= 00463007, "";

//Temperate
IDSFX_AMBIENT_RAIN	  			= 00463008, "";
IDSFX_AMBIENT_THUNDER1	  		= 00463009, "";
IDSFX_AMBIENT_THUNDER2	  		= 00463010, "";

//Mars
IDSFX_AMBIENT_WINDGUST	  		= 00463011, "";
IDSFX_AMBIENT_WIND1	  			= 00463012, "";
IDSFX_AMBIENT_WIND2	  			= 00463013, "";

//Human Ambient Sounds
IDSFX_AMBIENT_HUMAN_INDUSTRIAL1	= 00463020, "";
IDSFX_AMBIENT_HUMAN_INDUSTRIAL2	= 00463021, "";
IDSFX_AMBIENT_HUMAN_INDUSTRIAL3	= 00463022, "";
IDSFX_AMBIENT_HUMAN_RADAR		= 00463023, "";

//Cybrid Ambient Sounds
IDSFX_AMBIENT_CYBRID_COM		= 00463024, "";	
IDSFX_AMBIENT_CYBRID_INDUSTRY	= 00463025, "";	

//General Industrial Sounds
IDSFX_AMBIENT_INDUSTRIAL		= 00463026, "";
IDSFX_AMBIENT_STEAM				= 00463027, "";

//other...TBA

//Voice  7000-9999
IDCV_FIRST_HUMAN_CV              = 00470000, "";
IDCV_MISSION_COMPLETE            = 00470001, "";
IDCV_MISSION_FAILED              = 00470002, "";
IDCV_MISSION_ABORTED             = 00470003, "";
IDCV_NEW_OBJECTIVE               = 00470004, "";
IDCV_RULES_VIOLATED              = 00470005, "";
IDCV_BOUNDARY                    = 00470006, "";
IDCV_60SEC_WARN                  = 00470007, "";
IDCV_30SEC_WARN                  = 00470008, "";
IDCV_WEAPON_DESTROYED            = 00470009, "";
IDCV_LOW_ENERGY                  = 00470010, "";
IDCV_RELOAD_ENTER                = 00470011, "";
IDCV_RELOAD_COMPLETE             = 00470012, "";
IDCV_REPAIR_ENTER                = 00470013, "";
IDCV_REPAIR_COMPLETE             = 00470014, "";
IDCV_BLUE_CAPTURED               = 00470015, "";
IDCV_BLUE_STOLEN                 = 00470016, "";
IDCV_BLUE_SURRENDERED            = 00470017, "";
IDCV_RED_CAPTURED                = 00470018, "";
IDCV_RED_STOLEN                  = 00470019, "";
IDCV_RED_SURRENDERED             = 00470020, "";
IDCV_PURPLE_CAPTURED             = 00470021, "";
IDCV_PURPLE_STOLEN               = 00470022, "";
IDCV_PURPLE_SURRENDERED          = 00470023, "";
IDCV_YELLOW_CAPTURED             = 00470024, "";
IDCV_YELLOW_STOLEN               = 00470025, "";
IDCV_YELLOW_SURRENDERED          = 00470026, "";
IDCV_DLINK_ENGAGED               = 00470027, "";
IDCV_DLINK_ABORTED               = 00470028, "";
IDCV_DLINK_COMPLETE              = 00470029, "";
IDCV_NAVPOINT                    = 00470030, "";
IDCV_ACTIVE_SENSORS              = 00470031, "";
IDCV_PASSIVE_SENSORS             = 00470032, "";
IDCV_SCANNING                    = 00470033, "";
IDCV_ECM_ON                      = 00470034, "";
IDCV_ECM_OFF                     = 00470035, "";
IDCV_TDIFF_ON                    = 00470036, "";
IDCV_TDIFF_OFF                   = 00470037, "";
IDCV_ARTILLERY                   = 00470038, "";
IDCV_DAM_INTERNAL                = 00470039, "";
IDCV_DES_SHIELD                  = 00470040, "";
IDCV_WRN_MISSILE                 = 00470041, "";
IDCV_MISSILE_LOCK                = 00470042, "";
IDCV_POWER_ON                    = 00470043, "";
IDCV_POWER_OFF                   = 00470044, "";
IDCV_TARGETED                    = 00470045, "";
IDCV_SHIELD_CRITICAL             = 00470046, "";
IDCV_REACTOR_DESTROYED           = 00470047, ""; 
IDCV_COMPUTER_DAMAGED            = 00470048, "";
IDCV_LAST_HUMAN_CV               = 00470199, "";

IDCV_FIRST_CYBRID_CV             = 00470200, "";
IDCV_CY_MISSION_COMPLETE         = 00470201, "";
IDCV_CY_MISSION_FAILED           = 00470202, "";
IDCV_CY_MISSION_ABORTED          = 00470203, "";
IDCV_CY_NEW_OBJECTIVE            = 00470204, "";
IDCV_CY_RULES_VIOLATED           = 00470205, "";
IDCV_CY_BOUNDARY                 = 00470206, "";
IDCV_CY_60SEC_WARN               = 00470207, "";
IDCV_CY_30SEC_WARN               = 00470208, "";
IDCV_CY_WEAPON_DESTROYED         = 00470209, "";
IDCV_CY_LOW_ENERGY               = 00470210, "";
IDCV_CY_RELOAD_ENTER             = 00470211, "";
IDCV_CY_RELOAD_COMPLETE          = 00470212, "";
IDCV_CY_REPAIR_ENTER             = 00470213, "";
IDCV_CY_REPAIR_COMPLETE          = 00470214, "";
IDCV_CY_BLUE_CAPTURED            = 00470215, "";
IDCV_CY_BLUE_STOLEN              = 00470216, "";
IDCV_CY_BLUE_SURRENDERED         = 00470217, "";
IDCV_CY_RED_CAPTURED             = 00470218, "";
IDCV_CY_RED_STOLEN               = 00470219, "";
IDCV_CY_RED_SURRENDERED          = 00470220, "";
IDCV_CY_PURPLE_CAPTURED          = 00470221, "";
IDCV_CY_PURPLE_STOLEN            = 00470222, "";
IDCV_CY_PURPLE_SURRENDERED       = 00470223, "";
IDCV_CY_YELLOW_CAPTURED          = 00470224, "";
IDCV_CY_YELLOW_STOLEN            = 00470225, "";
IDCV_CY_YELLOW_SURRENDERED       = 00470226, "";
IDCV_CY_DLINK_ENGAGED            = 00470227, "";
IDCV_CY_DLINK_ABORTED            = 00470228, "";
IDCV_CY_DLINK_COMPLETE           = 00470229, "";
IDCV_CY_NAVPOINT                 = 00470230, "";
IDCV_CY_ACTIVE_SENSORS           = 00470231, "";
IDCV_CY_PASSIVE_SENSORS          = 00470232, "";
IDCV_CY_SCANNING                 = 00470233, "";
IDCV_CY_ECM_ON                   = 00470234, "";
IDCV_CY_ECM_OFF                  = 00470235, "";
IDCV_CY_TDIFF_ON                 = 00470236, "";
IDCV_CY_TDIFF_OFF                = 00470237, "";
IDCV_CY_ARTILLERY                = 00470238, "";
IDCV_CY_DAM_INTERNAL             = 00470239, "";
IDCV_CY_DES_SHIELD               = 00470240, "";
IDCV_CY_WRN_MISSILE              = 00470241, "";
IDCV_CY_MISSILE_LOCK             = 00470242, "";
IDCV_CY_POWER_ON                 = 00470243, "";
IDCV_CY_POWER_OFF                = 00470244, "";
IDCV_CY_TARGETED                 = 00470245, "";
IDCV_CY_SHIELD_CRITICAL          = 00470246, "";
IDCV_CY_REACTOR_DESTROYED        = 00470247, ""; 
IDCV_CY_COMPUTER_DAMAGED         = 00470248, "";
IDCV_LAST_CYBRID_CV              = 00470299, "";






//IDCV_CLOAK_ON                   = 00470002, "";
//IDCV_CLOAK_OFF                  = 00470003, "";
//IDCV_DAM_CRITICAL               = 00470004, "";
//IDCV_DAM_CLOAK                  = 00470005, "";
//IDCV_DAM_COMPUTER               = 00470006, "";
//IDCV_DAM_ENGINE                 = 00470007, "";
//IDCV_DAM_FLEXORS                = 00470008, "";
//IDCV_DAM_LIFE                   = 00470009, "";
//IDCV_DAM_POWERPLANT             = 00470010, "";
//IDCV_DAM_REACTOR                = 00470011, "";
//IDCV_DAM_SENSOR                 = 00470012, "";
//IDCV_DAM_SHIELD                 = 00470013, "";
//IDCV_DAM_STABILIZERS            = 00470014, "";
//IDCV_DES_CLOAK                  = 00470016, "";
//IDCV_DES_COMPUTER               = 00470017, "";
//IDCV_DES_FLEXORS                = 00470018, "";
//IDCV_DES_POWERPLANT             = 00470019, "";
//IDCV_DES_REACTOR                = 00470020, "";
//IDCV_ERROR                      = 00470023, "";
//IDCV_EXIT                       = 00470024, "";
//IDCV_LOW_SHIELDS                = 00470026, "";
//IDCV_CRIT_SHIELD                = 00470033, "";
//IDCV_STRUCTURAL                 = 00470034, "";
//IDCV_OPERATIONAL                = 00470035, "";
//IDCV_ENEMY_DETECT               = 00470038, "";
//IDCV_ENEMY_DISABLED             = 00470039, "";
//IDCV_ENEMY_DESTROYED            = 00470040, "";
//IDCV_FRIEND_DISABLED            = 00470041, "";
//IDCV_FRIEND_DESTROYED           = 00470042, "";
//IDCV_MISSION_SUCCESS            = 00470043, "";
//IDCV_PRIMARY_COMPLETE           = 00470044, "";

//IDSFX_END_SFX                   00499999
      
      
      
      
      
      
      
      
      A