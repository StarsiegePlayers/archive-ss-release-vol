// datWeapon.cs								
// a note about weapons								
// damage is armor + structure								
// charge rate is 1/2 charge limit over reload time								

// Energy Weapons first								

//-------------------------------------------------------------------------								
// Laser { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	101 ,	"wg_las.dts",	S,	IDSFX_LAS,	800 ,	A,	IDSPEC_WEA_LAS    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_LAS,	IDWDESC_LAS,	"LAS_S.bmp",	"LAS_SD.bmp",	"LAS_L.bmp",	"LAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	1 ,	435 ,	1.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_las.dts",	"mz_lasT.dts",	T,	239 ,	90 ,	90 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.30 ,	0.73		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	1 ,	20 ,	15.00	);				


//-------------------------------------------------------------------------								
// Heavy Laser { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	102 ,	"wg_hlas.dts",	M,	IDSFX_HLAS,	1000 ,	A,	IDSPEC_WEA_HLAS    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_HLAS,	IDWDESC_HLAS,	"HLAS_S.bmp",	"HLAS_SD.bmp",	"HLAS_L.bmp",	"HLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	700 ,	3.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_las.dts",	"mz_lasT.dts",	T,	239 ,	160 ,	90 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.3 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.50 ,	0.60		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	2 ,	40 ,	25.00	);				


//-------------------------------------------------------------------------								
// Compression Laser {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	103 ,	"wt_clas.dts",	S,	IDSFX_CLAS,	800 ,	H,	IDSPEC_WEA_CLAS    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_CLAS,	IDWDESC_CLAS,	"CLAS_S.bmp",	"CLAS_SD.bmp",	"CLAS_L.bmp",	"CLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	570 ,	2.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_clas.dts",	"mz_clasT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.5 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.20 ,	0.80		);			
weaponShot(	0.00 ,	2.20 ,	0.80 ,	0.2	);			
weaponShot(	0.00 ,	2.20 ,	0.80 ,	0.4	);			
//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	3 ,	50 ,	27.00	);				

//-------------------------------------------------------------------------								
// Twin Laser {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	104 ,	"wc_tlas.dts",	S,	IDSFX_TLAS,	800 ,	C,	IDSPEC_WEA_TLAS    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TLAS,	IDWDESC_TLAS,	"TLAS_S.bmp",	"TLAS_SD.bmp",	"TLAS_L.bmp",	"TLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	495 ,	2.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_tlas.dts",	"mz_tlasT.dts",	F,	239 ,	90 ,	90 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.5 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.90 ,	0.92		);			
weaponShot(	0.00 ,	1.90 ,	0.40 ,	0.3	);			
//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	4 ,	35 ,	20.00	);				


//-------------------------------------------------------------------------								
// Electro Magnetic Pulse Cannon { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	105 ,	"wg_emp.dts",	S,	IDSFX_EMP,	1000 ,	A,	IDSPEC_WEA_EMP    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_EMP,	IDWDESC_EMP,	"EMP_S.bmp",	"EMP_SD.bmp",	"EMP_L.bmp",	"EMP_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	610 ,	1.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_emp.dts",	"mz_empT.dts",	T,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.1 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.20 ,	0.95		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	5 ,	28 ,	20.00	);				


//-------------------------------------------------------------------------								
// Electron Flux Whip {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	106 ,	"wt_elf.dts",	M,	IDSFX_ELF,	1000 ,	H,	IDSPEC_WEA_ELF	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_ELF,	IDWDESC_ELF,	"ELF_S.bmp",	"ELF_SD.bmp",	"ELF_L.bmp",	"ELF_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	820 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_elf.dts",	"mz_elfT.dts",	F,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.5 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.00 ,	0.80		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	6 ,	85 ,	50.00	);				


//-------------------------------------------------------------------------								
// Blaster {masters}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	107 ,	"wm_blas.dts",	M,	IDSFX_BLAS,	1000 ,	X,	IDSPEC_WEA_BLAS    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_BLAS,	IDWDESC_BLAS,	"BLAS_S.bmp",	"BLAS_SD.bmp",	"BLAS_L.bmp",	"BLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	755 ,	4.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_blas.dts",	"mz_blasT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.1 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.20 ,	0.87		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	7 ,	42 ,	35.00	);				


