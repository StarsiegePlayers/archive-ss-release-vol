######################################################################
# datHerc_tr_talo.cs
# Terran Talon
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               Radar_Cross_SectionTech_Level      Combat_Value
hercBase(         IDVEH_TR_TALO,"TALO",          "tr_talon.dts",                  6.0 ,                  30 ,             0.85 ,             1 ,      1000);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 18.00 ,           3.00 ,           38.50 ,              -20.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          78.00 ,             37.50);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          10.0,            30.0,                               30);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          0.5,                           0.15);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                                 3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                           X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___               Z___            min__     max_  min__           max__
newHardPoint(     0,            M,               T,                LeftPod,            1.25,                 -1.5,              1.3,            -25.0,    45.0, -60.0,             30);
newHardPoint(     1,            M,               T,                LeftPod,            -1.25,                -1.5,              1.3,            -25.0,    45.0, -30.0,             60);
#
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
newMountPoint(    3,            S,               LeftPod,          Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            L,               RightPod,         Sensors             );
newMountPoint(    6,            L,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting,    NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,   ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
newMountPoint(    7,            S,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting,    NanoRepair,     Battery,  Cloak,FieldStabilizer,       ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,   ShieldAmplifier,Capacitor,      AgravGenerator,        TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                           4000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                            600 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                            600 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag          total internals =              2000
newComponent(     Pelvis,       Pelvis,          none,                            260 ,IDCOM_PELVIS          );                           # 0.13
newComponent(     Head,         Head,            Pelvis,                          300 ,IDCOM_HEAD            );                           # 0.15
newComponent(     LeftLeg,      LeftLeg,         Pelvis,                          200 ,IDCOM_LEFT_LEG        );                           # 0.10
newComponent(     RightLeg,     RightLeg,        Pelvis,                          200 ,IDCOM_RIGHT_LEG       );                           # 0.10
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         200 ,IDCOM_LEFT_CALF       );                           # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                        200 ,IDCOM_RIGHT_CALF      );                           # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                         100 ,IDCOM_LEFT_FOOT       );                           # 0.05
newComponent(     RightFoot,    RightFoot,       RightLeg,                        100 ,IDCOM_RIGHT_FOOT      );                           # 0.05
newComponent(     LeftPod,      LeftPod,         Head,                            220 ,IDCOM_LEFT_POD        );                           # 0.11
newComponent(     RightPod,     RightPod,        Head,                            220 ,IDCOM_RIGHT_POD       );                           # 0.11
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
#                                                (totals)                          2000                                                     1.00

#                 Distribution  of               internal          components          among                 external           components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.05);                                   # 200
newConfiguration( Armor,        RightFoot,                     0.05);                                   # 200
newConfiguration( Armor,        LeftCalf,                      0.10);                                   # 400
newConfiguration( Armor,        RightCalf,                     0.10);                                   # 400
newConfiguration( Armor,        LeftLeg,                       0.12);                                   # 480
newConfiguration( Armor,        RightLeg,                      0.12);                                   # 480
newConfiguration( Armor,        Pelvis,                        0.13);                                   # 520
newConfiguration( Armor,        Head,                          0.13);                                   # 520
newConfiguration( Armor,        LeftPod,                       0.16);                                   # 640
newConfiguration( Armor,        RightPod,                      0.04);                                   # 160
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   101,                        101);
defaultMountables(101,          202,             801,              300,                926,                  410,               850,                   810);
R