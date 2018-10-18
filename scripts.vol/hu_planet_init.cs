							
#Initial Planet Inventory Setup for Human Campaigns			

#Inventory setup parameters			

#inventoryComponentSet	(planet, componentId, amount);		
# set the availability of a component	planet:		either a planet name or -1 for the stash
#	componentId:		id of the component, or -1 for all components
#	amount:		number available, or -1 for an infinite supply
#			
#inventoryWeaponSet	(planet, weaponId, amount);		
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
			
#Hercs			
#weapons			
InventoryWeaponSet(	mars,	101,	2	);	#Laser
InventoryWeaponSet(	mars,	102,	2	);	#Heavy Laser
InventoryWeaponSet(	mars,	103,	0	);	#Comp Laser
InventoryWeaponSet(	mars,	104,	0	);	#Twin Laser
InventoryWeaponSet(	mars,	105,	2	);	#Emp
InventoryWeaponSet(	mars,	106,	2	);	#ELF
InventoryWeaponSet(	mars,	107,	2	);	#Blaster
InventoryWeaponSet(	mars,	108,	2	);	#Heavy Blaster
InventoryWeaponSet(	mars,	109,	0	);	#PBW
InventoryWeaponSet(	mars,	110,	0	);	#Plasma
InventoryWeaponSet(	mars,	111,	0	);	#Blink Gun 
InventoryWeaponSet(	mars,	112,	0	);	#Qgun
InventoryWeaponSet(	mars,	113,	0	);	#MFAC
InventoryWeaponSet(	mars,	114,	0	);	#Nano Infuser
InventoryWeaponSet(	mars,	115,	2	);	#Nanite Cannon
InventoryWeaponSet(	mars,	116,	2	);	#Autocannon
InventoryWeaponSet(	mars,	117,	2	);	#Hvy Autocannon
InventoryWeaponSet(	mars,	118,	0	);	#EMC Autocannon
InventoryWeaponSet(	mars,	119,	2	);	#Blast Cannon
InventoryWeaponSet(	mars,	120,	2	);	#Hvy Blast Can
InventoryWeaponSet(	mars,	121,	0	);	#Rail Gun
InventoryWeaponSet(	mars,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	mars,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	mars,	124,	2	);	#Pit Viper 8
InventoryWeaponSet(	mars,	125,	0	);	#Pit Viper 12
InventoryWeaponSet(	mars,	126,	2	);	#Sparrow 6
InventoryWeaponSet(	mars,	127,	2	);	#Sparrow 10
InventoryWeaponSet(	mars,	128,	0	);	#SWARM 6
InventoryWeaponSet(	mars,	129,	0	);	#Minion
InventoryWeaponSet(	mars,	130,	0	);	#Shrike 8
InventoryWeaponSet(	mars,	147,	2	);	#Aphid
InventoryWeaponSet(	mars,	131,	0	);	#Arachnitron 4
InventoryWeaponSet(	mars,	132,	0	);	#Arachnitron 8 
InventoryWeaponSet(	mars,	133,	0	);	#Arachnitron 12 
InventoryWeaponSet(	mars,	134,	2	);	#Proximity 6 
InventoryWeaponSet(	mars,	135,	2	);	#Proximity 10 
InventoryWeaponSet(	mars,	136,	2	);	#Proximity 15
InventoryWeaponSet(	mars,	1,	0	);	#Nike
InventoryWeaponSet(	mars,	2,	0	);	#AML
InventoryWeaponSet(	mars,	142,	0	);	#Radiation Gun
InventoryWeaponSet(	mars,	3,	0	);	#Disrupter
InventoryWeaponSet(	mars,	4,	0	);	#Electrohull
InventoryWeaponSet(	mars,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	mars,	146,	0	);	#FOG
InventoryWeaponSet(	mars,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	mars,	150,	0	);	#SMART Gun

#Reactors					
InventoryComponentSet(	mars,	200,	2	);	# Human Micro Reactor
InventoryComponentSet(	mars,	201,	2	);	# Small Human Reactor 2 -- small
InventoryComponentSet(	mars,	202,	2	);	# Medium Human Reactor 1 Standard
InventoryComponentSet(	mars,	203,	1	);	# Medium Human Reactor 2 medium
InventoryComponentSet(	mars,	204,	1	);	# Large Human Reactor 1 -- large
InventoryComponentSet(	mars,	205,	1	);	# Large Human Reactor 2-- Maxim
					
#Shields					
InventoryComponentSet(	mars,	300,	2	);	# Human Standard Shield
InventoryComponentSet(	mars,	301,	2	);	# Human Protector Shield
InventoryComponentSet(	mars,	302,	2	);	# Human Guardian Shield
InventoryComponentSet(	mars,	303,	2	);	# Human FastCharge Shield
InventoryComponentSet(	mars,	304,	2	);	# Human Centurian Shield
InventoryComponentSet(	mars,	305,	2	);	# Human Repulsor Shield
InventoryComponentSet(	mars,	306,	2	);	# Human Titan Shield
InventoryComponentSet(	mars,	307,	1	);	# Human Medusa Shield
					
#Sensors					
InventoryComponentSet(	mars,	400,	2	);	# Basic Human Sensor
InventoryComponentSet(	mars,	401,	1	);	# Long Range Sensor -- Ranger
InventoryComponentSet(	mars,	408,	3	);	#Standard Human Sensor
InventoryComponentSet(	mars,	409,	1	);	#Human Longbow Sensor
InventoryComponentSet(	mars,	410,	1	);	#Human Infiltrator Sensor
InventoryComponentSet(	mars,	411,	1	);	#Human Crossbow Sensor
InventoryComponentSet(	mars,	412,	2	);	#Human Ultralight Sensor
InventoryComponentSet(	mars,	413,	0	);	#Human Hound Dog Sensor
InventoryComponentSet(	mars,	414,	0	);	#Thermal Sensor
					
#Engines					
InventoryComponentSet(	mars,	100,	1	);	# Human Light Vehicle Engine
InventoryComponentSet(	mars,	101,	1	);	# Human High Output Light Engine
InventoryComponentSet(	mars,	102,	1	);	# Human Agile Light Engine
InventoryComponentSet(	mars,	103,	1	);	# Human Standard Medium Engine
InventoryComponentSet(	mars,	104,	1	);	# Human High Output Medium Engine
InventoryComponentSet(	mars,	105,	1	);	# Human Medium Agility Engine
InventoryComponentSet(	mars,	106,	1	);	# Human Standard Heavy Engine
InventoryComponentSet(	mars,	107,	1	);	# Human Improved Heavy Engine
InventoryComponentSet(	mars,	108,	1	);	# Human Heavy Cruise Engine
InventoryComponentSet(	mars,	109,	1	);	# Human High Output Heavy Engine
InventoryComponentSet(	mars,	110,	1	);	# Human Agile Heavy Engine
InventoryComponentSet(	mars,	111,	1	);	# Human Standard Assault Engine
InventoryComponentSet(	mars,	112,	1	);	# Human Improved Assault Engine
InventoryComponentSet(	mars,	113,	1	);	# Human heavy turbine engine
InventoryComponentSet(	mars,	114,	1	);	# High Output Turbine (HOT)
InventoryComponentSet(	mars,	115,	1	);	# Human super heavy engine
					
