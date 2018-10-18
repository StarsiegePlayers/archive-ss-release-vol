#Cybrid planet inventories initial set ups			
# set the availability of a weapon	planet:		either a planet name or -1 for the stash
#	weaponId:		id of the weapon, or -1 for all weapons
#	amount:		number available, or -1 for an infinite supply
#			
#inventoryVehicleSet	(planet, vehicleId, amount);		
# set the availability of a vehicle	planet:		a planet name (cannot use the stash here)
#	vehicleId:		id of the vehicle, or -1 for all vehicles
#	amount:		number available, or -1 for an infinite supply
#			
#inventoryPilotSet	(planet, pilotId, available);		
# set the availability of a pilot	planet:		a planet name (cannot use the stash here)
#	pilotId:		id of the pilot or name of the pilot
#	available:		true/false value
#			
#inventoryList	(planet, id);		
# display availability for components, 	planet:		a planet name or -1 for the stash		
# weapons, vehicles, and pilots of the	id:		the id in question -- will display information for all types		
# specified id					
#Cybrid planets: 	Mercury,	Moon,	Ice,	Temperate,	Desert,

#Mercury,					
#weapons					
InventoryWeaponSet(	Mercury,	101,	2	);	#Laser
InventoryWeaponSet(	Mercury,	102,	2	);	#Heavy Laser
InventoryWeaponSet(	Mercury,	103,	0	);	#Comp Laser
InventoryWeaponSet(	Mercury,	104,	2	);	#Twin Laser
InventoryWeaponSet(	Mercury,	105,	0	);	#Emp
InventoryWeaponSet(	Mercury,	106,	0	);	#ELF
InventoryWeaponSet(	Mercury,	107,	0	);	#Blaster
InventoryWeaponSet(	Mercury,	108,	0	);	#Heavy Blaster
InventoryWeaponSet(	Mercury,	109,	0	);	#PBW
InventoryWeaponSet(	Mercury,	110,	0	);	#Plasma
InventoryWeaponSet(	Mercury,	111,	0	);	#Blink Gun 
InventoryWeaponSet(	Mercury,	112,	0	);	#Qgun
InventoryWeaponSet(	Mercury,	113,	0	);	#MFAC
InventoryWeaponSet(	Mercury,	114,	2	);	#Nano Infuser
InventoryWeaponSet(	Mercury,	115,	0	);	#Nanite Cannon
InventoryWeaponSet(	Mercury,	116,	2	);	#Autocannon
InventoryWeaponSet(	Mercury,	117,	2	);	#Hvy Autocannon
InventoryWeaponSet(	Mercury,	118,	2	);	#EMC Autocannon
InventoryWeaponSet(	Mercury,	119,	0	);	#Blast Cannon
InventoryWeaponSet(	Mercury,	120,	0	);	#Hvy Blast Can
InventoryWeaponSet(	Mercury,	121,	0	);	#Rail Gun
InventoryWeaponSet(	Mercury,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	Mercury,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	Mercury,	124,	2	);	#Pit Viper 8
InventoryWeaponSet(	Mercury,	125,	1	);	#Pit Viper 12
InventoryWeaponSet(	Mercury,	126,	2	);	#Sparrow 6
InventoryWeaponSet(	Mercury,	127,	2	);	#Sparrow 10
InventoryWeaponSet(	Mercury,	128,	0	);	#SWARM 6
InventoryWeaponSet(	Mercury,	129,	0	);	#Minion
InventoryWeaponSet(	Mercury,	130,	0	);	#Shrike 8
InventoryWeaponSet(	Mercury,	147,	2	);	#Aphid
InventoryWeaponSet(	Mercury,	131,	2	);	#Arachnitron 4
InventoryWeaponSet(	Mercury,	132,	0	);	#Arachnitron 8 
InventoryWeaponSet(	Mercury,	133,	2	);	#Arachnitron 12 
InventoryWeaponSet(	Mercury,	134,	0	);	#Proximity 6 
InventoryWeaponSet(	Mercury,	135,	0	);	#Proximity 10 
InventoryWeaponSet(	Mercury,	136,	0	);	#Proximity 15
InventoryWeaponSet(	Mercury,	1,	0	);	#Nike
InventoryWeaponSet(	Mercury,	2,	0	);	#AML
InventoryWeaponSet(	Mercury,	142,	0	);	#Radiation Gun
InventoryWeaponSet(	Mercury,	3,	0	);	#Disrupter
InventoryWeaponSet(	Mercury,	4,	0	);	#Electrohull
InventoryWeaponSet(	Mercury,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	Mercury,	146,	0	);	#FOG
InventoryWeaponSet(	Mercury,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	Mercury,	150,	0	);	#SMART Gun

#Reactors					
InventoryComponentSet(	Mercury,	225,	2	);	# Small Cybrid Reactor 1 -- Alpha
InventoryComponentSet(	Mercury,	226,	1	);	# Small Cybrid Reactor 2-- Beta
InventoryComponentSet(	Mercury,	227,	1	);	# Medium Cybrid Reactor 1 -- Gamma
InventoryComponentSet(	Mercury,	228,	0	);	# Medium Cybrid Reactor 2--delta
InventoryComponentSet(	Mercury,	229,	0	);	# Large Cybrid Reactor 1--epsilon
InventoryComponentSet(	Mercury,	230,	0	);	# Large Cybrid Reactor 2--theta
					
#Shields					
InventoryComponentSet(	Mercury,	326,	1	);	# Cybrid Alpha Shield
InventoryComponentSet(	Mercury,	327,	2	);	# Cybrid Beta Shield
InventoryComponentSet(	Mercury,	328,	1	);	# Cybrid Gamma Shield
InventoryComponentSet(	Mercury,	329,	0	);	# Cybrid Delta Shield
InventoryComponentSet(	Mercury,	330,	0	);	# Cybrid Epsilon Shield
InventoryComponentSet(	Mercury,	331,	0	);	# Cybrid Zeta Shield
InventoryComponentSet(	Mercury,	332,	0	);	# Cybrid Eta Shield
InventoryComponentSet(	Mercury,	333,	0	);	# Cybrid Theta Shield
					
#Sensors					
InventoryComponentSet(	Mercury,	426,	1	);	# Basic Cybrid Sensor (Alpha)
InventoryComponentSet(	Mercury,	427,	2	);	# Long Range Cybrid Sensor (Beta)
InventoryComponentSet(	Mercury,	428,	1	);	#Standard Cybrid Sensor (Gamma)
InventoryComponentSet(	Mercury,	429,	0	);	#Cybrid Longbow Sensor (Delta)
InventoryComponentSet(	Mercury,	430,	0	);	#Cybrid Infiltrator Sensor (Epsilon)
InventoryComponentSet(	Mercury,	431,	0	);	#Cybrid Crossbow Sensor (Zeta)
InventoryComponentSet(	Mercury,	432,	1	);	#Cybrid Ultralight Sensor (Eta)
InventoryComponentSet(	Mercury,	433,	0	);	#Cybrid Hound Dog Sensor (Theta)
InventoryComponentSet(	Mercury,	434,	0	);	#Motion Detector (Iota)
					
#Engines					
InventoryComponentSet(	Mercury,	128,	2	);	# Cybrid Alpha Light Vehicle Engine
InventoryComponentSet(	Mercury,	129,	1	);	# Cybrid Beta Light Agility Engine
InventoryComponentSet(	Mercury,	130,	2	);	# Cybrid Gamma Standard Medium Engine
InventoryComponentSet(	Mercury,	131,	1	);	# Cybrid Delta Medium Cruise Engine
InventoryComponentSet(	Mercury,	132,	0	);	# Cybrid Epsilon Improved Medium Engine
InventoryComponentSet(	Mercury,	133,	0	);	# Cybrid Zeta Medium High Output Engine
InventoryComponentSet(	Mercury,	134,	0	);	# Cybrid Eta Medium Agility Engine
InventoryComponentSet(	Mercury,	135,	1	);	# Cybrid Theta Standard Heavy Engine
InventoryComponentSet(	Mercury,	136,	0	);	# Cybrid Iota Heavy High Output Engine
InventoryComponentSet(	Mercury,	137,	0	);	# Cybrid Kappa Heavy Agility Engine
InventoryComponentSet(	Mercury,	138,	0	);	# Cybrid Lamda Standard Assault Engine
InventoryComponentSet(	Mercury,	139,	0	);	# Cybrid Mu Improved Assault Engine
InventoryComponentSet(	Mercury,	140,	0	);	# Cybrid Nu High Output Assault Engine
InventoryComponentSet(	Mercury,	141,	0	);	# Cybrid Xi Heavy Assault Engine
InventoryComponentSet(	Mercury,	142,	0	);	# Cybrid Omicron Heavy Assault Turbine 
InventoryComponentSet(	Mercury,	143,	0	);	# Cybrid Pi Super Heavy Turbine
					
