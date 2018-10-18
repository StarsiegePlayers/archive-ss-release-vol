// -------------------------------------------------
// world types defined here.  
// -------------------------------------------------

// -------------------------------------------------
//goes like this
//$worldTypes[X, type]          = "PlanetName";

//$worldTypes[X, sounds]        = "planetSound();";

//$worldTypes[X, skyname, #]    = "Time of day type";
//$worldTypes[X, palette, #]    = "planet.X.ppl";
//$worldTypes[X, skydml, #]     = IDDML_SKY_PLANET_TOD_TAG;
//$worldTypes[X, panels, #]     = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
//$worldTypes[X, planet, #]     = IDBMP_SKY_PLANET_MOON_TOD_TAG;
//$worldTypes[X, Telly, #]      = "Who Loves Ya, Baby!";
// =================================================


// -------------------------------------------------
// Earth Desert
// -------------------------------------------------
$worldTypes[0, type]            = "Desert";

$worldTypes[0, sounds]          = "desertSounds();";

$worldTypes[0, skyname, 0]      = "Day";
$worldTypes[0, palette, 0]      = "desert.d.ppl";
$worldTypes[0, skydml,  0]      = IDDML_SKY_DESERT_DAY;
$worldTypes[0, panels,  0]      = "4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3";
$worldTypes[0, planet,  0]      = IDBMP_SKY_DESERT_MOON_DAY;

$worldTypes[0, skyname, 1]      = "Twilight";
$worldTypes[0, palette, 1]      = "desert.t.ppl";
$worldTypes[0, skydml,  1]      = IDDML_SKY_DESERT_DUSK;
$worldTypes[0, panels,  1]      = "0,1,2,3,4,5,6,7,6,7,6,7,6,7,6,7";
$worldTypes[0, planet,  1]      = IDBMP_SKY_DESERT_MOON_DUSK;

$worldTypes[0, skyname, 2]      = "Night";
$worldTypes[0, palette, 2]      = "desert.n.ppl";
$worldTypes[0, skydml,  2]      = IDDML_SKY_DESERT_NIGHT;
$worldTypes[0, panels,  2]      = "0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1";
$worldTypes[0, planet,  2]      = IDBMP_SKY_DESERT_MOON_NIGHT;
$worldTypes[0, stars,   2]      = "true";

$worldTypes[0, skyname, 3]      = "Day DustStorm";
$worldTypes[0, palette, 3]      = "desert.d.ppl";
$worldTypes[0, skydml,  3]      = IDDML_SKY_DESERT_DAY;
$worldTypes[0, panels,  3]      = "9,10,9,10,9,10,9,10,9,10,9,10,9,10,9,10";
$worldTypes[0, planet,  3]      = IDBMP_SKY_DESERT_MOON_BDAY;

$worldTypes[0, skyname, 4]      = "Twilight DustStorm";
$worldTypes[0, palette, 4]      = "desert.t.ppl";
$worldTypes[0, skydml,  4]      = IDDML_SKY_DESERT_DUSK;
$worldTypes[0, panels,  4]      = "9,10,11,12,9,10,9,10,9,10,9,10,9,10,9,10";

 
// -------------------------------------------------
// Europa
// -------------------------------------------------
$worldTypes[1, type]            = "Europa";

$worldTypes[1, sounds]          = "europaSounds();";

$worldTypes[1, skyname, 0]      = "Day";
$worldTypes[1, palette, 0]      = "europa.d.ppl";
$worldTypes[1, skydml,  0]      = IDDML_SKY_EUROPA_DAY;
$worldTypes[1, panels,  0]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[1, planet,  0]      = IDBMP_SKY_EUROPA_MOON_DAY;

$worldTypes[1, skyname, 1]      = "Twilight";
$worldTypes[1, palette, 1]      = "europa.t.ppl";
$worldTypes[1, skydml,  1]      = IDDML_SKY_EUROPA_DUSK;
$worldTypes[1, panels,  1]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[1, stars,   1]      = "true";

$worldTypes[1, skyname, 2]      = "Night";
$worldTypes[1, palette, 2]      = "europa.n.ppl";
$worldTypes[1, skydml,  2]      = IDDML_SKY_EUROPA_NIGHT;
$worldTypes[1, panels,  2]      = "1,1,2,3,4,5,1,1,1,1,1,1,1,1,1,1";
$worldTypes[1, planet,  2]      = IDBMP_SKY_EUROPA_MOON_NIGHT;
$worldTypes[1, stars,   2]      = "true";
 