#Internal Components					
InventoryComponentSet(	mars,	800,	2	);	#Human Basic Computer
InventoryComponentSet(	mars,	801,	2	);	# Human Improved Computer
InventoryComponentSet(	mars,	802,	2	);	# Human Advanced Computer
InventoryComponentSet(	mars,	805,	0	);	# Cybrid Basic Systems Control
InventoryComponentSet(	mars,	806,	0	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	mars,	807,	0	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	mars,	810,	1	);	# Guardian ECM
InventoryComponentSet(	mars,	811,	1	);	# Doppleganger ECM
InventoryComponentSet(	mars,	812,	0	);	# Cybrid Alpha ECM
InventoryComponentSet(	mars,	813,	0	);	#Cybrid Beta ECM
InventoryComponentSet(	mars,	820,	1	);	# Thermal Diffuser
#InventoryComponentSet(	mars,	825,	0	);	# Flares
InventoryComponentSet(	mars,	830,	2	);	# Chameleon
InventoryComponentSet(	mars,	831,	1	);	# Cuttlefish cloak
InventoryComponentSet(	mars,	840,	1	);	# Shield Modulator
InventoryComponentSet(	mars,	845,	1	);	# Shield Capacitor
InventoryComponentSet(	mars,	850,	1	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	mars,	860,	2	);	# Laser Targeting Module
InventoryComponentSet(	mars,	865,	3	);	# Extra Battery
InventoryComponentSet(	mars,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	mars,	875,	1	);	# Field Stabilizer
InventoryComponentSet(	mars,	880,	1	);	# Rocket Booster
InventoryComponentSet(	mars,	885,	0	);	# Turbine Boost
InventoryComponentSet(	mars,	890,	0	);	#NanoRepair
InventoryComponentSet(	mars,	900,	3	);	#Angle Life Support
InventoryComponentSet(	mars,	910,	0	);	#Agrav Generator
InventoryComponentSet(	mars,	914,	0	);	#UAP
					
#Armor					
InventoryComponentAdjust(	mars,	926,	2	);	#Carbon Fiber (CARLAM)
InventoryComponentAdjust(	mars,	927,	2	);	#Quad Bonded Metaplas (QBM)
InventoryComponentAdjust(	mars,	928,	1	);	#DURAC (Depleteted Uranium)
InventoryComponentAdjust(	mars,	929,	2	);	#Ceramic
InventoryComponentAdjust(	mars,	930,	1	);	#Crystaluminum
InventoryComponentAdjust(	mars,	931,	0	);	#Quicksilver
					
#Pilots					
InventoryPilotSet(	mars,	1,	FALSE	);	# Collossa (Jaguar), Imperial
InventoryPilotSet(	mars,	2,	FALSE	);	# Hunter Otobe, Rebel
InventoryPilotSet(	mars,	3,	FALSE	);	# Bioderm Delta-Six Niner, Rebel
InventoryPilotSet(	mars,	4,	FALSE	);	
InventoryPilotSet(	mars,	5,	FALSE	);	# Deathwish, Imperial
InventoryPilotSet(	mars,	6,	FALSE	);	# Hangman, Imperial
InventoryPilotSet(	mars,	7,	FALSE	);	
InventoryPilotSet(	mars,	8,	FALSE	);	#Tigress, Imperial
InventoryPilotSet(	mars,	9,	FALSE	);	#Oliphant, Imperial
InventoryPilotSet(	mars,	10,	FALSE	);	#Riana, Rebel
InventoryPilotSet(	mars,	11,	FALSE	);	#Saxon, Rebel
InventoryPilotSet(	mars,	12,	FALSE	);	#Verity, Rebel
InventoryPilotSet(	mars,	13,	FALSE	);	#Generic
InventoryPilotSet(	mars,	14,	FALSE	);	#Generic
InventoryPilotSet(	mars,	15,	FALSE	);	#Generic
					

#VENUS					
#Hercs					
					
#weapons					
InventoryWeaponSet(	venus,	101,	2	);	#Laser
InventoryWeaponSet(	venus,	102,	4	);	#Heavy Laser
InventoryWeaponSet(	venus,	103,	2	);	#Comp Laser
InventoryWeaponSet(	venus,	104,	2	);	#Twin Laser
InventoryWeaponSet(	venus,	105,	2	);	#Emp
InventoryWeaponSet(	venus,	106,	2	);	#ELF
InventoryWeaponSet(	venus,	107,	2	);	#Blaster
InventoryWeaponSet(	venus,	108,	2	);	#Heavy Blaster
InventoryWeaponSet(	venus,	109,	0	);	#PBW
InventoryWeaponSet(	venus,	110,	2	);	#Plasma
InventoryWeaponSet(	venus,	111,	0	);	#Blink Gun 
InventoryWeaponSet(	venus,	112,	2	);	#Qgun
InventoryWeaponSet(	venus,	113,	0	);	#MFAC
InventoryWeaponSet(	venus,	114,	0	);	#Nano Infuser
InventoryWeaponSet(	venus,	115,	2	);	#Nanite Cannon
InventoryWeaponSet(	venus,	116,	6	);	#Autocannon
InventoryWeaponSet(	venus,	117,	4	);	#Hvy Autocannon
InventoryWeaponSet(	venus,	118,	0	);	#EMC Autocannon
InventoryWeaponSet(	venus,	119,	2	);	#Blast Cannon
InventoryWeaponSet(	venus,	120,	2	);	#Hvy Blast Can
InventoryWeaponSet(	venus,	121,	0	);	#Rail Gun
InventoryWeaponSet(	venus,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	venus,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	venus,	124,	2	);	#Pit Viper 8
InventoryWeaponSet(	venus,	125,	2	);	#Pit Viper 12
InventoryWeaponSet(	venus,	126,	2	);	#Sparrow 6
InventoryWeaponSet(	venus,	127,	2	);	#Sparrow 10
InventoryWeaponSet(	venus,	128,	2	);	#SWARM 6
InventoryWeaponSet(	venus,	129,	2	);	#Minion
InventoryWeaponSet(	venus,	130,	0	);	#Shrike 8
InventoryWeaponSet(	venus,	147,	2	);	#Aphid
InventoryWeaponSet(	venus,	131,	0	);	#Arachnitron 4
InventoryWeaponSet(	venus,	132,	0	);	#Arachnitron 8 
InventoryWeaponSet(	venus,	133,	0	);	#Arachnitron 12 
InventoryWeaponSet(	venus,	134,	2	);	#Proximity 6 
InventoryWeaponSet(	venus,	135,	2	);	#Proximity 10 
InventoryWeaponSet(	venus,	136,	2	);	#Proximity 15
InventoryWeaponSet(	venus,	1,	0	);	#Nike
InventoryWeaponSet(	venus,	2,	0	);	#AML
InventoryWeaponSet(	venus,	142,	0	);	#Radiation Gun
InventoryWeaponSet(	venus,	3,	1	);	#Disrupter
InventoryWeaponSet(	venus,	4,	1	);	#Electrohull
InventoryWeaponSet(	venus,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	venus,	146,	0	);	#FOG
InventoryWeaponSet(	venus,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	venus,	150,	2	);	#SMART Gun

#Reactors					
InventoryComponentSet(	venus,	200,	2	);	# Human Micro Reactor
InventoryComponentSet(	venus,	201,	2	);	# Small Human Reactor 2 -- small
InventoryComponentSet(	venus,	202,	2	);	# Medium Human Reactor 1 Standard
InventoryComponentSet(	venus,	203,	2	);	# Medium Human Reactor 2 medium
InventoryComponentSet(	venus,	204,	2	);	# Large Human Reactor 1 -- large
InventoryComponentSet(	venus,	205,	2	);	# Large Human Reactor 2-- Maxim
					
#Shields					
InventoryComponentSet(	venus,	300,	2	);	# Human Standard Shield
InventoryComponentSet(	venus,	301,	2	);	# Human Protector Shield
InventoryComponentSet(	venus,	302,	2	);	# Human Guardian Shield
InventoryComponentSet(	venus,	303,	2	);	# Human FastCharge Shield
InventoryComponentSet(	venus,	304,	2	);	# Human Centurian Shield
InventoryComponentSet(	venus,	305,	2	);	# Human Repulsor Shield
InventoryComponentSet(	venus,	306,	2	);	# Human Titan Shield
InventoryComponentSet(	venus,	307,	2	);	# Human Medusa Shield
					
