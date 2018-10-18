######################################################################
# datHerc_tr_mino.cs
# Terran Minotaur
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_TR_MINO,"MINO",          "tr_mino.dts",                   7.0 ,                  40 ,          0.90 ,             1 ,      1300);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 15.00 ,           3.00 ,           33.00 ,              -15.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          72.50 ,             37.50);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          10.0,            24.0,                               30);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          0.3,                            0.2);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                                 3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                        X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___            Z___            min__     max_  min__           max__
newHardPoint(     0,            S,               T,                RightPod,           1.9,                  -0.6,           1.05,           -15.0,    45.0, -60.0,             60);
newHardPoint(     1,            S,               T,                LeftPod,            -1.9,                 -0.6,           1.05,           -15.0,    45.0, -60.0,             60);
newHardPoint(     2,            M,               R,                RightPod,           3.0,                  -0.6,           -0.15,          -40.0,    40.0, -60.0,             50);
newHardPoint(     3,            M,               L,                LeftPod,            -3.0,                 -0.6,           -0.15,          -40.0,    40.0, -50.0,             60);
#
#
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            M,               Pelvis,           Engine);
newMountPoint(    1,            M,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            M,               LeftPod,          Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            M,               RightPod,         Sensors             );
newMountPoint(    6,            M,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                           7200 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            900 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            900 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals             6000
newComponent(     Pelvis,       Pelvis,          none,                            720 ,IDCOM_PELVIS          );                        # 0.12
newComponent(     Head,         Head,            Pelvis,                          720 ,IDCOM_HEAD            );                        # 0.12
newComponent(     LeftLeg,      LeftLeg,         Pelvis,                          660 ,IDCOM_LEFT_LEG        );                        # 0.11
newComponent(     RightLeg,     RightLeg,        Pelvis,                          660 ,IDCOM_RIGHT_LEG       );                        # 0.11
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         600 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                        600 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                         300 ,IDCOM_LEFT_FOOT       );                        # 0.05
newComponent(     RightFoot,    RightFoot,       RightLeg,                        300 ,IDCOM_RIGHT_FOOT      );                        # 0.05
newComponent(     LeftPod,      LeftPod,         Head,                            720 ,IDCOM_LEFT_POD        );                        # 0.12
newComponent(     RightPod,     RightPod,        Head,                            720 ,IDCOM_RIGHT_POD       );                        # 0.12
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                                                (totals)                          6000                                                  1.00

#                 Distribution  of               internal          components          among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                                   # 432
newConfiguration( Armor,        RightFoot,                     0.06);                                   # 432
newConfiguration( Armor,        LeftCalf,                      0.09);                                   # 648
newConfiguration( Armor,        RightCalf,                     0.09);                                   # 648
newConfiguration( Armor,        LeftLeg,                        0.1);                                   # 720
newConfiguration( Armor,        RightLeg,                       0.1);                                   # 720
newConfiguration( Armor,        Pelvis,                        0.12);                                   # 864
newConfiguration( Armor,        Head,                           0.1);                                   # 720
newConfiguration( Armor,        LeftPod,                       0.14);                                  # 1008
newConfiguration( Armor,        RightPod,                      0.14);                                  # 1008
#
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   101,          101,             102,                               102);
defaultMountables(104,          203,             801,              302,                927,                  400,            865,                   870);