//-------------------------------------------------------------------------								
// Heavy Blaster {masters}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	108 ,	"wm_hbla.dts",	L,	IDSFX_HBLA,	1000 ,	X,	IDSPEC_WEA_HBLA	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_HBLA,	IDWDESC_HBLA,	"HBLA_S.bmp",	"HBLA_SD.bmp",	"HBLA_L.bmp",	"HBLA_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	6 ,	865 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_hbla.dts",	"mz_hblaT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.4 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.00 ,	1.00		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	8 ,	72 ,	45.00	);				


//-------------------------------------------------------------------------								
// Particle Beam Weapon {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	109 ,	"wc_pbw.dts",	L,	IDSFX_PBW,	1200 ,	C,	IDSPEC_WEA_PBW	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_PBW,	IDWDESC_PBW,	"PBW_S.bmp",	"PBW_SD.bmp",	"PBW_L.bmp",	"PBW_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	900 ,	7.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_pbw.dts",	"mz_pbwT.dts",	T,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.8 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.00 ,	0.35		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	9 ,	100 ,	50.00	);				


// quantum weapons								

//-------------------------------------------------------------------------								
// Plasma { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	110 ,	"wg_plas.dts",	L,	IDSFX_PLAS,	1200 ,	A,	IDSPEC_WEA_PLAS    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_PLAS,	IDWDESC_PLAS,	"PLAS_S.bmp",	"PLAS_SD.bmp",	"PLAS_L.bmp",	"PLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	6 ,	1025 ,	8.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_plas.dts",	"mz_plasT.dts",	T,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.9 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.20 ,	1.05		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	10 ,	110 ,	50.00	);				


//-------------------------------------------------------------------------								
// Blink Gun {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	111 ,	"wc_blnk.dts",	M,	IDSFX_BLNK,	1000 ,	C,	IDSPEC_WEA_BLNK	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_BLNK,	IDWDESC_BLNK,	"BLNK_S.bmp",	"BLNK_SD.bmp",	"BLNK_L.bmp",	"BLNK_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	785 ,	3.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_blnk.dts",	"mz_blnkT.dts",	F,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	0.8 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	11 ,	45 ,	45.00	);				


//-------------------------------------------------------------------------								
// Quantum Gun {masters}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	112 ,	"wm_qgun.dts",	X,	IDSFX_QGUN,	1200 ,	X,	IDSPEC_WEA_QGUN	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_QGUN,	IDWDESC_QGUN,	"QGUN_S.bmp",	"QGUN_SD.bmp",	"QGUN_L.bmp",	"QGUN_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	7 ,	1135 ,	8.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_las.dts",	"mz_blasT.dts",	T,	128 ,	0 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.50 ,	1.20		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	12 ,	140 ,	60.00	);				


//-------------------------------------------------------------------------								
// Magneto-Fusion Assault Cannon {masters}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	113 ,	"wm_mfac.dts",	X,	IDSFX_MFAC,	1200 ,	X,	IDSPEC_WEA_MFAC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_MFAC,	IDWDESC_MFAC,	"MFAC_S.bmp",	"MFAC_SD.bmp",	"MFAC_L.bmp",	"MFAC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	8 ,	1225 ,	10.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_mfac.dts",	"mz_mfacT.dts",	F,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.8 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	13 ,	155 ,	50.00	);				


//-------------------------------------------------------------------------								
// Nanno Infuser {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	114 ,	"wc_nano.dts",	S,	IDSFX_NANO,	800 ,	C,	IDSPEC_WEA_NANO	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_NANO,	IDWDESC_NANO,	"NANO_S.bmp",	"NANO_SD.bmp",	"NANO_L.bmp",	"NANO_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	600 ,	2.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_blas.dts",	"mz_blasT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.7 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.50 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	14 ,	30 ,	30 ,	1	);			


//-------------------------------------------------------------------------								
// Nannite Cannon {masters}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	115 ,	"wm_ncan.dts",	M,	IDSFX_NCAN,	800 ,	X,	IDSPEC_WEA_NCAN	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_NCAN,	IDWDESC_NCAN,	"NCAN_S.bmp",	"NCAN_SD.bmp",	"NCAN_L.bmp",	"NCAN_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	660 ,	4.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_blas.dts",	"mz_blasT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.7 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.75 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	15 ,	25 ,	25 ,	1	);			



