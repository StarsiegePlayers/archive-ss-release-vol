######################################################################
# datTank_pi_drea.cs
# Pirate Dreadlock
#
######################################################################
vehiclePilotable(false);
#                 Identity_Tag        Abbreviation     Shape             Mass            MaxMass                  RCS            Tech_Level   Combat_Value
tankBase(         IDVEH_PI_DREA,      "DREA",          "pi_drea.dts",             14.00 ,                  45.00 ,         0.70 ,          1 ,         2215);

#                 maxPosAcc           minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
tankPos(                       25.00 ,           3.00 ,           30.00 ,          -25.50);

#                 minRotVel           maxRVSlow        maxRVFast         maxRVTurret     (all_deg/s)
tankRot(                        4.50 ,          90.00 ,           45.00 ,           50.00);

#                 offsetX             offsetY          offsetZ
tankCpit(         0.0,                0.0,                              0);

#                 sphOffstX           sphOffstY        sphOffstZ         sphereRad
tankColl(         0.0,                0.0,             2.9,                             3);

#                 TreadAnim_Rot_Coeff Tread_Anim_Pos_Coeff
tankAnim(         2.0,                             0.25);

#                 engine_sound_tag    has_thrusters
tankSound(        IDSFX_TANK_ENGINE_0,      TRUE       );

#                 fireBayesNetName
tankAI(           "tankFire.ai",       "targetPart.ai","tankManeuver.ai","tankRetreat.ai");

#                                     Hard Points
#                                     (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                       X_rot_rnge         Z_rot_rnge
#                 id                  size             side              Prnt            X___                     Y___           Z___         min__        max_  min__           max__
newHardPoint(     0,                  X,               T,                tankLeftPod,    -2.2,                    0.5,           0.75,        -25.0,       60.0, -60.0,          60);
HardPointDamage(                  2000);
newHardPoint(     1,                  X,               T,                tankRightPod,   2.2,                     0.5,           0.75,        -25.0,       60.0, -60.0,          60);
HardPointDamage(                  2000);
#                 id                  size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,                  L,               Body,             Engine);
newMountPoint(    1,                  L,               Body,             Reactor);
newMountPoint(    2,                  S,               TankHead,         Computer);
newMountPoint(    3,                  L,               none,             Armor);
newMountPoint(    4,                  S,               TankHead,         Sensors);
newMountPoint(    5,                  M,               TankHead,         ECM,            ThermalDiffuser,         LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,               AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
newMountPoint(    6,                  L,               Body,             ECM,            ThermalDiffuser,         LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,               AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
newMountPoint(    7,                  M,               Body,             ECM,            ThermalDiffuser,         LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,               AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
#                 Internal            Components
#                 id                  type             parent            max_dmg         identity_tag
newComponent(     Armor,              Armor,           none,                      22000 ,IDCOM_ARMOR              );
newComponent(     LeftServos,         LeftServos,      none,                        500 ,IDCOM_LEFT_TREAD_SERVOS  );
newComponent(     RightServos,        RightServos,     none,                        500 ,IDCOM_RIGHT_TREAD_SERVOS );

#                 External            Components
#                 id                  type             parent            max_dmg         identity_tag             total internals        12000
newComponent(     Body,               Body,            none,                       1680 ,IDCOM_BODY               );                    # 0.14
newComponent(     TankHead,           TankHead,        Body,                       1560 ,IDCOM_HEAD               );                    # 0.13
newComponent(     LeftTread,          LeftTread,       Body,                       1440 ,IDCOM_LEFT_TREAD         );                    # 0.12
newComponent(     RightTread,         RightTread,      Body,                       1440 ,IDCOM_RIGHT_TREAD        );                    # 0.12
newComponent(     tankLeftPod,        tankLeftPod,     TankHead,                   1440 ,IDCOM_LEFT_POD           );                    # 0.12
newComponent(     tankRightPod,       tankRightPod,    TankHead,                   1440 ,IDCOM_RIGHT_POD          );                    # 0.12
newComponent(     Bumper,             Bumper,          Body,                       3000 ,IDCOM_BUMPER             );                    # 0.25
newComponent(     Pilot,              Pilot,           none,                        300 ,IDCOM_PILOT              );
#                                                      (totals)                      9000                                                 1.00

#                 Distribution        of               internal          components      among                    external       components
#                 containee           container        percent/100
newConfiguration( Armor,              Body,                          0.15);                                 # 3300
newConfiguration( Armor,              TankHead,                      0.09);                                 # 1980
newConfiguration( Armor,              LeftTread,                     0.13);                                 # 2860
newConfiguration( Armor,              RightTread,                    0.13);                                 # 2860
newConfiguration( Armor,              tankLeftPod,                   0.10);                                 # 2200
newConfiguration( Armor,              tankRightPod,                  0.10);                                 # 2200
newConfiguration( Armor,              Bumper,                        0.30);                                 # 6600
#                 -----
#                                                                    1.00                                  # 22000

newConfiguration( LeftServos,         LeftTread,                     1.00);
newConfiguration( RightServos,        RightTread,                    1.00);

defaultWeapons(   108,                              108);
defaultMountables(108,                204,             801,              927,            400,                     865,           830,                   885);
h