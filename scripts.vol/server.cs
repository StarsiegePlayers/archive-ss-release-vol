//-------------------------------------------------
//  RC file to load mission
//-------------------------------------------------

// make a server...
newServer();
focusServer();
initializeServer();

// Create network delegate
if ($server::UDPPortNumber == "")
{
   $server::UDPPortNumber = 29001;
}

// NOTE: only one of the ESCSDelegates should be created for the server, but
// you can change which transports it uses (the transports are specified by
// pairs of arguments, the transport type and port #)

%try = 20;
while( %try )
{
   //
   // HERE IS WHERE YOU SPECIFY WHICH TRANSPORT YOU WANT, only one of
   // the three following lines should be uncommented, the default is
   // for TCP/IP only.  They enable both TCP/IP and IPX, IPX only,
   // and TCP/IP only respectively.
   //
   // uncomment the ONE line for the trasport(s) you want:
   //
   
// if (newObject( serverDelegate, ESCSDelegate, true, "IP", $server::UDPPortNumber, "IPX", $server::UDPPortNumber))  // both 
// if (newObject( serverDelegate, ESCSDelegate, true, "IPX", $server::UDPPortNumber))  // IPX only
   if (newObject( serverDelegate, ESCSDelegate, true, "IP", $server::UDPPortNumber))     // TCP/IP only
   {
      echo("SUCCESS on PORT " @ $server::UDPPortNumber);
      %try = 0;
   }
   else
   {
      echo("FAILURE on PORT " @ $server::UDPPortNumber);
      $server::UDPPortNumber = $server::UDPPortNumber + 1;
      echo("TRYING Again on PORT " @ $server::UDPPortNumber);
      %try = %try - 1;
   }
}
newObject( "", SimConsoleScheduler );
newObject( "", ChatDispatcher );

if (isObject(serverDelegate))
{
   $Gui::ServerCreated = true;
   loadMission( $server::Mission );
}
else
{
   $Gui::ServerCreated = false;
   focusClient();
   deleteServer();
   
   if ($CmdLineServer)
   {
      echo( "Could not obtain port number.  Please exit by typing 'quit'." );
   }
   else
   {
      eval($Gui::OnErrScreen);
      clientCursorOn();
      #load up the error dlg
      GuiSendRootMessage( simCanvas, 110004 );
   }
}

# Set up for rendering...
focusClient();
.