#Internal Components					
InventoryComponentSet(	Mercury,	800,	0	);	#Human Basic Computer
InventoryComponentSet(	Mercury,	801,	0	);	# Human Improved Computer
InventoryComponentSet(	Mercury,	802,	0	);	# Human Advanced Computer
InventoryComponentSet(	Mercury,	805,	2	);	# Cybrid Basic Systems Control
InventoryComponentSet(	Mercury,	806,	2	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	Mercury,	807,	0	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	Mercury,	810,	0	);	# Guardian ECM
InventoryComponentSet(	Mercury,	811,	0	);	# Doppleganger ECM
InventoryComponentSet(	Mercury,	812,	1	);	# Cybrid Alpha ECM
InventoryComponentSet(	Mercury,	813,	0	);	#Cybrid Beta ECM
InventoryComponentSet(	Mercury,	820,	1	);	# Thermal Diffuser
#InventoryComponentSet(	Mercury,	825,	0	);	# Flares
InventoryComponentSet(	Mercury,	830,	1	);	# Chameleon
InventoryComponentSet(	Mercury,	831,	1	);	# Cuttlefish cloak
InventoryComponentSet(	Mercury,	840,	0	);	# Shield Modulator
InventoryComponentSet(	Mercury,	845,	1	);	# Shield Capacitor
InventoryComponentSet(	Mercury,	850,	0	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	Mercury,	860,	4	);	# Laser Targeting Module
InventoryComponentSet(	Mercury,	865,	2	);	# Extra Battery
InventoryComponentSet(	Mercury,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	Mercury,	875,	0	);	# Field Stabilizer
InventoryComponentSet(	Mercury,	880,	0	);	# Rocket Booster
InventoryComponentSet(	Mercury,	885,	0	);	# Turbine Boost
InventoryComponentSet(	Mercury,	890,	0	);	#NanoRepair
InventoryComponentSet(	Mercury,	900,	0	);	#Angle Life Support
InventoryComponentSet(	Mercury,	910,	0	);	#Agrav Generator
InventoryComponentSet(	Mercury,	914,	0	);	#UAP
					
#Armor					
InventoryComponentSet(	Mercury,	926,	1	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	Mercury,	927,	1	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	Mercury,	928,	0	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	Mercury,	929,	1	);	#Ceramic
InventoryComponentSet(	Mercury,	930,	0	);	#Crystaluminum
InventoryComponentSet(	Mercury,	931,	0	);	#Quicksilver

#Pilots					
InventoryPilotSet(	Mercury,	1,	FALSE	);	#Corinthian Blue (metagen)
InventoryPilotSet(	Mercury,	2,	FALSE	);	#Plague Dog
InventoryPilotSet(	Mercury,	3,	FALSE	);	#Eat's only Heads
InventoryPilotSet(	Mercury,	4,	FALSE	);	#Sepsis
InventoryPilotSet(	Mercury,	5,	FALSE	);	#Tyrrany (metagen)
InventoryPilotSet(	Mercury,	6,	FALSE	);	#Unrelent
InventoryPilotSet(	Mercury,	7,	FALSE	);	#generic (metagen)
InventoryPilotSet(	Mercury,	8,	FALSE	);	#generic (metagen)
InventoryPilotSet(	Mercury,	9,	FALSE	);	#generic (metagen)
InventoryPilotSet(	Mercury,	10,	FALSE	);	#generic  
					
					
					
					
					
					
#-------------------------------------------------------------------------------------------------------------------------------------					
#Moon,					
#weapons					
InventoryWeaponSet(	moon,	101,	6	);	#Laser
InventoryWeaponSet(	moon,	102,	4	);	#Heavy Laser
InventoryWeaponSet(	moon,	103,	0	);	#Comp Laser
InventoryWeaponSet(	moon,	104,	4	);	#Twin Laser
InventoryWeaponSet(	moon,	105,	2	);	#Emp
InventoryWeaponSet(	moon,	106,	0	);	#ELF
InventoryWeaponSet(	moon,	107,	0	);	#Blaster
InventoryWeaponSet(	moon,	108,	0	);	#Heavy Blaster
InventoryWeaponSet(	moon,	109,	2	);	#PBW
InventoryWeaponSet(	moon,	110,	2	);	#Plasma
InventoryWeaponSet(	moon,	111,	2	);	#Blink Gun 
InventoryWeaponSet(	moon,	112,	0	);	#Qgun
InventoryWeaponSet(	moon,	113,	0	);	#MFAC
InventoryWeaponSet(	moon,	114,	2	);	#Nano Infuser
InventoryWeaponSet(	moon,	115,	0	);	#Nanite Cannon
InventoryWeaponSet(	moon,	116,	4	);	#Autocannon
InventoryWeaponSet(	moon,	117,	4	);	#Hvy Autocannon
InventoryWeaponSet(	moon,	118,	2	);	#EMC Autocannon
InventoryWeaponSet(	moon,	119,	2	);	#Blast Cannon
InventoryWeaponSet(	moon,	120,	0	);	#Hvy Blast Can
InventoryWeaponSet(	moon,	121,	0	);	#Rail Gun
InventoryWeaponSet(	moon,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	moon,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	moon,	124,	2	);	#Pit Viper 8
InventoryWeaponSet(	moon,	125,	2	);	#Pit Viper 12
InventoryWeaponSet(	moon,	126,	2	);	#Sparrow 6
InventoryWeaponSet(	moon,	127,	2	);	#Sparrow 10
InventoryWeaponSet(	moon,	128,	0	);	#SWARM 6
InventoryWeaponSet(	moon,	129,	0	);	#Minion
InventoryWeaponSet(	moon,	130,	0	);	#Shrike 8
InventoryWeaponSet(	moon,	147,	0	);	#Aphid
InventoryWeaponSet(	moon,	131,	2	);	#Arachnitron 4
InventoryWeaponSet(	moon,	132,	2	);	#Arachnitron 8 
InventoryWeaponSet(	moon,	133,	2	);	#Arachnitron 12 
InventoryWeaponSet(	moon,	134,	2	);	#Proximity 6 
InventoryWeaponSet(	moon,	135,	2	);	#Proximity 10 
InventoryWeaponSet(	moon,	136,	0	);	#Proximity 15
InventoryWeaponSet(	moon,	1,	0	);	#Nike
InventoryWeaponSet(	moon,	2,	0	);	#AML
InventoryWeaponSet(	moon,	142,	2	);	#Radiation Gun
InventoryWeaponSet(	moon,	3,	0	);	#Disrupter
InventoryWeaponSet(	moon,	4,	0	);	#Electrohull
InventoryWeaponSet(	moon,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	moon,	146,	0	);	#FOG
InventoryWeaponSet(	moon,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	moon,	150,	0	);	#SMART Gun

#Reactors					
InventoryComponentSet(	moon,	225,	2	);	# Small Cybrid Reactor 1 -- Alpha
InventoryComponentSet(	moon,	226,	2	);	# Small Cybrid Reactor 2-- Beta
InventoryComponentSet(	moon,	227,	2	);	# Medium Cybrid Reactor 1 -- Gamma
InventoryComponentSet(	moon,	228,	1	);	# Medium Cybrid Reactor 2--delta
InventoryComponentSet(	moon,	229,	1	);	# Large Cybrid Reactor 1--epsilon
InventoryComponentSet(	moon,	230,	0	);	# Large Cybrid Reactor 2--theta
					
#Shields					
InventoryComponentSet(	moon,	326,	2	);	# Cybrid Alpha Shield
InventoryComponentSet(	moon,	327,	2	);	# Cybrid Beta Shield
InventoryComponentSet(	moon,	328,	2	);	# Cybrid Gamma Shield
InventoryComponentSet(	moon,	329,	1	);	# Cybrid Delta Shield
InventoryComponentSet(	moon,	330,	1	);	# Cybrid Epsilon Shield
InventoryComponentSet(	moon,	331,	1	);	# Cybrid Zeta Shield
InventoryComponentSet(	moon,	332,	0	);	# Cybrid Eta Shield
InventoryComponentSet(	moon,	333,	0	);	# Cybrid Theta Shield
					
#Sensors					
InventoryComponentSet(	moon,	426,	3	);	# Basic Cybrid Sensor (Alpha)
InventoryComponentSet(	moon,	427,	2	);	# Long Range Cybrid Sensor (Beta)
InventoryComponentSet(	moon,	428,	1	);	#Standard Cybrid Sensor (Gamma)
InventoryComponentSet(	moon,	429,	2	);	#Cybrid Longbow Sensor (Delta)
InventoryComponentSet(	moon,	430,	1	);	#Cybrid Infiltrator Sensor (Epsilon)
InventoryComponentSet(	moon,	431,	2	);	#Cybrid Crossbow Sensor (Zeta)
InventoryComponentSet(	moon,	432,	2	);	#Cybrid Ultralight Sensor (Eta)
InventoryComponentSet(	moon,	433,	0	);	#Cybrid Hound Dog Sensor (Theta)
InventoryComponentSet(	moon,	434,	0	);	#Motion Detector (Iota)
					
