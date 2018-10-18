######################################################################
# datFlyer_tr_drop.cs
# Terran Drop ship
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_TR_DROP, "DROP",	"tr_drop.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	(all_m/s)							
flyerPos(	275.0 ,	0.5,	40.00 ,	-100.00 ,	70.00 ,	0.25 );

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	20.00 ,	20.00 ,	10.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#	ExhaustShapeT ExhaustShapeNT	Number_of_sources
flyerExhaust( "fx_carg_exh_t.dts"	,	"fx_carg_exh.dts" ,	2 );

#
flyerAI ( "" );

#
# maxLean maxBank taxiRange shortRange mediumRange
flyerNav( 0.25, 0.35,	400,	800,	1600 );

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
newComponent(	Armor,	Armor,	none,	6000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	1500.0,	IDCOM_BODY	);						
newComponent(  FlyerHead, FlyerHead, FlyerBody, 1000.0, IDCOM_HEAD );
newComponent(  LeftEngine1, LeftEngine1, RightWing1, 500.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine1, RightEngine1, RightWing1, 500.0,  IDCOM_RIGHT_ENGINE );
newComponent(  LeftWing1, LeftWing1, Tail, 300.0, IDCOM_LEFT_WING );
newComponent(  RightWing1, RightWing1, FlyerBody, 2500.0, IDCOM_RIGHT_WING );
newComponent(  Tail, Tail, FlyerBody, 300.0, IDCOM_TAIL );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration(	Armor,	FlyerBody,	0.3	);								
newConfiguration( Armor,	FlyerHead,	0.3	);
newConfiguration( Armor,	LeftEngine1,	0.2	);
newConfiguration( Armor,	RightEngine1,	0.2	);
#	-----											
#	1											

defaultMountables(	102 ,	200,	0,	926,	811	,	820	);		

droneExplosion( true, 25 );					

