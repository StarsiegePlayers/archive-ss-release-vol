//datProjectile.cs																									

// some notes on bullets																									
// bullets are non-tracking, non-animating projectiles that are affected by gravity.  They never face the camera																									
			//Modify Velocity & Range only in summary sheet							//modify damage only in summary sheet															
// 	Abbr 	Id 	Veloc 	Range 	Pseudo Mass 	Glow Range 	Glow Color  (R)	(G)	(B)	Damage 	Blast 	Concussion %	Elec %	Therm  %	Spec %	Passthru Shield 	Passthru Armor 	Effect v. Shield	Effect v. Armor	Shape 	Transparent Shape 	ImpactId 	Shield ImpactId 	TerrainImpactId	
newBullet(	ATC,	16 ,	500 ,	650 ,	10 ,	0 ,	0 ,	0 ,	0 ,	150 ,	0 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.50 ,	1.00 ,	"pr_atc.dts",	"pr_atcT.dts",	IDDTS_IMP_BULLET,	IDDTS_SHIELD_EXP,	none 	);
newBullet(	HATC,	17 ,	350 ,	500 ,	20 ,	0 ,	0 ,	0 ,	0 ,	225 ,	0 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.50 ,	1.00 ,	"pr_hatc.dts",	"pr_hatcT.dts",	IDDTS_IMP_BULLET,	IDDTS_SHIELD_EXP,	none 	);
#EMC is now an energy weapon																									
newBullet(	BC,	19 ,	350 ,	1050 ,	200 ,	0 ,	0 ,	0 ,	0 ,	300 ,	10 ,	0.60 ,	0.20 ,	0.20 ,	0.00 ,	0.00 ,	0.00 ,	0.30 ,	1.00 ,	"pr_bc.dts",	"pr_bcT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);	
newBullet(	HBC,	20 ,	300 ,	900 ,	400 ,	0 ,	0 ,	0 ,	0 ,	400 ,	10 ,	0.60 ,	0.20 ,	0.20 ,	0.00 ,	0.00 ,	0.00 ,	0.30 ,	1.00 ,	"pr_hbc.dts",	"pr_hbcT.dts",	IDDTS_IMP_L,	IDDTS_SHIELD_LSR 	);	
#railgun is now an energy weapon																									
newBullet(	NIKE,	40 ,	300 ,	5000 ,	500 ,	0 ,	0 ,	0 ,	0 ,	750 ,	12 ,	0.50 ,	0.50 ,	0.00 ,	0.00 ,	0.50 ,	0.00 ,	0.85 ,	1.00 ,	"pr_hbc.dts",	"pr_hbcT.dts",	IDDTS_IMP_L,	IDDTS_IMP_L 	);	
newBullet(	ART,	60 ,	200 ,	5000 ,	2000 ,	0 ,	0 ,	0 ,	0 ,	750 ,	12 ,	0.50 ,	0.50 ,	0.00 ,	0.00 ,	0.50 ,	0.00 ,	1.00 ,	1.00 ,	"pr_hbc.dts",	"pr_hbcT.dts",	IDDTS_IMP_L,	IDDTS_SHIELD_SSR 	);	
// some notes on missiles																									
// missiles are tracking, animating projectiles that are essentially unaffected by gravity.  They never face the camera																									
						//Modify Range only in summary sheet							//modify damage only in summary sheet																							
//	Abbr	Id	StartVel	TermVel	Accel	Range	Min Range	Pseudo Mass	GlowRng	Glow Color (R)	(G)	(B)	Damage	Blast R	Concussion %	Elec %	Therm%	Spec %	Passthru Shield	Passthru Armor	Effect v. Shield	Effect v. Armor	Track Type	Turn Rate 1	Rate1 Timeout	Turn Rate2	Cruising	Cruise Hug Terrain	Cruise Envelope	Burn Fuel While Unarmed	Explode on Miss	Shape	Transparent Shape	Impaact Id	Shield ImpactId	
newMissile(	VIP,	24 ,	25 ,	300 ,	50 ,	800 ,	50 ,	300 ,	5 ,	253 ,	201 ,	160 ,	400 ,	6 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.00 ,	0.00 ,	0.40 ,	1.00 ,	H,	0.90 ,	0.70 ,	0.45 ,	F,	F,	0.00 ,	T,	F,	"pr_vip.dts",	"pr_vipT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
newMissile(	SPR,	25 ,	25 ,	400 ,	50 ,	1000 ,	20 ,	250 ,	5 ,	253 ,	201 ,	160 ,	450 ,	6 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.00 ,	0.00 ,	0.30 ,	1.00 ,	R,	0.95 ,	0.70 ,	0.45 ,	F,	F,	0.00 ,	T,	F,	"pr_spr.dts",	"pr_sprT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
newMissile(	SWRM,	26 ,	50 ,	450 ,	50 ,	800 ,	35 ,	450 ,	5 ,	253 ,	201 ,	160 ,	550 ,	6 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.00 ,	0.00 ,	0.40 ,	1.00 ,	R,	0.90 ,	0.70 ,	0.45 ,	F,	F,	0.00 ,	T,	T,	"pr_swrm.dts",	"pr_swrmT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
newMissile(	MIN,	27 ,	50 ,	400 ,	50 ,	1200 ,	25 ,	350 ,	5 ,	253 ,	201 ,	160 ,	450 ,	8 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.00 ,	0.00 ,	0.50 ,	1.00 ,	R,	1.00 ,	0.70 ,	0.45 ,	F,	F,	0.00 ,	T,	T,	"pr_min.dts",	"pr_minT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
newMissile(	SHRK,	28 ,	50 ,	500 ,	50 ,	750 ,	40 ,	400 ,	5 ,	253 ,	201 ,	160 ,	550 ,	8 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.00 ,	0.00 ,	0.30 ,	1.00 ,	H,	2.00 ,	0.70 ,	0.45 ,	F,	F,	0.00 ,	T,	T,	"pr_shrk.dts",	"pr_shrkT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
newMissile(	AML,	41 ,	25 ,	500 ,	50 ,	5000 ,	100 ,	250 ,	5 ,	253 ,	201 ,	160 ,	750 ,	12 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.50 ,	0.00 ,	0.85 ,	1.00 ,	R,	0.90 ,	1.00 ,	0.45 ,	T,	F,	200.00 ,	T,	F,	"pr_misl1.dts",	"pr_misl1t.dts",	IDDTS_IMP_L,	IDDTS_IMP_L 	);
newMissile(	APHID,	47 ,	35 ,	400 ,	50 ,	3000 ,	25 ,	100 ,	5 ,	253 ,	201 ,	160 ,	450 ,	8 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.00 ,	0.00 ,	0.10 ,	1.00 ,	R,	1.00 ,	1.00 ,	3.00 ,	F,	F,	0.00 ,	F,	T,	"pr_min.dts",	"pr_minT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
//newMissile(	SGUN,	50 ,	200 ,	200 ,	0 ,	700 ,	30 ,	50 ,	5 ,	253 ,	201 ,	160 ,	100 ,	0 ,	0.75 ,	0.25 ,	0.00 ,	0.00 ,	0.40 ,	0.00 ,	1.00 ,	1.00 ,	R,	3.00 ,	0.00 ,	3.00 ,	T,	T,	50.00 ,	F,	F,	"pr_hbc.dts",	"pr_hbcT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_SSR 	);
// some notes on energy																																				
// energy are non-tracking, animating projectiles that are not affected by gravity.  They may face the camera																																				
			//Modify Velocity & Range only in summary sheet							//modify damage only in summary sheet																										
//	Abbr 	Id 	Veloc 	Range 	Pseudo Mass 	Glow Range 	Glow Color  (R)	(G)	(B)	Damage 	Blast Radius	Concussion %	Elec %	Therm  %	Spec %	Passthru Shield 	Passthru Armor 	Effect v. Shield	Effect v. Armor	Face Camera	Shape 	Transparent Shape 	ImpactId 	Shield ImpactId 	TerrainImpactId											
NewEnergy(	EMP,	5 ,	700 ,	1000 ,	50 ,	5 ,	100 ,	100 ,	255 ,	125 ,	1 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	5.00 ,	0.50 ,	F,	"pr_emp.dts",	"pr_empT.dts",	IDDTS_IMP_S,	IDDTS_SHIELD_ELC	);											
NewEnergy(	BLAS,	7 ,	500 ,	1200 ,	75 ,	5 ,	100 ,	255 ,	100 ,	400 ,	0.25 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.20 ,	0.00 ,	1.00 ,	0.90 ,	T,	"pr_blas.dts",	"pr_blasT.dts",	IDDTS_IMP_S,	IDDTS_SHIELD_EXP	);											
NewEnergy(	HBLA,	8 ,	425 ,	1000 ,	100 ,	5 ,	100 ,	255 ,	100 ,	535 ,	0.25 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.20 ,	0.00 ,	1.00 ,	0.90 ,	F,	"pr_hbla.dts",	"pr_hblaT.dts",	IDDTS_IMP_S,	IDDTS_SHIELD_EXP	);								
NewEnergy(	BLNK,	11 ,	700 ,	1000 ,	0 ,	5 ,	100 ,	255 ,	100 ,	180 ,	0 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	1.00 ,	0.20 ,	0.00 ,	1.00 ,	F,	"pr_blnk.dts",	"pr_blnkT.dts",	IDDTS_IMP_S,	IDDTS_IMP_S	);								
NewEnergy(	MFAC,	13 ,	300 ,	1000 ,	300 ,	5 ,	25 ,	100 ,	255 ,	1000 ,	0.5 ,	0.40 ,	0.40 ,	0.20 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	1.00 ,	T,	"pr_mfac.dts",	"pr_mfacT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_LSR	);								
NewEnergy(	NANO,	14 ,	370 ,	400 ,	10 ,	5 ,	100 ,	255 ,	100 ,	350 ,	1 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.35 ,	0.10 ,	1.00 ,	T,	"pr_nano.dts",	"pr_nanoT.dts",	IDDTS_IMP_SP,	IDDTS_IMP_SP,	none	);							
NewEnergy(	DIS,	43 ,	600 ,	750 ,	0 ,	5 ,	50 ,	150 ,	255 ,	250 ,	0 ,	0.00 ,	0.50 ,	0.00 ,	0.50 ,	0.20 ,	0.00 ,	2.00 ,	1.00 ,	T,	"pr_dis.dts",	"pr_disT.dts",	IDDTS_SHIELD_ELC,	IDDTS_SHIELD_ELC,	none	);							
NewEnergy(	RAIL,	21 ,	1000 ,	1000 ,	350 ,	5 ,	100 ,	100 ,	255 ,	375 ,	0.5 ,	0.90 ,	0.10 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.80 ,	1.00 ,	F,	"pr_rail.dts",	"pr_railT.dts",	IDDTS_IMP_M,	IDDTS_SHIELD_EXP 	);								
NewEnergy(	EMC,	18 ,	400 ,	600 ,	30 ,	0 ,	0 ,	0 ,	0 ,	175 ,	0 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	0.75 ,	1.00 ,	F,	"pr_emc.dts",	"pr_emcT.dts",	IDDTS_IMP_BULLET,	IDDTS_SHIELD_EXP,	none 	);							
// some notes on beams																																	
// beams are potentially tracking, non-animating projectiles that are not affected by gravity.  They may face the camera -- if not, will face the firing vehicle's up vector																																	
// useful for mocking up energy			// beams, at present, can't glow								//modify damage only in summary sheet																						
			//Modify Range only in summary sheet						//Modify Velocity only in summary sheet									// Modify S,T,U,V rows only in Summary Sheet															
//	Abbr 	Id 	Range 	Beam Length	Seg Length	Target Track	Turn	Jitter	Velocity	Psuedo Mass	Damage	Var%	Blast	Concussion %	Elec %	Therm  %	Spec %	Passthru Shield 	Passthru Armor 	Effect v. Shield	Effect v. Armor	Face Camera	Near Width	Far Width	Bitmap	Trans Bitmap	Glow Color (R)	(G)	(B)	Alpha Impact ID	Shield Impact Id	Terrain Impact ID	
NewBeam(	LAS,	1 ,	750 ,	750 ,	750 ,	F,	1.00 ,	0.00 ,	2000 ,	0 ,	175 ,	20 ,	0 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.65 ,	T,	0.15 ,	0.00 ,	"@fx_las.bmp",	"fx_las.bmp",	255.00 ,	0.00 ,	0.00 ,	0.5 ,	IDDTS_IMP_TN,	IDDTS_SHIELD_ENG 	);
NewBeam(	HLAS,	2 ,	900 ,	900 ,	900 ,	F,	1.00 ,	0.00 ,	2000 ,	0 ,	300 ,	20 ,	0 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.65 ,	T,	0.25 ,	0.00 ,	"@fx_hlas.bmp",	"fx_hlas.bmp",	255.00 ,	128.00 ,	0.00 ,	0.5 ,	IDDTS_IMP_TN,	IDDTS_SHIELD_ENG 	);
NewBeam(	CLAS,	3 ,	950 ,	200 ,	950 ,	F,	1.00 ,	0.00 ,	2000 ,	0 ,	125 ,	25 ,	0 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.75 ,	T,	0.15 ,	0.00 ,	"@fx_clas.bmp",	"fx_clas.bmp",	128.00 ,	255.00 ,	0.00 ,	0.5 ,	IDDTS_IMP_TN,	IDDTS_SHIELD_ENG 	);
NewBeam(	TLAS,	4 ,	900 ,	350 ,	900 ,	F,	1.00 ,	0.00 ,	2000 ,	0 ,	150 ,	25 ,	0 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.65 ,	T,	0.25 ,	0.00 ,	"@fx_tlas.bmp",	"fx_tlas.bmp",	255.00 ,	0.00 ,	0.00 ,	0.5 ,	IDDTS_IMP_TN,	IDDTS_SHIELD_ENG 	);
NewBeam(	ELF,	6 ,	150 ,	75 ,	5 ,	F,	0.00 ,	0.20 ,	200 ,	0 ,	700 ,	0 ,	2 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.25 ,	0.00 ,	1.00 ,	1.00 ,	T,	0.35 ,	0.35 ,	"@fx_elf.bmp",	"fx_elf.bmp",	255.00 ,	255.00 ,	230.00 ,	1.0 ,	IDDTS_IMP_S,	IDDTS_SHIELD_ELC 	);	
NewBeam(	PBW,	9 ,	1000 ,	400 ,	1000 ,	F,	1.00 ,	0.00 ,	1000 ,	0 ,	600 ,	50 ,	0 ,	0.00 ,	0.50 ,	0.50 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.90 ,	T,	0.25 ,	0.50 ,	"@fx_pbw.bmp",	"fx_pbw.bmp",	0.00 ,	0.00 ,	255.00 ,	0.5 ,	IDDTS_IMP_S,	IDDTS_SHIELD_ENG 	);	
NewBeam(	PLAS,	10 ,	500 ,	25 ,	25 ,	T,	0.99 ,	0.00 ,	250 ,	250 ,	400 ,	0 ,	2 ,	0.00 ,	0.60 ,	0.40 ,	0.00 ,	0.10 ,	0.00 ,	1.00 ,	1.00 ,	T,	0.50 ,	0.50 ,	"@fx_plas.bmp",	"fx_plas.bmp",	0.00 ,	128.00 ,	255.00 ,	0.5 ,	IDDTS_IMP_S,	IDDTS_SHIELD_SSR 	);	
NewBeam(	QGUN,	12 ,	800 ,	100 ,	800 ,	F,	1.00 ,	0.00 ,	400 ,	300 ,	800 ,	0 ,	0.5 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.15 ,	0.00 ,	1.00 ,	1.00 ,	T,	0.00 ,	25.00 ,	"@fx_qgun.bmp",	"fx_qgun.bmp",	128.00 ,	0.00 ,	255.00 ,	0.5 ,	IDDTS_IMP_M,	IDDTS_IMP_M,	none 	);
NewBeam(	NCAN,	15 ,	350 ,	50 ,	10 ,	F,	0.00 ,	0.05 ,	370 ,	10 ,	500 ,	0 ,	0.5 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.30 ,	0.08 ,	1.00 ,	T,	0.15 ,	0.45 ,	"@fx_ncan.bmp",	"fx_ncan.bmp",	255.00 ,	255.00 ,	255.00 ,	0.8 ,	IDDTS_IMP_SP,	IDDTS_IMP_SP,	none 	);
NewBeam(	RAD,	42 ,	250 ,	150 ,	250 ,	F,	1.00 ,	0.00 ,	400 ,	0 ,	200 ,	0 ,	0 ,	0.00 ,	0.00 ,	0.25 ,	0.75 ,	0.50 ,	0.35 ,	1.00 ,	1.00 ,	T,	0.25 ,	0.50 ,	"@fx_rad.bmp",	"fx_rad.bmp",	255.00 ,	255.00 ,	255.00 ,	0.8 ,	IDDTS_IMP_SP,	IDDTS_IMP_SP,	none 	);
NewBeam(	EHUL,	44 ,	0 ,	0 ,	0 ,	F,	1.00 ,	0.00 ,	0 ,	100 ,	250 ,	0 ,	0 ,	0.50 ,	0.50 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	1.00 ,	T,	0.00 ,	0.00 ,	none,	none,	0.00 ,	0.00 ,	0.00 ,	0.0 ,	IDDTS_SHIELD_ELC,	IDDTS_SHIELD_ELC,	none 	);
NewBeam(	PROB,	45 ,	250 ,	10 ,	250 ,	F,	1.00 ,	0.00 ,	2 ,	0 ,	500 ,	0 ,	250 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	1.00 ,	1.00 ,	F,	0.10 ,	50.00 ,	none,	none,	0.00 ,	0.00 ,	0.00 ,	0.8 ,	IDDTS_SHOCK_S,	IDDTS_SHOCK_S,	none 	);
NewBeam(	FOG,	46 ,	1000 ,	1000 ,	1000 ,	F,	1.00 ,	0.00 ,	700 ,	1000 ,	750 ,	0 ,	2 ,	0.00 ,	0.00 ,	1.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	1.00 ,	F,	2.00 ,	2.00 ,	"@fx_fog.bmp",	"fx_fog.bmp",	255.00 ,	0.00 ,	0.00 ,	1.0 ,	IDDTS_IMP_L,	IDDTS_IMP_L 	);	
NewBeam(	SGUN,	50 ,	500 ,	3 ,	5 ,	T,	0.99 ,	0.08 ,	200 ,	250 ,	200 ,	0 ,	0 ,	0.85 ,	0.15 ,	0.00 ,	0.00 ,	0.00 ,	0.00 ,	1.00 ,	1.00 ,	T,	0.10 ,	0.10 ,	"@fx_ncan.bmp",	"fx_ncan.bmp",	255.00 ,	255.00 ,	255.00 ,	0.8 ,	IDDTS_SHIELD_ELC,	IDDTS_SHIELD_ENG 	);	
// some notes on mines																																		
// mines are potentially tracking and accelerating, animating projectiles that are affected by gravity.  Their velocity is zeroed when they hit the ground																																		
//	Abbr	Id	StartVel	TermVel	Accel	Duration	Arming Delay	Pseudo Mass	Proximity	Damage	Blast R	Concussion %	Elec %	Therm%	Spec %	Passthru Shield	Passthru Armor	Effect v. Shield	Effect v. Armor	Turn Rate	Cruise Envelope	Shape	Transparent Shape	Impaact Id	Shield ImpactId									
newMine(	ARAC,	31 ,	50 ,	50 ,	10 ,	30 ,	0 ,	100 ,	0 ,	250 ,	5 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.40 ,	0.00 ,	1.00 ,	1.00 ,	2.00 ,	10.00 ,	"pr_ara.dts",	"pr_ara.dts",	IDDTS_IMP_M,	IDDTS_IMP_M 	);								
newMine(	PROX,	32 ,	50 ,	50 ,	0 ,	30 ,	3 ,	100 ,	10 ,	350 ,	15 ,	0.75 ,	0.00 ,	0.25 ,	0.00 ,	0.40 ,	0.00 ,	1.00 ,	1.00 ,	0.00 ,	0.00 ,	"pr_prx.dts",	"pr_prx.dts",	IDDTS_IMP_M,	IDDTS_IMP_M 	);								

// some notes on bombs																				
// bombs are potentially tracking, non-accelerating, animating projectiles.  They are launched with zero velocity and accelerate only due to gravity																				
//	Abbr	Id	TermVel	Pseudo Mass	Damage	Blast R	Concussion %	Elec %	Therm%	Spec %	Passthru Shield	Passthru Armor	Effect v. Shield	Effect v. Armor	Turn Rate	Shape	Transparent Shape	Impaact Id	Shield ImpactId	
newBomb(	LGB,	22 ,	500 ,	300 ,	600 ,	10 ,	0.50 ,	0.00 ,	0.50 ,	0.00 ,	0.00 ,	0.00 ,	0.50 ,	1.00 ,	0.25 ,	"pr_vip.dts",	"pr_vipT.dts",	IDDTS_EXP_L,	IDDTS_EXP_L	);
newBomb(	HAD,	23 ,	500 ,	300 ,	500 ,	15 ,	0.30 ,	0.20 ,	0.50 ,	0.00 ,	0.00 ,	0.00 ,	0.50 ,	1.00 ,	0.00 ,	"pr_vip.dts",	"pr_vipT.dts",	IDDTS_FBALL_M,	IDDTS_FBALL_M	);
y