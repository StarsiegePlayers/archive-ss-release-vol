//---------------------------------------------------------
// dessert terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Desert::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(S, "1 SMOOTH");
   LS::addTerrainType(D, "1 THIN RIPPLES");
   LS::addTerrainType(G, "2 WIDER RIPPLES");
}

// default rules for this world type
function Terrain::Desert::setRules()
{
   LS::flushRules();

   LS::addRule(S,     0.0, 400.0,  20.0,  0.20,0.50, 0,  0.00, 0.25, 0.05, 0.40,0.50,  0 );
   LS::addRule(D,     0.0, 600.0,  150.0, 0.50,0.20, 0,  0.20, 1.90, 0.40, 0.50,0.80,  0 );
   LS::addRule(G,   200.0, 600.0,  300.0, 0.70,0.50, 0,  0.00, 0.25, 0.05, 0.70,0.50,  0 ); 
}

// create the grid file and dml for this world
function Terrain::Desert::createGridFile()
{
   LS::flushTextures();
   Terrain::Desert::setTypes();

   LS::addTerrainTexture("desert.paved1.bmp",           SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.paved2.bmp",           SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.paved_landg.bmp",      SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.rd_pave_strt.bmp",     SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.rd_pave_crnr.bmp",     SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.rd_pave_cros.bmp",     SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.rd_pave_tee.bmp",      SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.rd_trans.bmp",         SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.rd_dirt_strt.bmp",     SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.rd_dirt_crnr.bmp",     SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.rd_dirt_cros.bmp",     SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.rd_dirt_tee.bmp",      SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.rd_dirt_end.bmp",      SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.paved_trans_ppss.bmp", SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.paved_trans_psss.bmp", SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.paved_trans_sppp.bmp", SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_ConcreteType,  0.5, 1.0);
   LS::addTerrainTexture("desert.SSSS4.bmp",            SSSS, $FP|FY,  2, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SSSS3.bmp",            SSSS, $FP|FY,  3, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SSSS2.bmp",            SSSS, $FP|FY, 15, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SSSS.bmp",             SSSS, $FP|FY, 80, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DDDD4.bmp",            DDDD, $FP|FY,  2, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DDDD3.bmp",            DDDD, $FP|FY,  3, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DDDD2.bmp",            DDDD, $FP|FY, 45, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DDDD.bmp",             DDDD, $FP|FY, 50, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DDGG.bmp",             DDGG, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DGDD.bmp",             DGDD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DGGD.bmp",             DGGD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DGGG.bmp",             DGGG, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GDDD.bmp",             GDDD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GDDG.bmp",             GDDG, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GDGG.bmp",             GDGG, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GGGG6.bmp",            GGGG, $FP|FY,  2, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GGGG5.bmp",            GGGG, $FP|FY,  3, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GGGG4.bmp",            GGGG, $FP|FY,  3, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GGGG3.bmp",            GGGG, $FP|FY,  5, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GGGG2.bmp",            GGGG, $FP|FY, 40, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.GGGG.bmp",             GGGG, $FP|FY, 47, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SSDD.bmp",             SSDD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DSDD.bmp",             DSDD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DSSD.bmp",             DSSD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.DSSS.bmp",             DSSS, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SDDD.bmp",             SDDD, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SDDS.bmp",             SDDS, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.SDSS.bmp",             SDSS, $FP|FY,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
   LS::addTerrainTexture("desert.pavedscorch.bmp",      SSSS, $FNONE,  0, $TERRAIN_DESERT | $TS3_SoftEarthType, 0.5, 1.0);
                                                                         
   // create the dat and dml for this world                              
   LS::createGridFile("Desert.grid.dat", "Desert.terrain.dml");      
}
