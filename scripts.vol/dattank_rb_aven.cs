######################################################################
# datTank_rb_aven.cs
# Rebel Avenger
#
######################################################################

#                    Identity_Tag           Abbreviation          Shape             Mass               MaxMass                     RCS            Tech_Level   Combat_Value
tankBase(            IDVEH_RB_AVEN,         "AVEN",               "rb_aven.dts",                 3.00 ,                     30.00 ,         0.60 ,          2 ,         1830);

#                    maxPosAcc              minPosVel             maxForPosVel      maxRevPosVel       (all_m/s)
tankPos(                             25.00 ,                3.00 ,           30.00 ,             -25.50);

#                    minRotVel              maxRVSlow             maxRVFast         maxRVTurret        (all_deg/s)
tankRot(                              6.00 ,               75.00 ,           45.00 ,              65.00);

#                    offsetX                offsetY               offsetZ
tankCpit(            0.0,                   0.0,                                   0);

#                    sphOffstX              sphOffstY             sphOffstZ         sphereRad
tankColl(            0.0,                   0.0,                  2.9,                                3);

#                    TreadAnim_Rot_Coeff    Tread_Anim_Pos_Coeff
tankAnim(            2.0,                                     0.25);

#                    engine_sound_tag       has_thrusters
tankSound(           IDSFX_TANK_ENGINE_0,            TRUE         );

#                    fireBayesNetName
tankAI(              "tankFire.ai",          "targetPart.ai",     "tankManeuver.ai","tankRetreat.ai"   );

#                                           Hard Points
#                                           (sizes:SMLX           sides:TBLR)       Dmg                Offset_fm_Node                                          X_rot_rnge         Z_rot_rnge
#                    id                     size                  side              Prnt               X___                        Y___           Z___         min__        max_  min__           max__
newHardPoint(        0,                     L,                    T,                TankHead,          -1.0,                       0.0,           1.5,         -25.0,       60.0, -60.0,              60);
HardPointDamage(                        2000);
newHardPoint(        1,                     L,                    T,                TankHead,          1.0,                        0.0,           1.5,         -25.0,       60.0, -60.0,              60);
HardPointDamage(                        2000);

#                    id                     size                  Dmg_Parent        Allowed_Mountables
newMountPoint(       0,                     S,                    Body,             Engine);
newMountPoint(       1,                     L,                    Body,             Reactor);
newMountPoint(       2,                     S,                    TankHead,         Computer);
newMountPoint(       3,                     L,                    none,             Armor);
newMountPoint(       4,                     S,                    TankHead,         Sensors);
newMountPoint(       5,                     M,                    TankHead,         ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,     ammoPack              );
newMountPoint(       6,                     L,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,     ammoPack              );
newMountPoint(       7,                     M,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,TurbineBoost,RocketBooster,     ammoPack              );
#                    Internal               Components
#                    id                     type                  parent            max_dmg            identity_tag
newComponent(        Armor,                 Armor,                none,                         13000 ,IDCOM_ARMOR                 );
newComponent(        LeftServos,            LeftServos,           none,                           500 ,IDCOM_LEFT_TREAD_SERVOS     );
newComponent(        RightServos,           RightServos,          none,                           500 ,IDCOM_RIGHT_TREAD_SERVOS    );

#                    External               Components
#                    id                     type                  parent            max_dmg            identity_tag                total internals         8000
newComponent(        Body,                  Body,                 none,                          1520 ,IDCOM_BODY                  );                    # 0.19
newComponent(        TankHead,              TankHead,             Body,                          1120 ,IDCOM_HEAD                  );                    # 0.14
newComponent(        LeftTread,             LeftTread,            Body,                          1280 ,IDCOM_LEFT_TREAD            );                    # 0.16
newComponent(        RightTread,            RightTread,           Body,                          1280 ,IDCOM_RIGHT_TREAD           );                    # 0.16
newComponent(        Bumper,                Bumper,               Body,                          2800 ,IDCOM_BUMPER                );                    # 0.35
newComponent(        Pilot,                 Pilot,                none,                           300 ,IDCOM_PILOT                 );
#                                                                 (totals)                         8000                                                  # 1.00

#                    Distribution           of                    internal          components         among                       external       components
#                    containee              container             percent/100
newConfiguration(    Armor,                 Body,                               0.19);                                       # 2470
newConfiguration(    Armor,                 TankHead,                           0.14);                                       # 1820
newConfiguration(    Armor,                 LeftTread,                          0.16);                                       # 2080
newConfiguration(    Armor,                 RightTread,                         0.16);                                       # 2080
newConfiguration(    Armor,                 Bumper,                             0.35);                                       # 4550
#                    -----
#                                                                               1.00                                        # 13000

newConfiguration(    LeftServos,            LeftTread,                             1);
newConfiguration(    RightServos,           RightTread,                            1);

defaultWeapons(      106,                                      106);
defaultMountables(   101,                   202,                  801,              927 ,              400,                        885,           811,                   865);
X