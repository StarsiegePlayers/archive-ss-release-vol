# Sensor Data File														
# Sensor ID numbers: 400-499														
#														
# IMPORTANT: ONLY MODIFY DATA PARAMETERS IN SUMMARY SHEET														
#------------------------------------------------------------------------------														
# Basic Human Sensor														
#	id	Sweep_Time												
newSensor ( 	400 ,	2.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.50 ,	900 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.10 ,	0.20 ,	0.40 ,	-2.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.30 ,	500 ,	-0.30 ,	0.00 ,	-0.20 ,	0.20 ,	0.40 ,	0.70 ,	-0.60 ,	0.30 ,	0.20 ,	-0.60	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM1,	IDSEN_HUM1_L,	"huSensorS2_S.bmp",	"huSensorS2_SD.bmp",	"huSensorS2_L.bmp",	"huSensorS2_LD.bmp",	IDCSPEC_SEN_HUM1	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	1 ,	H ,	131 ,	1.0 ,	s ,	506	);							


#------------------------------------------------------------------------------														
# Long Range Sensor -- Ranger														
#	id	Sweep_Time												
newSensor ( 	401 ,	3.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a ,	0.65 ,	1200 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.05 ,	0.10 ,	0.40 ,	-2.00 ,	-0.40 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.30 ,	500 ,	-0.50 ,	0.00 ,	-0.20 ,	0.10 ,	0.20 ,	0.50 ,	-0.60 ,	0.20 ,	0.10 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM7,	IDSEN_HUM7_L,	"huSensorL2_S.bmp",	"huSensorL2_SD.bmp",	"huSensorL2_L.bmp",	"huSensorL2_LD.bmp",	IDCSPEC_SEN_HUM2	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	3 ,	H ,	143 ,	2.5 ,	s ,	1250	);							


#------------------------------------------------------------------------------														
#Standard Human Sensor														
#	id	Sweep_Time												
newSensor ( 	408 ,	2.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a ,	0.60 ,	1000 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.10 ,	0.20 ,	0.40 ,	-2.00 ,	-0.40 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.35 ,	700 ,	-0.50 ,	0.00 ,	-0.20 ,	0.20 ,	0.30 ,	0.60 ,	-0.60 ,	0.30 ,	0.20 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM9,	IDSEN_HUM9_L,	"huSensorM2_S.bmp",	"huSensorM2_SD.bmp",	"huSensorM2_L.bmp",	"huSensorM2_LD.bmp",	IDCSPEC_SEN_HUM3	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	2 ,	H ,	181 ,	2.0 ,	s ,	1000	);							


#------------------------------------------------------------------------------														
#Human Longbow Sensor														
#	id	Sweep_Time												
newSensor ( 	409 ,	2.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.70 ,	1350 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.10 ,	0.20 ,	0.30 ,	-2.00 ,	-0.30 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.30 ,	600 ,	-0.50 ,	0.00 ,	-0.10 ,	0.20 ,	0.30 ,	0.60 ,	-0.60 ,	0.20 ,	0.20 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM10,	IDSEN_HUM10_L,	"huSensorS1_S.bmp",	"huSensorS1_SD.bmp",	"huSensorS1_L.bmp",	"huSensorS1_LD.bmp",	IDCSPEC_SEN_HUM4	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	2 ,	H ,	259 ,	2.5 ,	M ,	1250	);							


#------------------------------------------------------------------------------														
#Human Infiltrator Sensor														
#	id	Sweep_Time												
newSensor ( 	410 ,	1.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.70 ,	1200 ,	-0.30 ,	-0.30 ,	-0.20 ,	0.10 ,	0.20 ,	0.30 ,	-1.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.50 ,	850 ,	-0.30 ,	0.00 ,	-0.10 ,	0.20 ,	0.30 ,	0.50 ,	-0.50 ,	0.30 ,	0.10 ,	-0.35	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM11,	IDSEN_HUM11_L,	"huSensorL1_S.bmp",	"huSensorL1_SD.bmp",	"huSensorL1_L.bmp",	"huSensorL1_LD.bmp",	IDCSPEC_SEN_HUM5	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	3 ,	H ,	351 ,	3.5 ,	M ,	1750	);							


