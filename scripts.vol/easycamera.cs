#------------------------------------------------------------------------------
#	Easy Camera controls
#------------------------------------------------------------------------------
newActionMap( Camera );

#------- Joystick Controls
bindAction( joystick0, zaxis, TO, IDACTION_SPEED, deadzone, 0.1, center, square );
bindAction( joystick0, xaxis, TO, IDACTION_ROLL, deadzone, 0.1, center, square, flip );
bindAction( joystick0, yaxis, TO, IDACTION_PITCH, deadzone, 0.1, center, square, flip );
bindAction( joystick0, rzaxis, TO, IDACTION_YAW, deadzone, 0.1, center, square );
bindAction( joystick0, make, button0, TO, IDACTION_STOP );
bindAction( joystick0, make, button1, TO, IDACTION_TURBO );

#------- Keyboard Controls
bindAction( keyboard, make, a, TO, IDACTION_MOVE_X, -1.0 );
bindAction( keyboard, make, d, TO, IDACTION_MOVE_X, "+1.0" );
bindAction( keyboard, break, d, TO, IDACTION_MOVE_X, 0.0 );
bindAction( keyboard, break, a, TO, IDACTION_MOVE_X, 0.0 );

bindAction( keyboard, make, w, TO, IDACTION_MOVE_Z, "+1.0" );
bindAction( keyboard, make, s, TO, IDACTION_MOVE_Z, -1.0 );
bindAction( keyboard, break, w, TO, IDACTION_MOVE_Z, 0.0 );
bindAction( keyboard, break, s, TO, IDACTION_MOVE_Z, 0.0 );
t