#Engines					
InventoryComponentSet(	moon,	128,	1	);	# Cybrid Alpha Light Vehicle Engine
InventoryComponentSet(	moon,	129,	1	);	# Cybrid Beta Light Agility Engine
InventoryComponentSet(	moon,	130,	1	);	# Cybrid Gamma Standard Medium Engine
InventoryComponentSet(	moon,	131,	1	);	# Cybrid Delta Medium Cruise Engine
InventoryComponentSet(	moon,	132,	1	);	# Cybrid Epsilon Improved Medium Engine
InventoryComponentSet(	moon,	133,	2	);	# Cybrid Zeta Medium High Output Engine
InventoryComponentSet(	moon,	134,	0	);	# Cybrid Eta Medium Agility Engine
InventoryComponentSet(	moon,	135,	2	);	# Cybrid Theta Standard Heavy Engine
InventoryComponentSet(	moon,	136,	1	);	# Cybrid Iota Heavy High Output Engine
InventoryComponentSet(	moon,	137,	0	);	# Cybrid Kappa Heavy Agility Engine
InventoryComponentSet(	moon,	138,	0	);	# Cybrid Lamda Standard Assault Engine
InventoryComponentSet(	moon,	139,	1	);	# Cybrid Mu Improved Assault Engine
InventoryComponentSet(	moon,	140,	1	);	# Cybrid Nu High Output Assault Engine
InventoryComponentSet(	moon,	141,	0	);	# Cybrid Xi Heavy Assault Engine
InventoryComponentSet(	moon,	142,	0	);	# Cybrid Omicron Heavy Assault Turbine 
InventoryComponentSet(	moon,	143,	0	);	# Cybrid Pi Super Heavy Turbine
					
#Internal Components					
InventoryComponentSet(	moon,	800,	0	);	#Human Basic Computer
InventoryComponentSet(	moon,	801,	0	);	# Human Improved Computer
InventoryComponentSet(	moon,	802,	0	);	# Human Advanced Computer
InventoryComponentSet(	moon,	805,	2	);	# Cybrid Basic Systems Control
InventoryComponentSet(	moon,	806,	2	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	moon,	807,	1	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	moon,	810,	0	);	# Guardian ECM
InventoryComponentSet(	moon,	811,	0	);	# Doppleganger ECM
InventoryComponentSet(	moon,	812,	1	);	# Cybrid Alpha ECM
InventoryComponentSet(	moon,	813,	1	);	#Cybrid Beta ECM
InventoryComponentSet(	moon,	820,	1	);	# Thermal Diffuser
#InventoryComponentSet(	moon,	825,	0	);	# Flares
InventoryComponentSet(	moon,	830,	1	);	# Chameleon
InventoryComponentSet(	moon,	831,	1	);	# Cuttlefish cloak
InventoryComponentSet(	moon,	840,	1	);	# Shield Modulator
InventoryComponentSet(	moon,	845,	1	);	# Shield Capacitor
InventoryComponentSet(	moon,	850,	1	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	moon,	860,	2	);	# Laser Targeting Module
InventoryComponentSet(	moon,	865,	6	);	# Extra Battery
InventoryComponentSet(	moon,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	moon,	875,	2	);	# Field Stabilizer
InventoryComponentSet(	moon,	880,	1	);	# Rocket Booster
InventoryComponentSet(	moon,	885,	2	);	# Turbine Boost
InventoryComponentSet(	moon,	890,	0	);	#NanoRepair
InventoryComponentSet(	moon,	900,	2	);	#Angle Life Support
InventoryComponentSet(	moon,	910,	0	);	#Agrav Generator
InventoryComponentSet(	moon,	914,	1	);	#UAP
					
#Armor					
InventoryComponentSet(	moon,	926,	2	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	moon,	927,	2	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	moon,	928,	1	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	moon,	929,	2	);	#Ceramic
InventoryComponentSet(	moon,	930,	1	);	#Crystaluminum
InventoryComponentSet(	moon,	931,	0	);	#Quicksilver

#Pilots					
InventoryPilotSet(	moon,	1,	TRUE	);	#Corinthian Blue (metagen)
InventoryPilotSet(	moon,	2,	TRUE	);	#Plague Dog
InventoryPilotSet(	moon,	3,	TRUE	);	#Eat's only Heads
InventoryPilotSet(	moon,	4,	FALSE	);	#Sepsis
InventoryPilotSet(	moon,	5,	FALSE	);	#Tyrrany (metagen)
InventoryPilotSet(	moon,	6,	FALSE	);	#Unrelent
InventoryPilotSet(	moon,	7,	TRUE	);	#generic (metagen)
InventoryPilotSet(	moon,	8,	FALSE	);	#generic (metagen)
InventoryPilotSet(	moon,	9,	FALSE	);	#generic (metagen)
InventoryPilotSet(	moon,	10,	TRUE	);	#generic  
					
					
					
					
					

#-------------------------------------------------------------------------------------------------------------------------------------					
#Artic					
#weapons					
InventoryWeaponSet(	ice,	101,	4	);	#Laser
InventoryWeaponSet(	ice,	102,	4	);	#Heavy Laser
InventoryWeaponSet(	ice,	103,	0	);	#Comp Laser
InventoryWeaponSet(	ice,	104,	6	);	#Twin Laser
InventoryWeaponSet(	ice,	105,	2	);	#Emp
InventoryWeaponSet(	ice,	106,	2	);	#ELF
InventoryWeaponSet(	ice,	107,	0	);	#Blaster
InventoryWeaponSet(	ice,	108,	0	);	#Heavy Blaster
InventoryWeaponSet(	ice,	109,	2	);	#PBW
InventoryWeaponSet(	ice,	110,	2	);	#Plasma
InventoryWeaponSet(	ice,	111,	4	);	#Blink Gun 
InventoryWeaponSet(	ice,	112,	0	);	#Qgun
InventoryWeaponSet(	ice,	113,	0	);	#MFAC
InventoryWeaponSet(	ice,	114,	6	);	#Nano Infuser
InventoryWeaponSet(	ice,	115,	0	);	#Nanite Cannon
InventoryWeaponSet(	ice,	116,	6	);	#Autocannon
InventoryWeaponSet(	ice,	117,	4	);	#Hvy Autocannon
InventoryWeaponSet(	ice,	118,	4	);	#EMC Autocannon
InventoryWeaponSet(	ice,	119,	0	);	#Blast Cannon
InventoryWeaponSet(	ice,	120,	0	);	#Hvy Blast Can
InventoryWeaponSet(	ice,	121,	2	);	#Rail Gun
InventoryWeaponSet(	ice,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	ice,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	ice,	124,	4	);	#Pit Viper 8
InventoryWeaponSet(	ice,	125,	2	);	#Pit Viper 12
InventoryWeaponSet(	ice,	126,	4	);	#Sparrow 6
InventoryWeaponSet(	ice,	127,	2	);	#Sparrow 10
InventoryWeaponSet(	ice,	128,	0	);	#SWARM 6
InventoryWeaponSet(	ice,	129,	2	);	#Minion
InventoryWeaponSet(	ice,	130,	4	);	#Shrike 8
InventoryWeaponSet(	ice,	147,	2	);	#Aphid
InventoryWeaponSet(	ice,	131,	4	);	#Arachnitron 4
InventoryWeaponSet(	ice,	132,	6	);	#Arachnitron 8 
InventoryWeaponSet(	ice,	133,	2	);	#Arachnitron 12 
InventoryWeaponSet(	ice,	134,	2	);	#Proximity 6 
InventoryWeaponSet(	ice,	135,	2	);	#Proximity 10 
InventoryWeaponSet(	ice,	136,	2	);	#Proximity 15
InventoryWeaponSet(	ice,	1,	0	);	#Nike
InventoryWeaponSet(	ice,	2,	0	);	#AML
InventoryWeaponSet(	ice,	142,	4	);	#Radiation Gun
InventoryWeaponSet(	ice,	3,	0	);	#Disrupter
InventoryWeaponSet(	ice,	4,	0	);	#Electrohull
InventoryWeaponSet(	ice,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	ice,	146,	0	);	#FOG
InventoryWeaponSet(	ice,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	ice,	150,	0	);	#SMART Gun

#Reactors					
InventoryComponentSet(	ice,	225,	2	);	# Small Cybrid Reactor 1 -- Alpha
InventoryComponentSet(	ice,	226,	2	);	# Small Cybrid Reactor 2-- Beta
InventoryComponentSet(	ice,	227,	2	);	# Medium Cybrid Reactor 1 -- Gamma
InventoryComponentSet(	ice,	228,	2	);	# Medium Cybrid Reactor 2--delta
InventoryComponentSet(	ice,	229,	1	);	# Large Cybrid Reactor 1--epsilon
InventoryComponentSet(	ice,	230,	1	);	# Large Cybrid Reactor 2--theta
					
#Shields					
InventoryComponentSet(	ice,	326,	4	);	# Cybrid Alpha Shield
InventoryComponentSet(	ice,	327,	3	);	# Cybrid Beta Shield
InventoryComponentSet(	ice,	328,	2	);	# Cybrid Gamma Shield
InventoryComponentSet(	ice,	329,	2	);	# Cybrid Delta Shield
InventoryComponentSet(	ice,	330,	2	);	# Cybrid Epsilon Shield
InventoryComponentSet(	ice,	331,	1	);	# Cybrid Zeta Shield
InventoryComponentSet(	ice,	332,	1	);	# Cybrid Eta Shield
InventoryComponentSet(	ice,	333,	1	);	# Cybrid Theta Shield
					