#Sensors					
InventoryComponentSet(	venus,	400,	4	);	# Basic Human Sensor
InventoryComponentSet(	venus,	401,	2	);	# Long Range Sensor -- Ranger
InventoryComponentSet(	venus,	408,	4	);	#Standard Human Sensor
InventoryComponentSet(	venus,	409,	2	);	#Human Longbow Sensor
InventoryComponentSet(	venus,	410,	2	);	#Human Infiltrator Sensor
InventoryComponentSet(	venus,	411,	1	);	#Human Crossbow Sensor
InventoryComponentSet(	venus,	412,	2	);	#Human Ultralight Sensor
InventoryComponentSet(	venus,	413,	1	);	#Human Hound Dog Sensor
InventoryComponentSet(	venus,	414,	1	);	#Thermal Sensor
					
#Engines					
InventoryComponentSet(	venus,	100,	1	);	# Human Light Vehicle Engine
InventoryComponentSet(	venus,	101,	2	);	# Human High Output Light Engine
InventoryComponentSet(	venus,	102,	1	);	# Human Agile Light Engine
InventoryComponentSet(	venus,	103,	1	);	# Human Standard Medium Engine
InventoryComponentSet(	venus,	104,	2	);	# Human High Output Medium Engine
InventoryComponentSet(	venus,	105,	1	);	# Human Medium Agility Engine
InventoryComponentSet(	venus,	106,	1	);	# Human Standard Heavy Engine
InventoryComponentSet(	venus,	107,	1	);	# Human Improved Heavy Engine
InventoryComponentSet(	venus,	108,	1	);	# Human Heavy Cruise Engine
InventoryComponentSet(	venus,	109,	1	);	# Human High Output Heavy Engine
InventoryComponentSet(	venus,	110,	1	);	# Human Agile Heavy Engine
InventoryComponentSet(	venus,	111,	1	);	# Human Standard Assault Engine
InventoryComponentSet(	venus,	112,	1	);	# Human Improved Assault Engine
InventoryComponentSet(	venus,	113,	1	);	# Human heavy turbine engine
InventoryComponentSet(	venus,	114,	1	);	# High Output Turbine (HOT)
InventoryComponentSet(	venus,	115,	1	);	# Human super heavy engine
					
#Internal Components					
InventoryComponentSet(	venus,	800,	4	);	#Human Basic Computer
InventoryComponentSet(	venus,	801,	2	);	# Human Improved Computer
InventoryComponentSet(	venus,	802,	2	);	# Human Advanced Computer
InventoryComponentSet(	venus,	810,	2	);	# Guardian ECM
InventoryComponentSet(	venus,	811,	2	);	# Doppleganger ECM
InventoryComponentSet(	venus,	820,	2	);	# Thermal Diffuser
InventoryComponentSet(	venus,	830,	1	);	# Chameleon
InventoryComponentSet(	venus,	831,	1	);	# Cuttlefish cloak
InventoryComponentSet(	venus,	840,	2	);	# Shield Modulator
InventoryComponentSet(	venus,	845,	2	);	# Shield Capacitor
InventoryComponentSet(	venus,	850,	1	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	venus,	860,	4	);	# Laser Targeting Module
InventoryComponentSet(	venus,	865,	3	);	# Extra Battery
InventoryComponentSet(	venus,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	venus,	875,	2	);	# Field Stabilizer
InventoryComponentSet(	venus,	880,	1	);	# Rocket Booster
InventoryComponentSet(	venus,	885,	2	);	# Turbine Boost
InventoryComponentSet(	venus,	890,	0	);	#NanoRepair
InventoryComponentSet(	venus,	900,	3	);	#Angle Life Support
InventoryComponentSet(	venus,	914,	2	);	#UAP
					
#Armor					
InventoryComponentSet(	venus,	926,	2	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	venus,	927,	2	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	venus,	928,	2	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	venus,	929,	2	);	#Ceramic
InventoryComponentSet(	venus,	930,	2	);	#Crystaluminum
InventoryComponentSet(	venus,	931,	1	);	#Quicksilver

#Pilots					
InventoryPilotSet(	venus,	1,	TRUE	);	# Collossa (Jaguar), Imperial
InventoryPilotSet(	venus,	2,	TRUE	);	# Hunter Otobe, Rebel
InventoryPilotSet(	venus,	3,	TRUE	);	# Bioderm Delta-Six Niner, Rebel
InventoryPilotSet(	venus,	4,	TRUE	);	
InventoryPilotSet(	venus,	5,	TRUE	);	# Deathwish, Imperial
InventoryPilotSet(	venus,	6,	TRUE	);	# Hangman, Imperial
InventoryPilotSet(	venus,	7,	TRUE	);	
InventoryPilotSet(	venus,	8,	TRUE	);	#Tigress, Imperial
InventoryPilotSet(	venus,	9,	TRUE	);	#Oliphant, Imperial
InventoryPilotSet(	venus,	10,	TRUE	);	#Riana, Rebel
InventoryPilotSet(	venus,	11,	TRUE	);	#Saxon, Rebel
InventoryPilotSet(	venus,	12,	TRUE	);	#Verity, Rebel
InventoryPilotSet(	venus,	13,	TRUE	);	#Generic
InventoryPilotSet(	venus,	14,	TRUE	);	#Generic
InventoryPilotSet(	venus,	15,	FALSE	);	#Generic
					
					
#Titan					
					
#Hercs					
					
#weapons					
InventoryWeaponSet(	titan,	101,	2	);	#Laser
InventoryWeaponSet(	titan,	102,	4	);	#Heavy Laser
InventoryWeaponSet(	titan,	103,	4	);	#Comp Laser
InventoryWeaponSet(	titan,	104,	0	);	#Twin Laser
InventoryWeaponSet(	titan,	105,	2	);	#Emp
InventoryWeaponSet(	titan,	106,	2	);	#ELF
InventoryWeaponSet(	titan,	107,	0	);	#Blaster
InventoryWeaponSet(	titan,	108,	0	);	#Heavy Blaster
InventoryWeaponSet(	titan,	109,	0	);	#PBW
InventoryWeaponSet(	titan,	110,	2	);	#Plasma
InventoryWeaponSet(	titan,	111,	0	);	#Blink Gun 
InventoryWeaponSet(	titan,	112,	0	);	#Qgun
InventoryWeaponSet(	titan,	113,	0	);	#MFAC
InventoryWeaponSet(	titan,	114,	0	);	#Nano Infuser
InventoryWeaponSet(	titan,	115,	0	);	#Nanite Cannon
InventoryWeaponSet(	titan,	116,	4	);	#Autocannon
InventoryWeaponSet(	titan,	117,	4	);	#Hvy Autocannon
InventoryWeaponSet(	titan,	118,	0	);	#EMC Autocannon
InventoryWeaponSet(	titan,	119,	2	);	#Blast Cannon
InventoryWeaponSet(	titan,	120,	2	);	#Hvy Blast Can
InventoryWeaponSet(	titan,	121,	0	);	#Rail Gun
InventoryWeaponSet(	titan,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	titan,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	titan,	124,	2	);	#Pit Viper 8
InventoryWeaponSet(	titan,	125,	4	);	#Pit Viper 12
InventoryWeaponSet(	titan,	126,	2	);	#Sparrow 6
InventoryWeaponSet(	titan,	127,	4	);	#Sparrow 10
InventoryWeaponSet(	titan,	128,	2	);	#SWARM 6
InventoryWeaponSet(	titan,	129,	2	);	#Minion
InventoryWeaponSet(	titan,	130,	0	);	#Shrike 8
InventoryWeaponSet(	titan,	147,	2	);	#Aphid
InventoryWeaponSet(	titan,	131,	0	);	#Arachnitron 4
InventoryWeaponSet(	titan,	132,	0	);	#Arachnitron 8 
InventoryWeaponSet(	titan,	133,	0	);	#Arachnitron 12 
InventoryWeaponSet(	titan,	134,	2	);	#Proximity 6 
InventoryWeaponSet(	titan,	135,	2	);	#Proximity 10 
InventoryWeaponSet(	titan,	136,	4	);	#Proximity 15
InventoryWeaponSet(	titan,	1,	0	);	#Nike
InventoryWeaponSet(	titan,	2,	0	);	#AML
InventoryWeaponSet(	titan,	142,	0	);	#Radiation Gun
InventoryWeaponSet(	titan,	3,	1	);	#Disrupter
InventoryWeaponSet(	titan,	4,	1	);	#Electrohull
InventoryWeaponSet(	titan,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	titan,	146,	0	);	#FOG
InventoryWeaponSet(	titan,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	titan,	150,	0	);	#SMART Gun

