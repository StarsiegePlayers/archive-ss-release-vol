######################################################################
# datTank_rb_artl.cs
# Rebel Artillery (non pilotable)
#
######################################################################
vehiclePilotable(false);
vehicleArtillery(true);
#
#                 Identity_Tag         Abbreviation      Shape             Mass            MaxMass                 RCS            Tech_Level   Combat_Value
tankBase(         IDVEH_RB_ARTL,       RBARTL,           "rb_artl.dts",              20.0 ,90.0 ,                  0.95 ,         4 ,                   3000);

#                 maxPosAcc            minPosVel         maxForPosVel      maxRevPosVel    (all_m/s)
tankPos(          15.00 ,              3.00 ,            27.00 ,                     -22.95);

#                 minRotVel            maxRVSlow         maxRVFast         maxRVTurret     (all_deg/s)
tankRot(          3.00 ,               55.00 ,           25.00 ,                      10.00);

#                 offsetX              offsetY           offsetZ
tankCpit(         0.0,                 0.0,                             0.0);

#                 sphOffstX            sphOffstY         sphOffstZ         sphereRad
tankColl(         0.0,                 0.0,              6.9,                             7);

#                 TreadAnim_Rot_Coeff  Tread_Anim_Pos_Coeff
tankAnim(         2.0,                                0.5);

#                 engine_sound_tag     has_thrusters
tankSound(        IDSFX_TANK_ENGINE_3,        TRUE       );

#                 fireBayesNetName
tankAI(           "tankFire.ai",       "targetPart.ai",  "tankManeuver.ai","tankRetreat.ai");

#                 Hard Points
#                 (sizes:SMLX          sides:TBLR)       Dmg               Offset_fm_Node  X_rot_rnge              Z_rot_rnge
#                 id                   size              side              Prnt            X___                    Y___           Z___         min__        max_  min__  max__
newHardPoint(     0 ,                  X,                T,                TankHead,       1.739,                  2.09,          1.801,       -25.0,       89.0, -60.0, 60);
HardPointDamage(                    800);
HardPointSpecial(                    21);



#                 id                   size              Dmg_Parent        Allowed_Mountables
newMountPoint(    0 ,                  X,                Body,             Engine);
newMountPoint(    1 ,                  L,                LeftTread,        Reactor);
newMountPoint(    2 ,                  S,                TankHead,         Computer);
newMountPoint(    3 ,                  L,                none,             Armor);
newMountPoint(    4 ,                  L,                TankHead,         Sensors);
newMountPoint(    5 ,                  M,                TankHead,         ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                           LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack );
newMountPoint(    6 ,                  L,                Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                           LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack );
newMountPoint(    7 ,                  L,                Body,             ECM,            ThermalDiffuser,        LaserTargeting,NanoRepair,  Battery,     Cloak,FieldStabilizer,
                                                                           LifeSupport,    Capacitor,              AgravGenerator,TurbineBoost,RocketBooster,     ammoPack );
#                 Internal             Components
#                 id                   type              parent            max_dmg         identity_tag
newComponent(     Armor,               Armor,            none,                      10000 ,IDCOM_ARMOR             );
newComponent(     LeftServos,          LeftServos,       Body,                        500 ,IDCOM_LEFT_TREAD_SERVOS );
newComponent(     RightServos,         RightServos,      Body,                        500 ,IDCOM_RIGHT_TREAD_SERVOS);

#                 External             Components
#                 id                   type              parent            max_dmg         identity_tag            total internals         2000
newComponent(     Body,                Body,             none,                        525 ,IDCOM_BODY              );             # 0.35
newComponent(     TankHead,            TankHead,         Body,                        375 ,IDCOM_HEAD              );             # 0.25
newComponent(     LeftTread,           LeftTread,        Body,                        300 ,IDCOM_LEFT_TREAD        );             # 0.20
newComponent(     RightTread,          RightTread,       Body,                        300 ,IDCOM_RIGHT_TREAD       );             # 0.20
newComponent(     Pilot,               Pilot,            none,                        300 ,IDCOM_PILOT             );
#                 (totals),                                                            1500                                       =SUM(H62:H65)

#                 Distribution         of                internal          components      among                   external       components
#                 containee,           container,        percent/100,
newConfiguration( Armor,               Body,                           0.35);                                # 3500
newConfiguration( Armor,               TankHead,                       0.25);                                # 2500
newConfiguration( Armor,               LeftTread,                       0.2);                                # 2000
newConfiguration( Armor,               RightTread,                      0.2);                                # 2000
#                 1
#

newConfiguration( LeftServos,          LeftTread,                      1.00);
newConfiguration( RightServos,         RightTread,                     1.00);

defaultWeapons(                      21);
defaultMountables(115,                 201,              800,              928,            411,                    860,           830,                   810);
ÿ