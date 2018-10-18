######################################################################
# datFlyer_tr_escape.cs
# Terran Escape ship
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_TR_ESCAPE, "ESCAPE",	"tr_escape.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	(all_m/s)							
flyerPos(	275.0 ,	0.5	,	40.00 ,	-100.00 ,	70.00 ,	0.15 );

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	10.00 ,	10.00 ,	5.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#	ExhaustShapeT	ExhaustShapeNT	Number_of_sources
flyerExhaust( "fx_escape_exh_t.dts" ,	"fx_escape_exh.dts" ,	4 );

#
flyerAI ( "" );

# maxLean maxBank taxiRange shortRange mediumRange
flyerNav ( 0.15	,	0.15,	800,	1600,	2400	);

#flyerSound(startup,shutdown,fly,damagedFly);
flyerSound(IDSFX_FLYER_ON, IDSFX_FLYER_OFF, IDSFX_FLYER_ENGINE, IDSFX_FLYER_DAMAGED );

#	id	size	Dmg_Parent	Allowed_Mountables								
newMountPoint(	0,	L,	FlyerBody,	Engine);								
newMountPoint(	1,	M,	FlyerBody,	Reactor);								
newMountPoint(	2,	M,	FlyerBody,	Computer);								
newMountPoint(	3,	S,	FlyerBody,	Armor);								
newMountPoint(	4,	S,	FlyerBody,	ECM,	Sensors);						
newMountPoint(	5,	M,	FlyerBody,	thermalDiffuser ,	Sensors);						

#	Internal	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	Armor,	Armor,	none,	2000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	1000.0,	IDCOM_BODY	);						
newComponent(  FlyerLeftFoot1, FlyerLeftFoot1, FlyerBody, 250.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerLeftFoot2, FlyerLeftFoot2, FlyerBody, 250.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerRightFoot1, FlyerRightFoot1, FlyerBody, 250.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerRightFoot2, FlyerRightFoot2, FlyerBody, 250.0, IDCOM_LEFT_FOOT );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration(	Armor,	FlyerBody,	1.00	);								
#	-----											
#	1											

#defaultWeapons(	127,	127 );										
defaultMountables(	102 ,	200,	0,	926,	811	,	820	);	

droneExplosion( true, 25 );					
b