#Reactors					
InventoryComponentSet(	titan,	200,	2	);	# Human Micro Reactor
InventoryComponentSet(	titan,	201,	2	);	# Small Human Reactor 2 -- small
InventoryComponentSet(	titan,	202,	2	);	# Medium Human Reactor 1 Standard
InventoryComponentSet(	titan,	203,	2	);	# Medium Human Reactor 2 medium
InventoryComponentSet(	titan,	204,	2	);	# Large Human Reactor 1 -- large
InventoryComponentSet(	titan,	205,	1	);	# Large Human Reactor 2-- Maxim
					
#Shields					
InventoryComponentSet(	titan,	300,	2	);	# Human Standard Shield
InventoryComponentSet(	titan,	301,	2	);	# Human Protector Shield
InventoryComponentSet(	titan,	302,	2	);	# Human Guardian Shield
InventoryComponentSet(	titan,	303,	2	);	# Human FastCharge Shield
InventoryComponentSet(	titan,	304,	2	);	# Human Centurian Shield
InventoryComponentSet(	titan,	305,	2	);	# Human Repulsor Shield
InventoryComponentSet(	titan,	306,	2	);	# Human Titan Shield
InventoryComponentSet(	titan,	307,	1	);	# Human Medusa Shield
					
#Sensors					
InventoryComponentSet(	titan,	400,	2	);	# Basic Human Sensor
InventoryComponentSet(	titan,	401,	2	);	# Long Range Sensor -- Ranger
InventoryComponentSet(	titan,	408,	2	);	#Standard Human Sensor
InventoryComponentSet(	titan,	409,	2	);	#Human Longbow Sensor
InventoryComponentSet(	titan,	410,	2	);	#Human Infiltrator Sensor
InventoryComponentSet(	titan,	411,	2	);	#Human Crossbow Sensor
InventoryComponentSet(	titan,	412,	2	);	#Human Ultralight Sensor
InventoryComponentSet(	titan,	413,	2	);	#Human Hound Dog Sensor
InventoryComponentSet(	titan,	414,	2	);	#Thermal Sensor
					
#Engines					
InventoryComponentSet(	titan,	100,	2	);	# Human Light Vehicle Engine
InventoryComponentSet(	titan,	101,	2	);	# Human High Output Light Engine
InventoryComponentSet(	titan,	102,	2	);	# Human Agile Light Engine
InventoryComponentSet(	titan,	103,	2	);	# Human Standard Medium Engine
InventoryComponentSet(	titan,	104,	2	);	# Human High Output Medium Engine
InventoryComponentSet(	titan,	105,	1	);	# Human Medium Agility Engine
InventoryComponentSet(	titan,	106,	2	);	# Human Standard Heavy Engine
InventoryComponentSet(	titan,	107,	2	);	# Human Improved Heavy Engine
InventoryComponentSet(	titan,	108,	2	);	# Human Heavy Cruise Engine
InventoryComponentSet(	titan,	109,	2	);	# Human High Output Heavy Engine
InventoryComponentSet(	titan,	110,	1	);	# Human Agile Heavy Engine
InventoryComponentSet(	titan,	111,	2	);	# Human Standard Assault Engine
InventoryComponentSet(	titan,	112,	2	);	# Human Improved Assault Engine
InventoryComponentSet(	titan,	113,	2	);	# Human heavy turbine engine
InventoryComponentSet(	titan,	114,	1	);	# High Output Turbine (HOT)
InventoryComponentSet(	titan,	115,	1	);	# Human super heavy engine
					
#Internal Components					
InventoryComponentSet(	titan,	800,	4	);	#Human Basic Computer
InventoryComponentSet(	titan,	801,	2	);	# Human Improved Computer
InventoryComponentSet(	titan,	802,	2	);	# Human Advanced Computer
InventoryComponentSet(	titan,	805,	0	);	# Cybrid Basic Systems Control
InventoryComponentSet(	titan,	806,	0	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	titan,	807,	0	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	titan,	810,	2	);	# Guardian ECM
InventoryComponentSet(	titan,	811,	2	);	# Doppleganger ECM
InventoryComponentSet(	titan,	812,	0	);	# Cybrid Alpha ECM
InventoryComponentSet(	titan,	813,	0	);	#Cybrid Beta ECM
InventoryComponentSet(	titan,	820,	2	);	# Thermal Diffuser
#InventoryComponentSet(	titan,	825,	0	);	# Flares
InventoryComponentSet(	titan,	830,	2	);	# Chameleon
InventoryComponentSet(	titan,	831,	2	);	# Cuttlefish cloak
InventoryComponentSet(	titan,	840,	2	);	# Shield Modulator
InventoryComponentSet(	titan,	845,	2	);	# Shield Capacitor
InventoryComponentSet(	titan,	850,	2	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	titan,	860,	0	);	# Laser Targeting Module
InventoryComponentSet(	titan,	865,	2	);	# Extra Battery
InventoryComponentSet(	titan,	870,	2	);	# Reactor Capacitor
InventoryComponentSet(	titan,	875,	1	);	# Field Stabilizer
InventoryComponentSet(	titan,	880,	2	);	# Rocket Booster
InventoryComponentSet(	titan,	885,	2	);	# Turbine Boost
InventoryComponentSet(	titan,	890,	1	);	#NanoRepair
InventoryComponentSet(	titan,	900,	2	);	#Angle Life Support
InventoryComponentSet(	titan,	910,	0	);	#Agrav Generator
InventoryComponentSet(	titan,	914,	2	);	#UAP
					
#Armor					
InventoryComponentSet(	titan,	926,	2	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	titan,	927,	2	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	titan,	928,	2	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	titan,	929,	2	);	#Ceramic
InventoryComponentSet(	titan,	930,	2	);	#Crystaluminum
InventoryComponentSet(	titan,	931,	1	);	#Quicksilver

#Pilots					
InventoryPilotSet(	titan,	1,	TRUE	);	# Collossa (Jaguar), Imperial
InventoryPilotSet(	titan,	2,	TRUE	);	# Hunter Otobe, Rebel
InventoryPilotSet(	titan,	3,	TRUE	);	# Bioderm Delta-Six Niner, Rebel
InventoryPilotSet(	titan,	4,	TRUE	);	
InventoryPilotSet(	titan,	5,	TRUE	);	# Deathwish, Imperial
InventoryPilotSet(	titan,	6,	TRUE	);	# Hangman, Imperial
InventoryPilotSet(	titan,	7,	TRUE	);	
InventoryPilotSet(	titan,	8,	TRUE	);	#Tigress, Imperial
InventoryPilotSet(	titan,	9,	TRUE	);	#Oliphant, Imperial
InventoryPilotSet(	titan,	10,	TRUE	);	#Riana, Rebel
InventoryPilotSet(	titan,	11,	TRUE	);	#Saxon, Rebel
InventoryPilotSet(	titan,	12,	TRUE	);	#Verity, Rebel
InventoryPilotSet(	titan,	13,	TRUE	);	#Generic
InventoryPilotSet(	titan,	14,	TRUE	);	#Generic
InventoryPilotSet(	titan,	15,	FALSE	);	#Generic
					
