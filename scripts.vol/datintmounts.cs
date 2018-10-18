# Miscellaneous Components							
# Component numbers 800-925							
#------------------------------------------------------------------------------							
# Computer Notes							
#newComputer(id, type, zoom, scanRange, leadIndicator, targetLabels, targetClosest, autoTarget);							
#zoom:  0 to 1.  If 0, no zoom.  If 1, current level of zoom.							
#scanRange:  scan range, in meters (identify target range)							
#							
#The other 4 parameters can take either a value of true or false, which enables or disables that feature.  Or it can take a number							
#between 0 and 1, which specifies how damaged the computer can be and still support this feature.  So true is equivalent to 0.0 (feature works							
#until the computer is destroyed) and false is equivalent to 2 (never works).							
#							
							
							
#------------------------------------------------------------------------------							
#Human Basic Computer			newComputer(id,type,zoom, scanRange, leadIndicator, targetLabels,targetClosest,autoTarget);				
#	id	Type	zoom	scanRange	Lead Indicator	targetLabels	targetClosest	autoTarget	
newComputer(	800 ,	Computer,	0.7,	150 ,	f,	f,	f,	f	);

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag		
mountInfo1 (	IDMNT_CMP_HUM1,	IDMNT_CMP_HUM1_L,	"hu_computerS_S.BMP",	"hu_computerS_SD.BMP",	"hu_computerS_L.BMP",	"hu_computerS_LD.BMP",	IDCSPEC_CMP_HUM1	);	

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage			
mountInfo2 (	1 ,	H ,	25 ,	1.0 ,	S ,	400	);		
									

