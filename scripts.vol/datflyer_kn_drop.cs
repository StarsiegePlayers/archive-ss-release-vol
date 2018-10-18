######################################################################
# datFlyer_kn_drop.cs
# Knight's Drop ship
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_KN_DROP, "DROP",	"kn_drop.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	(all_m/s)							
flyerPos(	275.0 ,	0.5,	40.00 ,	-100.00 ,	70.00 ,	0.25 );

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	30.00 ,	30.00 ,	15.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#	ExhaustShapeT ExhaustShapeNT	Number_of_sources
flyerExhaust( "fx_drop_exht.dts"	,	"fx_drop_exh.dts" ,	2 );

#
flyerAI ( "" );

#
# maxLean maxBank taxiRange shortRange mediumRange
flyerNav( 0.25, 0.30,	300,	700,	1500 );

#flyerSound(startup,shutdown,fly,damagedFly);
flyerSound(IDSFX_FLYER_ON, IDSFX_FLYER_OFF, IDSFX_FLYER_ENGINE, IDSFX_FLYER_DAMAGED );

#	id	size	Dmg_Parent	Allowed_Mountables								
newMountPoint(	0,	L,	FlyerBody,	Engine);								
newMountPoint(	1,	M,	FlyerBody,	Reactor);								
newMountPoint(	2,	M,	FlyerBody,	Computer);								
newMountPoint(	3,	S,	FlyerBody,	Armor);								
newMountPoint(	4,	S,	FlyerBody,	ECM	);						
newMountPoint(	5,	M,	FlyerBody,	ECM,	thermalDiffuser	,	Sensors);						

#	Internal	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	Armor,	Armor,	none,	8000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	1000.0,	IDCOM_BODY	);						
newComponent(  LeftEngine1, LeftEngine1, RightWing1, 600.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine1, RightEngine1, RightWing1, 600.0,  IDCOM_RIGHT_ENGINE );
newComponent(  LeftWing1, LeftWing1, Tail, 300.0, IDCOM_LEFT_WING );
newComponent(  RightWing1, RightWing1, FlyerBody, 3000.0, IDCOM_RIGHT_WING );
newComponent(  FlyerHead, FlyerHead, FlyerBody, 800.0, IDCOM_HEAD );
newComponent(  Tail, Tail, FlyerBody, 400.0, IDCOM_TAIL );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration(	Armor,	FlyerBody,	0.25	);								
newConfiguration( Armor,	LeftEngine1,	0.1	);
newConfiguration( Armor,	RightEngine1,	0.1	);
newConfiguration( Armor,	LeftWing1,	0.1	);
newConfiguration( Armor,	RightWing1,	0.1	);
newConfiguration( Armor,	FlyerHead,	0.25	);
newConfiguration( Armor,	Tail,	0.1	);
#	-----											
#	1											

defaultMountables(	102 ,	200,	0,	926,	811	,	820	);	

droneExplosion( true, 25 );						

