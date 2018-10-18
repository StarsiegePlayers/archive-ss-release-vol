$basePath = ".;keymaps;faces;scripts;vehicles;logos;movies;sounds";
if ($CDROM_drive != "")
{
   $basePath = $basePath @ ";"
            @ $CDROM_drive @ "data\\movies;"
            @ $CDROM_drive @ "data\\faces;"
            @ $CDROM_drive @ "data\\logos;"
            @ $CDROM_drive @ "data\\sounds";
}
$consoleWorld::defaultSearchPath = $basePath;
a