#Pluto					
					
#Hercs					
					
#weapons					
InventoryWeaponSet(	pluto,	101,	6	);	#Laser
InventoryWeaponSet(	pluto,	102,	6	);	#Heavy Laser
InventoryWeaponSet(	pluto,	103,	6	);	#Comp Laser
InventoryWeaponSet(	pluto,	104,	0	);	#Twin Laser
InventoryWeaponSet(	pluto,	105,	4	);	#Emp
InventoryWeaponSet(	pluto,	106,	4	);	#ELF
InventoryWeaponSet(	pluto,	107,	6	);	#Blaster
InventoryWeaponSet(	pluto,	108,	6	);	#Heavy Blaster
InventoryWeaponSet(	pluto,	109,	0	);	#PBW
InventoryWeaponSet(	pluto,	110,	2	);	#Plasma
InventoryWeaponSet(	pluto,	111,	0	);	#Blink Gun 
InventoryWeaponSet(	pluto,	112,	2	);	#Qgun
InventoryWeaponSet(	pluto,	113,	2	);	#MFAC
InventoryWeaponSet(	pluto,	114,	0	);	#Nano Infuser
InventoryWeaponSet(	pluto,	115,	4	);	#Nanite Cannon
InventoryWeaponSet(	pluto,	116,	8	);	#Autocannon
InventoryWeaponSet(	pluto,	117,	8	);	#Hvy Autocannon
InventoryWeaponSet(	pluto,	118,	0	);	#EMC Autocannon
InventoryWeaponSet(	pluto,	119,	4	);	#Blast Cannon
InventoryWeaponSet(	pluto,	120,	4	);	#Hvy Blast Can
InventoryWeaponSet(	pluto,	121,	0	);	#Rail Gun
InventoryWeaponSet(	pluto,	10,	0	);	#Laser G. Bomb
InventoryWeaponSet(	pluto,	11,	0	);	#Hades Bomb
InventoryWeaponSet(	pluto,	124,	4	);	#Pit Viper 8
InventoryWeaponSet(	pluto,	125,	4	);	#Pit Viper 12
InventoryWeaponSet(	pluto,	126,	4	);	#Sparrow 6
InventoryWeaponSet(	pluto,	127,	4	);	#Sparrow 10
InventoryWeaponSet(	pluto,	128,	4	);	#SWARM 6
InventoryWeaponSet(	pluto,	129,	4	);	#Minion
InventoryWeaponSet(	pluto,	130,	0	);	#Shrike 8
InventoryWeaponSet(	pluto,	147,	4	);	#Aphid
InventoryWeaponSet(	pluto,	131,	0	);	#Arachnitron 4
InventoryWeaponSet(	pluto,	132,	0	);	#Arachnitron 8 
InventoryWeaponSet(	pluto,	133,	0	);	#Arachnitron 12 
InventoryWeaponSet(	pluto,	134,	4	);	#Proximity 6 
InventoryWeaponSet(	pluto,	135,	4	);	#Proximity 10 
InventoryWeaponSet(	pluto,	136,	4	);	#Proximity 15
InventoryWeaponSet(	pluto,	1,	0	);	#Nike
InventoryWeaponSet(	pluto,	2,	0	);	#AML
InventoryWeaponSet(	pluto,	142,	0	);	#Radiation Gun
InventoryWeaponSet(	pluto,	3,	1	);	#Disrupter
InventoryWeaponSet(	pluto,	4,	1	);	#Electrohull
InventoryWeaponSet(	pluto,	5,	0	);	#Seismic Prob
InventoryWeaponSet(	pluto,	146,	0	);	#FOG
InventoryWeaponSet(	pluto,	20,	0	);	#Cyb Artillery
InventoryWeaponSet(	pluto,	150,	4	);	#SMART Gun

#Reactors					
InventoryComponentSet(	pluto,	200,	2	);	# Human Micro Reactor
InventoryComponentSet(	pluto,	201,	2	);	# Small Human Reactor 2 -- small
InventoryComponentSet(	pluto,	202,	2	);	# Medium Human Reactor 1 Standard
InventoryComponentSet(	pluto,	203,	2	);	# Medium Human Reactor 2 medium
InventoryComponentSet(	pluto,	204,	2	);	# Large Human Reactor 1 -- large
InventoryComponentSet(	pluto,	205,	2	);	# Large Human Reactor 2-- Maxim
#InventoryComponentSet(	pluto,	224,	0	);	# iCutChOO Reactor
					
#Shields					
InventoryComponentSet(	pluto,	300,	2	);	# Human Standard Shield
InventoryComponentSet(	pluto,	301,	2	);	# Human Protector Shield
InventoryComponentSet(	pluto,	302,	2	);	# Human Guardian Shield
InventoryComponentSet(	pluto,	303,	2	);	# Human FastCharge Shield
InventoryComponentSet(	pluto,	304,	2	);	# Human Centurian Shield
InventoryComponentSet(	pluto,	305,	2	);	# Human Repulsor Shield
InventoryComponentSet(	pluto,	306,	2	);	# Human Titan Shield
InventoryComponentSet(	pluto,	307,	2	);	# Human Medusa Shield
					
#Sensors					
InventoryComponentSet(	pluto,	400,	2	);	# Basic Human Sensor
InventoryComponentSet(	pluto,	401,	2	);	# Long Range Sensor -- Ranger
InventoryComponentSet(	pluto,	408,	2	);	#Standard Human Sensor
InventoryComponentSet(	pluto,	409,	2	);	#Human Longbow Sensor
InventoryComponentSet(	pluto,	410,	2	);	#Human Infiltrator Sensor
InventoryComponentSet(	pluto,	411,	2	);	#Human Crossbow Sensor
InventoryComponentSet(	pluto,	412,	2	);	#Human Ultralight Sensor
InventoryComponentSet(	pluto,	413,	2	);	#Human Hound Dog Sensor
InventoryComponentSet(	pluto,	414,	2	);	#Thermal Sensor
					
#Engines					
InventoryComponentSet(	pluto,	100,	2	);	# Human Light Vehicle Engine
InventoryComponentSet(	pluto,	101,	2	);	# Human High Output Light Engine
InventoryComponentSet(	pluto,	102,	2	);	# Human Agile Light Engine
InventoryComponentSet(	pluto,	103,	2	);	# Human Standard Medium Engine
InventoryComponentSet(	pluto,	104,	2	);	# Human High Output Medium Engine
InventoryComponentSet(	pluto,	105,	2	);	# Human Medium Agility Engine
InventoryComponentSet(	pluto,	106,	2	);	# Human Standard Heavy Engine
InventoryComponentSet(	pluto,	107,	2	);	# Human Improved Heavy Engine
InventoryComponentSet(	pluto,	108,	2	);	# Human Heavy Cruise Engine
InventoryComponentSet(	pluto,	109,	2	);	# Human High Output Heavy Engine
InventoryComponentSet(	pluto,	110,	2	);	# Human Agile Heavy Engine
InventoryComponentSet(	pluto,	111,	2	);	# Human Standard Assault Engine
InventoryComponentSet(	pluto,	112,	2	);	# Human Improved Assault Engine
InventoryComponentSet(	pluto,	113,	2	);	# Human heavy turbine engine
InventoryComponentSet(	pluto,	114,	2	);	# High Output Turbine (HOT)
InventoryComponentSet(	pluto,	115,	2	);	# Human super heavy engine
					