#------------------------------------------------------------------------------														
#Human Crossbow Sensor														
#	id	Sweep_Time												
newSensor ( 	411 ,	2.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.75 ,	1500 ,	-0.20 ,	-0.30 ,	0.00 ,	0.03 ,	0.10 ,	0.20 ,	-2.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.35 ,	700 ,	-0.50 ,	-0.05 ,	-0.15 ,	0.04 ,	0.20 ,	0.40 ,	-0.40 ,	0.20 ,	0.20 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM12,	IDSEN_HUM12_L,	"huSensorM1_S.bmp",	"huSensorM1_SD.bmp",	"huSensorM1_L.bmp",	"huSensorM1_LD.bmp",	IDCSPEC_SEN_HUM6	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	3 ,	H ,	250 ,	3.0 ,	L ,	1500	);							


#------------------------------------------------------------------------------														
#Human Ultralight Sensor														
#	id	Sweep_Time												
newSensor ( 	412 ,	2.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.60 ,	800 ,	-0.10 ,	-0.30 ,	0.00 ,	0.05 ,	0.10 ,	0.40 ,	-2.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.30 ,	500 ,	-0.50 ,	0.00 ,	-0.10 ,	0.10 ,	0.20 ,	0.60 ,	-0.60 ,	0.20 ,	0.10 ,	-0.60	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM13,	IDSEN_HUM13_L,	"huSensor3_S.bmp",	"huSensor3_SD.bmp",	"huSensor3_L.bmp",	"huSensor3_LD.bmp",	IDCSPEC_SEN_HUM7	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	2 ,	H ,	139 ,	0.5 ,	s ,	250	);							


#------------------------------------------------------------------------------														
#Human Hound Dog Sensor														
#	id	Sweep_Time												
newSensor ( 	413 ,	1.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.55 ,	900 ,	-0.10 ,	-0.20 ,	0.00 ,	0.10 ,	0.20 ,	0.40 ,	-1.50 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.45 ,	650 ,	-0.30 ,	0.00 ,	-0.10 ,	0.30 ,	0.50 ,	0.50 ,	-0.40 ,	0.20 ,	0.20 ,	-0.20	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM14,	IDSEN_HUM14_L,	"huSensor4_S.bmp",	"huSensor4_SD.bmp",	"huSensor4_L.bmp",	"huSensor4_LD.bmp",	IDCSPEC_SEN_HUM8	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	4 ,	H ,	214 ,	1.5 ,	M ,	750	);							


#------------------------------------------------------------------------------														
#Thermal Sensor														
#	id	Sweep_Time												
newSensor ( 	414 ,	1.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.35 ,	1000 ,	-0.10 ,	-0.30 ,	0.00 ,	0.20 ,	0.30 ,	0.60 ,	-0.50 ,	-0.50 ,	0.00 ,	-0.50	);#
sensorMode (	p,	0.60 ,	750 ,	-0.70 ,	0.00 ,	-0.10 ,	0.20 ,	0.30 ,	0.70 ,	-0.60 ,	0.50 ,	0.30 ,	-0.50	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_HUM8,	IDSEN_HUM8_L,	"huThermsensor_S.bmp",	"huThermsensor_SD.bmp",	"huThermsensor_L.bmp",	"huThermsensor_LD.bmp",	IDCSPEC_SEN_HUM9	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	4 ,	H ,	192 ,	1.5 ,	M ,	769	);							


#------------------------------------------------------------------------------														
# U can Run But U can't Hide Sensor														
#	id	Sweep_Time												
##newSensor ( 	425 ,	1.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
##sensorMode (	a,	1.00 ,	2000 ,	-0.20 ,	-0.10 ,	0.00 ,	0.05 ,	0.10 ,	0.20 ,	-0.50 ,	-0.50 ,	-0.05 ,	0.00	);#
##sensorMode (	p,	1.00 ,	1500 ,	-0.30 ,	0.00 ,	-0.10 ,	0.10 ,	0.15 ,	0.50 ,	-0.20 ,	0.20 ,	0.10 ,	-0.20	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
##sensorInfo1 (	IDSEN_HUM25,	IDSEN_HUM25_L,	"huSensor3_S.bmp",	"huSensor3_SD.bmp",	"huSensor3_L.bmp",	"huSensor3_LD.bmp",	IDCSPEC_SEN_HUM25	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
##sensorInfo2 (	1 ,	X ,	917 ,	5.5 ,	X ,	2751	);							


