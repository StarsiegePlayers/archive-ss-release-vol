//---------------------------------------------------------
// Temperate terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Temperate::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(D,  "1 - Clumpy vegetation"         );
   LS::addTerrainType(G,  "2 - Thin vegetation"         );
   LS::addTerrainType(R,  "3 - Rocky");
}

// default rules for this world type
function Terrain::Temperate::setRules()
{
   LS::flushRules();
   
   LS::addRule(D, 0.0, 600.0, 100.0, 0.60,0.30, 0, 0.01, 0.35, 0.10, 0.40,0.70,  0 );
   LS::addRule(G, 0.0, 600.0, 200.0, 0.50,0.30, 0, 0.00, 0.75, 0.08, 0.70,0.70,  0 );
   LS::addRule(R, 150.0, 600.0, 400.0, 0.30,0.40, 0, 0.20, 3.00, 0.25, 0.60,0.50,  0); 
}

// create the grid file and dml for this world
function Terrain::Temperate::createGridFile()
{
   LS::flushTextures();
   Terrain::Temperate::setTypes();
   
   LS::addTerrainTexture("temperate.pave_plain1.bmp", DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.pave_plain2.bmp", DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.pave_landg.bmp",  DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_p_strt.bmp",   DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_p_crnr.bmp",   DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_p_tee.bmp",    DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_p_cros.bmp",   DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_trans.bmp",    DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_d_strt.bmp",   DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_d_crnr.bmp",   DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_d_cros.bmp",   DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_d_tee.bmp",    DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.rd_d_end.bmp",    DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.trans_ppdd.bmp",  DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.trans_dppp.bmp",  DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("temperate.trans_pddd.bmp",  DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DDDD5.bmp",       DDDD, $FALL ,   5, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DDDD4.bmp",       DDDD, $FALL ,  20, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DDDD3.bmp",       DDDD, $FALL ,  25, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DDDD2.bmp",       DDDD, $FALL ,  25, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DDDD.bmp",        DDDD, $FALL ,  25, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGGG5.bmp",       GGGG, $FALL ,  10, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGGG4.bmp",       GGGG, $FALL ,  10, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGGG3.bmp",       GGGG, $FALL ,  25, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGGG2.bmp",       GGGG, $FALL ,  25, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGGG.bmp",        GGGG, $FALL ,  30, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.RRRR4.bmp",       RRRR, $FALL ,  15, $TERRAIN_TEMPERATE | $TS3_StoneType,       0.5, 1.0);
   LS::addTerrainTexture("temperate.RRRR3.bmp",       RRRR, $FALL ,  15, $TERRAIN_TEMPERATE | $TS3_StoneType,       0.5, 1.0);
   LS::addTerrainTexture("temperate.RRRR2.bmp",       RRRR, $FALL ,  35, $TERRAIN_TEMPERATE | $TS3_StoneType,       0.5, 1.0);
   LS::addTerrainTexture("temperate.RRRR.bmp",        RRRR, $FALL ,  35, $TERRAIN_TEMPERATE | $TS3_StoneType,       0.5, 1.0);
   LS::addTerrainTexture("temperate.DDGG2.bmp",       DDGG, $FALL ,  50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DDGG.bmp",        DDGG, $FALL ,  50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DGGG2.bmp",       DGGG, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.DGGG.bmp",        DGGG, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GDDD2.bmp",       GDDD, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GDDD.bmp",        GDDD, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGRR2.bmp",       GGRR, $FALL ,  50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GGRR.bmp",        GGRR, $FALL ,  50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.RGGG2.bmp",       RGGG, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.RGGG.bmp",        RGGG, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("temperate.GRRR2.bmp",       GRRR, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_StoneType,       0.5, 1.0);
   LS::addTerrainTexture("temperate.GRRR.bmp",        GRRR, $FALL,   50, $TERRAIN_TEMPERATE | $TS3_StoneType,       0.5, 1.0);
   LS::addTerrainTexture("temperate.pavedscorch.bmp", DDDD, $FNONE,   0, $TERRAIN_TEMPERATE | $TS3_ConcreteType,    0.5, 1.0);


   // create the dat and dml for this world
   LS::createGridFile("Temperate.grid.dat", "Temperate.terrain.dml");
}

  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
                                                                                                      
                                                                                                      
                                                                                                      
                                                                                                      
                                                                                                      