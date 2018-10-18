//---------------------------------------------------------
// Titan terrain file
//---------------------------------------------------------

// the terrain types for this world
function Terrain::Titan::setTypes()
{
	LS::flushTypes();

   LS::addTerrainType(C,  "1 - Purple vegetation"         );
   LS::addTerrainType(G,  "2 - Rocky flatland"         );
   LS::addTerrainType(H,  "3 - Cracked ground"         );
   LS::addTerrainType(O,  "4 - Oil plus sludge"         );
}

// default rules for this world type
function Terrain::Titan::setRules()
{
   LS::flushRules();
   
   LS::addRule(O,   0.0, 100.0,   0.0, 0.40,0.30,1, 0.00, 0.04, 0.00, 0.40,0.70,  0);
   LS::addRule(H,   0.0, 150.0,  10.0, 0.50,0.30,1, 0.00, 0.15, 0.01, 0.60,0.70,  0);
   LS::addRule(G,   0.0, 600.0, 100.0, 0.60,0.60,0, 0.01, 3.20, 0.00, 0.40,0.40,  0); 
   LS::addRule(C, 400.0, 600.0, 400.0, 0.30,0.50,1, 0.05, 3.20, 0.20, 0.50,0.50,  0);
}

// create the grid file and dml for this world
function Terrain::Titan::createGridFile()
{
   LS::flushTextures();
   Terrain::Titan::setTypes();
   
   LS::addTerrainTexture("titan.paved_gppp.bmp",   GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("titan.paved_pggg.bmp",   GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("titan.paved_ppgg.bmp",   GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("titan.paved_pppp.bmp",   GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("titan.paved_pppp2.bmp",  GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_ConcreteType,    0.5, 1.0);
   LS::addTerrainTexture("titan.road_begin.bmp",   GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.road_crnr.bmp",    GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.road_cros.bmp",    GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.road_end.bmp",     GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.road_strt.bmp",    GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.road_tee.bmp",     GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.HHHH5.bmp",        HHHH, $FALL,   2, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.HHHH3.bmp",        HHHH, $FALL,  20, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.HHHH2.bmp",        HHHH, $FALL,  23, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.HHHH4.bmp",        HHHH, $FALL,  25, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.HHHH.bmp",         HHHH, $FALL,  30, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.CCCC4.bmp",        CCCC, $FALL,  10, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.CCCC3.bmp",        CCCC, $FALL,  20, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.CCCC.bmp",         CCCC, $FALL,  30, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.CCCC2.bmp",        CCCC, $FALL,  40, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.GGGG4.bmp",        GGGG, $FALL,   5, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.GGGG2.bmp",        GGGG, $FALL,  15, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.GGGG3.bmp",        GGGG, $FALL,  35, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.GGGG.bmp",         GGGG, $FALL,  45, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.OOOO2.bmp",        OOOO, $FALL,  22, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.OOOO3.bmp",        OOOO, $FALL,  23, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.OOOO4.bmp",        OOOO, $FALL,  25, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.OOOO.bmp",         OOOO, $FALL,  30, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.gccc.bmp",         GCCC, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.gccc2.bmp",        GCCC, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.ccgg.bmp",         CCGG, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.ccgg2.bmp",        CCGG, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.cggg.bmp",         CGGG, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.cggg2.bmp",        CGGG, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.gghh.bmp",         GGHH, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.gghh2.bmp",        GGHH, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.ghhh.bmp",         GHHH, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.ghhh2.bmp",        GHHH, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.hggg.bmp",         HGGG, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.hggg2.bmp",        HGGG, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.hhoo.bmp",         HHOO, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.hhoo2.bmp",        HHOO, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.hooo.bmp",         HOOO, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.hooo2.bmp",        HOOO, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.ohhh.bmp",         OHHH, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.ohhh2.bmp",        OHHH, $FALL,  50, $TERRAIN_TITAN | $TTS3_PackedEarthType, 0.5, 1.0);
   LS::addTerrainTexture("titan.paved_scorch.bmp", GGGG, $FNONE,  0, $TERRAIN_TITAN | $TTS3_ConcreteType,    0.5, 1.0);

   // create the dat and dml for this world
   LS::createGridFile("Titan.grid.dat", "Titan.terrain.dml");

}
