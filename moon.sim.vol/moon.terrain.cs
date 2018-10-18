//---------------------------------------------------------
// Moon terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Moon::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(C, "1 - Flat with craters"     );
   LS::addTerrainType(R, "2 - Uneven with craters"     );
   LS::addTerrainType(D, "3 - lumpy light");
   LS::addTerrainType(G, "4 - Lumpy dark"     );
}

// default rules for this world type
function Terrain::Moon::setRules()
{
   LS::flushRules();
   
   LS::addRule( S,  0.0, 600.0,  10.0, 0.50,0.20,0, 0.00, 0.30, 0.05, 0.50,0.80,  0);
   LS::addRule( D,  0.0, 600.0, 100.0, 0.50,0.20,0, 0.05, 0.55, 0.20, 0.50,0.80,  0);
   LS::addRule( G,  0.0, 600.0, 300.0, 0.30,0.20,0, 0.35, 1.00, 0.55, 0.50,0.90,  0); 
   LS::addRule( R,  0.0, 600.0, 300.0, 0.50,0.30,0, 0.60, 1.20, 0.75, 0.50,0.70,  1);
}

// create the grid file and dml for this world
function Terrain::Moon::createGridFile()
{
   LS::flushTextures();
   Terrain::Moon::setTypes();
   
   LS::addTerrainTexture("moon.pave_plain1.bmp", SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.pave_plain2.bmp", SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.pave_landg.bmp",  SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_p_strt.bmp",   SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_p_crnr.bmp",   SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_p_cros.bmp",   SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_p_tee.bmp",    SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_trans.bmp",    SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_d_strt.bmp",   SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_d_crnr.bmp",   SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_d_cros.bmp",   SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_d_tee.bmp",    SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.rd_d_end.bmp",    SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.trans_ppdd.bmp",  SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.trans_dppp.bmp",  SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );
   LS::addTerrainTexture("moon.trans_pddd.bmp",  SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SSSS6.bmp",       SSSS, $FALL,   1, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SSSS3.bmp",       SSSS, $FALL,   3, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SSSS5.bmp",       SSSS, $FALL,   5, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SSSS2.bmp",       SSSS, $FALL,   6, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SSSS.bmp",        SSSS, $FALL,  40, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SSSS4.bmp",       SSSS, $FALL,  45, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDDD5.bmp",       DDDD, $FALL,   1, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDDD3.bmp",       DDDD, $FALL,   2, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDDD4.bmp",       DDDD, $FALL,   5, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDDD.bmp",        DDDD, $FALL,  45, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDDD2.bmp",       DDDD, $FALL,  47, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GGDD.bmp",        GGDD, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GGDD2.bmp",       GGDD, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDSS.bmp",        DDSS, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DDSS2.bmp",       DDSS, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SDDD.bmp",        SDDD, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.SDDD2.bmp",       SDDD, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DGGG.bmp",        DGGG, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DGGG2.bmp",       DGGG, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DSSS.bmp",        DSSS, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.DSSS2.bmp",       DSSS, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GDDD.bmp",        GDDD, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GDDD2.bmp",       GDDD, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GGGG3.bmp",       GGGG, $FALL,  30, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GGGG.bmp",        GGGG, $FALL,  35, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GGGG2.bmp",       GGGG, $FALL,  35, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.RRGG.bmp",        RRGG, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.RRGG2.bmp",       RRGG, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GRRR.bmp",        GRRR, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.GRRR2.bmp",       GRRR, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.RGGG.bmp",        RGGG, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.RGGG2.bmp",       RGGG, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.RRRR.bmp",        RRRR, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.RRRR2.bmp",       RRRR, $FALL,  50, $TERRAIN_MOON | $TS3_PackedEarthType, 0.5, 1.0 );
   LS::addTerrainTexture("moon.pave_scorch.bmp", SSSS, $FNONE,  0, $TERRAIN_MOON | $TS3_ConcreteType,    0.5, 1.0 );

   // create the dat and dml for this world
   LS::createGridFile("Moon.grid.dat", "Moon.terrain.dml");
}

