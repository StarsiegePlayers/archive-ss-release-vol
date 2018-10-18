	#-----------------------------------------------------------------------------														
	# datArmor.cs 														
	# Armor ids 926-950														
	#														
	#------------------------------------------------------------------------------														
	#Tech base H = Human, C = Cybrid, A = All, X = Alien														
	#														
	#------------------------------------------------------------------------------														
	# Armor 	Carbon Fiber													
	#	id	Type	Con_shrug	Elec_shrug	Thrm_shrug	Con_eff	Elec_eff	Thrm_eff	RCS_MOD	reAlloc_rate	regen_rate			
	newArmor (	926 ,	Armor,	25 ,	25 ,	50 ,	1.50 ,	1.00 ,	0.70 ,	-0.50 ,	0 ,	0	);		
															
	#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
	armorInfo1 (	IDMNT_ARM1,	IDMNT_ARM1_L,	"armor1_S.bmp",	"armor1_SD.bmp",	"armor1_L.bmp",	"armor1_LD.bmp",	IDSPEC_ARM1	);						
															
	#	Tech Level	Tech Base	Combat Value	Density	Mountpoint Size	Damage								
	armorInfo2 (	1 ,	A,	773 ,	0.03 ,	s,	1	);							
															
	#	Projectile_ID	Shrug	Effective											
	#armorInfospecial(	0 ,	0 ,	0	);										
															
	#	Projectile_ID	Shrug	Effective											
	#armorInfospecial(	0 ,	0 ,	0	);										
															
	#------------------------------------------------------------------------------														
	# Armor	QBM: Quad Bonded Metaplas (Standard)													
	#	id	Type	Con_shrug	Elec_shrug	Thrm_shrug	Con_eff	Elec_eff	Thrm_eff	RCS_MOD	reAlloc_rate	regen_rate			
	newArmor (	927 ,	Armor,	25 ,	50 ,	50 ,	1.00 ,	1.00 ,	1.00 ,	0.00 ,	0 ,	0	);		
															
	#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
	armorInfo1 (	IDMNT_ARM2,	IDMNT_ARM2_L,	"armor2_S.bmp",	"armor2_SD.bmp",	"armor2_L.bmp",	"armor2_LD.bmp",	IDSPEC_ARM2	);						
															
	#	Tech Level	Tech Base	Combat Value	Density	Mountpoint Size	Damage								
	armorInfo2 (	1 ,	A,	844 ,	0.05 ,	s,	1	);							
															
	#------------------------------------------------------------------------------														
	# Armor	Depleted Uranium (DPU)		Increased protection from Radiation Guns											
	#	id	Type	Con_shrug	Elec_shrug	Thrm_shrug	Con_eff	Elec_eff	Thrm_eff	RCS_MOD	reAlloc_rate	regen_rate			
	newArmor (	928 ,	Armor,	75 ,	50 ,	50 ,	1.20 ,	1.00 ,	1.00 ,	0.00 ,	0 ,	0	);		
															
	#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
	armorInfo1 (	IDMNT_ARM3,	IDMNT_ARM3_L,	"armor3_S.bmp",	"armor3_SD.bmp",	"armor3_L.bmp",	"armor3_LD.bmp",	IDSPEC_ARM3	);						
															
	#	Tech Level	Tech Base	Combat Value	Density	Mountpoint Size	Damage								
	armorInfo2 (	2 ,	A,	1367 ,	0.08 ,	M,	1	);							
															
	#	Projectile_ID	Shrug	Effective											
	armorInfospecial(	42 ,	35 ,	1.25	);										
															
	#------------------------------------------------------------------------------														
	# Armor	Ceramic													
	#	id	Type	Con_shrug	Elec_shrug	Thrm_shrug	Con_eff	Elec_eff	Thrm_eff	RCS_MOD	reAlloc_rate	regen_rate			
	newArmor (	929 ,	Armor,	0 ,	50 ,	100 ,	0.90 ,	2.00 ,	1.00 ,	0.00 ,	0 ,	0	);		
															
	#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
	armorInfo1 (	IDMNT_ARM4,	IDMNT_ARM4_L,	"armor4_S.bmp",	"armor4_SD.bmp",	"armor4_L.bmp",	"armor4_LD.bmp",	IDSPEC_ARM4	);						
															
	#	Tech Level	Tech Base	Combat Value	Density	Mountpoint Size	Damage								
	armorInfo2 (	3 ,	A,	1182 ,	0.06 ,	s,	1	);							
															
	#------------------------------------------------------------------------------														
	# Armor	Crystalluminum													
	#	id	Type	Con_shrug	Elec_shrug	Thrm_shrug	Con_eff	Elec_eff	Thrm_eff	RCS_MOD	reAlloc_rate	regen_rate			
	newArmor (	930 ,	Armor,	50 ,	100 ,	25 ,	1.10 ,	1.10 ,	0.70 ,	0.00 ,	0 ,	0	);		
															
	#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
	armorInfo1 (	IDMNT_ARM5,	IDMNT_ARM5_L,	"armor5_S.bmp",	"armor5_SD.bmp",	"armor5_L.bmp",	"armor5_LD.bmp",	IDSPEC_ARM5	);						
															
	#	Tech Level	Tech Base	Combat Value	Density	Mountpoint Size	Damage								
	armorInfo2 (	5 ,	A,	1257 ,	0.07 ,	M,	1	);							
															
															
	#------------------------------------------------------------------------------														
	# Armor	Quicksilver nano armor													
	#	id	Type	Con_shrug	Elec_shrug	Thrm_shrug	Con_eff	Elec_eff	Thrm_eff	RCS_MOD	reAlloc_rate	regen_rate			
	newArmor (	931 ,	Armor,	50 ,	50 ,	50 ,	1.00 ,	1.00 ,	1.00 ,	0.00 ,	350 ,	25	);		
															
	#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
	armorInfo1 (	IDMNT_ARM6,	IDMNT_ARM6_L,	"armor6_S.bmp",	"armor6_SD.bmp",	"armor6_L.bmp",	"armor6_LD.bmp",	IDSPEC_ARM6	);						
															
	#	Tech Level	Tech Base	Combat Value	Density	Mountpoint Size	Damage								
	armorInfo2 (	9 ,	X,	1480 ,	0.09 ,	L,	1	);							
															
	#	Projectile_ID	Shrug	Effective											
	armorInfospecial(	14 ,	400 ,	1.75	);										
															
	#	Projectile_ID	Shrug	Effective											
	armorInfospecial(	15 ,	500 ,	1.75	);										
dd