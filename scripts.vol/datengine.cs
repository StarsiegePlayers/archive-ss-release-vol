# Engines Data Script					
# Engine id numbers: 100-199					
# Vel_Rating/tons   = percentage of chassis top speed (capped).					
# Accel_Rating/tons = percentage of chassis max accleration (capped).					
#					
# Accel@Max_V indicates the low end of the accleration curve					
# at the maximum potential speed for a vehicle with this engine.					
#					
# Mountpoint size indicates the internal engine mount size required.					
#					
# Damage is the "hitpoints" for the engine component					
#					
#IMPORTANT: ONLY MODIFY COMPONENT STATS IN SUMMARY SHEET					
#------------------------------------------------------------------------------					
# Vehicle Engine Data Fields					
# 		id	Vel_Rating	Accel_Rating	Accel@Max_V
# newEngine								
# 		ShortName_tag	LongName_tag	SmallBmp   SmallDisBmp  LargeBmp LargeDisBMP				
# engine info1								
# 		Tech Level	Combat Value	Mass	Mountpoint_Size	Damage		
# engineInfo2								
#								
# 								
#------------------------------------------------------------------------------								
# Human Light Vehicle Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine ( 	100 ,	1000 ,	3000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM1,	IDENG_HUM1_L,	"huEngineS1_S.bmp",	"huEngineS1_SD.bmp",	"huEngineS1_L.bmp",	"huEngineS1_LD.bmp",	IDCSPEC_ENG_HUM1	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	1 ,	H ,	506 ,	1.5 ,	S ,	800	);	


#------------------------------------------------------------------------------								
# Human High Output Light Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	101 ,	2000 ,	2500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM4,	IDENG_HUM4_L,	"huEngineS2_S.bmp",	"huEngineS2_SD.bmp",	"huEngineS2_L.bmp",	"huEngineS2_LD.bmp",	IDCSPEC_ENG_HUM2	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	2 ,	H ,	537 ,	2.0 ,	S ,	900	);	
								

#------------------------------------------------------------------------------								
# Human Agile Light Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	102 ,	3000 ,	3000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM7,	IDENG_HUM7_L,	"huEngineS3_S.bmp",	"huEngineS3_SD.bmp",	"huEngineS3_L.bmp",	"huEngineS3_LD.bmp",	IDCSPEC_ENG_HUM3	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	H ,	620 ,	2.5 ,	S ,	1200	);	
								

#------------------------------------------------------------------------------								
# Human Standard Medium Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	103 ,	2000 ,	4000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM10,	IDENG_HUM10_L,	"huEngineturbo_S.bmp",	"huEngineturbo_SD.bmp",	"huEngineturbo_L.bmp",	"huEngineturbo_LD.bmp",	IDCSPEC_ENG_HUM4	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	1 ,	H ,	620 ,	3.0 ,	M ,	1200	);	
								

#------------------------------------------------------------------------------								
# Human High Output Medium Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	104 ,	3500 ,	3500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM2,	IDENG_HUM2_L,	"huEngineM1_S.bmp",	"huEngineM1_SD.bmp",	"huEngineM1_L.bmp",	"huEngineM1_LD.bmp",	IDCSPEC_ENG_HUM5	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	2 ,	H ,	669 ,	3.5 ,	M ,	1400	);	
								

#------------------------------------------------------------------------------								
# Human Medium Agility Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	105 ,	4000 ,	4000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM5,	IDENG_HUM5_L,	"huEngineM2_S.bmp",	"huEngineM2_SD.bmp",	"huEngineM2_L.bmp",	"huEngineM2_LD.bmp",	IDCSPEC_ENG_HUM6	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	H ,	716 ,	4.0 ,	M ,	1600	);	


#------------------------------------------------------------------------------								
# Human Standard Heavy Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	106 ,	4000 ,	5000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM8,	IDENG_HUM8_L,	"huEngineM3_S.bmp",	"huEngineM3_SD.bmp",	"huEngineM3_L.bmp",	"huEngineM3_LD.bmp",	IDCSPEC_ENG_HUM7	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	1 ,	H ,	759 ,	4.5 ,	L ,	1800	);	


