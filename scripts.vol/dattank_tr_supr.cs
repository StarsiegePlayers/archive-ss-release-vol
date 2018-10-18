######################################################################
#datTank_tr_supr.cs
#Terran suppressor
#
######################################################################
vehiclePilotable(false);
#
#
#                 Identity_Tag        Abbreviation    Shape             Mass            MaxMass                 RCS            Tech_Level   Combat_Value
tankBase(         IDVEH_TR_SUPR,      TRUPSR,         "tr_supr.dts",                5.0,                   60.0,           0.9,          2 ,         2000);

#                 maxPosAcc           minPosVel       maxForPosVel      maxRevPosVel    (all_m/s)
tankPos(                         20.0,            3.0,             30.0,           -25.5);

#                 minRotVel           maxRVSlow       maxRVFast         maxRVTurret     (all_deg/s)
tankRot(                          6.0,           75.0,             35.0,            75.0);

#                 offsetX             offsetY         offsetZ
tankCpit(         0.0,                0.0,                             0);

#                 sphOffstX           sphOffstY       sphOffstZ         sphereRad
tankColl(         0.0,                0.0,            5.9,                             6);

#                 TreadAnim_Rot_Coeff Tread_Anim_Pos_Coeff
tankAnim(         2.0,                0.25);

#                 engine_sound_tag    has_thrusters
tankSound(        IDSFX_TANK_ENGINE_3,      TRUE      );

#                 fireBayesNetName
tankAI(           "tankFire.ai",      "targetPart.ai","tankManeuver.ai","tankRetreat.ai");

#                 Hard                Points
#                 (sizes:SMLX         sides:TBLR)     Dmg               Offset_fm_Node  X_rot_rnge              Z_rot_rnge
#                 id                  size            side              Prnt            X___                    Y___           Z___         min__        max_  min__ max__
newHardPoint(     0,                  X,              T,                TankHead,       0.0,                    0.0,           0.0,         -25.0,       60.0, -60.0,60);
HardPointDamage(                  2000);

#                 id                  size            Dmg_Parent        Allowed_Mountables
newMountPoint(    0,                  L,              Body,             Engine);
newMountPoint(    1,                  M,              Body,             Reactor);
newMountPoint(    2,                  S,              TankHead,         Computer);
newMountPoint(    3,                  M,              none,             Armor);
newMountPoint(    4,                  L,              TankHead,         Sensors);
newMountPoint(    5,                  M,              TankHead,         ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                        LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack     );
newMountPoint(    6,                  L,              Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                        LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack     );
newMountPoint(    7,                  M,              Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                        LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack     );
#                 Internal            Components
#                 id                  type            parent            max_dmg         identity_tag
newComponent(     Armor,              Armor,          none,                       4500 ,IDCOM_ARMOR             );
newComponent(     LeftServos,         LeftServos,     none,                        500 ,IDCOM_LEFT_TREAD_SERVOS );
newComponent(     RightServos,        RightServos,    none,                        500 ,IDCOM_RIGHT_TREAD_SERVOS);

#                 External            Components
#                 id                  type            parent            max_dmg         identity_tag            total          interna               1000
newComponent(     Body,               Body,           none,                        250 ,IDCOM_BODY              );             #                     0.25
newComponent(     TankHead,           TankHead,       Body,                        250 ,IDCOM_HEAD              );             #                     0.25
newComponent(     CenterTread,        CenterTread,    Body,                        500 ,IDCOM_RIGHT_TREAD       );             #                     0.25
newComponent(     Pilot,              Pilot,          none,                        300 ,IDCOM_PILOT             );
#                                 1000               1

#                 Distribution        of              internal          components      among                   external       components
#                 containee           container       percent/100
newConfiguration( Armor,              Body,           0.2);             #                                    900
newConfiguration( Armor,              TankHead,       0.3);             #                                   1350
newConfiguration( Armor,              CenterTread,    0.5);             #                                   1125
#                 -----
#                                    1

newConfiguration( LeftServos,         CenterTread,    1);
newConfiguration( RightServos,        CenterTread,    1);

defaultWeapons(   127,                127);
defaultMountables(110,                202,            802,              928,            411,                    820,           831,         811);
à