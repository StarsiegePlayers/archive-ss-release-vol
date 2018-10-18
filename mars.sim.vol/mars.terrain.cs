//---------------------------------------------------------
// Mars terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Mars::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(S, "1 - Sandy"       );
   LS::addTerrainType(G, "2 - Sparse Rock" );
   LS::addTerrainType(L, "3 - Cliff"       );
   LS::addTerrainType(A, "4 - Agricultural");
}

// default rules for this world type
function Terrain::Mars::setRules()
{
   LS::flushRules();

   LS::addRule(A,  0.0, 000.0,   00.0, 0.00,0.00,0,0.00, 0.00, 0.00, 0.00,0.00,  0);
   LS::addRule(S,  0.0, 600.0,   75.0, 0.60,0.30,0,0.00, 0.80, 0.09, 0.60,0.70,  0);
   LS::addRule(G,  0.0, 600.0,   50.0, 0.50,0.25,0,0.05, 0.40, 0.05, 0.40,0.50,  0); 
   LS::addRule(G,150.0, 600.0,  230.0, 0.35,0.20,0,0.50, 3.00, 0.65, 0.35,0.80,  0);
   LS::addRule(L,150.0, 600.0,  250.0, 0.25,0.20,0,0.55, 2.95, 0.75, 0.25,0.80,  0);
}

// create the grid file and dml for this world
function Terrain::Mars::createGridFile()
{
   LS::flushTextures();
   Terrain::Mars::setTypes();
   
   LS::addTerrainTexture("mars.paved1.bmp",       SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.paved2.bmp",       SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.paved_landg.bmp",  SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.rd_dirt_crnr.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_dirt_cros.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_dirt_end.bmp",  SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_dirt_strt.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_dirt_tee.bmp",  SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_trans.bmp",     SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_begin.bmp",     SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.rd_pave_crnr.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.rd_pave_cros.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.rd_pave_strt.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.rd_pave_tee.bmp",  SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.trans_ppdd.bmp",   SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.trans_dppp.bmp",   SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.trans_pddd.bmp",   SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSS6.BMP",        SSSS, $FALL,   2, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSS4.BMP",        SSSS, $FALL,   4, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSS5.BMP",        SSSS, $FALL,   8, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSS3.BMP",        SSSS, $FALL,  12, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSS.BMP",         SSSS, $FALL,  37, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSS2.BMP",        SSSS, $FALL,  37, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GGGG5.BMP",        GGGG, $FALL,   1, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GGGG6.BMP",        GGGG, $FALL,   5, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GGGG4.BMP",        GGGG, $FALL,  14, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GGGG3.BMP",        GGGG, $FALL,  20, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GGGG.BMP",         GGGG, $FALL,  30, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GGGG2.BMP",        GGGG, $FALL,  30, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SGGG.BMP",         SGGG, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SGGG2.BMP",        SGGG, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSGG.BMP",         SSGG, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSGG2.BMP",        SSGG, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GSSS.BMP",         GSSS, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GSSS2.BMP",        GSSS, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LLLL2.BMP",        LLLL, $FALL,  40, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LLLL.BMP",         LLLL, $FALL,  60, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GLLL.BMP",         GLLL, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.GLLL2.BMP",        GLLL, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LGGG.BMP",         LGGG, $FALL,  33, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LGGG2.BMP",        LGGG, $FALL,  33, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LGGG3.BMP",        LGGG, $FALL,  34, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LLGG.BMP",         LLGG, $FALL,  33, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LLGG2.BMP",        LLGG, $FALL,  33, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.LLGG3.BMP",        LLGG, $FALL,  34, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.AAAA.bmp",         AAAA, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.AAAA2.bmp",        AAAA, $FALL,  50, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSAA.bmp",         SSAA, $FALL,   0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.SSSA.bmp",         SSSA, $FALL,   0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.paved3.bmp",       SSSS, $FALL,   0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.AAAS.bmp",         AAAS, $FALL,   0, $TERRAIN_MARS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("mars.paved_scorch.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("mars.paved_crater.bmp", SSSS, $FNONE,  0, $TERRAIN_MARS | $TS3_ConcreteType,    0.5, 1.0);

   // create the dat and dml for this world
   LS::createGridFile("Mars.grid.dat", "Mars.terrain.dml");
}
