
function show()
{
   // redefine end frame script
   function Game::EndFrame()
   {
   }
}
show();

function showFPS()
{
   function Game::EndFrame()
   {
	   echo($ConsoleWorld::FrameRate);
   }
}

function showGfxSW()
{
   function Game::EndFrame()
   {
      echo($ConsoleWorld::FrameRate 
       @ " P:" @ $GFXMetrics::EmittedPolys
       @ ", " @ $GFXMetrics::RenderedPolys
       @ " TSU:", $GFXMetrics::textureSpaceUsed);
   }
}
x