#------------------------------------------------------------------------------									
# Human Improved Computer									
#	id	Type	zoom	scanRange	Lead Indicator	targetLabels	targetClosest	autoTarget	
newComputer(	801 ,	Computer,	1,	300 ,	t,	f,	t,	f	);

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag		
mountInfo1 (	IDMNT_CMP_HUM2,	IDMNT_CMP_HUM2_L,	"hu_computerM_S.BMP",	"hu_computerM_SD.BMP",	"hu_computerM_L.BMP",	"hu_computerM_LD.BMP",	IDCSPEC_CMP_HUM2	);	

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage			
mountInfo2 (	1 ,	H ,	100 ,	1.5 ,	S ,	450	);		
									
									
#------------------------------------------------------------------------------									
# Human Advanced Computer									
#	id	Type	zoom	scanRange	Lead Indicator	targetLabels	targetClosest	autoTarget	
newComputer(	802 ,	Computer,	1,	500 ,	t,	t,	t,	t	);

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag		
mountInfo1 (	IDMNT_CMP_HUM3,	IDMNT_CMP_HUM3_L,	"hu_computerL_S.BMP",	"hu_computerL_SD.BMP",	"hu_computerL_L.BMP",	"hu_computerL_LD.BMP",	IDCSPEC_CMP_HUM3	);	

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage			
mountInfo2 (	1 ,	H ,	150 ,	2.0 ,	S ,	500	);		
									
									
#------------------------------------------------------------------------------									
# Cybrid Basic Systems Control									
#	id	Type	zoom	scanRange	Lead Indicator	targetLabels	targetClosest	autoTarget	
newComputer(	805 ,	Computer,	0.7,	150 ,	f,	f,	f,	f	);

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag		
mountInfo1 (	IDMNT_CMP_CYB1,	IDMNT_CMP_CYB1_L,	"cy_computerS_S.BMP",	"cy_computerS_SD.BMP",	"cy_computerS_L.BMP",	"cy_computerS_LD.BMP",	IDCSPEC_CMP_CYB1	);	

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage			
mountInfo2 (	1 ,	C ,	75 ,	0.5 ,	S ,	400	);		
									
									
#------------------------------------------------------------------------------									
# Cybrid Enhanced Systems Control									
#	id	Type	zoom	scanRange	Lead Indicator	targetLabels	targetClosest	autoTarget	
newComputer(	806 ,	Computer,	1,	300 ,	t,	f,	t,	f	);

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag		
mountInfo1 (	IDMNT_CMP_CYB2,	IDMNT_CMP_CYB2_L,	"cy_computerM_S.BMP",	"cy_computerM_SD.BMP",	"cy_computerM_L.BMP",	"cy_computerM_LD.BMP",	IDCSPEC_CMP_CYB2	);	

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage			
mountInfo2 (	1 ,	C ,	150 ,	1.0 ,	S ,	450	);		
									
									
#------------------------------------------------------------------------------									
# Cybrid Advanced Systems Control									
#	id	Type	zoom	scanRange	Lead Indicator	targetLabels	targetClosest	autoTarget	
newComputer(	807 ,	Computer,	1,	500 ,	t,	t,	t,	t	);

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag		
mountInfo1 (	IDMNT_CMP_CYB3,	IDMNT_CMP_CYB3_L,	"cy_computerL_S.BMP",	"cy_computerL_SD.BMP",	"cy_computerL_L.BMP",	"cy_computerL_LD.BMP",	IDCSPEC_CMP_CYB3	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	1 ,	C ,	200 ,	1.5 ,	S ,	500	);	
								
								
# Notes about jammers: Jamming chance is applied once per second. Value in the jamming chance field is the maximum chance attained at a distance of zero. 								
# Jamming chance falls with the square of distance								
#------------------------------------------------------------------------------								
# Guardian ECM								
#	id	Type	ECM Rating	ChargeRate 	JammingDistance	JammingChance		
newECM (	810 ,	ECM,	0.75 ,	10 ,	1000 ,	0.30	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag	
mountInfo1 (	IDMNT_ECM1,	IDMNT_ECM1_L,	"guardianECM_S.bmp",	"guardianECM_SD.bmp",	"guardianECM_L.bmp",	"guardianECM_LD.bmp",	IDCSPEC_ECM_HUM1	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	3 ,	H ,	700 ,	1.0 ,	S ,	500	);	


#------------------------------------------------------------------------------								
# Doppleganger ECM								
#	id	Type	ECM Rating	ChargeRate 	JammingDistance	JammingChance		
newECM (	811 ,	ECM,	1.2 ,	15 ,	1200 ,	0.50	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag	
mountInfo1 (	IDMNT_ECM2,	IDMNT_ECM2_L,	"doppleganger_S.bmp",	"doppleganger_SD.bmp",	"doppleganger_L.bmp",	"doppleganger_LD.bmp",	IDCSPEC_ECM_HUM2	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	5 ,	H ,	900 ,	2.0 ,	L ,	500	);	


#------------------------------------------------------------------------------								
# Cybrid Alpha ECM								
#	id	Type	ECM Rating	ChargeRate 	JammingDistance	JammingChance		
newECM (	812 ,	ECM,	0.9 ,	10 ,	1050 ,	0.35	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag	
mountInfo1 (	IDMNT_ECM3,	IDMNT_ECM3_L,	"cyECM1_S.bmp",	"cyECM1_SD.bmp",	"cyECM1_L.bmp",	"cyECM1_LD.bmp",	IDCSPEC_ECM_CYB1	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	3 ,	C ,	800 ,	1.5 ,	S ,	500	);	
								
								
#------------------------------------------------------------------------------								
#Cybrid Beta ECM								
#	id	Type	ECM Rating	ChargeRate 	JammingDistance	JammingChance		
newECM (	813 ,	ECM,	1.3 ,	15 ,	1250 ,	0.55	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag	
mountInfo1 (	IDMNT_ECM4,	IDMNT_ECM4_L,	"cyECM2_S.bmp",	"cyECM2_SD.bmp",	"cyECM2_L.bmp",	"cyECM2_LD.bmp",	IDCSPEC_ECM_CYB2	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	5 ,	C ,	1000 ,	3.0 ,	L ,	500	);	
								
								
#------------------------------------------------------------------------------								
# Thermal Diffuser								
#	id	Type	Rating	ChargeRate 	JammingDistance	JammingChance		
newThermal (	820 ,	ThermalDiffuser,	1 ,	10 ,	1000 ,	0.55	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description tag	
mountInfo1 (	IDMNT_DIF1,	IDMNT_DIF1_L,	"thermaldiffuser_S.bmp",	"thermaldiffuser_SD.bmp",	"thermaldiffuser_L.bmp",	"thermaldiffuser_LD.bmp",	IDCSPEC_THERM	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage	
mountInfo2 (	5 ,	A ,	1075 ,	2.0 ,	S ,	500	);


#------------------------------------------------------------------------------							
# Flares							
#	id	Type					
#newMountable (	825 ,	Flares	);				
#							
#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	
#mountInfo1 (	IDMNT_FLR,	IDMNT_FLR_L,	"flares_S.bmp",	"flares_SD.bmp",	"flares_L.bmp",	"flares_LD.bmp"	);
#							
#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage	
#mountInfo2 (	1 ,	A ,	100 ,	1.0 ,	S ,	500	);
#							
#							
#------------------------------------------------------------------------------								
# Chameleon								
#	id	rating	dmg_amt_glitch	glitch_coef	dmg_amt_fail	fail_coef		
newCloak (	830 ,	12000 ,	0.50 ,	1.00 ,	0.20 ,	5	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag	
mountInfo1 (	IDMNT_CLK1,	IDMNT_CLK1_L,	"chameleonCloak_S.bmp",	"chameleonCloak_SD.bmp",	"chameleonCloak_L.bmp",	"chameleonCloak_LD.bmp",	IDSPEC_CLK1	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	4 ,	A ,	850 ,	1.0 ,	M ,	500	);	


#------------------------------------------------------------------------------								
# Cuttlefish cloak								
#	id	rating	dmg_amt_glitch	glitch_coef	dmg_amt_fail	fail_coef		
newCloak (	831 ,	16000 ,	0.50 ,	1.00 ,	0.20 ,	5	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag	
mountInfo1 (	IDMNT_CLK2,	IDMNT_CLK2_L,	"cuttlefishCloak_S.bmp",	"cuttlefishCloak_SD.bmp",	"cuttlefishCloak_L.bmp",	"cuttlefishCloak_LD.bmp",	IDSPEC_CLK2	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	5 ,	A ,	1125 ,	3.5 ,	L ,	500	);	
								

#------------------------------------------------------------------------------								
# Shield Modulator			FocusBoost determines relative effectiveness of shields front to back. Valid values are 0-1. 1==2x effective front, 1/2 rear.					
#	id	Type	FocusBoost					
newModulator (	840 ,	ShieldModulator,	0.25	);				

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_SMOD,	IDMNT_SMOD_L,	"shieldModulater_S.bmp",	"shieldModulater_SD.bmp",	"shieldModulater_L.bmp",	"shieldModulater_LD.bmp",	IDSPEC_SMOD	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	3 ,	A ,	1200 ,	3.0 ,	S ,	500	);	
								
								
#------------------------------------------------------------------------------								
# Shield Capacitor								
#	id	Type	capacity	chargeRate	selfDamage			
newCapacitor (	845 ,	ShieldCapacitor,	1500 ,	25.00 ,	0.1	);		

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_SCAP,	IDMNT_SCAP_L,	"shieldCapacitor_S.bmp",	"shieldCapacitor_SD.bmp",	"shieldCapacitor_L.bmp",	"shieldCapacitor_LD.bmp",	IDSPEC_SCAP	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	1 ,	A ,	500 ,	1.0 ,	S ,	500	);	
								
								
#------------------------------------------------------------------------------								
#Shield Amplifier (increases shield constant)								
#	id	Type	multiplier					
newAmplifier (	850 ,	ShieldAmplifier,	1.25	);				

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_SAMP,	IDMNT_SAMP_L,	"shieldAmplifier_S.bmp",	"shieldAmplifier_SD.bmp",	"shieldAmplifier_L.bmp",	"shieldAmplifier_LD.bmp",	IDSPEC_SAMP	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	3 ,	A ,	825 ,	2.0 ,	M ,	500	);	
								

#------------------------------------------------------------------------------								
# Laser Targeting Module								
#	id	Type						
newMountable (	860 ,	LaserTargeting	);					

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_LTAD,	IDMNT_LTAD_L,	"Ltads_S.bmp",	"Ltads_SD.bmp",	"Ltads_L.bmp",	"Ltads_LD.bmp",	IDSPEC_LTAD	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	2 ,	A ,	500 ,	1.0 ,	S ,	500	);	
								

#------------------------------------------------------------------------------------								
# Extra Battery								
#	id	Type	Capacity					
newBattery (	865 ,	Battery,	1000	);				

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_BAT,	IDMNT_BAT_L,	"battery_S.bmp",	"battery_SD.bmp",	"battery_L.bmp",	"battery_LD.bmp",	IDSPEC_BAT	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	1 ,	A ,	1000 ,	1.0 ,	S ,	500	);	
								
								
#------------------------------------------------------------------------------------								
# Reactor Capacitor								
#	id	Type	capacity	chargeRate	selfDamage			
newCapacitor (	870 ,	Capacitor,	1500 ,	25.00 ,	0.1	);		

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_CAP,	IDMNT_CAP_L,	"capacitor_S.bmp",	"capacitor_SD.bmp",	"capacitor_L.bmp",	"capacitor_LD.bmp",	IDSPEC_CAP	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	2 ,	A ,	450 ,	1.0 ,	S ,	500	);	
								

#------------------------------------------------------------------------------------								
# Field Stabilizer								
#	id	Type						
newMountable (	875 ,	FieldStabilizer	);					

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_FSTB,	IDMNT_FSTB_L,	"fieldstabilizer_S.bmp",	"fieldstabilizer_SD.bmp",	"fieldstabilizer_L.bmp",	"fieldstabilizer_LD.bmp",	IDSPEC_FSTB	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	1 ,	A ,	400 ,	1.0 ,	S ,	500	);	
								

#------------------------------------------------------------------------------------								
# Rocket Booster								
#	id	Type	boostRatio 	energyCapacity 	burnRate 	chargeRate		
newBooster (	880 ,	RocketBooster,	1.80 ,	130 ,	15 ,	5	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_RBST,	IDMNT_RBST_L,	"rocketboost_S.bmp",	"rocketboost_SD.bmp",	"rocketboost_L.bmp",	"rocketboost_LD.bmp",	IDSPEC_RBST	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	5 ,	A ,	675 ,	5.0 ,	M ,	500	);	
								
								
#------------------------------------------------------------------------------------								
# Turbine Boost								
#	id	Type	boostRatio 	energyCapacity 	burnRate 	chargeRate		
newBooster (	885 ,	TurbineBoost,	1.75 ,	20 ,	8.0 ,	4	);	

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_TBST,	IDMNT_TBST_L,	"tubineboost_S.bmp",	"tubineboost_SD.bmp",	"turbineboost_L.bmp",	"turbineboost_LD.bmp",	IDSPEC_TBST	);
								

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	4 ,	A ,	875 ,	2.0 ,	S ,	500	);	
								
								
#------------------------------------------------------------------------------------								
#NanoRepair								
#	id	Type	Repair Rate	Energy Drain				
newRepair (	890 ,	NanoRepair,	30 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_NANO,	IDMNT_NANO_L,	"nanorepair_S.bmp",	"nanorepair_SD.bmp",	"nanorepair_L.bmp",	"nanorepair_LD.bmp",	IDSPEC_NANO	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	8 ,	X ,	3000 ,	6.0 ,	L ,	3000	);	


