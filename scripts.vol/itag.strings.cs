//============================================================================================
// ES Inspect Region reserves tags  400,000- 449,999
//    contains Inspect Member Description strings
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
//IDDAT_BEG_ES_ITG            = 00400000, "- ES Inspect DATA group reserves tags 400,000 - 449,999 -";

IDITG_SHAPE_NAME              = 00400001, "Shape Name:";
IDITG_SHAPE_ID                = 00400002, "Shape ID:";
IDITG_SHAPE_POSITION          = 00400003, "Shape Position:";
IDITG_HERC_NAME               = 00400004, "Herc Name:";
IDITG_HERC_ID                 = 00400005, "Herc ID:";
IDITG_HERC_POSITION           = 00400006, "Herc Position:";
IDITG_HERC_ROTATION           = 00400007, "Herc Rotation:";
IDITG_CAPTION_TAG             = 00400008, "Caption Tag:";
IDITG_CAPTIONS                = 00400009, "Captions:";
IDITG_CAPTION_V_POS_DELTA     = 00400010, "Caption V Pos Delta:";
IDITG_BMA_TAG                 = 00400011, "BMA Tag:";
IDITG_TOP_ICON_BMA_TAG        = 00400012, "Top Icon BMA Tag:";
IDITG_BOTTOM_ICON_BMA_LIST    = 00400013, "Bottom Icon List BMA Tag:";
IDITG_NUM_FRAMES_PER_ICON     = 00400014, "Num frames per bottom icon:";
IDITG_SNOW_INTENSITY          = 00400015, "Snowfall Intensity";
IDITG_SNOW_WIND               = 00400016, "Snowfall wind direction";
IDITG_YES_MESG                = 00400017, "Yes mesg tag:";
IDITG_NO_MESG                 = 00400018, "No mesg tag:";
IDITG_LOW_RES                 = 00400019, "Low Resolution Resrc:";
IDITG_HIGH_RES                = 00400020, "High Resolution Resrc:";
IDITG_MAX_TEXT_LEN            = 00400021, "Max text len:";
IDITG_SOLID_BACKGROUND        = 00400022, "Use solid background:";
IDITG_UP_BMP                  = 00400023, "Up Button State Bmp:";
IDITG_DOWN_BMP                = 00400024, "Down Button State Bmp:";
IDITG_TARGETABLE              = 00400025, "Targetable:";
IDITG_SMACK_TAG               = 00400026, "Smacker Tag:";
IDITG_LOOP                    = 00400027, "Loop:";
IDITG_PRELOAD                 = 00400028, "Preload:";
IDITG_PALSTART                = 00400029, "Place at pal index:";
IDITG_PALCOLORS               = 00400030, "Colors used:";
IDITG_STRETCH                 = 00400031, "Stretch to Fit:";
IDITG_LOW_BMP_TAG             = 00400032, "Low Res Bmp Tag:";
IDITG_HIGH_BMP_TAG            = 00400033, "High Res Bmp Tag:";
IDITG_REL_POSITION            = 00400034, "Relative Position:";
IDITG_NAV_COLOR               = 00400035, "Navigation Point Team Color:";
IDITG_NAV_OWNER               = 00400036, "Team (-1 = all teams can see it):";
IDITG_AUTOANIMATE             = 00400037, "Automatically Animate";
IDITG_HULKBURNSAWAY           = 00400038, "Hulk Burns Away";
IDITG_SHAPECOLLFACES          = 00400039, "Shape uses Face collision:";
IDITG_HULKCOLLFACES           = 00400040, "Hulk uses Face collision:";
IDITG_ISSHAPETRANSPARENT      = 00400041, "Shape is Transparent (or Trans.):";
IDITG_DISABLECOLLISIONS       = 00400042, "Disable Collisions:";
IDITG_TARGETPRIORITY          = 00400043, "Priority (0-15), highest targets first in group";
IDITG_SHORTNAME               = 00400044, "Short Name";
IDITG_LONGNAME                = 00400045, "Long (detailed) Name";
IDITG_METER_TYPE              = 00400046, "Meter Type:";
IDITG_DRAGABLE                = 00400047, "Dragable:";
IDITG_NAV_NAME                = 00400048, "Navigation Point name:";
IDITG_REACTOR_MODEL           = 00400050, "Reactor Model:";
IDITG_SENSOR_MODEL            = 00400051, "Sensor Model:";
IDITG_SHIELD_MODEL            = 00400052, "Shield Model:";
IDITG_SKIN_NAME               = 00400053, "Skin Name:";
IDITG_FIRE_AI                 = 00400054, "Uses AI for Firing";
IDITG_TARGET_AI               = 00400055, "Uses AI for Targeting";
IDITG_INIT_POWER              = 00400056, "Power On at Startup";
IDITG_TEAM                    = 00400057, "Team:";
IDITG_SENSORABLE              = 00400058, "Sensorable";
IDITG_MOVIE_DONE_TAG          = 00400059, "Movie Done Tag:";

