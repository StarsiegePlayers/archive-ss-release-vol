######################################################################
# datHerc_tr_basl.cs
# Terran Basilisk
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_TR_BASL,"BASL",          "tr_basl.dts",                  10.0 ,                  50 ,          1.00 ,             2 ,      2000);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 13.00 ,           3.00 ,           28.50 ,              -15.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          60.00 ,             31.00);

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
newMountPoint(    3,            M,               LeftPod,          Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            M,               RightPod,         Sensors             );
newMountPoint(    6,            M,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                           8500 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            400 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            400 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals             7000
newComponent(     Pelvis,       Pelvis,          none,                          840.0 ,IDCOM_PELVIS          );                        # 0.12
newComponent(     Head,         Head,            Pelvis,                        980.0 ,IDCOM_HEAD            );                        # 0.14
newComponent(     LeftLeg,      LeftLeg,         Pelvis,                        630.0 ,IDCOM_LEFT_LEG        );                        # 0.09
newComponent(     RightLeg,     RightLeg,        Pelvis,                        630.0 ,IDCOM_RIGHT_LEG       );                        # 0.09
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                       700.0 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                      700.0 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                       490.0 ,IDCOM_LEFT_FOOT       );                        # 0.07
newComponent(     RightFoot,    RightFoot,       RightLeg,                      490.0 ,IDCOM_RIGHT_FOOT      );                        # 0.07
newComponent(     LeftPod,      LeftPod,         Head,                          770.0 ,IDCOM_LEFT_POD        );                        # 0.11
newComponent(     RightPod,     RightPod,        Head,                          770.0 ,IDCOM_RIGHT_POD       );                        # 0.11
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#damage base                                     (totals)                          7000                                                # 1.00

#                 Distribution  of               internal          components          among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                                   # 510
newConfiguration( Armor,        RightFoot,                     0.06);                                   # 510
newConfiguration( Armor,        LeftCalf,                      0.10);                                   # 850
newConfiguration( Armor,        RightCalf,                     0.10);                                   # 850
newConfiguration( Armor,        LeftLeg,                       0.10);                                   # 850
newConfiguration( Armor,        RightLeg,                      0.10);                                   # 850
newConfiguration( Armor,        Pelvis,                        0.11);                                   # 935
newConfiguration( Armor,        Head,                          0.15);                                  # 1275
newConfiguration( Armor,        LeftPod,                       0.11);                                   # 935
newConfiguration( Armor,        RightPod,                      0.11);                                   # 935
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   105,          105,             125,                               125);
defaultMountables(108,          201,             801,              303,                929,                  408,            810,                   840);
to