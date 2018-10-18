######################################################################
# datFlyer_tr_carg.cs
# Terran Cargo ship
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_TR_CARG, "CARG",	"tr_carg.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	(all_m/s)							
flyerPos(	275.0 ,	0.5,	40.00 ,	-100.00 ,	70.00 ,	0.15 );

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	10.00 ,	10.00 ,	5.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#	ExhaustShapeT ExhaustShapeNT	Number_of_sources
flyerExhaust( "fx_carg_exh_t.dts"	,	"fx_carg_exh.dts" ,	4 );

#
flyerAI ( "" );

#
# maxLean maxBank taxiRange shortRange mediumRange
flyerNav( 0.15, 0.25,	800,	1600,	2400 );

#flyerSound(startup,shutdown,fly,damagedFly);
flyerSound(IDSFX_FLYER_ON, IDSFX_FLYER_OFF, IDSFX_FLYER_ENGINE, IDSFX_FLYER_DAMAGED );

#		Hard Points										
#		(sizes:SMLX	sides:TBLR)	Dmg	Offset_fm_Node			X_rot_rnge		Z_rot_rnge		
#	id	size	side	Prnt	X___	Y___	Z___	min__	max_	min__	max__	
#newHardPoint(	0,	M,	R, Left_WingA,	 2.5,	2.3,	-0.8,	-10.0,	10.0,	-10.0,	10	);
#hardPointSpecial(	10 );
#newHardPoint(	1,	M,	L,	Right_WingA,-2.5,	2.3,	-0.8,	-10.0,	10.0,	-10.0,	10	);
#hardPointSpecial(	11 );

#	id	size	Dmg_Parent	Allowed_Mountables								
newMountPoint(	0,	L,	FlyerBody,	Engine);								
newMountPoint(	1,	M,	FlyerBody,	Reactor);								
newMountPoint(	2,	M,	FlyerBody,	Computer);								
newMountPoint(	3,	S,	FlyerBody,	Armor);								
newMountPoint(	4,	S,	FlyerBody,	ECM,	Sensors);						
newMountPoint(	5,	M,	FlyerBody,	thermalDiffuser	,	Sensors);						

#	Internal	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	Armor,	Armor,	none,	5000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	1000.0,	IDCOM_BODY	);						
newComponent(  LeftEngine1, LeftEngine1, FlyerBody, 500.0,  IDCOM_LEFT_ENGINE );
newComponent(  LeftEngine2, LeftEngine2, FlyerBody, 500.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine1, RightEngine1, FlyerBody, 500.0,  IDCOM_RIGHT_ENGINE );
newComponent(  RightEngine2, RightEngine2, FlyerBody, 500.0,  IDCOM_RIGHT_ENGINE );
newComponent(  FlyerLeftFoot1, FlyerLeftFoot1, FlyerBody, 500.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerLeftFoot2, FlyerLeftFoot2, FlyerBody, 500.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerRightFoot1, FlyerRightFoot1, FlyerBody, 500.0, IDCOM_LEFT_FOOT );
newComponent(  FlyerRightFoot2, FlyerRightFoot2, FlyerBody, 500.0, IDCOM_LEFT_FOOT );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration(	Armor,	FlyerBody,	0.4	);								
newConfiguration( Armor,	LeftEngine1,	0.15	);
newConfiguration( Armor,	RightEngine1,	0.15	);
newConfiguration( Armor,	LeftEngine2,	0.15	);
newConfiguration( Armor,	RightEngine2,	0.15	);
#	-----											
#	1											

defaultMountables(	102 ,	200,	0,	926,	0	);			

droneExplosion( true, 25 );				