IDITG_TURRET_FIRE_NAME        = 00400060, "Bayes Network for Firing:";
IDITG_TURRET_TEAM             = 00400061, "Team (-1 = no team, kill all):";
IDITG_TURRET_VELOCITY         = 00400062, "rotational velocity Rad/s:";
IDITG_TURRET_SKILL            = 00400063, "Skill (0-1):";
IDITG_TURRET_ACCURACY         = 00400064, "Accuracy (0-1):";
IDITG_TURRET_ACT_DIST         = 00400065, "Activation distance:";
IDITG_TURRET_DEACT_BUFF       = 00400066, "Distance beyond Activate to Deactivate:";
IDITG_TURRET_WEAPON0          = 00400067, "Weapon........ Left:";
IDITG_TURRET_WEAPON1          = 00400068, "Weapon....... Right:";
IDITG_TURRET_WEAPON2          = 00400069, "Weapon.... Top Left:";
IDITG_TURRET_WEAPON3          = 00400070, "Weapon... Top Right:";
IDITG_TURRET_TARGET_FREQ      = 00400071, "Target selection......... Frequency:";
IDITG_TURRET_TRACK_FREQ       = 00400072, "Target tracking update... Frequency:";
IDITG_TURRET_FIRE_FREQ        = 00400073, "Firing evaluation........ Frequency:";
IDITG_TURRET_RELOAD_FREQ      = 00400074, "Reload/rearm turret......... Period:";
IDITG_TURRET_LOS_FREQ         = 00400075, "LOS check ............... Frequency:";
IDITG_TURRET_RESERVED         = 00400079, "---------------";
IDITG_TURRET_AGGRESSIVENESS   = 00400080, "Aggressiveness (0-1):";
IDITG_BW_FIRE_NET             = 00400081, "Edit: Fire Weapons Network";
IDITG_BW_MANEUVER_NET         = 00400082, "Edit: Maneuver Network";
IDITG_BW_TARGETING_NET        = 00400083, "Edit: Targeting Network";
IDITG_BW_RETREAT_NET          = 00400084, "Edit: Retreat Network";
IDITG_NAV_ACTIVE              = 00400085, "Active";

IDITG_DODEBRIS                = 00400090, "Produce debris?";
IDITG_EXPLODEIMPULSE          = 00400091, "Explosion impulse:";
IDITG_DEBRISTIMEOUT           = 00400092, "Debris timeout:";
IDITG_DEBRISFALLTHRU          = 00400093, "Debris fall through terrain?";
IDITG_FIRETAG                 = 00400094, "Fire tag:";
IDITG_FIREOFFSET              = 00400095, "Fire offset:";
IDITG_FIREDURATION            = 00400096, "Fire duration:";
IDITG_FIREDAMAGETHRESH        = 00400097, "Set fire when this much damage left:";
IDITG_FIREDAMAGERATE          = 00400098, "Rate of damage when on fire:";
IDITG_FIRENOANIM              = 00400099, "Stop animation on fire?";
IDITG_IMPULSEOFFSET           = 00400100, "Impulse offset:";
IDITG_DEBRIS_EXP_PROB         = 00400101, "Probability explode on contact:";
IDITG_DEBRIS_ELASTIC          = 00400102, "Debris elasticity:";
IDITG_DEBRIS_SINK             = 00400103, "Debris sink depth:";
IDITG_EXPOFFSET               = 00400104, "Explosion offset:";
IDITG_EXPTIME                 = 00400105, "Explosion time:";
IDITG_FIRETIME                = 00400106, "Fire start delay:";
IDITG_HULKFROM                = 00400107, "Hulk from shape?";
IDITG_BLAST                   = 00400108, "Blast Damage:";

