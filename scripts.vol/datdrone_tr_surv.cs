######################################################################
# datTank_tr_SURV.cs
# Terran SURVdin
#
######################################################################

droneBase( IDVEH_TR_SURV, "TRSURV",    "tr_surv.dts", 5.00, 30.00 ,  0.85, 2 ,          1500);

genericDrone(0);

newComponent(        TopPodA,            RightTread,           Body,                           250 ,IDCOM_RIGHT_TREAD           );                  # 0.25

droneExplosion(true, 15.0);
;