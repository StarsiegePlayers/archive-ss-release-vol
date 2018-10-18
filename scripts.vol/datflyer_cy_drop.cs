######################################################################
# datFlyer_cy_drop.cs
# Cybrid Drop ship
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_CY_DROP, "DROP",	"cy_drop.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	(all_m/s)							
flyerPos(	275.0 ,	0.5,	40.00 ,	-100.00 ,	70.00 ,	0.25 );

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	30.00 ,	30.00 ,	15.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#	ExhaustShapeT ExhaustShapeNT	Number_of_sources
flyerExhaust( "fx_cydrop_exht.dts"	,	"fx_cydrop_exh.dts" ,	4 );

#
flyerAI ( "" );

#
# maxLean maxBank taxiRange shortRange mediumRange
flyerNav( 0.25, 0.35,	200,	500,	800 );

#flyerSound(startup,shutdown,fly,damagedFly);
flyerSound(IDSFX_FLYER_ON, IDSFX_FLYER_OFF, IDSFX_FLYER_ENGINE, IDSFX_FLYER_DAMAGED );

#	id	size	Dmg_Parent	Allowed_Mountables								
newMountPoint(	0,	L,	FlyerBody,	Engine);								
newMountPoint(	1,	M,	FlyerBody,	Reactor);								
newMountPoint(	2,	M,	FlyerBody,	Computer);								
newMountPoint(	3,	S,	FlyerBody,	Armor);								
newMountPoint(	4,	S,	FlyerBody,	ECM,	Sensors);						
newMountPoint(	5,	M,	FlyerBody,	ECM,	thermalDiffuser, Sensors);						

#	Internal	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	Armor,	Armor,	none,	30000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	1500.0,	IDCOM_BODY	);						
newComponent(  LeftEngine1, LeftEngine1, FlyerBody, 500.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine1, RightEngine1, FlyerBody, 500.0,  IDCOM_RIGHT_ENGINE );
newComponent(  LeftEngine2, LeftEngine2, FlyerBody, 500.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine2, RightEngine2, FlyerBody, 500.0,  IDCOM_RIGHT_ENGINE );
newComponent(  FlyerLeftFoot1, FlyerLeftFoot1, FlyerBody, 500.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerRightFoot1, FlyerRightFoot1, FlyerBody, 500.0, IDCOM_RIGHT_FOOT );
newComponent(  FlyerLeftFoot2, FlyerLeftFoot2, FlyerBody, 500.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerRightFoot2, FlyerRightFoot2, FlyerBody, 500.0, IDCOM_RIGHT_FOOT );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration(	Armor,	FlyerBody,	0.111	);								
newConfiguration( Armor,	LeftEngine1,	0.111	);
newConfiguration( Armor,	RightEngine1,	0.111	);
newConfiguration( Armor,	LeftEngine2,	0.111	);
newConfiguration( Armor,	RightEngine2,	0.111	);
newConfiguration( Armor,	FlyerLeftFoot1,	0.111	);
newConfiguration( Armor,	FlyerRightFoot1,	0.111	);
newConfiguration( Armor,	FlyerLeftFoot2,	0.111	);
newConfiguration( Armor,	FlyerRightFoot2,	0.111	);
#	-----											
#	1											

defaultMountables(	102 ,	200,	0,	926,	813,	820);			

droneExplosion( true, 25 );				
u	