#Sensors					
InventoryComponentSet(	ice,	426,	4	);	# Basic Cybrid Sensor (Alpha)
InventoryComponentSet(	ice,	427,	3	);	# Long Range Cybrid Sensor (Beta)
InventoryComponentSet(	ice,	428,	4	);	#Standard Cybrid Sensor (Gamma)
InventoryComponentSet(	ice,	429,	2	);	#Cybrid Longbow Sensor (Delta)
InventoryComponentSet(	ice,	430,	1	);	#Cybrid Infiltrator Sensor (Epsilon)
InventoryComponentSet(	ice,	431,	2	);	#Cybrid Crossbow Sensor (Zeta)
InventoryComponentSet(	ice,	432,	4	);	#Cybrid Ultralight Sensor (Eta)
InventoryComponentSet(	ice,	433,	1	);	#Cybrid Hound Dog Sensor (Theta)
InventoryComponentSet(	ice,	434,	0	);	#Motion Detector (Iota)
					
#Engines					
InventoryComponentSet(	ice,	128,	4	);	# Cybrid Alpha Light Vehicle Engine
InventoryComponentSet(	ice,	129,	2	);	# Cybrid Beta Light Agility Engine
InventoryComponentSet(	ice,	130,	5	);	# Cybrid Gamma Standard Medium Engine
InventoryComponentSet(	ice,	131,	3	);	# Cybrid Delta Medium Cruise Engine
InventoryComponentSet(	ice,	132,	2	);	# Cybrid Epsilon Improved Medium Engine
InventoryComponentSet(	ice,	133,	2	);	# Cybrid Zeta Medium High Output Engine
InventoryComponentSet(	ice,	134,	1	);	# Cybrid Eta Medium Agility Engine
InventoryComponentSet(	ice,	135,	4	);	# Cybrid Theta Standard Heavy Engine
InventoryComponentSet(	ice,	136,	2	);	# Cybrid Iota Heavy High Output Engine
InventoryComponentSet(	ice,	137,	1	);	# Cybrid Kappa Heavy Agility Engine
InventoryComponentSet(	ice,	138,	2	);	# Cybrid Lamda Standard Assault Engine
InventoryComponentSet(	ice,	139,	1	);	# Cybrid Mu Improved Assault Engine
InventoryComponentSet(	ice,	140,	1	);	# Cybrid Nu High Output Assault Engine
InventoryComponentSet(	ice,	141,	1	);	# Cybrid Xi Heavy Assault Engine
InventoryComponentSet(	ice,	142,	0	);	# Cybrid Omicron Heavy Assault Turbine 
InventoryComponentSet(	ice,	143,	0	);	# Cybrid Pi Super Heavy Turbine
					
#Internal Components					
InventoryComponentSet(	ice,	800,	0	);	#Human Basic Computer
InventoryComponentSet(	ice,	801,	0	);	# Human Improved Computer
InventoryComponentSet(	ice,	802,	0	);	# Human Advanced Computer
InventoryComponentSet(	ice,	805,	4	);	# Cybrid Basic Systems Control
InventoryComponentSet(	ice,	806,	4	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	ice,	807,	2	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	ice,	810,	0	);	# Guardian ECM
InventoryComponentSet(	ice,	811,	0	);	# Doppleganger ECM
InventoryComponentSet(	ice,	812,	1	);	# Cybrid Alpha ECM
InventoryComponentSet(	ice,	813,	1	);	#Cybrid Beta ECM
InventoryComponentSet(	ice,	820,	2	);	# Thermal Diffuser
#InventoryComponentSet(	ice,	825,	0	);	# Flares
InventoryComponentSet(	ice,	830,	1	);	# Chameleon
InventoryComponentSet(	ice,	831,	1	);	# Cuttlefish cloak
InventoryComponentSet(	ice,	840,	2	);	# Shield Modulator
InventoryComponentSet(	ice,	845,	1	);	# Shield Capacitor
InventoryComponentSet(	ice,	850,	1	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	ice,	860,	4	);	# Laser Targeting Module
InventoryComponentSet(	ice,	865,	6	);	# Extra Battery
InventoryComponentSet(	ice,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	ice,	875,	2	);	# Field Stabilizer
InventoryComponentSet(	ice,	880,	1	);	# Rocket Booster
InventoryComponentSet(	ice,	885,	2	);	# Turbine Boost
InventoryComponentSet(	ice,	890,	0	);	#NanoRepair
InventoryComponentSet(	ice,	900,	1	);	#Angle Life Support
InventoryComponentSet(	ice,	910,	0	);	#Agrav Generator
InventoryComponentSet(	ice,	914,	1	);	#UAP
					
#Armor					
InventoryComponentSet(	ice,	926,	2	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	ice,	927,	2	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	ice,	928,	1	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	ice,	929,	2	);	#Ceramic
InventoryComponentSet(	ice,	930,	1	);	#Crystaluminum
InventoryComponentSet(	ice,	931,	0	);	#Quicksilver

#Pilots					
InventoryPilotSet(	ice,	1,	TRUE	);	#Corinthian Blue (metagen)
InventoryPilotSet(	ice,	2,	TRUE	);	#Plague Dog
InventoryPilotSet(	ice,	3,	TRUE	);	#Eat's only Heads
InventoryPilotSet(	ice,	4,	FALSE	);	#Sepsis
InventoryPilotSet(	ice,	5,	FALSE	);	#Tyrrany (metagen)
InventoryPilotSet(	ice,	6,	FALSE	);	#Unrelent
InventoryPilotSet(	ice,	7,	TRUE	);	#generic (metagen)
InventoryPilotSet(	ice,	8,	FALSE	);	#generic (metagen)
InventoryPilotSet(	ice,	9,	FALSE	);	#generic (metagen)
InventoryPilotSet(	ice,	10,	TRUE	);	#generic  
					
					
					
					
					

#-------------------------------------------------------------------------------------------------------------------------------------					
#Temperate					
#weapons					
InventoryWeaponSet(	temperate,	101,	8	);	#Laser
InventoryWeaponSet(	temperate,	102,	4	);	#Heavy Laser
InventoryWeaponSet(	temperate,	103,	0	);	#Comp Laser
InventoryWeaponSet(	temperate,	104,	6	);	#Twin Laser
InventoryWeaponSet(	temperate,	105,	2	);	#Emp
InventoryWeaponSet(	temperate,	106,	4	);	#ELF
InventoryWeaponSet(	temperate,	107,	2	);	#Blaster
InventoryWeaponSet(	temperate,	108,	2	);	#Heavy Blaster
InventoryWeaponSet(	temperate,	109,	4	);	#PBW
InventoryWeaponSet(	temperate,	110,	2	);	#Plasma
InventoryWeaponSet(	temperate,	111,	2	);	#Blink Gun 
InventoryWeaponSet(	temperate,	112,	0	);	#Qgun
InventoryWeaponSet(	temperate,	113,	0	);	#MFAC
InventoryWeaponSet(	temperate,	114,	6	);	#Nano Infuser
InventoryWeaponSet(	temperate,	115,	0	);	#Nanite Cannon
InventoryWeaponSet(	temperate,	116,	8	);	#Autocannon
InventoryWeaponSet(	temperate,	117,	4	);	#Hvy Autocannon
InventoryWeaponSet(	temperate,	118,	6	);	#EMC Autocannon
InventoryWeaponSet(	temperate,	119,	2	);	#Blast Cannon
InventoryWeaponSet(	temperate,	120,	2	);	#Hvy Blast Can
InventoryWeaponSet(	temperate,	121,	4	);	#Rail Gun
InventoryWeaponSet(	temperate,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	temperate,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	temperate,	124,	4	);	#Pit Viper 8
InventoryWeaponSet(	temperate,	125,	2	);	#Pit Viper 12
InventoryWeaponSet(	temperate,	126,	4	);	#Sparrow 6
InventoryWeaponSet(	temperate,	127,	2	);	#Sparrow 10
InventoryWeaponSet(	temperate,	128,	2	);	#SWARM 6
InventoryWeaponSet(	temperate,	129,	2	);	#Minion
InventoryWeaponSet(	temperate,	130,	4	);	#Shrike 8
InventoryWeaponSet(	temperate,	147,	2	);	#Aphid
InventoryWeaponSet(	temperate,	131,	8	);	#Arachnitron 4
InventoryWeaponSet(	temperate,	132,	4	);	#Arachnitron 8 
InventoryWeaponSet(	temperate,	133,	2	);	#Arachnitron 12 
InventoryWeaponSet(	temperate,	134,	6	);	#Proximity 6 
InventoryWeaponSet(	temperate,	135,	4	);	#Proximity 10 
InventoryWeaponSet(	temperate,	136,	2	);	#Proximity 15
InventoryWeaponSet(	temperate,	1,	0	);	#Nike
InventoryWeaponSet(	temperate,	2,	0	);	#AML
InventoryWeaponSet(	temperate,	142,	3	);	#Radiation Gun
InventoryWeaponSet(	temperate,	3,	0	);	#Disrupter
InventoryWeaponSet(	temperate,	4,	0	);	#Electrohull
InventoryWeaponSet(	temperate,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	temperate,	146,	0	);	#FOG
InventoryWeaponSet(	temperate,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	temperate,	150,	0	);	#SMART Gun