// ballistic weapons								

//-------------------------------------------------------------------------								
// Autocannon { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	116 ,	"wg_atc.dts",	S,	IDSFX_ATC,	800 ,	A,	IDSPEC_WEA_ATC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_ATC,	IDWDESC_ATC,	"ATC_S.bmp",	"ATC_SD.bmp",	"ATC_L.bmp",	"ATC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	1 ,	400 ,	1.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_atc.dts",	"mz_atcT.dts",	F,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	0.5 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.20 ,	0.70		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	16 ,	9000 ,	9000 ,	31	);			


//-------------------------------------------------------------------------								
// Heavy Autocannon { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	117 ,	"wg_hatc.dts",	M,	IDSFX_HATC,	800 ,	A,	IDSPEC_WEA_HATC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_HATC,	IDWDESC_HATC,	"HATC_S.bmp",	"HATC_SD.bmp",	"HATC_L.bmp",	"HATC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	610 ,	3.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_hatc.dts",	"mz_hatcT.dts",	F,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	0.7 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.90 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	17 ,	4000 ,	4000 ,	21	);			


//-------------------------------------------------------------------------								
// Electro-Mag Autocannon {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	118 ,	"wc_emc.dts",	S,	IDSFX_EMC,	800 ,	C,	IDSPEC_WEA_EMC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_EMC,	IDWDESC_EMC,	"EMC_S.bmp",	"EMC_SD.bmp",	"EMC_L.bmp",	"EMC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	520 ,	2.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_plas.dts",	"mz_plasT.dts",	T,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	0.6 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.50 ,	0.50		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	18 ,	5000 ,	5000 ,	21	);			


//-------------------------------------------------------------------------								
// Blast Cannon { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	119 ,	"wg_bc.dts",	L,	IDSFX_BC,	1200 ,	A,	IDSPEC_WEA_BC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_BC,	IDWDESC_BC,	"BC_S.bmp",	"BC_SD.bmp",	"BC_L.bmp",	"BC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	920 ,	8.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.7 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	19 ,	25 ,	25 ,	1	);			


//-------------------------------------------------------------------------								
// Heavy Blast Cannon { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	120 ,	"wg_hbc.dts",	X,	IDSFX_HBC,	1200 ,	A,	IDSPEC_WEA_HBC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_HBC,	IDWDESC_HBC,	"HBC_S.bmp",	"HBC_SD.bmp",	"HBC_L.bmp",	"HBC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	1015 ,	10.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.30 ,	1.15		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	20 ,	15 ,	15 ,	1	);			


//-------------------------------------------------------------------------								
// Rail Gun {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	121 ,	"wc_rail.dts",	L,	IDSFX_RAIL,	1200 ,	C,	IDSPEC_WEA_RAIL	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_RAIL,	IDWDESC_RAIL,	"RAIL_S.bmp",	"RAIL_SD.bmp",	"RAIL_L.bmp",	"RAIL_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	975 ,	6.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_plas.dts",	"mz_plasT.dts",	T,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.20 ,	0.00 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.20 ,	0.60		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	21 ,	40 ,	40 ,	1	);			


// bombs								

//-------------------------------------------------------------------------								
// Laser Guided Bomb {common}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	10 ,	"wc_rail.dts",	M,	IDSFX_LGB,	500 ,	A,	IDSPEC_WEA_LGB	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_LGB,	IDWDESC_LGB,	"LGB_S.bmp",	"LGB_SD.bmp",	"LGB_L.bmp",	"LGB_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	2 ,	500 ,	1.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	2.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.20 ,	0.60		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	22 ,	5 ,	5 ,	1	);			


//-------------------------------------------------------------------------								
// Hades {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	11 ,	"wc_rail.dts",	M,	IDSFX_HAD,	500 ,	H,	IDSPEC_WEA_HAD	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp	
weaponInfo1(	IDWEA_HAD,	IDWDESC_HAD,	"HAD_S.bmp",	"HAD_SD.bmp",	"HAD_L.bmp",	"HAD_LD.bmp" 	);

