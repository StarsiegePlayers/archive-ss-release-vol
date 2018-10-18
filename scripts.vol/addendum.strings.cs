//------------------------------------------------------------------------------
// Addendum strings cs
// These are additional strings we added after v1.0 Starsiege 
// (U.S. and U.K release gold).
// 
// These strings were added to make the executible fully localizable
//
// The range is 135,000 to 139,998
//------------------------------------------------------------------------------


//------------------------------------------------------------------------------
// Data section.  All of these Strings need to be translated
//------------------------------------------------------------------------------
IDDAT_ADDENDUM_BEG			      = 00135000; 

IDSTR_ADN_SELECT_CAMPAIGN        = 00135001, "SELECT CAMPAIGN";
IDSTR_ADN_SELECT_TRAIN_MIS       = 00135002, "SELECT TRAINING MISSION";
IDSTR_ADN_CHANNELS               = 00135003, "channels";
IDSTR_ADN_PEOPLE                 = 00135004, "people";
IDSTR_ADN_FIRING_CHAINS          = 00135009, "FIRING CHAINS";
IDSTR_ADN_CONFIG_FIRING_CHAINS   = 00135010, "CONFIG FIRING CHAINS";
IDSTR_ADN_INSTALL                = 00135011, "INSTALL";
IDSTR_ADN_CONFIGURE_VEHICLE      = 00135012, "CONFIGURE VEHICLE:";
IDSTR_ADN_EXIT                   = 00135013, "EXIT";
IDSTR_ADN_SAVE_VEHICLE           = 00135014, "Save Vehicle";
IDSTR_ADN_SAVE_THE_VEH_TO_FILE   = 00135015, "Save the vehicle to file:";
IDSTR_ADN_CURRENT_MISSION        = 00135016, "CURRENT MISSION:";
IDSTR_ADN_TECH_ACCESS            = 00135017, "TECH ACCESS:";
IDSTR_ADN_SQUAD_STATISTICS       = 00135018, "SQUAD STATISTICS";
IDSTR_ADN_NAME                   = 00135019, "NAME";
IDSTR_ADN_SQUAD_MIS_HISTORY      = 00135020, "SQUAD MISSION HISTORY";
IDSTR_ADN_COMPLETED              = 00135021, "COMPLETED";
IDSTR_ADN_SPEED_KPH              = 00135022, "Speed(KPH):";
IDSTR_ADN_VEHICLE_DEPOT          = 00135023, "VEHICLE DEPOT";
IDSTR_ADN_DISCARD_VEHICLE        = 00135024, "DISCARD VEHICLE";
IDSTR_ADN_PASSWORD               = 00135025, "PASSWORD:";
IDSTR_ADN_TEAM_STARSIEGE         = 00135026, "TEAM: STARSIEGE";
IDSTR_ADN_SEND_SHUT_DWN_NOTICE   = 00135027, "SEND SHUT DOWN NOTICE";
IDSTR_ADN_RECORD_MISSION         = 00135028, "RECORD MISSION";
IDSTR_ADN_ALERT                  = 00135029, "ALERT";
IDSTR_ADN_STATUS                 = 00135030, "Status";
IDSTR_ADN_NONE                   = 00135031, "none";
IDSTR_ADN_NONE_MIXED_CASE        = 00135032, "None";

// We have to redefine the planet strings here because the
// ones in gui.strings.cs cannot be translated.  They are
// being used as literals in the script files and changing
// the tags in gui.strings.cs will cause the game to break.
IDSTR_ADN_PLANET_MARS            = 00135033, "Mars";   
IDSTR_ADN_PLANET_EUROPA          = 00135034, "Europa"; 
IDSTR_ADN_PLANET_MERCURY         = 00135035, "Mercury";
IDSTR_ADN_PLANET_MOON            = 00135036, "Moon";   
IDSTR_ADN_PLANET_PLUTO           = 00135037, "Pluto";  
IDSTR_ADN_PLANET_TITAN           = 00135038, "Titan";  
IDSTR_ADN_PLANET_VENUS           = 00135039, "Venus";  

IDSTR_ADN_MESG_BOX_CAP_ALERT     = 00135040, "Alert";
IDSTR_ADN_RECOMMEND_8BIT         = 00135041, "Starsiege runs best when your monitor color depth is set to 16 bits.\n\nWe recommend you exit from the game and change your settings in\nthe display properties control panel.\n\nNote: To use OpenGL you must set the color depth to at least 16 bits.";

IDSTR_ADN_INT_STATUS             = 00135042, "Internals Status:";

IDSTR_ADN_BAD_PACKET_ERROR       = 00135043, "Invalid Packet Received By Server";

IDSTR_ADN_VERIFY_DELETE          = 00135044, "Are you sure you want to delete %s?";
IDSTR_ADN_KICK_CHEATER           = 00135045, "Corrupted Vehicle Detected";
  
IDDAT_ADDENDUM_END			     = 00139997; 

//------------------------------------------------------------------------------
// Resources and miscellaneous strings 
//------------------------------------------------------------------------------
IDRES_ADDENDUM_BEG               = 03000000;

// This tag is used to identify the default keymap that 
// should be used when none is specified by the user.
IDADN_DEFAULT_KEY_MAP            = 03000001, "Keyboard_Mouse.cs";

