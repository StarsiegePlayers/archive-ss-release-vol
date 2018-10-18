
function genericDrone(%cargoCount)
{
   #        maxPosAcc  minPosVel  maxForPosVel  maxRevPosVel       (all_m/s)
   dronePos( 25.00,    3.00,      30.00 ,       -25.50);

   #         minRotVel  maxRVSlow  maxRVFast  maxRVTurret        (all_deg/s)
   droneRot( 6.00,      35.00,     25.00,     65.00);

   #          sphOffstX  sphOffstY  sphOffstZ  sphereRad
   droneColl( 0.0,       0.0,       6.9,       7);

   #          TreadAnim_Rot_Coeff  Tread_Anim_Pos_Coeff
   droneAnim( 2.0,                 0.25);

   #          engine_sound_tag       has_thrusters
   droneSound( IDSFX_TANK_ENGINE_1,  TRUE);

   newMountPoint(0, M, Body, Engine);
   newMountPoint(1, M, Body, Reactor);

   #            Internal     Components
   #            id           type          parent  max_dmg  identity_tag
   newComponent(LeftServos,  LeftServos,   none,   3000.0,   IDCOM_LEFT_TREAD_SERVOS );
   newComponent(RightServos, RightServos,  none,   3000.0,   IDCOM_RIGHT_TREAD_SERVOS);

   #             External    Components
   #             id          type        parent max_dmg  identity_tag
   newComponent( Body,       Body,       none,  6000.0,  IDCOM_BODY);
   newComponent( LeftTread,  LeftTread,  Body,  3000.0,   IDCOM_LEFT_TREAD);
   newComponent( RightTread, RightTread, Body,  3000.0,   IDCOM_RIGHT_TREAD);
   
   if (%cargoCount > 0)
      { newComponent( CargoA,     CargoA,     Body,  400.0,   IDCOM_CARGOA); }
   if (%cargoCount > 1)
      { newComponent( CargoB,     CargoB,     Body,  400.0,   IDCOM_CARGOB); }

   newConfiguration(LeftServos,  LeftTread,  1);
   newConfiguration(RightServos, RightTread, 1);

   defaultMountables(101, 200);
}}