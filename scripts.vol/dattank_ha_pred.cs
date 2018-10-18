######################################################################
# datTank_ha_pred.cs
# Harabec's Predator
#
######################################################################
#vehiclePilotable(false);
#                    Identity_Tag           Abbreviation          Shape             Mass               MaxMass                     RCS            Tech_Level   Combat_Value
tankBase(            IDVEH_HA_PRED,         "PRED",               "ha_pred.dts",                18.00 ,                     60.00 ,         0.50 ,          5 ,         3510);

#                    maxPosAcc              minPosVel             maxForPosVel      maxRevPosVel       (all_m/s)
tankPos(                             30.00 ,                3.00 ,           36.00 ,             -30.60);

#                    minRotVel              maxRVSlow             maxRVFast         maxRVTurret        (all_deg/s)
tankRot(                              6.00 ,               90.00 ,           55.00 ,              90.00);

#                    offsetX                offsetY               offsetZ
tankCpit(            0.0,                   0.0,                                   0);

#                    sphOffstX              sphOffstY             sphOffstZ         sphereRad
tankColl(            0.0,                   0.0,                  2.9,                                3);

#                    TreadAnim_Rot_Coeff    Tread_Anim_Pos_Coeff
tankAnim(            2.0,                                      0.5);

#                    engine_sound_tag       has_thrusters
tankSound(           IDSFX_TANK_ENGINE_4,            TRUE         );

#                    slide_coeff,                                1=                 no                 slide                       (normal        tank),                   0=     pure            slide (hovercraft)
tankSlide(                               0.5);

#                    fireBayesNetName
tankAI(              "tankFire.ai",          "targetPart.ai",     "tankManeuver.ai","tankRetreat.ai"   );

#                                           Hard Points
#                                           (sizes:SMLX           sides:TBLR)       Dmg                Offset_fm_Node                                          X_rot_rnge         Z_rot_rnge
#                    id                     size                  side              Prnt               X___                        Y___           Z___         min__        max_  min__           max__
newHardPoint(        0,                     L,                    T,                TankHead,          -1.5,                       -0.25,         0.75,        -25.0,       45.0, -60.0,              60);
HardPointDamage(                        2000);
newHardPoint(        1,                     L,                    T,                TankHead,          1.5,                        -0.25,         0.75,        -25.0,       45.0, -60.0,              60);
HardPointDamage(                        2000);

#                    id                     size                  Dmg_Parent        Allowed_Mountables
newMountPoint(       0,                     L,                    Body,             Engine);
newMountPoint(       1,                     L,                    Body,             Reactor);
newMountPoint(       2,                     S,                    TankHead,         Computer);
newMountPoint(       3,                     L,                    none,             Armor);
newMountPoint(       4,                     M,                    TankHead,         Sensors);
newMountPoint(       5,                     M,                    TankHead,         ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,     ammoPack              );
newMountPoint(       6,                     L,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,     ammoPack              );
newMountPoint(       7,                     L,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,     ammoPack              );
#                    Internal               Components
#                    id                     type                  parent            max_dmg            identity_tag
newComponent(        Armor,                 Armor,                none,                          9000 ,IDCOM_ARMOR                 );
newComponent(        LeftServos,            LeftServos,           none,                           500 ,IDCOM_LEFT_TREAD_SERVOS     );
newComponent(        RightServos,           RightServos,          none,                           500 ,IDCOM_RIGHT_TREAD_SERVOS    );

#                    External               Components
#                    id                     type                  parent            max_dmg            identity_tag                total internals         6000
newComponent(        Body,                  Body,                 none,                          1560 ,IDCOM_BODY                  );                    # 0.26
newComponent(        TankHead,              TankHead,             Body,                          1200 ,IDCOM_HEAD                  );                    # 0.20
newComponent(        LeftTread,             LeftTread,            Body,                          1620 ,IDCOM_LEFT_TREAD            );                    # 0.27
newComponent(        RightTread,            RightTread,           Body,                          1620 ,IDCOM_RIGHT_TREAD           );                    # 0.27
newComponent(        Pilot,                 Pilot,                none,                           300 ,IDCOM_PILOT                 );
#                                                                 (totals)                         6000                                                    1.00

#                    Distribution           of                    internal          components         among                       external       components
#                    containee              container             percent/100
newConfiguration(    Armor,                 Body,                               0.26);                                       # 2340
newConfiguration(    Armor,                 TankHead,                           0.20);                                       # 1800
newConfiguration(    Armor,                 LeftTread,                          0.27);                                       # 2430
newConfiguration(    Armor,                 RightTread,                         0.27);                                       # 2430
#                    -----
#                                                                               1.00

newConfiguration(    LeftServos,            LeftTread,                          1.00);
newConfiguration(    RightServos,           RightTread,                         1.00);

defaultWeapons(      108,                                      108);
defaultMountables(   110,                   204,                  802,              928,               413,                        820,           811,                   831);

