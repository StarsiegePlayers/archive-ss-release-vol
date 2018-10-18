//---------------------------------------------------------
// Ice terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Ice::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(D, "1 - Directional Snow"     );
   LS::addTerrainType(F, "2 - Omnidirectional Snow"     );
   LS::addTerrainType(R, "3 - Frosty Rocks"     );
}

// default rules for this world type
function Terrain::Ice::setRules()
{
   LS::flushRules();
   
   LS::addRule(D, 0.0,   600.0,  100.0, 0.50,0.30,0,0.00, 0.25, 0.01, 0.50,0.70,  0);
   LS::addRule(F, 0.0,   600.0,  200.0, 0.50,0.30,0,0.00, 0.65, 0.25, 0.50,0.70,  0);
   LS::addRule(R, 100.0, 600.0,  300.0, 0.50,0.30,0,0.20, 2.50, 0.40, 0.50,0.70,  0); 
   LS::addRule(F, 100.0, 600.0,  400.0, 0.50,0.30,0,0.20, 2.50, 0.30, 0.50,0.70,  0);
}

// create the grid file and dml for this world
function Terrain::Ice::createGridFile()
{
   LS::flushTextures();
   Terrain::Ice::setTypes();
   
   LS::addTerrainTexture("ice.dev_plain1.bmp",   FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.dev_plain2.bmp",   FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.dev_landg.bmp",    FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.rd_begin.bmp",     FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.rd_p_strt.bmp",    FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.rd_p_crnr.bmp",    FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.rd_p_cros.bmp",    FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.rd_p_tee.bmp",     FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.rd_p_end.bmp",     FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.trans_ddpp.bmp",   FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.trans_dppp.bmp",   FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.trans_pddd.bmp",   FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.FFFF4.bmp",        FFFF, $FALL,         15, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.FFFF2.bmp",        FFFF, $FALL,         15, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.FFFF.bmp",         FFFF, $FALL,         35, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.FFFF3.bmp",        FFFF, $FALL,         35, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0  );
   LS::addTerrainTexture("ice.DDDD3.bmp",        DDDD, $FP|$FX|$FY|$FXY, 25, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.DDDD2.bmp",        DDDD, $FP|$FX|$FY|$FXY, 35, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.DDDD.bmp",         DDDD, $FP|$FX|$FY|$FXY, 40, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.DDFF.bmp",         DDFF, $FP|$FX|$FY|$FXY,  0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.DFFF.bmp",         DFFF, $FP|$FX|$FY|$FXY,  0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.FDDD.bmp",         FDDD, $FP|$FX|$FY|$FXY,  0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.DFFD.bmp",         DFFD, $FP|$FX|$FY|$FXY,  0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0); 
   LS::addTerrainTexture("ice.RRRR4.bmp",        RRRR, $FALL,          8, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRRR3.bmp",        RRRR, $FALL,         15, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRRR5.bmp",        RRRR, $FALL,         20, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRRR2.bmp",        RRRR, $FALL,         27, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRRR.bmp",         RRRR, $FALL,         30, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.FRRR.bmp",         FRRR, $FALL,         35, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.FRRR2.bmp",        FRRR, $FALL,         65, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRFF3.bmp",        RRFF, $FALL,         10, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRFF2.bmp",        RRFF, $FALL,         40, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RRFF.bmp",         RRFF, $FALL,         50, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RFFF2.bmp",        RFFF, $FALL,         15, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RFFF3.bmp",        RFFF, $FALL,         40, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.RFFF.bmp",         RFFF, $FALL,         45, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.ROCK.bmp",         RRRR, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.bluescreen.bmp",   RRRR, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );
   LS::addTerrainTexture("ice.paved_scorch.bmp", FFFF, $FNONE,         0, $TERRAIN_ICE | $TS3_IceType, 0.5, 1.0   );

   // create the dat and dml for this world
   LS::createGridFile("Ice.grid.dat", "Ice.terrain.dml");
}
