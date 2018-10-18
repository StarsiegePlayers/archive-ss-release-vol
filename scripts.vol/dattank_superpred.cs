######################################################################													
# datTank_SuperPred.cs													
# Harabec's Predator													
#													
######################################################################													
vehiclePilotable(false);													
#	Identity_Tag	Abbreviation	Shape	Mass	MaxMass	RCS	Tech_Level	Combat_Value					
tankBase(	IDVEH_HA_SUPER_PRED,	"SPRED",	"ha_pred.dts",	1.00 ,	80.00 ,	0.10 ,	127,	6000	);				
													
#	maxPosAcc	minPosVel	maxForPosVel	maxRevPosVel	(all_m/s)								
tankPos(	30.00 ,	3.00 ,	36.00 ,	-30.60	);								
													
#	minRotVel	maxRVSlow	maxRVFast	maxRVTurret	(all_deg/s)								
tankRot(	6.00 ,	90.00 ,	55.00 ,	90.00	);								
													
#	offsetX	offsetY	offsetZ										
tankCpit(	0.0,	0.0,	0	);									
													
#	sphOffstX	sphOffstY	sphOffstZ	sphereRad									
tankColl(	0.0,	0.0,	2.9,	3	);								
													
#	TreadAnim_Rot_Coeff	Tread_Anim_Pos_Coeff											
tankAnim(	2.0,	0.5	);										
													
#	engine_sound_tag	has_thrusters											
tankSound(	IDSFX_TANK_ENGINE_4,	TRUE	);										
													
#	slide_coeff,	1	=	no	slide	(normal	tank),	0	=	pure	slide	(hovercraft)	
tankSlide(	0.5	);											
													
#	fireBayesNetName												
tankAI(	"tankFire.ai",	 "targetPart.ai",	"tankManeuver.ai",	"tankRetreat.ai"	);								
													
#		Hard Points											
#		(sizes:SMLX	sides:TBLR)	Dmg	Offset_fm_Node			X_rot_rnge		Z_rot_rnge			
#	id	size	side	Prnt	X___	Y___	Z___	min__	max_	min__	max__		
newHardPoint(	0,	X,	T,	TankHead,	-1.5,	-0.25,	0.75,	-25.0,	45.0,	-60.0,	60	);	
HardPointDamage(	5000	);											
HardPointSpecial(	21	);											
newHardPoint(	1,	X,	T,	TankHead,	1.5,	-0.25,	0.75,	-25.0,	45.0,	-60.0,	60	);	
HardPointDamage(	5000	);											
HardPointSpecial(	21	);											
													
													
#	id	size	Dmg_Parent	Allowed_Mountables									
newMountPoint(	0,	X,	Body,	Engine);									
newMountPoint(	1,	X,	Body,	Reactor);									
newMountPoint(	2,	X,	TankHead,	Computer);									
newMountPoint(	3,	X,	none,	Armor);									
newMountPoint(	4,	X,	TankHead,	Sensors);									
newMountPoint(	5,	X,	TankHead,	Shield);									
													
newMountPoint(	6,	X,	Body,	ElectroHull,	ThermalDiffuser,	LaserTargeting,	NanoRepair,	Battery,	Cloak,	FieldStabilizer,			
				LifeSupport,	Capacitor,	AgravGenerator,	TurbineBoost,	RocketBooster,	ECM,	ammoPack		);	
newMountPoint(	7,	X,	Body,	ElectroHull,	ThermalDiffuser,	LaserTargeting,	NanoRepair,	Battery,	Cloak,	FieldStabilizer,			
				LifeSupport,	Capacitor,	AgravGenerator,	TurbineBoost,	RocketBooster,	ECM,	ammoPack		);	
#	Internal	Components											
#	id	type	parent	max_dmg	identity_tag								
newComponent(	Armor,	Armor,	none,	18000 ,	IDCOM_ARMOR	);							
newComponent(	LeftServos,	LeftServos,	none,	2000 ,	IDCOM_LEFT_TREAD_SERVOS	);							
newComponent(	RightServos,	RightServos,	none,	2000 ,	IDCOM_RIGHT_TREAD_SERVOS	);							
													
#	External	Components											
#	id	type	parent	max_dmg	identity_tag	total internals =	12000						
newComponent(	Body,	Body,	none,	3120 ,	IDCOM_BODY	);	# 0.26						
newComponent(	TankHead,	TankHead,	Body,	2400 ,	IDCOM_HEAD	);	# 0.20						
newComponent(	LeftTread,	LeftTread,	Body,	3240 ,	IDCOM_LEFT_TREAD	);	# 0.27						
newComponent(	RightTread,	RightTread,	Body,	3240 ,	IDCOM_RIGHT_TREAD	);	# 0.27						
newComponent(	Pilot,	Pilot,	none,	300 ,	IDCOM_PILOT	);							
#			(totals)	12000			1.00						
													
#	Distribution	of	internal	components	among	external	components						
#	containee	container	percent/100										
newConfiguration(	Armor,	Body,	0.26	);	# 4680								
newConfiguration(	Armor,	TankHead,	0.20	);	# 3600								
newConfiguration(	Armor,	LeftTread,	0.27	);	# 4860								
newConfiguration(	Armor,	RightTread,	0.27	);	# 4860								
#	-----												
#			1.00										
													
newConfiguration(	LeftServos,	LeftTread,	1.00	);									
newConfiguration(	RightServos,	RightTread,	1.00	);									
													
defaultWeapons(	113,	113	);						
defaultMountables(	112,	205,	802,	931,	410,	333,	820,	813	);

