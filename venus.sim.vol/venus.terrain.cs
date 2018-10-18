//---------------------------------------------------------
// Venus terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Venus::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(S,  "1 - Lava lake"     );
   LS::addTerrainType(G,  "2 - Ash"     );
   LS::addTerrainType(D,  "3 - Ash with rock"     );
}

// default rules for this world type
function Terrain::Venus::setRules()
{
   LS::flushRules();

   LS::addRule(S, 0.0, 200.0,   50.0, 0.40,0.30, 1, 0.00, 0.13, 0.00, 0.10,0.70, 1);
   LS::addRule(D, 0.0, 600.0,  300.0, 0.50,0.20, 0, 0.01, 0.25, 0.05, 0.65,0.80, 0);
   LS::addRule(G, 0.0, 600.0,  150.0, 0.50,0.20, 0, 0.01, 0.12, 0.11, 0.10,0.80, 0); 
   LS::addRule(G, 0.0, 600.0,  300.0, 0.50,0.20, 0, 0.30, 2.25, 0.55, 0.30,0.80, 0);
}

// create the grid file and dml for this world
function Terrain::Venus::createGridFile()
{
   LS::flushTextures();
	Terrain::Venus::setTypes();

   LS::addTerrainTexture("venus.paved_gggg.bmp",   GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("venus.paved_gppp.bmp",   GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("venus.paved_pggg.bmp",   GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("venus.paved_ppgg.bmp",   GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("venus.paved_pppp.bmp",   GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("venus.rd_trans.bmp",     GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.rd_p_strt.bmp",    GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.rd_p_crnr.bmp",    GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.rd_p_cros.bmp",    GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.rd_p_tee.bmp",     GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.rd_p_end.bmp",     GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD4.bmp",        DDDD, $FALL,   1, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD3.bmp",        DDDD, $FALL,   1, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD7.bmp",        DDDD, $FALL,   3, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD6.bmp",        DDDD, $FALL,  12, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD5.bmp",        DDDD, $FALL,  20, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD2.bmp",        DDDD, $FALL,  30, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DDDD.bmp",         DDDD, $FALL,  33, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DGGG.bmp",         DGGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DGGG2.bmp",        DGGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DSSS.bmp",         DSSS, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.DSSS2.bmp",        DSSS, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GDDD.bmp",         GDDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GDDD2.bmp",        GDDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GDSS.bmp",         GDSS, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GDSS2.bmp",        GDSS, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGDD.bmp",         GGDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGDD2.bmp",        GGDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG7.bmp",        GGGG, $FALL,   1, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG6.bmp",        GGGG, $FALL,   2, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG.bmp",         GGGG, $FALL,  17, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG5.bmp",        GGGG, $FALL,  20, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG4.bmp",        GGGG, $FALL,  20, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG3.bmp",        GGGG, $FALL,  20, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GGGG2.bmp",        GGGG, $FALL,  20, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GSSS.bmp",         GSSS, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.GSSS2.bmp",        GSSS, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SDDD.bmp",         SDDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SDDD2.bmp",        SDDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SDGG.bmp",         SDGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SDGG2.bmp",        SDGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SGDD.bmp",         SGDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SGDD2.bmp",        SGDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SGGG.bmp",         SGGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SGGG2.bmp",        SGGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSDD.bmp",         SSDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSDD2.bmp",        SSDD, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSGG.bmp",         SSGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSGG2.bmp",        SSGG, $FALL,  50, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS8.bmp",        SSSS, $FALL,   2, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS7.bmp",        SSSS, $FALL,   2, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS4.bmp",        SSSS, $FALL,   2, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS3.bmp",        SSSS, $FALL,  14, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS2.bmp",        SSSS, $FALL,  15, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS6.bmp",        SSSS, $FALL,  20, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS5.bmp",        SSSS, $FALL,  22, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.SSSS.bmp",         SSSS, $FALL,  23, $TERRAIN_VENUS | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("venus.paved_scorch.bmp", GGGG, $FNONE,  0, $TERRAIN_VENUS | $TS3_ConcreteType,    0.5, 1.0);

   LS::createGridFile("Venus.grid.dat", "Venus.terrain.dml");
}