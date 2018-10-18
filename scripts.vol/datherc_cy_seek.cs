######################################################################
# datHerc_cy_seek.cs
# Cybrid Seeker
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_CY_SEEK,"SEEK",          "cy_seek.dts",                   4.0 ,                  25 ,          0.75 ,             1 ,        1205);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 22.50 ,           3.00 ,           45.00 ,              -25.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          90.00 ,             60.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          15.0,            30.0,                               50);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          0.5,                              0);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                                 3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                        X_rot_rnge        Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___            Z___            min__       max_  min__           max__
newHardPoint(     0,            M,               T,                Head,               -1.5,                 -2.0,           0.75,           -45.0,      45.0, -30.0,             60);
newHardPoint(     1,            M,               T,                Head,               1.5,                  -2.0,           0.75,           -45.0,      45.0, -60.0,             30);
# HardPointDamage(           200);
#
#
#
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            S,               Pelvis,           Engine);
newMountPoint(    1,            M,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            M,               Pelvis,           Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            L,               Head,             Sensors             );
newMountPoint(    6,            L,               Pelvis,           ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster   );
newMountPoint(    7,            S,               Pelvis,           ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster   );
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                           2000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            400 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            400 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals             2000
newComponent(     Pelvis,       Pelvis,          none,                            300 ,IDCOM_PELVIS          );                        # 0.15
newComponent(     Head,         Head,            Pelvis,                          260 ,IDCOM_HEAD            );                        # 0.13
newComponent(     LeftThigh,    LeftThigh,       Pelvis,                          200 ,IDCOM_LEFT_THIGH      );                        # 0.10
newComponent(     RightThigh,   RightThigh,      Pelvis,                          200 ,IDCOM_RIGHT_THIGH     );                        # 0.10
newComponent(     LeftLeg,      LeftLeg,         LeftThigh,                       180 ,IDCOM_LEFT_LEG        );                        # 0.09
newComponent(     RightLeg,     RightLeg,        RighThigh,                       180 ,IDCOM_RIGHT_LEG       );                        # 0.09
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         200 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                        200 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftCalf,                        140 ,IDCOM_LEFT_FOOT       );                        # 0.07
newComponent(     RightFoot,    RightFoot,       RightCalf,                       140 ,IDCOM_RIGHT_FOOT      );                        # 0.07
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                                                (totals)                          2000                                                  1.00

#                 Distribution of internal components among external components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.08);                                   # 160
newConfiguration( Armor,        RightFoot,                     0.08);                                   # 160
newConfiguration( Armor,        LeftCalf,                      0.09);                                   # 180
newConfiguration( Armor,        RightCalf,                     0.09);                                   # 180
newConfiguration( Armor,        LeftLeg,                        0.1);                                   # 200
newConfiguration( Armor,        RightLeg,                       0.1);                                   # 200
newConfiguration( Armor,        LeftThigh,                     0.11);                                   # 220
newConfiguration( Armor,        RightThigh,                    0.11);                                   # 220
newConfiguration( Armor,        Pelvis,                        0.11);                                   # 220
newConfiguration( Armor,        Head,                          0.13);                                   # 260
#                 -----                                           1
#

newConfiguration( LeftServos,   LeftFoot,                      0.25);
newConfiguration( LeftServos,   LeftCalf,                      0.25);
newConfiguration( LeftServos,   LeftLeg,                       0.25);
newConfiguration( LeftServos,   LeftThigh,                     0.25);

newConfiguration( RightServos,  RightFoot,                     0.25);
newConfiguration( RightServos,  RightCalf,                     0.25);
newConfiguration( RightServos,  RightLeg,                      0.25);
newConfiguration( RightServos,  RightThigh,                    0.25);

defaultWeapons(   117,                        117);
defaultMountables(129,          225,             806,              328,                926,                  426,            850,                     812);
x