//	Techlevel	CombatValue	Mass				
weaponInfo2(	6 ,	500 ,	3.00	);			

//	Reload/anim_time	Lock_time	Converge				
weaponGeneral(	1.0 ,	2.0 ,	F	);			

//	FireOffset (X)	(Y)	(Z)	FireTime			
weaponShot(	0.00 ,	3.20 ,	0.60		);		

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley			
weaponAmmo(	23 ,	5 ,	5 ,	1	);		


// missles								
// reload time is half lock time								


//-------------------------------------------------------------------------								
// Pit Viper Missile Pack 8 { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	124 ,	"wg_vip8.dts",	S,	IDSFX_VIP8,	800 ,	A,	IDSPEC_WEA_VIP8	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_VIP8,	IDWDESC_VIP8,	"VIP_S.bmp",	"VIP_SD.bmp",	"VIP_L.bmp",	"VIP_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	2 ,	605 ,	3.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	3.0 ,	4.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	24 ,	8 ,	8 ,	1	);			


//-------------------------------------------------------------------------								
// Pit Viper Missile Pack 12 { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	125 ,	"wg_vip12.dts",	M,	IDSFX_VIP12,	1000 ,	A,	IDSPEC_WEA_VIP12	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_VIP12,	IDWDESC_VIP12,	"VIP_S.bmp",	"VIP_SD.bmp",	"VIP_L.bmp",	"VIP_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	700 ,	4.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	3.0 ,	4.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.50		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	24 ,	12 ,	12 ,	1	);			


//-------------------------------------------------------------------------								
// Sparrow Missile Pack 6 { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	126 ,	"wg_spr6.dts",	S,	IDSFX_SPR6,	800 ,	A,	IDSPEC_WEA_SPR6	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_SPR6,	IDWDESC_SPR6,	"SPR_S.bmp",	"SPR_SD.bmp",	"SPR_L.bmp",	"SPR_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	2 ,	490 ,	2.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	3.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	25 ,	6 ,	6 ,	1	);			


//-------------------------------------------------------------------------								
// Sparrow Missile Pack 10 { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	127 ,	"wg_spr10.dts",	M,	IDSFX_SPR10,	1000 ,	A,	IDSPEC_WEA_SPR10	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_SPR10,	IDWDESC_SPR10,	"SPR_S.bmp",	"SPR_SD.bmp",	"SPR_L.bmp",	"SPR_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	560 ,	3.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	3.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	25 ,	10 ,	10 ,	1	);			


//-------------------------------------------------------------------------								
// SWARM Missle Pack 6 {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	128 ,	"wt_swrm.dts",	M,	IDSFX_SWRM,	1000 ,	H,	IDSPEC_WEA_SWRM	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_SWRM,	IDWDESC_SWRM,	"SWRM_S.bmp",	"SWRM_SD.bmp",	"SWRM_L.bmp",	"SWRM_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	630 ,	4.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.5 ,	3.5 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	26 ,	6 ,	6 ,	1	);			


//-------------------------------------------------------------------------								
// Minion Missle Pack 10 { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	129 ,	"wg_min.dts",	M,	IDSFX_MIN,	1000 ,	A,	IDSPEC_WEA_MIN	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_MIN,	IDWDESC_MIN,	"MIN_S.bmp",	"MIN_SD.bmp",	"MIN_L.bmp",	"MIN_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	840 ,	3.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	4.0 ,	5.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	27 ,	10 ,	10 ,	1	);			

								
//-------------------------------------------------------------------------								
// Shrike Missle Pack 8 {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	130 ,	"wc_shrk.dts",	M,	IDSFX_SHRK,	1000 ,	C,	IDSPEC_WEA_SHRK	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_SHRK,	IDWDESC_SHRK,	"SHRK_S.bmp",	"SHRK_SD.bmp",	"SHRK_L.bmp",	"SHRK_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	800 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	3.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	28 ,	8 ,	8 ,	1	);			


//-------------------------------------------------------------------------								
// Aphid AA Missile System Pack 10 { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	147 ,	"wg_min.dts",	S,	IDSFX_APH,	800 ,	A,	IDSPEC_WEA_APHID	);
								