#Reactors					
InventoryComponentSet(	temperate,	225,	4	);	# Small Cybrid Reactor 1 -- Alpha
InventoryComponentSet(	temperate,	226,	4	);	# Small Cybrid Reactor 2-- Beta
InventoryComponentSet(	temperate,	227,	4	);	# Medium Cybrid Reactor 1 -- Gamma
InventoryComponentSet(	temperate,	228,	2	);	# Medium Cybrid Reactor 2--delta
InventoryComponentSet(	temperate,	229,	2	);	# Large Cybrid Reactor 1--epsilon
InventoryComponentSet(	temperate,	230,	2	);	# Large Cybrid Reactor 2--theta
					
#Shields					
InventoryComponentSet(	temperate,	326,	6	);	# Cybrid Alpha Shield
InventoryComponentSet(	temperate,	327,	4	);	# Cybrid Beta Shield
InventoryComponentSet(	temperate,	328,	2	);	# Cybrid Gamma Shield
InventoryComponentSet(	temperate,	329,	2	);	# Cybrid Delta Shield
InventoryComponentSet(	temperate,	330,	2	);	# Cybrid Epsilon Shield
InventoryComponentSet(	temperate,	331,	1	);	# Cybrid Zeta Shield
InventoryComponentSet(	temperate,	332,	1	);	# Cybrid Eta Shield
InventoryComponentSet(	temperate,	333,	1	);	# Cybrid Theta Shield
					
#Sensors					
InventoryComponentSet(	temperate,	426,	6	);	# Basic Cybrid Sensor (Alpha)
InventoryComponentSet(	temperate,	427,	4	);	# Long Range Cybrid Sensor (Beta)
InventoryComponentSet(	temperate,	428,	2	);	#Standard Cybrid Sensor (Gamma)
InventoryComponentSet(	temperate,	429,	1	);	#Cybrid Longbow Sensor (Delta)
InventoryComponentSet(	temperate,	430,	2	);	#Cybrid Infiltrator Sensor (Epsilon)
InventoryComponentSet(	temperate,	431,	1	);	#Cybrid Crossbow Sensor (Zeta)
InventoryComponentSet(	temperate,	432,	1	);	#Cybrid Ultralight Sensor (Eta)
InventoryComponentSet(	temperate,	433,	1	);	#Cybrid Hound Dog Sensor (Theta)
InventoryComponentSet(	temperate,	434,	1	);	#Motion Detector (Iota)
					
#Engines					
InventoryComponentSet(	temperate,	128,	4	);	# Cybrid Alpha Light Vehicle Engine
InventoryComponentSet(	temperate,	129,	4	);	# Cybrid Beta Light Agility Engine
InventoryComponentSet(	temperate,	130,	2	);	# Cybrid Gamma Standard Medium Engine
InventoryComponentSet(	temperate,	131,	1	);	# Cybrid Delta Medium Cruise Engine
InventoryComponentSet(	temperate,	132,	4	);	# Cybrid Epsilon Improved Medium Engine
InventoryComponentSet(	temperate,	133,	5	);	# Cybrid Zeta Medium High Output Engine
InventoryComponentSet(	temperate,	134,	2	);	# Cybrid Eta Medium Agility Engine
InventoryComponentSet(	temperate,	135,	6	);	# Cybrid Theta Standard Heavy Engine
InventoryComponentSet(	temperate,	136,	3	);	# Cybrid Iota Heavy High Output Engine
InventoryComponentSet(	temperate,	137,	2	);	# Cybrid Kappa Heavy Agility Engine
InventoryComponentSet(	temperate,	138,	4	);	# Cybrid Lamda Standard Assault Engine
InventoryComponentSet(	temperate,	139,	2	);	# Cybrid Mu Improved Assault Engine
InventoryComponentSet(	temperate,	140,	2	);	# Cybrid Nu High Output Assault Engine
InventoryComponentSet(	temperate,	141,	2	);	# Cybrid Xi Heavy Assault Engine
InventoryComponentSet(	temperate,	142,	1	);	# Cybrid Omicron Heavy Assault Turbine 
InventoryComponentSet(	temperate,	143,	1	);	# Cybrid Pi Super Heavy Turbine
					
#Internal Components					
InventoryComponentSet(	temperate,	800,	0	);	#Human Basic Computer
InventoryComponentSet(	temperate,	801,	0	);	# Human Improved Computer
InventoryComponentSet(	temperate,	802,	0	);	# Human Advanced Computer
InventoryComponentSet(	temperate,	805,	1	);	# Cybrid Basic Systems Control
InventoryComponentSet(	temperate,	806,	2	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	temperate,	807,	2	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	temperate,	810,	0	);	# Guardian ECM
InventoryComponentSet(	temperate,	811,	0	);	# Doppleganger ECM
InventoryComponentSet(	temperate,	812,	2	);	# Cybrid Alpha ECM
InventoryComponentSet(	temperate,	813,	2	);	#Cybrid Beta ECM
InventoryComponentSet(	temperate,	820,	1	);	# Thermal Diffuser
#InventoryComponentSet(	temperate,	825,	0	);	# Flares
InventoryComponentSet(	temperate,	830,	1	);	# Chameleon
InventoryComponentSet(	temperate,	831,	1	);	# Cuttlefish cloak
InventoryComponentSet(	temperate,	840,	3	);	# Shield Modulator
InventoryComponentSet(	temperate,	845,	1	);	# Shield Capacitor
InventoryComponentSet(	temperate,	850,	1	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	temperate,	860,	4	);	# Laser Targeting Module
InventoryComponentSet(	temperate,	865,	6	);	# Extra Battery
InventoryComponentSet(	temperate,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	temperate,	875,	2	);	# Field Stabilizer
InventoryComponentSet(	temperate,	880,	1	);	# Rocket Booster
InventoryComponentSet(	temperate,	885,	2	);	# Turbine Boost
InventoryComponentSet(	temperate,	890,	0	);	#NanoRepair
InventoryComponentSet(	temperate,	900,	1	);	#Angle Life Support
InventoryComponentSet(	temperate,	910,	0	);	#Agrav Generator
InventoryComponentSet(	temperate,	914,	1	);	#UAP
					
#Armor					
InventoryComponentSet(	temperate,	926,	4	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	temperate,	927,	1	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	temperate,	928,	2	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	temperate,	929,	2	);	#Ceramic
InventoryComponentSet(	temperate,	930,	1	);	#Crystaluminum
InventoryComponentSet(	temperate,	931,	1	);	#Quicksilver

#Pilots					
InventoryPilotSet(	temperate,	1,	TRUE	);	#Corinthian Blue (metagen)
InventoryPilotSet(	temperate,	2,	TRUE	);	#Plague Dog
InventoryPilotSet(	temperate,	3,	TRUE	);	#Eat's only Heads
InventoryPilotSet(	temperate,	4,	TRUE	);	#Sepsis
InventoryPilotSet(	temperate,	5,	TRUE	);	#Tyrrany (metagen)
InventoryPilotSet(	temperate,	6,	TRUE	);	#Unrelent
InventoryPilotSet(	temperate,	7,	TRUE	);	#generic (metagen)
InventoryPilotSet(	temperate,	8,	FALSE	);	#generic (metagen)
InventoryPilotSet(	temperate,	9,	FALSE	);	#generic (metagen)
InventoryPilotSet(	temperate,	10,	TRUE	);	#generic  
					
					
					
					
					