#------------------------------------------------------------------------------								
# Human Improved Heavy Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	107 ,	5000 ,	4500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM11,	IDENG_HUM11_L,	"hu_engine1_S.bmp",	"hu_engine1_SD.bmp",	"hu_engine1_L.bmp",	"hu_engine1_LD.bmp",	IDCSPEC_ENG_HUM8	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	2 ,	H ,	780 ,	5.0 ,	L ,	1900	);	


#------------------------------------------------------------------------------								
# Human Heavy Cruise Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	108 ,	5000 ,	5000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM3,	IDENG_HUM3_L,	"huEngineL1_S.bmp",	"huEngineL1_SD.bmp",	"huEngineL1_L.bmp",	"huEngineL1_LD.bmp",	IDCSPEC_ENG_HUM9	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	3 ,	H ,	800 ,	5.5 ,	L ,	2000	);	
								

#------------------------------------------------------------------------------								
# Human High Output Heavy Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	109 ,	5000 ,	6000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM6,	IDENG_HUM6_L,	"huEngineL2_S.bmp",	"huEngineL2_SD.bmp",	"huEngineL2_L.bmp",	"huEngineL2_LD.bmp",	IDCSPEC_ENG_HUM10	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	H ,	839 ,	6.0 ,	L ,	2200	);	


#------------------------------------------------------------------------------								
# Human Agile Heavy Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	110 ,	6000 ,	6000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM9,	IDENG_HUM9_L,	"huEngineL3_S.bmp",	"huEngineL3_SD.bmp",	"huEngineL3_L.bmp",	"huEngineL3_LD.bmp",	IDCSPEC_ENG_HUM11	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	5 ,	H ,	876 ,	7.0 ,	L ,	2400	);	
								
								
#------------------------------------------------------------------------------								
#------------------------------------------------------------------------------								
# Human Standard Assault Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	111 ,	6000 ,	7500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM12,	IDENG_HUM12_L,	"hu_engine2_S.bmp",	"hu_engine2_SD.bmp",	"hu_engine2_L.bmp",	"hu_engine2_LD.bmp",	IDCSPEC_ENG_HUM12	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	H ,	930 ,	8.0 ,	X ,	2700	);	


#------------------------------------------------------------------------------								
# Human Improved Assault Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	112 ,	7000 ,	8000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM13,	IDENG_HUM13_L,	"hu_engine3_S.bmp",	"hu_engine3_SD.bmp",	"hu_engine3_L.bmp",	"hu_engine3_LD.bmp",	IDCSPEC_ENG_HUM13	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	5 ,	H ,	980 ,	9.0 ,	X ,	3000	);	


#------------------------------------------------------------------------------								
# Human heavy turbine engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	113 ,	8000 ,	8000 ,	1.00	);			
#								
#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM15,	IDENG_HUM15_L,	"hu_flyengineS_S.bmp",	"hu_flyengineS_SD.bmp",	"hu_flyengineS_L.bmp",	"hu_flyengineS_LD.bmp",	IDCSPEC_ENG_HUM14	);
#								
#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	6 ,	H ,	1012 ,	10.0 ,	X ,	3200	);	


#------------------------------------------------------------------------------								
# High Output Turbine (HOT)								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	114 ,	8500 ,	9000 ,	1.00	);			
#								
#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM16,	IDENG_HUM16_L,	"hu_flyengineL_S.bmp",	"hu_flyengineL_SD.bmp",	"hu_flyengineL_L.bmp",	"hu_flyengineL_LD.bmp",	IDCSPEC_ENG_HUM15	);
#								
#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	7 ,	H ,	1058 ,	11.0 ,	X ,	3500	);	


#------------------------------------------------------------------------------								
# Human super heavy engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	115 ,	9000 ,	9000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_HUM14,	IDENG_HUM14_L,	"hu_engine4_S.bmp",	"hu_engine4_SD.bmp",	"hu_engine4_L.bmp",	"hu_engine4_LD.bmp",	IDCSPEC_ENG_HUM16	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	8 ,	H ,	1073 ,	12.5 ,	X ,	3600	);	


