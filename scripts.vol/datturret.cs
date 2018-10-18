//#####################################################################
//
// Turret definition instantiations
//
//#####################################################################


function humanLaser()
{
   turretAI( "turretFire.ai" );

   // # Hard Points (sizes:SMLX sides:TBLR)
   // #                         Dmg    Offset_fm_Node     X_rot_rnge  Z_rot_rnge  
   // #            id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
   newHardPointExt( 0, X, T, head0, -4.51, 3.324, 3.89, -15.0, 40.0, -30.0, 20.0 );
   newHardPointExt( 1, X, T, head0, 4.51, 3.324, 3.89, -15.0, 40.0,  -30.0, 20.0 );
}


function humanMissile()
{
   turretAI( "turretFire.ai" );

   // # Hard Points (sizes:SMLX sides:TBLR)
   // #                            Dmg    Offset_fm_Node     X_rot_rnge  Z_rot_rnge  
   // #               id size side Prnt   X____  Y___ Z___   min__ max_  min__ max__ 
   newHardPointExt( 0, L, I, head0, 9.11, -5.45, 6.28, 0.0, 0.0,  -30.0, 20.0 );
   newHardPointExt( 1, L, I, head0, -8.99, -5.45, 5.82, 0.0, 0.0, -30.0, 20.0 );

   newHardPointExt( 2, L, I, head0, 9.43, -5.45, 4.57, 0.0, 0.0,  -30.0, 20.0 );
   newHardPointExt( 3, L, I, head0, -9.11, -5.45, 4.52, 0.0, 0.0, -30.0, 20.0 );

   newHardPointExt( 4, L, I, head0, 8.08, -5.45, 5.06, 0.0, 0.0,  -30.0, 20.0 );
   newHardPointExt( 5, L, I, head0, -7.92, -5.45, 4.95, 0.0, 0.0, -30.0, 20.0 );

   newHardPointExt( 6, L, I, head0, 8.21, -5.45, 3.60, 0.0, 0.0,  -30.0, 20.0 );
   newHardPointExt( 7, L, I, head0, -8.02, -5.45, 3.55, 0.0, 0.0, -30.0, 20.0 );
}