#------------------------------------------------------------------------------------								
#Angle Life Support								
#	id	Type						
newMountable (	900 ,	LifeSupport	);					

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_LIFE,	IDMNT_LIFE_L,	"angellife_S.bmp",	"angellife_SD.bmp",	"angellife_L.bmp",	"angellife_LD.bmp",	IDSPEC_LIFE	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	2 ,	A ,	425 ,	0.5 ,	S ,	500	);	


#------------------------------------------------------------------------------------								
#Agrav Generator								
#	id	Type						
newMountable (	910 ,	AgravGenerator	);					

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_AGRV,	IDMNT_AGRV_L,	"agravGen_S.bmp",	"agravGen_SD.bmp",	"agravGen_L.bmp",	"agravGen_LD.bmp",	IDSPEC_AGRV	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	10 ,	X ,	1250 ,	-5.0 ,	L ,	500	);	


#------------------------------------------------------------------------------------								
#ElectroHull								
#	id	Type						
newMountable (	912 ,	electroHull	);					

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDWEA_EHUL,	IDWDESC_EHUL,	"EHUL_S.bmp",	"EHUL_SD.bmp",	"EHUL_L.bmp",	"EHUL_LD.bmp",	IDSPEC_EHUL	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	6 ,	H ,	915 ,	5.0 ,	L ,	500	);	


#------------------------------------------------------------------------------------								
#UAP								
#	id	Type						
newMountable (	914 ,	ammoPack	);					

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
mountInfo1 (	IDMNT_AMMOPACK,	IDMNT_AMMOPACK_L,	"LGB_S.bmp",	"LGB_SD.bmp",	"LGB_L.bmp",	"LGB_LD.bmp",	IDSPEC_AMMOPACK	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
mountInfo2 (	4,	X ,	750 ,	4.0 ,	M ,	800	);	

