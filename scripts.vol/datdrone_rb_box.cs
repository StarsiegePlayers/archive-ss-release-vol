######################################################################
# datDrone_rb_fltb.cs
# Rebel Empty Flatbed
#
######################################################################

#           Identity_Tag  Abbreviation  Shape           Mass  MaxMass  RCS     Tech_Level   Combat_Value
droneBase( IDVEH_RB_FLTB_BOX, "RBFLTB",     "rb_fltb_box.dts",  5.00, 30.00 ,  0.85 ,  2,           1500);

genericDrone(1);

droneExplosion(true, 25.0);
CL