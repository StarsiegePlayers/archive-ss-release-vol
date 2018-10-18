######################################################################
# datHerc_pi_eman.cs
# Pirate Emancipator
#
######################################################################
#vehiclePilotable(false);
#                 Identity_Tag  Abbreviation     Shape             Mass            MaxMass               RCS              Tech_Level      Combat_Value
hercBase(         IDVEH_PI_EMAN,"EMAN",          "pi_eman.dts",              10.0 ,                  40 ,           0.85 ,             1 ,        1730);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel    (all_m/s)
hercPos(                 13.10 ,           3.00 ,           35.30 ,          -20.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          80.00 ,             45.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          13.0,            18.0,                           36);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          0.6,                            0.2);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             3.9,                             4);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai");

#                 Special Footprint type
hercFootprint(    IDBMP_TR_FOOTPRINT_3           );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg             Offset_fm_Node                                         X_rot_rnge        Z_rot_rnge
#                 id            size             side              Prnt            X___                  Y___             Z___            min__       max_  min__           max__
newHardPoint(     0,            X,               T,                Head,           0.0,                  0.01,            2.2,            -25.0,      60.0, -60.0,          60);
newHardPoint(     1,            M,               B,                Head,           0.0,                  1.7,             -1.65,          -45.0,      35.0, -60.0,          60);




#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            M,               Head,             Engine);
newMountPoint(    1,            L,               Head,             Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            M,               RightPod,         Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            M,               LeftPod,          Sensors         );
newMountPoint(    6,            M,               LeftPod,          ECM,            ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,    ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,     TurbineBoost, RocketBooster);
newMountPoint(    7,            L,               RightPod,         ECM,            ThermalDiffuser,      LaserTargeting,  NanoRepair,     Battery,    Cloak,FieldStabilizer,    ammoPack,
                                                                   LifeSupport,    ShieldModulator,      ShieldCapacitor, ShieldAmplifier,Capacitor,        AgravGenerator,     TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg         identity_tag
newComponent(     Armor,        Armor,           none,                       7500 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                        300 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                        300 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg         identity_tag          total internals =            4500
newComponent(     Head,         Head,            none,                        810 ,IDCOM_HEAD            );                         # 0.18
newComponent(     LeftLeg,      LeftLeg,         Head,                        540 ,IDCOM_LEFT_LEG        );                         # 0.12
newComponent(     RightLeg,     RightLeg,        Head,                        540 ,IDCOM_RIGHT_LEG       );                         # 0.12
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                     495 ,IDCOM_LEFT_CALF       );                         # 0.11
newComponent(     RightCalf,    RightCalf,       RightLeg,                    495 ,IDCOM_RIGHT_CALF      );                         # 0.11
newComponent(     LeftFoot,     LeftFoot,        LeftCalf,                    315 ,IDCOM_LEFT_FOOT       );                         # 0.07
newComponent(     RightFoot,    RightFoot,       RightCalf,                   315 ,IDCOM_RIGHT_FOOT      );                         # 0.07
newComponent(     LeftPod,      LeftPod,         Head,                        495 ,IDCOM_LEFT_POD        );                         # 0.11
newComponent(     RightPod,     RightPod,        Head,                        495 ,IDCOM_RIGHT_POD       );                         # 0.11
newComponent(     Pilot,        Pilot,           none,                        300 ,IDCOM_PILOT           );
#                                                (totals)                    4500 ,                                                   1.00

#                 Distribution  of               internal          components      among                 external         components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.05);                               # 375
newConfiguration( Armor,        RightFoot,                     0.05);                               # 375
newConfiguration( Armor,        LeftCalf,                      0.08);                               # 600
newConfiguration( Armor,        RightCalf,                     0.08);                               # 600
newConfiguration( Armor,        LeftLeg,                       0.09);                               # 675
newConfiguration( Armor,        RightLeg,                      0.09);                               # 675
newConfiguration( Armor,        LeftPod,                       0.10);                               # 750
newConfiguration( Armor,        RightPod,                      0.10);                               # 750
newConfiguration( Armor,        Head,                          0.36);                              # 2700
#                 -----
#                                                              1.00

newConfiguration( LeftServos,   LeftFoot,                       0.3);
newConfiguration( LeftServos,   LeftCalf,                      0.35);
newConfiguration( LeftServos,   LeftLeg,                       0.35);

newConfiguration( RightServos,  RightFoot,                      0.3);
newConfiguration( RightServos,  RightCalf,                     0.35);
newConfiguration( RightServos,  RightLeg,                      0.35);

defaultWeapons(   107,                        107);
defaultMountables(104,          204,             801,              301,            927,                  400,             810,                     860);
d