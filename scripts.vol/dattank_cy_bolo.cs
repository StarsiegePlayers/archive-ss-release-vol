######################################################################
# datTank_cy_bolo.cs
# Cybrid Bolo
#
######################################################################

#                    Identity_Tag           Abbreviation          Shape             Mass               MaxMass                     RCS              Tech_Level   Combat_Value
tankBase(            IDVEH_CY_BOLO,         "BOLO",               "cy_bolo.dts",                 7.00 ,                     35.00 ,           0.55 ,          1 ,         1470);

#                    maxPosAcc              minPosVel             maxForPosVel      maxRevPosVel       (all_m/s)
tankPos(                             25.00 ,                3.00 ,           38.00 ,             -32.30);

#                    minRotVel              maxRVSlow             maxRVFast         maxRVTurret        (all_deg/s)
tankRot(                              5.00 ,               82.50 ,           45.00 ,              90.00);

#                    offsetX                offsetY               offsetZ
tankCpit(            0.0,                   0.0,                                   0);

#                    sphOffstX              sphOffstY             sphOffstZ         sphereRad
tankColl(            0.0,                   0.0,                  2.9,                                3);

#                    TreadAnim_Rot_Coeff    Tread_Anim_Pos_Coeff
tankAnim(            2.0,                                      0.5);

#                    engine_sound_tag       has_thrusters
tankSound(           IDSFX_TANK_ENGINE_1,            TRUE         );

#                    fireBayesNetName
tankAI(              "tankFire.ai",          "targetPart.ai",     "tankManeuver.ai","tankRetreat.ai"   );

#                                           Hard Points
#                                           (sizes:SMLX           sides:TBLR)       Dmg                Offset_fm_Node                                            X_rot_rnge              Z_rot_rnge
#                    id                     size                  side              Prnt               X___                        Y___             Z___         min__        max_       min__ max__
newHardPoint(        0,                     M,                    L,                TankHead,          -1.0,                       -0.3,            0.0,         -15.0,       60.0,      -60.0,    60);
HardPointDamage(                        2500);
newHardPoint(        1,                     M,                    R,                TankHead,          1.0,                        -0.3,            0.0,         -15.0,       60.0,      -60.0,    60);
HardPointDamage(                        2500);

#                    id                     size                  Dmg_Parent        Allowed_Mountables
newMountPoint(       0,                     M,                    Body,             Engine);
newMountPoint(       1,                     L,                    Body,             Reactor);
newMountPoint(       2,                     S,                    TankHead,         Computer);
newMountPoint(       3,                     L,                    none,             Armor);
newMountPoint(       4,                     S,                    TankHead,         Sensors);
newMountPoint(       5,                     S,                    TankHead,         ECM,               ThermalDiffuser,            LaserTargeting,  NanoRepair,  Battery,     Cloak,     FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,  TurbineBoost,RocketBooster,          ammoPack    );
newMountPoint(       6,                     L,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,  NanoRepair,  Battery,     Cloak,     FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,  TurbineBoost,RocketBooster,          ammoPack    );
newMountPoint(       7,                     M,                    Body,             ECM,               ThermalDiffuser,            LaserTargeting,  NanoRepair,  Battery,     Cloak,     FieldStabilizer,
                                                                                    LifeSupport,       Capacitor,                  AgravGenerator,  TurbineBoost,RocketBooster,          ammoPack    );
#                    Internal               Components
#                    id                     type                  parent            max_dmg            identity_tag
newComponent(        Armor,                 Armor,                none,                          7000 ,IDCOM_ARMOR                 );
newComponent(        LeftServos,            LeftServos,           none,                           200 ,IDCOM_LEFT_TREAD_SERVOS     );
newComponent(        RightServos,           RightServos,          none,                           200 ,IDCOM_RIGHT_TREAD_SERVOS    );

#                    External               Components
#                    id                     type                  parent            max_dmg            identity_tag                total internals=          5000
newComponent(        Body,                  Body,                 none,                          1250 ,IDCOM_BODY                  );                      # 0.25
newComponent(        TankHead,              TankHead,             Body,                           750 ,IDCOM_HEAD                  );                      # 0.15
newComponent(        LeftTread,             LeftTread,            Body,                          1000 ,IDCOM_LEFT_TREAD            );                      # 0.20
newComponent(        RightTread,            RightTread,           Body,                          1000 ,IDCOM_RIGHT_TREAD           );                      # 0.20
newComponent(        RearTread,             RearTread,            Body,                          1000 ,IDCOM_REAR_TREAD            );                      # 0.20
newComponent(        Pilot,                 Pilot,                none,                           300 ,IDCOM_PILOT                 );
#                                                                 (totals)                         5000                                                      1.00

#                    Distribution           of                    internal          components         among                       external         components
#                    containee              container             percent/100
newConfiguration(    Armor,                 Body,                               0.25);                                       # 1750
newConfiguration(    Armor,                 TankHead,                           0.15);                                       # 1050
newConfiguration(    Armor,                 LeftTread,                          0.20);                                       # 1400
newConfiguration(    Armor,                 RightTread,                         0.20);                                       # 1400
newConfiguration(    Armor,                 RearTread,                          0.20);                                       # 1400
#                    -----
#                                                                               1.00

newConfiguration(    LeftServos,            LeftTread,                          1.00);
newConfiguration(    RightServos,           RightTread,                         1.00);

defaultWeapons(      111,                                      111);
defaultMountables(   133,                   230,                  806,              927,               428,                        865,             830,                   885);
Þ