IDITG_MOUNTPOINT1             = 00400121, "Mount Point #1";
IDITG_MOUNTPOINT2             = 00400122, "Mount Point #1";
IDITG_MOUNTPOINT3             = 00400123, "Mount Point #1";
IDITG_MOUNTPOINT4             = 00400124, "Mount Point #1";
IDITG_MOUNTPOINT5             = 00400125, "Mount Point #1";
IDITG_MOUNTPOINT6             = 00400126, "Mount Point #1";
IDITG_MOUNTPOINT7             = 00400127, "Mount Point #1";
IDITG_MOUNTPOINT8             = 00400128, "Mount Point #1";
IDITG_MOUNTPOINT9             = 00400129, "Mount Point #1";
IDITG_MOUNTPOINT10            = 00400130, "Mount Point #1";
IDITG_MOUNTPOINT11            = 00400131, "Mount Point #1";
IDITG_MOUNTPOINT12            = 00400132, "Mount Point #1";
IDITG_MOUNTPOINT13            = 00400133, "Mount Point #1";
IDITG_MOUNTPOINT14            = 00400134, "Mount Point #1";
IDITG_MOUNTPOINT15            = 00400135, "Mount Point #1";
IDITG_CURMAXTOPSPEED          = 00400140, "Current/Max Top Speed";
IDITG_CURMAXMASS              = 00400141, "Current/Max Mass";
IDITG_CURMAXENERGY            = 00400142, "Current/Max Energy";
IDITG_DRAWSHADOW              = 00400143, "Draw Shadow";
IDITG_SHADOWPERIOD            = 00400144, "Shadow Animation Period:";


// spline camera tags
IDITG_FOV                     = 00400200, "Field of View (degrees):";
IDITG_VELOCITY                = 00400201, "Velocity (m/s):";
IDITG_TANGENT                 = 00400202, "Tangent to Curve";
IDITG_NORMAL                  = 00400203, "Normal to Curve";

// script
IDITG_SCRIPT_ARRIVE           = 00400300, "Script (onArrive):";

IDITG_WIN_STLYE               = 00402000, "Win style:";
IDITG_WIN_TITLE_MARGIN        = 00402001, "Title margin:";
IDITG_WIN_LIGHT_WINDOW        = 00402002, "Light Window:";
IDITG_WIN_DARK_WINDOW         = 00402003, "Dark Window:";
IDITG_WIN_LIGHT_TITLE_WIN     = 00402004, "Light Title Window:";
IDITG_WIN_DARK_TITLE_WIN      = 00402005, "Dark Title Window:";
IDITG_WIN_LIGHT_RND_PANEL     = 00402006, "Light Rounded Panel:";
IDITG_WIN_DARK_RND_PANEL      = 00402007, "Dark Rounded Panel:";
IDITG_WIN_LIGHT_PANEL         = 00402008, "Light Panel:";
IDITG_WIN_DARK_PANEL          = 00402009, "Dark Panel:";
IDITG_BTN_STYLE               = 00402010, "Button style:";
IDITG_BTN_MAIN_SMALL          = 00402011, "Main Small";
IDITG_BTN_MAIN_MEDIUM         = 00402012, "Main Medium";
IDITG_BTN_MAIN_LARGE          = 00402013, "Main Large";
IDITG_BTN_KNOB_SMALL          = 00402014, "Knob Small";
IDITG_BTN_KNOB_MEDIUM         = 00402015, "Knob Medium";
IDITG_BTN_KNOB_LARGE          = 00402016, "Knob Large";
IDITG_BTN_CHECK_BOX           = 00402017, "Check Box";
IDITG_BTN_FIRE_CHAIN          = 00402018, "Fire Chain";
IDITG_BTN_BMP                 = 00402019, "Bitmap";
IDITG_BTN_CELL                = 00402020, "Cell";
IDITG_FRAME_STYLE             = 00402021, "Frame Style";
IDITG_EMPTY_BMP_TAG           = 00402022, "Empty BMP Tag:";
IDITG_PALETTE_START           = 00402023, "Palette Start:";
IDITG_PALETTE_END             = 00402024, "Palette End:";
IDITG_HISTORY_SIZE            = 00402025, "History Size:";

//IDDAT_END_ES_ITG            = 00449999, "- ES Inspect DATA group reserves tags 400,000 - 449,999 -";
q