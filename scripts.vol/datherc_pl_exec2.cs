######################################################################
# datHerc_pl_exec.cs
# Cybrid Platinum Guard Executioner (player version)
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass            MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_PL_EXEC,"EXEC",          "pl_exec.dts",              23.0 ,                  90 ,          1.50 ,             5 ,      3835);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
hercPos(                  7.50 ,           3.00 ,           25.00 ,           -9.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          42.00 ,             20.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          8.0,             14.0,                           20);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          3.4,                          -0.65);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             4.9,                             5);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai");

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                        X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt            X___                  Y___            Z___            min__     max_  min__           max__
newHardPoint(     0,            X,               R,                Head,           3.8,                  1.25,           -0.5,           -45.0,    50.0, -45.0,          30);
newHardPoint(     1,            X,               L,                Head,           -3.8,                 1.25,           -0.5,           -45.0,    50.0, -30.0,          45);
newHardPoint(     2,            L,               B,                Head,           2.0,                  3.25,           -1.2,           -40.0,    30.0, -45.0,          20);
newHardPoint(     3,            L,               B,                Head,           -2.0,                 3.25,           -1.2,           -45.0,    30.0, -20.0,          45);
#
#
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            X,               Head,             Engine);
newMountPoint(    1,            L,               Head,             Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               Head,             Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            L,               Head,             Sensors         );
newMountPoint(    6,            L,               Head,             ECM,            ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,    ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,     TurbineBoost,RocketBooster);
newMountPoint(    7,            L,               Head,             ECM,            ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,    ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,     TurbineBoost,RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg         identity_tag
newComponent(     Armor,        Armor,           none,                       9500 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                       1500 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                       1500 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg         identity_tag          total internals=            5500
newComponent(     Head,         Head,            none,                       1870 ,IDCOM_HEAD            );                        # 0.34
newComponent(     LeftLeg,      LeftLeg,         Head,                        660 ,IDCOM_LEFT_LEG        );                        # 0.12
newComponent(     RightLeg,     RightLeg,        Head,                        660 ,IDCOM_RIGHT_LEG       );                        # 0.12
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                     660 ,IDCOM_LEFT_CALF       );                        # 0.12
newComponent(     RightCalf,    RightCalf,       RightLeg,                    660 ,IDCOM_RIGHT_CALF      );                        # 0.12
newComponent(     LeftFoot,     LeftFoot,        LeftCalf,                    495 ,IDCOM_LEFT_FOOT       );                        # 0.09
newComponent(     RightFoot,    RightFoot,       RightCalf,                   495 ,IDCOM_RIGHT_FOOT      );                        # 0.09
newComponent(     Pilot,        Pilot,           none,                        300 ,IDCOM_PILOT           );
                  #                              (totals)                    5500 ,                                                  1.00

#                 Distribution  of               internal          components      among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                               # 570
newConfiguration( Armor,        RightFoot,                     0.06);                               # 570
newConfiguration( Armor,        LeftCalf,                      0.09);                               # 855
newConfiguration( Armor,        RightCalf,                     0.09);                               # 855
newConfiguration( Armor,        LeftLeg,                        0.1);                               # 950
newConfiguration( Armor,        RightLeg,                       0.1);                               # 950
newConfiguration( Armor,        Head,                           0.5);                              # 4750
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   121,          121,             109,                           109);
defaultMountables(143,          230,             805,              331,            930,                  428,            865,                   850);