#-------------------------------------------------------------------------------------------------------------------------------------					
#Desert					
#weapons					
InventoryWeaponSet(	desert,	101,	8	);	#Laser
InventoryWeaponSet(	desert,	102,	4	);	#Heavy Laser
InventoryWeaponSet(	desert,	103,	0	);	#Comp Laser
InventoryWeaponSet(	desert,	104,	10	);	#Twin Laser
InventoryWeaponSet(	desert,	105,	4	);	#Emp
InventoryWeaponSet(	desert,	106,	2	);	#ELF
InventoryWeaponSet(	desert,	107,	2	);	#Blaster
InventoryWeaponSet(	desert,	108,	1	);	#Heavy Blaster
InventoryWeaponSet(	desert,	109,	4	);	#PBW
InventoryWeaponSet(	desert,	110,	6	);	#Plasma
InventoryWeaponSet(	desert,	111,	8	);	#Blink Gun 
InventoryWeaponSet(	desert,	112,	2	);	#Qgun
InventoryWeaponSet(	desert,	113,	2	);	#MFAC
InventoryWeaponSet(	desert,	114,	5	);	#Nano Infuser
InventoryWeaponSet(	desert,	115,	2	);	#Nanite Cannon
InventoryWeaponSet(	desert,	116,	8	);	#Autocannon
InventoryWeaponSet(	desert,	117,	4	);	#Hvy Autocannon
InventoryWeaponSet(	desert,	118,	4	);	#EMC Autocannon
InventoryWeaponSet(	desert,	119,	2	);	#Blast Cannon
InventoryWeaponSet(	desert,	120,	2	);	#Hvy Blast Can
InventoryWeaponSet(	desert,	121,	6	);	#Rail Gun
InventoryWeaponSet(	desert,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	desert,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	desert,	124,	2	);	#Pit Viper 8
InventoryWeaponSet(	desert,	125,	4	);	#Pit Viper 12
InventoryWeaponSet(	desert,	126,	2	);	#Sparrow 6
InventoryWeaponSet(	desert,	127,	4	);	#Sparrow 10
InventoryWeaponSet(	desert,	128,	2	);	#SWARM 6
InventoryWeaponSet(	desert,	129,	2	);	#Minion
InventoryWeaponSet(	desert,	130,	4	);	#Shrike 8
InventoryWeaponSet(	desert,	147,	2	);	#Aphid
InventoryWeaponSet(	desert,	131,	4	);	#Arachnitron 4
InventoryWeaponSet(	desert,	132,	4	);	#Arachnitron 8 
InventoryWeaponSet(	desert,	133,	4	);	#Arachnitron 12 
InventoryWeaponSet(	desert,	134,	4	);	#Proximity 6 
InventoryWeaponSet(	desert,	135,	4	);	#Proximity 10 
InventoryWeaponSet(	desert,	136,	4	);	#Proximity 15
InventoryWeaponSet(	desert,	1,	0	);	#Nike
InventoryWeaponSet(	desert,	2,	0	);	#AML
InventoryWeaponSet(	desert,	142,	4	);	#Radiation Gun
InventoryWeaponSet(	desert,	3,	0	);	#Disrupter
InventoryWeaponSet(	desert,	4,	0	);	#Electrohull
InventoryWeaponSet(	desert,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	desert,	146,	0	);	#FOG
InventoryWeaponSet(	desert,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	desert,	150,	2	);	#SMART Gun

#Reactors					
InventoryComponentSet(	desert,	225,	6	);	# Small Cybrid Reactor 1 -- Alpha
InventoryComponentSet(	desert,	226,	4	);	# Small Cybrid Reactor 2-- Beta
InventoryComponentSet(	desert,	227,	2	);	# Medium Cybrid Reactor 1 -- Gamma
InventoryComponentSet(	desert,	228,	4	);	# Medium Cybrid Reactor 2--delta
InventoryComponentSet(	desert,	229,	2	);	# Large Cybrid Reactor 1--epsilon
InventoryComponentSet(	desert,	230,	2	);	# Large Cybrid Reactor 2--theta
					
#Shields					
InventoryComponentSet(	desert,	326,	8	);	# Cybrid Alpha Shield
InventoryComponentSet(	desert,	327,	4	);	# Cybrid Beta Shield
InventoryComponentSet(	desert,	328,	4	);	# Cybrid Gamma Shield
InventoryComponentSet(	desert,	329,	2	);	# Cybrid Delta Shield
InventoryComponentSet(	desert,	330,	4	);	# Cybrid Epsilon Shield
InventoryComponentSet(	desert,	331,	2	);	# Cybrid Zeta Shield
InventoryComponentSet(	desert,	332,	2	);	# Cybrid Eta Shield
InventoryComponentSet(	desert,	333,	2	);	# Cybrid Theta Shield
					
#Sensors					
InventoryComponentSet(	desert,	426,	12	);	# Basic Cybrid Sensor (Alpha)
InventoryComponentSet(	desert,	427,	4	);	# Long Range Cybrid Sensor (Beta)
InventoryComponentSet(	desert,	428,	8	);	#Standard Cybrid Sensor (Gamma)
InventoryComponentSet(	desert,	429,	6	);	#Cybrid Longbow Sensor (Delta)
InventoryComponentSet(	desert,	430,	2	);	#Cybrid Infiltrator Sensor (Epsilon)
InventoryComponentSet(	desert,	431,	4	);	#Cybrid Crossbow Sensor (Zeta)
InventoryComponentSet(	desert,	432,	4	);	#Cybrid Ultralight Sensor (Eta)
InventoryComponentSet(	desert,	433,	4	);	#Cybrid Hound Dog Sensor (Theta)
InventoryComponentSet(	desert,	434,	2	);	#Motion Detector (Iota)
					
#Engines					
InventoryComponentSet(	desert,	128,	6	);	# Cybrid Alpha Light Vehicle Engine
InventoryComponentSet(	desert,	129,	4	);	# Cybrid Beta Light Agility Engine
InventoryComponentSet(	desert,	130,	4	);	# Cybrid Gamma Standard Medium Engine
InventoryComponentSet(	desert,	131,	3	);	# Cybrid Delta Medium Cruise Engine
InventoryComponentSet(	desert,	132,	2	);	# Cybrid Epsilon Improved Medium Engine
InventoryComponentSet(	desert,	133,	2	);	# Cybrid Zeta Medium High Output Engine
InventoryComponentSet(	desert,	134,	2	);	# Cybrid Eta Medium Agility Engine
InventoryComponentSet(	desert,	135,	5	);	# Cybrid Theta Standard Heavy Engine
InventoryComponentSet(	desert,	136,	3	);	# Cybrid Iota Heavy High Output Engine
InventoryComponentSet(	desert,	137,	2	);	# Cybrid Kappa Heavy Agility Engine
InventoryComponentSet(	desert,	138,	6	);	# Cybrid Lamda Standard Assault Engine
InventoryComponentSet(	desert,	139,	4	);	# Cybrid Mu Improved Assault Engine
InventoryComponentSet(	desert,	140,	4	);	# Cybrid Nu High Output Assault Engine
InventoryComponentSet(	desert,	141,	2	);	# Cybrid Xi Heavy Assault Engine
InventoryComponentSet(	desert,	142,	2	);	# Cybrid Omicron Heavy Assault Turbine 
InventoryComponentSet(	desert,	143,	2	);	# Cybrid Pi Super Heavy Turbine
					
#Internal Components					
InventoryComponentSet(	desert,	800,	0	);	#Human Basic Computer
InventoryComponentSet(	desert,	801,	0	);	# Human Improved Computer
InventoryComponentSet(	desert,	802,	0	);	# Human Advanced Computer
InventoryComponentSet(	desert,	805,	6	);	# Cybrid Basic Systems Control
InventoryComponentSet(	desert,	806,	4	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	desert,	807,	2	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	desert,	810,	0	);	# Guardian ECM
InventoryComponentSet(	desert,	811,	0	);	# Doppleganger ECM
InventoryComponentSet(	desert,	812,	4	);	# Cybrid Alpha ECM
InventoryComponentSet(	desert,	813,	2	);	#Cybrid Beta ECM
InventoryComponentSet(	desert,	820,	2	);	# Thermal Diffuser
#InventoryComponentSet(	desert,	825,	0	);	# Flares
InventoryComponentSet(	desert,	830,	2	);	# Chameleon
InventoryComponentSet(	desert,	831,	2	);	# Cuttlefish cloak
InventoryComponentSet(	desert,	840,	3	);	# Shield Modulator
InventoryComponentSet(	desert,	845,	2	);	# Shield Capacitor
InventoryComponentSet(	desert,	850,	2	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	desert,	860,	4	);	# Laser Targeting Module
InventoryComponentSet(	desert,	865,	6	);	# Extra Battery
InventoryComponentSet(	desert,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	desert,	875,	2	);	# Field Stabilizer
InventoryComponentSet(	desert,	880,	2	);	# Rocket Booster
InventoryComponentSet(	desert,	885,	2	);	# Turbine Boost
InventoryComponentSet(	desert,	890,	1	);	#NanoRepair
InventoryComponentSet(	desert,	900,	4	);	#Angle Life Support
InventoryComponentSet(	desert,	910,	1	);	#Agrav Generator
InventoryComponentSet(	desert,	914,	2	);	#UAP
					
#Armor					
InventoryComponentSet(	desert,	926,	4	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	desert,	927,	6	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	desert,	928,	2	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	desert,	929,	4	);	#Ceramic
InventoryComponentSet(	desert,	930,	1	);	#Crystaluminum
InventoryComponentSet(	desert,	931,	1	);	#Quicksilver

#Pilots					
InventoryPilotSet(	desert,	1,	TRUE	);	#Corinthian Blue (metagen)
InventoryPilotSet(	desert,	2,	TRUE	);	#Plague Dog
InventoryPilotSet(	desert,	3,	TRUE	);	#Eat's only Heads
InventoryPilotSet(	desert,	4,	TRUE	);	#Sepsis
InventoryPilotSet(	desert,	5,	TRUE	);	#Tyrrany (metagen)
InventoryPilotSet(	desert,	6,	TRUE	);	#Unrelent
InventoryPilotSet(	desert,	7,	TRUE	);	#generic (metagen)
InventoryPilotSet(	desert,	8,	TRUE	);	#generic (metagen)
InventoryPilotSet(	desert,	9,	TRUE	);	#generic (metagen)
InventoryPilotSet(	desert,	10,	TRUE	);	#generic  
					
					
					
					
					
##-------------------------------------------- Planet Inventory Starting Adjustements					