# Human RocketMan Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
##newEngine (	125 ,	10000 ,	10000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
##engineInfo1 (	IDENG_HUM25,	IDENG_HUM25_L,	"rocketboost_S.bmp",	"rocketboost_SD.bmp",	"rocketboost_L.bmp",	"rocketboost_LD.bmp",	IDCSPEC_ENG_HUM25	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
##engineInfo2 (	127 ,	H ,	1131 ,	16.5 ,	S ,	4000	);	


#------------------------------------------------------------------------------								
# Cybrid Alpha Light Vehicle Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine ( 	128 ,	1500 ,	2500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB1,	IDENG_CYB1_L,	"cyEngineS1_S.bmp",	"cyEngineS1_SD.bmp",	"cyEngineS1_L.bmp",	"cyEngineS1_LD.bmp",	IDCSPEC_ENG_CYB1	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	1 ,	C ,	506 ,	1.5 ,	S ,	800	);	


#------------------------------------------------------------------------------								
# Cybrid Beta Light Agility Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	129 ,	2500 ,	2500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB2,	IDENG_CYB2_L,	"cyEngineM1_S.bmp",	"cyEngineM1_SD.bmp",	"cyEngineM1_L.bmp",	"cyEngineM1_LD.bmp",	IDCSPEC_ENG_CYB2	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	3 ,	C ,	566 ,	2.0 ,	S ,	1000	);	
								

#------------------------------------------------------------------------------								
# Cybrid Gamma Standard Medium Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	130 ,	2000 ,	3500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB3,	IDENG_CYB3_L,	"cyEngineL1_S.bmp",	"cyEngineL1_SD.bmp",	"cyEngineL1_L.bmp",	"cyEngineL1_LD.bmp",	IDCSPEC_ENG_CYB3	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	1 ,	C ,	593 ,	2.5 ,	M ,	1100	);	
								

#------------------------------------------------------------------------------								
# Cybrid Delta Medium Cruise Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	131 ,	3000 ,	3000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB4,	IDENG_CYB4_L,	"cyEngineS2_S.bmp",	"cyEngineS2_SD.bmp",	"cyEngineS2_L.bmp",	"cyEngineS2_LD.bmp",	IDCSPEC_ENG_CYB4	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	2 ,	C ,	620 ,	3.0 ,	M ,	1200	);	
								

#------------------------------------------------------------------------------								
# Cybrid Epsilon Improved Medium Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	132 ,	3000 ,	3500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB5,	IDENG_CYB5_L,	"cyEngineM2_S.bmp",	"cyEngineM2_SD.bmp",	"cyEngineM2_L.bmp",	"cyEngineM2_LD.bmp",	IDCSPEC_ENG_CYB5	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	3 ,	C ,	645 ,	3.5 ,	M ,	1300	);	


#------------------------------------------------------------------------------								
# Cybrid Zeta Medium High Output Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	133 ,	4000 ,	3500 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB6,	IDENG_CYB6_L,	"cyEngineL2_S.bmp",	"cyEngineL2_SD.bmp",	"cyEngineL2_L.bmp",	"cyEngineL2_LD.bmp",	IDCSPEC_ENG_CYB6	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	3 ,	C ,	693 ,	4.0 ,	M ,	1500	);	


#------------------------------------------------------------------------------								
# Cybrid Eta Medium Agility Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	134 ,	4000 ,	4000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB7,	IDENG_CYB7_L,	"cyEngineS3_S.bmp",	"cyEngineS3_SD.bmp",	"cyEngineS3_L.bmp",	"cyEngineS3_LD.bmp",	IDCSPEC_ENG_CYB7	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	C ,	716 ,	4.5 ,	M ,	1600	);	
								

#------------------------------------------------------------------------------								
# Cybrid Theta Standard Heavy Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	135 ,	4000 ,	4800 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB8,	IDENG_CYB8_L,	"cyEngineM3_S.bmp",	"cyEngineM3_SD.bmp",	"cyEngineM3_L.bmp",	"cyEngineM3_LD.bmp",	IDCSPEC_ENG_CYB8	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	3 ,	C ,	750 ,	5.0 ,	L ,	1760	);	


