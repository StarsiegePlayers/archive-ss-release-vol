######################################################################
# datHerc_kn_basl.cs
# Knight Basilisk
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_KN_BASL,"BASL",          "kn_basl.dts",                   8.0 ,                  50 ,          1.00 ,             4 ,      2325);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 14.00 ,           3.00 ,           30.00 ,              -15.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          62.50 ,             32.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          14.0,            28.0,                               30);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          -0.1,                         -0.94);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                                 3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                        X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___            Z___            min__     max_  min__           max__
newHardPoint(     0,            M,               T,                RightPod,           2.295,                -1.275,         2.0,            -25.0,    60.0, -60.0,             60);
newHardPoint(     1,            M,               T,                LeftPod,            -2.295,               -1.275,         2.0,            -25.0,    60.0, -60.0,             60);
newHardPoint(     2,            X,               R,                Head,               3.225,                -1.115,         -0.1,           -60.0,    15.0, -60.0,             30);
newHardPoint(     3,            X,               L,                Head,               -3.225,               -1.115,         -0.1,           -60.0,    15.0, -30.0,             60);
#
#
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            L,               Pelvis,           Engine);
newMountPoint(    1,            M,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               LeftPod,          Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            S,               RightPod,         Sensors             );
newMountPoint(    6,            M,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                           7800 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            275 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            275 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals             7000
newComponent(     Pelvis,       Pelvis,          none,                            840 ,IDCOM_PELVIS          );                        # 0.12
newComponent(     Head,         Head,            Pelvis,                          980 ,IDCOM_HEAD            );                        # 0.14
newComponent(     LeftLeg,      LeftLeg,         Pelvis,                          630 ,IDCOM_LEFT_LEG        );                        # 0.09
newComponent(     RightLeg,     RightLeg,        Pelvis,                          630 ,IDCOM_RIGHT_LEG       );                        # 0.09
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         700 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                        700 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                         490 ,IDCOM_LEFT_FOOT       );                        # 0.07
newComponent(     RightFoot,    RightFoot,       RightLeg,                        490 ,IDCOM_RIGHT_FOOT      );                        # 0.07
newComponent(     LeftPod,      LeftPod,         Head,                            770 ,IDCOM_LEFT_POD        );                        # 0.11
newComponent(     RightPod,     RightPod,        Head,                            770 ,IDCOM_RIGHT_POD       );                        # 0.11
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                                                                              7000.0 ,                                                # 1.00

#                 Distribution  of               internal          components          among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                                   # 468
newConfiguration( Armor,        RightFoot,                     0.06);                                   # 468
newConfiguration( Armor,        LeftCalf,                      0.10);                                   # 780
newConfiguration( Armor,        RightCalf,                     0.10);                                   # 780
newConfiguration( Armor,        LeftLeg,                       0.10);                                   # 780
newConfiguration( Armor,        RightLeg,                      0.10);                                   # 780
newConfiguration( Armor,        Pelvis,                        0.11);                                   # 858
newConfiguration( Armor,        Head,                          0.15);                                  # 1170
newConfiguration( Armor,        LeftPod,                       0.11);                                   # 858
newConfiguration( Armor,        RightPod,                      0.11);                                   # 858
#                 -----
#                              1

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   124,          124,             127,                               127);
defaultMountables(109,          202,             801,              303,                930,                  408,            810,                   840);
tt