#Internal Components					
InventoryComponentSet(	pluto,	800,	4	);	#Human Basic Computer
InventoryComponentSet(	pluto,	801,	4	);	# Human Improved Computer
InventoryComponentSet(	pluto,	802,	4	);	# Human Advanced Computer
InventoryComponentSet(	pluto,	805,	0	);	# Cybrid Basic Systems Control
InventoryComponentSet(	pluto,	806,	0	);	# Cybrid Enhanced Systems Control
InventoryComponentSet(	pluto,	807,	0	);	# Cybrid Advanced Systems Control
InventoryComponentSet(	pluto,	810,	4	);	# Guardian ECM
InventoryComponentSet(	pluto,	811,	4	);	# Doppleganger ECM
InventoryComponentSet(	pluto,	812,	0	);	# Cybrid Alpha ECM
InventoryComponentSet(	pluto,	813,	0	);	#Cybrid Beta ECM
InventoryComponentSet(	pluto,	820,	4	);	# Thermal Diffuser
#InventoryComponentSet(	pluto,	825,	0	);	# Flares
InventoryComponentSet(	pluto,	830,	4	);	# Chameleon
InventoryComponentSet(	pluto,	831,	4	);	# Cuttlefish cloak
InventoryComponentSet(	pluto,	840,	4	);	# Shield Modulator
InventoryComponentSet(	pluto,	845,	4	);	# Shield Capacitor
InventoryComponentSet(	pluto,	850,	4	);	#Shield Amplifier (increases shield constant)
InventoryComponentSet(	pluto,	860,	0	);	# Laser Targeting Module
InventoryComponentSet(	pluto,	865,	4	);	# Extra Battery
InventoryComponentSet(	pluto,	870,	4	);	# Reactor Capacitor
InventoryComponentSet(	pluto,	875,	4	);	# Field Stabilizer
InventoryComponentSet(	pluto,	880,	4	);	# Rocket Booster
InventoryComponentSet(	pluto,	885,	4	);	# Turbine Boost
InventoryComponentSet(	pluto,	890,	4	);	#NanoRepair
InventoryComponentSet(	pluto,	900,	4	);	#Angle Life Support
InventoryComponentSet(	pluto,	910,	1	);	#Agrav Generator
InventoryComponentSet(	pluto,	914,	2	);	#UAP
					
#Armor					
InventoryComponentSet(	pluto,	926,	2	);	#Carbon Fiber (CARLAM)
InventoryComponentSet(	pluto,	927,	2	);	#Quad Bonded Metaplas (QBM)
InventoryComponentSet(	pluto,	928,	2	);	#DURAC (Depleteted Uranium)
InventoryComponentSet(	pluto,	929,	2	);	#Ceramic
InventoryComponentSet(	pluto,	930,	2	);	#Crystaluminum
InventoryComponentSet(	pluto,	931,	2	);	#Quicksilver

#Pilots					
InventoryPilotSet(	pluto,	1,	FALSE	);	# Collossa (Jaguar), Imperial
InventoryPilotSet(	pluto,	2,	FALSE	);	# Hunter Otobe, Rebel
InventoryPilotSet(	pluto,	3,	FALSE	);	# Bioderm Delta-Six Niner, Rebel
InventoryPilotSet(	pluto,	4,	FALSE	);	
InventoryPilotSet(	pluto,	5,	FALSE	);	# Deathwish, Imperial
InventoryPilotSet(	pluto,	6,	FALSE	);	# Hangman, Imperial
InventoryPilotSet(	pluto,	7,	FALSE	);	
InventoryPilotSet(	pluto,	8,	FALSE	);	#Tigress, Imperial
InventoryPilotSet(	pluto,	9,	FALSE	);	#Oliphant, Imperial
InventoryPilotSet(	pluto,	10,	FALSE	);	#Riana, Rebel
InventoryPilotSet(	pluto,	11,	FALSE	);	#Saxon, Rebel
InventoryPilotSet(	pluto,	12,	FALSE	);	#Verity, Rebel
InventoryPilotSet(	pluto,	13,	FALSE	);	#Generic
InventoryPilotSet(	pluto,	14,	FALSE	);	#Generic
InventoryPilotSet(	pluto,	15,	FALSE	);	#Generic
					
					
#Start out with an emancipator in the player's stash					
InventoryVehicleAdjust(	-1,	52,	1	);	#Pirate Emancipator (outrider)
InventoryweaponAdjust(	-1,	107,	2	);	
InventoryComponentAdjust(	-1,	104,	1	);	
InventoryComponentAdjust(	-1,	204,	1	);	
InventoryComponentAdjust(	-1,	801,	1	);			
InventoryComponentAdjust(	-1,	301,	1	);			
InventoryComponentAdjust(	-1,	927,	1	);			
InventoryComponentAdjust(	-1,	400,	1	);			
InventoryComponentAdjust(	-1,	810,	1	);			
InventoryComponentAdjust(	-1,	860,	1	);			

#Venus Vehicle adjustments							
InventoryVehicleAdjust(	venus,	4,	1	);	#Terran Talon		
InventoryweaponAdjust(	venus,	101,	2	);			
InventoryComponentAdjust(	venus,	101,	1	);			
InventoryComponentAdjust(	venus,	202,	1	);			
InventoryComponentAdjust(	venus,	801,	1	);			
InventoryComponentAdjust(	venus,	300,	1	);			
InventoryComponentAdjust(	venus,	926,	1	);			
InventoryComponentAdjust(	venus,	410,	1	);			
InventoryComponentAdjust(	venus,	810,	1	);	
InventoryComponentAdjust(	venus,	850,	1	);	
					
InventoryVehicleAdjust(	venus,	2,	1	);	#Terran Minotaur
InventoryweaponAdjust(	venus,	101,	2	);	
InventoryweaponAdjust(	venus,	102,	2	);	
InventoryComponentAdjust(	venus,	104,	1	);	
InventoryComponentAdjust(	venus,	203,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	302,	1	);	
InventoryComponentAdjust(	venus,	927,	1	);	
InventoryComponentAdjust(	venus,	400,	1	);	
InventoryComponentAdjust(	venus,	865,	1	);	
InventoryComponentAdjust(	venus,	870,	1	);	
					
InventoryVehicleAdjust(	venus,	11,	1	);	#Knight's Minotaur
InventoryweaponAdjust(	venus,	103,	4	);	
					
InventoryComponentAdjust(	venus,	105,	1	);	
InventoryComponentAdjust(	venus,	204,	1	);	
InventoryComponentAdjust(	venus,	802,	1	);	
InventoryComponentAdjust(	venus,	306,	1	);	
InventoryComponentAdjust(	venus,	927,	1	);	
InventoryComponentAdjust(	venus,	412,	1	);	
InventoryComponentAdjust(	venus,	810,	1	);	
InventoryComponentAdjust(	venus,	840,	1	);	
					
InventoryVehicleAdjust(	venus,	5,	1	);	#Terran Basilisk
InventoryweaponAdjust(	venus,	105,	2	);	
InventoryweaponAdjust(	venus,	125,	2	);	
InventoryComponentAdjust(	venus,	108,	1	);	
InventoryComponentAdjust(	venus,	201,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	303,	1	);	
InventoryComponentAdjust(	venus,	929,	1	);	
InventoryComponentAdjust(	venus,	408,	1	);	
InventoryComponentAdjust(	venus,	810,	1	);	
InventoryComponentAdjust(	venus,	840,	1	);	
					
