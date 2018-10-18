# JAMMA

#          Identity_Tag         Abbreviation Shape               Mass  MaxMass  RCS   Tech_Level   Combat_Value
droneBase( IDVEH_CY_JAMM, "CYJAMM",    "cy_jamm.dts", 5.00, 30.00 ,  0.85, 2 ,          1500);

#        maxPosAcc  minPosVel  maxForPosVel  maxRevPosVel       (all_m/s)
dronePos( 15.00,    3.00,      30.00 ,       -15.50);

#         minRotVel  maxRVSlow  maxRVFast  maxRVTurret        (all_deg/s)
droneRot( 6.00,      35.00,     25.00,     65.00);

#          sphOffstX  sphOffstY  sphOffstZ  sphereRad
droneColl( 0.0,       0.0,       2.9,       16);

#          TreadAnim_Rot_Coeff  Tread_Anim_Pos_Coeff
droneAnim( 2.0,                 0.25);

#          engine_sound_tag       has_thrusters
droneSound( IDSFX_TANK_ENGINE_1,  TRUE);

newMountPoint(0, M, Body, Engine);
newMountPoint(1, M, Body, Reactor);

#            Internal     Components
#            id           type          parent  max_dmg  identity_tag
newComponent(LeftServos,  LeftServos,   none,   300.0,   IDCOM_LEFT_TREAD_SERVOS );
newComponent(RightServos, RightServos,  none,   300.0,   IDCOM_RIGHT_TREAD_SERVOS);

#             External    Components
#             id          type        parent max_dmg  identity_tag
newComponent( Body,       Body,       none,  3000.0,  IDCOM_BODY);
newComponent( LeftTread,  LeftTread,  Body,  900.0,   IDCOM_LEFT_TREAD);
newComponent( RightTread, RightTread, Body,  900.0,   IDCOM_RIGHT_TREAD);
newComponent( tankLeftPod,  tankLeftPod,  Body,  900.0,   IDCOM_LEFT_POD);
newComponent( tankRightPod, tankRightPod, Body,  900.0,   IDCOM_RIGHT_POD);



newConfiguration(LeftServos,  LeftTread,  1);
newConfiguration(RightServos, RightTread, 1);

defaultMountables(101, 200);

droneExplosion(true, 10.0);
y