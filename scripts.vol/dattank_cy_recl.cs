######################################################################
# datTank_cy_recl.cs
# Cybrid Recluse
#
######################################################################

#                 Identity_Tag        Abbreviation     Shape             Mass            MaxMass                 RCS            Tech_Level   Combat_Value
tankBase(         IDVEH_CY_RECL,      "RECL",          "cy_recl.dts",              8.00 ,                 40.00 ,         0.65 ,          2 ,    1720);

#                 maxPosAcc           minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
tankPos(                       20.00 ,           3.00 ,           32.00 ,          -27.20);

#                 minRotVel           maxRVSlow        maxRVFast         maxRVTurret     (all_deg/s)
tankRot(                        2.00 ,          75.00 ,           35.00 ,           45.00);

#                 offsetX             offsetY          offsetZ
tankCpit(         0.0,                0.5,                              0);

#                 sphOffstX           sphOffstY        sphOffstZ         sphereRad
tankColl(         0.0,                0.0,             2.9,                             3);

#                 TreadAnim_Rot_Coeff Tread_Anim_Pos_Coeff
tankAnim(         2.0,                              0.5);

#                 engine_sound_tag    has_thrusters
tankSound(        IDSFX_TANK_ENGINE_1,      TRUE       );

#                 fireBayesNetName
tankAI(           "tankFire.ai",       "targetPart.ai","tankManeuver.ai","tankRetreat.ai");

#                                     Hard Points
#                                     (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                      X_rot_rnge    Z_rot_rnge
#                 id                  size             side              Prnt            X___                    Y___           Z___         min__   max_  min__           max__
newHardPoint(     0,                  M,               T,                TopPodA,        0.0,                    -2.0,          1.2,         -25.0,  60.0, -60.0,          60);
HardPointDamage(                  3000);
newHardPoint(     1,                  L,               R,                TopPodA,        1.0,                   1.0,           0.0,         -15.0,  40.0 ,-60.0,          60);
newHardPoint(     2,                  L,               L,                TopPodA,        -1.0,                  1.0,           0.0,         -15.0,  40.0 ,-60.0,          60);

#                 id                  size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,                  M,               Body,             Engine);
newMountPoint(    1,                  M,               Body,             Reactor);
newMountPoint(    2,                  S,               TankHead,         Computer);
newMountPoint(    3,                  L,               none,             Armor);
newMountPoint(    4,                  S,               TankHead,         Sensors);
newMountPoint(    5,                  M,               TankHead,         ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,ammoPack          );
newMountPoint(    6,                  M,               Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,ammoPack          );
newMountPoint(    7,                  L,               Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,ammoPack          );
#                 Internal            Components
#                 id                  type             parent            max_dmg         identity_tag
newComponent(     Armor,              Armor,           none,                       8000 ,IDCOM_ARMOR             );
newComponent(     LeftServos,         LeftServos,      none,                        500 ,IDCOM_LEFT_TREAD_SERVOS );
newComponent(     RightServos,        RightServos,     none,                        500 ,IDCOM_RIGHT_TREAD_SERVOS);

#                 External            Components
#                 id                  type             parent            max_dmg         identity_tag            total interals          6000
newComponent(     Body,               Body,            none,                       1200 ,IDCOM_BODY              );                    # 0.20
newComponent(     TankHead,           TankHead,        Body,                       1200 ,IDCOM_HEAD              );                    # 0.20
newComponent(     TopPodA,            TopPodA,         TankHead,                   1200 ,IDCOM_HEAD              );                    # 0.20
newComponent(     LeftTread,          LeftTread,       Body,                       1200 ,IDCOM_LEFT_TREAD        );                    # 0.20
newComponent(     RightTread,         RightTread,      Body,                       1200 ,IDCOM_RIGHT_TREAD       );                    # 0.20
newComponent(     Pilot,              Pilot,           none,                        300 ,IDCOM_PILOT             );
#                                     (totals)                                       6000

#                 Distribution        of               internal          components      among                   external       components
#                 containee           container        percent/100
newConfiguration( Armor,              Body,                           0.2);                                # 1600
newConfiguration( Armor,              TopPodA,                        0.2);                                # 1600
newConfiguration( Armor,              TankHead,                       0.2);                                # 1600
newConfiguration( Armor,              LeftTread,                      0.2);                                # 1600
newConfiguration( Armor,              RightTread,                     0.2);                                # 1600
#                 -----
#                                                                    1.00

newConfiguration( LeftServos,         LeftTread,                     1.00);
newConfiguration( RightServos,        RightTread,                    1.00);

defaultWeapons(   104,                133,                            133);
defaultMountables(133,                225,             806,              927,            426,                    812,           830,              885);
Û