InventoryVehicleAdjust(	venus,	1,	1	);	#Terran Apocalypse
InventoryweaponAdjust(	venus,	117,	4	);	
InventoryweaponAdjust(	venus,	105,	2	);	
					
InventoryComponentAdjust(	venus,	108,	1	);	
InventoryComponentAdjust(	venus,	202,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	304,	1	);	
InventoryComponentAdjust(	venus,	928,	1	);	
InventoryComponentAdjust(	venus,	400,	1	);	
InventoryComponentAdjust(	venus,	820,	1	);	
InventoryComponentAdjust(	venus,	850,	1	);	
					
InventoryVehicleAdjust(	venus,	30,	1	);	#Emancipator
InventoryweaponAdjust(	venus,	107,	2	);	
InventoryComponentAdjust(	venus,	105,	1	);	
InventoryComponentAdjust(	venus,	204,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	306,	1	);	
InventoryComponentAdjust(	venus,	927,	1	);	
InventoryComponentAdjust(	venus,	412,	1	);	
InventoryComponentAdjust(	venus,	840,	1	);	
InventoryComponentAdjust(	venus,	830,	1	);	

InventoryVehicleAdjust(	venus,	31,	1	);	#Avenger
InventoryweaponAdjust(	venus,	106,	2	);	
InventoryComponentAdjust(	venus,	101,	1	);	
InventoryComponentAdjust(	venus,	202,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	927,	1	);	
InventoryComponentAdjust(	venus,	400,	1	);	
InventoryComponentAdjust(	venus,	865,	1	);	
InventoryComponentAdjust(	venus,	811,	1	);	
InventoryComponentAdjust(	venus,	865,	2	);	

InventoryVehicleAdjust(	venus,	32,	1	);	#Dreadlock
InventoryweaponAdjust(	venus,	108,	2	);	
InventoryComponentAdjust(	venus,	108,	1	);	
InventoryComponentAdjust(	venus,	204,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	927,	1	);	
InventoryComponentAdjust(	venus,	412,	1	);	
InventoryComponentAdjust(	venus,	865,	1	);	
InventoryComponentAdjust(	venus,	830,	1	);	
InventoryComponentAdjust(	venus,	885,	1	);	

InventoryVehicleAdjust(	venus,	8,	1	);	#Disrupter
InventoryweaponAdjust(	venus,	3,	1	);	
InventoryComponentAdjust(	venus,	109,	1	);	
InventoryComponentAdjust(	venus,	204,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	928,	1	);	
InventoryComponentAdjust(	venus,	400,	1	);	
InventoryComponentAdjust(	venus,	810,	1	);	
InventoryComponentAdjust(	venus,	912,	1	);	
InventoryComponentAdjust(	venus,	885,	1	);	

InventoryVehicleAdjust(	venus,	7,	1	);	#Myrmidon
InventoryweaponAdjust(	venus,	120,	2	);	
InventoryComponentAdjust(	venus,	113,	1	);	
InventoryComponentAdjust(	venus,	200,	1	);	
InventoryComponentAdjust(	venus,	801,	1	);	
InventoryComponentAdjust(	venus,	927,	1	);	
InventoryComponentAdjust(	venus,	412,	1	);	
InventoryComponentAdjust(	venus,	914,	1	);	
InventoryComponentAdjust(	venus,	820,	1	);	
InventoryComponentAdjust(	venus,	811,	1	);	

InventoryVehicleAdjust(	venus,	6,	1	);	#Paladin
InventoryweaponAdjust(	venus,	129,	2	);	
InventoryComponentAdjust(	venus,	109,	1	);	
InventoryComponentAdjust(	venus,	202,	1	);	
InventoryComponentAdjust(	venus,	802,	1	);	
InventoryComponentAdjust(	venus,	928,	1	);	
InventoryComponentAdjust(	venus,	410,	1	);	
InventoryComponentAdjust(	venus,	810,	1	);	
InventoryComponentAdjust(	venus,	820,	1	);	
InventoryComponentAdjust(	venus,	860,	1	);	
					
#Titan Adjustments					

InventoryVehicleAdjust(	titan,	11,	1	);	#Knight's Minotaur
InventoryweaponAdjust(	titan,	103,	4	);	
					
InventoryComponentAdjust(	titan,	105,	1	);	
InventoryComponentAdjust(	titan,	204,	1	);	
InventoryComponentAdjust(	titan,	802,	1	);	
InventoryComponentAdjust(	titan,	306,	1	);	
InventoryComponentAdjust(	titan,	927,	1	);	
InventoryComponentAdjust(	titan,	412,	1	);	
InventoryComponentAdjust(	titan,	810,	1	);	
InventoryComponentAdjust(	titan,	840,	1	);	

InventoryVehicleAdjust(	titan,	14,	1	);	#Knight's Basilisk
InventoryweaponAdjust(	titan,	124,	2	);	
InventoryweaponAdjust(	titan,	127,	2	);	
InventoryComponentAdjust(	titan,	109,	1	);	
InventoryComponentAdjust(	titan,	202,	1	);	
InventoryComponentAdjust(	titan,	801,	1	);	
InventoryComponentAdjust(	titan,	303,	1	);	
InventoryComponentAdjust(	titan,	930,	1	);	
InventoryComponentAdjust(	titan,	408,	1	);	
InventoryComponentAdjust(	titan,	810,	1	);	
InventoryComponentAdjust(	titan,	840,	1	);	
					
InventoryVehicleAdjust(	titan,	10,	1	);	#Knight's Apocalypse
InventoryweaponAdjust(	titan,	102,	2	);	
InventoryweaponAdjust(	titan,	117,	2	);	
InventoryweaponAdjust(	titan,	126,	2	);	
InventoryComponentAdjust(	titan,	109,	1	);	
InventoryComponentAdjust(	titan,	202,	1	);	
InventoryComponentAdjust(	titan,	801,	1	);	
InventoryComponentAdjust(	titan,	305,	1	);	
InventoryComponentAdjust(	titan,	928,	1	);	
InventoryComponentAdjust(	titan,	413,	1	);	
InventoryComponentAdjust(	titan,	820,	1	);	
InventoryComponentAdjust(	titan,	850,	1	);	
					
InventoryVehicleAdjust(	titan,	30,	1	);	#Emancipator
InventoryweaponAdjust(	titan,	107,	2	);	
InventoryComponentAdjust(	titan,	105,	1	);	
InventoryComponentAdjust(	titan,	204,	1	);	
InventoryComponentAdjust(	titan,	801,	1	);	
InventoryComponentAdjust(	titan,	306,	1	);	
InventoryComponentAdjust(	titan,	927,	1	);	
InventoryComponentAdjust(	titan,	412,	1	);	
InventoryComponentAdjust(	titan,	840,	1	);	
InventoryComponentAdjust(	titan,	830,	1	);	
					
InventoryVehicleAdjust(	titan,	33,	1	);	#Olympian
InventoryweaponAdjust(	titan,	107,	2	);	
InventoryweaponAdjust(	titan,	115,	2	);	
InventoryweaponAdjust(	titan,	105,	2	);	
InventoryComponentAdjust(	titan,	114,	1	);	
InventoryComponentAdjust(	titan,	205,	1	);	
InventoryComponentAdjust(	titan,	801,	1	);	
InventoryComponentAdjust(	titan,	305,	1	);	
InventoryComponentAdjust(	titan,	928,	1	);	
InventoryComponentAdjust(	titan,	411,	1	);	
InventoryComponentAdjust(	titan,	810,	1	);	
InventoryComponentAdjust(	titan,	865,	1	);	
					
