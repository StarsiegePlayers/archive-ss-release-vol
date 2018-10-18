######################################################################
# datHerc_mg_adju.cs
# Cybrid (Metagen) Adjudicator
# Clone of adjudicator except for labels and .dts
######################################################################
vehiclePilotable(false);
#                 Identity_Tag  Abbreviation     Shape             Mass            MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_MG_ADJU,"JUDG",          "mg_JUDG.dts",              12.0 ,                  60 ,          1.20 ,             3 ,      2705);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
hercPos(                 12.50 ,           3.00 ,           27.00 ,          -15.00);

#                 minRotVel     maxRVSlow        maxRVFast         {all_deg/s}
hercRot(                  6.00 ,          50.00 ,             25.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          10.0,            18.0,                           41);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          3.0,                           -1.5);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                             3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai");

#                 Special Footprint type
hercFootprint(    IDBMP_CY_FOOTPRINT_3           );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                        X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt            X___                  Y___            Z___            min__     max_  min__           max__
newHardPoint(     0,            M,               T,                RightPod,       1.75,                 -3.25,          4.75,           -35.0,    45.0, -60.0,           60);
newHardPoint(     1,            M,               T,                LeftPod,        -1.75,                -3.25,          4.75,           -35.0,    45.0, -60.0,           60);
newHardPoint(     2,            X,               R,                RightPod,       2.3,                  -3.2,           3.0,            -50.0,    90.0, -60.0,           20);
newHardPoint(     3,            X,               L,                LeftPod,        -2.3,                 -3.2,           3.0,            -50.0,    90.0, -20.0,           60);
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            X,               Pelvis,           Engine);
newMountPoint(    1,            M,               Pelvis,           Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               Pelvis,           Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            S,               Head,             Sensors         );
newMountPoint(    6,            M,               LeftPod,          ECM,            ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,           ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,            TurbineBoost,RocketBooster);
newMountPoint(    7,            L,               RightPod,         ECM,            ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,           ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,            TurbineBoost,RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg         identity_tag
newComponent(     Armor,        Armor,           none,                      11000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                       1600 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                       1600 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg         identity_tag          total internals=            8500
newComponent(     Pelvis,       Pelvis,          none,                        850 ,IDCOM_PELVIS          );                        # 0.10
newComponent(     Head,         Head,            Pelvis,                     1020 ,IDCOM_HEAD            );                        # 0.12
newComponent(     LeftThigh,    LeftThigh,       Pelvis,                      680 ,IDCOM_LEFT_THIGH      );                        # 0.08
newComponent(     RightThigh,   RightThigh,      Pelvis,                      680 ,IDCOM_RIGHT_THIGH     );                        # 0.08
newComponent(     LeftLeg,      LeftLeg,         LeftThigh,                   680 ,IDCOM_LEFT_LEG        );                        # 0.08
newComponent(     RightLeg,     RightLeg,        RighThigh,                   680 ,IDCOM_RIGHT_LEG       );                        # 0.08
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                     595 ,IDCOM_LEFT_CALF       );                        # 0.07
newComponent(     RightCalf,    RightCalf,       RightLeg,                    595 ,IDCOM_RIGHT_CALF      );                        # 0.07
newComponent(     LeftFoot,     LeftFoot,        LeftLeg,                     510 ,IDCOM_LEFT_FOOT       );                        # 0.06
newComponent(     RightFoot,    RightFoot,       RightLeg,                    510 ,IDCOM_RIGHT_FOOT      );                        # 0.06
newComponent(     LeftPod,      LeftPod,         Head,                        850 ,IDCOM_LEFT_POD        );                        # 0.10
newComponent(     RightPod,     RightPod,        Head,                        850 ,IDCOM_RIGHT_POD       );                        # 0.10
newComponent(     Pilot,        Pilot,           none,                        300 ,IDCOM_PILOT           );
#                                                (totals)                      8500                                                # 1.00


#                 Distribution  of               internal          components      among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                               # 660
newConfiguration( Armor,        RightFoot,                     0.06);                               # 660
newConfiguration( Armor,        LeftCalf,                      0.07);                               # 770
newConfiguration( Armor,        RightCalf,                     0.07);                               # 770
newConfiguration( Armor,        LeftLeg,                       0.08);                               # 880
newConfiguration( Armor,        RightLeg,                      0.08);                               # 880
newConfiguration( Armor,        LeftThigh,                     0.08);                               # 880
newConfiguration( Armor,        RightThigh,                    0.08);                               # 880
newConfiguration( Armor,        LeftPod,                       0.10);                              # 1100
newConfiguration( Armor,        RightPod,                      0.10);                              # 1100
newConfiguration( Armor,        Pelvis,                        0.10);                              # 1100
newConfiguration( Armor,        Head,                          0.12);                              # 1320
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

defaultWeapons(   104,          142,             121,                           121);
defaultMountables(139,          229,             806,              331,            927,                  432,            865,                   813);
t