//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_APHID,	IDWDESC_APHID,	"LaserMissile_S.bmp",	"LaserMissile_SD.bmp",	"LaserMissile_L.bmp",	"LaserMissile_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	595 ,	3.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_smok.dts",	"mz_smokT.dts",	T,	0 ,	0 ,	0 ,	0	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	3.0 ,	4.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	47 ,	10 ,	10 ,	1	);			



// mines								

//-------------------------------------------------------------------------								
// Arachnitron 4 pack {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	131 ,	"wc_shrk.dts",	S,	IDSFX_ARA4,	800 ,	C,	IDSPEC_WEA_ARA4	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_ARA4,	IDWDESC_ARA4,	"ARA_S.bmp",	"ARA_SD.bmp",	"ARA_L.bmp",	"ARA_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	410 ,	2.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	3.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	31 ,	6 ,	6 ,	1	);			


//-------------------------------------------------------------------------								
// Arachnitron 8 pack {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	132 ,	"wc_shrk.dts",	M,	IDSFX_ARA8,	1000 ,	C,	IDSPEC_WEA_ARA8	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp	
weaponInfo1(	IDWEA_ARA8,	IDWDESC_ARA8,	"ARA_S.bmp",	"ARA_SD.bmp",	"ARA_L.bmp",	"ARA_LD.bmp" 	);

//  	Techlevel	CombatValue	Mass				
weaponInfo2(	4 ,	450 ,	4.00	);			

//	Reload/anim_time	Lock_time	Converge				
weaponGeneral(	2.0 ,	3.0 ,	F	);			

//	FireOffset (X)	(Y)	(Z)	FireTime			
weaponShot(	0.00 ,	1.00 ,	1.00		);		

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley			
weaponAmmo(	31 ,	10 ,	10 ,	1	);		


//-------------------------------------------------------------------------								
// Arachnitron 12 pack {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	133 ,	"wc_shrk.dts",	L,	IDSFX_ARA12,	1200 ,	C,	IDSPEC_WEA_ARA12	);
								
//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_ARA12,	IDWDESC_ARA12,	"ARA_S.bmp",	"ARA_SD.bmp",	"ARA_L.bmp",	"ARA_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	490 ,	6.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	3.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	31 ,	14 ,	14 ,	1	);			


//-------------------------------------------------------------------------								
// Proximity 6 pack {common}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	134 ,	"wg_vip8.dts",	S,	IDSFX_PRX6,	800 ,	A,	IDSPEC_WEA_PRX6	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_PRX6,	IDWDESC_PRX6,	"PRX_S.bmp",	"PRX_SD.bmp",	"PRX_L.bmp",	"PRX_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	1 ,	400 ,	1.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.5 ,	0.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	32 ,	6 ,	6 ,	1	);			


//-------------------------------------------------------------------------								
// Proximity 10 pack {common}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	135 ,	"wg_vip8.dts",	M,	IDSFX_PRX10,	1000 ,	A,	IDSPEC_WEA_PRX10	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp	
weaponInfo1(	IDWEA_PRX10,	IDWDESC_PRX10,	"PRX_S.bmp",	"PRX_SD.bmp",	"PRX_L.bmp",	"PRX_LD.bmp" 	);

//  	Techlevel	CombatValue	Mass				
weaponInfo2(	2 ,	425 ,	3.00	);			

//	Reload/anim_time	Lock_time	Converge				
weaponGeneral(	1.5 ,	0.0 ,	F	);			

//	FireOffset (X)	(Y)	(Z)	FireTime			
weaponShot(	0.00 ,	1.00 ,	1.00		);		

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley			
weaponAmmo(	32 ,	8 ,	8 ,	1	);		


//-------------------------------------------------------------------------								
// Proximity 15 pack {common}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	136 ,	"wg_vip8.dts",	L,	IDSFX_PRX15,	1200 ,	A,	IDSPEC_WEA_PRX15	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_PRX15,	IDWDESC_PRX15,	"PRX_S.bmp",	"PRX_SD.bmp",	"PRX_L.bmp",	"PRX_LD.bmp" 	);	

//  	Techlevel	CombatValue	Mass					
weaponInfo2(	3 ,	450 ,	5.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.5 ,	0.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.00 ,	1.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	32 ,	10 ,	10 ,	1	);			

								

