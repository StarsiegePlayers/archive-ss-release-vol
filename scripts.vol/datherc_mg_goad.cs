######################################################################
# datHerc_mg_goad.cs
# Metagen Goad
#
######################################################################

#                 Identity_Tag  Abbreviation     Shape             Mass              MaxMass               RCS             Tech_Level      Combat_Value
hercBase(         IDVEH_MG_GOAD,"GOAD",          "mg_goad.dts",                 8.0 ,                  35 ,          0.85 ,             1 ,           1600);

#                 maxPosAcc     minPosVel        maxForPosVel      maxRevPosVel      (all_m/s)
hercPos(                 20.00 ,           3.00 ,           40.00 ,            -25.00);

#                 minRotVel     maxRVSlow        maxRVFast         (all_deg/s)
hercRot(                  6.00 ,          80.00 ,             50.00);

#                 toStandVel    toRunVel         toFastRunVel      toFastTurnVel(deg/s)
hercAnim(         4.0,          13.0,            25.0,                             36);

#                 offsetX       offsetY          offsetZ
hercCpit(         0.0,          0.50,                         -0.65);

#                 sphOffstX     sphOffstY        sphOffstZ         sphereRad
hercColl(         0.0,          0.0,             2.9,                               3);

#                 fireBayesNetName
hercAI(           "hercFire.ai", "targetPart.ai","hercManeuver.ai","hercRetreat.ai"  );

#                               Hard Points
#                               (sizes:SMLX      sides:TBLR)       Dmg               Offset_fm_Node                                        X_rot_rnge           Z_rot_rnge
#                 id            size             side              Prnt              X___                  Y___            Z___            min__          max_  min__           max__
newHardPoint(     0,            M,               T,                Head,             0.0,                  -0.1,           1.3,            -30.0,         40.0, -60.0,          60);
newHardPoint(     1,            M,               B,                Head,             0.0,                  0.65,           -1.6,           -30.0,         30.0, -60.0,          60);
#
#
#
#
#
#
#
#                 id            size             Dmg_Parent        Allowed_Mountables
newMountPoint(    0,            M,               Head,             Engine);
newMountPoint(    1,            M,               Head,             Reactor);
newMountPoint(    2,            S,               Head,             Computer);
newMountPoint(    3,            M,               Head,             Shield);
newMountPoint(    4,            M,               none,             Armor);
newMountPoint(    5,            M,               Head,             Sensors           );
newMountPoint(    6,            L,               Head,             ECM,              ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,       Cloak,FieldStabilizer,    ammoPack,
                                                                   LifeSupport,      ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,           AgravGenerator,     TurbineBoost, RocketBooster);
newMountPoint(    7,            S,               Head,             ECM,              ThermalDiffuser,      LaserTargeting, NanoRepair,     Battery,       Cloak,FieldStabilizer,    ammoPack,
                                                                   LifeSupport,      ShieldModulator,      ShieldCapacitor,ShieldAmplifier,Capacitor,           AgravGenerator,     TurbineBoost, RocketBooster);
#                 Internal      Components
#                 id            type             parent            max_dmg           identity_tag
newComponent(     Armor,        Armor,           none,                         3200 ,IDCOM_ARMOR           );
newComponent(     LeftServos,   LeftServos,      none,                          600 ,IDCOM_LEFT_LEG_SERVOS );
newComponent(     RightServos,  RightServos,     none,                          600 ,IDCOM_RIGHT_LEG_SERVOS);

#                 External      Components
#                 id            type             parent            max_dmg           identity_tag          Total internals             3000
newComponent(     Head,         Head,            none,                          840 ,IDCOM_HEAD            );                        # 0.28
newComponent(     LeftThigh,    LeftThigh,       Head,                          300 ,IDCOM_LEFT_THIGH      );                        # 0.10
newComponent(     RightThigh,   RightThigh,      Head,                          300 ,IDCOM_RIGHT_THIGH     );                        # 0.10
newComponent(     LeftLeg,      LeftLeg,         LeftThigh,                     270 ,IDCOM_LEFT_LEG        );                        # 0.09
newComponent(     RightLeg,     RightLeg,        RighThigh,                     270 ,IDCOM_RIGHT_LEG       );                        # 0.09
newComponent(     LeftCalf,     LeftCalf,        LeftLeg,                       300 ,IDCOM_LEFT_CALF       );                        # 0.10
newComponent(     RightCalf,    RightCalf,       RightLeg,                      300 ,IDCOM_RIGHT_CALF      );                        # 0.10
newComponent(     LeftFoot,     LeftFoot,        LeftCalf,                      210 ,IDCOM_LEFT_FOOT       );                        # 0.07
newComponent(     RightFoot,    RightFoot,       RightCalf,                     210 ,IDCOM_RIGHT_FOOT      );                        # 0.07
newComponent(     Pilot,        Pilot,           none,                          300 ,IDCOM_PILOT           );
#                                                (totals)                      3000 ,                                                  1.00

#                 Distribution of internal components among external components
#                 containee     container        percent/100
newConfiguration( Armor,        LeftFoot,                      0.06);                                 # 192
newConfiguration( Armor,        RightFoot,                     0.06);                                 # 192
newConfiguration( Armor,        LeftCalf,                      0.09);                                 # 288
newConfiguration( Armor,        RightCalf,                     0.09);                                 # 288
newConfiguration( Armor,        LeftLeg,                       0.11);                                 # 352
newConfiguration( Armor,        RightLeg,                      0.11);                                 # 352
newConfiguration( Armor,        LeftThigh,                     0.12);                                 # 384
newConfiguration( Armor,        RightThigh,                    0.12);                                 # 384
newConfiguration( Armor,        Head,                          0.24);                                 # 768
#                 -----
#

newConfiguration( LeftServos,   LeftFoot,                      0.25);
newConfiguration( LeftServos,   LeftCalf,                      0.25);
newConfiguration( LeftServos,   LeftLeg,                       0.25);
newConfiguration( LeftServos,   LeftThigh,                     0.25);

newConfiguration( RightServos,  RightFoot,                     0.25);
newConfiguration( RightServos,  RightCalf,                     0.25);
newConfiguration( RightServos,  RightLeg,                      0.25);
newConfiguration( RightServos,  RightThigh,                    0.25);

defaultWeapons(	130,	130	);						
defaultMountables(	133,	225,	806,	326,	926,	432,	914,	820	);
ì