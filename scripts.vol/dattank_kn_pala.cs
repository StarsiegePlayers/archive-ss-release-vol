######################################################################
# datTank_kn_pala.cs
# Knight's Paladin
#
######################################################################

#                 Identity_Tag        Abbreviation     Shape             Mass            MaxMass                 RCS            Tech_Level   Combat_Value
tankBase(         IDVEH_KN_PALA,      "PALA",          "kn_pala.dts",             12.00 ,                 60.00 ,         0.90 ,          2 ,         2300);

#                 maxPosAcc           minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
tankPos(                       20.00 ,           3.00 ,           31.00 ,          -25.50);

#                 minRotVel           maxRVSlow        maxRVFast         maxRVTurret     (all_deg/s)
tankRot(                        6.00 ,          75.00 ,           35.00 ,           75.00);

#                 offsetX             offsetY          offsetZ
tankCpit(         0.0,                0.0,                              0);

#                 sphOffstX           sphOffstY        sphOffstZ         sphereRad
tankColl(         0.0,                0.0,             2.9,                             3);

#                 TreadAnim_Rot_Coeff Tread_Anim_Pos_Coeff
tankAnim(         2.0,                             0.25);

#                 engine_sound_tag    has_thrusters
tankSound(        IDSFX_TANK_ENGINE_2,      TRUE       );

#                 fireBayesNetName
tankAI(           "tankFire.ai",       "targetPart.ai","tankManeuver.ai","tankRetreat.ai");

#                                     Hard Points
#                                     (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                      X_rot_rnge         Z_rot_rnge
#                 id                  size             side              Prnt            X___                    Y___           Z___         min__        max_  min__           max__
newHardPoint(     0,                  L,               R,                TankHead,       1.6,                    0.0,           0.4,         -25.0,       60.0, -60.0,          60);
HardPointDamage(                  2000);
newHardPoint(     1,                  L,               L,                TankHead,       -1.6,                   0.0,           0.4,         -25.0,       60.0, -60.0,          60);
HardPointDamage(                  2000);

#                 id                  size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,                  L,               Body,             Engine);
newMountPoint(    1,                  M,               Body,             Reactor);
newMountPoint(    2,                  S,               TankHead,         Computer);
newMountPoint(    3,                  L,               none,             Armor);
newMountPoint(    4,                  L,               TankHead,         Sensors);
newMountPoint(    5,                  M,               TankHead,         ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
newMountPoint(    6,                  L,               Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
newMountPoint(    7,                  M,               Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
#                 Internal            Components
#                 id                  type             parent            max_dmg         identity_tag
newComponent(     Armor,              Armor,           none,                       6000 ,IDCOM_ARMOR             );
newComponent(     LeftServos,         LeftServos,      none,                        500 ,IDCOM_LEFT_TREAD_SERVOS );
newComponent(     RightServos,        RightServos,     none,                        500 ,IDCOM_RIGHT_TREAD_SERVOS);

#                 External            Components
#                 id                  type             parent            max_dmg         identity_tag            total internals         5000
newComponent(     Body,               Body,            none,                       1500 ,IDCOM_BODY              );                    # 0.30
newComponent(     TankHead,           TankHead,        Body,                       1000 ,IDCOM_HEAD              );                    # 0.20
newComponent(     LeftTread,          LeftTread,       Body,                       1250 ,IDCOM_LEFT_TREAD        );                    # 0.25
newComponent(     RightTread,         RightTread,      Body,                       1250 ,IDCOM_RIGHT_TREAD       );                    # 0.25
newComponent(     Pilot,              Pilot,           none,                        300 ,IDCOM_PILOT             );
#                                                                                    5000                                                1.00

#                 Distribution        of               internal          components      among                   external       components
#                 containee           container        percent/100
newConfiguration( Armor,              Body,                           0.3);                                # 1800
newConfiguration( Armor,              TankHead,                       0.2);                                # 1200
newConfiguration( Armor,              LeftTread,                     0.25);                                # 1500
newConfiguration( Armor,              RightTread,                    0.25);                                # 1500
#                 -----
#                                                                    1.00

newConfiguration( LeftServos,         LeftTread,                        1);
newConfiguration( RightServos,        RightTread,                       1);

defaultWeapons(   119,                              119);
defaultMountables(110,                201,             802,              928,            411,                    820,           811,                   885);
´