// artillery weapons								

//-------------------------------------------------------------------------								
// Nike Siege Gun {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	1 ,	"wt_nike.dts",	X,	IDSFX_NIKE,	1050 ,	H,	IDSPEC_WEA_NIKE	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_NIKE,	IDWDESC_NIKE,	"HBC_S.bmp",	"HBC_SD.bmp",	"HBC_L.bmp",	"HBC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	1000 ,	8.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	3.5 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	13.25 ,	0.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	40 ,	30 ,	30 ,	1	);			


//-------------------------------------------------------------------------								
// Artillery Missle Launcher { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	2 ,	"wg_vip12.dts",	X,	IDSFX_AML,	1050 ,	A,	IDSPEC_WEA_AML	);
// right shape but not working now		"wp_misl.dts",						
//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_AML,	IDWDESC_AML,	"6missilePack_S.bmp",	"6missilePack_SD.bmp",	"6missilePack_L.bmp",	"6missilePack_LD.bmp" 	);	
// right shape but not working now		wp_misl.dts,						
//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	1000 ,	15.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	5.0 ,	10.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	0.20 ,	1.50		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	41 ,	10 ,	10 ,	1	);			

								

// special weapons								

//-------------------------------------------------------------------------								
// Radiation Gun {cybrid}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	142 ,	"wc_rad.dts",	M,	IDSFX_RAD,	900 ,	C,	IDSPEC_WEA_RAD	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_RAD,	IDWDESC_RAD,	"RAD_S.bmp",	"RAD_SD.bmp",	"RAD_L.bmp",	"RAD_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	770 ,	3.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_blas.dts",	"mz_blasT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	1.50 ,	0.80		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	42 ,	112 ,	75.00	);				


//-------------------------------------------------------------------------								
// Disrupter {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	3 ,	"wt_dis.dts",	M,	IDSFX_DIS,	1000 ,	H,	IDSPEC_WEA_DIS	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_DIS,	IDWDESC_DIS,	"DIS_S.bmp",	"DIS_SD.bmp",	"DIS_L.bmp",	"DIS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	6 ,	600 ,	4.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_dis.dts",	"mz_disT.dts",	T,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	3.50 ,	1.00		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	43 ,	105 ,	70.00	);				


//-------------------------------------------------------------------------								
// Electrohull {terran}								

// This is some ramming enhancer which is fired automatically in a collision with								
// another vehicle								

//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	4 ,	internal,	M,	IDSFX_EHUL,	300 ,	H,	IDSPEC_WEA_EHUL	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp	
weaponInfo1(	IDWEA_EHUL,	IDWDESC_EHUL,	"EHUL_S.bmp",	"EHUL_SD.bmp",	"EHUL_L.bmp",	"EHUL_LD.bmp" 	);

//	Techlevel	CombatValue	Mass				
weaponInfo2(	6 ,	500 ,	5.00	);			

//	Reload/anim_time	Lock_time	Converge				
weaponGeneral(	2.0 ,	0.0 ,	T	);			

//	FireOffset (X)	(Y)	(Z)	FireTime			
weaponShot(	0.00 ,	0.20 ,	1.50		);		

//	projectileId 	Charge_limit	Charge_rate				
weaponEnergy(	44 ,	200 ,	20.00	);			


//-------------------------------------------------------------------------								
// Seismic Probe {terran}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
//newWeapon(	5 ,	"wg_las.dts",	M,	IDSFX_PROB,	1000 ,	H,	IDSPEC_WEA_PROB	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
//weaponInfo1(	IDWEA_PROB,	IDWDESC_PROB,	"RAIL_S.bmp",	"RAIL_SD.bmp",	"RAIL_L.bmp",	"RAIL_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
//weaponInfo2(	7 ,	1000 ,	16.00	);				

//	Reload/anim_time	Lock_time	Converge					
//weaponGeneral(	5.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	0.20 ,	1.50		);			

//	projectileId 	Charge_limit	Charge_rate					
//weaponEnergy(	45 ,	500 ,	20.00	);				
								

//-------------------------------------------------------------------------								
// Finger of God {terran}								

