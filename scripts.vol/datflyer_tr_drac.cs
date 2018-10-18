######################################################################
# datFlyer_tr_drac.cs
# Terrain Draco Bomber
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_TR_DRAC, "DRAC",	"tr_drac.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	(all_m/s)							
flyerPos(	275.0 ,	0.5,	40.00 ,	-100.00 ,	70.00 ,	0.3 );

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	15.00 ,	15.00 ,	10.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#
flyerAI ( "" );

#
# maxLean maxBank taxiRange shortRange mediumRange
flyerNav( 0.30, 0.35,	200,	400,	800 );

#flyerSound(startup,shutdown,fly,damagedFly);
flyerSound(IDSFX_FLYER_ON, IDSFX_FLYER_OFF, IDSFX_FLYER_ENGINE, IDSFX_FLYER_DAMAGED );

#	id	size	Dmg_Parent	Allowed_Mountables								
newMountPoint(	0,	L,	FlyerBody,	Engine);								
newMountPoint(	1,	M,	FlyerBody,	Reactor);								
newMountPoint(	2,	M,	FlyerBody,	Computer);								
newMountPoint(	3,	S,	FlyerBody,	Armor);								
newMountPoint(	4,	S,	FlyerBody,	ECM,	Sensors);						
newMountPoint(	5,	M,	FlyerBody,	thermalDiffuser	,	Sensors);						

#	Internal	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	Armor,	Armor,	none,	2000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	800.0,	IDCOM_BODY	);						
newComponent(  LeftEngine1, LeftEngine1, FlyerBody, 300.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine1, RightEngine1, FlyerBody, 300.0,  IDCOM_RIGHT_ENGINE );
newComponent(  LeftWing1, LeftWing1, FlyerBody, 200.0, IDCOM_LEFT_WING );
newComponent(  RightWing1, RightWing1, FlyerBody, 200.0, IDCOM_RIGHT_WING );
newComponent(  LeftWing2, LeftWing2, FlyerBody, 200.0, IDCOM_LEFT_WING );
newComponent(  RightWing2, RightWing2, FlyerBody, 200.0, IDCOM_RIGHT_WING );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration(	Armor,	FlyerBody,	0.4	);								
newConfiguration( Armor,	LeftEngine1,	0.2	);
newConfiguration( Armor,	RightEngine1,	0.2	);
newConfiguration( Armor,	LeftWing1,	0.05	);
newConfiguration( Armor,	RightWing1,	0.05	);
newConfiguration( Armor,	LeftWing2,	0.05	);
newConfiguration( Armor,	RightWing2,	0.05	);
#	-----											
#	1											

defaultMountables(	102 ,	200,	0,	926,	811	);						

droneExplosion( true, 25 );		