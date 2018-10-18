//---------------------------------------------------------
// Europa terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Europa::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType( F,"  1  FLAT ICE");
   LS::addTerrainType( C,"  2  CREVASSES");
   LS::addTerrainType( R,"  3  DARKER");
   LS::addTerrainType( G,"  4  SMOOTH ICE, BUBBLES");
   LS::addTerrainType( D,"  5  CRACKED UP");
}                        

// default rules for this world type
function Terrain::Europa::setRules()
{
   LS::flushRules();
   
   LS::addRule(F,   0.0, 150.0,    0.0, 0.60, 0.20, 0,   0.00, 0.10, 0.00,   0.60,0.80, 1);
   LS::addRule(C,   0.0, 150.0,    1.0, 0.40, 0.20, 0,   0.04, 0.08, 0.03,   0.10,0.80, 1);
   LS::addRule(R,   0.0, 600.0,   50.0, 0.50, 0.30, 0,   0.10, 0.30, 0.20,   0.40,0.70, 1); 
   LS::addRule(G,   0.0, 600.0,   50.0, 0.60, 0.30, 0,   0.05, 0.90, 0.40,   0.70,0.70, 0);
   LS::addRule(D,   50.0,600.0,  300.0, 0.50, 0.50, 1,   0.35, 3.90, 0.75,   0.60,0.50, 0);
}

// create the grid file and dml for this world
function Terrain::Europa::createGridFile()
{
   LS::flushTextures();
   Terrain::Europa::setTypes();
   
   LS::addTerrainTexture("europa.pave_plain1.bmp", FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.pave_plain2.bmp", FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.pave_landg.bmp",  FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_p_strt.bmp",   FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_p_crnr.bmp",   FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_p_cros.bmp",   FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_p_tee.bmp",    FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_trans.bmp",    FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_d_strt.bmp",   FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_d_crnr.bmp",   FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_d_cros.bmp",   FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_d_tee.bmp",    FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.rd_d_end.bmp",    FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.trans_ppdd.bmp",  FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.trans_pddd.bmp",  FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.trans_dppp.bmp",  FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.CFFC3.bmp",       CFFC, $FALL,  25, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFFC2.bmp",       CFFC, $FALL,  35, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFFC.bmp",        CFFC, $FALL,  40, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFFF3.bmp",       CFFF, $FALL,  25, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFFF2.bmp",       CFFF, $FALL,  35, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFFF.bmp",        CFFF, $FALL,  40, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFCF3.bmp",       CFCF, $FALL,  25, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFCF2.bmp",       CFCF, $FALL,  35, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.CFCF.bmp",        CFCF, $FALL,  40, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRRR4.bmp",       RRRR, $FALL,   4, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRRR3.bmp",       RRRR, $FALL,   5, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRRR5.bmp",       RRRR, $FALL,  12, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRRR2.bmp",       RRRR, $FALL,  38, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRRR.bmp",        RRRR, $FALL,  41, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GGGG6.bmp",       GGGG, $FALL,   2, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GGGG5.bmp",       GGGG, $FALL,   3, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GGGG4.bmp",       GGGG, $FALL,  13, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GGGG3.bmp",       GGGG, $FALL,  17, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GGGG.bmp",        GGGG, $FALL,  30, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GGGG2.bmp",       GGGG, $FALL,  35, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDDD6.bmp",       DDDD, $FALL,   2, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDDD5.bmp",       DDDD, $FALL,   4, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDDD4.bmp",       DDDD, $FALL,  10, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDDD3.bmp",       DDDD, $FALL,  24, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDDD2.bmp",       DDDD, $FALL,  30, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDDD.bmp",        DDDD, $FALL,  30, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDGG.bmp",        DDGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DDGG2.bmp",       DDGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DGGG.bmp",        DGGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.DGGG2.bmp",       DGGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GDDD.bmp",        GDDD, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GDDD2.bmp",       GDDD, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FFGG.bmp",        FFGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FFGG2.bmp",       FFGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GFFF.bmp",        GFFF, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GFFF2.bmp",       GFFF, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FGGG.bmp",        FGGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FGGG2.bmp",       FGGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRGG.bmp",        RRGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RRGG2.bmp",       RRGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GRRR.bmp",        GRRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GRRR2.bmp",       GRRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RGGG.bmp",        RGGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RGGG2.bmp",       RGGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FGRR.bmp",        FGRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FGRR2.bmp",       FGRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FRGG.bmp",        FRGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FRGG2.bmp",       FRGG, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GRFF.bmp",        GRFF, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.GRFF2.bmp",       GRFF, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FFRR.bmp",        FFRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FFRR2.bmp",       FFRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RFFF.bmp",        RFFF, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.RFFF2.bmp",       RFFF, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FRRR.bmp",        FRRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.FRRR2.bmp",       FRRR, $FALL,  50, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.pavedscorch.bmp", FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.pavedcrater.bmp", FFFF, $FNONE,  0, $TERRAIN_EUROPA | $TS3_ConcreteType,    0.5, 1.0); 
   LS::addTerrainTexture("europa.ffff5.bmp",       FFFF, $FALL,   5, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.ffff4.bmp",       FFFF, $FALL,   5, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.ffff3.bmp",       FFFF, $FALL,  20, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.ffff2.bmp",       FFFF, $FALL,  35, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 
   LS::addTerrainTexture("europa.ffff.bmp",        FFFF, $FALL,  35, $TERRAIN_EUROPA | $TS3_PackedEarthType, 0.5, 1.0); 


   // create the dat and dml for this world
   LS::createGridFile("Europa.grid.dat", "Europa.terrain.dml");
}