// -------------------------------------------------
// Earth Ice  
// -------------------------------------------------

$worldTypes[2, type]            = "Ice";

$worldTypes[2, sounds]          = "iceSounds();";

$worldTypes[2, skyname, 0]      = "Day";
$worldTypes[2, palette, 0]      = "ice.d.ppl";
$worldTypes[2, skydml,  0]      = IDDML_SKY_ICE_DAY;
$worldTypes[2, panels,  0]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[2, planet,  0]      = IDBMP_SKY_ICE_MOON_DAY;

$worldTypes[2, skyname, 1]      = "Twilight";
$worldTypes[2, palette, 1]      = "ice.t.ppl";
$worldTypes[2, skydml,  1]      = IDDML_SKY_ICE_DUSK;
$worldTypes[2, panels,  1]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[2, planet,  1]      = IDBMP_SKY_ICEMOON_DUSK;

$worldTypes[2, skyname, 2]      = "Night";
$worldTypes[2, palette, 2]      = "ice.n.ppl";
$worldTypes[2, skydml,  2]      = IDDML_SKY_ICE_NIGHT;
$worldTypes[2, panels,  2]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[2, planet,  2]      = IDBMP_SKY_ICE_MOON_NIGHT;
$worldTypes[2, stars,   2]      = "true";
 
$worldTypes[2, skyname, 3]      = "Day Storm";
$worldTypes[2, palette, 3]      = "ice.d.ppl";
$worldTypes[2, skydml,  3]      = IDDML_SKY_ICE_DAY;
$worldTypes[2, panels,  3]      = "5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5";
$worldTypes[2, planet,  3]      = IDBMP_SKY_ICE_MOON_BDAY;
 
$worldTypes[2, skyname, 4]      = "Twilight Storm";
$worldTypes[2, palette, 4]      = "ice.t.ppl";
$worldTypes[2, skydml,  4]      = IDDML_SKY_ICE_DUSK;
$worldTypes[2, panels,  4]      = "5,6,7,8,5,6,7,8,5,6,7,8,5,6,7,8";
 
// -------------------------------------------------
// Mars
// -------------------------------------------------

$worldTypes[3, type]            = "Mars";

$worldTypes[3, sounds]          = "marsSounds();";

$worldTypes[3, skyname, 0]      = "Day";
$worldTypes[3, palette, 0]      = "mars.d.ppl";
$worldTypes[3, skydml,  0]      = IDDML_SKY_MARS_DAY;
$worldTypes[3, panels,  0]      = "0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1";
$worldTypes[3, planet,  0]      = IDBMP_SKY_MARS_MOON_DAY;

$worldTypes[3, skyname, 1]      = "Twilight";
$worldTypes[3, palette, 1]      = "mars.t.ppl";
$worldTypes[3, skydml,  1]      = IDDML_SKY_MARS_DUSK;
$worldTypes[3, panels,  1]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[3, planet,  1]      = IDBMP_SKY_MARS_MOON1_DUSK;

$worldTypes[3, skyname, 2]      = "Night";
$worldTypes[3, palette, 2]      = "mars.n.ppl";
$worldTypes[3, skydml,  2]      = IDDML_SKY_MARS_NIGHT;
$worldTypes[3, panels,  2]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[3, planet,  2]      = IDBMP_SKY_MOON_MOON_NIGHT;
$worldTypes[2, stars,   2]      = "true";

$worldTypes[3, skyname, 3]      = "Day DustStorm";
$worldTypes[3, palette, 3]      = "mars.d.ppl";
$worldTypes[3, skydml,  3]      = IDDML_SKY_MARS_DAY;
$worldTypes[3, panels,  3]      = "3,4,3,4,3,4,3,4,3,4,3,4,3,4,3,4";
$worldTypes[3, planet,  3]      = IDBMP_SKY_MARS_MOON_DAY;