#------------------------------------------------------------------------------														
# Basic Cybrid Sensor (Alpha)														
#	id	Sweep_Time												
newSensor ( 	426 ,	2.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.55 ,	900 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.10 ,	0.20 ,	0.40 ,	-2.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.35 ,	500 ,	-0.30 ,	0.00 ,	-0.20 ,	0.20 ,	0.40 ,	0.70 ,	-0.70 ,	0.30 ,	0.20 ,	-0.60	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB1,	IDSEN_CYB1_L,	"cySensorS2_S.bmp",	"cySensorS2_SD.bmp",	"cySensorS2_L.bmp",	"cySensorS2_LD.bmp",	IDCSPEC_SEN_CYB1	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	1 ,	C ,	117 ,	1.0 ,	s ,	506	);							


#------------------------------------------------------------------------------														
# Long Range Cybrid Sensor (Beta)														
#	id	Sweep_Time												
newSensor ( 	427 ,	3.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.70 ,	1200 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.05 ,	0.10 ,	0.30 ,	-2.00 ,	-0.40 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.35 ,	500 ,	-0.50 ,	0.00 ,	-0.20 ,	0.10 ,	0.20 ,	0.60 ,	-0.70 ,	0.20 ,	0.10 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB2,	IDSEN_CYB2_L,	"cySensorL2_S.bmp",	"cySensorL2_SD.bmp",	"cySensorL2_L.bmp",	"cySensorL2_LD.bmp",	IDCSPEC_SEN_CYB2	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	3 ,	C ,	133 ,	2.5 ,	s ,	1237	);							


#------------------------------------------------------------------------------														
#Standard Cybrid Sensor (Gamma)														
#	id	Sweep_Time												
newSensor ( 	428 ,	2.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.65 ,	1000 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.10 ,	0.20 ,	0.30 ,	-2.00 ,	-0.40 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.40 ,	700 ,	-0.50 ,	0.00 ,	-0.20 ,	0.20 ,	0.30 ,	0.50 ,	-0.60 ,	0.30 ,	0.20 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB3,	IDSEN_CYB3_L,	"cySensorM2_S.bmp",	"cySensorM2_SD.bmp",	"cySensorM2_L.bmp",	"cySensorM2_LD.bmp",	IDCSPEC_SEN_CYB3	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	2 ,	C ,	158 ,	2.0 ,	s ,	1000	);							


#------------------------------------------------------------------------------														
#Cybrid Longbow Sensor (Delta)														
#	id	Sweep_Time												
newSensor ( 	429 ,	2.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.75 ,	1350 ,	-0.10 ,	-0.30 ,	-0.10 ,	0.10 ,	0.20 ,	0.20 ,	-2.00 ,	-0.30 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.35 ,	600 ,	-0.50 ,	0.00 ,	-0.10 ,	0.20 ,	0.30 ,	0.60 ,	-0.60 ,	0.20 ,	0.20 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB4,	IDSEN_CYB4_L,	"cySensorS1_S.bmp",	"cySensorS1_SD.bmp",	"cySensorS1_L.bmp",	"cySensorS1_LD.bmp",	IDCSPEC_SEN_CYB4	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	2 ,	C ,	224 ,	2.5 ,	M ,	1250	);							


#------------------------------------------------------------------------------														
#Cybrid Infiltrator Sensor (Epsilon)														
#	id	Sweep_Time												
newSensor ( 	430 ,	2.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.70 ,	1100 ,	-0.30 ,	-0.30 ,	-0.20 ,	0.10 ,	0.20 ,	0.30 ,	-1.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.55 ,	850 ,	-0.30 ,	0.00 ,	-0.10 ,	0.20 ,	0.30 ,	0.50 ,	-0.60 ,	0.30 ,	0.10 ,	-0.35	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB5,	IDSEN_CYB5_L,	"cySensorL1_S.bmp",	"cySensorL1_SD.bmp",	"cySensorL1_L.bmp",	"cySensorL1_LD.bmp",	IDCSPEC_SEN_CYB5	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	3 ,	C ,	251 ,	3.0 ,	m ,	1500	);							


