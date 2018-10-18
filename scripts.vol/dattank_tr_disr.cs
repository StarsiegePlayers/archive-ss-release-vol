######################################################################
# datTank_tr_disr.cs
# Terran Disrupter
#
######################################################################

#                    Identity_Tag           Abbreviation          Shape             Mass               MaxMass                     RCS            Tech_Level   Combat_Value
tankBase(            IDVEH_TR_DISR,         "DISR",               "tr_disr.dts",                20.00 ,                     55.00 ,         0.85 ,          3 ,          2700);

#                    maxPosAcc              minPosVel             maxForPosVel      maxRevPosVel       (all_m/s)
tankPos(                             25.00 ,                3.00 ,           32.50 ,             -27.63);

#                    minRotVel              maxRVSlow             maxRVFast         maxRVTurret        (all_deg/s)
tankRot(                              6.00 ,               75.00 ,           45.00 ,              50.00);

#                    offsetX                offsetY               offsetZ
tankCpit(            0.0,                   0.15,                 -0.3              );

#                    sphOffstX              sphOffstY             sphOffstZ         sphereRad
tankColl(            0.0,                   0.0,                  2.9,                                3);

#                    TreadAnim_Rot_Coeff    Tread_Anim_Pos_Coeff
tankAnim(            2.0,                                     0.25);

#                    engine_sound_tag       has_thrusters
tankSound(           IDSFX_TANK_ENGINE_4,            TRUE         );

#                    fireBayesNetName
tankAI(              "tankFire.ai",          "targetPart.ai",     "tankManeuver.ai","tankRetreat.ai"   );

#                                           Hard Points
#                                           (sizes:SMLX           sides:TBLR)       Dmg                Offset_fm_Node                                          X_rot_rnge          Z_rot_rnge
#                    id                     size                  side              Prnt               X___                        Y___           Z___         min__         max_  min__           max__
newHardPoint(        0,                     L,                    R,                TankHead,          0.6,                        -0.1,          0.25,        -10.0,        60.0, -60.0,              60);
HardPointDamage(                        3000);
hardPointSpecial(                          3);
#newHardPoint(       1,                     S,                    L,                TankHead,          -0.6,                       0.15,          0.25,        -25.0,        60.0, -60.0,              60);
#HardPointDamage(                        500);
#newHardPoint(       1,                     S,                    T,                TankHead,          0.0,                        -0.75,         1.0,         -25.0,        60.0, -60.0,              60);
#                    id                     size                  Dmg_Parent        Allowed_Mountables
newMountPoint(       0,                     L,                    Body,             Engine);
newMountPoint(       1,                     L,                    Body,             Reactor);
newMountPoint(       2,                     S,                    TankHead,         Computer);
newMountPoint(       3,                     L,                    none,             Armor);
newMountPoint(       4,                     S,                    TankHead,         Sensors);
newMountPoint(       5,                     M,                    TankHead,         ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,      Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,      ammoPack              );
newMountPoint(       6,                     L,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,      Cloak,FieldStabilizer,ammoPack,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,      ElectroHull           );
newMountPoint(       7,                     L,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,      Cloak,FieldStabilizer,ammoPack,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,      ElectroHull           );
#                    Internal               Components
#                    id                     type                  parent            max_dmg            identity_tag
newComponent(        Armor,                 Armor,                none,                          7500 ,IDCOM_ARMOR                 );
newComponent(        LeftServos,            LeftServos,           none,                           500 ,IDCOM_LEFT_TREAD_SERVOS     );
newComponent(        RightServos,           RightServos,          none,                           500 ,IDCOM_RIGHT_TREAD_SERVOS    );

#                    External               Components
#                    id                     type                  parent            max_dmg            identity_tag                total internals         5000
newComponent(        Body,                  Body,                 none,                          1500 ,IDCOM_BODY                  );                    # 0.30
newComponent(        TankHead,              TankHead,             Body,                           500 ,IDCOM_HEAD                  );                    # 0.10
newComponent(        LeftTread,             LeftTread,            Body,                          1500 ,IDCOM_LEFT_TREAD            );                    # 0.30
newComponent(        RightTread,            RightTread,           Body,                          1500 ,IDCOM_RIGHT_TREAD           );                    # 0.30
newComponent(        Pilot,                 Pilot,                none,                           300 ,IDCOM_PILOT                 );
                     #                                                                             5000                                                  # 1.00

#                    Distribution           of                    internal          components         among                       external       components
#                    containee              container             percent/100
newConfiguration(    Armor,                 Body,                                0.3);                                    # 2250.00
newConfiguration(    Armor,                 TankHead,                            0.1);                                     # 750.00
newConfiguration(    Armor,                 LeftTread,                           0.3);                                    # 2250.00
newConfiguration(    Armor,                 RightTread,                          0.3);                                    # 2250.00
#                    -----
#                                                                               1.00

newConfiguration(    LeftServos,            LeftTread,                             1);
newConfiguration(    RightServos,           RightTread,                            1);

defaultWeapons(                            3                      );
defaultMountables(   109,                   204,                  801,              928,               400,                        810,           912,                    885);