$worldTypes[3, skyname, 4]      = "Twilight DustStorm";
$worldTypes[3, palette, 4]      = "mars.t.ppl";
$worldTypes[3, skydml,  4]      = IDDML_SKY_MARS_DUSK;
$worldTypes[3, panels,  4]      = "6,7,6,7,6,7,6,7,6,7,6,7,6,7,6,7";

// -------------------------------------------------
// Mercury
// -------------------------------------------------

$worldTypes[4, type]            = "Mercury";

$worldTypes[4, sounds]          = "mercurySounds();";

$worldTypes[4, skyname, 0]      = "Day";
$worldTypes[4, palette, 0]      = "mercury.d.ppl";
$worldTypes[4, skydml,  0]      = IDDML_SKY_MERCURY_DAY;
$worldTypes[4, panels,  0]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[4, stars,   0]      = "true";
$worldTypes[4, planet,  0]      = IDBMP_SKY_MERCURY_MOON_DAY;

$worldTypes[4, skyname, 1]      = "Twilight";
$worldTypes[4, palette, 1]      = "mercury.t.ppl";
$worldTypes[4, skydml,  1]      = IDDML_SKY_MERCURY_DUSK;
$worldTypes[4, panels,  1]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[4, stars,   1]      = "true";
$worldTypes[4, planet,  1]      = IDBMP_SKY_MERCURY_MOON_DUSK;

$worldTypes[4, skyname, 2]      = "Night";
$worldTypes[4, palette, 2]      = "mercury.n.ppl";
$worldTypes[4, skydml,  2]      = IDDML_SKY_MERCURY_NIGHT;
$worldTypes[4, panels,  2]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[4, stars,   2]      = "true";
$worldTypes[4, planet,  2]      = IDBMP_SKY_MERCURY_MOON_NIGHT;

// -------------------------------------------------
// Moon      
// -------------------------------------------------

$worldTypes[5, type]            = "Moon";

$worldTypes[5, sounds]          = "moonSounds();";

$worldTypes[5, skyname, 0]      = "Day";
$worldTypes[5, palette, 0]      = "moon.d.ppl";
$worldTypes[5, skydml,  0]      = IDDML_SKY_MOON_DAY;
$worldTypes[5, panels,  0]      = "2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2";
$worldTypes[5, stars,   0]      = "true";
$worldTypes[5, planet,  0]      = IDBMP_SKY_MOON_MOON_DAY;

$worldTypes[5, skyname, 1]      = "Twilight";
$worldTypes[5, palette, 1]      = "moon.t.ppl";
$worldTypes[5, skydml,  1]      = IDDML_SKY_MOON_DUSK;
$worldTypes[5, panels,  1]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[5, stars,   1]      = "true";
$worldTypes[5, planet,  1]      = IDBMP_SKY_MOON_MOON_DUSK;

$worldTypes[5, skyname, 2]      = "Night";
$worldTypes[5, palette, 2]      = "moon.n.ppl";
$worldTypes[5, skydml,  2]      = IDDML_SKY_MOON_NIGHT;
$worldTypes[5, panels,  2]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[5, stars,   2]      = "true";
$worldTypes[5, planet,  2]      = IDBMP_SKY_MOON_MOON_NIGHT;

// -------------------------------------------------
// Pluto     0
// -------------------------------------------------

$worldTypes[6, type]            = "Pluto";

$worldTypes[6, sounds]          = "plutoSounds();";

$worldTypes[6, skyname, 0]      = "Day";
$worldTypes[6, palette, 0]      = "pluto.d.ppl";
$worldTypes[6, skydml,  0]      = IDDML_SKY_PLUTO_DAY;
$worldTypes[6, panels,  0]      = "0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1";
$worldTypes[6, planet,  0]      = IDBMP_SKY_PLUTO_MOON_DAY;
$worldTypes[6, stars,   0]      = "true";

$worldTypes[6, skyname, 1]      = "Twilight";
$worldTypes[6, palette, 1]      = "pluto.t.ppl";
$worldTypes[6, skydml,  1]      = IDDML_SKY_PLUTO_DUSK;
$worldTypes[6, panels,  1]      = "0,1,2,3,4,5,6,6,6,6,6,6,6,6,6,6";
$worldTypes[6, planet,  1]      = IDBMP_SKY_PLUTO_MOON_DUSK;
$worldTypes[6, stars,   1]      = "true";

