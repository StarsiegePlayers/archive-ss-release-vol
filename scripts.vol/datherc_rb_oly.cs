######################################################################
# datHerc_rb_oly.cs
# Rebel Olympian
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_RB_OLY, "OLYP",          "rb_oly.dts",                   15.0 ,                  75 ,          1.35 ,             2 ,        3150);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 10.00 ,           3.00 ,           20.00 ,               -9.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          45.00 ,             18.50);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          8.0,             12.0,                               20);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,                     -1.0 ,                 2);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             4.9,                                 5);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                        X_rot_rnge        Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___            Z___            min__       max_  min__           max__
newHardPoint(     0,            X,               T,                LeftPod,                            -2.5 ,          -1.5 ,           1.0 ,-15,        45.0 ,         -20.0 ,   75);
newHardPoint(     1,            X,               T,                RightPod,                            2.5 ,          -1.5 ,           1.0 ,-15,        45.0 ,         -75.0 ,   20);
newHardPoint(     2,            L,               B,                LeftPod,                            -2.5 ,           2.5 ,          -1.9 ,     -45.0 ,20.0 ,         -45.0 ,   75);
newHardPoint(     3,            L,               B,                RightPod,                            2.5 ,           2.5 ,          -1.9 ,     -45.0 ,20.0 ,         -75.0 ,   45);
newHardPoint(     4,            S,               I,                RightPod,                            2.5 ,           2.0 ,           0.0 ,     -45.0 ,45.0 ,         -15.0 ,   15);
newHardPoint(     5,            S,               I,                LeftPod,                            -2.5 ,           2.0 ,           0.0 ,     -45.0 ,45.0 ,         -15.0 ,   15);



#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            X,               Head,             Engine);
newMountPoint(    1,            L,               Head,             Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               LeftPod,          Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            L,               RightPod,         Sensors             );
newMountPoint(    6,            L,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,    Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,        AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                          10000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            500 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            500 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals             4500
newComponent(     Head,         Head,            none,                            720 ,IDCOM_HEAD            );                        # 0.16
newComponent(     LeftPod,      LeftPod,         Head,                            630 ,IDCOM_LEFT_POD        );                        # 0.14
newComponent(     RightPod,     RightPod,        Head,                            630 ,IDCOM_RIGHT_POD       );                        # 0.14
newComponent(     LeftLeg,      LeftLeg,         Head,                            495 ,IDCOM_LEFT_LEG        );                        # 0.11
newComponent(     RightLeg,     RightLeg,        Head,                            495 ,IDCOM_RIGHT_LEG       );                        # 0.11
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         450 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                        450 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftCalf,                        315 ,IDCOM_LEFT_FOOT       );                        # 0.07
newComponent(     RightFoot,    RightFoot,       RightCalf,                       315 ,IDCOM_RIGHT_FOOT      );                        # 0.07
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                               (totals)                                           4500                                                  1.00

#                 Distribution  of               internal          components          among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.07);                                   # 700
newConfiguration( Armor,        RightFoot,                     0.07);                                   # 700
newConfiguration( Armor,        LeftCalf,                      0.10);                                  # 1000
newConfiguration( Armor,        RightCalf,                     0.10);                                  # 1000
newConfiguration( Armor,        LeftLeg,                       0.12);                                  # 1200
newConfiguration( Armor,        RightLeg,                      0.12);                                  # 1200
newConfiguration( Armor,        LeftPod,                       0.14);                                  # 1400
newConfiguration( Armor,        RightPod,                      0.14);                                  # 1400
newConfiguration( Armor,        Head,                          0.14);                                  # 1400
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   107,          107,             115,              115,                105,                               105);
defaultMountables(114,          205,             801,              305,                928,                  411,            810,                     865);