// The FOG is about as special as they get.  	What is actually mounted to the vehicle							
// is merely some kind of radio switch (thus	no shape) which informs the satellite that							
// it should fire at the current target.  	The beam itself will originate from the sky.							

//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
//newWeapon(	146 ,	internal,	X,	IDSFX_FOG,	1000 ,	H,	IDSPEC_WEA_FOG	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
//weaponInfo1(	IDWEA_FOG,	IDWDESC_FOG,	"RAIL_S.bmp",	"RAIL_SD.bmp",	"RAIL_L.bmp",	"RAIL_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
//weaponInfo2(	1 ,	2000 ,	1.00	);				

//	Reload/anim_time	Lock_time	Converge					
//weaponGeneral(	1.0 ,	30.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
//weaponShot(	0.00 ,	0.00 ,	0.00		);			

//  	projectileId  	maxAmmo	startAmmo	roundsPerVolley				
//weaponAmmo(	46 ,	1 ,	1 ,	1	);			

//-------------------------------------------------------------------------								
// Cybrid Artillery Gun								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	20 ,	"wc_artl.dts",	X,	IDSFX_NIKE,	1050 ,	C,	IDSPEC_WEA_BC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_CYART,	IDWDESC_CYART,	"HBC_S.bmp",	"HBC_SD.bmp",	"HBC_L.bmp",	"HBC_LD.bmp" 	);	
								
//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	1000 ,	10.00	);				
								
//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);
								
//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	4.0 ,	0.0 ,	T	);				
								
//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	15.65 ,	0.00		);			
								
//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	60 ,	30 ,	30 ,	1	);			
								
//-------------------------------------------------------------------------								
// Rebel Artillery Gun								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	21 ,	"wr_artl.dts",	X,	IDSFX_NIKE,	1050 ,	H,	IDSPEC_WEA_BC	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_RBART,	IDWDESC_RBART,	"HBC_S.bmp",	"HBC_SD.bmp",	"HBC_L.bmp",	"HBC_LD.bmp" 	);	
								
//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	1000 ,	10.00	);				
								
//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);
								
//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	4.0 ,	0.0 ,	T	);				
								
//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	12.14 ,	0.00		);			
								
//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	60 ,	30 ,	30 ,	1	);			

//-------------------------------------------------------------------------								
//Smart Gun								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	Description Tag	
newWeapon(	150 ,	"wm_sgun.dts",	M,	IDSFX_SGUN,	900 ,	X,	IDSPEC_WEA_SGUN    	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_SGUN,	IDWDESC_SGUN,	"SGUN_S.bmp",	"SGUN_SD.bmp",	"SGUN_L.bmp",	"SGUN_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	7 ,	625 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_blas.dts",	"mz_blasT.dts",	T,	112 ,	246 ,	116 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	0.8 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	2.50 ,	0.70		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	50 ,	20 ,	25.00	);				
								
								
// Turret weapons								

//-------------------------------------------------------------------------								
// Turret Heavy Laser { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	6 ,	"wx_gun.dts",	X,	IDSFX_HLAS,	225,	A	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_HLAS,	IDWDESC_TUR_HLAS,	"HLAS_S.bmp",	"HLAS_SD.bmp",	"HLAS_L.bmp",	"HLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	2 ,	150 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_las.dts",	"mz_lasT.dts",	T,	239 ,	90 ,	90 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	5.00 ,	0.52		);			
								
//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	2 ,	30 ,	15.00	);				


//-------------------------------------------------------------------------								
// Turret Internal Pit Viper Single-Shot { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	7 ,	internal,	S,	IDSFX_VIP8,	20,	A	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_IVIP1,	IDWDESC_TUR_IVIP1,	"VIP_S.bmp",	"VIP_SD.bmp",	"VIP_L.bmp",	"VIP_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	0 ,	300 ,	3.00	);				

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.5 ,	3.0 ,	F	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	0.00 ,	0.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	24 ,	1 ,	1 ,	1	);			
								

//-------------------------------------------------------------------------								
// Turret Internal Heavy Laser { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	8,	"internal",	X,	IDSFX_HLAS,	225,	A	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_IHLAS,	IDWDESC_TUR_IHLAS,	"HLAS_S.bmp",	"HLAS_SD.bmp",	"HLAS_L.bmp",	"HLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	2 ,	150 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_las.dts",	"mz_lasT.dts",	T,	239 ,	90 ,	90 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	5.00 ,	0.52		);			

