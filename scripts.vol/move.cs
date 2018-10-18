// check which version should be loaded..
if( $ME::Loaded == "true" )
{
   function ME::Move( %speed, %rot, %turbo )
   {
      if( %speed == "" ) 
         %speed = 100.0;
      if( %rot == "" )
         %rot = 1.5;
      if( %turbo == "" )
         %turbo = 5.0;

      $ME::CameraMoveSpeed   = %speed;
      $ME::CameraRotateSpeed = %rot;
		$ME::CameraTurboSpeed  = %turbo;
   }

   newActionMap( "editCamera.sae" );

	#------- Keyboard Controls
   bindAction( keyboard, make,  a, TO, IDACTION_MOVE_X, -1.0 );
   bindAction( keyboard, break, a, TO, IDACTION_MOVE_X,  0.0 );
   bindAction( keyboard, make,  d, TO, IDACTION_MOVE_X,  1.0 );
   bindAction( keyboard, break, d, TO, IDACTION_MOVE_X,  0.0 );
   bindAction( keyboard, make,  s, TO, IDACTION_MOVE_Y, -1.0 );
   bindAction( keyboard, break, s, TO, IDACTION_MOVE_Y,  0.0 );
   bindAction( keyboard, make,  w, TO, IDACTION_MOVE_Y,  1.0 );
   bindAction( keyboard, break, w, TO, IDACTION_MOVE_Y,  0.0 );
   bindAction( keyboard, make,  e, TO, IDACTION_MOVE_Z,  1.0 );
   bindAction( keyboard, break, e, TO, IDACTION_MOVE_Z,  0.0 );
   bindAction( keyboard, make,  c, TO, IDACTION_MOVE_Z, -1.0 );
   bindAction( keyboard, break, c, TO, IDACTION_MOVE_Z,  0.0 );

	#------- Joystick Controls
	//bindAction( joystick0, zaxis, TO, IDACTION_SPEED, deadzone, 0.1, center, square );
	bindAction( joystick0, xaxis, TO, IDACTION_ROLL, deadzone, 0.1, center, square, flip );
	bindAction( joystick0, yaxis, TO, IDACTION_PITCH, deadzone, 0.1, center, square, flip );
	bindAction( joystick0, rzaxis, TO, IDACTION_YAW, deadzone, 0.1, center, square );
	bindAction( joystick0, make, button0, TO, IDACTION_STOP );
	bindAction( joystick0, make, button1, TO, IDACTION_TURBO );

   bindCommand( keyboard, make, f1, TO, "MEHide();");
   bindCommand( keyboard, make, f2, TO, "MEShowInspector();");
   bindCommand( keyboard, make, f3, TO, "MEShowCreator();");
   bindCommand( keyboard, make, f4, TO, "MEShowTed();");
   bindCommand( keyboard, make, f5, TO, "MEGameMode();");
   bindCommand( keyboard, make, f9, TO, "METoggleHelp();" );
   bindCommand( keyboard, make,  o, TO, "METoggleOptions();");

   // just to remove the useless map view
   bindaction( keyboard, make,  Enter, TO, IDACTION_TURBO);   
   
   //   
   bindCommand( keyboard, make, control, delete, TO, "MEDeleteSelection();" );
   bindCommand( keyboard, make, delete, TO, "MEDeleteSelection();" );
   bindCommand( keyboard, make, control, c, TO, "MECopySelection();" );
   bindCommand( keyboard, make, "numpad+", TO, "MECopySelection();" );
   bindCommand( keyboard, make, control, x, TO, "MECutSelection();" );
   bindCommand( keyboard, make, "numpad-", TO, "MECutSelection();" );
   bindCommand( keyboard, make, control, v, TO, "MEPasteSelection();" );
   bindCommand( keyboard, make, "numpad0", TO, "MEPasteSelection();" );
   bindCommand( keyboard, make, control, d, TO, "MEDropSelection();");

   bindCommand( keyboard, make, control, n, TO, "ME::CreateGroup();" );

   //
   bindCommand( keyboard, make, control, z, TO, "MEUndo();" );
   bindCommand( keyboard, make, control, s, TO, "MESave();" );

   // 
   bindAction( keyboard,  make, control, TO, IDACTION_ME_MOD1, 1.0 );
   bindAction( keyboard, break, control, TO, IDACTION_ME_MOD1, 0.0 );
   bindAction( keyboard,  make, shift,   TO, IDACTION_ME_MOD2, 1.0 );
   bindAction( keyboard, break, shift,   TO, IDACTION_ME_MOD2, 0.0 );
   bindAction( keyboard,  make, alt,     TO, IDACTION_ME_MOD3, 1.0 );
   bindAction( keyboard, break, alt,     TO, IDACTION_ME_MOD3, 0.0 );

   //
   bindAction(mouse, xaxis, TO, IDACTION_YAW, scale, 0.002, flip);
   bindAction(mouse, yaxis, TO, IDACTION_PITCH, scale, 0.002, flip);

   // bookmark binds
   for( %i = 0; %i < 10; %i++ )
   {
      bindCommand( keyboard, make, control, %i, TO, "ME::PlaceBookmark(" @ %i @ ");");
      bindCommand( keyboard, make, alt, %i, TO, "ME::GotoBookmark(" @ %i @ ");");
   }

   // movement binds
   bindCommand( keyboard, make, 0, TO, "ME::Move(1024);");
   for( %i = 1; %i < 10; %i++ )
      bindCommand( keyboard, make, %i, TO, "ME::Move(" @ ( 1 << %i ) @ ");" );

   // toggle key for plane movement
   bindCommand( keyboard, make, capslock, TO, "METogglePlaneMovement();" );
}

