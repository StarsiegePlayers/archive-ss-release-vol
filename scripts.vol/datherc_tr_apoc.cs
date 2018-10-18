######################################################################
# datHerc_tr_apoc.cs
#Terran Apoc
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS              Tech_Level      Combat_Value
hercBase(         IDVEH_TR_APOC,"APOC",          "tr_apoc.dts",                  15.0 ,                  60 ,           1.15 ,             3 ,        2540);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 12.00 ,           3.00 ,           25.00 ,              -12.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          52.00 ,             22.50);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          9.0,             14.0,                               30);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          1.45,                          1.55);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                                 3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                         X_rot_rnge        Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___             Z___            min__       max_  min__           max__
newHardPoint(     0,            M,               R,                RightPod,           2.5,                  -0.75,           3.70,           -25.0,      60.0, -60.0,             40);
newHardPoint(     1,            M,               L,                LeftPod,            -2.5,                 -0.75,           3.70,           -25.0,      60.0, -40.0,             60);
newHardPoint(     2,            X,               R,                RightPod,           2.5,                  0.5,             1.90,           -35.0,      60.0, -60.0,             40);
newHardPoint(     3,            X,               L,                LeftPod,            -2.5,                 0.5,             1.90,           -35.0,      60.0, -40.0,             60);
newHardPoint(     4,            S,               I,                RightPod,           1.75,                 -2.0,            3.5,            -15.0,      15.0, -15.0,             15);
newHardPoint(     5,            S,               I,                LeftPod,            -1.5,                 -2.0,            3.5,            -15.0,      15.0, -15.0,             15);
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            L,               Pelvis,           Engine);
newMountPoint(    1,            M,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               RightPod,         Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            L,               LeftPod,          Sensors             );
newMountPoint(    6,            M,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                          11000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            900 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            900 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals =            9000
newComponent(     Pelvis,       Pelvis,          none,                           1080 ,IDCOM_PELVIS          );                         # 0.12
newComponent(     Head,         Head,            Pelvis,                         1260 ,IDCOM_HEAD            );                         # 0.14
newComponent(     LeftLeg,      LeftLeg,         Pelvis,                         1080 ,IDCOM_LEFT_LEG        );                         # 0.12
newComponent(     RightLeg,     RightLeg,        Pelvis,                         1080 ,IDCOM_RIGHT_LEG       );                         # 0.12
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         810 ,IDCOM_LEFT_CALF       );                         # 0.09
newComponent(     RightCalf,    RightCalf,       RightLeg,                        810 ,IDCOM_RIGHT_CALF      );                         # 0.09
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                         540 ,IDCOM_LEFT_FOOT       );                         # 0.06
newComponent(     RightFoot,    RightFoot,       RightLeg,                        540 ,IDCOM_RIGHT_FOOT      );                         # 0.06
newComponent(     LeftPod,      LeftPod,         Head,                            900 ,IDCOM_LEFT_POD        );                         # 0.10
newComponent(     RightPod,     RightPod,        Head,                            900 ,IDCOM_RIGHT_POD       );                         # 0.10
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                                                (totals)                          9000                                                   1.00

#                 Distribution  of               internal          components          among                 external         components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.05);                                   # 550
newConfiguration( Armor,        RightFoot,                     0.05);                                   # 550
newConfiguration( Armor,        LeftCalf,                      0.10);                                  # 1100
newConfiguration( Armor,        RightCalf,                     0.10);                                  # 1100
newConfiguration( Armor,        LeftLeg,                       0.10);                                  # 1100
newConfiguration( Armor,        RightLeg,                      0.10);                                  # 1100
newConfiguration( Armor,        Pelvis,                        0.12);                                  # 1320
newConfiguration( Armor,        Head,                          0.14);                                  # 1540
newConfiguration( Armor,        LeftPod,                       0.12);                                  # 1320
newConfiguration( Armor,        RightPod,                      0.12);                                  # 1320
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   117,          117,             117,              117,                105,                                105);
defaultMountables(108,          202,             801,              304,                928,                  400,             820,                     850);
d