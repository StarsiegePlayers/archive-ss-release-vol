//---------------------------------------------------------
// Pluto terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Pluto::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(S,  "1 - Flat with craters"         );
   LS::addTerrainType(G,  "2 - Uneven no craters"         );
   LS::addTerrainType(R,  "3 - Lumpy"         );
   LS::addTerrainType(P,  "4 - PAVED"         );
   LS::addTerrainType(T,  "5 - BORG TECH"         );
   LS::addTerrainType(M,  "6 - CYBRID METAL"         );
}

// default rules for this world type
function Terrain::Pluto::setRules()
{
   LS::flushRules();
   
   LS::addRule( S, 0.0,    600.0,   10.0,   0.50,0.30,0,0.00, 0.20, 0.05, 0.50,0.70,  0);
   LS::addRule( G, 0.0,    600.0,  200.0,   0.50,0.20,0,0.15, 1.00, 0.45, 0.50,0.80,  0);
   LS::addRule( R, 0.0,    600.0,  350.0,   0.50,0.30,0,0.35, 2.00, 0.75, 0.50,0.70,  0); 
   LS::addRule( P, 0.0,    3000.0,  1500.0, 1.00,-1,0,  0, 4, 2,           1.0,  -1,  0);
   LS::addRule( T, 0.0,    3000.0,  1500.0, 1.00,-1,0,  0, 4, 2,           1.0,  -1,  0); 
   LS::addRule( M, 4999.0, 5000.0, 4999.0,  0.50,0.30,0,0.35, 2.00, 0.75, 0.50,0.70,  0);
}

// create the grid file and dml for this world
function Terrain::Pluto::createGridFile()
{
   LS::flushTextures();
   Terrain::Pluto::setTypes();
   
   LS::addTerrainTexture("pluto.paved_pppp2.bmp",  PPPP, $FALL,         30, $TERRAIN_PLUTO | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("pluto.paved_pppp.bmp",   PPPP, $FALL,         70, $TERRAIN_PLUTO | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("pluto.paved_pptt.bmp",   PPTT, $FALL,          0, $TERRAIN_PLUTO | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("pluto.paved_pttt.bmp",   PTTT, $FALL,          0, $TERRAIN_PLUTO | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("pluto.paved_ssss.bmp",   SSSS, $FNONE,         0, $TERRAIN_PLUTO | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("pluto.rd_d_strt.bmp",    SSSS, $FNONE,         0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.rd_d_crnr.bmp",    SSSS, $FNONE,         0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.rd_d_cros.bmp",    SSSS, $FNONE,         0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.rd_d_tee.bmp",     SSSS, $FNONE,         0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.rd_d_end.bmp",     SSSS, $FNONE,         0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.tech_sttt.bmp",    STTT, $FALL,          0, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.tech_tsss.bmp",    TSSS, $FALL,          0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.tech_ttss.bmp",    TTSS, $FALL,          0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.tech_tttt.bmp",    TTTT, $FALL,         50, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.tech_tttt2.bmp",   TTTT, $FALL,         50, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSSS5.bmp",        SSSS, $FP|$FX|$FY|$FXY,  3, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSSS4.bmp",        SSSS, $FP|$FX|$FY|$FXY,  5, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSSS2.bmp",        SSSS, $FP|$FX|$FY|$FXY, 30, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSSS3.bmp",        SSSS, $FP|$FX|$FY|$FXY, 30, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSSS.bmp",         SSSS, $FP|$FX|$FY|$FXY, 32, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGGG5.bmp",        GGGG, $FP|$FX|$FY|$FXY,  5, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGGG4.bmp",        GGGG, $FP|$FX|$FY|$FXY, 10, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGGG3.bmp",        GGGG, $FP|$FX|$FY|$FXY, 20, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGGG2.bmp",        GGGG, $FP|$FX|$FY|$FXY, 30, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGGG.bmp",         GGGG, $FP|$FX|$FY|$FXY, 35, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGRR.bmp",         GGRR, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GGRR2.bmp",        GGRR, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GRRR.bmp",         GRRR, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GRRR2.bmp",        GRRR, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GRRG.bmp",         GRRG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GRRG2.bmp",        GRRG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GSSS.bmp",         GSSS, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.GSSS2.bmp",        GSSS, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RGGG.bmp",         RGGG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RGGG2.bmp",        RGGG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RRRR3.bmp",        RRRR, $FP|$FX|$FY|$FXY,  5, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RRRR5.bmp",        RRRR, $FP|$FX|$FY|$FXY,  5, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RRRR4.bmp",        RRRR, $FP|$FX|$FY|$FXY, 10, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RRRR2.bmp",        RRRR, $FP|$FX|$FY|$FXY, 40, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RRRR.bmp",         RRRR, $FP|$FX|$FY|$FXY, 40, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSGG.bmp",         SSGG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SSGG2.bmp",        SSGG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SGGG.bmp",         SGGG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SGGG2.bmp",        SGGG, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SGGS.bmp",         SGGS, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.SGGS2.bmp",        SGGS, $FP|$FX|$FY|$FXY, 50, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.paved_scorch.bmp", PPPP, $FALL,            30, $TERRAIN_PLUTO | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMMM1.bmp",        MMMM, $FP|$FX|$FY|$FXY, 35, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMMM2.bmp",        MMMM, $FP|$FX|$FY|$FXY, 30, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMMM3.bmp",        MMMM, $FP|$FX|$FY|$FXY, 15, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMMM4.bmp",        MMMM, $FP|$FX|$FY|$FXY, 10, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMMM5.bmp",        MMMM, $FP|$FX|$FY|$FXY, 10, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMRR.bmp",         MMRR, $FP|$FX|$FY|$FXY, 60, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.MMRR2.bmp",        MMRR, $FP|$FX|$FY|$FXY, 40, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.MRRR.bmp",         MRRR, $FP|$FX|$FY|$FXY,  0, $TERRAIN_PLUTO | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("pluto.RMMM.bmp",         RMMM, $FP|$FX|$FY|$FXY,  0, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 
   LS::addTerrainTexture("pluto.RMMR.bmp",         RMMR, $FP|$FX|$FY|$FXY,  0, $TERRAIN_PLUTO | $TS3_MetalType,       0.5, 1.0); 

   // create the dat and dml for this world
   LS::createGridFile("Pluto.grid.dat", "Pluto.terrain.dml");
}
