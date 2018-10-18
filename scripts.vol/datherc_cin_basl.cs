######################################################################									
# datHerc_cin_basl.cs									
# Caanon's Basilisk (Knight Basilisk--Cinematic Version)							
#									
######################################################################									
vehiclePilotable(false);

#	Identity_Tag	Abbreviation 	Shape	Mass	MaxMass	RCS	Tech_Level	Combat_Value	
hercBase(	IDVEH_CIN_MINO,	BASL,	"cin_basl.dts",	1.0 ,	60.0 ,	1.00 ,	4 ,	6600	);

#	maxPosAcc	minPosVel	maxForPosVel	maxRevPosVel	(all_m/s)				
hercPos(	14.00 ,	3.00 ,	30.00 ,	-12	);				

#	minRotVel	maxRVSlow	maxRVFast	(all_deg/s)					
hercRot(	6.00 ,	75.00 ,	30.00	);					

#	toStandVel	toRunVel	toFastRunVel	toFastTurnVel(deg/s)					
hercAnim(	4.0,	14.0,	28.0,	30	);							

#	offsetX	offsetY	offsetZ									
hercCpit(	0.0,	-0.1,	-0.94	);								

#	sphOffstX	sphOffstY	sphOffstZ	sphereRad								
hercColl(	0.0,	0.0,	2.9,	3	);							

#	fireBayesNetName											
hercAI(  	"hercFire.ai",	 "targetPart.ai",	"hercManeuver.ai",	"hercRetreat.ai"	);							
#
translucentCockpit();
#
#	Hard Points											
#	(sizes:SMLX	sides:TBLR)	Dmg	Offset_fm_Node	X_rot_rnge	Z_rot_rnge						
#	id	size	side	Prnt	X___	Y___	Z___	min__	max_	min__	max__	
newHardPoint(	0,	S,	T,	RightPod,	2.295,	-1.275,	2.0,	-25.0,	60.0,	-60.0,	60	);
newHardPoint(	1,	S,	T,	LeftPod,	-2.295,	-1.275,	2.0,	-25.0,	60.0,	-60.0,	60	);
newHardPoint(	2,	X,	R,	Head,	3.225,	-1.115,	-0.1,	-60.0,	15.0,	-60.0,	30	);			
newHardPoint(	3,	X,	L,	Head,	-3.225,	-1.115,	-0.1,	-60.0,	15.0,	-30.0,	60	);			
#															
#															
#															
#															
#															
#	id	size	Dmg_Parent	Allowed_Mountables											
newMountPoint(	0,	X,	Pelvis,	Engine);											
newMountPoint(	1,	L,	Pelvis,	Reactor);											
newMountPoint(	2,	L,	Head,	Computer);											
newMountPoint(	3,	L,	LeftPod,	Shield);											
newMountPoint(	4,	L,	none,	Armor);											
newMountPoint(	5,	L,	RightPod,	Sensors	);										
newMountPoint(	6,	L,	RightPod,	ShieldModulator, ShieldCapacitor, ShieldAmplifier, NanoRepair, Cloak, ECM, ThermalDiffuser,	LaserTargeting,	Capacitor, Battery, LifeSupport, TurbineBoost, RocketBooster	);
newMountPoint(	7,	L,	LeftPod,	ShieldModulator, ShieldCapacitor, ShieldAmplifier, NanoRepair, Cloak, ECM, ThermalDiffuser,	LaserTargeting,	Capacitor, Battery, LifeSupport, TurbineBoost, RocketBooster	);


#	Internal	Components					
#	id	type	parent	max_dmg	identity_tag		
newComponent(	Armor,	Armor,	none,	10000 ,	IDCOM_ARMOR	);	
newComponent(	LeftServos,	LeftServos,	none,	2000 ,	IDCOM_LEFT_LEG_SERVOS	);	
newComponent(	RightServos,	RightServos,	none,	2000 ,	IDCOM_RIGHT_LEG_SERVOS	);	

#	External	Components					
#	id	type	parent	max_dmg	identity_tag	total internals =	3000
newComponent(	Pelvis,	Pelvis,	none,	860 ,	IDCOM_PELVIS	);	# 0.12
newComponent(	Head,	Head,	Pelvis,	920 ,	IDCOM_HEAD	);	# 0.14
newComponent(	LeftLeg,	LeftLeg,	Pelvis,	770 ,	IDCOM_LEFT_LEG	);	# 0.09
newComponent(	RightLeg,	RightLeg,	Pelvis,	770 ,	IDCOM_RIGHT_LEG	);	# 0.09
newComponent(	LeftCalf,	LeftCalf,	LeftLeg,	800 ,	IDCOM_LEFT_CALF	);	# 0.10
newComponent(	RightCalf,	RightCalf,	RightLeg,	800 ,	IDCOM_RIGHT_CALF	);	# 0.10
newComponent(	LeftFoot,	LeftFoot,	LeftLeg,	710 ,	IDCOM_LEFT_FOOT	);	# 0.07
newComponent(	RightFoot,	RightFoot,	RightLeg,	710 ,	IDCOM_RIGHT_FOOT	);	# 0.07
newComponent(	LeftPod,	LeftPod,	Head,	830 ,	IDCOM_LEFT_POD	);	# 0.11
newComponent(	RightPod,	RightPod,	Head,	830 ,	IDCOM_RIGHT_POD	);	# 0.11
newComponent(	Pilot,	Pilot,	none,	10000 ,	IDCOM_PILOT	);	
#			(totals)	3000			# 1.00

#	Distribution	of	internal	components	among external	components	
#	containee	container	percent/100				
newConfiguration(	Armor,	LeftFoot,	0.06	);	# 270		
newConfiguration(	Armor,	RightFoot,	0.06	);	# 270		
newConfiguration(	Armor,	LeftCalf,	0.09	);	# 405		
newConfiguration(	Armor,	RightCalf,	0.09	);	# 405		
newConfiguration(	Armor,	LeftLeg,	0.12	);	# 540		
newConfiguration(	Armor,	RightLeg,	0.12	);	# 540		
newConfiguration(	Armor,	Pelvis,	0.15	);	# 675		
newConfiguration(	Armor,	Head,	0.13	);	# 585				
newConfiguration(	Armor,	LeftPod,	0.09	);	# 405				
newConfiguration(	Armor,	RightPod,	0.09	);	# 405				
#	-----								
#			1.00						
									
newConfiguration(	LeftServos,	LeftFoot,	0.3	);					
newConfiguration(	LeftServos,	LeftCalf,	0.35	);					
newConfiguration(	LeftServos,	LeftLeg,	0.35	);					
									
newConfiguration(	RightServos,	RightFoot,	0.3	);					
newConfiguration(	RightServos,	RightCalf,	0.35	);					
newConfiguration(	RightServos,	RightLeg,	0.35	);					
									
defaultWeapons(	103,	103,	117,	117	);				
defaultMountables(	108,	205,	800,	307,	931,	413,	850,	890	);
¼