InventoryVehicleAdjust(	titan,	17,	1	);	#Knight Disrupter
InventoryweaponAdjust(	titan,	3,	1	);	
InventoryComponentAdjust(	titan,	110,	1	);	
InventoryComponentAdjust(	titan,	204,	1	);	
InventoryComponentAdjust(	titan,	801,	1	);	
InventoryComponentAdjust(	titan,	928,	1	);	
InventoryComponentAdjust(	titan,	400,	1	);	
InventoryComponentAdjust(	titan,	810,	1	);	
InventoryComponentAdjust(	titan,	912,	1	);	
InventoryComponentAdjust(	titan,	885,	1	);	
					
InventoryVehicleAdjust(	titan,	16,	1	);	#Knight Myrmidon
InventoryweaponAdjust(	titan,	110,	2	);	
InventoryComponentAdjust(	titan,	114,	1	);	
InventoryComponentAdjust(	titan,	205,	1	);	
InventoryComponentAdjust(	titan,	801,	1	);	
InventoryComponentAdjust(	titan,	927,	1	);	
InventoryComponentAdjust(	titan,	408,	1	);	
InventoryComponentAdjust(	titan,	900,	1	);	
InventoryComponentAdjust(	titan,	820,	1	);	
InventoryComponentAdjust(	titan,	811,	1	);	
					
#Pluto Vehicle Adjustments					

InventoryVehicleAdjust(	pluto,	13,	1	);	#Knight's Talon
InventoryweaponAdjust(	pluto,	103,	2	);	
InventoryComponentAdjust(	pluto,	102,	1	);	
InventoryComponentAdjust(	pluto,	203,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	304,	1	);	
InventoryComponentAdjust(	pluto,	926,	1	);	
InventoryComponentAdjust(	pluto,	410,	1	);	
InventoryComponentAdjust(	pluto,	865,	1	);	
InventoryComponentAdjust(	pluto,	850,	1	);	
					
InventoryVehicleAdjust(	pluto,	11,	1	);	#Knight's Minotaur
InventoryweaponAdjust(	pluto,	103,	4	);	
					
InventoryComponentAdjust(	pluto,	105,	1	);	
InventoryComponentAdjust(	pluto,	204,	1	);	
InventoryComponentAdjust(	pluto,	802,	1	);	
InventoryComponentAdjust(	pluto,	306,	1	);	
InventoryComponentAdjust(	pluto,	927,	1	);	
InventoryComponentAdjust(	pluto,	412,	1	);	
InventoryComponentAdjust(	pluto,	810,	1	);	
InventoryComponentAdjust(	pluto,	840,	1	);	
					
InventoryVehicleAdjust(	pluto,	14,	1	);	#Knight's Basilisk
InventoryweaponAdjust(	pluto,	124,	2	);	
InventoryweaponAdjust(	pluto,	127,	2	);	
InventoryComponentAdjust(	pluto,	109,	1	);	
InventoryComponentAdjust(	pluto,	202,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	303,	1	);	
InventoryComponentAdjust(	pluto,	930,	1	);	
InventoryComponentAdjust(	pluto,	408,	1	);	
InventoryComponentAdjust(	pluto,	810,	1	);	
InventoryComponentAdjust(	pluto,	840,	1	);	
					
InventoryVehicleAdjust(	pluto,	1,	1	);	#Terran Apocalypse
InventoryweaponAdjust(	pluto,	117,	4	);	
InventoryweaponAdjust(	pluto,	105,	2	);	
					
InventoryComponentAdjust(	pluto,	108,	1	);	
InventoryComponentAdjust(	pluto,	202,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	304,	1	);	
InventoryComponentAdjust(	pluto,	928,	1	);	
InventoryComponentAdjust(	pluto,	400,	1	);	
InventoryComponentAdjust(	pluto,	820,	1	);	
InventoryComponentAdjust(	pluto,	850,	1	);	
					
InventoryVehicleAdjust(	pluto,	12,	1	);	#Knight's Gorgon
InventoryweaponAdjust(	pluto,	102,	2	);	
InventoryweaponAdjust(	pluto,	129,	2	);	
InventoryComponentAdjust(	pluto,	114,	1	);	
InventoryComponentAdjust(	pluto,	204,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	307,	1	);	
InventoryComponentAdjust(	pluto,	927,	1	);	
InventoryComponentAdjust(	pluto,	400,	1	);	
InventoryComponentAdjust(	pluto,	820,	1	);	
InventoryComponentAdjust(	pluto,	850,	1	);	
					
InventoryVehicleAdjust(	pluto,	33,	1	);	#Olympian
InventoryweaponAdjust(	pluto,	107,	2	);	
InventoryweaponAdjust(	pluto,	115,	2	);	
InventoryweaponAdjust(	pluto,	105,	2	);	
InventoryComponentAdjust(	pluto,	114,	1	);	
InventoryComponentAdjust(	pluto,	205,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	305,	1	);	
InventoryComponentAdjust(	pluto,	928,	1	);	
InventoryComponentAdjust(	pluto,	411,	1	);	
InventoryComponentAdjust(	pluto,	810,	1	);	
InventoryComponentAdjust(	pluto,	865,	1	);	
					
InventoryVehicleAdjust(	pluto,	6,	1	);	#Paladin
InventoryweaponAdjust(	pluto,	129,	2	);	
InventoryComponentAdjust(	pluto,	109,	1	);	
InventoryComponentAdjust(	pluto,	202,	1	);	
InventoryComponentAdjust(	pluto,	802,	1	);	
InventoryComponentAdjust(	pluto,	928,	1	);	
InventoryComponentAdjust(	pluto,	410,	1	);	
InventoryComponentAdjust(	pluto,	810,	1	);	
InventoryComponentAdjust(	pluto,	820,	1	);	
InventoryComponentAdjust(	pluto,	860,	1	);	

InventoryVehicleAdjust(	pluto,	16,	1	);	#Knight Myrmidon
InventoryweaponAdjust(	pluto,	110,	2	);	
InventoryComponentAdjust(	pluto,	114,	1	);	
InventoryComponentAdjust(	pluto,	205,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	927,	1	);	
InventoryComponentAdjust(	pluto,	408,	1	);	
InventoryComponentAdjust(	pluto,	900,	1	);	
InventoryComponentAdjust(	pluto,	820,	1	);	
InventoryComponentAdjust(	pluto,	811,	1	);	
					
InventoryVehicleAdjust(	pluto,	10,	1	);	#Knight's Apocalypse
InventoryweaponAdjust(	pluto,	102,	2	);	
InventoryweaponAdjust(	pluto,	117,	2	);	
InventoryweaponAdjust(	pluto,	126,	2	);	
InventoryComponentAdjust(	pluto,	109,	1	);	
InventoryComponentAdjust(	pluto,	202,	1	);	
InventoryComponentAdjust(	pluto,	801,	1	);	
InventoryComponentAdjust(	pluto,	305,	1	);	
InventoryComponentAdjust(	pluto,	928,	1	);	
InventoryComponentAdjust(	pluto,	413,	1	);	
InventoryComponentAdjust(	pluto,	820,	1	);	
InventoryComponentAdjust(	pluto,	850,	1	);	

InventoryVehicleAdjust(	pluto,	15,	1	);	#Knight Paladin
InventoryweaponAdjust(	pluto,	119,	2	);	
InventoryComponentAdjust(	pluto,	110,	1	);	
InventoryComponentAdjust(	pluto,	201,	1	);	
InventoryComponentAdjust(	pluto,	802,	1	);	
InventoryComponentAdjust(	pluto,	928,	1	);	
InventoryComponentAdjust(	pluto,	411,	1	);	
InventoryComponentAdjust(	pluto,	820,	1	);	
InventoryComponentAdjust(	pluto,	811,	1	);	
InventoryComponentAdjust(	pluto,	885,	1	);	

