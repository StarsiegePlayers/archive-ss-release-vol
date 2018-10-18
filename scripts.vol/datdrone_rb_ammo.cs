######################################################################
# datDrone_rb_ammo.cs
# Rebel ammo flatbed
#
######################################################################

#          Identity_Tag         Abbreviation Shape               Mass  MaxMass  RCS   Tech_Level   Combat_Value
droneBase( IDVEH_RB_FLTB_AMMO, "RBAMMO",    "rb_fltb_ammo.dts", 5.00, 30.00 ,  0.85, 2 ,          1500);

genericDrone(1);

droneExplosion(true, 25.0);;