$worldTypes[6, skyname, 2]      = "Night";
$worldTypes[6, palette, 2]      = "pluto.n.ppl";
$worldTypes[6, skydml,  2]      = IDDML_SKY_PLUTO_NIGHT;
$worldTypes[6, panels,  2]      = "1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1";
$worldTypes[6, planet,  2]      = IDBMP_SKY_PLUTO_MOON_NIGHT;
$worldTypes[6, stars,   3]      = "true";

// -------------------------------------------------
// Earth Temperate
// -------------------------------------------------

$worldTypes[7, type]            = "Temperate";

$worldTypes[7, sounds]          = "temperateSounds();";

$worldTypes[7, skyname, 0]      = "Day";
$worldTypes[7, palette, 0]      = "temperate.d.ppl";
$worldTypes[7, skydml,  0]      = IDDML_SKY_TEMPERATE_DAY;
$worldTypes[7, panels,  0]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[7, planet,  0]      = IDBMP_SKY_TEMPERATE_MOON_DAY;

$worldTypes[7, skyname, 1]      = "Twilight";
$worldTypes[7, palette, 1]      = "temperate.t.ppl";
$worldTypes[7, skydml,  1]      = IDDML_SKY_TEMPERATE_DUSK;
$worldTypes[7, panels,  1]      = "0,1,2,3,4,5,6,7,0,1,2,3,0,1,2,3";
$worldTypes[7, planet,  1]      = IDBMP_SKY_TEMPERATE_MOON_DUSK;

$worldTypes[7, skyname, 2]      = "Night";
$worldTypes[7, palette, 2]      = "temperate.n.ppl";
$worldTypes[7, skydml,  2]      = IDDML_SKY_TEMPERATE_NIGHT;
$worldTypes[7, panels,  2]      = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
$worldTypes[7, planet,  2]      = IDBMP_SKY_TEMPERATE_MOON_NIGHT;
$worldTypes[7, stars,   2]      = "true";

$worldTypes[7, skyname, 3]      = "Day Overcast";
$worldTypes[7, palette, 3]      = "temperate.d.ppl";
$worldTypes[7, skydml,  3]      = IDDML_SKY_TEMPERATE_DAY;
$worldTypes[7, panels,  3]      = "7,8,9,10,7,8,9,10,7,8,9,10,7,8,9,10";
$worldTypes[7, planet,  3]      = IDBMP_SKY_TEMPERATE_MOON_BDAY;

$worldTypes[7, skyname, 4]      = "Twilight Overcast";
$worldTypes[7, palette, 4]      = "temperate.t.ppl";
$worldTypes[7, skydml,  4]      = IDDML_SKY_TEMPERATE_DUSK;
$worldTypes[7, panels,  4]      = "11,12,13,14,11,12,13,14,11,12,13,14,11,12,13,14";
$worldTypes[7, planet,  4]      = IDBMP_SKY_TEMPERATE_MOON_BDUSK;

$worldTypes[7, skyname, 5]      = "Night Overcast";
$worldTypes[7, palette, 5]      = "temperate.n.ppl";
$worldTypes[7, skydml,  5]      = IDDML_SKY_TEMPERATE_NIGHT;
$worldTypes[7, panels,  5]      = "3,4,5,6,3,4,5,6,3,4,5,6,3,4,5,6";

// -------------------------------------------------
// Titan
// -------------------------------------------------

$worldTypes[8, type]            = "Titan";

$worldTypes[8, sounds]          = "titanSounds();";

$worldTypes[8, skyname, 0]      = "Day";
$worldTypes[8, palette, 0]      = "titan.d.ppl";
$worldTypes[8, skydml,  0]      = IDDML_SKY_TITAN_DAY;
$worldTypes[8, panels,  0]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[8, planet,  0]      = IDBMP_SKY_TITAN_MOON0_DAY;

$worldTypes[8, skyname, 1]      = "Twilight";
$worldTypes[8, palette, 1]      = "titan.t.ppl";
$worldTypes[8, skydml,  1]      = IDDML_SKY_TITAN_DUSK;
$worldTypes[8, panels,  1]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[8, planet,  1]      = IDBMP_SKY_TITAN_MOON_DUSK;

