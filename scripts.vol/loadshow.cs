#---------------------------------------------------------------------------

//alias( show, set, ConsoleWorld::Echo );
//alias( showGfx, show, '$ConsoleWorld::FrameRate', P:'$GFXMetrics::EmittedPolys','$GFXMetrics::RenderedPolys', C:'$GFXMetrics::RecachedPolys', mspf:'$ConsoleWorld::msecsPerFrame' );
//alias( showGfxSW, show, '$ConsoleWorld::FrameRate', P:'$GFXMetrics::EmittedPolys','$GFXMetrics::RenderedPolys', S:'$GFXMetrics::UsedSpans', TSU:'$GFXMetrics::textureSpaceUsed' );
//alias( showGfxHW, show, '$ConsoleWorld::FrameRate', P:'$GFXMetrics::EmittedPolys','$GFXMetrics::RenderedPolys', NTD:'$GFXMetrics::numTexturesDownloaded', NTS:'$GFXMetrics::numTexturesScavenged', TSU:'$GFXMetrics::textureSpaceUsed', TBD:'$GFXMetrics::textureBytesDownloaded' );
//alias( showTerrain, show, S:'$GridMetrics::VisibleSquares', V:'$GridMetrics::TransformedVertices', P:'$GridMetrics::RenderedPolys' );
//alias( showSfx, show, msTP:'$SFXMetrics::msTimerPeriod', HW:'$SFXMetrics::nHardwareMixed', SW:'$SFXMetrics::nSoftwareMixed', STRM:'$SFXMetrics::nStreaming', STRV:'$SFXMetrics::nStarved', BUF:'$SFXMetrics::nBuffers' );
//alias( showSfx2, show, channels:, '$SFXMetrics::channels' );
//alias( showNet, show, Sent:'$SimRouter::sendCount', '$SimRouter::sendLastSize', '$SimRouter::sendTotalSize', '$SimRouter::sendErrors', Recd:'$SimRouter::recvCount', '$SimRouter::recvLastSize', '$SimRouter::recvTotalSize', '$SimRouter::recvErrors' );
//alias( showITR, show, '$ConsoleWorld::FrameRate', Rendered:, '$ITRMetrics::NumRenderedInteriors', OutsideBits:, '$ITRMetrics::OutsideBits' );
//
//alias( showHercNetServer, set, Herc::netStats, 1 );
//alias( showHercNetGhost, set, Herc::netStats, 3 );
//alias( showHercNetPlayer, set, Herc::netStats, 2 );

#alias showHercNetServer show "player to server last:'$HercNS::last' min:'$HercNS::min' max:'$HercNS::max' avg:'$HercNS::avg' count'$HercNS::count'"
#alias showHercNetGhost  show "server to ghosts last:'$HercNS::last' min:'$HercNS::min' max:'$HercNS::max' avg:'$HercNS::avg' count'$HercNS::count'"

#---------------------------------------------------------------------------


