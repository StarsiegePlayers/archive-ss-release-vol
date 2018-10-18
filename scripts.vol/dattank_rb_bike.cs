######################################################################
# datTank_rb_bike
# Rebel Pouncer
#
######################################################################
vehiclePilotable(false);
#                 Identity_Tag        Abbreviation     Shape             Mass            MaxMass                 RCS            Tech_Level   Combat_Value
tankBase(         IDVEH_RB_PNCR,      "PCR-B",         "rb_bike.dts",              1.00 ,                 30.00 ,         0.55 ,          5 ,         1200);

#                 maxPosAcc           minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
tankPos(                       30.00 ,           3.00 ,           50.00 ,          -27.20);

#                 minRotVel           maxRVSlow        maxRVFast         maxRVTurret     (all_deg/s)
tankRot(                        6.00 ,          90.00 ,           55.00 ,           90.00);

#                 offsetX             offsetY          offsetZ
tankCpit(         0.0,                0.75,                             0);

#                 sphOffstX           sphOffstY        sphOffstZ         sphereRad
tankColl(         0.0,                0.0,             2.9,                             3);

#                 TreadAnim_Rot_Coeff Tread_Anim_Pos_Coeff
tankAnim(         2.0,                              0.5);

#                 engine_sound_tag    has_thrusters
tankSound(        IDSFX_TANK_ENGINE_1,      TRUE       );

#                 slide_coeff,                        1=                 no              slide                   (normal        tank),                   0=     pure            sl(hovercraft)
tankSlide(                         0.5);

#                 fireBayesNetName
tankAI(           "tankFire.ai",       "targetPart.ai","tankManeuver.ai","tankRetreat.ai");

#                                     Hard Points
#                                     (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                      X_rot_rnge         Z_rot_rnge
#                 id                  size             side              Prnt            X___                    Y___           Z___         min__        max_  min__           max__
newHardPoint(     0,                  X,               T,                TankHead,       0,                      0.0,           0,           -25.0,       45.0, -60.0,          60);
HardPointDamage(                  3000);
#newHardPoint(    1,                  M,               T,                TankHead,       1.5,                    -0.25,         0.75,        -25.0,       45.0, -60.0,          60);
#HardPointDamage(                 3000);

#                 id                  size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,                  L,               Body,             Engine);
newMountPoint(    1,                  L,               Body,             Reactor);
newMountPoint(    2,                  S,               TankHead,         Computer);
newMountPoint(    3,                  L,               none,             Armor);
newMountPoint(    4,                  M,               TankHead,         Sensors);
newMountPoint(    5,                  M,               TankHead,         ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
newMountPoint(    6,                  L,               Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
newMountPoint(    7,                  L,               Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                         LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack          );
#                 Internal            Components
#                 id                  type             parent            max_dmg         identity_tag
newComponent(     Armor,              Armor,           none,                       6000 ,IDCOM_ARMOR             );
newComponent(     LeftServos,         LeftServos,      none,                        500 ,IDCOM_LEFT_TREAD_SERVOS );
newComponent(     RightServos,        RightServos,     none,                        500 ,IDCOM_RIGHT_TREAD_SERVOS);

#                 External            Components
#                 id                  type             parent            max_dmg         identity_tag            total internals         3000
newComponent(     Body,               Body,            none,                        750 ,IDCOM_BODY              );                    # 0.25
newComponent(     TankHead,           TankHead,        Body,                        750 ,IDCOM_HEAD              );                    # 0.25
newComponent(     LeftTread,          LeftTread,       Body,                        750 ,IDCOM_LEFT_TREAD        );                    # 0.25
newComponent(     RightTread,         RightTread,      Body,                        750 ,IDCOM_RIGHT_TREAD       );                    # 0.25
newComponent(     Pilot,              Pilot,           none,                        300 ,IDCOM_PILOT             );
#                                                      (totals)                      3000                                                1.00

#                 Distribution        of               internal          components      among                   external       components
#                 containee           container        percent/100
newConfiguration( Armor,              Body,                          0.25);                                # 1500
newConfiguration( Armor,              TankHead,                      0.25);                                # 1500
newConfiguration( Armor,              LeftTread,                     0.25);                                # 1500
newConfiguration( Armor,              RightTread,                    0.25);                                # 1500
#                 -----
#                                                                    1.00

newConfiguration( LeftServos,         LeftTread,                     1.00);
newConfiguration( RightServos,        RightTread,                    1.00);

defaultWeapons(                    120                 );
defaultMountables(102,                200,             801,              926,            410,                    880,           810,                   830);
J