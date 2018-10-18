######################################################################
# datHerc_pl_adju.cs
# Cybrid Platinum Guard Adjudicator
#
######################################################################
vehiclePilotable(false);
#                 Identity_Tag  Abbreviation     Shape             Mass                MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_PL_ADJU,"JUDG",          "pl_JUDG.dts",                  10.0 ,                  60 ,          1.20 ,             5 ,      2995);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel        (all_m/s)
hercPos(                 13.00 ,           3.00 ,           30.00 ,              -15.00);

#                 minRotVel     maxRVSlow        maxRVFast         {all_deg/s}
hercRot(                  6.00 ,          65.00 ,             30.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          10.0,            18.0,                               41);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          3.0,                           -1.5);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                                 3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"    );

#                 Special Footprint type
hercFootprint(    IDBMP_CY_FOOTPRINT_3           );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg                 Offset_fm_Node                                        X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt                X___                  Y___            Z___            min__     max_  min__           max__
newHardPoint(     0,            M,               T,                RightPod,           1.75,                 -3.25,          4.75,           -35.0,    45.0, -60.0,             60);
newHardPoint(     1,            M,               T,                LeftPod,            -1.75,                -3.25,          4.75,           -35.0,    45.0, -60.0,             60);
newHardPoint(     2,            X,               R,                RightPod,           2.3,                  -3.2,           3.0,            -50.0,    90.0, -60.0,             20);
newHardPoint(     3,            X,               L,                LeftPod,            -2.3,                 -3.2,           3.0,            -50.0,    90.0, -20.0,             60);
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            X,               Pelvis,           Engine);
newMountPoint(    1,            L,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               Pelvis,           Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            S,               Head,             Sensors             );
newMountPoint(    6,            M,               LeftPod,          ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator, TurbineBoost,        RocketBooster);
newMountPoint(    7,            L,               RightPod,         ECM,                ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,ammoPack,
                                                                   LifeSupport,        ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator, TurbineBoost,        RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg             identity_tag
newComponent(     Armor,        Armor,           none,                          13000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                           1600 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                           1600 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg             identity_tag                                      9500
newComponent(     Pelvis,       Pelvis,          none,                            950 ,IDCOM_PELVIS          );                        # 0.10
newComponent(     Head,         Head,            Pelvis,                         1140 ,IDCOM_HEAD            );                        # 0.12
newComponent(     LeftThigh,    LeftThigh,       Pelvis,                          760 ,IDCOM_LEFT_THIGH      );                        # 0.08
newComponent(     RightThigh,   RightThigh,      Pelvis,                          760 ,IDCOM_RIGHT_THIGH     );                        # 0.08
newComponent(     LeftLeg,      LeftLeg,         LeftThigh,                       760 ,IDCOM_LEFT_LEG        );                        # 0.08
newComponent(     RightLeg,     RightLeg,        RighThigh,                       760 ,IDCOM_RIGHT_LEG       );                        # 0.08
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                         665 ,IDCOM_LEFT_CALF       );                        # 0.07
newComponent(     RightCalf,    RightCalf,       RightLeg,                        665 ,IDCOM_RIGHT_CALF      );                        # 0.07
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                         570 ,IDCOM_LEFT_FOOT       );                        # 0.06
newComponent(     RightFoot,    RightFoot,       RightLeg,                        570 ,IDCOM_RIGHT_FOOT      );                        # 0.06
newComponent(     LeftPod,      LeftPod,         Head,                            950 ,IDCOM_LEFT_POD        );                        # 0.10
newComponent(     RightPod,     RightPod,        Head,                            950 ,IDCOM_RIGHT_POD       );                        # 0.10
newComponent(     Pilot,        Pilot,           none,                            300 ,IDCOM_PILOT           );
                                                                                                                                       # 1.00

#                 Distribution  of               internal          components          among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                                   # 780
newConfiguration( Armor,        RightFoot,                     0.06);                                   # 780
newConfiguration( Armor,        LeftCalf,                      0.07);                                   # 910
newConfiguration( Armor,        RightCalf,                     0.07);                                   # 910
newConfiguration( Armor,        LeftLeg,                       0.08);                                  # 1040
newConfiguration( Armor,        RightLeg,                      0.08);                                  # 1040
newConfiguration( Armor,        LeftThigh,                     0.09);                                  # 1170
newConfiguration( Armor,        RightThigh,                    0.09);                                  # 1170
newConfiguration( Armor,        LeftPod,                        0.1);                                  # 1300
newConfiguration( Armor,        RightPod,                       0.1);                                  # 1300
newConfiguration( Armor,        Pelvis,                         0.1);                                  # 1300
newConfiguration( Armor,        Head,                           0.1);                                  # 1300
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                      0.25);
newConfiguration( LeftServos,   LeftCalf,                      0.25);
newConfiguration( LeftServos,   LeftLeg,                       0.25);
newConfiguration( LeftServos,   LeftThigh,                     0.25);

newConfiguration( RightServos,  RightFoot,                     0.25);
newConfiguration( RightServos,  RightCalf,                     0.25);
newConfiguration( RightServos,  RightLeg,                      0.25);
newConfiguration( RightServos,  RightThigh,                    0.25);

defaultWeapons(   114,          114,             121,                               121);
defaultMountables(139,          225,             805,              330,                930,                  428,            812,                   850);
vI