//          Identity_Tag   |Shape          |Hulk             |RadarXsection  |turretVel  |teamId
//                                                                |activateDist   |checkFreq  |numHardpts
//------------------------------------------------------------------------------
newTurret(1);
turretBase( IDTRT_C_LAS, "cLaserTurret.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, 1, 1, 0 );

//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                         Dmg    Offset_fm_Node     X_rot_rnge  Z_rot_rnge  
//            id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPoint( 0, X, T, head0, 0.0, 3.32, 6.89, -15.0, 40.0, -30.0, 20.0 );


//------------------------------------------------------------------------------
newTurret(2);
turretBase( IDTRT_C_MSSL, "cMissleTurret.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 12, 1 );

//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                            Dmg    Offset_fm_Node    X_rot_rnge  Z_rot_rnge  
//               id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPointExt( 0, L, I, head0, 8.09, -3.19, 9.55, 0.0, 0.0,  -30.0, 20.0 );
newHardPointExt( 1, L, I, head0, -7.35, -3.19, 9.55, 0.0, 0.0, -30.0, 20.0 );
newHardPointExt( 2, L, I, head0, 8.05, 0.47, 4.70, 0.0, 0.0,   -30.0, 20.0 );
newHardPointExt( 3, L, I, head0, -7.85, 0.47, 4.99, 0.0, 0.0,  -30.0, 20.0 );

newHardPointExt( 4, L, I, head0, 7.56, -3.19, 9.10, 0.0, 0.0,  -30.0, 20.0 );
newHardPointExt( 5, L, I, head0, -6.82, -3.19, 9.10, 0.0, 0.0, -30.0, 20.0 );
newHardPointExt( 6, L, I, head0, -7.56, 0.47, 5.36, 0.0, 0.0,  -30.0, 20.0 );
newHardPointExt( 7, L, I, head0, 7.77, 0.47, 5.28, 0.0, 0.0,   -30.0, 20.0 );

newHardPointExt( 8, L, I, head0, 7.05, -3.19, 8.57, 0.0, 0.0,  -30.0, 20.0 );
newHardPointExt( 9, L, I, head0, -6.20, -3.19, 8.57, 0.0, 0.0, -30.0, 20.0 );
newHardPointExt( 10, L, I, head0, -7.07, 0.47, 6.14, 0.0, 0.0, -30.0, 20.0 );
newHardPointExt( 11, L, I, head0, 7.44, 0.47, 6.06, 0.0, 0.0,  -30.0, 20.0 );


//------------------------------------------------------------------------------
newTurret( 3 );
turretBase( IDTRT_H_CANNON, "hCannon.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                            Dmg    Offset_fm_Node    X_rot_rnge  Z_rot_rnge  
//               id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPointExt( 0, X,    T, head0, 0.00, -1.7, 9.43, 0.0, 0.0, -30.0, 20.0 );


//------------------------------------------------------------------------------
newTurret( 27 );
turretBase( IDTRT_H_DESERT_LAS_SHORT, "hDesertLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 28 );
turretBase( IDTRT_H_DESERT_LAS_TALL, "hDesertLaserTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 4 );
turretBase( IDTRT_H_EARTH_LAS_SHORT, "hEarthLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 5 );
turretBase( IDTRT_H_EARTH_LAS_TALL, "hEarthLaserTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 6 );
turretBase( IDTRT_H_MARS_LAS_SHORT, "hMarsLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 7 );
turretBase( IDTRT_H_MARS_LAS_TALL, "hMarsLaserTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 8 );
turretBase( IDTRT_H_MOON_LAS_SHORT, "hMoonLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 9 );
turretBase( IDTRT_H_MOON_LAS_TALL, "hMoonLaserTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 10 );
turretBase( IDTRT_H_TITAN_LAS_SHORT, "hTitanLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 11 );
turretBase( IDTRT_H_TITAN_LAS_TALL, "hTitanLaserTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 12 );
turretBase( IDTRT_H_VENUS_LAS_SHORT, "hVenusLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();


//------------------------------------------------------------------------------
newTurret( 13 );
turretBase( IDTRT_H_VENUS_LAS_TALL, "hVenusLaserTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
humanLaser();

//                                                                               |activateDist   |checkFreq |numHardpts

//------------------------------------------------------------------------------
newTurret( 29 );
turretBase( IDTRT_H_DESERT_MSSL_SHORT, "hDesertMissleShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 30 );
turretBase( IDTRT_H_DESERT_MSSL_TALL, "hDesertMissleTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 14 );
turretBase( IDTRT_H_EARTH_MSSL_SHORT, "hEarthMissleShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 15 );
turretBase( IDTRT_H_EARTH_MSSL_TALL, "hEarthMissleTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 16 );
turretBase( IDTRT_H_MARS_MSSL_SHORT, "hMarsMissleShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 17 );
turretBase( IDTRT_H_MARS_MSSL_TALL, "hMarsMissleTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 18 );
turretBase( IDTRT_H_MOON_MSSL_SHORT, "hMoonMissleShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 19 );
turretBase( IDTRT_H_MOON_MSSL_TALL, "hMoonMissleTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 20 );
turretBase( IDTRT_H_TITAN_MSSL_SHORT, "hTitanMissleShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 21 );
turretBase( IDTRT_H_TITAN_MSSL_TALL, "hTitanMissleTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 22 );
turretBase( IDTRT_H_VENUS_MSSL_SHORT, "hVenusMissleShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();


//------------------------------------------------------------------------------
newTurret( 23 );
turretBase( IDTRT_H_VENUS_MSSL_TALL, "hVenusMissleTall.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 8, 1 );
humanMissile();

//------------------------------------------------------------------------------
// Rebel Artillery is now a Tank
//newTurret(24);
//turretBase( IDTRT_R_GUN, "hRebelARTL.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, 1, 1, 0 );
//
//          fireBayesNetworkName
////turretAI( "turretFire.ai" );
//
//// Hard Points (sizes:SMLX sides:TBLR)
//                         Dmg    Offset_fm_Node     X_rot_rnge  Z_rot_rnge  
//            id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
//newHardPoint( 0, X, T,    head0, 0.0, 0.00, 0.00,   -5.0, 20.0, -30.0, 20.0 );

//------------------------------------------------------------------------------
newTurret( 25 );
turretBase( IDTRT_M_CANNON, "hMoonCannon.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                            Dmg    Offset_fm_Node    X_rot_rnge  Z_rot_rnge  
//               id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPointExt( 0, X,    T, head0, 0.00, -1.7, 9.43, 0.0, 0.0, -30.0, 20.0 );


//------------------------------------------------------------------------------
newTurret( 26 );
turretBase( IDTRT_T_CANNON, "hTrooperCannon.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                            Dmg    Offset_fm_Node    X_rot_rnge  Z_rot_rnge  
//               id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPointExt( 0, X,    T, head0, 0.00, -1.7, 9.43, 0.0, 0.0, -30.0, 20.0 );


//------------------------------------------------------------------------------
newTurret( 31 );
turretBase( IDTRT_D_CANNON, "hDesertCannon.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 0 );
//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                            Dmg    Offset_fm_Node    X_rot_rnge  Z_rot_rnge  
//               id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPointExt( 0, X,    T, head0, 0.00, -1.7, 9.43, 0.0, 0.0, -30.0, 20.0 );


//------------------------------------------------------------------------------


//------------------------------------------------------------------------------
// respawning turrets
//------------------------------------------------------------------------------
newTurret( 32 );
turretBase( IDTRT_H_DESERT_LAS_SHORT, "hDesertLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 1 );
humanLaser();


//------------------------------------------------------------------------------
newTurret(33);
turretBase( IDTRT_C_LAS, "cLaserTurret.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, 1, 1, 1 );

//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                         Dmg    Offset_fm_Node     X_rot_rnge  Z_rot_rnge  
//            id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPoint( 0, X, T, head0, 0.0, 3.32, 6.89, -15.0, 40.0, -30.0, 20.0 );


//------------------------------------------------------------------------------
newTurret( 34 );
turretBase( IDTRT_H_TITAN_LAS_SHORT, "hTitanLaserShort.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 1 );
humanLaser();

//------------------------------------------------------------------------------
newTurret( 35 );
turretBase( IDTRT_T_CANNON, "hTrooperCannon.dts", "HULK_10X10.DTS", 1.0, 500.0, 1.0, 0.2, -1, 2, 1 );
//          fireBayesNetworkName
turretAI( "turretFire.ai" );

// Hard Points (sizes:SMLX sides:TBLR)
//                            Dmg    Offset_fm_Node    X_rot_rnge  Z_rot_rnge  
//               id size side Prnt   X____ Y___  Z___   min__ max_  min__ max__ 
newHardPointExt( 0, X,    T, head0, 0.00, -1.7, 9.43, 0.0, 0.0, -30.0, 20.0 );


o