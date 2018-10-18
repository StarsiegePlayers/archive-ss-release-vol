######################################################################
# datHerc_kn_gorg.cs
# Knight Gorgon
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS              Tech_Level      Combat_Value
hercBase(         IDVEH_KN_GORG,"GORG",          "kn_gorg.dts",                  22.0 ,                  80 ,           1.40 ,             6 ,        3805);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 10.00 ,           3.00 ,           27.50 ,              -10.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          50.00 ,             23.50);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          10.0,            14.0,                               30);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          1.85,                             0);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             4.9,                                 5);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                         X_rot_rnge        Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___             Z___            min__       max_  min__           max__
newHardPoint(     0,            X,               R,                Head,               2.75,                 1.4,             1.0,            -30.0,      60.0, -60.0,             30);
newHardPoint(     1,            X,               L,                Head,               -2.75,                1.4,             1.0,            -30.0,      60.0, -30.0,             60);
newHardPoint(     2,            L,               T,                Head,               2.0,                  -2.0,            3.5,            -20.0,      40.0, -60.0,             60);
newHardPoint(     3,            L,               T,                Head,               -2.0,                 -2.0,            3.5,            -20.0,      40.0, -60.0,             60);





#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            X,               Pelvis,           Engine);
newMountPoint(    1,            L,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               RightPod,         Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            M,               LeftPod,          Sensors             );
newMountPoint(    6,            L,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                          12500 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            200 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            200 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals =           10000
newComponent(     Head,         Head,            none,                           1500 ,IDCOM_HEAD            );                         # 0.15
newComponent(     Pelvis,       Pelvis,          Head,                            900 ,IDCOM_PELVIS          );                         # 0.09
newComponent(     LeftPod,      LeftPod,         Pelvis,                          800 ,IDCOM_LEFT_POD        );                         # 0.08
newComponent(     RightPod,     RightPod,        Pelvis,                          800 ,IDCOM_RIGHT_POD       );                         # 0.08
newComponent(     LeftLeg,      LeftLeg,         LeftPod,                        1200 ,IDCOM_LEFT_LEG        );                         # 0.12
newComponent(     RightLeg,     RightLeg,        RightPod,                       1200 ,IDCOM_RIGHT_LEG       );                         # 0.12
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                        1000 ,IDCOM_LEFT_CALF       );                         # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                       1000 ,IDCOM_RIGHT_CALF      );                         # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                         800 ,IDCOM_LEFT_FOOT       );                         # 0.08
newComponent(     RightFoot,    RightFoot,       RightLeg,                        800 ,IDCOM_RIGHT_FOOT      );                         # 0.08
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                               (totals)                                          10000                                                   1.00

#                 Distribution  of               internal          components          among                 external         components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.08);                                  # 1000
newConfiguration( Armor,        RightFoot,                     0.08);                                  # 1000
newConfiguration( Armor,        LeftCalf,                      0.10);                                  # 1250
newConfiguration( Armor,        RightCalf,                     0.10);                                  # 1250
newConfiguration( Armor,        LeftLeg,                       0.10);                                  # 1250
newConfiguration( Armor,        RightLeg,                      0.10);                                  # 1250
newConfiguration( Armor,        Pelvis,                        0.13);                                  # 1625
newConfiguration( Armor,        Head,                          0.15);                                  # 1875
newConfiguration( Armor,        LeftPod,                       0.08);                                  # 1000
newConfiguration( Armor,        RightPod,                      0.08);                                  # 1000
#                 -----
#                                                              1.00                                   # 12500

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   102,          102,             129,                               129);
defaultMountables(114,          204,             801,              307,                927,                  400,             820,                     850);
t