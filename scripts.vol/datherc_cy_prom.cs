######################################################################
# datHerc_cy_prom.cs
# Cybrid Prometheus
#
######################################################################
vehiclePilotable(false);
#                     Identity_Tag   Abbreviation         Shape            Mass                MaxMass               RCS              Tech_Level      Combat_Value
hercBase(             IDVEH_CY_PROM, PROM,                 "cy_PROM.dts",                20.0 ,                 120 ,           1.00 ,           127 ,        5000);

#                     maxPosAcc      minPosVel            maxForPosVel     maxRevPosVel        (all_m/s)
hercPos(                      14.00 ,               3.00 ,          30.00 ,              -15.00);

#                     minRotVel      maxRVSlow            maxRVFast        {all_deg/s}
hercRot(                       6.00 ,              90.00 ,            60.00);

#                     toStandVel     toRunVel             toFastRunVel     toFastTurnVel(deg/s)
hercAnim(             4.0,           10.0,                18.0,                              41);

#                     offsetX        offsetY              offsetZ
hercCpit(             0.0,           1.5,                              1.25);

#                     sphOffstX      sphOffstY            sphOffstZ        sphereRad
hercColl(             0.0,           0.0,                 2.9,                                4);

#                     fireBayesNetName
hercAI(               "hercFire.ai",  "targetPart.ai",    "hercManeuver.ai"); #                "hercRetreat.ai"      );

#                     Hard Points
#                     (sizes:SMLX    sides:TBLR)          Dmg              Offset_fm_Node                                                             X_rot_rnge        Z_rot_rnge
#                     id             size                 side             Prnt                X___                  Y___             Z___            min__       max_  min__           max__
newHardPoint(         0,             X,                   I,               TopPod,               -3.5,                 0.4,             0.7,            -60.0,      60.0, -60.0,             60);
newHardPoint(         1,             X,                   I,               TopPod,                3.5,                 0.4,             0.7,            -60.0,      60.0, -60.0,             60);
newHardPoint(         2,             X,                   R,               TopPod,             4.0,                  -1.5,            0.0,            -60.0,      60.0, -60.0,             60);
newHardPoint(         3,             X,                   L,               TopPod,             -4.0,                 -1.5,            0.0,            -60.0,      60.0, -60.0,             60);
newHardPoint(         4,             X,                   R,               Pelvis,             1.8,                  1.5,             -3.0,           -60.0,      60.0, -60.0,             60);
newHardPoint(         5,             X,                   L,               Pelvis,             -1.8,                 1.5,             -3.0,           -60.0,      60.0, -60.0,             60);



#                     id             size                 Dmg_Parent       Allowed_Mountables
newMountPoint(        0,             X,                   Pelvis,          Engine);
newMountPoint(        1,             X,                   Pelvis,          Reactor);
newMountPoint(        2,             X,                   Head,            Computer);
newMountPoint(        3,             X,                   Pelvis,          Shield);
newMountPoint(        4,             X,                   none,            Armor);
newMountPoint(        5,             X,                   Head,            Sensors             );
newMountPoint(        6,             X,                   Head,            ECM,                ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                           LifeSupport,        ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(        7,             X,                   Head,            ECM,                ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                           LifeSupport,        ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
#                     Internal       Components
#                     id             type                 parent           max_dmg             identity_tag
newComponent(         Armor,         Armor,               none,                         18000 ,IDCOM_ARMOR           );
newComponent(         LeftServos,    LeftServos,          none,                          3000 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(         RightServos,   RightServos,         none,                          3000 ,IDCOM_RIGHT_LEG_SERVOS);

#                     External       Components
#                     id             type                 parent           max_dmg             identity_tag          total internals =           10000
newComponent(         Pelvis,        Pelvis,              none,                          1000 ,IDCOM_PELVIS          );                         # 0.10
newComponent(         Head,          Head,                Pelvis,                        1100 ,IDCOM_HEAD            );                         # 0.11
newComponent(         TopPod,        TopPod,              Pelvis,                        1100 ,IDCOM_HEAD            );                         # 0.11
newComponent(         LeftThigh,     LeftThigh,           Pelvis,                        1000 ,IDCOM_LEFT_THIGH      );                         # 0.10
newComponent(         RightThigh,    RightThigh,          Pelvis,                        1000 ,IDCOM_RIGHT_THIGH     );                         # 0.10
newComponent(         LeftLeg,       LeftLeg,             Pelvis,                         900 ,IDCOM_LEFT_LEG        );                         # 0.09
newComponent(         RightLeg,      RightLeg,            Pelvis,                         900 ,IDCOM_RIGHT_LEG       );                         # 0.09
newComponent(         LeftCalf,      LeftCalf,            LeftLeg,                        800 ,IDCOM_LEFT_CALF       );                         # 0.08
newComponent(         RightCalf,     RightCalf,           RightLeg,                       800 ,IDCOM_RIGHT_CALF      );                         # 0.08
newComponent(         LeftFoot,      LeftFoot,            LeftLeg,                        700 ,IDCOM_LEFT_FOOT       );                         # 0.07
newComponent(         RightFoot,     RightFoot,           RightLeg,                       700 ,IDCOM_RIGHT_FOOT      );                         # 0.07
newComponent(         Pilot,         Pilot,               none,                          1000 ,IDCOM_PILOT           );
#                                                         (totals)                        10000                                                 # 1.00

#                     Distribution   of                   internal         components          among                 external         components
#                     containee      container            percent/100
newConfiguration(     Armor,         LeftFoot,                         0.07);                                  # 1260
newConfiguration(     Armor,         RightFoot,                        0.07);                                  # 1260
newConfiguration(     Armor,         LeftCalf,                         0.08);                                  # 1440
newConfiguration(     Armor,         RightCalf,                        0.08);                                  # 1440
newConfiguration(     Armor,         LeftLeg,                          0.09);                                  # 1620
newConfiguration(     Armor,         RightLeg,                         0.09);                                  # 1620
newConfiguration(     Armor,         LeftThigh,                         0.1);                                  # 1800
newConfiguration(     Armor,         RightThigh,                        0.1);                                  # 1800
newConfiguration(     Armor,         TopPod,                           0.11);                                  # 1980
newConfiguration(     Armor,         Pelvis,                            0.1);                                  # 1800
newConfiguration(     Armor,         Head,                             0.11);                                  # 1980
#                     -----
#                                                                      1.00

newConfiguration(     LeftServos,    LeftFoot,                         0.25);
newConfiguration(     LeftServos,    LeftCalf,                         0.25);
newConfiguration(     LeftServos,    LeftLeg,                          0.25);
newConfiguration(     LeftServos,    LeftThigh,                        0.25);

newConfiguration(     RightServos,   RightFoot,                        0.25);
newConfiguration(     RightServos,   RightCalf,                        0.25);
newConfiguration(     RightServos,   RightLeg,                         0.25);
newConfiguration(     RightServos,   RightThigh,                       0.25);

defaultWeapons(       142,           104,                 133,             121,                111,                                118);
defaultMountables(    143,           230,                 805,             333,                931,                  433,             890,                     850);
i