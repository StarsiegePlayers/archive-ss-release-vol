//---------------------------------------------------------
// Mercury terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Mercury::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(S,  "1 - Cracked salt flats"  );
   LS::addTerrainType(D,  "2 - Sandstone"           );
   LS::addTerrainType(L,  "3 - Eroded directional"  );
}

// default rules for this world type
function Terrain::Mercury::setRules()
{
   LS::flushRules();
   
   LS::addRule(S,0.0,   300.0,  50.0, 0.50, 0.50, 1, 0.00, 0.20, 0.05,0.60,0.50, 1);
   LS::addRule(D,0.0,   600.0, 300.0, 0.70, 0.50, 1, 0.15, 0.95, 0.40,0.60,0.50, 0);
   LS::addRule(L,200.0, 600.0, 400.0, 0.50, 0.50, 1, 0.30, 1.90, 0.70,0.50,0.50, 0); 
}

// create the grid file and dml for this world
function Terrain::Mercury::createGridFile()
{
   LS::flushTextures();
   Terrain::Mercury::setTypes();
   
   LS::addTerrainTexture("mercury.pave_plain1.bmp",SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.pave_plain2.bmp",SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.pave_landg.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_pp_strt.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_pp_crnr.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_pp_cros.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_pp_tee.bmp",  SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_trans.bmp",   SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_d_strt.bmp",  SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_d_crnr.bmp",  SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_d_cros.bmp",  SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_d_tee.bmp",   SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.rd_d_end.bmp",   SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.trans_ppdd.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.trans_dppp.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("mercury.trans_pddd.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSSS6.bmp",      SSSS, $FALL,          2, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSSS5.bmp",      SSSS, $FALL,          3, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSSS4.bmp",      SSSS, $FALL,         10, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSSS3.bmp",      SSSS, $FALL,         15, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSSS2.bmp",      SSSS, $FALL,         34, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSSS.bmp",       SSSS, $FALL,         36, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDDD6.bmp",      DDDD, $FP|$FX|$FY|$FXY,  2, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDDD5.bmp",      DDDD, $FP|$FX|$FY|$FXY,  2, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDDD4.bmp",      DDDD, $FALL,         16, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDDD3.bmp",      DDDD, $FALL,         20, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDDD2.bmp",      DDDD, $FALL,         29, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDDD.bmp",       DDDD, $FALL,         31, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDLL.bmp",       DDLL, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DDLL2.bmp",      DDLL, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DLLL.bmp",       DLLL, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DLLL2.bmp",      DLLL, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LDDD.bmp",       LDDD, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LDDD2.bmp",      LDDD, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LDDL.bmp",       LDDL, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LDDL2.bmp",      LDDL, $FP|$FX|$FY|$FXY, 50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LLLL4.bmp",      LLLL, $FP|$FX|$FY|$FXY, 10, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LLLL3.bmp",      LLLL, $FP|$FX|$FY|$FXY, 20, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LLLL2.bmp",      LLLL, $FP|$FX|$FY|$FXY, 30, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.LLLL.bmp",       LLLL, $FP|$FX|$FY|$FXY, 40, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DSSS.bmp",       DSSS, $FALL,         50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.DSSS2.bmp",      DSSS, $FALL,         50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SDDD.bmp",       SDDD, $FALL,         50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SDDD2.bmp",      SDDD, $FALL,         50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSDD.bmp",       SSDD, $FALL,         50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.SSDD2.bmp",      SSDD, $FALL,         50, $TERRAIN_MERCURY | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("mercury.pave_landg.bmp", SSSS, $FNONE,         0, $TERRAIN_MERCURY | $TS3_ConcreteType,    0.5, 1.0); 

   // create the dat and dml for this world
   LS::createGridFile("Mercury.grid.dat", "Mercury.terrain.dml");
}