//	projectileId 	Charge_limit	Charge_rate					
weaponEnergy(	2 ,	30 ,	15.00	);				
								

//-------------------------------------------------------------------------								
// Turret Cannon { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	9 ,	"wx_can.dts",	X,	IDSFX_BC,	1200,	A	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_CAN,	IDWDESC_TUR_CAN,	"BC_S.bmp",	"BC_SD.bmp",	"BC_L.bmp",	"BC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	4 ,	920 ,	8.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.7 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	18.35 ,	0.57		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	19 ,	25 ,	25 ,	1	);			
								

//-------------------------------------------------------------------------								
// Turret Artillery { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	12 ,	"wx_artl.dts",	X,	IDSFX_HBC,	600,	A	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_ARTL,	IDWDESC_TUR_ARTL,	"HBC_S.bmp",	"HBC_SD.bmp",	"HBC_L.bmp",	"HBC_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	1015 ,	10.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_rail.dts",	"mz_railT.dts",	T,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	11.52 ,	0.00		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	20 ,	15 ,	15 ,	1	);			
								

//-------------------------------------------------------------------------								
// Turret Internal Sentry {common}								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	13 ,	"wc_pbw.dts",	I,	IDSFX_PBW,	1200,	A	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_ISENT,	IDWDESC_TUR_ISENT,	"PBW_S.bmp",	"PBW_SD.bmp",	"PBW_L.bmp",	"PBW_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	5 ,	900 ,	7.50	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_pbw.dts",	"mz_pbwT.dts",	T,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.8 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	0.00 ,	0.00		);			

//	projectileId 	Charge_limit	Charge_rate				
weaponEnergy(	9 ,	100 ,	50.00	);			


//-------------------------------------------------------------------------							
// Turret Heavy Autocannon { common }							
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base	
newWeapon(	14 ,	"wx_gat.dts",	X,	IDSFX_HATC,	400,	A	);

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp	
weaponInfo1(	IDWEA_TUR_HATC,	IDWDESC_TUR_HATC,	"HATC_S.bmp",	"HATC_SD.bmp",	"HATC_L.bmp",	"HATC_LD.bmp" 	);

//	Techlevel	CombatValue	Mass				
weaponInfo2(	2 ,	150 ,	5.00	);			

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange
weaponMuzzle(	"mz_hatc.dts",	"mz_hatcT.dts",	F,	255 ,	208 ,	62 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	1.0 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	6.00 ,	1.50		);			

//  	projectileId	maxAmmo	startAmmo	roundsPerVolley				
weaponAmmo(	17 ,	4000 ,	4000 ,	21	);			


//-------------------------------------------------------------------------								
// MFAC Turret (Heavy Laser) { common }								
//	Id	Shape	Size	Sound_Tag	Damage	Tech Base		
newWeapon(	15 ,	"wx_TURM.dts",	X,	IDSFX_MFAC,	225,	H	);	

//	ShortName_tag	Longname_tag	SmallBmp	SmDisabledBmp	LargeBmp	LgDisabledBmp		
weaponInfo1(	IDWEA_TUR_MFAC,	IDWDESC_TUR_MFAC,	"HLAS_S.bmp",	"HLAS_SD.bmp",	"HLAS_L.bmp",	"HLAS_LD.bmp" 	);	

//	Techlevel	CombatValue	Mass					
weaponInfo2(	2 ,	150 ,	5.00	);				

//	MuzzleShape	Trans MuzzleShape	FaceCamera	FlashColor (R)	(G)	(B)	FlashRange	
weaponMuzzle(	"mz_mfac.dts",	"mz_mfacT.dts",	F,	72 ,	150 ,	255 ,	2.5	);

//	Reload/anim_time	Lock_time	Converge					
weaponGeneral(	2.8 ,	0.0 ,	T	);				

//	FireOffset (X)	(Y)	(Z)	FireTime				
weaponShot(	0.00 ,	5.00 ,	0.52		);			

//	projectileId 	Charge_limit	Charge_rate				
weaponEnergy(	13 ,	155 ,	50.00	);			