$worldTypes[8, skyname, 2]      = "Night";
$worldTypes[8, palette, 2]      = "titan.n.ppl";
$worldTypes[8, skydml,  2]      = IDDML_SKY_TITAN_NIGHT;
$worldTypes[8, panels,  2]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[8, planet,  2]      = IDBMP_SKY_TITAN_MOON_NIGHT;

$worldTypes[8, skyname, 3]      = "Day Cloudy";
$worldTypes[8, palette, 3]      = "titan.d.ppl";
$worldTypes[8, skydml,  3]      = IDDML_SKY_TITAN_DAY;
$worldTypes[8, panels,  3]      = "5,6,7,8,5,6,7,8,5,6,7,8,5,6,7,8";
$worldTypes[8, planet,  3]      = IDBMP_SKY_TITAN_MOON0_BDAY;

$worldTypes[8, skyname, 4]      = "Twilight Cloudy";
$worldTypes[8, palette, 4]      = "titan.t.ppl";
$worldTypes[8, skydml,  4]      = IDDML_SKY_TITAN_DUSK;
$worldTypes[8, panels,  4]      = "6,7,8,9,6,7,8,9,6,7,8,9,6,7,8,9";
$worldTypes[8, planet,  4]      = IDBMP_SKY_TITAN_MOON0_BDUSK;

$worldTypes[8, skyname, 5]      = "Night Cloudy";
$worldTypes[8, palette, 5]      = "titan.n.ppl";
$worldTypes[8, skydml,  5]      = IDDML_SKY_TITAN_NIGHT;
$worldTypes[8, panels,  5]      = "5,6,7,8,5,6,7,8,5,6,7,8,5,6,7,8";

// -------------------------------------------------
// Venus world
// -------------------------------------------------
$worldTypes[9, type]            = "Venus";

$worldTypes[9, sounds]          = "venusSounds();";

$worldTypes[9, skyname, 0]      = "Day";
$worldTypes[9, palette, 0]      = "venus.d.ppl";
$worldTypes[9, skydml,  0]      = IDDML_SKY_VENUS_DAY;
$worldTypes[9, panels,  0]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[9, planet,  0]      = IDBMP_SKY_VENUS_MOON_DAY;

$worldTypes[9, skyname, 1]      = "Twilight";
$worldTypes[9, palette, 1]      = "venus.t.ppl";
$worldTypes[9, skydml,  1]      = IDDML_SKY_VENUS_DUSK;
$worldTypes[9, panels,  1]      = "0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3";
$worldTypes[9, planet,  1]      = IDBMP_SKY_VENUS_MOON_DUSK;

$worldTypes[9, skyname, 2]      = "Night";
$worldTypes[9, palette, 2]      = "venus.n.ppl";
$worldTypes[9, skydml,  2]      = IDDML_SKY_VENUS_NIGHT;
$worldTypes[9, panels,  2]      = "0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1";

$worldTypes[9, skyname, 3]      = "Day Cloudy";
$worldTypes[9, palette, 3]      = "venus.d.ppl";
$worldTypes[9, skydml,  3]      = IDDML_SKY_VENUS_DAY;
$worldTypes[9, panels,  3]      = "5,6,7,8,5,6,7,8,5,6,7,8,5,6,7,8";
$worldTypes[9, planet,  3]      = IDBMP_SKY_VENUS_MOON_DAY0;

$worldTypes[9, skyname, 4]      = "Twilight Cloudy";
$worldTypes[9, palette, 4]      = "venus.t.ppl";
$worldTypes[9, skydml,  4]      = IDDML_SKY_VENUS_DUSK;
$worldTypes[9, panels,  4]      = "5,6,7,8,5,6,7,8,5,6,7,8,5,6,7,8";
$worldTypes[9, planet,  4]      = IDBMP_SKY_VENUS_MOON_BDUSK;

$worldTypes[9, skyname, 5]      = "Night Cloudy";
$worldTypes[9, palette, 5]      = "venus.n.ppl";
$worldTypes[9, skydml,  5]      = IDDML_SKY_VENUS_NIGHT;
$worldTypes[9, panels,  5]      = "2,3,4,5,2,3,4,5,2,3,4,5,2,3,4,5";
$worldTypes[9, planet,  5]      = IDBMP_SKY_VENUS_MOON_NIGHT;