InventoryVehicleAdjust(	-1,	21,	1	);	#Goad
InventoryweaponAdjust(	-1,	102,	2	);	
InventoryComponentAdjust(	-1,	132,	1	);	
InventoryComponentAdjust(	-1,	227,	1	);	
InventoryComponentAdjust(	-1,	806,	1	);	
InventoryComponentAdjust(	-1,	328,	1	);	
InventoryComponentAdjust(	-1,	929,	1	);	
InventoryComponentAdjust(	-1,	432,	1	);	
InventoryComponentAdjust(	-1,	812,	1	);	
InventoryComponentAdjust(	-1,	840,	1	);	


InventoryVehicleAdjust(	Mercury,	20,	1	);	#Seeker
InventoryweaponAdjust(	Mercury,	117,	2	);	
InventoryComponentAdjust(	Mercury,	129,	1	);	
InventoryComponentAdjust(	Mercury,	225,	1	);	
InventoryComponentAdjust(	Mercury,	806,	1	);	
InventoryComponentAdjust(	Mercury,	328,	1	);	
InventoryComponentAdjust(	Mercury,	926,	1	);	
InventoryComponentAdjust(	Mercury,	426,	1	);	
InventoryComponentAdjust(	Mercury,	850,	1	);	
InventoryComponentAdjust(	Mercury,	812,	1	);	

InventoryVehicleAdjust(	moon,	21,	2	);	#Goad
InventoryweaponAdjust(	moon,	102,	4	);	
InventoryComponentAdjust(	moon,	132,	2	);	
InventoryComponentAdjust(	moon,	227,	2	);	
InventoryComponentAdjust(	moon,	806,	2	);	
InventoryComponentAdjust(	moon,	328,	2	);	
InventoryComponentAdjust(	moon,	929,	2	);	
InventoryComponentAdjust(	moon,	432,	2	);	
InventoryComponentAdjust(	moon,	812,	2	);	
InventoryComponentAdjust(	moon,	840,	2	);	


InventoryVehicleAdjust(	moon,	20,	1	);	#Seeker
InventoryweaponAdjust(	moon,	117,	2	);	
InventoryComponentAdjust(	moon,	129,	1	);	
InventoryComponentAdjust(	moon,	225,	1	);	
InventoryComponentAdjust(	moon,	806,	1	);	
InventoryComponentAdjust(	moon,	328,	1	);	
InventoryComponentAdjust(	moon,	926,	1	);	
InventoryComponentAdjust(	moon,	426,	1	);	
InventoryComponentAdjust(	moon,	850,	1	);	
InventoryComponentAdjust(	moon,	812,	1	);	


InventoryVehicleAdjust(	moon,	25,	1	);	#Bolo
InventoryweaponAdjust(	-1,	111,	2	);	
InventoryComponentAdjust(	moon,	133,	1	);	
InventoryComponentAdjust(	-1,	230,	1	);	
InventoryComponentAdjust(	moon,	806,	1	);	
InventoryComponentAdjust(	moon,	927,	1	);	
InventoryComponentAdjust(	moon,	428,	1	);	
InventoryComponentAdjust(	moon,	865,	1	);	
InventoryComponentAdjust(	moon,	830,	1	);	
InventoryComponentAdjust(	moon,	885,	1	);	

InventoryVehicleAdjust(	moon,	26,	1	);	#Recluse
InventoryweaponAdjust(	moon,	104,	1	);	
InventoryweaponAdjust(	-1,	133,	2	);	
InventoryComponentAdjust(	moon,	133,	1	);	
InventoryComponentAdjust(	moon,	225,	1	);	
InventoryComponentAdjust(	moon,	806,	1	);	
InventoryComponentAdjust(	moon,	927,	1	);	
InventoryComponentAdjust(	moon,	426,	1	);	
InventoryComponentAdjust(	moon,	812,	1	);	
InventoryComponentAdjust(	moon,	830,	1	);	
InventoryComponentAdjust(	moon,	885,	1	);	

InventoryVehicleAdjust(	ice,	21,	2	);	#Goad
InventoryweaponAdjust(	ice,	102,	4	);	
InventoryComponentAdjust(	ice,	132,	2	);	
InventoryComponentAdjust(	ice,	227,	2	);	
InventoryComponentAdjust(	ice,	806,	2	);	
InventoryComponentAdjust(	ice,	328,	2	);	
InventoryComponentAdjust(	ice,	929,	2	);	
InventoryComponentAdjust(	ice,	432,	2	);	
InventoryComponentAdjust(	ice,	812,	2	);	
InventoryComponentAdjust(	ice,	840,	2	);	


InventoryVehicleAdjust(	ice,	20,	2	);	#Seeker
InventoryweaponAdjust(	ice,	117,	4	);	
InventoryComponentAdjust(	ice,	129,	2	);	
InventoryComponentAdjust(	ice,	225,	2	);	
InventoryComponentAdjust(	ice,	806,	2	);	
InventoryComponentAdjust(	ice,	328,	2	);	
InventoryComponentAdjust(	ice,	926,	2	);	
InventoryComponentAdjust(	ice,	426,	2	);	
InventoryComponentAdjust(	ice,	850,	2	);	
InventoryComponentAdjust(	ice,	812,	2	);	


InventoryVehicleAdjust(	ice,	25,	1	);	#Bolo
InventoryweaponAdjust(	-1,	111,	2	);	
InventoryComponentAdjust(	ice,	133,	1	);	
InventoryComponentAdjust(	-1,	230,	1	);	
InventoryComponentAdjust(	ice,	806,	1	);	
InventoryComponentAdjust(	ice,	927,	1	);	
InventoryComponentAdjust(	ice,	428,	1	);	
InventoryComponentAdjust(	ice,	865,	1	);	
InventoryComponentAdjust(	ice,	830,	1	);	
InventoryComponentAdjust(	ice,	885,	1	);	

InventoryVehicleAdjust(	ice,	26,	1	);	#Recluse
InventoryweaponAdjust(	ice,	104,	1	);	
InventoryweaponAdjust(	-1,	133,	2	);	
InventoryComponentAdjust(	ice,	133,	1	);	
InventoryComponentAdjust(	ice,	225,	1	);	
InventoryComponentAdjust(	ice,	806,	1	);	
InventoryComponentAdjust(	ice,	927,	1	);	
InventoryComponentAdjust(	ice,	426,	1	);	
InventoryComponentAdjust(	ice,	812,	1	);	
InventoryComponentAdjust(	ice,	830,	1	);	
InventoryComponentAdjust(	ice,	885,	1	);	

InventoryVehicleAdjust(	ice,	22,	1	);	#Shepherd
InventoryweaponAdjust(	ice,	118,	2	);	
InventoryweaponAdjust(	ice,	104,	2	);	
InventoryComponentAdjust(	ice,	136,	1	);	
InventoryComponentAdjust(	ice,	228,	1	);	
InventoryComponentAdjust(	ice,	807,	1	);	
InventoryComponentAdjust(	ice,	332,	1	);	
InventoryComponentAdjust(	ice,	930,	1	);	
InventoryComponentAdjust(	ice,	427,	1	);	
InventoryComponentAdjust(	ice,	845,	1	);	
InventoryComponentAdjust(	ice,	850,	1	);	
					
InventoryVehicleAdjust(	ice,	23,	1	);	#Adjudicator
InventoryweaponAdjust(	ice,	121,	2	);	
InventoryweaponAdjust(	ice,	104,	1	);	
InventoryweaponAdjust(	ice,	142,	1	);	
InventoryComponentAdjust(	ice,	139,	1	);	
InventoryComponentAdjust(	ice,	229,	1	);	
InventoryComponentAdjust(	ice,	806,	1	);	
InventoryComponentAdjust(	ice,	331,	1	);	
InventoryComponentAdjust(	ice,	927,	1	);	
InventoryComponentAdjust(	ice,	432,	1	);	
InventoryComponentAdjust(	ice,	865,	1	);	
InventoryComponentAdjust(	ice,	813,	1	);	

InventoryVehicleAdjust(	temperate,	21,	2	);	#Goad
InventoryweaponAdjust(	temperate,	102,	4	);	
InventoryComponentAdjust(	temperate,	132,	2	);	
InventoryComponentAdjust(	temperate,	227,	2	);	
InventoryComponentAdjust(	temperate,	806,	2	);	
InventoryComponentAdjust(	temperate,	328,	2	);	
InventoryComponentAdjust(	temperate,	929,	2	);	
InventoryComponentAdjust(	temperate,	432,	2	);	
InventoryComponentAdjust(	temperate,	812,	2	);	
InventoryComponentAdjust(	temperate,	840,	2	);	


InventoryVehicleAdjust(	temperate,	20,	1	);	#Seeker
InventoryweaponAdjust(	temperate,	117,	2	);	
InventoryComponentAdjust(	temperate,	129,	1	);	
InventoryComponentAdjust(	temperate,	225,	1	);	
InventoryComponentAdjust(	temperate,	806,	1	);	
InventoryComponentAdjust(	temperate,	328,	1	);	
InventoryComponentAdjust(	temperate,	926,	1	);	
InventoryComponentAdjust(	temperate,	426,	1	);	
InventoryComponentAdjust(	temperate,	850,	1	);	
InventoryComponentAdjust(	temperate,	812,	1	);	