#------------------------------------------------------------------------------								
# Cybrid Iota Heavy High Output Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	136 ,	4800 ,	4300 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB9,	IDENG_CYB9_L,	"cyEngineL3_S.bmp",	"cyEngineL3_SD.bmp",	"cyEngineL3_L.bmp",	"cyEngineL3_LD.bmp",	IDCSPEC_ENG_CYB9	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	C ,	763 ,	5.5 ,	L ,	1820	);	

#------------------------------------------------------------------------------								
# Cybrid Kappa Heavy Agility Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	137 ,	4800 ,	5000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB10,	IDENG_CYB10_L,	"cyEngineturbo_S.bmp",	"cyEngineturbo_SD.bmp",	"cyEngineturbo_L.bmp",	"cyEngineturbo_LD.bmp",	IDCSPEC_ENG_CYB10	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	5 ,	C ,	792 ,	6.0 ,	L ,	1960	);	
#------------------------------------------------------------------------------								
# Cybrid Lamda Standard Assault Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	138 ,	5000 ,	6000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB11,	IDENG_CYB11_L,	"cy_engine1_S.bmp",	"cy_engine1_SD.bmp",	"cy_engine1_L.bmp",	"cy_engine1_LD.bmp",	IDCSPEC_ENG_CYB11	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	4 ,	C ,	839 ,	6.0 ,	x ,	2200	);	


#------------------------------------------------------------------------------								
# Cybrid Mu Improved Assault Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	139 ,	6000 ,	7000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB12,	IDENG_CYB12_L,	"cy_engine2_S.bmp",	"cy_engine2_SD.bmp",	"cy_engine2_L.bmp",	"cy_engine2_LD.bmp",	IDCSPEC_ENG_CYB12	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	5 ,	C ,	912 ,	7.5 ,	x ,	2600	);	


#------------------------------------------------------------------------------								
# Cybrid Nu High Output Assault Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	140 ,	6000 ,	8000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB13,	IDENG_CYB13_L,	"cy_engine3_S.bmp",	"cy_engine3_SD.bmp",	"cy_engine3_L.bmp",	"cy_engine3_LD.bmp",	IDCSPEC_ENG_CYB13	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	6 ,	C ,	947 ,	9.0 ,	x ,	2800	);	


#------------------------------------------------------------------------------								
# Cybrid Xi Heavy Assault Engine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	141 ,	7000 ,	9000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB14,	IDENG_CYB14_L,	"cy_engine4_S.bmp",	"cy_engine4_SD.bmp",	"cy_engine4_L.bmp",	"cy_engine4_LD.bmp",	IDCSPEC_ENG_CYB14	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	7 ,	C ,	1012 ,	10.0 ,	x ,	3200	);	


#------------------------------------------------------------------------------								
# Cybrid Omicron Heavy Assault Turbine 								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	142 ,	8000 ,	9000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB15,	IDENG_CYB15_L,	"cy_flyengineS_S.bmp",	"cy_flyengineS_SD.bmp",	"cy_flyengineS_L.bmp",	"cy_flyengineS_LD.bmp",	IDCSPEC_ENG_CYB15	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	8 ,	C ,	1043 ,	10.5 ,	x ,	3400	);	


#------------------------------------------------------------------------------								
# Cybrid Pi Super Heavy Turbine								
#	id	Vel_Rating	Accel_Rating	Accel@Max_V				
newEngine (	143 ,	9000 ,	9000 ,	1.00	);			

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP		
engineInfo1 (	IDENG_CYB16,	IDENG_CYB16_L,	"cy_flyengineL_S.bmp",	"cy_flyengineL_SD.bmp",	"cy_flyengineL_L.bmp",	"cy_flyengineL_LD.bmp",	IDCSPEC_ENG_CYB16	);

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage		
engineInfo2 (	8 ,	C ,	1073 ,	12.5 ,	x ,	3600	);	

