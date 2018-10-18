# OMNI CRAWLER

droneBase( IDVEH_CY_OMNI, "CYOMNI",    "cy_omni.dts", 10.00, 90.00 ,  2.00, 10 ,          1500);

#        maxPosAcc  minPosVel  maxForPosVel  maxRevPosVel       (all_m/s)
dronePos( 25.00,    3.00,      30.00 ,       -25.50);

#         minRotVel  maxRVSlow  maxRVFast  maxRVTurret        (all_deg/s)
droneRot( 6.00,      35.00,     25.00,     65.00);

#          sphOffstX  sphOffstY  sphOffstZ  sphereRad
droneColl( 0.0,       0.0,       2.9,       35);

#          TreadAnim_Rot_Coeff  Tread_Anim_Pos_Coeff
droneAnim( 2.0,                 0.25);

#          engine_sound_tag       has_thrusters
droneSound( IDSFX_TANK_ENGINE_1,  TRUE);

newMountPoint(0, X, Body, Engine);
newMountPoint(1, X, Body, Reactor);
newMountPoint(2, L, none, Armor);

#            Internal     Components
#            id           type          parent  max_dmg  identity_tag
newComponent(LeftServos,  LeftServos,   none,   12000.0,   IDCOM_LEFT_TREAD_SERVOS );
newComponent(RightServos, RightServos,  none,   12000.0,   IDCOM_RIGHT_TREAD_SERVOS);

#             External    Components
#             id          type        parent max_dmg  identity_tag
newComponent( Body,       Body,       none, 30000.0,  IDCOM_BODY);
newComponent( LeftLegA,   LeftLegA,   none, 20000.0,  IDCOM_LEFT_TREAD);
newComponent( LeftLegB,   LeftLegC,   none, 20000.0,  IDCOM_LEFT_TREAD);
newComponent( LeftLegC,   LeftLegB,   none, 20000.0,  IDCOM_LEFT_TREAD);
newComponent( RightLegA,  RightLegA,  none, 20000.0,  IDCOM_RIGHT_TREAD);
newComponent( RightLegB,  RightLegC,  none, 20000.0,  IDCOM_RIGHT_TREAD);
newComponent( RightLegC,  RightLegB,  none, 20000.0,  IDCOM_RIGHT_TREAD);
newComponent( Armor,      Armor,      none, 90000 ,   IDCOM_ARMOR);


# Armor Components
#                                          
newConfiguration(    Armor,                 Body,                                0.40);                                       # 3500
newConfiguration(    Armor,                 LeftLegA,                            0.10);                                       # 2500
newConfiguration(    Armor,                 LeftLegB,                            0.10);                                       # 2000
newConfiguration(    Armor,                 LeftLegC,                            0.10); 
newConfiguration(    Armor,                 RightLegA,                           0.10); 
newConfiguration(    Armor,                 RightLegB,                           0.10); 
newConfiguration(    Armor,                 RightLegC,                           0.10); 
#                                                                                1.0



newConfiguration(LeftServos,  LeftLegA,  0.34);
newConfiguration(LeftServos,  LeftLegB,  0.33);
newConfiguration(LeftServos,  LeftLegC,  0.33);
newConfiguration(RightServos, RightLegA, 0.34);
newConfiguration(RightServos, RightLegB, 0.33);
newConfiguration(RightServos, RightLegC, 0.33);

defaultMountables(143, 230,927);
y5