InventoryVehicleAdjust(	temperate,	25,	1	);	#Bolo
InventoryweaponAdjust(	temperate,	111,	2	);	
InventoryComponentAdjust(	temperate,	133,	1	);	
InventoryComponentAdjust(	temperate,	230,	1	);	
InventoryComponentAdjust(	temperate,	806,	1	);	
InventoryComponentAdjust(	temperate,	927,	1	);	
InventoryComponentAdjust(	temperate,	428,	1	);	
InventoryComponentAdjust(	temperate,	865,	1	);	
InventoryComponentAdjust(	temperate,	830,	1	);	
InventoryComponentAdjust(	temperate,	885,	1	);	
					
InventoryVehicleAdjust(	temperate,	26,	2	);	#Recluse
InventoryweaponAdjust(	temperate,	104,	2	);	
InventoryweaponAdjust(	temperate,	133,	4	);	
InventoryComponentAdjust(	temperate,	133,	2	);	
InventoryComponentAdjust(	temperate,	225,	2	);	
InventoryComponentAdjust(	temperate,	806,	2	);	
InventoryComponentAdjust(	temperate,	927,	2	);	
InventoryComponentAdjust(	temperate,	426,	2	);	
InventoryComponentAdjust(	temperate,	812,	2	);	
InventoryComponentAdjust(	temperate,	830,	2	);	
InventoryComponentAdjust(	temperate,	885,	2	);	

InventoryVehicleAdjust(	temperate,	22,	2	);	#Shepherd
InventoryweaponAdjust(	temperate,	118,	4	);	
InventoryweaponAdjust(	temperate,	104,	4	);	
InventoryComponentAdjust(	temperate,	136,	2	);	
InventoryComponentAdjust(	temperate,	228,	2	);	
InventoryComponentAdjust(	temperate,	807,	2	);	
InventoryComponentAdjust(	temperate,	332,	2	);	
InventoryComponentAdjust(	temperate,	930,	2	);	
InventoryComponentAdjust(	temperate,	427,	2	);	
InventoryComponentAdjust(	temperate,	845,	2	);	
InventoryComponentAdjust(	temperate,	850,	2	);	
					
InventoryVehicleAdjust(	temperate,	23,	1	);	#Adjudicator
InventoryweaponAdjust(	temperate,	121,	2	);	
InventoryweaponAdjust(	temperate,	104,	1	);	
InventoryweaponAdjust(	temperate,	142,	1	);	
InventoryComponentAdjust(	temperate,	139,	1	);	
InventoryComponentAdjust(	temperate,	229,	1	);	
InventoryComponentAdjust(	temperate,	806,	1	);	
InventoryComponentAdjust(	temperate,	331,	1	);	
InventoryComponentAdjust(	temperate,	927,	1	);	
InventoryComponentAdjust(	temperate,	432,	1	);	
InventoryComponentAdjust(	temperate,	865,	1	);	
InventoryComponentAdjust(	temperate,	813,	1	);	
					
InventoryVehicleAdjust(	temperate,	24,	1	);	#Executioner
InventoryweaponAdjust(	temperate,	130,	2	);	
InventoryweaponAdjust(	temperate,	109,	2	);	
InventoryComponentAdjust(	temperate,	143,	1	);	
InventoryComponentAdjust(	temperate,	230,	1	);	
InventoryComponentAdjust(	temperate,	806,	1	);	
InventoryComponentAdjust(	temperate,	333,	1	);	
InventoryComponentAdjust(	temperate,	927,	1	);	
InventoryComponentAdjust(	temperate,	431,	1	);	
InventoryComponentAdjust(	temperate,	812,	1	);	
InventoryComponentAdjust(	temperate,	865,	1	);	
					
InventoryVehicleAdjust(	temperate,	25,	1	);	#Bolo
InventoryweaponAdjust(	temperate,	111,	2	);	
InventoryComponentAdjust(	temperate,	133,	1	);	
InventoryComponentAdjust(	temperate,	230,	1	);	
InventoryComponentAdjust(	temperate,	806,	1	);	
InventoryComponentAdjust(	temperate,	927,	1	);	
InventoryComponentAdjust(	temperate,	428,	1	);	
InventoryComponentAdjust(	temperate,	865,	1	);	
InventoryComponentAdjust(	temperate,	830,	1	);	
InventoryComponentAdjust(	temperate,	885,	1	);	
					
					
InventoryVehicleAdjust(	desert,	21,	1	);	#Goad
InventoryweaponAdjust(	desert,	102,	2	);	
InventoryComponentAdjust(	desert,	132,	1	);	
InventoryComponentAdjust(	desert,	227,	1	);	
InventoryComponentAdjust(	desert,	806,	1	);	
InventoryComponentAdjust(	desert,	328,	1	);	
InventoryComponentAdjust(	desert,	929,	1	);	
InventoryComponentAdjust(	desert,	432,	1	);	
InventoryComponentAdjust(	desert,	812,	1	);	
InventoryComponentAdjust(	desert,	840,	1	);	


InventoryVehicleAdjust(	desert,	20,	1	);	#Seeker
InventoryweaponAdjust(	desert,	117,	2	);	
InventoryComponentAdjust(	desert,	129,	1	);	
InventoryComponentAdjust(	desert,	225,	1	);	
InventoryComponentAdjust(	desert,	806,	1	);	
InventoryComponentAdjust(	desert,	328,	1	);	
InventoryComponentAdjust(	desert,	926,	1	);	
InventoryComponentAdjust(	desert,	426,	1	);	
InventoryComponentAdjust(	desert,	850,	1	);	
InventoryComponentAdjust(	desert,	812,	1	);	


InventoryVehicleAdjust(	desert,	25,	1	);	#Bolo
InventoryweaponAdjust(	desert,	111,	2	);	
InventoryComponentAdjust(	desert,	133,	1	);	
InventoryComponentAdjust(	desert,	230,	1	);	
InventoryComponentAdjust(	desert,	806,	1	);	
InventoryComponentAdjust(	desert,	927,	1	);	
InventoryComponentAdjust(	desert,	428,	1	);	
InventoryComponentAdjust(	desert,	865,	1	);	
InventoryComponentAdjust(	desert,	830,	1	);	
InventoryComponentAdjust(	desert,	885,	1	);	
					
InventoryVehicleAdjust(	desert,	26,	1	);	#Recluse
InventoryweaponAdjust(	desert,	104,	1	);	
InventoryweaponAdjust(	desert,	133,	2	);	
InventoryComponentAdjust(	desert,	133,	1	);	
InventoryComponentAdjust(	desert,	225,	1	);	
InventoryComponentAdjust(	desert,	806,	1	);	
InventoryComponentAdjust(	desert,	927,	1	);	
InventoryComponentAdjust(	desert,	426,	1	);	
InventoryComponentAdjust(	desert,	812,	1	);	
InventoryComponentAdjust(	desert,	830,	1	);	
InventoryComponentAdjust(	desert,	885,	1	);	

InventoryVehicleAdjust(	desert,	22,	1	);	#Shepherd
InventoryweaponAdjust(	desert,	118,	2	);	
InventoryweaponAdjust(	desert,	104,	2	);	
InventoryComponentAdjust(	desert,	136,	1	);	
InventoryComponentAdjust(	desert,	228,	1	);	
InventoryComponentAdjust(	desert,	807,	1	);	
InventoryComponentAdjust(	desert,	332,	1	);	
InventoryComponentAdjust(	desert,	930,	1	);	
InventoryComponentAdjust(	desert,	427,	1	);	
InventoryComponentAdjust(	desert,	845,	1	);	
InventoryComponentAdjust(	desert,	850,	1	);	
					
InventoryVehicleAdjust(	desert,	23,	1	);	#Adjudicator
InventoryweaponAdjust(	desert,	121,	2	);	
InventoryweaponAdjust(	desert,	104,	1	);	
InventoryweaponAdjust(	desert,	142,	1	);	
InventoryComponentAdjust(	desert,	139,	1	);	
InventoryComponentAdjust(	desert,	229,	1	);	
InventoryComponentAdjust(	desert,	806,	1	);	
InventoryComponentAdjust(	desert,	331,	1	);	
InventoryComponentAdjust(	desert,	927,	1	);	
InventoryComponentAdjust(	desert,	432,	1	);	
InventoryComponentAdjust(	desert,	865,	1	);	
InventoryComponentAdjust(	desert,	813,	1	);	
					
InventoryVehicleAdjust(	desert,	24,	1	);	#Executioner
InventoryweaponAdjust(	desert,	130,	2	);	
InventoryweaponAdjust(	desert,	109,	2	);	
InventoryComponentAdjust(	desert,	143,	1	);	
InventoryComponentAdjust(	desert,	230,	1	);	
InventoryComponentAdjust(	desert,	806,	1	);	
InventoryComponentAdjust(	desert,	333,	1	);	
InventoryComponentAdjust(	desert,	927,	1	);	
InventoryComponentAdjust(	desert,	431,	1	);	
InventoryComponentAdjust(	desert,	812,	1	);	
InventoryComponentAdjust(	desert,	865,	1	);	

