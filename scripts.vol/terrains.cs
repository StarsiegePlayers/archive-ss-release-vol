// -------------------------------------------------
// declare the terrain types here
// -------------------------------------------------
$terrainTypes[0, type]           = "flat";
$terrainTypes[0, description]    = "Flat terrain";
$terrainTypes[0, visDistance]    = 3000;
$terrainTypes[0, hazeDistance]   = 2000;
$terrainTypes[0, screenSize]     = 90;

$terrainTypes[1, type]           = "rolplains";
$terrainTypes[1, description]    = "Rolling plains";
$terrainTypes[1, visDistance]    = 3000;
$terrainTypes[1, hazeDistance]   = 2000;
$terrainTypes[1, screenSize]     = 70;

$terrainTypes[2, type]           = "rolhills";
$terrainTypes[2, description]    = "Rolling hills";
$terrainTypes[2, visDistance]    = 3000;
$terrainTypes[2, hazeDistance]   = 1500;
$terrainTypes[2, screenSize]     = 70;

$terrainTypes[3, type]           = "modhills";
$terrainTypes[3, description]    = "Moderately hilly";
$terrainTypes[3, visDistance]    = 3000;
$terrainTypes[3, hazeDistance]   = 1500;
$terrainTypes[3, screenSize]     = 70;

$terrainTypes[4, type]           = "bighills";
$terrainTypes[4, description]    = "Large hills";
$terrainTypes[4, visDistance]    = 3000;
$terrainTypes[4, hazeDistance]   = 1500;
$terrainTypes[4, screenSize]     = 55;

$terrainTypes[5, type]           = "rughills";
$terrainTypes[5, description]    = "Rugged hills";
$terrainTypes[5, visDistance]    = 3000;
$terrainTypes[5, hazeDistance]   = 1500;
$terrainTypes[5, screenSize]     = 40;

// -------------------------------------------------
// pretty flat terrain
// -------------------------------------------------
function Terrain::flat::create(%seed)
{
   if(%seed == "")
      %seed = $ME::terrainSeed;

   LS::addCommand("seed " @ %seed);
   LS::addCommand("terrain 256 .9");
   LS::addCommand("normalize 0 100");
}

// -------------------------------------------------
// rolling plains
// -------------------------------------------------
function Terrain::rolplains::create(%seed)
{
   if(%seed == "")
      %seed = $ME::terrainSeed;

   LS::addCommand("seed " @ %seed      );      
   LS::addCommand("terrain 256 .8"      );
   LS::addCommand("normalize 0 600"      );
   LS::addCommand("floor   200 400 0"   );
   LS::addCommand("clamp   5   20"         );
   LS::addCommand("clamp   4   10"         );
   LS::addCommand("clamp   3   5"         );
   LS::addCommand("clamp   2   2"         );
   LS::addCommand("clamp   1   0"         );
   LS::addCommand("smooth   0.005   5"      );
   LS::addCommand("normalize   0   200"   );
}

// -------------------------------------------------
// rolling hills
// -------------------------------------------------
function Terrain::rolhills::create(%seed)
{
   if(%seed == "")
      %seed = $ME::terrainSeed;
 
   LS::addCommand("seed " @ %seed      );      
   LS::addCommand("terrain 256 .8"      );
   LS::addCommand("normalize 0 600"      );
   LS::addCommand("clamp   5   20"         );
   LS::addCommand("clamp   4   10"         );
   LS::addCommand("clamp   3   5"         );
   LS::addCommand("clamp   2   2"         );
   LS::addCommand("clamp   1   0"         );
   LS::addCommand("smooth   0.005   5"      );
   LS::addCommand("normalize   0   600"   );
}

// -------------------------------------------------
// moderately hilly
// -------------------------------------------------
function Terrain::modhills::create(%seed)
{
   if(%seed == "")
      %seed = $ME::terrainSeed;

   LS::addCommand("seed " @ %seed      );      
   LS::addCommand("terrain 256 .8"      );
   LS::addCommand("normalize 0 600"      );
   LS::addCommand("floor   250 550 0"   );
   LS::addCommand("clamp   5   20"         );
   LS::addCommand("clamp   4   10"         );
   LS::addCommand("clamp   3   5"         );
   LS::addCommand("clamp   2   2"         );
   LS::addCommand("clamp   1   0"         );
   LS::addCommand("smooth   0.005   5"      );
   LS::addCommand("normalize   0   600"   );
}

// -------------------------------------------------
// really hilly
// -------------------------------------------------
function Terrain::bighills::create(%seed)
{
   if(%seed == "")
      %seed = $ME::terrainSeed;

   LS::addCommand("seed " @ %seed      );      
   LS::addCommand("terrain 256 .6"      );
   LS::addCommand("normalize 0 600"      );
   LS::addCommand("clamp   5   20"         );
   LS::addCommand("clamp   4   10"         );
   LS::addCommand("clamp   3   5"         );
   LS::addCommand("clamp   2   2"         );
   LS::addCommand("clamp   1   0"         );
   LS::addCommand("smooth   0.005   5"      );
   LS::addCommand("normalize   0   800"   );
}

// -------------------------------------------------
// rugged hills
// -------------------------------------------------
function Terrain::rughills::create(%seed)
{
   if(%seed == "")
      %seed = $ME::terrainSeed;

   LS::addCommand("seed " @ %seed      );      
   LS::addCommand("terrain 256 .6"      );
   LS::addCommand("normalize 0 600"      );
   LS::addCommand("floor   200 250 0"   );
   LS::addCommand("clamp   5   20"         );
   LS::addCommand("clamp   4   10"         );
   LS::addCommand("clamp   3   5"         );
   LS::addCommand("clamp   2   2"         );
   LS::addCommand("clamp   1   0"         );
   LS::addCommand("normalize   0   800"   );
}
