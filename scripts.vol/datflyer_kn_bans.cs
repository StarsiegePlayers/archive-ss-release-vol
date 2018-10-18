######################################################################
# datFlyer_kn_bans.cs
# Knights Banshee
#
######################################################################

#	Identity_Tag	Abbreviation   Shape	Mass	MaxMass	Radar_Cross_Section	Tech_Level	Combat_Value					
flyerBase(	IDVEH_KN_BANS, "BANS",	"kn_bans.dts" ,	20.00 ,	65.00 ,	0.90 ,	2 ,	1485	);

#	maxPosAcc	thrustMultiple	maxLiftVel	maxFallVel	maxFlyVel	fastLean	(all_m/s)							
flyerPos(	100.0 ,	0.3	,	40.00 ,	-100.00 ,	55.00 ,	0.4	);							

#	maxRotXVel	maxRotYVel	maxRotZVel
flyerRot(	25.00 ,	35.00 ,	30.00 );							

#	offsetX	offsetY	offsetZ									
flyerCpit(	0.0,	0.0,	0	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
flyerColl(	0.0,	0.0,	0.0,	3	);							

#	ExhaustShapeT ExhaustShapeNT	Number_of_sources
flyerExhaust( "fx_bans_exh.dts" , "fx_bans_exhT.dts" ,	2 );

#flyerSound(startup,shutdown,fly,damagedFly);
flyerSound(IDSFX_FLYER_ON, IDSFX_FLYER_OFF, IDSFX_FLYER_ENGINE, IDSFX_FLYER_DAMAGED );

#
flyerAI ( "" );

# maxLean maxBank taxiRange shortRange mediumRange
flyerNav ( 0.4,	0.4,	150,	400,	800	);

#		Hard Points										
#		(sizes:SMLX	sides:TBLR)	Dmg	Offset_fm_Node			X_rot_rnge		Z_rot_rnge		
#	id	size	side	Prnt	X___	Y___	Z___	min__	max_	min__	max__	
newHardPoint(	0,	M,	R, Left_WingA,	 2.5,	2.3,	-0.8,	-10.0,	10.0,	-10.0,	10	);
hardPointSpecial(	10 );
newHardPoint(	1,	M,	L,	Right_WingA,-2.5,	2.3,	-0.8,	-10.0,	10.0,	-10.0,	10	);
hardPointSpecial(	11 );

#	id	size	Dmg_Parent	Allowed_Mountables								
newMountPoint(	0,	L,	FlyerBody,	Engine);								
newMountPoint(	1,	M,	FlyerBody,	Reactor);								
newMountPoint(	2,	M,	FlyerBody,	Computer);								
newMountPoint(	3,	S,	FlyerBody,	Armor);	
newMountPoint(	4,	S,	FlyerBody,	Cloak,	ECM,	Sensors	);						
newMountPoint(	5,	M,	FlyerBody,	Cloak,	ECM,	thermalDiffuser	);	


#	Internal	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	Armor,	Armor,	none,	4000 ,	IDCOM_ARMOR	);						

#	External	Components										
#	id	type	parent	max_dmg	identity_tag							
newComponent(	FlyerBody,	FlyerBody,	none,	500.0,	IDCOM_BODY	);						
newComponent(	FlyerHead,	FlyerHead,	FlyerBody,	500.0,	IDCOM_HEAD	);						
newComponent(	LeftWing1,	LeftWing1,	FlyerBody,	200.0,	IDCOM_LEFT_WING	);						
newComponent(	RightWing1,	RightWing1,	FlyerBody,	200.0,	IDCOM_RIGHT_WING	);						
newComponent(	LeftWing2,	LeftWing2,	FlyerBody,	200.0,	IDCOM_LEFT_WING	);						
newComponent(	RightWing2,	RightWing2,	FlyerBody,	200.0,	IDCOM_RIGHT_WING	);						
newComponent(  LeftEngine1, LeftEngine1, FlyerBody, 400.0,  IDCOM_LEFT_ENGINE );
newComponent(  RightEngine1, RightEngine1, FlyerBody, 400.0,  IDCOM_RIGHT_ENGINE );
newComponent(  Tail, Tail, FlyerBody, 200.0, IDCOM_TAIL );

#	Distribution	of	internal	components	among	external	components					
#	containee	container	percent/100									
newConfiguration( Armor,	FlyerBody,	0.3	);								
newConfiguration( Armor,	FlyerHead,	0.2	);								
newConfiguration( Armor,	LeftWing1,	0.1	);
newConfiguration( Armor,	RightWing1,	0.1	);
newConfiguration( Armor,	LeftWing2,	0.1	);
newConfiguration( Armor,	RightWing2,	0.1	);
newConfiguration( Armor,	LeftEngine1,	0.033	);
newConfiguration( Armor,	RightEngine1,	0.033	);
newConfiguration( Armor,	Tail,		0.033	);
#	-----											
#	1											

defaultWeapons(	127,	127 );										
defaultMountables(	101 ,	200,	0,	926,	811	);			

droneExplosion( true, 25 );				

