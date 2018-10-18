######################################################################
# datHerc_mg_shep.cs
# Cybrid Metagen Shepherd
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass            MaxMass               Radar_Cross_SectTech_Level      Combat_Value
hercBase(         IDVEH_MG_SHEP,"SHEP",          "mg_shep.dts",               8.0 ,                  48 ,          1.00 ,             2 ,      1810);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
hercPos(                 15.50 ,           3.00 ,           32.00 ,          -15.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          70.00 ,             30.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          10.0,            20.0,                           36);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          0.4,                            0.6);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             3.9,                             4);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai");

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                        X_rot_rnge      Z_rot_rnge
#                 id            size             side              Prnt            X___                  Y___            Z___            min__     max_  min__           max__
newHardPoint(     0,            M,               R,                RightPod,       3.245,                -0.94,          1.0,            -55.0,    45.0, -55.0,          55);
newHardPoint(     1,            M,               L,                LeftPod,        -3.245,               -0.94,          1.0,            -55.0,    45.0, -55.0,          55);
newHardPoint(     2,            M,               R,                Head,           1.9,                  -1.5,           -1.4,           -55.0,    45.0, -55.0,          55);
newHardPoint(     3,            M,               L,                Head,           -1.9,                 -1.5,           -1.4,           -55.0,    45.0, -55.0,          55);
#
#
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            L,               Head,             Engine);
newMountPoint(    1,            M,               Head,             Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            L,               LeftPod,          Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            M,               RightPod,         Sensors         );
newMountPoint(    6,            M,               LeftPod,          ECM,            ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,          ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,           TurbineBoost,RocketBooster);
newMountPoint(    7,            L,               RightPod,         ECM,            ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,  Cloak,FieldStabilizer,          ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,      AgravGenerator,           TurbineBoost,RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg         identity_tag
newComponent(     Armor,        Armor,           none,                       5000 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                        600 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                        600 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg         identity_tag          total internals=            4000
newComponent(     Head,         Head,            none,                        560 ,IDCOM_HEAD            );                        # 0.14
newComponent(     LeftLeg,      LeftLeg,         Head,                        400 ,IDCOM_LEFT_LEG        );                        # 0.10
newComponent(     RightLeg,     RightLeg,        Head,                        400 ,IDCOM_RIGHT_LEG       );                        # 0.10
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                     400 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                    400 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftCalf,                    440 ,IDCOM_LEFT_FOOT       );                        # 0.11
newComponent(     RightFoot,    RightFoot,       RightCalf,                   440 ,IDCOM_RIGHT_FOOT      );                        # 0.11
newComponent(     LeftPod,      LeftPod,         Head,                        480 ,IDCOM_LEFT_POD        );                        # 0.12
newComponent(     RightPod,     RightPod,        Head,                        480 ,IDCOM_RIGHT_POD       );                        # 0.12
newComponent(     Pilot,        Pilot,           none,                        300 ,IDCOM_PILOT           );
#                                                (totals)                    4000 ,                                                # 1.00

#                 Distribution  of               internal          components      among                 external        components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                       0.1);                               # 500
newConfiguration( Armor,        RightFoot,                      0.1);                               # 500
newConfiguration( Armor,        LeftCalf,                      0.11);                               # 550
newConfiguration( Armor,        RightCalf,                     0.11);                               # 550
newConfiguration( Armor,        LeftLeg,                       0.11);                               # 550
newConfiguration( Armor,        RightLeg,                      0.11);                               # 550
newConfiguration( Armor,        LeftPod,                       0.13);                               # 650
newConfiguration( Armor,        RightPod,                      0.13);                               # 650
newConfiguration( Armor,        Head,                           0.1);                               # 500
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);


defaultWeapons(   111,          111,             118,                           118);
defaultMountables(137,          229,             806,              332,            928,                  433,            865,                   840);
R