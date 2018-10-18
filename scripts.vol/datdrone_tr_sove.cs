# SOVEREIGN

#          Identity_Tag         Abbreviation Shape               Mass  MaxMass  RCS   Tech_Level   Combat_Value
droneBase( IDVEH_TR_SOVE, "TRSOVE",    "tr_sove.dts", 5.00, 30.00 ,  0.85, 2 ,          1500);

#        maxPosAcc  minPosVel  maxForPosVel  maxRevPosVel       (all_m/s)
dronePos( 45.00,    3.00,      30.00 ,       -15.50);

#         minRotVel  maxRVSlow  maxRVFast  maxRVTurret        (all_deg/s)
droneRot( 6.00,      35.00,     25.00,     65.00);

#          sphOffstX  sphOffstY  sphOffstZ  sphereRad
droneColl( 0.0,       0.0,       8.9,       9);

#          TreadAnim_Rot_Coeff  Tread_Anim_Pos_Coeff
droneAnim( 2.0,                 0.25);

#          engine_sound_tag       has_thrusters
droneSound( IDSFX_TANK_ENGINE_1,  TRUE);

newMountPoint(0, M, Body, Engine);
newMountPoint(1, M, Body, Reactor);

#            Internal     Components
#            id           type          parent  max_dmg  identity_tag
newComponent(LeftServos,  LeftServos,   none,   300.0,   IDCOM_LEFT_TREAD_SERVOS );

#             External    Components
#             id          type        parent max_dmg  identity_tag
newComponent( Body,       Body,       none,  1000.0,  IDCOM_BODY);
newComponent( TankHead,   TankHead,   Body,  250 ,IDCOM_HEAD                  );                  # 0.25
newComponent( CenterTread,  CenterTread,  Body,  400.0,   IDCOM_LEFT_TREAD);
newComponent( TopPodA, TopPodA, Body,  400.0,   IDCOM_RIGHT_TREAD);


newConfiguration(LeftServos,  CenterTread,  1);

defaultMountables(101, 200);

droneExplosion(true, 15.0);
D