#------------------------------------------------------------------------------														
#Cybrid Crossbow Sensor (Zeta)														
#	id	Sweep_Time												
newSensor ( 	431 ,	3.00	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.75 ,	1500 ,	-0.20 ,	-0.30 ,	0.00 ,	0.03 ,	0.10 ,	0.20 ,	-2.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.40 ,	700 ,	-0.50 ,	-0.05 ,	-0.15 ,	0.04 ,	0.20 ,	0.50 ,	-0.60 ,	0.20 ,	0.20 ,	-0.40	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB6,	IDSEN_CYB6_L,	"cySensorM1_S.bmp",	"cySensorM1_SD.bmp",	"cySensorM1_L.bmp",	"cySensorM1_LD.bmp",	IDCSPEC_SEN_CYB6	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	3 ,	C ,	211 ,	2.5 ,	L ,	1254	);							


#------------------------------------------------------------------------------														
#Cybrid Ultralight Sensor (Eta)														
#	id	Sweep_Time												
newSensor ( 	432 ,	2.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.60 ,	800 ,	-0.10 ,	-0.30 ,	0.00 ,	0.05 ,	0.10 ,	0.50 ,	-2.00 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.35 ,	500 ,	-0.50 ,	0.00 ,	-0.10 ,	0.10 ,	0.20 ,	0.50 ,	-0.60 ,	0.20 ,	0.10 ,	-0.60	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB7,	IDSEN_CYB7_L,	"cySensor3_S.bmp",	"cySensor3_SD.bmp",	"cySensor3_L.bmp",	"cySensor3_LD.bmp",	IDCSPEC_SEN_CYB7	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	2 ,	C ,	114 ,	0.5 ,	s ,	250	);							


#------------------------------------------------------------------------------														
#Cybrid Hound Dog Sensor (Theta)														
#	id	Sweep_Time												
newSensor ( 	433 ,	1.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.55 ,	900 ,	-0.10 ,	-0.20 ,	0.00 ,	0.10 ,	0.20 ,	0.40 ,	-1.50 ,	-0.50 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.45 ,	650 ,	-0.30 ,	0.00 ,	-0.10 ,	0.30 ,	0.50 ,	0.60 ,	-0.45 ,	0.20 ,	0.20 ,	-0.20	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB8,	IDSEN_CYB8_L,	"cySensor4_S.bmp",	"cySensor4_SD.bmp",	"cySensor4_L.bmp",	"cySensor4_LD.bmp",	IDCSPEC_SEN_CYB8	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage								
sensorInfo2 (	4 ,	C ,	214 ,	1.5 ,	M ,	750	);							


#------------------------------------------------------------------------------														
#Motion Detector (Iota)														
#	id	Sweep_Time												
newSensor ( 	434 ,	1.50	);											
														
#	[a/p]	base	range	shutdown	squat	stop	slow	fast	activ	camo	jam	shld	tjam	
sensorMode (	a,	0.40 ,	1000 ,	-0.10 ,	-0.30 ,	-0.20 ,	0.40 ,	0.80 ,	0.00 ,	-0.50 ,	-0.30 ,	0.00 ,	0.00	);#
sensorMode (	p,	0.60 ,	750 ,	-0.90 ,	-0.80 ,	-0.30 ,	0.50 ,	1.00 ,	0.30 ,	-0.50 ,	0.50 ,	0.00 ,	-0.20	);#

#	ShortName_tag	LongName_tag	SmallBmp	SmallDisBmp        	LargeBmp	LargeDisBMP	Description Tag							
sensorInfo1 (	IDSEN_CYB9,	IDSEN_CYB9_L,	"cyThermsensor_S.bmp",	"cyThermsensor_SD.bmp",	"cyThermsensor_L.bmp",	"cyThermsensor_LD.bmp",	IDCSPEC_SEN_CYB9	);						

#	Tech Level	Tech Base	Combat Value	Mass	Mountpoint Size	Damage	
sensorInfo2 (	4 ,	C ,	208 ,	1.5 ,	M ,	769	);