// This tag is used to identify the default campaign mission
// that should be selected when the user enters the
// new game screen
IDADN_DEFAULT_CAMPAIGN_MISSION   = 03000002, "Human";

IDADN_CAMPAIGN_SORT_KEY_HUMAN    = 03000003, "Human";
IDADN_CAMPAIGN_SORT_KEY_CYBRID   = 03000004, "Cybrid";

// These tags are used to display the windowed and
// fullscreen render options
IDADN_RENDER_SOFTWARE            = 03001005, "Software";
IDADN_RENDER_GLIDE               = 03001006, "Glide";
IDADN_RENDER_OPENGL              = 03001007, "OpenGL";
                                        
// these are strings describing the keys on the keyboard
IDADN_DIK_ESCAPE                 = 03001101, "escape";
IDADN_DIK_BACK                   = 03001102, "backspace";
IDADN_DIK_TAB                    = 03001103, "tab";
IDADN_DIK_RETURN                 = 03001104, "enter";
IDADN_DIK_LCONTROL               = 03001105, "lcontrol";
IDADN_DIK_APOSTROPHE             = 03001106, "quote";
IDADN_DIK_LSHIFT                 = 03001107, "lshift";
IDADN_DIK_COMMA                  = 03001108, "comma";
IDADN_DIK_PERIOD                 = 03001109, "period";
IDADN_DIK_RSHIFT                 = 03001110, "rshift";
IDADN_DIK_MULTIPLY               = 03001111, "numpad*";
IDADN_DIK_LMENU                  = 03001112, "lalt";   
IDADN_DIK_SPACE                  = 03001113, "space";  
IDADN_DIK_CAPITAL                = 03001114, "capslock";
IDADN_DIK_F1                     = 03001115, "f1";
IDADN_DIK_F2                     = 03001116, "f2";
IDADN_DIK_F3                     = 03001117, "f3";
IDADN_DIK_F4                     = 03001118, "f4";
IDADN_DIK_F5                     = 03001119, "f5";
IDADN_DIK_F6                     = 03001120, "f6";
IDADN_DIK_F7                     = 03001121, "f7";
IDADN_DIK_F8                     = 03001122, "f8";
IDADN_DIK_F9                     = 03001123, "f9";
IDADN_DIK_F10                    = 03001124, "f10";
IDADN_DIK_F11                    = 03001125, "f11";
IDADN_DIK_F12                    = 03001126, "f12";
IDADN_DIK_F13                    = 03001127, "f13";
IDADN_DIK_F14                    = 03001128, "f14";
IDADN_DIK_F15                    = 03001129, "f15";
IDADN_DIK_NUMLOCK                = 03001130, "numlock";  
IDADN_DIK_SCROLL                 = 03001131, "scroll";   
IDADN_DIK_NUMPAD7                = 03001132, "numpad7";  
IDADN_DIK_NUMPAD8                = 03001133, "numpad8";  
IDADN_DIK_NUMPAD9                = 03001134, "numpad9";  
IDADN_DIK_SUBTRACT               = 03001135, "numpad-";  
IDADN_DIK_NUMPAD4                = 03001136, "numpad4";  
IDADN_DIK_NUMPAD5                = 03001137, "numpad5";  
IDADN_DIK_NUMPAD6                = 03001138, "numpad6";  
IDADN_DIK_ADD                    = 03001139, "numpad+";  
IDADN_DIK_NUMPAD1                = 03001140, "numpad1";  
IDADN_DIK_NUMPAD2                = 03001141, "numpad2";  
IDADN_DIK_NUMPAD3                = 03001142, "numpad3";  
IDADN_DIK_NUMPAD0                = 03001143, "numpad0";
IDADN_DIK_NUMPADEQUALS           = 03001144, "numpadequals";    
IDADN_DIK_STOP                   = 03001145, "stop";            
IDADN_DIK_NUMPADENTER            = 03001146, "numpadenter";     
IDADN_DIK_RCONTROL               = 03001147, "rcontrol";        
IDADN_DIK_NUMPADCOMMA            = 03001148, "numpadcomma";     
IDADN_DIK_DIVIDE                 = 03001149, "numpad/";         
IDADN_DIK_SYSRQ                  = 03001150, "sysreq";          
IDADN_DIK_RMENU                  = 03001151, "ralt";            
IDADN_DIK_HOME                   = 03001152, "home";            
IDADN_DIK_UP                     = 03001153, "up";              
IDADN_DIK_PRIOR                  = 03001154, "prior";           
IDADN_DIK_LEFT                   = 03001155, "left";            
IDADN_DIK_RIGHT                  = 03001156, "right";           
IDADN_DIK_END                    = 03001157, "end";             
IDADN_DIK_DOWN                   = 03001158, "down";            
IDADN_DIK_NEXT                   = 03001159, "next";            
IDADN_DIK_INSERT                 = 03001160, "insert";          
IDADN_DIK_DELETE                 = 03001161, "delete";          
IDADN_DIK_LWIN                   = 03001162, "win";             
IDADN_DIK_RWIN                   = 03001163, "win";             
IDADN_DIK_APPS                   = 03001164, "app";             
                          
IDADN_DIK_MODIFIER_ALT           = 03003001, "alt-";
IDADN_DIK_MODIFIER_SHIFT         = 03003002, "sift-";
IDADN_DIK_MODIFIER_CTRL          = 03003003, "ctrl-";
                                         
IDRES_ADDENDUM_END               = 03100000;
S