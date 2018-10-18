######################################################################													
# datHerc_cin_apoc.cs													
# Harabec's Apocalpyse (cinematic version)													
#													
######################################################################													
vehiclePilotable(false);

#													
#	Identity_Tag	Abbreviation	Shape	Mass	MaxMass	RCS	Tech_Level	Combat_Value					
hercBase(	IDVEH_CIN_APOC,	"APOC",	"cin_APOC.dts",	2.0 ,	60 ,	0.85 ,	6 ,	8465	);				
#													
#	maxPosAcc	minPosVel	maxForPosVel	maxRevPosVel	(all_m/s)								
hercPos(	15.00 ,	3.00 ,	30.00 ,	-12.00	);								
#													
#	minRotVel	maxRVSlow	maxRVFast	(all_deg/s)									
hercRot(	6.00 ,	75.00 ,	30.00	);									
#													
#	toStandVel	toRunVel	toFastRunVel	toFastTurnVel(deg/s)									
hercAnim(	4.0,	10.0,	14.0,	30	);								
#													
#	offsetX	offsetY	offsetZ										
hercCpit(	0.0,	1.45,	1.55	);									
#													
#	sphOffstX	sphOffstY	sphOffstZ	sphereRad									
hercColl(	0.0,	0.0,	2.9,	3	);								
#													
#	fireBayesNetName												
hercAI(  	"hercFire.ai",	 "targetPart.ai",	"hercManeuver.ai",	"hercRetreat.ai"	);								
#
translucentCockpit();
#													
#		Hard Points											
#		(sizes:SMLX	sides:TBLR)	Dmg	Offset_fm_Node			X_rot_rnge		Z_rot_rnge			
#	id	size	side	Prnt	X___	Y___	Z___	min__	max_	min__	max__		
newHardPoint(	0,	X,	R,	RightPod,	2.5,	-0.75,	3.70,	-25.0,	60.0,	-60.0,	40	);	
newHardPoint(	1,	X,	L,	LeftPod,	-2.5,	-0.75,	3.70,	-25.0,	60.0,	-40.0,	60	);	
newHardPoint(	2,	M,	R,	RightPod,	2.5,	0.5,	1.90,	-35.0,	60.0,	-60.0,	40	);			
newHardPoint(	3,	M,	L,	LeftPod,	-2.5,	0.5,	1.90,	-35.0,	60.0,	-40.0,	60	);			
newHardPoint(	4,	M,	I,	RightPod,	1.75,	0.0,	4.15,	-45.0 ,	45.0,	-15.0,	15	);			
newHardPoint(	5,	M,	I,	LeftPod,	-1.75,	0.0,	4.15,	-45.0 ,	45.0,	-15.0,	15	);			
#															
#															
#															
#	id	size	Dmg_Parent	Allowed_Mountables											
newMountPoint(	0,	X,	Pelvis,	Engine);											
newMountPoint(	1,	L,	Pelvis,	Reactor);											
newMountPoint(	2,	M,	Head,	Computer);											
newMountPoint(	3,	L,	RightPod,	Shield);											
newMountPoint(	4,	L,	none,	Armor);											
newMountPoint(	5,	M,	LeftPod,	Sensors);											
newMountPoint(	6,	L,	RightPod,	Cloak,	ThermalDiffuser,	LaserTargeting,	NanoRepair,	Battery,	ECM,	FieldStabilizer,			LifeSupport		);
newMountPoint(	7,	L,	LeftPod,	ShieldModulator,	ShieldCapacitor,	ShieldAmplifier,	Capacitor,	AgravGenerator,		TurbineBoost,			RocketBooster		);
													
													
#	Internal	Components											
#	id	type	parent	max_dmg	identity_tag								
newComponent(	Armor,	Armor,	none,	100000 ,	IDCOM_ARMOR	);							
newComponent(	LeftServos,	LeftServos,	none,	450 ,	IDCOM_LEFT_LEG_SERVOS	);							
newComponent(	RightServos,	RightServos,	none,	450 ,	IDCOM_RIGHT_LEG_SERVOS	);							
													
#	External	Components											
#	id	type	parent	max_dmg	identity_tag	total internals =	3250						
newComponent(	Pelvis,	Pelvis,	none,	390 ,	IDCOM_PELVIS	);	# 0.12						
newComponent(	Head,	Head,	Pelvis,	455 ,	IDCOM_HEAD	);	# 0.14						
newComponent(	LeftLeg,	LeftLeg,	Pelvis,	390 ,	IDCOM_LEFT_LEG	);	# 0.12						
newComponent(	RightLeg,	RightLeg,	Pelvis,	390 ,	IDCOM_RIGHT_LEG	);	# 0.12						
newComponent(	LeftCalf,	LeftCalf,	LeftLeg,	293 ,	IDCOM_LEFT_CALF	);	# 0.09						
newComponent(	RightCalf,	RightCalf,	RightLeg,	293 ,	IDCOM_RIGHT_CALF	);	# 0.09						
newComponent(	LeftFoot,	LeftFoot,	LeftLeg,	195 ,	IDCOM_LEFT_FOOT	);	# 0.06						
newComponent(	RightFoot,	RightFoot,	RightLeg,	195 ,	IDCOM_RIGHT_FOOT	);	# 0.06						
newComponent(	LeftPod,	LeftPod,	Head,	325 ,	IDCOM_LEFT_POD	);	# 0.10						
newComponent(	RightPod,	RightPod,	Head,	325 ,	IDCOM_RIGHT_POD	);	# 0.10						
newComponent(	Pilot,	Pilot,	none,	300 ,	IDCOM_PILOT	);							
#			(totals)	3250			1.00						
#													
													
#	Distribution	of	internal	components	among	external	components						
#	containee	container	percent/100										
newConfiguration(	Armor,	LeftFoot,	0.05	);	# 400								
newConfiguration(	Armor,	RightFoot,	0.05	);	# 400								
newConfiguration(	Armor,	LeftCalf,	0.10	);	# 800								
newConfiguration(	Armor,	RightCalf,	0.10	);	# 800								
newConfiguration(	Armor,	LeftLeg,	0.10	);	# 800								
newConfiguration(	Armor,	RightLeg,	0.10	);	# 800								
newConfiguration(	Armor,	Pelvis,	0.12	);	# 960								
newConfiguration(	Armor,	Head,	0.14	);	# 1120								
newConfiguration(	Armor,	LeftPod,	0.12	);	# 960								
newConfiguration(	Armor,	RightPod,	0.12	);	# 960								
#	-----												
#			1.00										
													
newConfiguration(	LeftServos,	LeftFoot,	0.3	);									
newConfiguration(	LeftServos,	LeftCalf,	0.35	);									
newConfiguration(	LeftServos,	LeftLeg,	0.35	);									
													
newConfiguration(	RightServos,	RightFoot,	0.3	);									
newConfiguration(	RightServos,	RightCalf,	0.35	);									
newConfiguration(	RightServos,	RightLeg,	0.35	);									
													
defaultWeapons(	113,	107,	117,	117	);								
defaultMountables(	113,	204,	800,	307,	931,	401,	830,	910	);				
													
c