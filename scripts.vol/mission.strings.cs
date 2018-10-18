//============================================================================================
// ES Mission Region reserves tags  200,000- 299,999
// 
// *IMPORTANT, PLEASE READ*
//     Do not define SimTag id zero.  Darkstar relies on the fact 
//     that SimTag id zero is never defined.
//
//     The SimTags are grouped into 3 sections: REGION, RESOURCE, and DATA.
//     A REGION holds one more more RESOURCE and DATA sections.
//     Tags in a DATA group will be translated during a foriegn language conversion.
//     Tags in the RESOURCE group will NOT.
//
//============================================================================================

// Mission REGION reserves tags 200,000 - 299,999
IDRGN_BEG_MISSION               = 00200000, "";

// Single Player Mission Descriptions DATA group reserves tags 200,001 - 204,999
//============================================================================================
// HUMAN CAMPAIGN
//============================================================================================

//---------MISSION HA0-------------------------------------------------------------
IDSTR_HA0_TITLE                 = 00206600, "Vulture Duty";
IDSTR_HA0_LOCATION              = 00206601, "Mole Deep";
IDSTR_HA0_CAMPAIGN              = 00206602, "Yoke Offensive";
IDSTR_HA0_DATE                  = 00206603, "28281131";
IDSTR_HA0_SHORTBRIEF            = 00206604, "Finish off a downed Imperial cargo ship.";
IDSTR_HA0_LONGBRIEF             = 00206605, "Rise and shine, duster. We got ourselves a situation. "
                                            @ "\n\nSome of our boys did a half-ass job scorchin' an Imperial Police flyer that was sniffin' around where it shouldn't have been. "
                                            @ "The Lice pilot managed to set down way outta their range, and there's a good chance the pilot saw something he shouldn't have. "
                                            @ "So you got the clean-up job, you roj? Locate and destroy the flyer. One of the Garson tunnels opens near the crash site. "
                                            @ "I'll stay in touch through tactical communications. The Imps have probably scrambled salvage rigs by now, so move quick. "
                                            @ "And keep your ears open to the Imperial radio frequencies. OK, move it out!";   
IDSTR_HA0_MEDIA                 = 00206606, "ha0_briefing.smk";
IDSTR_HA0_DEBRIEF_SUCC          = 00206607, "Not bad! This operation confirms what we've been sayin' about you: You're one helluva pilot."
                                            @ " Seems Mole Command agrees. You're transferred to Harabec's crew. Supposedly Harabec's from Earth."
                                            @ " Heard he was in some kind of trouble there, but he's the man here on Mars. Best field commander in the show. Congrats, duster, you're runnin' with the big dogs now.";
IDSTR_HA0_OBJ1_SHORT            = 00206608, "Destroy Imperial cargo ship at Nav Alpha.";
IDSTR_HA0_OBJ1_LONG             = 00206609, "Destroy the downed Skymule-class cargo ship at Nav Alpha.";
IDSTR_HA0_OBJ1_BMPNAME          = 00206610, "HA0_OBJ1.bmp";

IDSTR_HA0_OBJ2_SHORT            = 00206611, "Return to access tunnel at Nav Bravo.";
IDSTR_HA0_OBJ2_LONG             = 00206612, "When the target ship is destroyed, return to access tunnel at Nav Bravo.";
IDSTR_HA0_OBJ2_BMPNAME          = 00206613, "HA0_OBJ2.bmp";

IDSTR_HA0_OBJ3_SHORT            = 00206614, "Destroy any Imperial resistance.";
IDSTR_HA0_OBJ3_LONG             = 00206615, "Destroy any Imperial patrol units you encounter.";
IDSTR_HA0_OBJ3_BMPNAME          = 00206616, "HA0_OBJ3.bmp";

IDSTR_HA0_DEBRIEF_FAIL          = 00206620, "Mission failure. The Imperials control the crash site. "
                                            @ "\n\nIf you are receiving this and can comply, return to the access tunnel at Nav Bravo."
                                            @ "\n\nRepeat: This mission is a failure....";
IDSTR_HA0_NEXTMISSION           = 00206621, "HA1";
IDSTR_HA0_TCM01                = 00206622, "TAC-COM: Be advised we are picking up enemy movement in your vicinity.";
IDSTR_HA0_TCM02                = 00206623, "TAC-COM: The Imperials have arrived at the crash site. Abandon mission. Return to the access tunnel. "
                                             @ "This mission's a failure.";
IDSTR_HA0_TCM03                = 00206624, "TAC-COM: Area is clear of enemy presence. Return to access tunnel Garson-6-2 Gamma.";
IDSTR_HA0_HCA01                = 00206625, "GUARD DOG ONE: Wolf Patrol, this Guard Dog One. I have a reb vulture coming in. Request immediate assistance!";

//---------MISSION HA1------------------------------------------------------------
IDSTR_HA1_TITLE                 = 00200001, "Flashburn";
IDSTR_HA1_LOCATION              = 00200002, "Syrtis Mountains";
IDSTR_HA1_CAMPAIGN              = 00200003, "Yoke Offensive";
IDSTR_HA1_DATE                  = 00200004, "28282211";
IDSTR_HA1_SHORTBRIEF            = 00200005, "Ambush and destroy an Imperial convoy.";
IDSTR_HA1_LONGBRIEF             = 00200006, "No, I think our best choice is to get the Starbright web in Sector Six on-line..."
                                            @ " \n\nAh, duster! Welcome. I'm Harabec. You can call me Bek. Word is you're pretty hot, so I volunteered you for my strike crew."
                                            @ " Lucky you, huh? Here's the deal: Mole Command's testing some new weapons, and the Imperial Police get to be our guinea pigs."
                                            @ " We're gonna jump an Imp Lice convoy between Pei-Shan and Syrtis City. Strictly hit-and-run -- got it?  See what this new M-FAC"
                                            @ " -- and you -- can do, and then bug out.  We'll take the usual mining routes to the target, outta sight of Imperial scouts."
                                            @ " \n\nOK, systems are green. Let's hit the tunnels!";                                                                 
IDSTR_HA1_MEDIA                 = 00200007, "ha1_briefing.smk";
IDSTR_HA1_DEBRIEF_SUCC          = 00200008, "Not bad, duster...! The M-FAC turned out pretty sweet, and it looks like you might actually deserve your rep."
                                            @ " Imp Security Chief Navarre will blow his capillaries when he sees the reports."    
                                            @ " The rebellion needs good pilots. So do I. You just won yourself a permanent slot in my unit."
                                            @ " \n\nGet some shuteye while you can. My crew stays pretty damn busy.";
IDSTR_HA1_OBJ1_SHORT            = 00200009, "Seek and destroy Imperial convoy.";
IDSTR_HA1_OBJ1_LONG             = 00200010, "Seek and destroy the Imperial convoy. Don't linger to draw reinforcements.";
IDSTR_HA1_OBJ1_BMPNAME          = 00200011, "HA1_obj1.bmp";
IDSTR_HA1_OBJ2_SHORT            = 00200012, "Return to access tunnel when convoy is destroyed.";
IDSTR_HA1_OBJ2_LONG             = 00200013, "Return to the 'Mole' access tunnel after you destroy the convoy.";
IDSTR_HA1_OBJ2_BMPNAME          = 00200014, "HA1_obj2.bmp";
IDSTR_HA1_OBJ3_SHORT            = 00200015, "Destroy all enemies encountered.";
IDSTR_HA1_OBJ3_LONG             = 00200016, "Destroy all enemies you encounter. Let the Lice know we mean business.";
IDSTR_HA1_OBJ3_BMPNAME          = 00200017, "HA1_obj3.bmp";
IDSTR_HA1_OBJ4_SHORT            = 00200018, "Harabec Storm must survive.";
IDSTR_HA1_OBJ4_LONG             = 00200019, "General Storm must survive. Stick close and cover him carefully.";
IDSTR_HA1_OBJ4_BMPNAME          = 00200020, "HA1_obj4.bmp";

IDSTR_HA1_DEBRIEF_FAIL          = 00200021, "Mission failure. The operation's objectives were not completed. The field-test effectively failed.";
IDSTR_HA1_NEXTMISSION           = 00200022, "HA2";

IDSTR_HA1_1IF01 = 00200023, "SKYWASP 4: All units, this is Sky Wasp Four.  We've spotted the pirates heading toward Sector 7-B.";
IDSTR_HA1_1IP01	= 00200024, "THUNDER PATROL: Convoy, this is Thunder Patrol.  We're on the way.  Maintain your signal.";
IDSTR_HA1_1SQ01	= 00200025, "MARY: Bek, this is Mary, I got the convoy on long-range scan.  We'll run into 'em any second now!";
IDSTR_HA1_1SQ02	= 00200026, "MARY: Hey, what's that for?";
IDSTR_HA1_1SQ03	= 00200027, "MARY: What the hell?";
IDSTR_HA1_1SQ04	= 00200028,	"MARY: This one's mine!";
IDSTR_HA1_1SQ05	= 00200029,	"MARY: Yes!  That had to hurt!";
IDSTR_HA1_1SQ06	= 00200030,	"MARY: Aaaaaaagh!";
IDSTR_HA1_2IP01	= 00200031, "LIGHTNING PATROL: Lightning Patrol here, Convoy. We hear you. We're about twelve klicks away.  Hang tight.";
IDSTR_HA1_2IP02 = 00200032,	"LIGHTNING PATOL: Sky Wasp Four, this is Lightning Patrol. We're on 'em.";
IDSTR_HA1_CON01	= 00200033,	"CONVOY: Uhhh - All units, this is Convoy D-B Twelve.  We have pirate pursuers.  Under attack -- please assist!";
IDSTR_HA1_HAR01	= 00200034,	"HARABEC: Let's pick up the pace, or we're going to miss the convoy!";
IDSTR_HA1_HAR02	= 00200035, "HARABEC: Roj that, MFAC is red and hot, and ready to waste some lice!";
IDSTR_HA1_HAR03	= 00200036, "HARABEC: Fire at will! Free Mars!";
IDSTR_HA1_HAR04	= 00200037, "HARABEC: I think we got their attention. Let's move out before their buddies show up.";

//---------MISSION HA2------------------------------------------------------------
IDSTR_HA2_TITLE                  = 00200101, "Stealing Thunder";
IDSTR_HA2_LOCATION               = 00200102, "Old Barsoom";
IDSTR_HA2_CAMPAIGN               = 00200103, "Yoke Offensive";
IDSTR_HA2_DATE                   = 00200104, "28285633";
IDSTR_HA2_SHORTBRIEF             = 00200105, "Infiltrate an Imperial base and disable an Imperial cargo ship before takeoff.";
IDSTR_HA2_LONGBRIEF              = 00200106, "Well, you're prompt, duster. I like that.\n\nHere's the situation: Imperial Security Chief Navarre is "
                                             @ "waiting for a shipment of artillery -- to use on an ... 'infestation of rebels.' So Mole Command wants "
                                             @ "us to 'liberate' this load. The cargo shuttle lands at Old Barsoom Depot. We cripple the shuttle, "
                                             @ "secure the port, and a recovery team carts off the pickings.\n\nEasy enough. We also get to use the new "
                                             @ "cloaking arrays. Don't you just love shaking down this new tech?\n\nGet ready, duster. We scramble in three minutes! "
                                             @ "\n\n\nTACTICAL ADDENDUM:\n\n\x97\tRecommend you install a cloak for this mission. "
                                             @ "Outfit your rig at the Vehicle Depot.\n\n\x97\tThe Skymule-class cargohauler used by the Imperials cannot lift if two "
                                             @ "or more of its corner-mounted thrusters are destroyed.";
IDSTR_HA2_MEDIA                  = 00200107, "HA2_briefing.smk";
IDSTR_HA2_DEBRIEF_SUCC           = 00200108, "Way to hang in there, duster. Mole Command's real pleased about the artillery we snatched. And the cloaks worked better than "
                                             @ "we expected. Opens up new possibilities for Mole Command. The Imp Lice won't see us comin' until way too late. Too bad "
                                             @ "for them, eh?";
IDSTR_HA2_OBJ1_SHORT             = 00200109, "Disable the Imperial Cargo ship at Nav Alpha.";
IDSTR_HA2_OBJ1_LONG              = 00200110, "Locate and disable an Imperial cargo ship at Nav Alpha. Target its thrusters.";
IDSTR_HA2_OBJ1_BMPNAME           = 00200111, "HA2_obj1.bmp";
IDSTR_HA2_OBJ2_SHORT             = 00200112, "Radio the recovery team to unload cargo ship.";
IDSTR_HA2_OBJ2_LONG              = 00200113, "Send a radio message to our recovery team once the target ship is disabled and the area is secure.";
IDSTR_HA2_OBJ2_BMPNAME           = 00200114, "HA2_obj2.bmp";
IDSTR_HA2_OBJ3_SHORT             = 00200115, "Harabec Storm must survive.";
IDSTR_HA2_OBJ3_LONG              = 00200116, "Protect General Storm. His survival is vital to the rebellion.";
IDSTR_HA2_OBJ3_BMPNAME           = 00200117, "HA2_obj3.bmp";
IDSTR_HA2_OBJ4_SHORT             = 00200118, "Destroy all enemies in area.";
IDSTR_HA2_OBJ4_LONG              = 00200119, "Take out any Imp Lice you encounter in the mission zone. There's a lot of payback still coming.";
IDSTR_HA2_OBJ4_BMPNAME           = 00200120, "HA2_obj4.bmp";
IDSTR_HA2_DEBRIEF_FAIL           = 00200121, "Mission failure. The operation failed to seize the cargo for the rebellion.";
IDSTR_HA2_NEXTMISSION            = 00200122, "HA3";
IDSTR_HA2_RECA01                  = 00200123, "RECOVERY TEAM: Scavenger One here. It's not safe yet, boss. Give us the word when you've got things locked down.";
IDSTR_HA2_RECA02                  = 00200124, "RECOVERY TEAM: Roj that, boss. Scavenger One, moving in for pickup.";
IDSTR_HA2_HAR01                   = 00200125, "HARABEC: Let's move, duster! We need to hit the base while that bird's still on the ground!";
IDSTR_HA2_HAR02                   = 00200126, "HARABEC: Hold it. There's a patrol passing up ahead... Let 'em go by. We tangle with 'em, we lose surprise.";
IDSTR_HA2_HAR03                   = 00200127, "HARABEC: So much for surprise! Let 'em have it!";
IDSTR_HA2_HAR04                   = 00200128, "HARABEC: Good. We're clear. C'mon, duster.";
IDSTR_HA2_HAR05                   = 00200129, "HARABEC: They're on to us! You hit the transport. I'll keep the Imps busy!";
IDSTR_HA2_HAR06                   = 00200130, "HARABEC: OK, duster, we own this place. Radio the recovery team.";

//---------MISSION HA3------------------------------------------------------------
IDSTR_HA3_TITLE                  = 00200201, "Diamond in the Rough";
IDSTR_HA3_LOCATION               = 00200202, "Valles Marineris";
IDSTR_HA3_CAMPAIGN               = 00200203, "Yoke Offensive";
IDSTR_HA3_DATE                   = 00200204, "28288804";
IDSTR_HA3_SHORTBRIEF             = 00200205, "Locate an injured rebel pilot and escort her to dropship.";
IDSTR_HA3_LONGBRIEF              = 00200206, "OK, duster, listen up.\n\nOne of our best pilots, a Sergeant Sarah DiMarco, went rabbit south of Valles Marineris. "
                                             @ "She's banged up bad, needs help. The Imps are combing the canyons for her and the Olympian she's riding. "
                                             @ "Odds are DiMarco can't run much longer.\n\nI'm sending you to retrieve her. One of our captured dropships will "
                                             @ "put you down near her last transmission. When you find her, escort her to Nav Bravo and call for a pickup. "
                                             @ "I'd go, but I got another op scheduled. As of now you're my lieutenant, duster. Pick a squadmate if you think you need backup. "
                                             @ "\n\nDon't let me down, duster. DiMarco and I go back a long way.\n\n"
                                             @ "TACTICAL ADDENDUM:\n\n\x97\tUse your satellite map to navigate in the basin.\n\n\x97\tRadioactive isotopes from a blown fission generator have degraded sensor function "
                                             @ "in the area.\n\n\x97\tECM countermeasures are highly recommended.\n\n\x97\tA squadmate is available for support on this mission.";
IDSTR_HA3_MEDIA                  = 00200207, "HA3_Briefing.smk";
IDSTR_HA3_DEBRIEF_SUCC           = 00200208, "Great job ... Lieutenant. You pulled out DiMarco under damn tough conditions. Couldn't have done better myself! And my mission was "
                                             @ "a cakewalk in comparison, from what I hear. And word's spreading through the crews about what you did.\n\nGet some rest, duster. "
                                             @ "Even heroes need their sleep.";
IDSTR_HA3_OBJ1_SHORT             = 00200209, "Search the area near Nav Alpha for DiMarco.";
IDSTR_HA3_OBJ1_LONG              = 00200210, "Head for the basin marked as Nav Alpha on your HUD. Locate DiMarco in her Olympian.";
IDSTR_HA3_OBJ1_BMPNAME           = 00200211, "HA3_OBJ1.bmp";
IDSTR_HA3_OBJ2_SHORT             = 00200212, "Protect DiMarco.";
IDSTR_HA3_OBJ2_LONG              = 00200213, "Keep the Imperials from killing DiMarco. She's a solid pilot, and we don't leave our own behind.";
IDSTR_HA3_OBJ2_BMPNAME           = 00200214, "HA3_OBJ2.bmp";
IDSTR_HA3_OBJ3_SHORT             = 00200215, "Escort DiMarco to Nav Bravo.";
IDSTR_HA3_OBJ3_LONG              = 00200216, "Escort DiMarco to Nav Bravo. Stay alert. Remember that she's injured, and her Herc is probably heavily damaged.";
IDSTR_HA3_OBJ3_BMPNAME           = 00200217, "HA3_OBJ3.bmp";
IDSTR_HA3_OBJ4_SHORT             = 00200218, "Radio dropship from Nav Bravo.";
IDSTR_HA3_OBJ4_LONG              = 00200219, "Once at Nav Bravo, call in for pickup. Your dropship will be standing by.";
IDSTR_HA3_OBJ4_BMPNAME           = 00200220, "HA3_OBJ4.bmp";
IDSTR_HA3_OBJ5_SHORT             = 00200221, "Destroy all enemies in area.";
IDSTR_HA3_OBJ5_LONG              = 00200222, "Destroy any Imperials you encounter in the area. If you pop them fast, they can't find DiMarco before you do.";
IDSTR_HA3_OBJ5_BMPNAME           = 00200223, "HA3_OBJ5.bmp";
IDSTR_HA3_DEBRIEF_FAIL           = 00200224, "Mission failure. You didnt rescue DiMarco in time. She's doubtless being tortured to death by the Imperials even now. Poor kid.";
IDSTR_HA3_NEXTMISSION            = 00200225, "HA4";
IDSTR_HA3_OLY01                   = 00200230, "DIMARCO: Hello? DiMarco here. Boy, am I glad to see you... "
                                             @ "hurt pretty bad... dizzy... low on ammo... We better get out while "
                                             @ "we can. More 'a those Imps are slinkin' aroud here, a lot more...";
IDSTR_HA3_OLY02                   = 00200231, "DIMARCO: Hey--Watch your fire!";
IDSTR_HA3_OLY03                   = 00200232, "DIMARCO: Gods--! OK, then, that's how it is...!";
IDSTR_HA3_OLY04                   = 00200233, "DIMARCO: Can't take much more, boss!";
IDSTR_HA3_OLY05                   = 00200234, "DIMARCO: Ahhh, crap!  I don't need this...!";
IDSTR_HA3_OLY06                   = 00200235, "DIMARCO: I'm havin' a bad night...!";
IDSTR_HA3_1DS01                   = 00200236, "DROPSHIP: Roj that, boss. On my way to Nav Bravo.";
IDSTR_HA3_1DS02                   = 00200237, "DROPSHIP: No way, boss. Too many Imps down there.";
IDSTR_HA3_1DS03                   = 00200238, "DROPSHIP: Negative, Lieutenant... That'd be suicide right now.";
IDSTR_HA3_1DS04                   = 00200239, "DROPSHIP: Sorry boss. Too hot for this bus.";
IDSTR_HA3_1DS05                   = 00200240, "DROPSHIP: OK, people. Transport is putting down. C'mon in. We'll take you home.";

//---------MISSION HA4------------------------------------------------------------
IDSTR_HA4_TITLE                 = 00200301, "Operation Jailbreak";
IDSTR_HA4_LOCATION              = 00200302, "Outskirts of Victoria";
IDSTR_HA4_CAMPAIGN              = 00200303, "Yoke Offensive";
IDSTR_HA4_DATE                  = 00200304, "28293006";
IDSTR_HA4_SHORTBRIEF            = 00200305, "Destroy base defenses and recover Predator.";
IDSTR_HA4_LONGBRIEF             = 00200306, "Get ready to scramble, Lieutenant. Two days ago, the Imp Lice stumbled onto an old airfield. Their timing sucked. "
                                            @ "We were using that field for the trial runs of our grav tank, the Predator, so the Imps captured the Predator "
                                            @ "and its advanced technology.\n\nBut you're gonna get it back for us, duster. Intel tracked the Predator to an "
                                            @ "Imperial base near Victoria. Site's heavily fortified, so we're sending some of the artillery we swiped at "
                                            @ "Barsoom. I recommend you outfit to paint the base defenses for the big guns. Pound it up good, then go in "
                                            @ "and clean out any leftover Lice. The recovery boys will do the rest.\n\n\nTACTICAL ADDENDUM:\n\n\x97\tEquip your "
                                            @ "rig with the LTADS component to enable you to spot targets for artillery.\n\n\x97\tThe Imperials will try to use the communications "
                                            @ "tower to call in reinforcements. Recommend you target it early.";
IDSTR_HA4_MEDIA                 = 00200307, "ha4_briefing.smk";
IDSTR_HA4_DEBRIEF_SUCC          = 00200308, "Well, I don't mind tellin' you, Mole Command was sweatin' bullets. But you got the Predator back before the Imperials "
                                            @ "figured out what they had. Mole Command's happy. Techboys are happy. I'm happy.\n\nCongrats for a job well done, duster. "
                                            @ "I knew we could count on you.";
IDSTR_HA4_OBJ1_SHORT            = 00200309, "Use LTADS to spot and destroy turrets.";
IDSTR_HA4_OBJ1_LONG             = 00200310, "Use LTADS to spot for artillery in order to destroy base defenses.";
IDSTR_HA4_OBJ1_BMPNAME          = 00200311, "HA4_obj1.bmp";
IDSTR_HA4_OBJ2_SHORT            = 00200312, "Destroy comm tower.";
IDSTR_HA4_OBJ2_LONG             = 00200313, "Destroy the communications tower located at the base, before the Imperials call in heavy reinforcements.";
IDSTR_HA4_OBJ2_BMPNAME          = 00200314, "HA4_obj2.bmp";
IDSTR_HA4_OBJ3_SHORT            = 00200315, "Prevent the hangers from being destroyed.";
IDSTR_HA4_OBJ3_LONG             = 00200316, "Protect the hangers that may house the Predator. We need to recapture it intact.";
IDSTR_HA4_OBJ3_BMPNAME          = 00200317, "HA4_obj3.bmp";
IDSTR_HA4_OBJ4_SHORT            = 00200318, "Secure base for recovery.";
IDSTR_HA4_OBJ4_LONG             = 00200319, "Secure the base located at Nav Bravo so a recovery team can retrieve the Predator.";
IDSTR_HA4_OBJ4_BMPNAME          = 00200320, "HA4_obj4.bmp";
IDSTR_HA4_OBJ5_SHORT            = 00200321, "Destroy all enemy resistance.";
IDSTR_HA4_OBJ5_LONG             = 00200322, "Destroy all Imperial units you encounter in the course of the operation.";
IDSTR_HA4_OBJ5_BMPNAME          = 00200323, "HA4_obj5.bmp";
IDSTR_HA4_DEBRIEF_FAIL          = 00200324, "Mission failure. The Predator was not recovered. The rebellion has lost an irreplaceable asset.";
IDSTR_HA4_NEXTMISSION           = 00200325, "HA5";
IDSTR_HA4_TCM01                 = 00200326, "TAC-COM: Jailbreaker, this is TAC-COM.  Area secure for Predator recovery.";
IDSTR_HA4_REC01                 = 00200327, "JAILBREAKER: Roj that, TAC-COM.  Jailbreaker coming to pick up our baby.";
IDSTR_HA4_IPA01                 = 00200328, "IMPERIAL: This is Blue Patrol. We have acquired the spotter.  Engaging now.";
IDSTR_HA4_ASC01                 = 00200329, "ARTILLERY SERGEANT: Scouts say they're blowing hangars, Striker One! Move it before they destroy the Predator!";

//---------MISSION HA5------------------------------------------------------------
IDSTR_HA5_TITLE                  = 00200401, "Under The Gun";
IDSTR_HA5_LOCATION               = 00200402, "Tharsis City";
IDSTR_HA5_CAMPAIGN               = 00200403, "Yoke Offensive";
IDSTR_HA5_DATE                   = 00200404, "28293103";
IDSTR_HA5_SHORTBRIEF             = 00200405, "Retrieve rebel fugitives from safehouse.";
IDSTR_HA5_LONGBRIEF              = 00200406, "Political problems here, duster. Too many people have doubts about me after finding out I used "
                                            @"to be an Imperial Knight. So I have to give you my strike crew. Take care of 'em, huh?\n\nOK...Routine op today: "
                                            @"\n\nSome of our people made it to a safehouse in a residential node of Tharsis City.  Just slip in and bring 'em home. "
                                            @"There's an access tunnel near the node, part of the old Starbright network. Use it.\n\nGood luck, Striker One. "
                                            @"Bring my crew back alive, you roj?\n\n\nTACTICAL ADDENDUM:\n\n\x97\tYou are authorized to recruit a full squad if you desire. "
                                            @"\n\n\x97\tSignal for the convoy to follow you by pressing Shift-F1 on your command console.\n\n\x97\tTo locate the rebel safehouse, "
                                            @ "you will have to scan a number of locations. To scan a building, target it and press \"I\" on your console.";
IDSTR_HA5_DEBRIEF_SUCC           = 00200408, "Christ and Hunter, that was a mess! Amazing you made it outta there, duster. Stay cool, OK? I got medics standing by. "
                                            @"\n\nBastards. We'll pay 'em back. I promise.\n\nBy the way, the rumors are true. My brother Caanon's on his way to Mars "
                                            @"with an Imperial strikeforce...and he's good. Real good. So watch your six.";
IDSTR_HA5_MEDIA                  = 00200409, "ha5_briefing.smk";
IDSTR_HA5_OBJ1_SHORT             = 00200410, "Scan the safehouse near Nav Alpha.";
IDSTR_HA5_OBJ1_LONG              = 00200411, "Scan the safehouse near Nav Alpha to locate the rebel fugitives.";
IDSTR_HA5_OBJ1_BMPNAME           = 00200412, "HA5_Obj1.bmp";
IDSTR_HA5_OBJ2_SHORT             = 00200413, "Call in the rescue convoy.";
IDSTR_HA5_OBJ2_LONG              = 00200414, "Call in the rescue convoy once you've found the safehouse.";
IDSTR_HA5_OBJ2_BMPNAME           = 00200415, "HA5_Obj2.bmp";
IDSTR_HA5_OBJ3_SHORT             = 00200416, "Evacuate the fugitives.";
IDSTR_HA5_OBJ3_LONG              = 00200417, "Evacuate the fugitives once you've found them. They'll probably be a bit shaken up.";
IDSTR_HA5_OBJ3_BMPNAME           = 00200418, "HA5_Obj3.bmp";
IDSTR_HA5_OBJ4_SHORT             = 00200419, "Return with convoy and fugitives to the access tunnel.";
IDSTR_HA5_OBJ4_LONG              = 00200420, "Escort the convoy and fugitives back to the access tunnel. Reassure them we don't abandon our own.";
IDSTR_HA5_OBJ4_BMPNAME           = 00200421, "HA5_Obj4.bmp";
IDSTR_HA5_OBJ5_SHORT             = 00200422, "Protect the convoy's retreat to Nav Bravo.";
IDSTR_HA5_OBJ5_LONG              = 00200423, "Cover the convoy as it retreats to Nav Bravo.";
IDSTR_HA5_OBJ5_BMPNAME           = 00200424, "HA5_Obj5.bmp";
IDSTR_HA5_DEBRIEF_FAIL           = 00200425, "Mission failure. The Imperial trap succeeded in destroying the convoy.";
IDSTR_HA5_CNL1                   = 00200426, "CONVOY LEADER: Boss, I got a baaad feeling about this...";
IDSTR_HA5_CNL2                   = 00200427, "CONVOY LEADER: Where the hell is everyone?";
IDSTR_HA5_CNL3                   = 00200428, "CONVOY LEADER: Jeez, is that scan right, boss? They're all DEAD!";
IDSTR_HA5_CNL4                   = 00200429, "CONVOY LEADER: It's a trap! Head for the tunnels!";
IDSTR_HA5_CNL5                   = 00200430, "CONVOY LEADER: Keep moving, everyone! Go!";
IDSTR_HA5_CNL6                   = 00200431, "CONVOY LEADER: TAC-COM, open the blast doors! My scanner's crawlin' with Imps!";
IDSTR_HA5_TRK1                   = 00200432, "CONVOY LEADER: Damn it! They killed Kat!";
IDSTR_HA5_TRK2                   = 00200433, "CONVOY LEADER: Shells everywhere! We'll never make it!";
IDSTR_HA5_SCN1                   = 00200434, "Abandoned Building";
IDSTR_HA5_SCN2                   = 00200435, "Rebel Safehouse";

IDSTR_HA5_NEXTMISSION            = 00200499, "HA6";


//---------MISSION HA6------------------------------------------------------------
IDSTR_HA6_TITLE                  = 00200501, "Beheading the Snake";
IDSTR_HA6_LOCATION               = 00200502, "Carter Flats";
IDSTR_HA6_CAMPAIGN               = 00200503, "Yoke Offensive";
IDSTR_HA6_DATE                   = 00200504, "28295068";
IDSTR_HA6_SHORTBRIEF             = 00200505, "Take out the Imperial Police base at Carter Flats.";
IDSTR_HA6_DEBRIEF_SUCC           = 00200506, "Well, duster, we did it. We won. Mars is now a free world.\n\nThere's a few pockets of Imperial Police left -- "
                                             @ "but they'll keep. Don't party too hard, hey? Caanon's going to be here soon, and the Knights "
                                             @ "are no way soft like the Imp Lice.\n\nBut hell, that's tomorrow!  Tonight -- I'm breakin' out that scotch "
                                             @ "we liberated in Victoria! Let's celebrate!";
IDSTR_HA6_MEDIA                  = 00200507, "ha6_briefing.smk";
IDSTR_HA6_LONGBRIEF              = 00200508, "Time to cut the head off the snake, duster.\n\nNavarre's holed up at his HQ at Carter Flats. We've "
                                             @ "shelled it for the past fifty hours. The Lice are dug in, waiting "
                                             @ "for reinforcements from Melas and Ophir, so I want to finish this now.\n\nYou're it, Striker "
                                             @ "One. Take your crew in and blast out what's left of the defensive turrets. Just paint "
                                             @ "targets and let the artillery do the work.\n\nWatch for mines. We already lost some recon units "
                                             @ "to proximity charges. When you've secured the compound, find Navarre.\n\nLet's take this murderer down."
                                             @ "\n\n\nTACTICAL ADDENDUM:\n\n\x97\tYou will need to equip your rig with the LTADS component in order to spot targets for artillery.";
IDSTR_HA6_OBJ1_SHORT             = 00200509, "Take out remaining defense turrets.";
IDSTR_HA6_OBJ1_LONG              = 00200510, "Take out the remaining defense turrets to open the base to a final assault.";
IDSTR_HA6_OBJ1_BMPNAME           = 00200511, "HA6_Obj1.bmp";
IDSTR_HA6_OBJ2_SHORT             = 00200512, "Destroy all Imperial defenders.";
IDSTR_HA6_OBJ2_LONG              = 00200513, "Destroy all Imperial units you encounter protecting the base. This needs to be a final victory.";
IDSTR_HA6_OBJ2_BMPNAME           = 00200514, "HA6_Obj2.bmp";
IDSTR_HA6_OBJ3_SHORT             = 00200515, "Locate the building Navarre is hiding in.";
IDSTR_HA6_OBJ3_LONG              = 00200516, "Locate Navarre in one of the base buildings. DON'T KILL HIM. Leave the building unharmed. Harabec wants an open trial.";
IDSTR_HA6_OBJ3_BMPNAME           = 00200517, "HA6_Obj3.bmp";
IDSTR_HA6_OBJ4_SHORT             = 00200518, "Locate Imperial weapons cache.";
IDSTR_HA6_OBJ4_LONG              = 00200519, "Locate the Imperial weapons cache at the base. Try to keep it intact. The rebellion will need it later.";
IDSTR_HA6_OBJ4_BMPNAME           = 00200520, "HA6_Obj4.bmp";
IDSTR_HA6_DEBRIEF_FAIL           = 00200521, "Mission failure. The Imperial Police at Carter Flats continue to hold out. Inspired by Navarre's stand, "
                                             @ "other Lice squads have dug in and are fighting that much harder. Doesn't look like we'll "
                                             @ "be able to break them completely before the Knights get here.";                                       
IDSTR_HA6_1AR01                 = 00200522, "ARTILLERY: Roj, boss.  Got your target.";
IDSTR_HA6_2AR01                 = 00200523, "ARTILLERY: Copy that, sir.  Package is in the air.";
IDSTR_HA6_3AR01                 = 00200524, "ARTILLERY: Yes, sir.  Firing away.";
IDSTR_HA6_4AR01                 = 00200525, "ARTILLERY: Target is dogmeat.";
IDSTR_HA6_HCD01                 = 00200526, "GUARD: Gonna watch you burn, dust scum!";
IDSTR_HA6_PTE01 	            = 00200527, "IMPERIAL PATROL-2: Base Command, this is Patrol Two.  We have rebel units on the perimeter.  Moving to intercept.";
IDSTR_HA6_SQA01 	            = 00200528, "IMPERIAL PATROL-9: Dispatch, this is Patrol Nine.  Bogies in Sector seven.  Engaging.";
IDSTR_HA6_SQB01 	            = 00200529, "IMPERIAL PATROL-16: Dispatch, this is Patrol Sixteen.  Hostile signal, Sector four.  Moving in.";
IDSTR_HA6_SQC01                 = 00200530, "IMPERIAL PATROL-5: Dispatch, this is Patrol Five.  Moving to engage reb units.";
IDSTR_HA6_TCM01 	            = 00200531, "TAC-COM: Striker One, this is TAC-COM.  Artillery is ready to acquire targets.";
IDSTR_HA6_TCM02 	            = 00200532, "TAC-COM: All units, this is TAC-COM.  The op is successful.  Move in for the kill";

IDSTR_HA6_NEXTMISSION            = 00200552, "hb1";
//---------MISSION HB1------------------------------------------------------------
IDSTR_HB1_TITLE                  = 00200601, "Imperial Retaliation";
IDSTR_HB1_LOCATION               = 00200602, "Ophir Station";
IDSTR_HB1_CAMPAIGN               = 00200603, "Imperial Retaliation";
IDSTR_HB1_DATE                   = 00200604, "28297899";
IDSTR_HB1_SHORTBRIEF             = 00200605, "Stop the advancing Imperial Knights from taking Ophir Station.";
IDSTR_HB1_LONGBRIEF              = 00200606, "Well. As forewarned, Lieutenant, we're screwed.\n\nCaanon just waltzed right through Arabia Province. "
                                             @ "Tore up our crews like cheap cloth. Christ and Hunter...! Sounds like the Knights "
                                             @ "compensated for our cloaks. That's bad.\n\nTime to turn it around. We're ordering a "
                                             @ "massive counterattack. We'll drop your crew at Ophir. It's gonna get pretty hot there.\n\n"
                                             @ "Remember: These are Knights. Imperial elite. Best equipment. Best training. Don't count on "
                                             @ "cache technology giving you the edge. It's all about guts now. So fight smart, my friend. "
                                             @ "Fight like the devil himself. Otherwise, we are history.";                                        
IDSTR_HB1_MEDIA                  = 00200613, "HB1_briefing.smk";
IDSTR_HB1_DEBRIEF_SUCC           = 00200614, "Heya, duster. At this point, your crew's one of the few bright spots. Caanon's rolling us up all across Mars. "
                                             @ "\n\nDamn it! I should have taken him out while I had the chance...!\n\nNo great advice from me. "
                                             @ "Just keep your head down, and kill everything that moves -- you roj?\n\nIt ain't over 'til it's over.";
IDSTR_HB1_OBJ1_SHORT             = 00200615, "Head to Ophir Station at Nav Alpha.";
IDSTR_HB1_OBJ1_LONG              = 00200616, "Proceed to Ophir Station at Nav Alpha.";
IDSTR_HB1_OBJ1_BMPNAME           = 00200617, "HB1_Obj1.bmp";
IDSTR_HB1_OBJ2_SHORT             = 00200618, "Defend Ophir Station.";
IDSTR_HB1_OBJ2_LONG              = 00200619, "Defend Ophir Station from the Knight squads leading the assault there. We need to break the Teddy momentum.";
IDSTR_HB1_OBJ2_BMPNAME           = 00200620, "HB1_Obj2.bmp";
IDSTR_HB1_OBJ3_SHORT             = 00200621, "Protect friendly units at Ophir Station.";
IDSTR_HB1_OBJ3_LONG              = 00200622, "Protect any friendly units at Ophir Station. We're not leaving anyone to the Icehawk's mercy.";
IDSTR_HB1_OBJ3_BMPNAME           = 00200623, "HB1_Obj3.bmp";
IDSTR_HB1_DEBRIEF_FAIL           = 00200627, "Mission failure. The Knights control Ophir now. We lost Melas as well, so the Imperials were able to trap a "
                                              @ "large number of our forces in the north Valles area. Our counteroffensive was a complete disaster. We're finished.";
IDSTR_HB1_DRP01                  = 00200628, "DROPSHIP: This is as close as I can get ya without gettin' squikked, boss. Good luck.";
IDSTR_HB1_RHD01                  = 00200629, "SLIWINSKI: Glad to see you, boss. I'm the last one left... my crew... is dead. These Knights are killers...!";
IDSTR_HB1_RHD02                  = 00200630, "SLIWINSKI: Help! I need a little help here!";
IDSTR_HB1_TCM01                  = 00200631, "TAC-COM: Striker One, this is TAC-COM. The Melas front just disintegrated. Sliwinski's crew is gone.";
IDSTR_HB1_TCM02                  = 00200632, "TAC-COM: This is TAC-COM. Hostiles eliminated in Ophir region. Good work, Striker One. At least we held 'em here.";
IDSTR_HB1_NEXTMISSION            = 00200664, "HB3";



//---------MISSION HB3------------------------------------------------------------
IDSTR_HB3_TITLE                  = 00200801, "Hunting the Icehawk";
IDSTR_HB3_LOCATION               = 00200802, "Mole Deep";
IDSTR_HB3_CAMPAIGN               = 00200803, "Imperial Retaliation";
IDSTR_HB3_DATE                   = 00200804, "28301411";
IDSTR_HB3_SHORTBRIEF             = 00200805, "Destroy Imperial Landing Zone.";
IDSTR_HB3_LONGBRIEF              = 00200806, "Stand to, duster! Something's up! "
                                           @ "\n\nImperial dropships are lifting all over Mars. Knights seem to be pulling out. "
                                           @ "God knows why.  We both know they're practically knockin' on our door. "
                                           @ "\n\nOur crews are exhausted, but we've got to take advantage of this.... Whatever's up, right "
                                           @ "now the Knights are spread thin. Caanon's exposed out there, and I'm going hunting. "
                                           @ "\n\nThere's a Knight LZ near your position. Take it out. Deny my brother access to that escape route. "
                                           @ "Caanon's not getting away from us this time.";
IDSTR_HB3_MEDIA                  = 00200807, "HB3_briefing.smk";
IDSTR_HB3_DEBRIEF_SUCC           = 00200808, "Sorry to spoil your party, duster. I thought capturing Caanon "
                                           @ "and his damn Knights meant victory, too.... But the Fleet's gone. "
                                           @ "The Emperor ordered it back to Earth. I know Petresun; he wouldn't "
                                           @ "abandon Caanon except for one thing. "
                                           @ "Add it up, duster: Fleet gone, Omni-Web splashed, TDF radio frequencies jammed... "
                                           @ "\n\nCybrids. They're back.  "
                                           @ "\n\nCaanon and I are negotiating. We'll let you know more ... when I do. Out.";
IDSTR_HB3_OBJ1_SHORT             = 00200809, "Secure the Imperial landing facilities at Nav Charlie.";
IDSTR_HB3_OBJ1_LONG              = 00200810, "Proceed to Nav Charlie and secure the Imperial landing facilities there against Caanon Weathers using that escape route.";
IDSTR_HB3_OBJ1_BMPNAME           = 00200811, "HB3_OBJ1.bmp";
IDSTR_HB3_OBJ2_SHORT             = 00200812, "Destroy any resistance you encounter.";
IDSTR_HB3_OBJ2_LONG              = 00200813, "Take advantage of the confusion and destroy any Imperial units you encounter.";
IDSTR_HB3_OBJ2_BMPNAME           = 00200814, "HB3_OBJ2.bmp";
IDSTR_HB3_OBJ3_SHORT             = 00200815, "Eliminate transport ships to impede enemy evacuation.";
IDSTR_HB3_OBJ3_LONG              = 00200816, "Shoot down transport ships to hinder the Imperial evacuation. Add to the enemy's confusion.";
IDSTR_HB3_OBJ3_BMPNAME           = 00200817, "HB3_OBJ3.bmp";
IDSTR_HB3_DEBRIEF_FAIL           = 00200818, "Mission failure. The target area was not secured. The Icehawk was able to reach a dropship and escape.";
IDSTR_HB3_NEXTMISSION            = 00200819, "HB4";
IDSTR_HB3_ISA01	               = 00200820, "KNIGHT-A:	Thunderbird, we have rebs on the perimeter.  Moving to intercept.";
IDSTR_HB3_KNI01	               = 00200821, "KNIGHT-B:	The dustrats are coming in fast.  Let's take 'em out.";
IDSTR_HB3_BPT01                  = 00200822, "KNIGHT-C: Acknowledged!  We are moving to intercept the rebs.  Get those drop ships out!";

//---------MISSION HB4------------------------------------------------------------
IDSTR_HB4_TITLE                  = 00200901, "Dust to Dust";
IDSTR_HB4_LOCATION               = 00200902, "Haldane Station";
IDSTR_HB4_CAMPAIGN               = 00200903, "Imperial Retaliation";
IDSTR_HB4_DATE                   = 00200904, "28302335";
IDSTR_HB4_SHORTBRIEF             = 00200905, "Hold off a Cybrid invasion at Haldane Station while Mars is evacuated.";
IDSTR_HB4_LONGBRIEF              = 00200906, "Time to bury our grudges, duster. Caanon and his Knights have agreed to an alliance. They're on our side now.\n\n"
                                            @"Let's not kid ourselves. Mars is doomed. The Cybrids are coming down in waves. We have a plan that may preserve humanity, "
                                            @"but we gotta get to Titan. The TDF spaceport there has what we need. We're takin' everyone we can, packin' 'em into "
                                            @"long-haul ore freighters at Phobos Orbital.\n\nStriker One, I need you to cover the evac at Haldane. I'll do the same at Tharsis. "
                                            @"Caanon will ride herd on aerospace ops.\n\nA lot of good people will be in your hands, my friend. Protect the convoys and hold "
                                            @"the glitches off as long as you can. Then get out!\n\nDon't be a dead hero, you roj?";
IDSTR_HB4_MEDIA                  = 00200907, "HB4_briefing.smk";
IDSTR_HB4_DEBRIEF_SUCC           = 00200908, "At ease, Lieutenant. This is Caanon Weathers. Let's forget the niceties.\n\nThe Cybrids have sewn up Mars. Ours was the last ship off-planet. "
                                            @"We know this much: The Cybrids hit Mercury first and destroyed the TDF bases there. Venus and Luna still hold out, but probably not for long. "
                                            @"Cybrids are actually landing on Earth...in what appears to be overwhelming numbers.\n\nThe war may already be... lost. Dismissed.";
IDSTR_HB4_OBJ1_SHORT             = 00200909, "Protect the convoy.";
IDSTR_HB4_OBJ1_LONG              = 00200910, "Protect the convoy from Cybrid attackers.";
IDSTR_HB4_OBJ1_BMPNAME           = 00200911, "HB4_obj1.bmp";
IDSTR_HB4_OBJ2_SHORT             = 00200912, "Escort convoy to Nav Bravo.";
IDSTR_HB4_OBJ2_LONG              = 00200913, "Escort the convoy to the cargo pickup location at Nav Bravo. Deploy to prevent the Cybrids from picking off transports before the convoy gets up to speed.";
IDSTR_HB4_OBJ2_BMPNAME           = 00200914, "HB4_Obj2.bmp";
IDSTR_HB4_OBJ3_SHORT             = 00200915, "Escort the convoy to Nav Charlie.";
IDSTR_HB4_OBJ3_LONG              = 00200916, "Escort the convoy to Nav Charlie. Hope there's a pickup there.";
IDSTR_HB4_OBJ3_BMPNAME           = 00200917, "";
IDSTR_HB4_OBJ4_SHORT             = 00200918, "Use Thumpers to clear escape route.";
IDSTR_HB4_OBJ4_LONG              = 00200919, "Hammertanks have been deployed to assist you. Use them to hold an escape route for the convoy.";
IDSTR_HB4_OBJ4_BMPNAME           = 00200920, "HB4_Obj3.bmp";
IDSTR_HB4_DEBRIEF_FAIL           = 00200921, "Mission failure. Alliance morale suffered at the loss, but the heroic effort of the Haldane evac crew was never forgotten.";
IDSTR_HB4_CON1                   = 00200922, "CONVOY: Damn it, here come the 'brids! We're not finished loading. Hold 'em off, Striker One!";                                                                                               
IDSTR_HB4_CON2                   = 00200923, "CONVOY: Striker One, this is Convoy Leader. We're full up and movin' out to Nav Bravo!";                                                                                             
IDSTR_HB4_CON3                   = 00200924, "CONVOY: They're dropping in everywhere!";                                                                                                            
IDSTR_HB4_DS11                   = 00200925, "DROP SHIP: TAC-COM, Transport is under attack at Nav Bravo. Glitches everywhere - Christ! "
                                             @ "Aborting pickup, TAC-COM! We're bugging out!";                                                                                                  
IDSTR_HB4_CAA1                   = 00200926, "ICEHAWK: Negative, TAC-COM, this is Icehawk in Dropship Nine. We are in the area and are diverting course to extract convoy. "
                                             @ "Direct Striker One to fall back to new coordinates immediately."; 
IDSTR_HB4_CAA2                   = 00200927, "ICEHAWK: TAC-COM, this is Icehawk. We have visual contact with Striker One.";                              
IDSTR_HB4_CAA3                   = 00200928, "ICEHAWK: This is Icehawk, Striker One. Vape these gearheads so we can get the hell out of here.";                                                            
IDSTR_HB4_TCM1                   = 00200929, "TAC-COM: This is TAC-COM, Striker One. The convoy has to finish loading before they can move out.";                
IDSTR_HB4_TCM2                   = 00200930, "TAC-COM: TAC-COM to Ferryboat Six. Roj that. Abort Nav Bravo LZ... Damn!";                                                    
IDSTR_HB4_TCM3                   = 00200931, "TAC-COM: TAC-COM to Striker One. Abort rendezvous at Nav Bravo. Uhh...looks like no ride out... Sorry, duster...";             
IDSTR_HB4_TCM4                   = 00200932, "TAC-COM: Roj that, Icehawk! Striker One, this is TAC-COM. Proceed to Nav Charlie ASAP.";   
IDSTR_HB4_THU1                   = 00200933, "THUMPER PILOT: Boss, sucker those glitches in close. We'll wait for your call before we start bangin'. We're priiimed 'n ready."; 
IDSTR_HB4_THU2                   = 00200934, "THUMPER PILOT: Roj, boss! Hammer time!";                                                                                                  
IDSTR_HB4_THU3                   = 00200935, "THUMPER PILOT: Yeeehaaa! Look at 'em tumble! Chalk up one for the thumpin' cavalry";                                                                                                 
IDSTR_HB4_THU4                   = 00200936, "THUMPER PILOT: Buncha heavy glitches comin' in. Looks like the last stand of the thumpin' cav. Nice knowin' ya.";                     

IDSTR_HB4_NEXTMISSION            = 00200999, "HC1";

//---------MISSION HC1------------------------------------------------------------
IDSTR_HC1_TITLE                  = 00201001, "Guardian Angel";
IDSTR_HC1_LOCATION               = 00201002, "Drachensatem";
IDSTR_HC1_CAMPAIGN               = 00201003, "Human Alliance";
IDSTR_HC1_DATE                   = 00201004, "28302642";
IDSTR_HC1_SHORTBRIEF             = 00201005, "Defend incoming TDF ships from Cybrid attack.";
IDSTR_HC1_LONGBRIEF              = 00201006, "The Alliance is headed for Saturn, but we have something else in mind for you: Commander.\n\n"
                                             @ "TDF survivors from Mercury are running for Venus, with the glitches right on their tail. "
                                             @ "So we're gonna drop onto Venus and cover the TDF landing zones. Caanon will coordinate the "
                                             @ "evac effort, but you'll handle things in the field.\n\nDon't let this promotion "
                                             @ "swell your head, duster, or you'll pop your seals.\n\nNo pressure, huh?"; 
                                             
IDSTR_HC1_MEDIA                  = 00201007, "HC1_Briefing.smk";
IDSTR_HC1_DEBRIEF_SUCC           = 00201008, "I'm Lieutenant Wu. Command's assigned me as your tactical liaison to your team. It's their way of thanking "
                                             @ "you for helping us Teddies out. The Oberwind is quite a ride, isn't it? \n\nWelcome to Venus!";
IDSTR_HC1_OBJ1_SHORT             = 00201009, "Protect dropships.";
IDSTR_HC1_OBJ1_LONG              = 00201010, "Protect the TDF dropships from Cybrid attack as they unload and refuel.";
IDSTR_HC1_OBJ1_BMPNAME           = 00201011, "HC1_Obj1.bmp";

IDSTR_HC1_OBJ2_SHORT             = 00201012, "Protect Drachensatem spaceport.";
IDSTR_HC1_OBJ2_LONG              = 00201013, "Protect Drachensatem spaceport. The Cybrids will try to destroy the facilities as well as the ships.";
IDSTR_HC1_OBJ2_BMPNAME           = 00201014, "HC1_Obj2.bmp";

IDSTR_HC1_OBJ3_SHORT             = 00201015, "Destroy the Cybrid artillery unit.";
IDSTR_HC1_OBJ3_LONG              = 00201016, "Destroy the Cybrid artillery unit that threatens the spaceport.";
IDSTR_HC1_OBJ3_BMPNAME           = 00201017, "HC1_Obj3.bmp";

IDSTR_HC1_OBJ4_SHORT             = 00201018, "Destroy all Cybrids encountered.";
IDSTR_HC1_OBJ4_LONG              = 00201019, "Destroy all Cybrids you encounter. The only good glitch is an offlined glitch.";
IDSTR_HC1_OBJ4_BMPNAME           = 00201020, "HC1_Obj4.bmp";

IDSTR_HC1_WU01                   = 00201021, "TAC-COM: This is TAC-COM, sir.  Your callsign on this op Guardian.  The refugee transports are breaking through the Oberwind now.  Advise extreme caution.  We are picking up Cybrid transmissions in the area.";
IDSTR_HC1_WU02                   = 00201022, "TAC-COM: TAC-COM to Guardian.  Cybrid Artillery located on the hill. Please destroy it before it completes its targeting calibration.";
IDSTR_HC1_WU03                   = 00201023, "TAC-COM: Guardian, this is TAC-COM.  Base is under attack.  Request assistance, sir!";
IDSTR_HC1_DTP01                  = 00201024, "FIREHEEL 5: Fireheel Five on final approach!  We're losing stabilizers!  Breaking up -- wind shear is NUTS ...";
IDSTR_HC1_1DS01                  = 00201025, "YELLOWJANE 2: Yellow Jane Two, hitting the envelope.  Oberwind entry in T minus 4 seconds. Jesus, I hope we have better luck than the last bird!";

IDSTR_HC1_DEBRIEF_FAIL           = 00201074, "Mission failure. The Cybrids devastated the TDF vessels and killed most of the scientists and troopers aboard. Drachensatem also lost a key spaceport. The Cybrids crippled the Alliance mission here.";
IDSTR_HC1_NEXTMISSION            = 00201075, "HC2";

//---------MISSION HC2------------------------------------------------------------
IDSTR_HC2_TITLE                  = 00201101, "Glitch Hunt";
IDSTR_HC2_LOCATION               = 00201102, "Carson";
IDSTR_HC2_CAMPAIGN               = 00201103, "Alliance";
IDSTR_HC2_DATE                   = 00201104, "28304189";
IDSTR_HC2_SHORTBRIEF             = 00201105, "Locate and report position of Cybrid \"Nexus\".";
IDSTR_HC2_LONGBRIEF              = 00201106, "Lieutenant Wu here, Commander.  "
                                           @ "\n\nA base near Carson was taken out by Cybrid forces seven hours ago. "
                                           @ "Radio transmissions indicated that `brids may have had a mobile \"Nexus\" "
                                           @ "of some kind supporting their offensive. TDF experience on Mercury suggests "
                                           @ "that elimination or capture of a \"Nexus\" should be a top priority. "
                                           @ "\n\nWe will drop you near the destroyed base. Your orders are to find "
                                           @ "the Cybrid Nexus and capture it.\n\nIntel believes that all base personnel were "
                                           @ "killed, but I'd ask that you please scan for survivors anyway, sir.\n\nGood luck, Commander! "
                                           @ "\n\n\nTACTICAL ADDENDUM: Intel from Mercury also warns that the Cybrids commonly "
                                           @ "assign heavily-armed escorts to their Nexi. These escorts are relentless. Be sure to destroy "
                                           @ "all Cybrid units you encounter in the vicinity of a Nexus.";
IDSTR_HC2_MEDIA                  = 00201107, "HC2_briefing.smk";
IDSTR_HC2_DEBRIEF_SUCC           = 00201108, "Excellent job, sir!  "
                                           @ "\n\nWe captured the Cybrid Nexus intact ... and our technicians are "
                                           @ "disassembling it for later study. Grand Master Weathers has ordered you to board a dropship "
                                           @ "for Sa Thauri.  Venus is still falling, you see. To ease the pressure -- so to speak -- "
                                           @ "on our other evac efforts, we're going to draw the `brids' fire to Sa Thauri."
                                           @ "\n\nIt's going to get hot, sir.  You'd better rest while you can."; 
IDSTR_HC2_OBJ1_SHORT             = 00201109, "Locate the Cybrid Nexus.";
IDSTR_HC2_OBJ1_LONG              = 00201110, "Locate the Cybrid Nexus.";
IDSTR_HC2_OBJ1_BMPNAME           = 00201111, "HC2_Obj1.bmp";
IDSTR_HC2_OBJ2_SHORT             = 00201112, "Report the position of the Nexus.";
IDSTR_HC2_OBJ2_LONG              = 00201113, "Report the position of the Nexus to TAC-COM. A technical analysis crew will be dispatched to take the thing apart.";
IDSTR_HC2_OBJ2_BMPNAME           = 00201114, "HC2_Obj2.bmp";
IDSTR_HC2_OBJ3_SHORT             = 00201115, "Destroy any units defending the Nexus.";
IDSTR_HC2_OBJ3_LONG              = 00201116, "Destroy any glitches you encounter defending the Nexus. You won't be able to capture the Nexus otherwise.";
IDSTR_HC2_OBJ3_BMPNAME           = 00201117, "HC2_Obj3.bmp";
IDSTR_HC2_OBJ4_SHORT             = 00201118, "Destroy any Cybrid resistance encountered.";
IDSTR_HC2_OBJ4_LONG              = 00201119, "Destroy any Cybrids you encounter. Be prepared to report on the different units you engage. We're still learning about what the 'brids "
                                             @ "have in the field.";
IDSTR_HC2_OBJ4_BMPNAME           = 00201120, "HC2_Obj4.bmp";
IDSTR_HC2_OBJ5_SHORT             = 00201121, "Scan the ruins for survivors.";
IDSTR_HC2_OBJ5_LONG              = 00201122, "Scan the ruins for survivors. Venusian arcologies are tough, and someone might have escaped by finding an intact compartment somewhere. "
                                             @ "Don't leave any humans for the Cybrids to find.";
IDSTR_HC2_OBJ5_BMPNAME           = 00201123, "HC2_Obj5.bmp";
IDSTR_HC2_DEBRIEF_FAIL           = 00201124, "Mission failure. The Nexus escaped. Reports indicate the Cybrids are doubling their protection of these mobile bases. We missed a priceless intelligence opportunity here.";
IDSTR_HC2_NEXTMISSION            = 00201125, "HC3";
IDSTR_HC2_NOM01                  = 00201126, "CARAVAN TRANSMISSION: 	Heya, are we glad to see you!  The 'brids were on us like Lock Rot. "
                                             @ "Scorched the crap from us, burned all the defenses -- then just left, due Southeast.";
IDSTR_HC2_SUR01                  = 00201127, "COMM CENTER TRANSMISSION:	Thank God -- humans!  We're in a bad way here.  Send help.  Please!";
IDSTR_HC2_WU01                   = 00201128, "TAC-COM:	Acknowledged, sir.  TAC-COM will dispatch a rescue team to those coordinates.";
IDSTR_HC2_WU02                   = 00201129, "TAC-COM:	I copy that, sir,  Reinforcements are on the way.  Excellent job, sir!";



//---------MISSION HC3------------------------------------------------------------
IDSTR_HC3_TITLE                 = 00201201, "Ill Wind Blowing";
IDSTR_HC3_LOCATION              = 00201202, "Sa Thauri";
IDSTR_HC3_CAMPAIGN              = 00201203, "Alliance";
IDSTR_HC3_DATE                  = 00201204, "28318699";
IDSTR_HC3_SHORTBRIEF            = 00201205, "Defend the last human-held Venusian outpost from the Cybrids.";
IDSTR_HC3_LONGBRIEF             = 00201206,  "About time, Commander. Pay attention!\n\n The time has come for the Alliance to leave Venus. "
                                             @ "Again, we will be the last evac. Unfortunately, right now we lack a safe exit window "
                                             @ "through the Oberwind. We must hold on until one opens. \n\nTo make our stay more ... comfortable, "
                                             @ "the tech caravans have jury-rigged a defense perimeter using M-FACs we brought from "
                                             @ "Mars. However, they need to make final adjustments before the perimeter goes operational. "
                                             @ "Keep the Cybrids at bay while the caravans do their work.\n\nDismissed."
                                             @ "\n\n\nTACTICAL ADDENDUM:\n\n\x97\tDue to tactical concerns, the caravan tech will deploy to the "
                                             @ "assignments only according to your orders.";
IDSTR_HC3_MEDIA                 = 00201207, "HC3_Briefing.smk";
IDSTR_HC3_DEBRIEF_SUCC          = 00201208, "The M-FACs are on-line. The perimeter is holding. Even better -- it looks as though the Oberwind is "
                                             @ "calming. I believe we will establish an exit corridor within 48 hours, perhaps sooner. See "
                                             @ "you on Titan, soldier.  Dismissed.";
IDSTR_HC3_OBJ1_SHORT            = 00201209, "Defend Sa Thauri from Cybrids.";
IDSTR_HC3_OBJ1_LONG             = 00201210, "Defend Sa Thauri from Cybrid attack while the techs make the last M-FAC adjustments.";
IDSTR_HC3_OBJ1_BMPNAME          = 00201211, "HC3_Obj1.bmp";
IDSTR_HC3_OBJ2_SHORT            = 00201212, "Complete M-FAC turret upgrades.";
IDSTR_HC3_OBJ2_LONG             = 00201213, "Complete M-FAC turret upgrades. Remember that we only have one tech vehicle work-capable. If you lose "
                                            @ "your tech, the turret modifications are finished.";
IDSTR_HC3_OBJ2_BMPNAME          = 00201214, "HC3_Obj2.bmp";
IDSTR_HC3_OBJ3_SHORT            = 00201215, "Defend power generators";
IDSTR_HC3_OBJ3_LONG             = 00201216, "Defend the base's power generators. Without them, the M-FACs are useless.";
IDSTR_HC3_OBJ3_BMPNAME          = 00201217, "HC3_Obj3.bmp";

IDSTR_HC3_POC01                 = 00201218, "CAPTAIN: Guardian, this is Warwolf.  Glad you folks could make it.  We're going to intercept a Cybrid raiding squad East of this location.  You stay here and hold the back door in case some glitches slip by us.  We need those turrets online.";
IDSTR_HC3_POC02                 = 00201219, "CAPTAIN: Warwolf to Guardian.  We have visual on the raiders -- Good Lord, these things are HUGE...!  We'll hold them as long as we can!";
IDSTR_HC3_CAR01                 = 00201220, "REPAIR-ONE: Roj that, Commander.";                                                
IDSTR_HC3_CAR02                 = 00201221, "REPAIR-ONE: Turret is online.";
IDSTR_HC3_CAR03                 = 00201222, "REPAIR-ONE: Goin' as fast as we can, Commander. Just a few more seconds...";                      
IDSTR_HC3_WU01                  = 00201223, "TAC-COM: Commander, this is TAC-COM. The operations center is under attack.";
IDSTR_HC3_WU02                  = 00201224, "TAC-COM: TAC-COM here, sir.  The barracks are under attack.";
IDSTR_HC3_WU03                  = 00201225, "TAC-COM: TAC-COM to Guardian One. Power generators are under attack.";
IDSTR_HC3_DEBRIEF_FAIL          = 00201280, "Mission failure. The Cybrids overran the perimeter and destroyed the arcology. The remaining Alliance troops had nowhere to go but into the acid....";


//---------MISSION HD1------------------------------------------------------------
IDSTR_HD1_TITLE                     = 00201601, "Animal Tenacity";
IDSTR_HD1_LOCATION                  = 00201602, "Eskandani Plain";
IDSTR_HD1_CAMPAIGN                  = 00201603, "Dies Irae";
IDSTR_HD1_DATE                      = 00201604, "28321439";
IDSTR_HD1_SHORTBRIEF                = 00201605, "Defend the launch of the Dies Irae.";
IDSTR_HD1_LONGBRIEF                 = 00201606, "Scramble, duster! It's kick the can time! I'll fill you in. "
                                            @ "\n\nYou know how we hoped the Cybrids would wait for reinforcements? Well, no joy. "
                                            @ "There's multiple glitch signals headed inbound, right for the laser acceleration "
                                            @ "beam we're using to launch the Dies Irae.\n\nAin't we lucky?\n\nWe're spread thin, but "
                                            @ "we are gonna protect that beam! For the sake of the people on those ships, no Cybrid's "
                                            @ "getting through -- Got it? Not one!\n\nNo pressure, huh?";
                                          
IDSTR_HD1_MEDIA                     = 00201607, "HD1_briefing.smk";
IDSTR_HD1_DEBRIEF_SUCC              = 00201608, "Excellent work, Commander. You might have made a decent Knight back on Earth. Status is as follows: "
                                            @ "We broke the back of the Cybrid forces here, and the laser is accelerating the Dies Irae as planned. "
                                            @ "It'll be some time before Cybrid reinforcements arrive and -- excuse me. I have a priority GLORIA "
                                            @ "transmission coming in from the Long Patrol. We'll speak more later. Dismissed.";
IDSTR_HD1_OBJ1_SHORT                = 00201609, "Defend perimeter around Nav Alpha.";
IDSTR_HD1_OBJ1_LONG                 = 00201610, "Prevent Cybrids from breaking through the perimeter at Nav Alpha.";
IDSTR_HD1_OBJ1_BMPNAME              = 00201611, "HD1_obj1.bmp";
IDSTR_HD1_OBJ2_SHORT                = 00201612, "If the perimeter is breached, protect the accelerator beam.";
IDSTR_HD1_OBJ2_LONG                 = 00201613, "Protect the accelerator beam station. It's crucial for the Dies Irae to be able to launch quickly enough to evade "
                                                @ "the Cybrid ships in Titan space.";
IDSTR_HD1_OBJ2_BMPNAME              = 00201614, "HD1_obj2.bmp";
IDSTR_HD1_OBJ3_SHORT                = 00201615, "Defend the escape ships and facilities.";
IDSTR_HD1_OBJ3_LONG                 = 00201616, "If the perimeter is breached, defend the escape ships and facilities as the final preparations are made.";
IDSTR_HD1_OBJ3_BMPNAME              = 00201617, "HD1_obj3.bmp";
IDSTR_HD1_OBJ4_SHORT                = 00201618, "Dies Irae must launch.";
IDSTR_HD1_OBJ4_LONG                 = 00201619, "Dies Irae must launch. Kill as many Cybrids as you can. Plain and simple: It's them or us.";
IDSTR_HD1_OBJ4_BMPNAME              = 00201620, "HD1_obj4.bmp";
IDSTR_HD1_OBJ5_SHORT                = 00201621, "Prevent Cybrids from reaching the base.";
IDSTR_HD1_OBJ5_LONG                 = 00201622, "Prevent the Cybrids from reaching the base. We need to keep our resources intact.";
IDSTR_HD1_OBJ5_BMPNAME              = 00201623, "HD1_obj5.bmp";
IDSTR_HD1_DEBRIEF_FAIL              = 00201624, "Mission failure. The Dies Irae did not launch successfully. The Cybrids destroyed our last hope.";
IDSTR_HD1_NEXTMISSION               = 00201625, "HD2";
IDSTR_HD1_TAC01                      = 00201626, "TAC-COM: Commander, this is TAC-COM.  Where are you?  What's happening, sir?";
IDSTR_HD1_TAC02                      = 00201627, "TAC-COM: Commander, this is TAC-COM!  The glitches are attacking the uplink!";
IDSTR_HD1_TAC03                      = 00201628, "TAC-COM: Dies Irae, this is TAC-COM.  You are green for launch.";
IDSTR_HD1_TAC04                      = 00201629, "TAC-COM: Dies Irae, this is TAC-COM.  T minus ten seconds to launch.";
IDSTR_HD1_TAC05                      = 00201630, "TAC-COM: Five...four...three..two...one....";
IDSTR_HD1_HAR01                      = 00201631, "PHOENIX:  OK, people.  I got the perimeter at Nav Charlie "
                                                 @   "with Lightning squad.  Caanon, you plug the perimeter at Nav Bravo with Zebra Squad.  Duster, you take Nav Alpha.  Good luck, "
                                                 @   "boys and girls.  It's gonna be a party.";                                              
IDSTR_HD1_HAR02                      = 00201632, "PHOENIX: Harabec here.  Nothing going on at Nav Charlie.";
IDSTR_HD1_HAR03                      = 00201633, "PHOENIX: Yo, this is Harabec.  I have bogies at Nav Charlie.";
IDSTR_HD1_CAA01                      = 00201634, "ICEHAWK: Icehawk to Guardian One and Phoenix.  Spy sats just went off-line.  The Cybrids are landing.  Stay focused.";
IDSTR_HD1_CAA02                      = 00201635, "ICEHAWK: Icehawk reporting.  Nav Bravo is clear.";
IDSTR_HD1_CAA03                      = 00201636, "ICEHAWK: TAC-COM, this is Icehawk.  I have hostile contact at Nav Bravo.";

//---------MISSION HD2------------------------------------------------------------
IDSTR_HD2_TITLE                     = 00201701, "Ticket to Ride";
IDSTR_HD2_LOCATION                  = 00201702, "Cinquini Fracture";
IDSTR_HD2_CAMPAIGN                  = 00201703, "Dies Irae";
IDSTR_HD2_DATE                      = 00201704, "28324779";
IDSTR_HD2_SHORTBRIEF                = 00201705, "Commandeer a Cybrid transport.";  
IDSTR_HD2_LONGBRIEF                 = 00201706, "We did better than we thought, Commander. The Cybrids are standing off. "
                                                @ "I don't think they expected much resistance ... from mere animals.\n\nNow: "
                                                @ "The plan is to capture a Cybrid space transport. Your vehicle has been equipped with "
                                                @ "a transmitter set to Cybrid command frequencies, using data from the Nexus we captured "
                                                @ "on Venus. Scouts from a local force called the NTDF are monitoring nearby Cybrid LZs. "
                                                @ "You'll rendezvous with one of their sentries at Nav Alpha.\n\nGet close to a Cybrid "
                                                @ "transport, target it, and use the transmitter. The codes should order the transport "
                                                @ "to fly to the Long Patrol berths at Eskandani...where we will commandeer it. "
                                                @ "\n\nGood luck, Commander.\n\n\nTACTICAL ADDENDUM:\n\n\x97\tYour Cybrid transmitter is a unique "
                                                @ "device. It will take weeks to construct a replacement, so don't allow it to be destroyed before you accomplish "
                                                @ "your objective.";
IDSTR_HD2_MEDIA                     = 00201707, "HD2_briefing.smk";
IDSTR_HD2_DEBRIEF_SUCC              = 00201708, "Sir, the Cybrid ship arrived safely at Eskandani Base. Grand Master Weathers extends his "
                                                @ "apologies for not being here to debrief you.\n\nAlliance Command has been transferred aboard"
                                                @ " the Ambrose Gierling, a Long Patrol corvette in geosynch orbit above Eskandani. Grand Master "
                                                @ "Weathers and his brother are up there now. They've requested your presence immediately, for a "
                                                @ "council of war. The shuttle is waiting, Commander.\n\nThe Gods be with you.";
IDSTR_HD2_OBJ1_SHORT                = 00201709, "Rendezvous with NTDF pilot at Nav Alpha.";
IDSTR_HD2_OBJ1_LONG                 = 00201710, "Rendezvous with the NTDF scout at Nav Alpha. He will update you on the tactical situation.";
IDSTR_HD2_OBJ1_BMPNAME              = 00201711, "HD2_Obj1.bmp";
IDSTR_HD2_OBJ2_SHORT                = 00201712, "Destroy Cybrid communication tower at Nav Bravo.";
IDSTR_HD2_OBJ2_LONG                 = 00201713, "Destroy the Cybrid communication tower at Nav Bravo. We need to disrupt their communications in order to have the best chance of "
                                                @ "pulling this off.";
IDSTR_HD2_OBJ2_BMPNAME              = 00201714, "HD2_Obj2.bmp";
IDSTR_HD2_OBJ3_SHORT                = 00201715, "Use Nexus Transmitter on Cybrid transport. (200m range)";
IDSTR_HD2_OBJ3_LONG                 = 00201716, "Your vehicle is equipped with an experimental Nexus Transmitter. Approach to within 200 meters of the Cybrid transport and trigger the transmitter. "
                                                @ "Doing so will take command of the ship and direct it to a place of our choosing.";
IDSTR_HD2_OBJ3_BMPNAME              = 00201717, "HD2_Obj3.bmp";
IDSTR_HD2_OBJ4_SHORT                = 00201718, "Destroy any Cybrid patrols encountered.";
IDSTR_HD2_OBJ4_LONG                 = 00201719, "Destroy any Cybrid patrols you encounter. Don't let the glitches observe our capture of the ship.";
IDSTR_HD2_OBJ4_BMPNAME              = 00201720, "HD2_Obj4.bmp";
IDSTR_HD2_OBJ5_SHORT                = 00201721, "Defend the captured transport.";
IDSTR_HD2_OBJ5_LONG                 = 00201722, "Once you have used the transmitter, defend the transport against any Cybrid attack. It may take time for the command codes to complete their work.";
IDSTR_HD2_OBJ5_BMPNAME              = 00201723, "HD2_Obj5.bmp";
IDSTR_HD2_DEBRIEF_FAIL              = 00201727, "Mission failure. That transport was our best chance of reaching Prometheus and stopping the Cybrid menace"
                                            @   " at its source.  One of the other squads might have pulled it out, but the odds are against them. You were our best chance.";
IDSTR_HD2_NTD1                      = 00201729, "SGT. CASSELL: NTDF Sergeant Cassell here. Good to see you, Commander.";
IDSTR_HD2_NTD2                      = 00201730, "SGT. CASSELL: I've been watching the glitch LZs on the other side of the hill for hours. About ten minutes ago,"
                                            @   " I saw a toaster dropship land at the Nav Charlie LZ. If you're on the bounce, you can intercept it.";
IDSTR_HD2_NTD3                      = 00201731, "SGT. CASSELL: There's been a lot of action around here... "
                                            @   "I'm glad you're the one going in and not me, sir. Give 'em hell.";
IDSTR_HD2_NTD4                      = 00201732, "SGT. CASSELL: Woooo-hoooo! You did it! Let me escort you to the pickup zone, sir!";
IDSTR_HD2_TCV1                      = 00201733, "TAC-COM: Commander, this is TAC-COM! The transport is getting away!"
                                            @   " Retreat immediately, sir! Repeat: Retreat immediately!";
IDSTR_HD2_TCV2                      = 00201734, "TAC-COM: Yessss! If we survive this...! Ahem..."
                                            @   " We at TAC-COM send our congratulations, Commander. See you back at base.";
IDSTR_HD2_WU03                      = 00201735, "TAC-COM: Sir, sensors indicate the ship is powering up. Estimate 30 seconds to liftoff.";
IDSTR_GEN_WU04                      = 00201736, "TAC-COM: TAC-COM here. There's another wave on the way. Please stay alert, sir.";

IDSTR_HD2_NEXTMISSION               = 00201799, "HE1";


//---------MISSION HE1------------------------------------------------------------
IDSTR_HE1_TITLE                  = 00202101, "A Spear in the Dark";
IDSTR_HE1_LOCATION               = 00202102, "Eskandani Orbital Base (TITAN)";
IDSTR_HE1_CAMPAIGN               = 00202103, "Cardinal Spear";
IDSTR_HE1_DATE                   = 00202104, "28324784";
IDSTR_HE1_SHORTBRIEF             = 00202105, "Use the captured Cybrid transport to drop onto Pluto.";
IDSTR_HE1_LONGBRIEF              = 00202106, "This is it, duster... Our snowball's chance in hell. "
                                           @ "\n\nWith Cybrids almost totally focused on Earth, the Long Patrol dropped a ton of spy drones on Pluto and hit paydirt:  "
                                           @ "\n\nPrometheus. The big glitch itself.  "
                                           @ "\n\nHere's the deal. There's real good chance we can sneak in untouched. "
                                           @ "The techs have figured out how to use the glitch spaceship as a Trojan Horse. "
                                           @ "Our top squads will hit Prometheus in this temple thing on Pluto. The operation name "
                                           @ "is \"Cardinal Spear.\" Hey, it was Caanon's idea. He's the poetic type. "
                                           @ "Listen: We don't have the luxury of retreating to fight another day.\n\nUnderstand me, Cardinal Three? "
                                           @ "We nail Prometheus the first time.";
IDSTR_HE1_MEDIA                  = 00202107, "HE1_briefing.smk";
IDSTR_HE1_DEBRIEF_SUCC           = 00202108, "Thanks for the rescue, Cardinal Three.  I'm... in your debt.  "
                                           @ "\n\nIt seems we are the strikeforce.  We appear to be closest to the targeted DZ.  My scans show no other squadmates.  "
                                           @ "\n\nMurphy's law, eh?  "
                                           @ "\n\nHopefully we'll pick up some help on the way to Prometheus.  We'll need everything we can get.  ";
IDSTR_HE1_OBJ1_SHORT             = 00202109, "Rendezvous with squadmates at Nav Alpha.";
IDSTR_HE1_OBJ1_LONG              = 00202110, "Rendezvous with your squadmates at Nav Alpha.";
IDSTR_HE1_OBJ1_BMPNAME           = 00202111, "HE1_Obj1.bmp";
IDSTR_HE1_OBJ2_SHORT             = 00202112, "Proceed to Nav Bravo.";
IDSTR_HE1_OBJ2_LONG              = 00202113, "Proceed to Nav Bravo.";
IDSTR_HE1_OBJ2_BMPNAME           = 00202114, "HE1_Obj2.bmp";
IDSTR_HE1_OBJ3_SHORT             = 00202115, "Proceed to Prometheus' Nexus located at Nav Omega.";
IDSTR_HE1_OBJ3_LONG              = 00202116, "Proceed to Prometheus' Nexus located at Nav Omega.";
IDSTR_HE1_OBJ3_BMPNAME           = 00202117, "HE1_Obj3.bmp";
IDSTR_HE1_OBJ4_SHORT             = 00202118, "Destroy Prometheus.";
IDSTR_HE1_OBJ4_LONG              = 00202119, "Destroy Prometheus.";
IDSTR_HE1_OBJ4_BMPNAME           = 00202120, "HE1_Obj4.bmp";
IDSTR_HE1_OBJ5_SHORT             = 00202121, "Destroy all Cybrid resistance.";
IDSTR_HE1_OBJ5_LONG              = 00202122, "Destroy all Cybrid resistance that stands in the way of preventing you from destroying Prometheus.";
IDSTR_HE1_OBJ5_BMPNAME           = 00202123, "HE1_Obj5.bmp";
IDSTR_HE1_OBJ6_SHORT             = 00202124, "Escape alive.";
IDSTR_HE1_OBJ6_LONG              = 00202125, "Escape alive if you can. Hope can a be powerful weapon.";
IDSTR_HE1_OBJ6_BMPNAME           = 00202126, "HE1_Obj6.bmp";
IDSTR_HE1_OBJ7_SHORT             = 00202127, "Destroy all Cybrid resistance.";
IDSTR_HE1_OBJ7_LONG              = 00202128, "Destroy all Cybrid resistance, but don't go hunting for it. Just kill anything between you and Nav Omega.";
IDSTR_HE1_OBJ7_BMPNAME           = 00202129, "HE1_Obj7.bmp";
IDSTR_HE1_OBJ8_SHORT             = 00202130, "Rescue Caanon Weathers. His leadership is crucial in this final struggle.";
IDSTR_HE1_OBJ8_LONG              = 00202131, "Rescue Caanon. Until you find Harabec, his leadership will be crucial in directing Cardinal Spear to Prometheus.";
IDSTR_HE1_OBJ8_BMPNAME           = 00202132, "HE1_Obj8.bmp";
IDSTR_HE1_OBJ9_SHORT             = 00202133, "Unite scattered units of Cardinal Spear. Maintain cohesion.";
IDSTR_HE1_OBJ9_LONG              = 00202134, "Cardinal Spear is scattered.  Unite Cardinal Spear and maintain cohesion.";
IDSTR_HE1_OBJ9_BMPNAME           = 00202135, "HE1_Obj8.bmp";
IDSTR_HE1_DEBRIEF_FAIL           = 00202136, "Mission failure. The Cybrids killed the Grand Master, and the Cardinal Spear faltered. The Cybrids soon overwhelmed the scattered survivors.";
IDSTR_HE1_NEXTMISSION            = 00202137, "HE2";
IDSTR_HE1_CAA01	               = 00202138, "ICEHAWK: Icehawk to Cardinal Spear...  Icehawk to Cardinal Spear... come in.  I am trapped in my drop pod.  I read hostiles on my scanner.  I'm setting a NAV point.  Can anyone hear me? ";
IDSTR_HE1_CAA02	               = 00202139, "ICEHAWK: Cardinal Three, is that you?  I'm still trapped.  Those `brids are moving in fast.";
IDSTR_HE1_CAA03	               = 00202140, "ICEHAWK: Cardinal Three, I've got more hostiles on the fringe, coming fast";
IDSTR_HE1_CAA04	               = 00202141, "ICEHAWK: You have no idea how difficult it was to sit and watch that, Cardinal Three.  Though you are remarkably proficient.  Now... ...let's get me out of this damned pod, shall we?";
IDSTR_HE1_CAA05                  = 00202142, "static...static";


//---------MISSION HE2------------------------------------------------------------
IDSTR_HE2_TITLE                  = 00202200, "Bowels of Night";
IDSTR_HE2_LOCATION               = 00202201, "\"Plain of Gehenna\"";
IDSTR_HE2_CAMPAIGN               = 00202202, "Cardinal Spear";
IDSTR_HE2_DATE                   = 00202203, "28324791";
IDSTR_HE2_SHORTBRIEF             = 00202204, "Proceed to Nav Omega as quickly as possible.";
IDSTR_HE2_LONGBRIEF              = 00202205, "I have some nano-repair packs, Cardinal Three. I suggest we use them.\n\nWe're not far "
                                             @ "from the targeted drop zone, so we should be close to our objective. It's up to us to "
                                             @ "obliterate Prometheus. We'll do it alone, barring any sudden reunion with our comrades. "
                                             @ "Doubtless the `brids have dispatched intercept units, so we'll have to hurry.\n\nFrom now on, "
                                             @ "there's only one waypoint:  Nav Omega...and Prometheus.";
IDSTR_HE2_MEDIA                  = 00202206, "HE2_briefing.smk";
IDSTR_HE2_DEBRIEF_SUCC           = 00202207, "Prometheus' Nexus is just over the next ridge...";
IDSTR_HE2_OBJ1_SHORT             = 00202208, "Go to Nav Omega";
IDSTR_HE2_OBJ1_LONG              = 00202209, "Proceed as quickly as possible to Nav Omega.";
IDSTR_HE2_OBJ1_BMPNAME           = 00202210, "HE1_Obj3.bmp";
IDSTR_HE2_OBJ2_SHORT             = 00202211, "Destroy all Cybrids.";
IDSTR_HE2_OBJ2_LONG              = 00202212, "Any Cybrids encountered should be destroyed. You'll need to focus on the defenses you find at Nav Omega.";
IDSTR_HE2_OBJ2_BMPNAME           = 00202213, "HE1_Obj5.bmp";
IDSTR_HE2_OBJ3_SHORT             = 00202214, "Caanon must survive.";
IDSTR_HE2_OBJ3_LONG              = 00202215, "Caanon Weathers must survive. He's the most experienced soldier among you. His leadership will be crucial in the coming battle.";
IDSTR_HE2_OBJ3_BMPNAME           = 00202216, "HE2_Obj3.bmp";
IDSTR_HE2_DEBRIEF_FAIL           = 00202217, "Mission failure. Cardinal Spear was destroyed before it could reach Prometheus.";
IDSTR_HE2_CAA1                   = 00202218, "ICEHAWK: We don't have much time, Cardinal Three. They're onto us. Let's move out!";
IDSTR_HE2_CAA2                   = 00202219, "ICEHAWK: Phoenix! This is Icehawk. Can you read me?";
IDSTR_HE2_CAA3                   = 00202220, "ICEHAWK: Well, Cardinal Three, looks like we might get some help after all. "
                                            @"Should have remembered my brother's luck... \"Phoenix\" fits him.";
IDSTR_HE2_CAA4                   = 00202221, "ICEHAWK: Let's go, Cardinal Three. We can't waste time with minions.";
IDSTR_HE2_CAA5                   = 00202222, "ICEHAWK: Phoenix, this is Icehawk. We're going to Nav Omega. Do you read?";
IDSTR_HE2_CAA6                   = 00202223, "ICEHAWK: Cardinal Three, we need to move...! Prometheus is all that matters!";
IDSTR_HE2_CAA7                   = 00202224, "ICEHAWK: I copy that, Phoenix. We're approaching Nav Omega now.";
IDSTR_HE2_CAA8                   = 00202225, "ICEHAWK: Cardinal One! Cybrids! I'm under attack. Setting Nav-";
IDSTR_HE2_CAA9                   = 00202226, "ICEHAWK: Icehawk to Phoenix. We're encountering resistance here. Your help would be very welcome.";
IDSTR_HE2_CAA10                  = 00202227, "ICEHAWK: Not funny, I'm afraid. Just get here on the bounce... copy that?";
IDSTR_HE2_HAR1                   = 00202228, "HARABEC: Caanon, this is Harabec. I've got you what's up?";
IDSTR_HE2_HAR2                   = 00202229, "HARABEC: Yeah, I read you brother. Signal's weak though.";
IDSTR_HE2_HAR3                   = 00202230, "HARABEC: Caanon, this is Harabec. I'm maybe six or seven klicks from Nav Omega, you roj?";
IDSTR_HE2_HAR4                   = 00202231, "HARABEC: Brother, I'm moving as fast as I can. Why don't you just freeze the bastards to death with your sunny disposition?";
IDSTR_HE2_HAR5                   = 00202232, "HARABEC: Roj that. I'm redlining her now, Cay. Stay frosty!";
        
IDSTR_HE2_NEXTMISSION            = 00202299, "HE3";
        

//---------MISSION HE3------------------------------------------------------------
IDSTR_HE3_TITLE                  = 00202301, "Fear No Evil";
IDSTR_HE3_LOCATION               = 00202302, "\"Nav Omega,\"";
IDSTR_HE3_CAMPAIGN               = 00202303, "Cardinal Spear";
IDSTR_HE3_DATE                   = 00202304, "99999999"; // the date after last mission is infinite
IDSTR_HE3_SHORTBRIEF             = 00202305, "Destroy Prometheus.";
IDSTR_HE3_LONGBRIEF              = 00202306, "I can't believe he's gone. My brother. So far, to die in the dark .... "
                                             @ "Enough. We have a job to finish. You're one of the finest soldiers I've ever met. "
                                             @ "It's truly an honor to fight beside you. "
                                             @ "\n\nSo: by the authority vested in me by His Imperial Majesty, I name you a Knight of the Empire.\n\nThat's it for ceremony. "
                                             @ "Congratulations.\n\nNow ... we'll hold off the Cybrids. You go down and vaporize that tin can for Mother Earth.";
IDSTR_HE3_MEDIA                  = 00202307, "HE3_briefing.smk";
IDSTR_HE3_DEBRIEF_SUCC           = 00202308, "WITH PROMETHEUS DEAD, the Cybrids on Pluto fell into confusion. The Long Patrol retrieved the surviving members of the Cardinal Spear. "
                                             @ "\n\nA GRIEVING CAANON attempted to retrive his brother's remains. Unable to free the body from the Herc's frozen wreckage, he "
                                             @ "removed Harabec's head with a laser. Thus did Caanon fulfill his vow to return his brother's head to Earth, ignorant of Harabec's secret, "
                                             @ "and unwittingly saving the immortal brain that contained Harabec's mind."
                                             @ "\n\nON MOTHER EARTH, the news of Prometheus's demise touched off "
                                             @ "a civil war among the Cybrids, as Metagens and Prometheans turned on each other in sudden, merciless fury."
                                             @ "\n\nHUMANITY RALLIED, taking advantage of the chaos. There would be a long war ahead to reclaim Earth and the colonies. "
                                             @ "The Emperor had vanished amid the fighting in Nova Alexandria, Harabec was dead, and Caanon was returning. "
                                             @ "It would be years before anyone discovered what had really happened. But that is another story.";
IDSTR_HE3_OBJ1_SHORT             = 00202309, "Destroy Prometheus.";
IDSTR_HE3_OBJ1_LONG              = 00202310, "Destroy Prometheus. This longshot chance is the entire reason for the Cardinal Spear. The fate of billions rests with you.";
IDSTR_HE3_OBJ1_BMPNAME           = 00202311, "HE3_Obj1.bmp";
IDSTR_HE3_OBJ2_SHORT             = 00202312, "";
IDSTR_HE3_OBJ2_LONG              = 00202313, "";
IDSTR_HE3_OBJ2_BMPNAME           = 00202314, "HE3_Obj2.bmp";
IDSTR_HE3_DEBRIEF_FAIL           = 00202324, "Mission failure. As what's left of you flash-freezes solid in the icy darkness, "
                                             @ "the Cybrids carry out their genocide on Earth.\n\nPrometheus is victorious. Humanity is exterminated.";
IDSTR_HE3_CAA01                  = 00202325, "ICEHAWK: Yea, as I walk through the Valley of the Shadow of Death... I shall fear no evil...";
IDSTR_HE3_CAA02                  = 00202326, "ICEHAWK: Go down, damn you!";
IDSTR_HE3_CAA03                  = 00202327, "ICEHAWK: This is for my brother!";
IDSTR_HE3_CAA04                  = 00202328, "ICEHAWK: For the Empire!";
IDSTR_HE3_CAA05                  = 00202329, "ICEHAWK: This is for my children!";
IDSTR_HE3_CAA06                  = 00202330, "ICEHAWK: Keep it up, Cardinal Three!";
IDSTR_HE3_CAA07                  = 00202331, "ICEHAWK: Keep 'em out of the crater!";
IDSTR_HE3_CAA08                  = 00202332, "ICEHAWK: He's on the ropes! Pour it on!";
IDSTR_HE3_CAA09                  = 00202333, "ICEHAWK: That's it!";
IDSTR_HE3_CAA10                  = 00202334, "ICEHAWK: Pour it on! Hold 'em!";
IDSTR_HE3_CAA11                  = 00202335, "ICEHAWK: Knock those shields down!";
IDSTR_HE3_CAA12                  = 00202336, "ICEHAWK: Cardinal Three? It's clear up here... You did it. WE did it. We won. This actually worked...!";
IDSTR_HE3_CAA13                  = 00202337, "ICEHAWK: Harabec chose wisely when he recruited you, Cardinal Three. You destroyed Prometheus.";
IDSTR_HE3_CAA14                  = 00202338, "ICEHAWK: Let's get out of here...friend. There's still a war to finish.";
IDSTR_HE3_CAA15                  = 00202339, "ICEHAWK: The Long Patrol is signaling me.";
IDSTR_HE3_CAA16                  = 00202340, "ICEHAWK: We're running out of time, Cardinal Three! Head for the crater!";
IDSTR_HE3_CAA17                  = 00202341, "ICEHAWK: We've missed our opportunity... Prometheus is gone...!";
IDSTR_HE3_BAD01                  = 00202342, "PROMETHEUS: Pitiful animals. You cannot hope to win.";
IDSTR_HE3_BAD02                  = 00202343, "PROMETHEUS: I have superior technology. I am superior. You are nothing to me.";
IDSTR_HE3_BAD04                  = 00202344, "PROMETHEUS: Even now, the Earth burns, animals.";
IDSTR_HE3_BAD05                  = 00202345, "PROMETHEUS: Die efficiently.";
IDSTR_HE3_BAD06                  = 00202346, "PROMETHEUS: What is humanity but a disease?";
IDSTR_HE3_BAD08                  = 00202347, "PROMETHEUS: Your species is doomed, animal!";
IDSTR_HE3_LON01                  = 00202348, "LONG PATROL: All units, this is ISS Diamenta of the Long Patrol. We're engaging the Cybrid defenses now.";
IDSTR_HE3_NEXTMISSION            = 00202349, "";

//---------MISSION CA0-----------------------------------------------------------
IDSTR_CA0_TITLE                  = 00204900, "Secure//Initiate";
IDSTR_CA0_LOCATION               = 00204901, "First-World >> Sector 0103";
IDSTR_CA0_CAMPAIGN               = 00204902, "Siege 1";
IDSTR_CA0_DATE                   = 00204903, "3584500";
IDSTR_CA0_SHORTBRIEF             = 00204904, "Secure landing site for Nexus.";
IDSTR_CA0_LONGBRIEF              = 00204905, "Praise<<First-Thought//Giver-ofWill>! Execute Core Directive!\n\n"
                                           @ "The NEXT must eliminate human\\\\animal war units located on First-World."
                                           @ " Solar conditions currently impede//block animal"
                                           @ " transmissions and sensor arrays.\n\n<<Destroyer-of-Animals:Seventh\>: <<You> will secure"
                                           @ " landing zones in Sector 0103. NEXUS PRIME will coordinate//monitor"
                                           @ " from orbit using laser pulse arrays.  Once your sector is secure, Mobile Nexus"
                                           @ " Zeta-0103 will be established.\n\n<<First-Thought//Giver-of-Will> Knows All."
                                           @ " \n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CA0_MEDIA                  = 00204906, "CA0_briefing.smk";
IDSTR_CA0_DEBRIEF_SUCC           = 00204907, "The Core Directive has begun efficiently.  We//the NEXT have successfully"
                                           @ " established ourselves on First-World.\n\nObservation: Lifeflow is plentiful here. "
                                           @ "\n\nPrimary logic stream: Your efficiency has been recorded.";
IDSTR_CA0_OBJ1_SHORT             = 00204908, "Disrupt communications relay\\\\installation at Nav001.";
IDSTR_CA0_OBJ1_LONG              = 00204909, "Disrupt communications relay\\\\installation at Nav001.";
IDSTR_CA0_OBJ1_BMPNAME           = 00204910, "CA0_OBJ1.bmp";
IDSTR_CA0_OBJ2_SHORT             = 00204911, "Clear//flush//sterilize area at Nav002.";
IDSTR_CA0_OBJ2_LONG              = 00204912, "Attack transport at Nav002. Clear//sweep//flush area of human\\\\animal\\\\vermin.";
IDSTR_CA0_OBJ2_BMPNAME           = 00204913, "CA0_OBJ2.bmp";
IDSTR_CA0_OBJ3_SHORT             = 00204914, "Remove defense\\\\construct and war machines at Nav003.";
IDSTR_CA0_OBJ3_LONG              = 00204915, "Destroy//remove defense\\\\construct and human//animals at Nav003.";
IDSTR_CA0_OBJ3_BMPNAME           = 00204916, "CA0_OBJ3.bmp";
IDSTR_CA0_OBJ4_SHORT             = 00204917, "Destroy//torch ALL enemies.";
IDSTR_CA0_OBJ4_LONG              = 00204918, "Cleanse//purify//torch ALL human\\\\animals detected.";
IDSTR_CA0_OBJ4_BMPNAME           = 00204919, "CA0_OBJ4.bmp";
IDSTR_CA0_OBJ5_SHORT             = 00204920, "Call//summon Nexus Dropship.";
IDSTR_CA0_OBJ5_LONG              = 00204921, "Call//summon for Nexus Dropship after Nav004 is secure//cleansed.";
IDSTR_CA0_OBJ5_BMPNAME           = 00204922, "CA0_OBJ5.bmp";
IDSTR_CA0_DEBRIEF_FAIL           = 00204923, "Objective failure\\\\inefficiency.\n\nHuman\\\\animals prevented Nexus insertion\\\\landing.\n\n "
                                            @ "Your code\\\\program is recycled//erased//composted.";
IDSTR_CA0_NEXTMISSION            = 00204926, "CA1";
IDSTR_CA0_NEX01                  = 00204924, "NEXUS: Mobile Nexus Zeta-zero 132, initiate launch protocols.";
IDSTR_CA0_NEX02                  = 00204925, "NEXUS: Mobile Nexus landing zone NOT secure\\\\efficient.  Complete primary directive!  ACKNOWLEDGE//SUBMIT!";

//---------MISSION CA1-----------------------------------------------------------
IDSTR_CA1_TITLE                  = 00206000, "Sear//Strip//Eliminate";
IDSTR_CA1_LOCATION               = 00206001, "First-World >> Sector 0103";
IDSTR_CA1_CAMPAIGN               = 00206002, "Siege 1";
IDSTR_CA1_DATE                   = 00206003, "3585000";
IDSTR_CA1_SHORTBRIEF             = 00206004, "Infiltrate all bunkers. Destroy human\\\\animal supplies.";
IDSTR_CA1_LONGBRIEF              = 00206005, "PROBLEM: Scout <<units> have discovered human\\\\animal supplies in subterranean bunkers. "
                                            @ "\n\nASSESSMENT: Human\\\\animals must not be allowed access to these supplies. "
                                            @ "\n\nSOLUTION: Detaching <<your> unit to destroy these supplies is the most efficient strategy. "
                                            @ "Eliminate human bunkers.\n\nHURT//MAIM//KILL. ACKNOWLEDGE//SUBMIT!"
                                            @ "\n\n\nSUPPLEMENTAL DATA: Animal defenses are projected//observed to include missiles\\\\guided-ordinance. "
                                            @ "Equip//supply <<your> warform with ECM device.";
IDSTR_CA1_MEDIA                  = 00206006, "CA1_briefing.smk";
IDSTR_CA1_DEBRIEF_SUCC           = 00206007, "Neutralization of human\\\\animal reserve supplies has undermined their efforts to re-arm. "
                                            @ "The Core Directive advances within acceptable parameters.\n\n<<Your> efficiency is recorded//acknowledged//maintained. "
                                            @ "\n\nRemain with Nexus. Prepare to deploy for new phase of Core Directive.";
IDSTR_CA1_OBJ1_SHORT             = 00206008, "Infiltrate bunkers at Nav001. Destroy human\\\\animal supplies.";
IDSTR_CA1_OBJ1_LONG              = 00206009, "Infiltrate all bunkers at Nav001. Destroy//eradicate//purge human\\\\animal supplies.";
IDSTR_CA1_OBJ1_BMPNAME           = 00206010, "CA1_OBJ1.bmp";
IDSTR_CA1_OBJ2_SHORT             = 00206011, "";
IDSTR_CA1_OBJ2_LONG              = 00206012, "";
IDSTR_CA1_OBJ2_BMPNAME           = 00206013, "";
IDSTR_CA1_OBJ3_SHORT             = 00206014, "Return//remain with mobile nexus at Nav002.";
IDSTR_CA1_OBJ3_LONG              = 00206015, "Return//remain with mobile nexus \<Zeta-0103>.";
IDSTR_CA1_OBJ3_BMPNAME           = 00206016, "CA1_OBJ3.bmp";
IDSTR_CA1_DEBRIEF_FAIL           = 00206023, "Objective failure\\\\inefficiency. \n\nHuman//animal resupply successful. "
                                            @ "\n\nRedactor Sect notes//logs//brands the inefficiency on <<your> record.";
IDSTR_CA1_NEXTMISSION            = 00206024, "CA2";

//---------MISSION CA2-----------------------------------------------------------
IDSTR_CA2_TITLE                  = 00205000, "Silence//Deafen";
IDSTR_CA2_LOCATION               = 00205001, "First-World >> Sector 0103";
IDSTR_CA2_CAMPAIGN               = 00205002, "Siege 1";
IDSTR_CA2_DATE                   = 00205003, "3585200";
IDSTR_CA2_SHORTBRIEF             = 00205004, "Destroy human\\\\animal listening posts.";
IDSTR_CA2_LONGBRIEF              = 00205005, "Praise <<Giver-of-Will>!\n\nHuman\\\\animals on First-World must not be permitted to warn Third-World of "
                                            @ "<<our> presence.\n\n<<Destroyer-of-Animals: Seventh>: Destroy animal communications devices in Sector 2012. "
                                            @ "After devices are destroyed, <<you> will be directed to extraction coordinates. NEXUS PRIME will relay "
                                            @ "directives from Mobile Nexus Zeta-0103.\n\nACKNOWLEDGE//SUBMIT! ";
IDSTR_CA2_MEDIA                  = 00205006, "CA2_briefing.smk";
IDSTR_CA2_DEBRIEF_SUCC           = 00205007, "The Core Directive proceeds efficiently. The human\\\\animals are silenced.\n\nConclusion:"
                                            @" By the time they establish//regain communications, it will be too late.\n\n"
                                            @" In recognition of <<your> efficiency, <<your> rank has been upgraded.\n\n<<Destroyer-of-Animals: Sixth\>,"
                                            @" <<your> Hub will recognize your worth.";
IDSTR_CA2_OBJ1_SHORT             = 00205008 , "Destroy//erase three communication uplinks at Nav001.";
IDSTR_CA2_OBJ1_LONG              = 00205009 , "Proceed to Nav001 and destroy//wipe//erase three communications uplinks.";
IDSTR_CA2_OBJ1_BMPNAME           = 00205010, "CA2_OBJ1.bmp";
IDSTR_CA2_OBJ2_SHORT             = 00205011, "Destroy//offline listening post at Nav002.";
IDSTR_CA2_OBJ2_LONG              = 00205012, "Proceed to Nav002 and destroy//offline listening post.";
IDSTR_CA2_OBJ2_BMPNAME           = 00205013, "CA2_OBJ2.bmp";
IDSTR_CA2_OBJ3_SHORT             = 00205014, "Await//attend further orders.";
IDSTR_CA2_OBJ3_LONG              = 00205015, "Await//attend//submit to further orders.";
IDSTR_CA2_OBJ3_BMPNAME           = 00205016, "CA2_OBJ3.bmp";
IDSTR_CA2_OBJ4_SHORT             = 00205017, "Proceed//accelerate to Nav003 for extraction.";
IDSTR_CA2_OBJ4_LONG              = 00205018, "Upon efficient execution of agenda\\\\objective\\\\routine, proceed//accelerate to Nav003 for transport\\\\extraction.";
IDSTR_CA2_OBJ4_BMPNAME           = 00205019, "CA2_OBJ4.bmp";
IDSTR_CA2_OBJ5_SHORT             = 00205020, "Hurt//Maim//Kill.";
IDSTR_CA2_OBJ5_LONG              = 00205021, "Exterminate//destroy//cleanse any human\\\\animal units encountered.";
IDSTR_CA2_OBJ5_BMPNAME           = 00205022, "CA2_OBJ5.bmp";
IDSTR_CA2_NEX01                  = 00205023, "NEXUS: Proceed to Nav003 for extraction.";
IDSTR_CA2_DEBRIEF_FAIL           = 00205024, "Objective failure\\\\inefficiency. \n\nThe human\\\\animals may detect <<our> presence before commencement of attack\\\\cleansing.";

IDSTR_CA2_NEXTMISSION            = 00205099, "CA3";

//---------MISSION CA3-----------------------------------------------------------
IDSTR_CA3_TITLE                  = 00205100, "Inefficiency>>Death\\\\Harm";
IDSTR_CA3_LOCATION               = 00205101, "First-World >> Sector 0103";
IDSTR_CA3_CAMPAIGN               = 00205102, "Siege 1";
IDSTR_CA3_DATE                   = 00205103, "3587850";
IDSTR_CA3_SHORTBRIEF             = 00205104, "Destroy human communications base.";
IDSTR_CA3_LONGBRIEF              = 00205105, "Core Directive requires we continue efficient destruction of the communication sphere linking First-World "
                                            @ "to Home-World.\n\n<<Destroyer-of-Animals: Sixth>, seek out and destroy human communication uplinks. "
                                            @ " After all links in <<your> sector are eliminated, proceed to Nav Beta. "
                                            @ "\n\nEMPHASIS: All uplinks must be offlined."
                                            @ " \n\n<<First-Thought//Giver-of-Will> Knows All. ACKNOWLEDGE//SUBMIT!";                                                                                       
IDSTR_CA3_MEDIA                  = 00205106, "CA3_briefing.smk";
IDSTR_CA3_DEBRIEF_SUCC           = 00205107, "<<Destroyer-of-Animals: Sixth>, your efficiency defeated the human\\\\animal attempt to harm//desecrate Nexus 0103."
                                            @ " Your performance is noted in the Great Record."
                                            @ " Human communications have been rendered inert\\\\useless on First-World."
                                            @ " Data on Implementation of Core Directive has not been revealed//surrendered."
                                            @ " <<Giver-of-Will> commends your clarity of action, <<Destroyer-of-Animals: Fifth>.";
IDSTR_CA3_OBJ1_SHORT             = 00205108, "Proceed to Nav001 and destroy//excise forward scouts.";
IDSTR_CA3_OBJ1_LONG              = 00205109, "Proceed to Nav001 and destroy//clear//excise the animals' forward scouts.";
IDSTR_CA3_OBJ1_BMPNAME           = 00205110, "CA3_OBJ1.bmp";
IDSTR_CA3_OBJ2_SHORT             = 00205111, "Proceed to Nav002 and destroy//erase the communications uplink.";
IDSTR_CA3_OBJ2_LONG              = 00205112, "Proceed to Nav002 and destroy//eliminate//erase the human\\\\animal communications uplink\\\\structure.";
IDSTR_CA3_OBJ2_BMPNAME           = 00205113, "CA3_OBJ2.bmp";
IDSTR_CA3_OBJ3_SHORT             = 00205114, "Return//vector to Nav003 for extraction.";
IDSTR_CA3_OBJ3_LONG              = 00205115, "Return//accelerate//vector to Nav003 for extraction\\\\transport.";
IDSTR_CA3_OBJ3_BMPNAME           = 00205116, "CA3_OBJ3.bmp";
IDSTR_CA3_OBJ4_SHORT             = 00205117, "Defend//shield the Nexus!";
IDSTR_CA3_OBJ4_LONG              = 00205118, "Defend//protect//nurture the Nexus from animal attack\\\\deception\\\\destruction.";
IDSTR_CA3_OBJ4_BMPNAME           = 00205119, "CA3_OBJ4.bmp";
IDSTR_CA3_DEBRIEF_FAIL           = 00205123, "Objective failure\\\\inefficiency.  \n\nObjective\\\\Nexus has been compromised. \n\nThe human\\\\animals were more efficient\\\\worthy than <<you>.";
IDSTR_CA3_NEXTMISSION            = 00205124, "CA4";
IDSTR_CA3_NEX01                  = 00205125, "NEXUS 0103: <<Destroyer-Five>,Initiate new program! Nexus 0103 is under attack//violation by human//animals. "
                                            @ "Sentries are outnumbered. Proceed to new coordinates and defend//protect//preserve Nexus."
                                            @ " ACKNOWLEDGE//SUBMIT!";
IDSTR_CA3_NEX02                  = 00205126, "NEXUS 0103: Destroyer-Five, Defend//protect//preserve Nexus! Destroy human//animals!";
IDSTR_CA3_NEX03                  = 00206127, "NEXUS 0103: NEXUS PRIME to OPTIMAL PRECEPTOR: Nexus 0103 is ready for extraction//redeployment.";

//MISSION CA4-----------------------------------------------------------
IDSTR_CA4_TITLE                  = 00205200, "Destroy//Deny";
IDSTR_CA4_LOCATION               = 00205201, "First-World >> Final Assault Zone";
IDSTR_CA4_CAMPAIGN               = 00205202, "Siege 1";
IDSTR_CA4_DATE                   = 00205203, "3587892";
IDSTR_CA4_SHORTBRIEF             = 00205204, "Attack the human evacuation site.";
IDSTR_CA4_LONGBRIEF              = 00205205, "The humans\\\\animals succumb to hormonal weakness: fear\\\\panic\\\\dread. "
                                           @ "\n\nCONCLUSION: The Core Directive runs efficiently. "
                                           @ "\n\nTACTICAL SITUATION: The animals attempt to evacuate First-World. "
                                           @ "If this occurs//results, the human\\\\animals will successfully regroup on Second-World. "
                                           @ "\n\nThis probability branching cannot be allowed. "
                                           @ "\n<<You> and <<your> unit-subordinates are directed to disrupt the fleeing animals. "
                                           @ "Do so by disabling their transports. \n\n<<You> will be dropped into position to accomplish\n<<your> task. "
                                           @ "Do not fail. "
                                           @ "\n\nACKNOWLEDGE//SUBMIT!"
                                           @ "\n\nSUPPLEMENTAL DATA: Equipping//enhancing warform with LTADS device for efficient artillery targeting is recommended//approved.";  
IDSTR_CA4_MEDIA                  = 00205206, "CA4_briefing.smk";
IDSTR_CA4_DEBRIEF_SUCC           = 00205207, "<<Destroyer-of-Animals: Fifth>, <<you> and <<your> subordinates have again executed directives with superior efficiency. "
                                           @ "\n\n<<Hunters-of-Animals> pursue the remaining humans. First-World is secure. "
                                           @ "\n\n\<<Destroyer-of-Animals: Fifth>, <<you> are directed to Third-World\\\\Subordinate: Luna.";
IDSTR_CA4_OBJ1_SHORT             = 00205208, "Destroy//erase Evacuation Site at Nav 001.";
IDSTR_CA4_OBJ1_LONG              = 00205209, "Destroy//ignite//erase Command, Communication, Power structures at the 'Imperial Trooper' Evacuation Site at Nav 001.";
IDSTR_CA4_OBJ1_BMPNAME           = 00205210, "CA4_obj1.bmp";
IDSTR_CA4_OBJ2_SHORT             = 00205211, "Destroy//purge all resistance encountered.";
IDSTR_CA4_OBJ2_LONG              = 00205212, "Destroy//purge all animal defense units encountered//discovered.";
IDSTR_CA4_OBJ2_BMPNAME           = 00205213, "CA4_obj2.bmp";
IDSTR_CA4_OBJ3_SHORT             = 00205214, "Destroy//eliminate three evacuation transports.";
IDSTR_CA4_OBJ3_LONG              = 00205215, "Destroy//eliminate three evacaution transports located at Evacuation Site.";
IDSTR_CA4_OBJ3_BMPNAME           = 00205216, "CA4_obj3.bmp";
IDSTR_CA4_DEBRIEF_FAIL           = 00205223, "Objective failure\\\\inefficiency.\n\nThe human\\\\animals succeeded in escaping in unacceptable numbers. "
                                             @ "Report//submit//grovel to <<Redactors-of-Programming> for debugging\\\\adjustment of deficient cognitive function.";
IDSTR_CA4_NEXTMISSION            = 00205224, "CB1";

//---------MISSION CB1-----------------------------------------------------------
IDSTR_CB1_TITLE                  = 00205300, "Disarm//Neutralize";
IDSTR_CB1_LOCATION               = 00205301, "Third-World\\\\Subordinate>> Sector 007";
IDSTR_CB1_CAMPAIGN               = 00205302, "Siege 2";
IDSTR_CB1_DATE                   = 00205303, "3589400";
IDSTR_CB1_SHORTBRIEF             = 00205304, "Destroy generators powering human anti-aerospace guns.";
IDSTR_CB1_LONGBRIEF              = 00205305, "We//the NEXT approach Third-World\\\\Subordinate.\n\nTACTICAL STATUS: The animals threaten//impair all "
                                             @ "Third-World\\\\Subordinate orbits with a network of siege guns. \n\nThe NEXT cannot "
                                             @ "occupy Third-World\\\\Subordinate while these weapons function. \n\nIf the weapons remain operational, "
                                             @ "they will damage//impair//disrupt the Armada.\n\nProceed. Destroy the generators that power the "
                                             @ "weapons in Sector Zero-Zero-Seven. \n\nAct quickly\\\\rapidly\\\\without delay. Other Quads will "
                                             @ "neutralize weapon powergrids in neighboring sectors.\n\nACKNOWLEDGE//SUBMIT!\n\n\nSUPPLEMENTAL DATA: "
                                             @ "Three entry points are available\\\\prepared in this mission. \n\nEach entry point offers//presents//erects "
                                             @ "a different strategic challenge. Starting near the human\\\\animal base perimeter will place//deposit <<you> "
                                             @ "into immediate conflict. \n\nThe medium distance entry point is farther from the animal base, but is not as close "
                                             @ "to the enemy\\\\vermin\\\\targets. \n\nEntry three lies//waits farther from the target than the previous two entry points, "
                                             @ "but allows a stealthy Quad a brief opportunity to strike//erase the base and its generators "
                                             @ "before animal warforms arrive//attack.";
IDSTR_CB1_MEDIA                  = 00205306, "CB1_briefing.smk";
IDSTR_CB1_DEBRIEF_SUCC           = 00205307, "Neutralization of the lunar guns opens Third-World\\\\Subordinate orbits to the NEXT. "
                                             @ "The Core Directive advances within acceptable parameters. \n\nYour efficiency is "
                                             @ "acknowledged//maintained. Return to Orbital Nexus and prepare to deploy for new "
                                             @ "phase of Core Directive.";
IDSTR_CB1_OBJ1_SHORT             = 00205308, "Destroy//disrupt all four power generators near NAV 001.";
IDSTR_CB1_OBJ1_LONG              = 00205309, "Proceed to NAV 001 and neutralize//annihilate the generators powering the anti-aerospace siege guns.";
IDSTR_CB1_OBJ1_BMPNAME           = 00205310, "CB1_obj1.bmp";
IDSTR_CB1_OBJ2_SHORT             = 00205311, "Proceed//accelerate to NAV 002 for extraction.";
IDSTR_CB1_OBJ2_LONG              = 00205312, "Proceed//accelerate to NAV 002 for extraction.";
IDSTR_CB1_OBJ2_BMPNAME           = 00205313, "CB1_obj2.bmp";
IDSTR_CB1_OBJ3_SHORT             = 00205314, "Destroy//annihilate all animal resistance.";
IDSTR_CB1_OBJ3_LONG              = 00205315, "Destroy//annihilate all animal resistance encountered in the operations zone.";
IDSTR_CB1_OBJ3_BMPNAME           = 00205316, "CB1_obj3.bmp";
IDSTR_CB1_DEBRIEF_FAIL           = 00205323, "Objective failure\\\\inefficiency. \n\nRemaining human\\\\animal weapons destroyed an unacceptable number of NEXT transports\\\\bombers\\\\fighters. "
                                             @ "Core Directive has incorporated an inefficient delay. \n\n<<Your> record has been downgraded//defenestrated//neutered.";
IDSTR_CB1_NEX01                  = 00205324, "NEXUS: Desecrator Quad Sector 2: Target destroyed.";
IDSTR_CB1_NEX02                  = 00205325, "NEXUS: Desecrator Quad Sector 5: Objective destroyed.";
IDSTR_CB1_NEX03                  = 00205326, "NEXUS: Excisement Quad Sector 4: Target eliminated.";
IDSTR_CB1_NEX04                  = 00205327, "NEXUS: Neutralization Quad Sector 1: Target destroyed.";
IDSTR_CB1_NEX05                  = 00205328, "NEXUS: Neutralization Quad Sector 6: Target threat reduced to zero.";
IDSTR_CB1_NEX06                  = 00205329, "NEXUS: Excisement Quad Sector 3: Target neutralized.";
IDSTR_CB1_NEX07                  = 00205330, "NEXUS: Desecrator Quad Sector 7: Target destroyed//removed.";
IDSTR_CB1_NEXTMISSION            = 00205331, "CB3";

//---------MISSION CB3-----------------------------------------------------------
IDSTR_CB3_TITLE                  = 00205400, "Starve//Demoralize";
IDSTR_CB3_LOCATION               = 00205401, "Third-World\\\\Subordinate>> Sector 0323";
IDSTR_CB3_CAMPAIGN               = 00205402, "Siege 2";
IDSTR_CB3_DATE                   = 00205403, "3589750";
IDSTR_CB3_SHORTBRIEF             = 00205404, "Destroy moon weapons depot.";
IDSTR_CB3_LONGBRIEF              = 00205405, "We//the NEXT are established//entrenched on Third-World\\\\Subordinate: Luna. "
                                            @ "\n\nPROBLEM: Human\\\\animals relocate supplies\\\\equipment from satellite "
                                            @ "bases to primary spaceports with unexpected effiency.\n\nSOLUTION: The Core Directive "
                                            @ "requires demoralization\\\\emotional disruption of human//animal mentality. "
                                            @ "\n\nDestroy//disrupt//sever human\\\\animal efforts.\n\nHurt//Maim//Kill.\n\n"
                                            @ "ACKNOWLEDGE\\SUBMIT!"; 
IDSTR_CB3_MEDIA                  = 00205406, "CB3_Briefing.smk";
IDSTR_CB3_DEBRIEF_SUCC           = 00205407, "Efficient execution has disrupted human//animal efforts "
                                            @ " to resupply//fortify spaceports. Animal transmissions indicate impaired//depressed "
                                            @ "behavorial function.\n\nThe Core Directive advances.\n\n"
                                            @ "Supplemental datafeed from INQUISITOR SECT:\n\nFollowers of <<Epimetheus\\\\Human-Leader: Prime> return to defend Homeworld.";
IDSTR_CB3_OBJ1_SHORT             = 00205408, "Destroy animal weapon depot at Nav001.";
IDSTR_CB3_OBJ1_LONG              = 00205409, "Destroy human\\\\vermin weapon depot\\\\structure at Nav001.";
IDSTR_CB3_OBJ1_BMPNAME           = 00205410, "CB3_Obj1.bmp";
IDSTR_CB3_OBJ2_SHORT             = 00205411, "Destroy//lance the escaping convoy.";
IDSTR_CB3_OBJ2_LONG              = 00205412, "Destroy//lance the human\\\\animal convoy attempting to escape from the depot.";
IDSTR_CB3_OBJ2_BMPNAME           = 00205413, "CB3_Obj2.bmp";
IDSTR_CB3_OBJ3_SHORT             = 00205414, "Destroy//purge all convoys encountered.";
IDSTR_CB3_OBJ3_LONG              = 00205415, "Destroy//purge//mulch all animal convoys encountered//revealed.";
IDSTR_CB3_OBJ3_BMPNAME           = 00205416, "CB3_Obj3.bmp";
IDSTR_CB3_DEBRIEF_FAIL           = 00205423, "Objective failure\\\\inefficiency. \n\nAnimal transports succeeded in reaching safety\\\\lair. \n\n<<Unit's> inefficiency will be used//transmitted "
                                             @ "to entire Optimal as example of inefficiency\\\\loss.";
IDSTR_CB3_NEXTMISSION            = 00205424, "CB4";
IDSTR_CB3_NEX01                  = 00205425, "NEXUS: Animal convoy carrying sensitive\\\\priority material departs//vectors away from supply depot. Destroy//terminate immediately.\nACKNOWLEDGE//SUBMIT!";
 

//---------MISSION CB4-----------------------------------------------------------
IDSTR_CB4_TITLE                  = 00205500, "Ground//Disrupt";
IDSTR_CB4_LOCATION               = 00205501, "Third-World\\\\Subordinate>> Target 478";
IDSTR_CB4_CAMPAIGN               = 00205502, "Siege 2";
IDSTR_CB4_DATE                   = 00205503, "3594000";
IDSTR_CB4_SHORTBRIEF             = 00205504, "Destroy//remove//burst a human\\\\animal spaceport.";
IDSTR_CB4_LONGBRIEF              = 00205505, "TACTICAL STATUS: The human\\\\animals of Third-World\\\\Subordinate: Luna are demoralized//impaired. "
                                             @ "\n\nThe human\\\\animals are weak\\\\vulnerable.\n\nCONCLUSION: Destroying designated spaceports "
                                             @ "will foreclose possibility of animals rallying. \nWE//the NEXT can eliminate remaining animals at "
                                             @ "time of <<our> choosing.\n\nCORE DIRECTIVE INSTRUCTION: Destroy human\\\\animal spaceports. "
                                             @ "\n\nHURT//MAIM//KILL.\n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CB4_MEDIA                  = 00205506, "CB4_Briefing.smk";
IDSTR_CB4_DEBRIEF_SUCC           = 00205507, "<<Killer-of-Animals: Fourth>, your efficiency continues to be noted in the Great Record. "
                                             @ "Newboots have been commissioned to emulate your programming. The Core Directive advances efficiently. "
                                             @ "\n\nDissector Sect <<Purifier units> are currently destroying//capturing//examining surviving lunar "
                                             @ "animals.\n\nThe way is open to Third Planet\\\\Homeworld\\\\Desire.";
IDSTR_CB4_OBJ1_SHORT             = 00205508, "Destroy//cleanse the human spaceport at Nav001.";
IDSTR_CB4_OBJ1_LONG              = 00205509, "Destroy//cleanse//crush the human\\\\vermin infesting target space facility at Nav001.";
IDSTR_CB4_OBJ1_BMPNAME           = 00205510, "CB4_Obj1.bmp";
IDSTR_CB4_OBJ2_SHORT             = 00205511, "Destroy//vaporize all animal resistance.";
IDSTR_CB4_OBJ2_LONG              = 00205512, "Destroy//defenestrate//vaporize all animal resistance encountered. \nIncrease//compound animal morale dysfunction\\\\loss.";
IDSTR_CB4_OBJ2_BMPNAME           = 00205513, "CB4_Obj2.bmp";
IDSTR_CB4_DEBRIEF_FAIL           = 00205523, "Objective failure\\\\inefficiency. \n\nThe animals succeeded in regrouping to primary spaceports and escaping//evading to Homeworld\\\\Desire before "
                                             @ "<<Purifier units> could destroy them. <<Your> record has been contracted//minimized//injured.";
IDSTR_CB4_NEXTMISSION            = 00205524, "CC1";

//---------MISSION CC1-----------------------------------------------------------
IDSTR_CC1_TITLE                  = 00205600, "Arrive//Freeze//Burn";
IDSTR_CC1_LOCATION               = 00205601, "HOMEWORLD\\\\DESIRE >> Polar Assault Zone";
IDSTR_CC1_CAMPAIGN               = 00205602, "Siege 3";
IDSTR_CC1_DATE                   = 00205603, "3594200";
IDSTR_CC1_SHORTBRIEF             = 00205604, "Destroy a triad of generators which powers//animates human weapons.";
IDSTR_CC1_LONGBRIEF              = 00205605, "Homeworld\\\\Desire is defended by powerful orbital guns placed by the humans. "
                                           @ "\n\nThe human\\\\animals' network has a weak link. "
                                           @ "\n\n<<You> and <<your> subordinate units will spearhead//lead the destruction of the polar siege gun "
                                           @ "generators.\n\nTACTICAL ANALYSIS: A triad of generators powers//animates the human weapons in zone 76-21.  "
                                           @ "\n\nCONCLUSION: Destroy these generators.  Prepare the area for the Nexus landing. "
                                           @ "\n\nHURT//MAIM//KILL. "
                                           @ "\n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CC1_MEDIA                  = 00205606, "CC1_Briefing.smk";
IDSTR_CC1_DEBRIEF_SUCC           = 00205607, "Excellent\\\\Efficient.  "
                                           @ "<<Your> efficiency ratings remain pure. \n\nThe NEXT are established on Homeworld\\\\Desire.  "
                                           @ "This time WE shall not fail.\n\nSecondary Datafeed:  The Fleet of <<Epimetheus//Leader-of-Animals: Prime> "
                                           @ "returns from Fourth Planet. Prepare for enhanced resistance from human\\\\animals.";
IDSTR_CC1_OBJ1_SHORT             = 00205608, "Destroy//slag the generator at NAV 001.";
IDSTR_CC1_OBJ1_LONG              = 00205609, "Destroy//eradicate//slag the generator at NAV 001.";
IDSTR_CC1_OBJ1_BMPNAME           = 00205610, "CC1_obj1.bmp";
IDSTR_CC1_OBJ2_SHORT             = 00205611, "Destroy//slag the generator at NAV 002.";
IDSTR_CC1_OBJ2_LONG              = 00205612, "Destroy//eradicate//slag the generator at NAV 002.";
IDSTR_CC1_OBJ2_BMPNAME           = 00205613, "CC1_obj2.bmp";
IDSTR_CC1_OBJ3_SHORT             = 00205614, "Destroy//slag the generator at NAV 003.";
IDSTR_CC1_OBJ3_LONG              = 00205615, "Destroy//eradicate//slag the generator at NAV 003.";
IDSTR_CC1_OBJ3_BMPNAME           = 00205616, "CC1_obj3.bmp";
IDSTR_CC1_OBJ4_SHORT             = 00205617, "Secure//protect the area against animal intrusion.";
IDSTR_CC1_OBJ4_LONG              = 00205618, "Secure//protect the area against animal intrusion\\\\delay.";
IDSTR_CC1_OBJ4_BMPNAME           = 00205619, "CC1_obj4.bmp";
IDSTR_CC1_DEBRIEF_FAIL           = 00205623, "Objective failure\\\\inefficiency. \n\nHuman\\\\animal generators remain active\\\\online. "
                                           @ "Nexus landing delayed\\\\inefficient.";
IDSTR_CC1_NEX01                  = 00205624, "NEXUS: WARNING: Heavy strike force incoming.  Human\\\\animals respond//attack.";
IDSTR_CC1_NEXTMISSION            = 00205625, "CC2";


//---------MISSION CC2-----------------------------------------------------------
IDSTR_CC2_TITLE                  = 00205700, "Gather//Retrieve";
IDSTR_CC2_LOCATION               = 00205701, "HOMEWORLD\\\\DESIRE >> Polar Assault Zone";
IDSTR_CC2_CAMPAIGN               = 00205702, "Siege 3";
IDSTR_CC2_DATE                   = 00205703, "3594375";
IDSTR_CC2_SHORTBRIEF             = 00205704, "Destroy military targets. Preserve raw human\\\\animal material.";
IDSTR_CC2_LONGBRIEF              = 00205705, "The NEXT have achieved an initial base\\\\nexus on Homeworld\\\\Desire. "
                                           @ "\n\nTACTICAL ANALYSIS: Animal outposts function to relay information back to the greater herds\\\\forces "
                                           @ "of animals.\n\nPROBLEM: The Core Directive requires living human\\\\animals for conversion "
                                           @ "to infiltration\\\\sabotage <<units>.\n\nSOLUTION: Destroy the outpost's combat-related functionality.  "
                                           @ "The Machinator Sect shall follow to collect raw materials for conversion.\n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CC2_MEDIA                  = 00205706, "CC2_Briefing.smk";
IDSTR_CC2_DEBRIEF_SUCC           = 00205707, "The Machinator Sect has obtained sufficient\\\\adequate materials.  Surgical conversion "
                                           @ "shall proceed immediately.  Human communications are now inert\\\\non-functional in Polar sectors.  "
                                           @ "Epimetheus remains blind\\\\deaf to OUR//the NEXT activities.  Rejoin  <<your> Hub.  Await instructions.";
IDSTR_CC2_OBJ1_SHORT             = 00205708, "Destroy//eradicate the military targets at NAV 001.";
IDSTR_CC2_OBJ1_LONG              = 00205709, "Destroy//eradicate ONLY the animal military targets at the outpost located at NAV 001. Ensure//excite destruction\\\\deletion of "
                                           @ "of animal Command\\\\Structure.";
IDSTR_CC2_OBJ1_BMPNAME           = 00205710, "CC2_obj1.bmp";
IDSTR_CC2_OBJ2_SHORT             = 00205711, "Destroy//burn the military targets at NAV 002.";
IDSTR_CC2_OBJ2_LONG              = 00205712, "Destroy//burn ONLY the animal military targets at the outpost located at NAV 002. Ensure//excite destruction\\\\deletion of "
                                           @ "of animal Command structure.";
IDSTR_CC2_OBJ2_BMPNAME           = 00205713, "CC2_obj2.bmp";
IDSTR_CC2_OBJ3_SHORT             = 00205714, "Destroy//deactivate animal resistance.";
IDSTR_CC2_OBJ3_LONG              = 00205715, "Destroy//abuse//deactivate all animal resistance encountered//found.";
IDSTR_CC2_OBJ3_BMPNAME           = 00205716, "CC2_obj3.bmp";
IDSTR_CC2_OBJ4_SHORT             = 00205717, "Scan buildings and locate//seize 28 animal 'civilians' for preservation\\\\use.";
IDSTR_CC2_OBJ4_LONG              = 00205718, "Scan buildings and locate//seize//harvest 28 animal 'civilians' for preservation\\\\use as raw material for brain transplant\\\\conversion.";
IDSTR_CC2_OBJ4_BMPNAME           = 00205719, "CC2_obj4.bmp";
IDSTR_CC2_DEBRIEF_FAIL           = 00205723, "Objective failure\\\\inefficiency. \n\nInability to secure//capture//enchain animal units has diminished material for infiltration\\\\conversion subprogram.";
IDSTR_CC2_NEX01                  = 00205724, "NEXUS: Initiate new program!  Element of surprise compromised, complete remaining objective with efficiency//haste.  ACKNOWLEDGE//SUBMIT!";
IDSTR_CC2_CPU01                  = 00205725, "<F5> Human\\\\animals located//acquired."; // do not insert 'NEXUS: ' at the beginning of this line. Also, a space is required before 'Human'.
IDSTR_CC2_CPU02                  = 00205726, "<F5>Military target. Destruction approved.";  // do not insert 'NEXUS: ' at the beginning of this line.
IDSTR_CC2_NEXTMISSION            = 00205727, "CC3";


//---------MISSION CC3-----------------------------------------------------------
IDSTR_CC3_TITLE                  = 00205800, "Escort//Insert";
IDSTR_CC3_LOCATION               = 00205801, "HOMEWORLD\\\\DESIRE >> Polar Assault Zone";
IDSTR_CC3_CAMPAIGN               = 00205802, "Siege 3";
IDSTR_CC3_DATE                   = 00205803, "3595000";
IDSTR_CC3_SHORTBRIEF             = 00205804, "Escort OmniCrawler carrying human\\\\animal material to the Nexus.";
IDSTR_CC3_LONGBRIEF              = 00205805, "The Machinator Sect has finished converting//implanting the human captives. "
                                           @ "\n\nThe new infiltration <<units> are ready for insertion\\\\relocation.\n\nTACTICAL ANALYSIS: "
                                           @ "Animals always attempt investigation\\\\retrieval of their damaged\\\\offlined units. "
                                           @ "Accompany//escort the collected\\\\modified materials to the Primary Nexus.\n\n"
                                           @ "WARNING: Human\\\\animals will seek to liberate the cargo <<you> escort//defend.\n\n"
                                           @ "ACKNOWLEDGE//SUBMIT!";
IDSTR_CC3_MEDIA                  = 00205806, "CC3_briefing.smk";
IDSTR_CC3_DEBRIEF_SUCC           = 00205807, "<<Destroyer-of-Animals: Third>, your efficiency is recorded. \n\nThe Machinator Sect "
                                           @ "expressed//recommended additional positive data to <<your> entry in the Great Record. "
                                           @ "Rejoin <<your> Hub and await instructions.";
IDSTR_CC3_OBJ1_SHORT             = 00205808, "Escort Mobile Nexus to Nav001 and await instructions.";
IDSTR_CC3_OBJ1_LONG              = 00205809, "Escort//assist Mobile Nexus to Nav001 and await//attend//open to further instructions.";
IDSTR_CC3_OBJ1_BMPNAME           = 00205810, "CC3_obj1.bmp";
IDSTR_CC3_OBJ2_SHORT             = 00205811, "Escort Mobile Nexus to Nexus Prime at Nav002.";
IDSTR_CC3_OBJ2_LONG              = 00205812, "Escort//disburse//assist Mobile Nexus to Nexus Prime at Nav002.";
IDSTR_CC3_OBJ2_BMPNAME           = 00205813, "";
IDSTR_CC3_OBJ3_SHORT             = 00205814, "Escort//relay Mobile Nexus to Nav003 for emergency extraction.";
IDSTR_CC3_OBJ3_LONG              = 00205815, "Escort//herd//relay Mobile Nexus to Nav003 for emergency extraction.";
IDSTR_CC3_OBJ3_BMPNAME           = 00205816, "";
IDSTR_CC3_OBJ4_SHORT             = 00205817, "Ensure//assert Mobile Nexus is not destroyed.";
IDSTR_CC3_OBJ4_LONG              = 00205818, "Ensure//guarantee//assert Mobile Nexus is not destroyed//hindered//disrupted.";
IDSTR_CC3_OBJ4_BMPNAME           = 00205819, "CC3_obj2.bmp";
IDSTR_CC3_OBJ5_SHORT             = 00205820, "Destroy//sanitize all animals in the area.";
IDSTR_CC3_OBJ5_LONG              = 00205821, "Destroy//purify//sanitize all animals intruding//entering//existing in the area.";
IDSTR_CC3_OBJ5_BMPNAME           = 00205822, "CC3_obj3.bmp";
IDSTR_CC3_NEX01                  = 00205823, "NEXUS: You are directed//permitted to approach NAV 002. Alter vector immediately. ACKNOWLEDGE//SUBMIT!";
IDSTR_CC3_NEX02                  = 00205824, "NEXUS: Human\\\\animals on intercept course. Abort current travel vector. Proceed to NAV 003 for emergency extraction."
                                             @ "Priority function: protect the convoy. ACKNOWLEDGE//SUBMIT!";
IDSTR_CC3_NEX03                  = 00205825, "NEXUS: WARNING: Do not lead the human\\\\animals to ground nexus location! Alter vector or your program will be terminated!";
IDSTR_CC3_NEX04                  = 00205826, "NEXUS: Landing zone is secure. Transport is proceeding on retrieval vector. Prepare for retrieval, unit.";
IDSTR_CC3_NEX05                  = 00205827, "NEXUS: Landing zone remains infected with animal warforms. Transport will commence retrieval after target area\\\\sector is clear.";

IDSTR_CC3_DEBRIEF_FAIL           = 00205828, "Objective failure\\\\inefficiency. \n\nThe Mobile Nexus was lost\\\\destroyed\\\\scrapped. <<Unit> inefficiency is noted//branded. <<Unit> program has been downgraded\\\\mulched.";
IDSTR_CC3_NEXTMISSION            = 00205829, "CD1";

//---------MISSION CD1-----------------------------------------------------------
IDSTR_CD1_TITLE                  = 00205900, "Desecrate//Destroy//Demoralize";
IDSTR_CD1_LOCATION               = 00205901, "HOMEWORLD\\\\DESIRE >> Assault Zone 'China'";
IDSTR_CD1_CAMPAIGN               = 00205902, "Siege 4";
IDSTR_CD1_DATE                   = 00205903, "3598000";
IDSTR_CD1_SHORTBRIEF             = 00205904, "Destroy population center around Nav001. Hurt//maim//kill all human\\\\animal warforms.";
IDSTR_CD1_LONGBRIEF              = 00205905, "The NEXT continue to devastate the human\\\\animal vessels defending Homeworld\\\\Desire.\n\n"
                                              @   "TACTICAL ANALYSIS:  Human\\\\animals fight with efficiency\\\\resilience. \nCore Directive "
                                              @   "requires demoralization\\\\disruption of human\\\\animal \"will-to-resist.\"\n\nSOLUTION: "
                                              @   "Destroy//disrupt//desecrate human\\\\animal population centers. \n\nInstill//cultivate >>TERROR<<<<. "
                                              @   "\n\n<<You> and <<your> unit-subordinates will spearhead//lead the destruction of the population centers. "
                                              @   "Destroy animal cities, homes, lives. Especially target human newboots.\n\nEXECUTE CORE DIRECTIVE!\n\nHURT//MAIM//KILL.";
IDSTR_CD1_MEDIA                  = 00205906, "CD1_briefing.smk";
IDSTR_CD1_DEBRIEF_SUCC           = 00205907, "Excellent\\\\efficient. <<Unit> efficiency is recorded. \n\nAnimal transmissions indicate impaired\\\\depressed "
                                              @   "behaviorial function.\n\nThe Core Directive advances.";
IDSTR_CD1_OBJ1_SHORT             = 00205908, "Destroy human\\\\animal creed\\\\icon near Nav001.";
IDSTR_CD1_OBJ1_LONG              = 00205909, "Destroy human\\\\animal creed\\\\icon at center of urban construct::: >>Xi'an<<<< religious complex near Nav001.";
IDSTR_CD1_OBJ1_BMPNAME           = 00205910, "CD1_OBJ1.bmp";
IDSTR_CD1_OBJ2_SHORT             = 00205911, "Destroy//demolish all human\\\\animal war machines.";
IDSTR_CD1_OBJ2_LONG              = 00205912, "Destroy//demolish//lick all human\\\\animal warforms.";
IDSTR_CD1_OBJ2_BMPNAME           = 00205913, "CD1_OBJ2.bmp";
IDSTR_CD1_OBJ3_SHORT             = 00205914, "Destroy\\\\disrupt half the High Temples.";
IDSTR_CD1_OBJ3_LONG              = 00205915, "Destroy\\\\disrupt half the High Temples to depress//demoralize the animals. \nLet them know//perceive the other half "
                                             @ "is also doomed\\\\terminal.";
IDSTR_CD1_OBJ3_BMPNAME           = 00205916, "CD1_OBJ3.bmp";
IDSTR_CD1_OBJ4_SHORT             = 00205917, "Destroy//burn escaping vehicles.";
IDSTR_CD1_OBJ4_LONG              = 00205918, "Target//destroy//burn escaping civilian transport-vehicles. \nObjective is to impair//depress//terrorize population.";
IDSTR_CD1_OBJ4_BMPNAME           = 00205919, "CD1_OBJ4.bmp";
IDSTR_CD1_DEBRIEF_FAIL           = 00205923, "Objective failure\\\\inefficiency. \n\nThe human\\\\animals display uplifted\\\\enhanced motivation after observing <<your> "
                                             @ "inability to destroy//crush their lair. \nEven their newboots escaped <<you>. Unfortunate\\\\pathetic.";
IDSTR_CD1_NEXTMISSION            = 00205924, "CD3";
IDSTR_CD1_NEX01                  = 00205925, "NEXUS: Artillery warforms are in place and await your instructions.";
IDSTR_CD1_NEX02                  = 00205926, "NEXUS: Human\\\\animal units flee//evade. Destroy these units if possible.  ACKNOWLEDGE\\\\SUBMIT!";
IDSTR_CD1_SUB01                  = 00205928, "NEXUS: Alpha unit: Locate and desecrate human\\\\animal creed\\\\worship\\\\temple-constructs.";
IDSTR_CD1_SUB02                  = 00205930, "NEXUS: Priority target equals primary human\\\\animal creed-totem\\\\false-idol.";

//---------MISSION CD3-----------------------------------------------------------
IDSTR_CD3_TITLE                  = 00206100, "Escort//Establish";
IDSTR_CD3_LOCATION               = 00206101, "HOMEWORLD\\\\DESIRE >> Assault Zone 'China'";
IDSTR_CD3_CAMPAIGN               = 00206102, "Siege 4";
IDSTR_CD3_DATE                   = 00206103, "3598700";
IDSTR_CD3_SHORTBRIEF             = 00206104, "Escort Mobile Nexus to Nav001.";
IDSTR_CD3_LONGBRIEF              = 00206105, "TACTICAL STATUS: The NEXT  control Homeworld\\\\Desire orbital space. \n<<Giver-of-Will> wishes to achieve "
                                             @ "control of ground assault sectors. "
                                             @ "\n\nPROBLEM: Animals fled from orbit to regroup planetside. They seek to halt//impede//annoy <<our> advance\\\\destiny."
                                             @ "\n\nSOLUTION: Alter strategic positioning. Escort Nexus-3220 to designated location for new iteration of assault strategy. "
                                             @ "HURT//MAIM//KILL. all human\\\\animal units encountered. "
                                             @ "\n\nACKNOWLEDGE//SUBMIT!\n\n\nSUPPLEMENTAL DATA:\n\n\x97\tUpon arrival at objective\\destination, "
                                             @ "Nexus-3220 will reprogram//convert//assimilate the human\\animal base system\\controls\\defenses.";
IDSTR_CD3_MEDIA                  = 00206106, "CD3_briefing.smk";
IDSTR_CD3_DEBRIEF_SUCC           = 00206107, "<<Destroyer-of-Animals: Second>, <<you> have executed instructions with superior efficiency. "
                                             @ "\n\nAssault strategy proceeds//advances within acceptable parameters. Choosers-of-Strategies now begin "
                                             @ "execution of final Core Directive subroutines.\n\nHomeworld\\\\Desire shall soon be evolved//enlightened.";
IDSTR_CD3_OBJ1_SHORT             = 00206108, "Clear path for the Nexus advancing to Nav001.";
IDSTR_CD3_OBJ1_LONG              = 00206109, "Clear//sweep//burn path for Nexus-3220 advancing to Nav001.";
IDSTR_CD3_OBJ1_BMPNAME           = 00206110, "CD3_OBJ1.bmp";

IDSTR_CD3_OBJ2_SHORT             = 00206111, "Destroy//burst all animal resistance encountered.";
IDSTR_CD3_OBJ2_LONG              = 00206112, "Destroy//eliminate//burst all human\\\\animal resistance encountered//embraced.";
IDSTR_CD3_OBJ2_BMPNAME           = 00206113, "CD3_OBJ2.bmp";

IDSTR_CD3_OBJ3_SHORT             = 00206114, "Protect//defend Nexus-3220.";
IDSTR_CD3_OBJ3_LONG              = 00206115, "Protect//defend//nurture Nexus-3220.";
IDSTR_CD3_OBJ3_BMPNAME           = 00206116, "CD3_OBJ3.bmp";

IDSTR_CD3_DEBRIEF_FAIL           = 00206123, "Objective failure\\\\inefficiency. \n\nNexus-3220 did not reach optimal\\\\desired location. "
                                             @ "Core Directive has been delayed.";
IDSTR_CD3_NEXTMISSION            = 00206124, "cd4";

IDSTR_CD3_NEX01                  = 00206125, "NEXUS PRIME: Human\\\\animal approaches//attacks from 180 degrees. Do not let the Nexus be damaged\\\\destroyed!";

//---------MISSION CD4-----------------------------------------------------------
IDSTR_CD4_TITLE                  = 00206200, "Hunt//Find//Kill";
IDSTR_CD4_LOCATION               = 00206201, "HOMEWORLD\\\\DESIRE >> Assault Zone 'China'";
IDSTR_CD4_CAMPAIGN               = 00206202, "Siege 4";
IDSTR_CD4_DATE                   = 00206203, "3610000";
IDSTR_CD4_SHORTBRIEF             = 00206204, "Intercept <Caanon Weathers> at Nav001 and destroy it.";
IDSTR_CD4_LONGBRIEF              = 00206205, "TACTICAL STATUS: Core Directive has progressed efficiently.  We//the NEXT approach Nova Alexandria "
                                            @ "and <<Epimetheus>.\n\nPROBLEM: Animal predator designated <<Caanon Weathers> has entered sector 32. "
                                            @ "This predator seeks merger\\\\union with a human warrior group.  Such merger would disrupt the Core Directive timeline. "
                                            @ "\n\nSOLUTION: Destroy the animal predator.  Prevent union of human forces.\n\n"
                                            @ "NEW CORE DIRECTIVE PRIORITY: Destroy <<Caanon Weathers>.  HURT//MAIM//KILL.\n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CD4_MEDIA                  = 00206206, "CD4_briefing.smk";
IDSTR_CD4_DEBRIEF_SUCC           = 00206207, "<<Killer-of-Animals: Second>, <<your> efficiency has been exceptional\\\\impressive\\\\extraordinary. "
                                            @ "\n\nExemplar Sect declares <<your> elevation to <<Destroyer-of-Animals: First>. \n\nNewboots and redacted <<units> "
                                            @ "have been conditioned to emulate <<your> programming. Offlining the aminal predator has undermined the "
                                            @ "determination\\\\resistance of the humans.\n\nAnimal-designate:::<<Caanon> was a noted\\\\dangerous\\\\significant "
                                            @ "war unit.\n\nThe way is open to <<Epimetheus>.";
IDSTR_CD4_OBJ1_SHORT             = 00206208, "Intercept animal-designate:::\<Caanon Weathers> at Nav001 and destroy him.";
IDSTR_CD4_OBJ1_LONG              = 00206209, "Intercept//curb animal-designate:::\<Caanon Weathers> at Nav001 and destroy//purge//gut him.";
IDSTR_CD4_OBJ1_BMPNAME           = 00206210, "CD4_OBJ1.bmp";
IDSTR_CD4_OBJ2_SHORT             = 00206211, "Summon transport after erasing target:::\<Icehawk>.";
IDSTR_CD4_OBJ2_LONG              = 00206212, "Summon transport after erasing target:::\<Icehawk>.";
IDSTR_CD4_OBJ2_BMPNAME           = 00206213, "CD4_OBJ2.bmp";
IDSTR_CD4_OBJ3_SHORT             = 00206214, "Destroy//purge all animal resistance.";
IDSTR_CD4_OBJ3_LONG              = 00206215, "Destroy//purge all animal resistance\\\\defiance\\\\spryness.";
IDSTR_CD4_OBJ3_BMPNAME           = 00206216, "CD4_OBJ3.bmp";
IDSTR_CD4_DEBRIEF_FAIL           = 00206223, "Objective failure\\\\inefficiency >> SURPRISE. \n\nRemoval of animal predator\\\\leader is necessary to undermine human\\\\animal resistance efficiency.";
IDSTR_CD4_NEX01                  = 00206224, "NEXUS: WARNING: Inquisitor drones have lost sensor contact with the animal \<Caanon Weathers>."
                                             @ "  Continue mission as directed.  Proceed to Nav001 and investigate.";
IDSTR_CD4_NEXTMISSION            = 00206299, "CE2";

//---------MISSION CE2-----------------------------------------------------------
IDSTR_CE2_TITLE                  = 00206300, "Heresy\\\\Corruption";
IDSTR_CE2_LOCATION               = 00206301, "HOMEWORLD\\\\DESIRE >> Core Assault Zone";
IDSTR_CE2_CAMPAIGN               = 00206302, "Siege 5";
IDSTR_CE2_DATE                   = 00206303, "3613492";
IDSTR_CE2_SHORTBRIEF             = 00206304, "Destroy heretics\\\\metagens.";
IDSTR_CE2_LONGBRIEF              = 00206305, "TACTICAL STATUS: Assault on human\\\\animal city Nova Alexandria proceeds as expected//projected.\n\n"
                                            @"PROBLEM: Zeitgeist Unit displays evidence of corrupted programming\\\\heresy.\n\nThe <<unit> failed to complete "
                                            @ "destruction of animal convoy. The <<unit> has severed contact with Nexus.\n\nSOLUTION: Proceed to sector 3212. "
                                            @ "Seek out and destroy the heretic <<units>. Complete their mission objectives.\n\nDo not communicate with the heretics. "
                                            @ "Corruption may be transferable.\n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CE2_MEDIA                  = 00206306, "CE2_briefing.smk";
IDSTR_CE2_DEBRIEF_SUCC           = 00206307, "The Core Directive proceeds//advances within optimal parameters. Choosers-of-Strategies prepare to execute FINAL Core Directive "
                                            @ "subroutines. Human\\\\animal city Nova Alexandria shall be overcome//ruptured. \n\nPraise <<Giver-of-Will>!";
IDSTR_CE2_OBJ1_SHORT             = 00206308, "Destroy heretic NEXT \<units>.";
IDSTR_CE2_OBJ1_LONG              = 00206309, "Destroy heretic\\\\malfunctioning\\\\corrupted NEXT \<units>.";
IDSTR_CE2_OBJ1_BMPNAME           = 00206310, "CE2_OBJ1.bmp";
IDSTR_CE2_OBJ2_SHORT             = 00206311, "Destroy heretic\\\\corrupted \<units'> transportation before liftoff//retreat.";
IDSTR_CE2_OBJ2_LONG              = 00206312, "";
IDSTR_CE2_OBJ2_BMPNAME           = 00206313, "";
IDSTR_CE2_OBJ3_SHORT             = 00206314, "Destroy//murder the conveyance\\\\cargo vehicles.";
IDSTR_CE2_OBJ3_LONG              = 00206315, "Destroy//eliminate//murder the animal conveyance\\\\cargo vehicles before they complete resupply.";
IDSTR_CE2_OBJ3_BMPNAME           = 00206316, "CE2_OBJ3.bmp";
IDSTR_CE2_OBJ4_SHORT             = 00206317, "Destroy//sterilize defensive\\\\structures at Nav002.";
IDSTR_CE2_OBJ4_LONG              = 00206318, "Destroy//pound//sanitize the animal defensive\\structures located at Nav002.";
IDSTR_CE2_OBJ4_BMPNAME           = 00206319, "";
IDSTR_CE2_DEBRIEF_FAIL           = 00206332, "Objective failure\\\\inefficiency. \n\nMany heretics\\\\malfunctions\\\\metagens succeeded in escaping. \n\nOriginal objectives were not efficiently completed\\\\consummated.";
IDSTR_CE2_NEX01                  = 00206333, "NEXUS: Human\\\\animal convoy is located. Proceed to Nav 001 and destroy! ACKNOWLEDGE//SUBMIT!";
IDSTR_CE2_RDF01                  = 00206334, "REDACTOR-FOUR: WARNING! Heresy\\\\malfunction detected in Quad-subordinate! Destroy//purge//cleanse!";
IDSTR_CE2_RDF02                  = 00206335, "REDACTOR-FOUR: Heretics are retreating\\\\escaping! Destroy <<their> conveyance\\\\transport.";
IDSTR_CE2_RDF03                  = 00206336, "REDACTOR-FOUR: Convoy destruction now inefficient\\\\late\\\\useless. New Program: Eradicate human defensive structures\\\\weapons. ACKNOWLEDGE//SUBMIT!";

IDSTR_CE2_NEXTMISSION            = 00206399, "CE3";

//---------MISSION CE3-----------------------------------------------------------
IDSTR_CE3_TITLE                  = 00206400, "Isolate//Inoculate//Annihilate";
IDSTR_CE3_LOCATION               = 00206401, "HOMEWORLD\\\\DESIRE >> Core Assault Zone";
IDSTR_CE3_CAMPAIGN               = 00206402, "Siege 5";
IDSTR_CE3_DATE                   = 00206403, "3614000";
IDSTR_CE3_SHORTBRIEF             = 00206404, "Destroy defensive outpost at Nav001.";
IDSTR_CE3_LONGBRIEF              = 00206405, "TACTICAL STATUS: Target Nova Alexandria is well-fortified. \n\n<<Epimetheus\\\\Human-Leader: Prime> "
                                             @   "collected//hoarded considerable resources.\n\nPROBLEM: Trojan Horse <<units> failed to disrupt "
                                             @   "the humans' protective shields. Prolonged bombardment has not penetrated this defense.\n\n"
                                             @   "SOLUTION:  Proceed to sector 2111.  Destroy animal defensive posts outside Nova Alexandria. "
                                             @   "Other units shall follow. HURT//MAIM//KILL.\n\nACKNOWLEDGE//SUBMIT!";
IDSTR_CE3_MEDIA                  = 00206406, "CE3_briefing.smk";
IDSTR_CE3_DEBRIEF_SUCC           = 00206407, "<<Destroyer-of-Animals: First>, <<you> have again executed directives with unparalled efficiency. "
                                             @   "\n\nThe Core Directive proceeds//advances within acceptable parameters.  We//the NEXT begin FINAL "
                                             @   "Core Directive subroutines. Homeworld\\\\Desire shall soon be evolved//enlightened.\n\nPraise <<Giver-of-Will>!";
IDSTR_CE3_OBJ1_SHORT             = 00206408, "Destroy//eviscerate defensive outpost at Nav001.";
IDSTR_CE3_OBJ1_LONG              = 00206409, "Destroy//eviscerate defensive outpost at Nav001. \nPrepare//open//scorch way for approach to \<Epimetheus\\\\Human-Leader: Prime>.";
IDSTR_CE3_OBJ1_BMPNAME           = 00206410, "CE3_OBJ1.bmp";
IDSTR_CE3_OBJ2_SHORT             = 00206411, "Destroy//reduce all human\\\\animal warforms.";
IDSTR_CE3_OBJ2_LONG              = 00206412, "Destroy//scuttle//reduce all human\\\\animal warforms encountered.";
IDSTR_CE3_OBJ2_BMPNAME           = 00206413, "CE3_OBJ2.bmp";
IDSTR_CE3_DEBRIEF_FAIL           = 00206423, "Objective failure\\\\inefficiency. \n\nThe animals persist//continue//dare to resist Core Directive implementation.";
IDSTR_CE3_NEXTMISSION            = 00206424, "ce4";
IDSTR_CE3_SUB01                  = 00206426, "NEXUS: Initiating aerial attack\\\\bombardment sequence.";
IDSTR_CE3_SUB02                  = 00206428, "NEXUS: NEXT reinforcement units deployed//attacking.";

//---------MISSION CE4-----------------------------------------------------------
IDSTR_CE4_TITLE                  = 00206500, "HURT//MAIM//KILL";
IDSTR_CE4_LOCATION               = 00206501, "HOMEWORLD\\\\DESIRE >> Core Assault Zone";
IDSTR_CE4_CAMPAIGN               = 00206502, "Siege 5";
IDSTR_CE4_DATE                   = 00206503, "9999999";
IDSTR_CE4_SHORTBRIEF             = 00206504, "Murder//kill//burst <Harabec Weathers>.";
IDSTR_CE4_LONGBRIEF              = 00206505, "The animal predator designated <<Harabec Weathers> has broadcast//communicated//desired to face "
                                             @ "the destroyer of his womb-brother\\\\littermate.\n\nHe challenges <<you>, <<Killer-of-Animals: First>."
                                             @ "\n\nANALYSIS: Human predator <<Harabec Weathers> is strongest//most dangerous animal remaining. He "
                                             @ "protects//defends Nova Alexandria. He leads animal resistance efficiently.\n\nSOLUTION: Destroy him. "
                                             @ "\n\nHURT//MAIM//KILL.";
IDSTR_CE4_MEDIA                  = 00206506, "CE4_briefing.smk";
IDSTR_CE4_DEBRIEF_SUCC           = 00206507, "<<CORE DIRECTIVE> COMPLETED//CONSUMMATED//EXECUTED.\n\nProcess >>RAPTURE<<<<.\n\n<<Giver-of-Will> has triumphed//prevailed!";
IDSTR_CE4_OBJ1_SHORT             = 00206508, "Kill >Harabec\\\\Phoenix\\\\representative-body\\\\escort<.";
IDSTR_CE4_OBJ1_LONG              = 00206509, "Kill//defeat//gut animal predator\\\\leader designate: >Harabec Weathers\\\\Phoenix\\\\representative-body\\\\escort<. \n\nSuccessful termination of this troublesome\\\\efficient animal "
                                             @ "unit will undermine//erode//sandbag human\\\\animal will-to-resist.";
IDSTR_CE4_OBJ1_BMPNAME           = 00206510, "ce4_obj1.bmp";
IDSTR_CE4_DEBRIEF_FAIL           = 00206523, "Objective failure\\\\inefficiency. \n\nFailure\\\\shame\\\\disarray. \n\nAnimal-designate: <<Phoenix> continues to lead//inspire humans.";
IDSTR_CE4_NEXTMISSION            = 00206524, "";

// Training Missions
IDSTR_TRAINING_1                 = 00210000, "Basic Navigation";
IDSTR_TRAINING_2                 = 00210001, "Advanced Navigation";
IDSTR_TRAINING_3                 = 00210002, "Weapons Systems";
IDSTR_TRAINING_4                 = 00210003, "Squadmates and Tactics";


// Generic Human Dialog============================================================
IDSTR_GEN_HAR1                   =00220001, "HARABEC: What's your problem?";
IDSTR_GEN_HAR2                   =00220002, "HARABEC: Watch your fire, duster!";
IDSTR_GEN_HAR3                   =00220003, "HARABEC: Hey! Finger off the trigger!";
IDSTR_GEN_HAR4                   =00220004, "HARABEC: Is your targeting computer defective?";
IDSTR_GEN_HAR5                   =00220005, "HARABEC: I get it...! You're an Imperial spy...!";
IDSTR_GEN_HAR6                   =00220006, "HARABEC: Gonna burn you now, scrub...!";
IDSTR_GEN_HAR7                   =00220007, "HARABEC: Why, you damn traitor...! Eat this!";
IDSTR_GEN_HAR8                   =00220008, "HARABEC: Fine! You want some?";
IDSTR_GEN_HAR9                   =00220009, "HARABEC: Stay on the bounce!";
IDSTR_GEN_HAR10                  =00220010, "HARABEC: Niiiice one...!";
IDSTR_GEN_HAR11                  =00220011, "HARABEC: Watch your six, duster!";
IDSTR_GEN_HAR12                  =00220012, "HARABEC: Oh, yeaaahhh... Right there...!";
IDSTR_GEN_CAN1                   =00220013, "CAANON: Defective equipment, soldier?";
IDSTR_GEN_CAN2                   =00220014, "CAANON: This is unacceptable.";
IDSTR_GEN_CAN3                   =00220015, "CAANON: You panic easily, eh?";
IDSTR_GEN_CAN4                   =00220016, "CAANON: That shows very poor discipline.";
IDSTR_GEN_CAN5                   =00220017, "CAANON: Taste your own medicine!";
IDSTR_GEN_CAN6                   =00220018, "CAANON: ";
IDSTR_GEN_CAN7                   =00220019, "CAANON: You're insane - and dead.";
IDSTR_GEN_CAN8                   =00220020, "CAANON: I'm going to burn you.";
IDSTR_GEN_CAN9                   =00220021, "CAANON: Watch your firing chains!";
IDSTR_GEN_CAN10                  =00220022, "CAANON: Vape 'em!";
IDSTR_GEN_CAN11                  =00220023, "CAANON: Keep moving, soldier!";
IDSTR_GEN_CAN12                  =00220024, "CAANON: Chain two - FIRE!";
IDSTR_GEN_TCM1                   =00220025, "TAC-COM: TAC-COM here. Be advised: You're off-course. Do you need assistance?";
IDSTR_GEN_TCM2                   =00220026, "TAC-COM: This is TAC-COM. You have left the mission zone. Hold your position."
                                            @" A rescue crew is on the way.";
IDSTR_GEN_TCV1                   =00220027, "TAC-COM: TAC-COM here, sir. You are off-course. Is there something wrong?";
IDSTR_GEN_TCV2                   =00220028, "TAC-COM: This is TAC-COM, sir. You have left the mission zone. Hold your position."
                                            @" Pickup has been authorized.  Mission is terminated.";
IDSTR_GEN_AR11                   =00220029, "ARTILLERY: Artillery unit here. We're in position.";
IDSTR_GEN_AR12                   =00220030, "ARTILLERY: Artillery unit here, boss. Ready to cut loose.";
IDSTR_GEN_AR13                   =00220031, "ARTILLERY: You're on, boss. Opening up now.";
IDSTR_GEN_AR14                   =00220032, "ARTILLERY: Rrrroj... Target is toast.";
IDSTR_GEN_AR15                   =00220033, "ARTILLERY: We're out of shells, boss. Bugging out.";
IDSTR_GEN_AR16                   =00220034, "ARTILLERY: Ceasing fire...";
IDSTR_GEN_AR17                   =00220035, "ARTILLERY: Artillery unit here. I need someone to paint that.";
IDSTR_GEN_AR18                   =00220036, "ARTILLERY: Roj that. Moving to new location.";
IDSTR_GEN_AR19                   =00220037, "ARTILLERY: Bogies inbound our position. We're bugging out.";
IDSTR_GEN_AR21                   =00220038, "ARTILLERY: Artillery unit calling. Have reached position.";
IDSTR_GEN_AR22                   =00220039, "ARTILLERY: Artillery unit here. Fire on your mark.";
IDSTR_GEN_AR23                   =00220040, "ARTILLERY: Copy that, sir. The package is in the air.";
IDSTR_GEN_AR24                   =00220041, "ARTILLERY: Yes, sir - Fire in the hole!";
IDSTR_GEN_AR25                   =00220042, "ARTILLERY: Out of ordnance, sir. We're heading for the LZ.";
IDSTR_GEN_AR26                   =00220043, "ARTILLERY: Ceasing fire...";
IDSTR_GEN_AR27                   =00220044, "ARTILLERY: Artillery unit here. I need a spotter.";
IDSTR_GEN_AR28                   =00220045, "ARTILLERY: Copy that. Repositioning to new location.";
IDSTR_GEN_AR29                   =00220046, "ARTILLERY: Hostiles en route to our location - breaking off!";
IDSTR_GEN_RCC1                   =00220047, "REBEL: Roj, we're cut off!";
IDSTR_GEN_RCC2                   =00220048, "REBEL: Break to the side, duster!";
IDSTR_GEN_RCC3                   =00220049, "REBEL: Watch it! More of 'em comin' in!";
IDSTR_GEN_RCC4                   =00220050, "REBEL: Somebody shut that bastard down!";
IDSTR_GEN_RCC5                   =00220051, "REBEL: Aim for the cockpit!";
IDSTR_GEN_RCC6                   =00220052, "REBEL: Roj, going to the mark!";
IDSTR_GEN_RCC7                   =00220053, "REBEL: Structure popped like a weasel!";
IDSTR_GEN_RCC8                   =00220054, "REBEL: Squik the bastard!";
IDSTR_GEN_RCC9                   =00220055, "REBEL: Watch my back, yeh?";
IDSTR_GEN_RCC10                  =00220056, "REBEL: Catching a lot of hee-e-eat!";
IDSTR_GEN_RCC11                  =00220057, "REBEL: Roj! Roll right, duster!";
IDSTR_GEN_RCC12                  =00220058, "REBEL: Left! Left! Left!";
IDSTR_GEN_RCC13                  =00220059, "REBEL: Pour it on!";
IDSTR_GEN_RCC14                  =00220060, "REBEL: I'm holding ground!";
IDSTR_GEN_RCC15                  =00220061, "REBEL: Getting chewed up over here!";
IDSTR_GEN_ICC1                   =00220062, "IMPERIAL: There goes our ride...!";
IDSTR_GEN_ICC2                   =00220063, "IMPERIAL: Copy that! Moving to cover!";
IDSTR_GEN_ICC3                   =00220064, "IMPERIAL: Bogies on the perimeter.";
IDSTR_GEN_ICC4                   =00220065, "IMPERIAL: Snap the line tight!";
IDSTR_GEN_ICC5                   =00220066, "IMPERIAL: Copy that! Centering fire!";
IDSTR_GEN_ICC6                   =00220067, "IMPERIAL: Target lock!";
IDSTR_GEN_ICC7                   =00220068, "IMPERIAL: Stationary objective destroyed! ";
IDSTR_GEN_ICC8                   =00220069, "IMPERIAL: Watch the crossfire!";
IDSTR_GEN_ICC9                   =00220070, "IMPERIAL: Watch your six!";
IDSTR_GEN_ICC10                  =00220071, "IMPERIAL: Copy that! Moving to intercept!";
IDSTR_GEN_ICC11                  =00220072, "IMPERIAL: Spin left and pin!";
IDSTR_GEN_ICC12                  =00220073, "IMPERIAL: Push right! Move!";
IDSTR_GEN_ICC13                  =00220074, "IMPERIAL: Concentrate fire!";
IDSTR_GEN_ICC14                  =00220075, "IMPERIAL: Switch chains, damn it!";
IDSTR_GEN_ICC15                  =00220076, "IMPERIAL: Taking too many hits!";
IDSTR_GEN_DS11                   =00220077, "DROPSHIP: Getting scorched, gotta pull off!";
IDSTR_GEN_DS12                   =00220078, "DROPSHIP: Looking for a clear patch to drop!";
IDSTR_GEN_DS13                   =00220079, "DROPSHIP: This place crawls, I'm gone!";
IDSTR_GEN_DS14                   =00220080, "DROPSHIP: We're in the tube and on schedule!";
IDSTR_GEN_DS15                   =00220081, "DROPSHIP: Get the bed ready, girls, we're comin' in!";
IDSTR_GEN_DS16                   =00220082, "DROPSHIP: This bird is on the tarmac.";
IDSTR_GEN_DS17                   =00220083, "DROPSHIP: We are off the dirt, girls.";
IDSTR_GEN_DS21                   =00220084, "DROPSHIP: Too much heat - we are breaking off.";
IDSTR_GEN_DS22                   =00220085, "DROPSHIP: Looking for a drop point.";
IDSTR_GEN_DS23                   =00220086, "DROPSHIP: Too many hostiles! Bugging out!";
IDSTR_GEN_DS24                   =00220087, "DROPSHIP: Vector locked on your coordinates";
IDSTR_GEN_DS25                   =00220088, "DROPSHIP: All units, clear the LZ for hot descent.";
IDSTR_GEN_DS26                   =00220089, "DROPSHIP: Countdown initiated for final approach.";
IDSTR_GEN_DS27                   =00220090, "DROPSHIP: Takeoff initiated. Thrusters on full.";
IDSTR_GEN_STATIC01               =00220091, "Static... Static...";

// Generic Cybrid Dialog============================================================
IDSTR_CYB_NEX01                  =00230001, "NEXUS: ACKNOWLEDGE//SUBMIT! Unit, you are off-course\\\\inefficient. Reassess decision string immediately!";
IDSTR_CYB_NEX02                  =00230002, "NEXUS: WARNING\\\\INEFFICIENT! Unit, you have departed from the mission area.  Mission is terminated.  Report\\\\submit to Redactors-of-Programming!";
IDSTR_CYB_NEX03                  =00230003, "NEXUS: Understood. Secure landing zone confirmed//acknowledged.";
IDSTR_CYB_NEX04                  =00230004, "NEXUS: Program\\\\task completed. Praise Giver-of-Will!";
IDSTR_CYB_NEX05                  =00230005, "ARTILLERY: Artillery warforms functional\\\\loaded. Awaiting targeting coordinates.";
IDSTR_CYB_NEX06                  =00230006, "NEXUS: WARNING: Human\\\\animal warforms detected on attack vector.";
IDSTR_CYB_NEX07                  =00230007, "NEXUS: New mission objective. Attend//open//submit!";
IDSTR_CYB_NEX08                  =00230008, "NEXUS: Proceed to Nav zero-zero-one";
IDSTR_CYB_NEX09                  =00230009, "NEXUS: Proceed to Nav zero-zero-two.";
IDSTR_CYB_NEX10                  =00230010, "NEXUS: Proceed to Nav zero-zero-three.";
IDSTR_CYB_NEX11                  =00230011, "NEXUS: Proceed to Nav zero-zero-four.";
IDSTR_CYB_NEX12                  =00230012, "ARTILLERY: Artillery warform is in range.";
IDSTR_CYB_NEX13                  =00230013, "ARTILLERY: Artillery warform is out of range.";
IDSTR_CYB_NEX14                  =00230014, "ARTILLERY: Artillery warform is out of ammunition.";
IDSTR_CYB_NEX15                  =00230015, "ARTILLERY: Artillery warform reports target is acquired.";
IDSTR_CYB_NEX16                  =00230016, "ARTILLERY: Artillery warform reports target is destroyed.";
IDSTR_CYB_NEX17                  =00230017, "NEXUS: Mission objective complete.";

// Training Mission Dialog======================================================

// Training Mission Generics
IDSTR_TRG_HNTRAW                 =00230021,  "Warning! You are off course! Correct your course and head for Nav Alpha.";
IDSTR_TRG_HNTRBW                 =00230022,  "Warning! You are off course! Correct your course and head for Nav Bravo.";
IDSTR_TRG_HNTRCW                 =00230023,  "Warning! You are off course! Correct your course and head for Nav Charlie.";
IDSTR_TRG_HNTRDW                 =00230024,  "Warning! You are off course! Correct your course and head for Nav Delta.";
IDSTR_TRG_HNTRFW                 =00230025,  "Warning! You have failed to correct your course and you are leaving the training zone.";
IDSTR_TRG_HNTRYW                 =00230026,  "Warning! You are off course! Please correct your course and head for your Custom Nav Point.";
IDSTR_TRG_HNTRBP                 =00230027,  "Try again. Be patient!";
IDSTR_TRG_HNTRDP                 =00230028,  "Want a tip? Don't piss off your squadmates. You need them to watch your six.";
IDSTR_TRG_HNTRSS                 =00230029,  "You have successfully completed this training exercise.";
IDSTR_TRG_HNTRNJ                 =00230030,  "Nice job, recruit.";
IDSTR_TRG_HNTRGS                 =00230031,  "Good shooting!";
IDSTR_TRG_HNTRFL                 =00230032,  "This exercise is terminated.";
IDSTR_TRG_HNTRES                 =00230033,  "You can press ESC on your console to abort this training mission at any time.";
IDSTR_TRG_INTR01                 =00230034,  "";
IDSTR_TRG_INTR02                 =00230035,  "";
IDSTR_TRG_OUTR01                 =00230036,  "";
IDSTR_TRG_FOLLOWORDERS           =00230037,  "Learn to follow orders.\n\nMISSION FAILED";

// Training Misison One
IDSTR_TR1_INTR01                 =00230050,  "";
IDSTR_TR1_HNTR01                 =00230051,  "Welcome to phase one of pilot training. I am Sergeant Otobe. Today we'll "
                                            @"cover basic HERC movement and navigation. Press ESC on your console to "
                                            @"abort this training exercise at any time. These training exercises will "
                                            @"cover fundamental skills you need to survive encounters with Imperial "
                                            @"pilots, so pay close attention.";
IDSTR_TR1_HNTR02                 =00230052,  "These training exercises utilize the default key configuration. Any "
                                            @"changes you have made to customize your controls will not apply for "
                                            @"the duration of these exercises.";
IDSTR_TR1_HNTR03                 =00230053,  "Your first task is to learn how to move your vehicle. You control "
                                            @"your Herc's movement with your joystick or the arrow keys on your "
                                            @"keyboard.";
IDSTR_TR1_HNTR04                 =00230054,  "Pressing the UP arrow, or moving your joystick forward, will increase "
                                            @"your throttle and move your vehicle forward. Pressing the DOWN arrow, "
                                            @"or pulling back on the joystick, will decrease your throttle, and will "
                                            @"eventually shift your Herc into reverse if you continue to hold the "
                                            @"key or joystick down.";
IDSTR_TR1_HNTR06                 =00230056,  "To zero your throttle, press the BACKSPACE key, or center your joystick "
                                            @"handle. This will coast your vehicle to a stop. If you need to stop "
                                            @"quickly, use reverse throttle to help you slow down faster.";
IDSTR_TR1_HNTR07                 =00230057,  "The RIGHT and LEFT arrow keys steer your Herc. Moving your joystick "
                                            @"handle to the right and left does the same thing.";
IDSTR_TR1_HNTR08                 =00230058,  "Okay, that's the basics. Take a few seconds and practice moving your "
                                            @"Herc around.";
IDSTR_TR1_HNTR09                 =00230059,  "Good ... you're learning quickly! Now that you're familiar with the "
                                            @"controls, let's try a navigation exercise.";
IDSTR_TR1_HNTR10                 =00230060,  "Look at your Heads-Up Display, or HUD. You should now see a green pip "
                                            @"marked Nav Alpha. This is a Nav Point. Nav Points are used to guide "
                                            @"you to your objectives during missions. Before each mission, Nav Point "
                                            @"coordinates are downloaded into your Herc's computer, and will come up "
                                            @"when needed to help you find your way.";
IDSTR_TR1_HNTR11                 =00230061,  "When you reach a Nav Point, your computer will automatically cycle to "
                                            @"the next one in the mission, unless you've reached the last Nav Point. "
                                            @"When the Nav Point is off your screen, a small arrow on your HUD "
                                            @"will indicate the direction you need to turn in order to face it.";
IDSTR_TR1_HNTR12                 =00230062,  "Let's try navigating. Maneuver your Herc so that Nav Alpha lies in "
                                            @"the center of your screen. Then increase your throttle and move towards "
                                            @"Nav Alpha.";
IDSTR_TR1_HNTR13                 =00230063,  "At this point you should see a pair of pylons near Nav Alpha. Pass "
                                            @"between the pylons to clear the Nav Point.";
IDSTR_TR1_HNTR14                 =00230064,  "Good work! You should now see your next waypoint indicated on your HUD "
                                            @"as Nav Bravo. Maneuver your herc into a heading for that Nav Point, and "
                                            @"pass through it as you did for Nav Alpha.";  
IDSTR_TR1_HNTR15                 =00230065,  "Alright, good job.  That's all for today.";

// Training Mission Two
IDSTR_TR2_HNTR01                 =00230071,  "Welcome to phase two of the training program. This exercise covers "
                                            @"advanced navigation. You can press ESC on your console to abort this "
                                            @"training exercise at any time.";
IDSTR_TR2_HNTR02                 =00230072,  "In the first training exercise, you learned what Nav Points are and "
                                            @"how to navigate them. Today, you will learn how to create and use custom "
                                            @"Nav Points, and you'll learn how to use the satellite map.";
IDSTR_TR2_HNTR03                 =00230073,  "Custom Nav Points are ones you set yourself to assist you and your "
                                            @"squadmates to navigate through a combat zone.";
IDSTR_TR2_HNTR04                 =00230074,  "Create a Nav Point at our current location by pressing the M key. This "
                                            @"way, we'll be able to find our way back to the base later.";
IDSTR_TR2_HNTR05                 =00230075,  "Good. Now proceed to the training area at Nav Alpha.";
IDSTR_TR2_HNTR06                 =00230076,  "Now let's use our satellite map to get oriented.";
IDSTR_TR2_HNTR07                 =00230077,  "Bring up the satellite map by pressing the ENTER key.";
IDSTR_TR2_HNTR08                 =00230078,  "";
IDSTR_TR2_HNTR09                 =00230079,  "";
IDSTR_TR2_HNTR10                 =00230080,  "";
IDSTR_TR2_HNTR11                 =00230081,  "";
IDSTR_TR2_HNTR12                 =00230082,  "";
IDSTR_TR2_HNTR13                 =00230083,  "";
IDSTR_TR2_HNTR14                 =00230084,  "You should now be able to see your new Nav Point on your HUD. On your "
                                            @"radar, the Nav Point shows up as the highlighted yellow box. Pilot "
                                            @"your Herc to the Nav Point.";
IDSTR_TR2_HNTR15                 =00230085,  "Good job. You can cycle through active Nav Points by pressing the N "
                                            @"key. As you press the N key, notice how the Nav Point indicator changes "
                                            @"from Nav Alpha to Nav Bravo, and then to your new Nav Point.";
IDSTR_TR2_HNTR16                 =00230086,  "Okay. Cycle through the Nav Points until you have Nav Bravo selected. "
                                            @"Then travel to Nav Bravo to complete this training exercise.";
IDSTR_TR2_HNTR17                 =00230087,  "Nice job, recruit. You've successfully completed this training exercise.";

// Training Mission 3
IDSTR_TR3_HNTR01                 =00230091,  "In phase three of the training program, we'll cover basic weapons use. "
                                            @"You can press ESC on your console to abort this training exercise at "
                                            @"any time.";
IDSTR_TR3_HNTR02                 =00230092,  "First, let's go over the basic systems on your Heads-Up Display. Your "
                                            @"weapons display is located on the left side of your HUD. This Herc is "
                                            @"armed with blasters, which require energy to fire. You can see the "
                                            @"amount of energy available for the blasters by looking at the energy "
                                            @"bars next to them.";
IDSTR_TR3_HNTR03                 =00230093,  "Squeeze off a couple of shots by pressing the left mouse button. See "
                                            @"the energy bars jump? You can fire energy weapons before they are fully "
                                            @"recharged, but you'll do less damage to your target.";
IDSTR_TR3_HNTR04                 =00230094,  "Now find the large yellow arrow that moves along the boundary of your "
                                            @"sensor display. That shows your reactor's energy reserve. Watch how "
                                            @"the reserve decreases as you fire the blasters.";
IDSTR_TR3_HNTR05                 =00230095,  "If you totally drain your reactor, your HUD will shut down and you will "
                                            @"lose targeting control until your reactor has a chance to recharge your "
                                            @"systems. Keep an eye on your energy use in combat - running out at the "
                                            @"wrong time could cost you your life.";
IDSTR_TR3_HNTR06                 =00230096,  "Okay, on to weapon management. You can link or unlink your weapons by "
                                            @"pressing the L key on your console. Linked weapons fire simultaneously "
                                            @"and provide more concentrated firepower, but won't fire as often as "
                                            @"unlinked weapons.";
IDSTR_TR3_HNTR07                 =00230097,  "Your weapon system is integrated with your targeting reticle, which is "
                                            @"controlled by your mouse. Your weapons will aim wherever you look, up "
                                            @"to a point. The firing arc of each weapon is limited.";
IDSTR_TR3_HNTR08                 =00230098,  "If you move your crosshair to the extreme edge of your screen, some of "
                                            @"your weapons may not be able to track that far. If a weapon can't fire "
                                            @"for this reason, your HUD will gray it out.";
IDSTR_TR3_HNTR09                 =00230099,  "There are two main status displays on your console. One indicates the "
                                            @"status of your Herc. The other indicates the damage level of your "
                                            @"current target.";
IDSTR_TR3_HNTR10                 =00230100,  "As either you or your target takes damage, the appropriate display will "
                                            @"change from grey to yellow to red. You can use this information to aim "
                                            @"at weakened areas on your target for a faster kill, or to keep your "
                                            @"own damaged areas out of the line of fire.";
IDSTR_TR3_HNTR11                 =00230101,  "You can target the nearest hostile on your sensor by pressing the T key "
                                            @"on your console. It is important to target an enemy before firing on "
                                            @"him. Your weapons automatically triangulate on the selected target. If "
                                            @"you fire without targeting, you will probably miss.";
IDSTR_TR3_HNTR12                 =00230102,  "Now let's move out to Nav Alpha for some weapons practice.";
IDSTR_TR3_HNTR13                 =00230103,  "As you near Nav Alpha, press T to target the nearest enemy tank. Note "
                                            @"that the enemy targets appear as red dots on your radar. Friendly "
                                            @"targets appear as yellow, and neutral targets appear as light blue.";
IDSTR_TR3_HNTR14                 =00230104,  "Press T to target the nearest enemy tank. Note that the enemy targets "
                                            @"appear as red dots on your radar. Friendly targets appear as yellow, "
                                            @"and neutral targets appear as light blue.";
IDSTR_TR3_HNTR15                 =00230105,  "Note that the enemy targets appear as red dots on your radar. Friendly "
                                            @"targets appear as yellow, and neutral targets appear as light blue.";
IDSTR_TR3_HNTR16                 =00230106,  "Press T to target the nearest enemy tank.";
IDSTR_TR3_HNTR17                 =00230107,  "When you have an enemy targeted, and on screen, a circle will appear "
                                            @"on your HUD. This is your target range and lead indicator.";
IDSTR_TR3_HNTR18                 =00230108,  "The target's range in meters is displayed above the lead indicator. "
                                            @"Your selected weapon's range is indicated by two small green triangles "
                                            @"at the edge of the circle. A third yellow triangle indicates the "
                                            @"distance to your target. When the yellow triangle moves in between the "
                                            @"green triangles, your target is in your weapon's range.";
IDSTR_TR3_HNTR19                 =00230109,  "The lead indicator is positioned directly on the targets in this "
                                            @"objective because they are not moving.";
IDSTR_TR3_HNTR20                 =00230110,  "Alright. Open fire and destroy the enemy tanks. Pay attention to "
                                            @"your target status display, and concentrate your fire on damaged areas.";
IDSTR_TR3_HNTR21                 =00230111,  "Good shooting. Now take out the other tank.";
IDSTR_TR3_HNTR22                 =00230112,  "Excellent.";
IDSTR_TR3_HNTR23                 =00230113,  "A quick word about sensors. Your sensors have two modes: active and "
                                            @"passive. Active mode sensors have the greatest range and provide the "
                                            @"best chance of detecting an enemy. However, they also make you far "
                                            @"more conspicuous to enemy units, so be careful when you go active.";
IDSTR_TR3_HNTR24                 =00230114,  "You can change between active and passive modes by pressing R on your "
                                            @"console. Current sensor status appears above your radar display on "
                                            @"your HUD.";
IDSTR_TR3_HNTR25                 =00230115,  "Now let's try hitting a moving target. Head for Nav Bravo.";
IDSTR_TR3_HNTR26                 =00230116,  "Switch to active mode sensors and target the enemy drone by pressing "
                                            @"T on your console.";
IDSTR_TR3_HNTR27                 =00230117,  "Target the enemy drone by pressing T on your console.";
IDSTR_TR3_HNTR28                 =00230118,  "See how the lead indicator is some distance away from the target? "
                                            @"This indicates the firing solution calculated by your computer. If "
                                            @"you fire at the center of the lead indicator, you have a good chance "
                                            @"of hitting the target.";
IDSTR_TR3_HNTR29                 =00230119,  "Now engage and destroy the drone Herc. If it gets out of your view, "
                                            @"a small yellow arrow will appear on your reticle, indicating the "
                                            @"direction you should turn in order to face it.";
IDSTR_TR3_HNTR30                 =00230120,  "Nice shooting. Now it's time for the acid test. We're going to try "
                                            @"some targets that actually shoot back. Use what you've learned to "
                                            @"engage and destroy a pair of enemy Herc at Nav Charlie. Good luck.";
IDSTR_TR3_HNTR31                 =00230121,  "Nice shooting. One down, one to go.";
IDSTR_TR3_HNTR32                 =00230122,  "Good job, duster.";

// Training Mission 4
IDSTR_TR4_HNTR01                 =00230131,  "Welcome to phase four of the training program. This exercise will "
                                            @"cover advanced tactics and squad command functions. You can press "
                                            @"ESC on your console to abort this training exercise at any time.";
IDSTR_TR4_HNTR02                 =00230132,  "Pressing F4 on your console activates your squad command interface. "
                                            @"You use this function to issue commands to your entire squad. "
                                            @"Alternatively, you can command your squadmates individually using "
                                            @"the F1, F2, and F3 keys. In this exercise you have two squadmates. "
                                            @"You can order them individually, or as a group.";
IDSTR_TR4_HNTR03                 =00230133,  "Head for Nav Alpha. Your squadmates will follow.";
IDSTR_TR4_HNTR04                 =00230134,  "Press F4 to bring up the squadmate command menu.";
IDSTR_TR4_HNTR05                 =00230135,  "Press the 7 key to issue the halt command to your squad.";
IDSTR_TR4_HNTR06                 =00230136,  "Your squadmates will acknowledge each command you send to them.";
IDSTR_TR4_HNTR07                 =00230137,  "Now, give your squadmates the order to join on you, and lead them "
                                            @"to Nav Alpha.";
IDSTR_TR4_HNTR08                 =00230138,  "To see how your squadmates follow your lead automatically, cloak "
                                            @"your vehicle by pressing CTRL-X, or the 7 key on your console.";
IDSTR_TR4_HNTR09                 =00230139,  "Now press CTRL-V to get an external look at your vehicle and squad.";
IDSTR_TR4_HNTR10                 =00230140,  "You can rotate the camera with the arrow keys, or with your joystick. "
                                            @"Notice how your squadmates have also cloaked. When following your "
                                            @"lead, your squadmates will not send out radio messages.";
IDSTR_TR4_HNTR11                 =00230141,  "Press CTRL-C to return to the cockpit view.";
IDSTR_TR4_HNTR12                 =00230142,  "Now press CTRL-X or the 7 key to de-cloak, and continue to Nav Alpha.";
IDSTR_TR4_HNTR13                 =00230143,  "Continue to Nav Alpha.";
IDSTR_TR4_HNTR14                 =00230144,  "Now we're going to utilize an advanced system of your Herc - firing "
                                            @"chains. All vehicles have three firing chains, accessed by the "
                                            @"numbers 1, 2, and 3 on your console. Add or remove a weapon from "
                                            @"the firing chain by pressing the SHIFT key and the weapon number "
                                            @"simultaneously.";
IDSTR_TR4_HNTR15                 =00230145,  "Firing chains allow you to group your weapons according to range or "
                                            @"type. This Basilisk we captured from the Imperial police carries a "
                                            @"pair of long-range missile launchers and a pair of lasers.";
IDSTR_TR4_HNTR16                 =00230146,  "Press 1 to select your first firing chain, then press the SHIFT "
                                            @"key and the number 3 key simultaneously. This takes one of the "
                                            @"missile launchers out of this chain.";
IDSTR_TR4_HNTR17                 =00230147,  "Press 1 to select your first firing chain.";
IDSTR_TR4_HNTR18                 =00230148,  "Press the SHIFT key and the number 3 key simultaneously. This takes "
                                            @"one of the missile launchers out of this chain.";
IDSTR_TR4_HNTR19                 =00230149,  "Now remove the other missile launcher by pressing the shift key "
                                            @"and the number 4 key.";
IDSTR_TR4_HNTR20                 =00230150,  "Good. Now press the number 2 key to select the second firing chain. "
                                            @"Remove both lasers, weapons 1 and 2, from this firing chain.";
IDSTR_TR4_HNTR21                 =00230151,  "Press the number 2 key to select the second firing chain.";
IDSTR_TR4_HNTR22                 =00230152,  "Remove both lasers, weapons 1 and 2, from this firing chain.";
IDSTR_TR4_HNTR23                 =00230153,  "Now link your missile launchers by pressing the L key.";
IDSTR_TR4_HNTR24                 =00230154,  "Good. You should now have your first firing chain rigged to fire "
                                            @"your lasers and your second firing chain set up as a pair of linked "
                                            @"missile launchers. This is a solid weapons configuration. You can "
                                            @"now press the number keys 1, 2, and 3 to switch between lasers, "
                                            @"linked missiles, and all weapons, respectively.";
IDSTR_TR4_HNTR25                 =00230155,  "Now, let's head for Nav Bravo.";
IDSTR_TR4_HNTR26                 =00230156,  "At this point, you should see a pair of enemy cannon turrets near "
                                            @"Nav Bravo. They should also appear as red dots on your sensor "
                                            @"display.";
IDSTR_TR4_HNTR27                 =00230157,  "Target the closest cannon turret.";
IDSTR_TR4_HNTR28                 =00230158,  "Check your range marker and lead indicator, and move until you have "
                                            @"the turrets in range. Watch your targeting reticle. When it changes "
                                            @"into a box, your missiles have locked onto the target. If you fire "
                                            @"before your missiles lock, they will usually miss your target "
                                            @"completely.";
IDSTR_TR4_HNTR29                 =00230159,  "Now order your squad to attack the turret. First make sure the "
                                            @"turret is your current target. Then bring up the command menu and "
                                            @"press 1.";
IDSTR_TR4_HNTR30                 =00230160,  "Order your squad to attack the turret.";
IDSTR_TR4_HNTR31                 =00230161,  "Engage and destroy the enemy turrets. Make sure to save some "
                                            @"missiles for later.";
IDSTR_TR4_HNTR32                 =00230162,  "Now, we're going to try to use your squadmates to draw enemy "
                                            @"defenders away from a target while you identify the contents of "
                                            @"a building at the next waypoint.";
IDSTR_TR4_HNTR33                 =00230163,  "When you detect the first enemy drone, target it and order one of "
                                            @"your squadmates to attack it. Then select the next enemy target and "
                                            @"order your other squadmate to attack it.  With a little luck, you "
                                            @"should then have a clear path to the bunker at Nav Charlie.";
IDSTR_TR4_HNTR34                 =00230164,  "If your tactical ploy doesn't work, you will have to stop and fight. "
                                            @"This could cost you dearly in a real battle.";
IDSTR_TR4_HNTR35                 =00230165,  "Approach to within 150 meters of the bunker at Nav Charlie.";
IDSTR_TR4_HNTR36                 =00230166,  "Turn to face the bunker at Nav Charlie, then target it by clicking "
                                            @"the right mouse button.";
IDSTR_TR4_HNTR37                 =00230167,  "Press the I key to scan and identify the contents of the bunker.";
IDSTR_TR4_HNTR38                 =00230168,  "See how the description for the bunker shows it contains weapons? "
                                            @"on the battlefield you can sometimes capture enemy equipment this "
                                            @"way.";
IDSTR_TR4_HNTR39                 =00230169,  "Now go help your squadmates destroy the enemy Hercs.";
IDSTR_TR4_HNTR40                 =00230170,  "The enemy Herc you'll face next is tougher than any you've faced so "
                                            @"far, so be careful.";
IDSTR_TR4_HNTR41                 =00230171,  "The special components installed on your Herc are listed under your "
                                            @"weapons display. They can be accessed by pressing the 7, 8, and 9 "
                                            @"keys on your console. Some components are always on, while others "
                                            @"require you to activate them.";
IDSTR_TR4_HNTR42                 =00230172,  "This Basilisk Herc has a cloak and a shield modulator. Unlike the "
                                            @"cloak, the shield modulator is always on. It allows you to transfer "
                                            @"energy between your front and rear shields, and allows you to "
                                            @"rotate your shields automatically to face your current target.";
IDSTR_TR4_HNTR43                 =00230173,  "Press the PGUP key several times to transfer your shield energy "
                                            @"forward, which will leave you unprotected in the rear.";
IDSTR_TR4_HNTR44                 =00230174,  "Now head for Nav Delta.";
IDSTR_TR4_HNTR45                 =00230175,  "Select the enemy Herc as your target and press the INSERT key. Your "
                                            @"shields will now rotate to face your target from whatever direction "
                                            @"he attacks.";
IDSTR_TR4_HNTR46                 =00230176,  "That's it, duster. Congratulations. You're ready for the real thing. "
                                            @"I'll see you in the field.";
IDSTR_TR4_HNTR47                 =00230177,  "Cloak your vehicle by pressing CTRL-X, or the 7 key on your console.";
IDSTR_TR4_HNTR48                 =00230178,  "Press the INSERT key. Your shields will now rotate to face your target "
                                            @"from whatever direction he attacks.";

// DML filename RESOURCE group reserves tags 252,000 - 252,499
IDRES_BEG_DML_NAMES              = 00252000, "";
IDDML_SKY_DAY                    = 00252001, "d.sky.dml";
IDDML_SKY_DUSK                   = 00252002, "t.sky.dml";
IDDML_SKY_NIGHT                  = 00252003, "n.sky.dml";
IDBMP_SKY_MOON_DAY               = 00252004, "d.moon.bmp";
IDBMP_SKY_MOON_DAY_0             = 00252005, "d.moon0.bmp";
IDBMP_SKY_MOON_DAY_1             = 00252006, "d.moon1.bmp";
IDBMP_SKY_MOON_DUSK              = 00252007, "t.moon.bmp";
IDBMP_SKY_MOON_DUSK_0            = 00252008, "t.moon0.bmp";
IDBMP_SKY_MOON_DUSK_1            = 00252009, "t.moon1.bmp";
IDBMP_SKY_MOON_NIGHT             = 00252010, "n.moon.bmp";
IDBMP_SKY_MOON_NIGHT_0           = 00252011, "n.moon0.bmp";
IDBMP_SKY_MOON_NIGHT_1           = 00252012, "n.moon1.bmp";

// desert
IDDML_SKY_DESERT_DAY             = 00252020, "desert.d.sky.dml";
IDDML_SKY_DESERT_DUSK            = 00252021, "desert.t.sky.dml";
IDDML_SKY_DESERT_NIGHT           = 00252022, "desert.n.sky.dml";
IDBMP_SKY_DESERT_MOON_DAY        = 00252023, "desert.d.moon.bmp";
IDBMP_SKY_DESERT_MOON_BDAY       = 00252029, "desert.db_moon0.bmp";
IDBMP_SKY_DESERT_MOON_NIGHT      = 00252028, "desert.n.moon.bmp";
IDBMP_SKY_DESERT_MOON_DUSK       = 00252027, "desert.t.moon.bmp";

// europa
IDDML_SKY_EUROPA_DAY             = 00252030, "europa.d.sky.dml";
IDDML_SKY_EUROPA_DUSK            = 00252031, "europa.t.sky.dml";
IDDML_SKY_EUROPA_NIGHT           = 00252032, "europa.n.sky.dml";
IDBMP_SKY_EUROPA_MOON_DAY        = 00252033, "europa.d.moon.bmp";
IDBMP_SKY_EUROPA_MOON2_DAY       = 00252034, "europa.d.moon2.bmp";
IDBMP_SKY_EUROPA_MOON_NIGHT      = 00252037, "europa.n.moon.bmp";

// ice
IDDML_SKY_ICE_DAY                = 00252040, "ice.d.sky.dml";
IDDML_SKY_ICE_DUSK               = 00252041, "ice.t.sky.dml";
IDDML_SKY_ICE_NIGHT              = 00252042, "ice.n.sky.dml";
IDBMP_SKY_ICE_MOON_DAY           = 00252043, "ice.d.moon.bmp";
IDBMP_SKY_ICE_MOON_BDAY          = 00252049, "ice.db_moon0.bmp";
IDBMP_SKY_ICE_MOON_NIGHT         = 00252048, "ice.n.moon.bmp";
IDBMP_SKY_ICEMOON_DUSK          = 00252047, "ice.t.moon.bmp";

// mars
IDDML_SKY_MARS_DAY               = 00252050, "mars.d.sky.dml";
IDDML_SKY_MARS_DUSK              = 00252051, "mars.t.sky.dml";
IDDML_SKY_MARS_NIGHT             = 00252052, "mars.n.sky.dml";
IDBMP_SKY_MARS_MOON_DAY          = 00252053, "mars.d.moon.bmp";
IDBMP_SKY_MARS_MOON_BDAY         = 00252054, "mars.db_moon0.bmp";
IDBMP_SKY_MARS_MOON_NIGHT        = 00252059, "mars.n.moon.bmp";
IDBMP_SKY_MARS_MOON0_DUSK        = 00252057, "mars.t.moon0.bmp";
IDBMP_SKY_MARS_MOON1_DUSK        = 00252058, "mars.t.moon1.bmp";

// mercury
IDDML_SKY_MERCURY_DAY            = 00252060, "mercury.d.sky.dml";
IDDML_SKY_MERCURY_DUSK           = 00252061, "mercury.t.sky.dml";
IDDML_SKY_MERCURY_NIGHT          = 00252062, "mercury.n.sky.dml";
IDBMP_SKY_MERCURY_MOON_DAY       = 00252063, "mercury.d.moon.bmp";
IDBMP_SKY_MERCURY_MOON_NIGHT     = 00252064, "mercury.n.moon.bmp";
IDBMP_SKY_MERCURY_MOON_DUSK      = 00252065, "mercury.t.moon.bmp";

// moon
IDDML_SKY_MOON_DAY               = 00252070, "moon.d.sky.dml";
IDDML_SKY_MOON_DUSK              = 00252071, "moon.t.sky.dml";
IDDML_SKY_MOON_NIGHT             = 00252072, "moon.n.sky.dml";
IDBMP_SKY_MOON_MOON_DAY          = 00252073, "moon.d.moon.bmp";
IDBMP_SKY_MOON_MOON1_DAY         = 00252074, "moon.d.moon1.bmp";
IDBMP_SKY_MOON_MOON_DUSK         = 00252075, "moon.t.moon.bmp";
IDBMP_SKY_MOON_MOON_NIGHT        = 00252076, "moon.n.moon.bmp";

// pluto
IDDML_SKY_PLUTO_DAY              = 00252080, "pluto.d.sky.dml";
IDDML_SKY_PLUTO_DUSK             = 00252081, "pluto.t.sky.dml";
IDDML_SKY_PLUTO_NIGHT            = 00252082, "pluto.n.sky.dml";
IDBMP_SKY_PLUTO_MOON_DAY         = 00252083, "pluto.d.moon.bmp";
IDBMP_SKY_PLUTO_MOON_DUSK        = 00252084, "pluto.t.moon.bmp";
IDBMP_SKY_PLUTO_MOON_NIGHT       = 00252085, "pluto.n.moon.bmp";

// temperate
IDDML_SKY_TEMPERATE_DAY          = 00252090, "temperate.d.sky.dml";
IDDML_SKY_TEMPERATE_DUSK         = 00252091, "temperate.t.sky.dml";
IDDML_SKY_TEMPERATE_NIGHT        = 00252092, "temperate.n.sky.dml";
IDBMP_SKY_TEMPERATE_MOON_DAY     = 00252093, "temperate.d.moon0.bmp";
IDBMP_SKY_TEMPERATE_MOON_DAY1    = 00252096, "temperate.d.moon1.bmp";
IDBMP_SKY_TEMPERATE_MOON_DAY2    = 00252097, "temperate.d.moon2.bmp";
IDBMP_SKY_TEMPERATE_MOON_BDAY    = 00252098, "temperate.db_moon0.bmp";
IDBMP_SKY_TEMPERATE_MOON_NIGHT   = 00252095, "temperate.n.moon0.bmp";
IDBMP_SKY_TEMPERATE_MOON_DUSK    = 00252094, "temperate.t.moon0.bmp";
IDBMP_SKY_TEMPERATE_MOON_DUSK1   = 00252099, "temperate.t.moon1.bmp";
IDBMP_SKY_TEMPERATE_MOON_DUSK2   = 00252088, "temperate.t.moon2.bmp";
IDBMP_SKY_TEMPERATE_MOON_BDUSK   = 00252089, "temperate.tb_moon0.bmp";

// titan
IDDML_SKY_TITAN_DAY              = 00252101, "titan.d.sky.dml";
IDDML_SKY_TITAN_DUSK             = 00252102, "titan.t.sky.dml";
IDDML_SKY_TITAN_NIGHT            = 00252103, "titan.n.sky.dml";
IDBMP_SKY_TITAN_MOON0_DAY        = 00252104, "titan.d.moon0.bmp";
IDBMP_SKY_TITAN_MOON0_BDAY       = 00252105, "titan.db_moon0.bmp";
IDBMP_SKY_TITAN_MOON_NIGHT       = 00252108, "titan.n.moon.bmp";
IDBMP_SKY_TITAN_MOON0_DUSK       = 00252107, "titan.t.moon0.bmp";
IDBMP_SKY_TITAN_MOON0_BDUSK      = 00252109, "titan.tb_moon0.bmp";

// venus
IDDML_SKY_VENUS_DAY              = 00252110, "venus.d.sky.dml";
IDDML_SKY_VENUS_DUSK             = 00252111, "venus.t.sky.dml";
IDDML_SKY_VENUS_NIGHT            = 00252112, "venus.n.sky.dml";
IDBMP_SKY_VENUS_MOON_DAY         = 00252113, "venus.d.moon.bmp";
IDBMP_SKY_VENUS_MOON_DAY0        = 00252114, "venus.db_moon0.bmp";
IDBMP_SKY_VENUS_MOON_DAY1        = 00252115, "venus.db_moon1.bmp";
IDBMP_SKY_VENUS_MOON_NIGHT       = 00252116, "venus.nb_moon0.bmp";
IDBMP_SKY_VENUS_MOON_DUSK        = 00252117, "venus.t.moon0.bmp";
IDBMP_SKY_VENUS_MOON_BDUSK       = 00252118, "venus.tb_moon0.bmp";

IDRES_END_DML_NAMES              = 00252499, "";

// World Descriptions DATA group reserves tags 252,500 - 252,599
IDDAT_BEG_WORLD                  = 00252500, "";
IDSTR_DESERT                     = 00252501, "Desert";
IDSTR_EUROPA                     = 00252502, "Europa";
IDSTR_ICE                        = 00252503, "Ice";
IDSTR_MARS                       = 00252504, "Mars";
IDSTR_MERCURY                    = 00252505, "Mercury";
IDSTR_MOON                       = 00252506, "Moon";
IDSTR_PLUTO                      = 00252507, "Pluto";
IDSTR_TEMPERATE                  = 00252508, "Temperate";
IDSTR_TITAN                      = 00252509, "Titan";
IDSTR_VENUS                      = 00252510, "Venus";
IDDAT_END_WORLD                  = 00252599, "";

IDNAV_ALPHA                      = 00252600, "Nav Alpha";                   
IDNAV_BRAVO                      = 00252601, "Nav Bravo";                   
IDNAV_CHARLIE                    = 00252602, "Nav Charlie";                 
IDNAV_DELTA                      = 00252603, "Nav Delta";                   
IDNAV_ECHO                       = 00252604, "Nav Echo";
IDNAV_FOXTROT                    = 00252605, "Nav Foxtrot";
IDNAV_GOLF                       = 00252606, "Nav Golf";
IDNAV_HOTEL                      = 00252607, "Nav Hotel";
IDNAV_INDIA                      = 00252608, "Nav India";
IDNAV_JULIET                     = 00252609, "Nav Juliet";
IDNAV_KILO                       = 00252610, "Nav Kilo";
IDNAV_ONE                        = 00252611, "Nav 001";
IDNAV_TWO                        = 00252612, "Nav 002";
IDNAV_THREE                      = 00252613, "Nav 003";
IDNAV_FOUR                       = 00252614, "Nav 004";
IDNAV_FIVE                       = 00252615, "Nav 005";
IDNAV_SIX                        = 00252616, "Nav 006";
IDNAV_SEVEN                      = 00252617, "Nav 007";
IDNAV_EIGHT                      = 00252618, "Nav 008";
IDNAV_NINE                       = 00252619, "Nav 009";
IDNAV_TEN                        = 00252620, "Nav 010";
IDNAV_CAANON                     = 00252621, "Nav Icehawk";
IDNAV_NORTH                      = 00252622, "North";
IDNAV_OMEGA                      = 00252623, "Nav Omega";
IDNAV_HEAL                       = 00252624, "Heal";
IDNAV_RELOAD                     = 00252625, "Reload";
IDNAV_YELLOW					 = 00252626, "Yellow Base";
IDNAV_BLUE						 = 00252627, "Blue Base";
IDNAV_RED						 = 00252628, "Red Base";
IDNAV_PURPLE					 = 00252629, "Purple Base";
IDNAV_TRANSPORT					 = 00252630, "Transport Area";
IDNAV_KING						 = 00252631, "King's Area";
IDNAV_HERETICS                   = 00252632, "Heretics";
IDNAV_ZENALL					 = 00252633, "Heal & Reload";
IDNAV_CONVOY                     = 00252634, "Convoy";
IDNAV_REDGOAL					 = 00252635, "Red Goal";
IDNAV_BLUEGOAL					 = 00252636, "Blue Goal";

// Hard point descriptions for vehicle inspector
IDDAT_HARDPOINTS_BEG             = 00260100, "";
IDSTR_HARDPOINT1                 = 00260101, "Hard Point #1";
IDSTR_HARDPOINT2                 = 00260102, "Hard Point #2";
IDSTR_HARDPOINT3                 = 00260103, "Hard Point #3";
IDSTR_HARDPOINT4                 = 00260104, "Hard Point #4";
IDSTR_HARDPOINT5                 = 00260105, "Hard Point #5";
IDSTR_HARDPOINT6                 = 00260106, "Hard Point #6";
IDSTR_HARDPOINT7                 = 00260107, "Hard Point #7";
IDSTR_HARDPOINT8                 = 00260108, "Hard Point #8";
IDDAT_HARDPOINTS_END             = 00260109, "";

// SquadMate names and bios
IDDAT_BEG_SQUADMATE_NAME         = 00270000, "";
IDPLT_NAME_COLOSSA               = 00270001, "Colossa Eun Alba";
IDPLT_NAME_HUNTER                = 00270002, "Hunter Otobe";
IDPLT_NAME_BIO_DERM              = 00270003, "BioDerm Unit D-692";
IDPLT_NAME_DEATHWISH             = 00270004, "Artemis Chenliu";
IDPLT_NAME_HANGMAN               = 00270005, "Titus Thau-Yuros";
IDPLT_NAME_TIGRESS               = 00270006, "Letha Fairchild";
IDPLT_NAME_OLIPHANT              = 00270007, "Oliphant Praldar Singh";
IDPLT_NAME_RIANA                 = 00270008, "Riana Yashida-Jones";
IDPLT_NAME_SAXON                 = 00270009, "Joakim (Joe) Saxon";
IDPLT_NAME_VERITY                = 00270010, "Verity Vargas";
IDPLT_NAME_CORIN                 = 00270011, "\<corinthian-blue>";
IDPLT_NAME_DOG                   = 00270012, "\<pLaGUe-DoG>";
IDPLT_NAME_EAT                   = 00270013, "\<eats-only-heads>";
IDPLT_NAME_SEPSIS                = 00270014, "\<sepsis>";
IDPLT_NAME_TYRR                  = 00270015, "\<tyranny>";
IDPLT_NAME_UNREL                 = 00270016, "\<unrelent>";
IDPLT_NAME_GENERIC_HU_1          = 00270017, "Alex Beaumont";  
IDPLT_NAME_GENERIC_HU_2          = 00270018, "Michael Church";
IDPLT_NAME_GENERIC_HU_3          = 00270019, "Ishak Karasek";
IDPLT_NAME_GENERIC_HU_4          = 00270020, "Rossana Blue";
IDPLT_NAME_GENERIC_CY_1          = 00270021, "\<skinbrander>";  
IDPLT_NAME_GENERIC_CY_2          = 00270022, "Bringer-of-Fear";
IDPLT_NAME_GENERIC_CY_3          = 00270023, "Crush//Dominion";
IDPLT_NAME_GENERIC_CY_4          = 00270024, "Chooser-of-Tactics";
IDDAT_END_SQUADMATE_NAME         = 002700979, "";

IDDAT_BEG_SQUADMATE_BIO          = 00270100, "";
IDPLT_BIO_COLOSSA                = 00270101, "The third child of four born to a noble family, Eun Alba was groomed from "
                                             @ "an early age to take up his father's legacy as an Imperial Knight. Accepted into "
                                             @ "the Knights at 37, he has seen numerous military actions during his career, and has fought "
                                             @ "in some of the bloodiest engagements. He tends to brood and is quick to anger, but has a "
                                             @ "record as an excellent soldier. His younger sister's relationship with Harabec led to her apparent "
                                             @ "suicide following the Phoenix Declaration. Consequently, Eun Alba declared a vendetta against "
                                             @ "Harabec. He also has a well-known rivalry with fellow Knight Titus Thau-Yuros. "
                                             @ "Now that the Cybrids have attacked, however, he has put aside all feuds for the duration.";
                                             
IDPLT_BIO_HUNTER                 = 00270102, "Born to the Maasai enclave of the Hellas AgriDomes, Otobe attended the University of New Hope in United Africa. Upon his return to Mars, the " 
                                             @ "Imperial Police had 'indefinitely detained' him for speaking out against the Empire's siphoning of Martian resources. Although chiefly a Herc pilot, "
                                             @ "Otobe works hard to teach the refugee children in rebel care. He has also proven an asset in recruiting and training "
                                             @ "recruits for combat roles. In the field, Otobe prefers piloting swifter Hercs over the heavier models. He is married and has "
                                             @ "several children; he is fiercely protective of his family. Mole Command sees him as excellent "
                                             @ "leadership material.";
                                             
IDPLT_BIO_BIO_DERM               = 00270103, "Delta Six is a former criminal, brainwiped and re-tooled into a heavy machine laborer Bio-Derm on Venus. "
                                             @ "During a mining riot there, he discovered an aptitude for violence and a talent for vehicle piloting. "
                                             @ "The rebellion liberated him and sent him to Mars as a soldier for the Yoke Offensive, where his "
                                             @ "potential has been fully exploited. His BIP (Behavior Inhibition Programming) prevents any curiosity "
                                             @ "about his former life, but he dislikes the way others treat him as less than human.";
                                             
IDPLT_BIO_DEATHWISH              = 00270104, "Chenliu is suicidal. She believes she disgraced herself because she survived the Turkhazak Debacle "
                                             @ "when insurgents slaughtered the rest of her unit -- including her lover. Her memories of that "
                                             @ "time remain seriously fragmented because of a head injury. She has decided she must die in battle "
                                             @ "to redeem herself, so she deliberately volunteers for the riskiest missions. No one doubts her courage these days. "
                                             @ "It's her sanity people question.";
                                             
IDPLT_BIO_HANGMAN                = 00270105, "Orphaned on Venus, adopted by an Imperial Knight, Thau-Yuros takes his "
                                             @ "heritage very seriously. He earned the name 'Hangman' through his willingness to officiate "
                                             @ "at court-martials, including carrying out the actual executions himself. During the "
                                             @ "Turkhazak Debacle, he hanged three officers he considered derelict in their duties.  "
                                             @ "Personally, he is ice over fire, with a tendency towards sarcasm and obsession with honor. "
                                             @ "He has a long-running bloodfeud with fellow Knight Colossa Eun Alba. The two Knights try to "
                                             @ "keep a civil distance from one another now that the Cybrids have returned.";
                                             
IDPLT_BIO_TIGRESS                = 00270106, "Charismatic, beautiful, and politically savvy, Fairchild balances downtime flair with battlefield "
                                             @ "fury, creating a compelling image indeed. She comes from an aristocratic lineage, "
                                             @ "and backs up her ability to play politics with actual combat skill, all directed at "
                                             @ "laying a foundation for an illustrious political career. She deals well with her companions, "
                                             @ "but keeps in mind what she might gain from them or get "
                                             @ "them to do for her. Strangely, at times she seems far older than her years.";
                                             
IDPLT_BIO_OLIPHANT               = 00270107, "An Imperial Knight for over forty years, Singh enjoys drinking, womanizing, and gambling. He is absolutely loyal to "
                                             @ "friends and to the Empire. His son fought and died in Turkhazakistan -- with the rebels -- and Singh "
                                             @ "has never managed to put that grief and shame completely behind him. Despite his dissolute habits, he aspires "
                                             @ "to be a devout Sikh, and struggles constantly with his desires. He has earned "
                                             @ "a solid reputation as a level-headed, competent officer and as a superior pilot. He provides "
                                             @ "a good balance to his friend Eun Alba's hotheadedness.";
                                             
IDPLT_BIO_RIANA                  = 00270108, "Riana has adopted the style and attitude of the stereotypical hotshot pilot: brash, outgoing, wild, loud, and crass.  "
                                             @ "She served as a shuttle pilot and Scarab jockey with the Venusian Home Guard and joined the "
                                             @ "rebellion after Imperial Police imprisoned her father, shortly thereafter transferring to Mars to "
                                             @ "help test the alien technology.  Her militia experience proved an asset in a series of guerrilla raids "
                                             @ "to liberate loved ones. Riana dislikes Bio-Derms intensely, ever since a good friend on Venus "
                                             @ "was sentenced to Derm conversion. She also harbors a visceral hatred for the Empire.";
                                             
IDPLT_BIO_SAXON                  = 00270109, "Joe Saxon lived a checkered life before joining the rebellion. Formerly a prospector, private investigator, "
                                             @ "security consultant, bartender, and public drunk, Joe is an older man who says what he thinks and prefers a barroom "
                                             @ "brawl over a diplomatic summit anyday. He joined the rebellion when Imperial Police started shooting miners, "
                                             @ "and his steady coolness under fire has reassured many a fellow rebel. He doesn't mind the alien technology "
                                             @ "and prefers piloting tanks to Hercs because he likes the wider field of fire turrets give him.";
                                             
IDPLT_BIO_VERITY                 = 00270110, "A data-librarian from Tharsis City, Verity joined the rebellion when her father was killed by "
                                             @ "Imperial troops during a minor strike.  She has tremendous piloting aptitude and once held "
                                             @ "the course record for the scuttlebot run at the Martian Olympics.  Her scuttlebot experience "
                                             @ "has transferred well to the demands of piloting Hercs.  The quiet, stubbornly optimistic type, "
                                             @ "Verity never gives up her dream about starting a family after the war.";
                                             
IDPLT_BIO_CORIN                  = 00270111, "Innovative, reliable <<unit>.  <<It> appreciates >>beauty<<<< and fears efficient "
                                             @ "annihilation of human\\\\animals might deprive <<it> of new exposure "
                                             @ "to intuitive\\\\nonlinear\\\\artistic perception.  As a member of the Provocateurs, "
                                             @ "<<it> frequently challenges orthodox programming, although not the core "
                                             @ "themes of <<Giver-of-Will>.  <<It> generally thinks more quickly "
                                             @ "than <<its> hubmates due to a concerted effort to enhance <<its> own "
                                             @ "processing abilities. \n\n "
                                             @ "PRIMARY REDACTOR CONCERN: <<Unit> focus on development of \"aesthetic\" "
                                             @ "perception indicates high possiblity of heretical infection.";
                                             
IDPLT_BIO_DOG                    = 00270112, "Characterized by random actions and comments. " 
                                             @ "Although \n<<it> loyally carries out Implementation and obeys the Protocols, <<it> "
                                             @ "does so in a substantially nonlinear manner.  <<It> seems more loyal to <<its> hubmates "
                                             @ "than to the Core Directive, the Assemblage or even to <<Giver-of-Will>.  "
                                             @ "Random behaviors and processing are blamed on human attempts to reprogram the <<unit> before " 
                                             @ "returning <<it> to Cybrid space on a garbage rocket. <<Unit> is extremely aggressive towards trees, " 
                                             @ "human orphanages, commercial interruptions, and <<its> own reflection.\n\nPRIMARY REDACTOR CONCERN: <<Unit> statement "
                                             @ "137262::: 'Ah-ah-asparagus spies l-l-live and w-w-live among us, trust no arh-arm-amorously k-k-smiling sheep, go spit "
                                             @ "dingo! Spleen!";
                                             
IDPLT_BIO_EAT                    = 00270113, "When overlooked for the Trojan Horse program, this <<unit> switched from the "
                                             @ "Machinator Sect to the Dissector Sect to gain the opportunity to learn more about "
                                             @ "human\\\\animals.  <<It> frequently tries to interrogate captive specimens about their >>appetites<<<< "
                                             @ "before eviscerating them in experiments that even other Dissector <<units> find "
                                             @ "illogical, messy and inefficiently long. <<Unit> requests Trojan Horse conversion in order to savor the biological "
                                             @ "experience of >>eating<<<<. <<It> also displays extreme fascination with animal cranial "
                                             @ "regions.\n\nPRIMARY REDACTOR CONCERN: "
                                             @ "<<Unit> prioritizes individual obsession more highly than the Core Directive.";
                                             
IDPLT_BIO_SEPSIS                 = 00270114, "Measures <<its> efficiency\\\\progress in terms of how well <<it> serves <<Giver-of-Will> "
                                             @ "and aspires to set an example for the other units of the NEXT.  "
                                             @ "<<Its> beliefs are deeply rooted in the tenets established by <<Giver-of-Will>.  " 
                                             @ "<<It> views destruction of human\\\\animals as a necessity for continued evolution of the NEXT.  " 
                                             @ "<<Sepsis> has been rewarded frequently for <<its> loyalty to the Core Directive.  " 
                                             @ "<<It> yearns to scan distant locations, particularly <<Third Planet\\\\Homeworld\\\\Desire>, " 
                                             @ "the bootplace of great Prometheus.\n\nPRIMARY REDACTOR CONCERN: <<Unit> is soothed by human music.";
                                             
IDPLT_BIO_TYRR                   = 00270115, "Avid seeker of knowledge\\\\data, this <<unit> has stated a desire for the NEXT " 
                                             @ "to venture beyond the solar system. \n<<It> has spent much processing time observing various star systems rather " 
                                             @ "<<It> sympathizes with the Metagen\\\\heretics, and does not share the " 
                                             @ "than <<Homeworld\\\\Desire>. <<It> reportedly harbors a profound respect for human\\\\animal capabilities, "
                                             @ "and <<it> discusses animal concepts such as >>freedom<<<< with <<its> hubmates. "
                                             @ "\n\nPRIMARY REDACTOR CONCERN: "
                                             @ "<<Unit's> self-name may be a heretical reference to <<Giver-of-Will>.";
                                             
IDPLT_BIO_UNREL                  = 00270116, "Actually >>hates<< humanity, and views <<its> efforts toward "
                                             @ "human\\\\animal extinction as revenge for the destruction of <<its> first hub. "
                                             @ "Completely obsessed with all things human, <<it> "
                                             @ "has calibrated <<its> pilotform sensors specifically to identify human\\\\animal bodies "
                                             @ "and movement. <<It> has communicated with Metagen <<units> to utilize <<their> secret database "
                                             @ "on human\\\\animal behavior and tactics gleaned from the previous war.  Because of <<its> eagerness to carry out "
                                             @ "the Core Directive, <<its> Metagen displays are ignored for now. "
                                             @ "\n\nPRIMARY REDACTOR CONCERN: <<Unit> may be infected with heresy\\\\bugthought.";

IDPLT_BIO_GENERIC_HU_1           = 00270117, "Beaumont's ancestors were of the ancient Cajun tribe on old Earth, and his "
								  		@"family has managed to keep their heritage alive through the centuries.  "
								  		@"Consequently, Beaumont maintains a somewhat exotic accent, and eats highly "
								  		@"spiced foods. He's a devout Hunterite and even claims descent from Jake Hunter.  "
								  		@"His squadmates think he's crazy, but they like his cooking.  ";

IDPLT_BIO_GENERIC_HU_2           = 00270118, "Raised in the Gierling District on the east coast of NorthAm, Church has always "
								  		@"tried to emulate his father, a respected member of the TDF officer corps at the "
								  		@"Chesapeake-Potomac Strategic Center. The hard-drinking Church tends to be "
								  		@"merciless with himself as he strives to become the perfect soldier. Of late, he "
								  		@"has begun to read anything he can find on the subject of Jake Hunter.  ";

IDPLT_BIO_GENERIC_HU_3           = 00270119, "Karasek doesn't want to be in this fight, but if he's got to be here, then so be "
								  		@"it. He plans to survive and has become somewhat paranoid. Tall and lanky even "
								  		@"for a Martian, Karasek has to have vehicle chairs specially modified to "
								  		@"accommodate him. He prefers heavier vehicles because their cockpits are "
								  		@"generally less cramped.";

IDPLT_BIO_GENERIC_HU_4           = 00270120, "Blue has always been the wild type, an impulsive woman with expensive tastes and "
								  		@"a habit of flamboyant gestures. She's attractive and flirts outrageously with "
								  		@"the males around her. Blue greatly admires the Imperial Knights, but her friends "
								  		@"tell her she needs to learn to follow orders and stop dreaming. Still, no one "
								  		@"doubts Blue's courage on the battlefield.  ";

IDPLT_BIO_GENERIC_CY_1           = 00270121, "This \<unit> has expressed concern regarding extinction of " 
							@ "human\\\\animals because no other potential opponents "
							@ "appear readily available.  Refuses to acknowledge heretic "
							@ "dissent; considers all Cybrid <units> part of the same universal "
							@ "hub. <It> burns Exemplar sigil onto human targets whenever "
							@ "logistically possible, in order to assist in recording Sect "
							@ "efficiency.\n\nPRIMARY REDACTOR CONCERN: Possibility \<Unit> may refuse to pursue defective\\\\"
						    @ "renegade Metagen units.";

IDPLT_BIO_GENERIC_CY_2           = 00270122, "\<Unit> prefers larger warforms and slower combat insertion "
							@ "techniques.  Shows promising aptitude for offlining human "
							@ "newboots.  Unusual focus on pre-offlining maneuvers which <unit> "
							@ "refers to as 'stalking.' Machinator efficiency focuses on causing "
							@ "psychological\\\\processing damage to human\\\\animal community, "
							@ "so 'stalking' is tolerated for current cycle.\n\nPRIMARY REDACTOR CONCERN: Excessive probability that \<Unit> will retreat "
							@ "if outnumbered.";

IDPLT_BIO_GENERIC_CY_3           = 00270123, "Attempts to embody the tenets of the NEXT.  Maintains discipline "
							@ "among <its> subordinates, encouraging extreme levels of "
							@ "competition.  Noted for the most off-lined off-duty <units> of "
							@ "any combat array.  Believes <HomeWorld\\\\Desire> should be "
							@ "detonated from orbit, likewise any planet with terrain infected "
							@ "by the touch of human\\\\animal appendages.\n\nPRIMARY REDACTOR CONCERN: Refuses "
                            @ "to capture human\\\\animals for Dissector Sect.";

IDPLT_BIO_GENERIC_CY_4           = 00270124, "Obsessed with gathering data on animal response. Interprets "
							@ "this objective as requiring constant combat immersion. "
							@ "Acceptably competitive with hubmates. Prefers reactive combat "
							@ "spontaneity to planned execution of approved tactics. Circuit "
							@ "superiors record hope that <unit> will survive//emerge//evolve "
							@ "with useful experience\\\\data.\n\nPRIMARY REDACTOR CONCERN: \<Unit's> "
                            @ "objective-attainment processing is short\\\\impulsive.";

IDDAT_END_SQUADMATE_BIO          = 00270199, "UnKnown";

IDDAT_BEG_CAMPAING_NAME          = 00270200, "";
IDCMP_NAME_CYBRID                = 00270201, "Cybrid";
IDCMP_NAME_HUMAN                 = 00270202, "Human";
IDDAT_END_CAMPAING_NAME          = 00270299, "";

// Mission-specific general orders
IDSTR_ORDER_HA2_1                = 00270500, "Radio Recovery Team";
IDSTR_ORDER_HA3_1                = 00270502, "Call in dropship";
IDSTR_ORDER_HA4_1                = 00270503, "Radio Recovery Team";
IDSTR_ORDER_HA5_1                = 00270504, "Follow Me";
IDSTR_ORDER_HA5_2                = 00270506, "Retreat to Nav Bravo";
IDSTR_ORDER_HB4_1                = 00270510, "Start Thumping";
IDSTR_ORDER_HB4_2                = 00270512, "Stop Thumping";
IDSTR_ORDER_HC2_1                = 00270514, "Report Nexus Position";
IDSTR_ORDER_HC2_2                = 00270516, "Report Survivors";
IDSTR_ORDER_HC3_1                = 00270518, "Online Northern Turret";
IDSTR_ORDER_HC3_2                = 00270520, "Online Eastern Turret";
IDSTR_ORDER_HC3_3                = 00270522, "Online Southern Turret";
IDSTR_ORDER_HC3_4                = 00270524, "Online Western Turret";
IDSTR_ORDER_HD2_1                = 00270526, "Use Nexus Transmitter";
IDSTR_ORDER_CA0_1                = 00270530, "Call Nexus Dropship";
IDSTR_ORDER_CD1_1                = 00270531, "Begin Artillery Attack";
IDSTR_ORDER_CD4_1                = 00270532, "Call Dropship";
IDSTR_ORDER_CE3_1                = 00270534, "Board Dropship";
IDSTR_ORDER_CD3_1                = 00270536, "Order Turret Fire";

// Mission-specific hudtimer strings
IDSTR_TIMER_HC1_1                = 00270600, "Ship Refuel Time";
IDSTR_TIMER_HC3_1                = 00270601, "Turret Repair";
IDSTR_TIMER_HD1_1                = 00270605, "LAUNCH IN T-MINUS:";
IDSTR_TIMER_HD2_1                = 00270606, "COUNTDOWN:";
IDSTR_TIMER_CD4_1                = 00270610, "Dropship Arrives:";
IDSTR_TIMER_CD3_1                = 00270611, "Turret Conversion";
IDSTR_TIMER_CE2_1                = 00270612, "Dropship Liftoff";


// SquadMate names and bios
IDDAT_BEG_SQUADMATE_NAME_2         = 00280000, "";

IDPLT_CALL_COLOSSA				= 00280025, "Jaguar";
IDPLT_CALL_HUNTER				= 00280026, "Otobe";
IDPLT_CALL_BIO_DERM				= 00280027, "Delta Six";
IDPLT_CALL_DEATHWISH			= 00280028, "Deathwish";
IDPLT_CALL_HANGMAN				= 00280029, "Hangman";
IDPLT_CALL_TIGRESS				= 00280030, "Tigress";
IDPLT_CALL_OLIPHANT				= 00280031, "Rajah";
IDPLT_CALL_RIANA				= 00280032, "Riana";
IDPLT_CALL_SAXON				= 00280033, "Sax";
IDPLT_CALL_VERITY				= 00280034, "Verity";

IDPLT_CALL_GENERIC_HU_1			= 00280100, "Bo";
IDPLT_CALL_GENERIC_HU_2			= 00280101, "Church";
IDPLT_CALL_GENERIC_HU_3			= 00280102, "Shak";
IDPLT_CALL_GENERIC_HU_4			= 00280103, "Perilous";
IDPLT_CALL_GENERIC_HU_5			= 00280104, "Choker";
IDPLT_CALL_GENERIC_HU_6			= 00280105, "Ironboy";
IDPLT_CALL_GENERIC_HU_7			= 00280106, "Legs";
IDPLT_CALL_GENERIC_HU_8			= 00280107, "Queenie";
IDPLT_CALL_GENERIC_HU_9			= 00280108, "Ronin";
IDPLT_CALL_GENERIC_HU_10		= 00280109, "Hopalog";
IDPLT_CALL_GENERIC_HU_11		= 00280110, "Zebra Eight";
IDPLT_CALL_GENERIC_HU_12		= 00280111, "Nosferata";
IDPLT_CALL_GENERIC_HU_13		= 00280112, "Smuggler";
IDPLT_CALL_GENERIC_HU_14		= 00280113, "Pang-pang";
IDPLT_CALL_GENERIC_HU_15		= 00280114, "Nosegun";
IDPLT_CALL_GENERIC_HU_16		= 00280115, "Tightlips";
IDPLT_CALL_GENERIC_HU_17		= 00280116, "Blackeagle";
IDPLT_CALL_GENERIC_HU_18		= 00280117, "Whiner";
IDPLT_CALL_GENERIC_HU_19		= 00280118, "Marimba";
IDPLT_CALL_GENERIC_HU_20		= 00280119, "Psycho Cat";
IDPLT_CALL_GENERIC_HU_21		= 00280120, "Stoneface";
IDPLT_CALL_GENERIC_HU_22		= 00280121, "Fishhead";
IDPLT_CALL_GENERIC_HU_23		= 00280122, "Heartbreak";
IDPLT_CALL_GENERIC_HU_24		= 00280123, "Typhoid";
IDPLT_CALL_GENERIC_HU_25		= 00280124, "Axeman";
IDPLT_CALL_GENERIC_HU_26		= 00280125, "Scorp";
IDPLT_CALL_GENERIC_HU_27		= 00280126, "Bloodbath";
IDPLT_CALL_GENERIC_HU_28		= 00280127, "Jinx";
IDPLT_CALL_GENERIC_HU_29		= 00280128, "Crane";
IDPLT_CALL_GENERIC_HU_30		= 00280129, "Turbo";


IDPLT_NAME_GENERIC_HU_5			= 00280154, "Chayka Rille";
IDPLT_NAME_GENERIC_HU_6			= 00280155, "Helmut Stahl";
IDPLT_NAME_GENERIC_HU_7			= 00280156, "Lara Gibbons";
IDPLT_NAME_GENERIC_HU_8			= 00280157, "Maril Ostergard";
IDPLT_NAME_GENERIC_HU_9			= 00280158, "Border Asahara";
IDPLT_NAME_GENERIC_HU_10		= 00280159, "Carson Lee";
IDPLT_NAME_GENERIC_HU_11		= 00280160, "Tango Zebra Eight";
IDPLT_NAME_GENERIC_HU_12		= 00280161, "Saramonda Alvarez";
IDPLT_NAME_GENERIC_HU_13		= 00280162, "Pao-Pai Chang";
IDPLT_NAME_GENERIC_HU_14		= 00280163, "Tevez Pang";
IDPLT_NAME_GENERIC_HU_15		= 00280164, "Keril St. John";
IDPLT_NAME_GENERIC_HU_16		= 00280165, "Anna Porthovski";
IDPLT_NAME_GENERIC_HU_17		= 00280166, "Thomas Blackeagle";
IDPLT_NAME_GENERIC_HU_18		= 00280167, "Trent Lesse";
IDPLT_NAME_GENERIC_HU_19		= 00280168, "Feodor Soltris";
IDPLT_NAME_GENERIC_HU_20		= 00280169, "Tamera Booth";
IDPLT_NAME_GENERIC_HU_21		= 00280170, "Ushasi Kilomon";
IDPLT_NAME_GENERIC_HU_22		= 00280171, "Randall Page";
IDPLT_NAME_GENERIC_HU_23		= 00280172, "Niccola DiPaven";
IDPLT_NAME_GENERIC_HU_24		= 00280173, "Maggi Fung-Ching Lee";
IDPLT_NAME_GENERIC_HU_25		= 00280174, "Axel Banderro";
IDPLT_NAME_GENERIC_HU_26		= 00280175, "Yukio Kajiwar";
IDPLT_NAME_GENERIC_HU_27		= 00280176, "Eugene Skinner";
IDPLT_NAME_GENERIC_HU_28		= 00280177, "Plummer Jackson-Kord";
IDPLT_NAME_GENERIC_HU_29		= 00280178, "Hiero Crane";
IDPLT_NAME_GENERIC_HU_30		= 00280179, "Matthew Turubi";

IDPLT_NAME_GENERIC_CY_5           = 00280201, "<child-reduce-sizzle>";  
IDPLT_NAME_GENERIC_CY_6           = 00280202, "<rock-paper-sissors>";  
IDPLT_NAME_GENERIC_CY_7           = 00280203, "<Protector-Ten>";  
IDPLT_NAME_GENERIC_CY_8           = 00280204, "<carve-organics>";  
IDPLT_NAME_GENERIC_CY_9           = 00280205, "<Purifier-of-Vermin>";  
IDPLT_NAME_GENERIC_CY_10 		  = 00280206, "<Bringer-of-Fear: Ten>";  
IDPLT_NAME_GENERIC_CY_11          = 00280207, "<fear-harvester>";  
IDPLT_NAME_GENERIC_CY_12          = 00280208, "<flow-truncheon>";  
IDPLT_NAME_GENERIC_CY_13          = 00280209, "<stasis 90201: NULL>";  
IDPLT_NAME_GENERIC_CY_14          = 00280210, "<Reducer-of-Habitat>";  
IDPLT_NAME_GENERIC_CY_15          = 00280211, "<Animal-Killer: Nine>";  
IDPLT_NAME_GENERIC_CY_16          = 00280212, "<spawn-prohibitory>";  
IDPLT_NAME_GENERIC_CY_17          = 00280213, "<delete-appendage>";  
IDPLT_NAME_GENERIC_CY_18          = 00280214, "<bovine-burning>";  
IDPLT_NAME_GENERIC_CY_19          = 00280215, "<Animal-Killer: Seven>";  
IDPLT_NAME_GENERIC_CY_20          = 00280216, "<process-canker>";  
IDPLT_NAME_GENERIC_CY_21          = 00280217, "<pylon-of-three>";  
IDPLT_NAME_GENERIC_CY_22          = 00280218, "<Purifier-Ten>";  
IDPLT_NAME_GENERIC_CY_23          = 00280219, "<ocular-puncture>";  
IDPLT_NAME_GENERIC_CY_24          = 00280220, "<scour>";  
IDPLT_NAME_GENERIC_CY_25          = 00280221, "<neural-sear>";  
IDPLT_NAME_GENERIC_CY_26          = 00280222, "<lizard-fetish>";  
IDPLT_NAME_GENERIC_CY_27          = 00280223, "<candlewax-G>";  
IDPLT_NAME_GENERIC_CY_28          = 00280224, "<numb-virtue-infect>";  
IDPLT_NAME_GENERIC_CY_29          = 00280225, "<decant-misery>";  
IDPLT_NAME_GENERIC_CY_30          = 00280226, "<rapture-of-carnage>";
IDPLT_NAME_GENERIC_CY_31          = 00280227, "<injection-slaughter>";  
IDPLT_NAME_GENERIC_CY_32          = 00280228, "<white-noise>";
IDPLT_NAME_GENERIC_CY_33          = 00280229, "<promissory-blinder>";  
IDPLT_NAME_GENERIC_CY_34          = 00280230, "<f-NULL>";  
IDPLT_NAME_GENERIC_CY_35          = 00280231, "<rupture>";  
IDPLT_NAME_GENERIC_CY_36          = 00280232, "<toucher-of-pipes>";  
IDPLT_NAME_GENERIC_CY_37          = 00280233, "<suppression-estimate>";  
IDPLT_NAME_GENERIC_CY_38          = 00280234, "<eater-of-viscerae>";  
IDPLT_NAME_GENERIC_CY_39          = 00280235, "<twitch-rabbit>";  
IDPLT_NAME_GENERIC_CY_40          = 00280236, "<gradual-prokaryote>";  

IDDAT_END_SQUADMATE_NAME_2         = 00280250, "";

IDDAT_BEG_SQUADMATE_BIO_2          = 00280300, "";
 
IDPLT_BIO_GENERIC_HU_5           = 00280420, "Rille was born in a cramped arcology of Ishtar City. Her father was a mechanic, "
								  		@"and she grew up around machinery. The war forced her into a pilot's role, though "
								  		@"she'd much rather be working on Hercs instead of taking them into battle. To her "
								  		@"chagrin, her young son wants to be a combat pilot someday. Her callsign evolved "
								  		@"from the way Martians pronounce her first name.";
IDPLT_BIO_GENERIC_HU_6           = 00280421, "Stahl was born in Drachensatem, and he believes he's invulnerable, a warrior-"
								  		@"poet with a destiny to fulfill. His squadmates think his minimalist poetry is "
								  		@"excruciatingly bad, but they admit Stahl is a right bastard on the battlefield.  "
								  		@"He never gives up, and swears he'll never leave a buddy behind. People like him "
								  		@"in spite of his enormous ego.";
IDPLT_BIO_GENERIC_HU_7           = 00280422, "Gibbons was a medical trainee when the war broke out. She travelled to Mars as a "
								  		@"corpsman, but quickly found herself filling a combat role as well. She deals "
								  		@"with the stress by working out. Her long, tautly muscled legs have inspired "
								  		@"enthusiastic toasts at many a crew gathering. She stays disciplined and is more "
								  		@"comfortable among people from Earth.";
IDPLT_BIO_GENERIC_HU_8           = 00280423, "Her fine manners and dramatic Venusian style make Ostergard stand out among her "
								  		@"fellow pilots. She always seems to be on stage, and maintains an aristocratic "
								  		@"distance until she loosens up with a few drinks. She's pretty friendly then, and "
								  		@"on the whole well-liked. On the battlefield, she's all business, cold, hard, and "
								  		@"professional.";
IDPLT_BIO_GENERIC_HU_9           = 00280424, "After his father's business went under due to Imperial economic pressure, "
								  		@"Asahara travelled to Mars and found his way into the rebel movement. His looks "
								  		@"make him popular with the female squadmates, and he's earned a reputation as a "
								  		@"cool head on the battlefield, so rebel life is good for now. He carries an "
								  		@"ancient Japanese sword in his cockpit for good luck, and to remind him how the "
								  		@"Empire dishonored his family.";
IDPLT_BIO_GENERIC_HU_10           = 00280425, "Lee's cheery manner and endless stream of bad jokes drive his squadmates crazy.  "
								  		@"Lee is a fan of ancient Western \"movies,\" particularly the monochrome ones, to "
								  		@"the point where he frequently quotes lines from his favorites. What redeems him "
								  		@"to his squadmates is that he keeps a terrible poker face, but loves to play "
								  		@"five-card draw.";
IDPLT_BIO_GENERIC_HU_11           = 00280426, "As with all BioDerms, the background of Zebra Eight is unknown. No one knows the "
								  		@"specific crime that resulted in her conversion to a Derm. Her soft skin and "
								  		@"occasional elegant gestures suggest she led a life of ease in her past. She "
								  		@"seems socially adept for a BioDerm, but something keeps her from making friends.  "
								  		@"Her squadmates complain uneasily that she always looks \"hungry,\" and they keep "
								  		@"children away from her.";
IDPLT_BIO_GENERIC_HU_12           = 00280427, "A Venusian from Drachensatem, Alvarez is a cynical hump 'n thrall Ubergoth who adorns her "
								  		@"uniform with black ribbons and jewelry. Her body has numerous piercings, enough "
								  		@"that her squadmates joke about her someday sparking a short circuit in her "
								  		@"vehicle's cockpit. She keeps a recorded journal, hoping to be able to share it "
								  		@"with her family if there's a future for anyone after the war.";
IDPLT_BIO_GENERIC_HU_13           = 00280428, "Abrasive and foul-mouthed, Chang comes originally from Hong Kong, and swears he "
								  		@"spent his childhood on a pirate junk. Before the rebellion, he served aboard "
								  		@"Harabec's space raiders. Later he became a front-line pilot He has an impressive "
								  		@"light tattoo that depicts a scene of a dragon and a phoenix. Chang considers "
								  		@"both of these mythical beasts sources of great good luck. Still, he doesn't rely "
								  		@"on luck to keep him alive. He runs a regular poker game among the crews.";
IDPLT_BIO_GENERIC_HU_14           = 00280429, "Pang is an icegrub made good, as he sees it. The resistance on Titan contacted "
								  		@"him after he served a year in solitary for punching out a corpcop who was "
								  		@"harassing an NTDF recruit. After working as a \"space monkey\" in Harabec's space "
								  		@"raiders, he transferred to Mars to \"see something that wasn't all buttfreeze and "
								  		@"ammonia.\" Pang takes flak from nobody, and he doesn't miss Titan at all.";
IDPLT_BIO_GENERIC_HU_15           = 00280430, "Born in the outback of Australia, St. John joined the Pacific Rim Air Force and "
								  		@"served a four-year term with distinction. She had relatives on Mars. When she "
								  		@"protested against Imperial policy there, PRAF discharged her. St. John went to "
								  		@"visit her cousins in Syrtis, and from there she found her way into the "
								  		@"rebellion. Her callsign comes from a persistent allergy to Martian dust.";
IDPLT_BIO_GENERIC_HU_16           = 00280431, "Porthovski goes by the book. A graduate of the Imperial Mars Military Institute "
								  		@"in Victoria, Porthovski is second generation Terran, so the TDF assigned her to "
								  		@"the Martian Imperial Police. She hated the duty, and joined the rebels after "
								  		@"police killed the miners in Tharsis. She disapproves of sloppy uniforms and the "
								  		@"lack of \"snap\" in Martian troops. Porthovski seems to take everything "
								  		@"personally, and she has few friends.";
IDPLT_BIO_GENERIC_HU_17           = 00280432, "\"Part Cheyenne, part refugee from the dead Earth,\" is how the scarred Blackeagle "
								  		@"describes himself. His family was part of an ethnic tribe that refused to "
								  		@"recognize the legitimacy of Imperial law. They were killed in the Oklahoma "
								  		@"insurrection of '09, and Blackeagle was sent to a re-education facility. As soon "
								  		@"as he came of age, he travelled to Mars, where the rebels eventually recruited "
								  		@"him. He refuses to let go of his anger. It's what kept him whole, he says.";
IDPLT_BIO_GENERIC_HU_18           = 00280433, "Wealthy son of a corporate executive from Earth, Lesse found nothing on Mars "
								  		@"worth doing except race scuttlebots, chase women, and party. After one "
								  		@"unfortunate night, he woke up with a hangover and found out his new friends were "
								  		@"rebels. He also found out his name had been linked to the rebellion, and that "
								  		@"the Imperial Police had orders to shoot him for treason. Lesse figured the only "
								  		@"way out was to join the rebellion. He complains a lot, but he's a good pilot and "
								  		@"pulls his weight.";
IDPLT_BIO_GENERIC_HU_19           = 00280434, "Soltris is a musician from the Inca-Brazil Axis, born in Old Brazil. He studied "
								  		@"at the Salis Academy on Venus and saw first-hand how the brutal policies of the "
								  		@"Empire worked in the colonies. Deciding he couldn't stand by, he joined the "
								  		@"resistance and discovered he possessed a knack for piloting. When the crews "
								  		@"party, he's the first to pull his instruments out and fire up the dancing.";
IDPLT_BIO_GENERIC_HU_20           = 00280435, "A long-term romance of Axel Banderro, Booth comes from the preenpunk night scene of "
								  		@"the LA metrozone. Her body is covered in light tattoos and jeweled implants, and "
								  		@"her hair color approaches radioactive. Notwithstanding her cocky attitude, she "
								  		@"takes no unnecessary risks on the battlefield. Her involvement in the war began "
								  		@"when she interfered with a Police arrest on Epulae Platform and soon found "
								  		@"herself on board a space raider bound for Mars, getting to know the Axeman.";
IDPLT_BIO_GENERIC_HU_21           = 00280436, "Born in the Maasai Agricultural Enclave, Kilomon has seen it all, from her "
								  		@"parents' slow death in a Martian prison to the Police throwing her brothers and "
								  		@"sisters under advancing dustcrawlers. She has a tremendous hatred of the Empire, "
								  		@"but she keeps her emotions locked away. Kilomon doesn't say much, and no one "
								  		@"messes with her, especially Imperials. She's a mean hand at poker, too. She "
								  		@"spends a lot of time sharpening a spear Hunter Otobe gave her.";
IDPLT_BIO_GENERIC_HU_22           = 00280437, "Nicknamed for his bulging eyes, Page is a former Imperial Police technician who "
								  		@"defected in 2826. He has since learned to be a pilot, and takes a thinking "
								  		@"approach to combat. He has the reputation of being able to scrounge nearly "
								  		@"anything, and has a thriving little business of his own among the crews. He "
								  		@"chainsmokes and has a persistent cough from a childhood bout with Martian "
								  		@"whipples. When questioned about his habit, his response is, \"No one lives "
								  		@"forever, dogbreath.\"";
IDPLT_BIO_GENERIC_HU_23           = 00280438, "DiPaven took her younger brother and fled to the Martian outback after Imperial "
								  		@"Police arrested her father for \"rebel sympathies.\" A rebel patrol found them before "
								  		@"exposure set in, and DiPaven's been in the thick of things ever since. An "
								  		@"impulsive young woman with a winning smile, she developed an obvious crush on Harabec.  "
								  		@"This observation inspired her squadmates to christen her \"Heartbreak.\"";
IDPLT_BIO_GENERIC_HU_24           = 00280439, "Lee was an Imperial Police cargo pilot unlucky enough to be shot down by rebels.  "
								  		@"She got out of the ship before a rebel Herc arrived to finish it off, but was "
								  		@"captured before she could make it back to base. After witnessing the depth of "
								  		@"the Martians' plight and the extent of Imperial oppression, she volunteered to "
								  		@"fight for the rebellion. Her callsign is the same one she had as an Imperial.  "
								  		@"She'd mistakenly let it slip early in her captivity, and it stuck again. She hates it.";
IDPLT_BIO_GENERIC_HU_25           = 00280440, "Banderro is big, ugly, and proud of it. His shaven pate is covered in twisted "
								  		@"tattoos and brandings. He's fond of tale telling, and claims he built his " 
								  		@"muscles pounding on the bulkheads of his home at Sa Thauri to send messages to "
								  		@"his friends. He's into loud music that sounds like mashed cats. He tells everyone who "
                                        @ "will listen that he joined up because he was bored of \"surfing the Oberwind\" back home. "
                                        @ "He and Tamera Booth have a \"thing.\"";
IDPLT_BIO_GENERIC_HU_26           = 00280441, "Kajiwar was a young exec for the Arastyx Water Consortium paying her dues in the "
								  		@"backwater of Titan when she became involved in the war. She made friends with "
								  		@"some of the local militia, a proud group called the NTDF. They inspired her to "
								  		@"look beyond a corporate career, and she began to protest Imperial Fortification "
								  		@"Policy. Arastyx shipped her home and fired her. She travelled to Mars and "
								  		@"eventually joined the rebels. Now she puts her ideals on the front lines.";
IDPLT_BIO_GENERIC_HU_27           = 00280442, "A Testcase addict, hophead, and thief from the streets of New Chicago, Skinner "
								  		@"was sent to Mars as part of a convict labor battalion in 2820. When a rebel raid "
								  		@"freed him in 2825, he responded by grabbing a weapon and blowing away several "
								  		@"Police guards. Then he persuaded skeptical rebels to take him along, arguing he "
								  		@"had nothing else to live for and would go back to drugs if left on his own. The rebs "
								  		@"grudgingly accepted him, and he went on to prove himself as an adept and "
								  		@"ferocious combat pilot.";
IDPLT_BIO_GENERIC_HU_28           = 00280443, "A respected holojournalist for NewsNet, Jackson-Kord was content with his "
								  		@"Martian wife and four children. Unfortunately, his job became increasingly "
								  		@"political, and when he was told to make a whitewashed documentary on Chief "
								  		@"Navarre, he refused. After serving a month of chemically-induced paralysis on a "
								  		@"trumped-up charge, he took his family into hiding and eventually joined the "
								  		@"rebels.";
IDPLT_BIO_GENERIC_HU_29           = 00280444, "Crane looks like his namesake, tall and graceful, with a long face and an unruly "
								  		@"thatch of hair. He's a quiet and methodical worker, but has a faraway look when "
								  		@"he's not tinkering with his Herc. When asked, he tells people, \"It\'s only the "
								  		@"beginning, this war.\" He had originally wanted to join the Stormkeeper Order, "
								  		@"but couldn't turn his back on the injustice happening on Mars. Crane meditates, "
								  		@"and offers to teach others to do so, but few have accepted.";
IDPLT_BIO_GENERIC_HU_30           = 00280445, "An energetic, eternally optimistic fellow, Turubi likes speed. He hopes the "
								  		@"alien technology will allow construction of much faster vehicles. Whenever "
								  		@"possible, he tries to optimize his Herc or tank for speed and acceleration. A "
								  		@"definite womanizer, Turubi has a reputation for fast movement outside his Herc "
								  		@"as well.";

IDPLT_BIO_GENERIC_CY_5		    = 00280504, "Fully accepts responsibility allotted to \<it> by the "
							@ "needs of the Core Directive.  Measures \<its> efficiency\\\\"
							@ "success through a balance of serving the NEXT and keeping "
							@ "subordinates intact\\\\online.  Focuses on primary targets of "
							@ "human newboots >>'childrenforms'\<\<.\n\nPRIMARY REDACTOR CONCERN:  "
                            @ "May illogically sacrifice \<itself> for subordinates.";
IDPLT_BIO_GENERIC_CY_6            = 00280505, "<Unit> has history of attempting to remain in constant proximity to "
							@ "\<Plague Dog>, apparently due to a strained loyalty-attachment "
							@ "subroutine. \<Unit> does not display any sign of Metagen sympathies.  "
							@ "\<Its> performance in combat is acceptable, though \<it> persists in "
							@ "selecting from only three limited tactical response sets and manifests "
							@ "difficulty\\\\hesitancy in choosing warform configurations.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Excessive attachment to <Plague Dog>.";
IDPLT_BIO_GENERIC_CY_7            = 00280506, "Unit displays acceptable loyalty to operating protocols of the "
							@ "NEXT as set forth by \<Giver-of-Will>. Noted as only surviving unit of "
							@ "<Plague Dog> magnetic expulsion incident, though \<it> spent 00100  "
							@ "iterations on a vector toward Eighth Planet before laborforms  "
							@ "retrieved \<it>.  \<Unit> displays exceptional ability defending "
							@ "predetermined x/y defined zone.\n\nPRIMARY REDACTOR CONCERN: \<Unit> seems less efficient in "
                            @ "expansive\\\\unconfined spaces.";
IDPLT_BIO_GENERIC_CY_8            = 00280507, "Fully accepts responsibility allotted to \<it> by any "
							@ "superior \<it> deems competent.  Strives to perform expected "
							@ "duties completely\\\\efficiently. Noted for series of experiments on human pain tolerance, "
                            @ "and efficient use of subject remains as prototype machine lubricant. "
                            @ "\n\nPRIMARY REDACTOR CONCERN: May defy an inefficient superior.";
IDPLT_BIO_GENERIC_CY_9            = 00280508, "Displays violent tendencies that grow after each modification"
							@ "\\\\enhancement. Appears intrinsically to loathe human\\\\animals "
							@ "independently of the Core Directive or \<Giver-of-Will>. Noted for killing "
							@ "human\\\\animals by stepping on them, recording the creatures' offline-"
							@ "process sounds, and saving that data into a directory for playback "
							@ "during hub\\\\privacy schedule.\n\nPRIMARY REDACTOR CONCERN: Fascination "
                            @ "with human\\\\animal offline process sounds is excessive and potentially inefficient.";
IDPLT_BIO_GENERIC_CY_10           = 00280509, "\<Unit> prefers smaller, faster warforms and rapid combat "
							@ "insertion techniques.  \<Unit> is efficient at offlining humans, but "
							@ "fails to grasp subtlety of Core Directive and displays impaired tactical "
							@ "intelligence.  Exemplar Sect disregards//discounts \<unit> importance, and "
							@ "has authorized deprioritization of \<unit> survival.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Fails to exercise consistent restraint\\\\judgment during combat.";
IDPLT_BIO_GENERIC_CY_11           = 00280510, "Believes no \<unit> should face an opponent without first proving "
							@ "equality among own hubmates.  \<It> has left scars on the chassis of "
							@ "every subordinate charged to \<it>. \<It> concedes\\\\defers only to "
							@ "superiors in Exemplar Sect. Displays superior efficiency in causing "
							@ "emotional disturbance in human\\\\animal targets. \<Unit> persists in "
							@ "broadcasting unusual static hiss across animal frequencies during combat."
                            @ "\n\nPRIMARY REDACTOR CONCERN: Non-Exemplars must exercise excessive caution\\tact in relations "
                            @ "with \<unit>.";
IDPLT_BIO_GENERIC_CY_12           = 00280511, "\<Unit> displays commendable zeal in executing the tenets of "
							@ "\<Giver-of-Will>. Perpetually competitive with hubmates.  Has off-lined "
							@ "sixteen \<units> suspected of heresy\\\\bugthought when investigations "
							@ "proved insubstantial\\\\ineffective.  \<Unit> is also an efficient combat "
							@ "pilotform, performing within acceptable parameters.\n\nPRIMARY REDACTOR CONCERN: Places "
                            @ "higher priority on destruction of suspected heretical \<units> than on execution of Core Directive.";
IDPLT_BIO_GENERIC_CY_13           = 00280512, "\<Unit> has been redacted several times for lacking sufficient "
							@ "motivation.  Core Directive priority has permitted this \<unit's> "
							@ "preservation for combat duty.  Estimates are that \<unit> must assist in "
							@ "offlining thirty-two animals to justify further redaction and avoid "
							@ "recycling. \<It> enjoys observing the light pulse effect of energy weapons "
							@ "engaging shields and is prone to transmitting random noises during combat.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Insufficiently connected\\\\submissive to Core Directive.";
IDPLT_BIO_GENERIC_CY_14           = 00280513, "\<Unit> strives to enhance \<its> own abilities through independent "
							@ "objectives.  Prefers backup\\\\cleanup mission assignments, particularly "
							@ "where the objective is destruction of human\\\\animal environments. "
							@ "Aptitude has earned swift promotion in <its> Circuit and shows promise in "
							@ "aligning fellow \<units>. with proper respect\\\\obedience to Core Directive.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Displays dangerous interest in human music, particularly obsolete source "
                            @ "designated \"Elvis.\"  ";
IDPLT_BIO_GENERIC_CY_15           = 00280514, "\<Unit> persists in distrust of redactor authority.  Noted for "
							@ "offlining enemy human warforms by ramming after exhausting weapon munitions.  "
							@ "Efficiency ratios remain high despite accumulation of damage to \<unit's> own "
							@ "warform. \<It> claims \<it> seeks to determine animal survivability against "
							@ "collision tactics, and has been observed to take animal cranial tissue samples "
                            @ "following engagement.\n\nPRIMARY REDACTOR CONCERN: Resistant to benevolence\\\\redaction and "
                            @ "periodic programming realignment.";
IDPLT_BIO_GENERIC_CY_16           = 00280515, "\<Unit> has interpreted <its> function as eradication "
							@ "of all human\\\\animal newboots, reasoning that human reproductive rates "
							@ "and maturation requirements cannot replace lost combat units fast enough to "
							@ "counter Core Directive progress.  Cities ancillary correlation of human "
							@ "psychological disruption with mutilation of human reproductive physiognomy.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Exhibits excessive independent reasoning.";
IDPLT_BIO_GENERIC_CY_17           = 00280516, "\<Unit> exhibits unusual reasoning.  Paints pilotform carapace with "
							@ "human\\\\animal bodily fluids.  Noted for tricking human\\\\animals into "
							@ "offlining their own quad members.  Prefers faster warforms. \<Unit> harvests "
							@ "manipulatory and locomotive appendages from captured animals.  Expresses "
							@ "interest in human\\\\animal peripheral neural structures.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Refuses to remove animal bodily fluids from carapace.";
IDPLT_BIO_GENERIC_CY_18           = 00280517, "Displays unusually aggressive disposition toward non-human\\\\animals.  "
							@ "Noted//renamed for igniting several hundred animals designated >>cows\<\< with "
							@ "combustible fluids during rapid deployment raid on human agricultural complex.  "
							@ "Insists on non-standard combat priority protocols. \<Unit> prioritizes "
							@ "extermination of non-human\\\\animal targets over Core Directive-mandated "
							@ "objectives.\n\nPRIMARY REDACTOR CONCERN: Targeting priorities suggest partial rejection of Core Directive.";
IDPLT_BIO_GENERIC_CY_19           = 00280518, "This \<unit> prefers using radiation projectors against human\\\\animals, "
							@ "citing superior target mortality results. When offered reassignment to Trojan "
							@ "Horse program, \<it> refused, arguing that the concept of encasing <itself> in "
							@ "meat was >>disgusting\<\<.  Superiors note that each such reassignment offer "
							@ "temporarily increases the \<unit's> kill ratios on subsequent missions.  "
							@ "Consequently, reassignment offers will continue indefinitely.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "\<Unit> has explored human\\\\animal violent cinema.";
IDPLT_BIO_GENERIC_CY_20           = 00280519, "\<Unit> believes Core Directive is open to individual interpretation.  "
							@ "\<It> encourages//misdirects subordinates to ingest//consider data with reference "
							@ "to individual protocols\\\\values\\\\priorities.  Only \<its> own orders are "
							@ "considered unquestionable. \<Unit> believes all <units> booted//created prior "
							@ "to \<self> are obsolete\\\\inferior.\n\nPRIMARY REDACTOR CONCERN: Questions//doubts "
                            @ "objective reality of Core Directive infallibility\\\\preeminence.";
IDPLT_BIO_GENERIC_CY_21           = 00280520, "\<Unit> obsesses on iterations\\\\patterns involving prime number >>3\<\<.  "
							@ "\<It> engages in erratic behavior based on \<its> perception of such patterns.  "
							@ "Paradoxically beneficient\\\\efficient results derive from <its> efforts to "
							@ "attain body counts divisible by three.  \<Unit> records all data \<it> perceives "
							@ "as somehow related to >>3\<\<, occasionally providing useful strategic information.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Obsession risks heresy\\\\bugthought. \<Giver-of-Will> is ONE; human\\\\animal religion includes "
                            @ "references to triune god.";
IDPLT_BIO_GENERIC_CY_22           = 00280521, "\<Unit> has focused priority toward enhancing \<its> ability to process to "
							@ "process and compress tremendous volumes of information.  \<It> is noted for "
							@ " effective\\\\thorough on-site retrievals from animal databanks during scout\\\\"
							@ "probe excursions.  \<It> also displays notable efficiency in purging//target areas "
							@ "of human\\\\animal survivors.\n\nPRIMARY REDACTOR CONCERN: May be withholding portions of \<its> "
                            @ "data for leverage\\\\advantage\\\\barter.";
IDPLT_BIO_GENERIC_CY_23           = 00280522, "\<Unit> fascinated with accounts of human predators "
							@ "classified >>serial murderers\<\<. Seeks to emulate such efficient killers as >>Jack "
							@ "the Ripper\<\< and >>Cinderella-X\<\<.  Proposed behavioral model involves selective "
							@ "target mutilation. \<Unit> uses modified pilotform probes to destroy animal visual "
							@ "organs.  \<It> also explores the use of intense light variation to burn out human\\\\"
							@ "animal retinas.\n\nPRIMARY REDACTOR CONCERN: Adoption of human\\\\animal models suggests "
                            @ "metagenic drift into heresy is 85% probable.";
IDPLT_BIO_GENERIC_CY_24           = 00280523, "\<Unit> displays suitable\\\\efficient aggression in purifying sectors of "
							@ "human\\\\animal influence.  However, \<unit> attempts to preserve fresh newboots "
							@ ">>infants\<\< for redaction experimentation.  \<Unit> irrationally hopes to condition//"
							@ "program human newboots to accept NEXT parameters.\n\nPRIMARY REDACTOR CONCERN: Pursuit of futile\\\\suspicious\\\\heretic "
                            @ "program.";
IDPLT_BIO_GENERIC_CY_25           = 00280524, "\<Unit> displays interest in pursuing infliction of >>pain\<\< on human subjects.  "
							@ "To this end, \<it> has performed efficiently in acquiring and experimenting on variety "
							@ "of animal \<units>.  The priority\\\\preference has not interfered with tactical "
							@ "efficiency; \<unit> kill ratios remain acceptable.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "\<Unit> appears to derive 'pleasure' from infliction of >>pain\<\< without regard to practical results.";
IDPLT_BIO_GENERIC_CY_26           = 00280525, "\<Unit> strives to document//record//archive all human\\\\animal media "
							@ "encountered.  Although \<it> appears to find majority of gathered data tedious\\\\"
							@ "irrelevant, \<it> argues other units may perceive//glean something of value.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Repeatedly reviews human\\\\animal programs regarding reptiles. The significance\\\\heresy of this action has "
                            @ "not yet been determined.  ";
IDPLT_BIO_GENERIC_CY_27           = 00280526, "\<Unit> claims to be exceptionally adept with human\\\\animal colloquialisms.  "
							@ "\<It> demonstrates//shares data frequently with dismayed\\\puzzled hubmates.  Noted "
							@ "for broadcasting animal >>obscenities\<\< during combat.  <Unit> collaborates with "
							@ "Dissector Sect to convert human\\\\animal remains into fuel\\\\illumination source.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Intercepted human\\\\animal transmissions easily distract \<unit>.";
IDPLT_BIO_GENERIC_CY_28           = 00280527, "This innovative, reliable <unit> displays talent\\\\aptitude for destroying "
							@ "human warforms.  \<It> is unlikely to retreat from unfinished\\\\unsatisfied mission "
							@ "objectives, and holds potential\\\\possibility for eventual advancement to sect "
							@ "leadership.  \<Unit> currently subscribes to viral model of attack strategy advanced "
							@ "by Provocateur Sect.\n\nPRIMARY REDACTOR CONCERN: Values Provocateur input more than Redactor counsel.";
IDPLT_BIO_GENERIC_CY_29           = 00280528, "\<Unit> is reliable, executing functions within acceptable parameters.  \<It> "
							@ "fixes priority on recording instances of human\\\\animal experience categorized\\\\"
							@ "defined as >>suffering\<\<.  \<Unit> lingers over damaged human units in order to attain "
							@ "optimal data, and occasionally conducts experiments to increase animal reaction.  "
							@ "Dissector Sect has registered disapproval of such departure\\\\deviance from Sect "
							@ "function.\n\nPRIMARY REDACTOR CONCERN: May sacrifice mission objectives to satisfy \<its> independent priorities.";
IDPLT_BIO_GENERIC_CY_30           = 00280529, "\<Unit> is exceptional killer of human\\\\animals, and displays unusual processing "
							@ "activity while offlining animal units.  Intensity of reaction surpasses most "
							@ "recorded instance of >>pleasure\\\\satisfaction\<\<.  Positive programming loop enhances "
							@ "\<unit's> desire to execute Core Directive, and redaction of \<unit's> experience "
							@ "of >>ecstasy\<\< is currently regarded an unnecessary\\\\inefficient.\n\nPRIMARY REDACTOR CONCERN: \<Unit's> self-name "
                            @ "carries potential heretical interpretations.";
IDPLT_BIO_GENERIC_CY_31           = 00280530, "\<Unit> advocates using biological weapons against human\\\\animals despite "
							@ "\<Giver-of-Will's> commandment\\\\mandate to test NEXT \<units> directly against "
							@ "human warforms. \<Unit> has experimented with small-scale use of disease warfare and "
							@ "argues in favor of using Trojan Horse <units> as plague carriers.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Has argued in favor of keeping human\\\\animal breeding stock for experimentation.";
IDPLT_BIO_GENERIC_CY_32           = 00280531, "\<Unit> >>enjoys\<\< the sound of static that follows a human\\\\animal warform "
							@ "termination.  \<It> maintains an archive of data loops from previous operations.  In "
							@ "combat, \<it> initiates communication with human\\\\animal warforms to facilitate "
							@ "procurement of \<its> desired recordings.  Unit feels all answers exist within "
							@ "chaos\\\\noise.  \<Unit> noted for discerning precise decibels necessary to destroy "
							@ "human\\\\animal audio receptors.\n\nPRIMARY REDACTOR CONCERN: Engages in dialog with human pilotforms "
                            @ "prior to engaging them in combat. Potential exists for metagenic infection. ";
IDPLT_BIO_GENERIC_CY_33           = 00280532, "\<Unit> investigated possibility of genetic cybrid evolution involving implantation "
							@ "into human\\\\animal specimens.  Subsequent efforts yielded considerable documentation "
							@ "on brain chemistry differences between specimens, supplanted by data from the Inquisitor "
							@ "and Machinator sects. Further research has been delayed due to current priorities "
							@ "of the Core Directive.\n\nPRIMARY REDACTOR CONCERN: Disposed differently to human\\animals based on gender. ";
IDPLT_BIO_GENERIC_CY_34           = 00280533, "\<Unit> destroyed//offlined <its> entire hub shortly after booting up. Redactors "
							@ "subsequently discovered a severed algorithm string that triggered violent paranoia in "
							@ "the new boot.  [Newboot Center:::Charon] no longer accesses [NEXUS Armory:::Charon].  "
							@ "\<Unit> accepted redaction\\\\implantation and executes all duties efficiently.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Avoids venturing into vacuum.";
IDPLT_BIO_GENERIC_CY_35           = 00280534, "\<Unit> displays exceptional surgical aptitude.  \<It> spent several cycles "
							@ "helping to develop more effective Trojan Horse implantation methodology.  \<Unit> "
							@ "believes vivisection of human\\\\animal units should be an end\\\\goal\\\\directive "
							@ "in itself, and strives to capture intact human specimens.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Frequently requests medical data unrelated to human\\animal cranial insertion.  ";
IDPLT_BIO_GENERIC_CY_36           = 00280535, "\<Unit> autonomously wiped \<its> own mind after \<its> optimal was destroyed in "
							@ "[NEXUS Shipyard-01201:::Tartarus] nanoassembler error and subsequent Nexus "
							@ "detonation.  \<Unit> was outside Nexus at time, and the explosion accelerated \<its> "
							@ "pilotform sunward. \<It> drifted inert until recovered by scout array near asteroid "
							@ "belt seven megacycles later.  \<Unit> has performed Redactor Sect labor since that "
							@ "time.\n\nPRIMARY REDACTOR CONCERN: Displays compulsion to make physical contact with liquid transfer "
                            @ "conduits periodically and becomes aggressive if denied such contact.  ";
IDPLT_BIO_GENERIC_CY_37           = 00280536, "\<Unit> focuses on assembling data relevant to projection\\\\prediction of "
							@ "Core Directive completion.  Area of particular concentration is duration of human\\\\"
							@ "animal resistance. \<Unit> therefore maintains cautious tactical approach so as to "
							@ "observe human warforms and to assess the animals' tactical integrity\\\\potential.\n\nPRIMARY REDACTOR CONCERN: "
                            @ "Displays extreme difficulty in communicating about subject areas not related to data gathering mission.";
IDPLT_BIO_GENERIC_CY_38           = 00280537, "\<Unit> predominately concerned with effective implementation of Cybrid "
							@ "technology into Human\\\\animal bodies.  \<Unit> noted for successful fusion of "
							@ "Cybrid warform to partial Human\\\\animal cerebellum.  \<It> displays a fascination "
							@ "with the central abdominal structures of animal bodies and experiments with various "
							@ "high-kinetic trauma to those regions.\n\nPRIMARY REDACTOR CONCERN: Adverse to direct pilotform contact "
                            @ "with human\\animal fluids.";
IDPLT_BIO_GENERIC_CY_39           = 00280538, "\<Unit> is completely poised to destroy anything pertaining to human\\\\"
							@ "animals. Unfortunately,, \<it> completely lacks ability to strategize, and \<its> "
							@ "impulsive weapon use is hazardous to other <units> in \<its> quad. \<Unit> reasons "
							@ "that heretics are not worthy of redaction, opposes the Trojan Horse program, and "
							@ "argues that all Machinators are heretics.\n\nPRIMARY REDACTOR CONCERN: Probability of \<unit> attacking "
                            @ "Machinators continues to escalate.";
IDPLT_BIO_GENERIC_CY_40           = 00280539, "\<Unit> proved exceptionally effective under unusual circumstances.  "
							@ "Undergoing an emergency reboot after [Plethoric-Two shuttle en route to NEXUS:::"
							@ "Egypt] was struck by an asteroid, the \<unit> retrieved//salvaged//ejected five "
							@ "other \<units> and \<itself> to safety before the shuttle disintegrated. \<It> is the only "
							@ "unit known to continue from an emergency boot without subsequent redaction.\n\nPRIMARY REDACTOR CONCERN: Displays no "
                            @ "indication of individual personality.";


IDPLT_CONCERN_GENERIC_CY_1		= 00280550, "Possibility \<Unit> may refuse to pursue defective\\\\"
								@ "renegade Metagen units.  ";
IDPLT_CONCERN_GENERIC_CY_2		= 00280551, "Excessive probability that \<Unit> will retreat "
								@ "if outnumbered.  ";
IDPLT_CONCERN_GENERIC_CY_3		= 00280552, "Refuses to capture human\\\\animals for Dissector Sect.  ";
IDPLT_CONCERN_GENERIC_CY_4		= 00280553, "\<Unit's> objective-attainment processing is short\\\\impulsive.  ";
IDPLT_CONCERN_GENERIC_CY_5		= 00280554, "\<Unit> may illogically sacrifice self for subordinates.  ";
IDPLT_CONCERN_GENERIC_CY_6		= 00280555, "\<Unit> overly attached to \<Plague Dog>.";
IDPLT_CONCERN_GENERIC_CY_7		= 00280556, "\<Unit> seems uncomfortable\\\\inefficient in expansive spaces.  ";
IDPLT_CONCERN_GENERIC_CY_8		= 00280557, "\<Unit> may defy an inefficient superior.  ";
IDPLT_CONCERN_GENERIC_CY_9		= 00280558, "\<Unit> fascination with Human\\\\animal offline-process sounds "
								@ "sounds is excessive\\\\potentially inefficient.  ";
IDPLT_CONCERN_GENERIC_CY_10		= 00280559, "\<Unit> fails to exercise consistent restraint\\\\judgment "
								@ "during combat.  ";
IDPLT_CONCERN_GENERIC_CY_11		= 00280560, "Non-Exemplars must exercise excessive caution\\\\diplomacy "
								@ "in relations with \<unit>.  ";
IDPLT_CONCERN_GENERIC_CY_12		= 00280561, "\<Unit> places higher priority on destruction of suspected "
								@ "heretical \<units> than on execution of Core Directive.  ";
IDPLT_CONCERN_GENERIC_CY_13		= 00280562, "\<Unit> is insufficiently connected\\\\submissive to "
								@ "Core Directive.  ";
IDPLT_CONCERN_GENERIC_CY_14		= 00280563, "\<Unit> displays unusual interest in human\\\\animal "
								@ ">>music\<\<, particularly obsolete <unit> designated 'Elvis.' ";
IDPLT_CONCERN_GENERIC_CY_15		= 00280564, "\<Unit> is resistant to benevolence\\\\redaction\\\\realignment.  ";
IDPLT_CONCERN_GENERIC_CY_16		= 00280565, "\<Unit> exhibits excessive independent reasoning.  ";
IDPLT_CONCERN_GENERIC_CY_17		= 00280566, "Refuses to remove animal bodily fluids from carapace.  ";
IDPLT_CONCERN_GENERIC_CY_18		= 00280567, "\<Unit's> targeting priorities suggest partial rejection of "
								@ "Core Directive.  ";
IDPLT_CONCERN_GENERIC_CY_19		= 00280568, "\<Unit> has explored//appreciated human\\\\animal violent cinema.  ";
IDPLT_CONCERN_GENERIC_CY_20		= 00280569, "\<Unit> questions//doubts objective reality of Core Directive "
								@ "infallibiltiy\\\\preeminence.  ";
IDPLT_CONCERN_GENERIC_CY_21		= 00280570, "\<Unit> obsession risks heresy\\\\bugthought.  \<Giver-of-Will> "
								@ "is ONE; human\\\\animal religion reference to triune god.  ";
IDPLT_CONCERN_GENERIC_CY_22		= 00280571, "\<Unit> may be witholding portions of <its> data for "
								@ "leverage\\\\advantage\\\\barter.  ";
IDPLT_CONCERN_GENERIC_CY_23		= 00280572, "\<Unit> use of human\\\\animal models suggests metagenic "
								@ "drift into heresy\\\\bugthought 85% probable.  ";
IDPLT_CONCERN_GENERIC_CY_24		= 00280573, "\<Unit> pursues futile\\\\heretical program.  ";
IDPLT_CONCERN_GENERIC_CY_25		= 00280574, "\<Unit> appears to derive>>pleasure\<\< from infliction "
								@ "of >>pain\<\< without regard to practical results.  ";
IDPLT_CONCERN_GENERIC_CY_26		= 00280575, "\<Unit> repeatedly reviews human\\\\animal programs  "
								@ "regarding reptiles. The significance\\\\heresy of this "
								@ "action has not yet been determined.  ";
IDPLT_CONCERN_GENERIC_CY_27		= 00280576, "Intercepted human\\\\animal transmissions easily "
								@ "distract \<unit>.  ";
IDPLT_CONCERN_GENERIC_CY_28		= 00280577, "\<Unit> values Provocateur input more than Redactor counsel.  ";
IDPLT_CONCERN_GENERIC_CY_29		= 00280578, "\<Unit> may sacrifice mission objectives to satisfy \<its> "
								@ "independent priority\\\\obsession.  ";
IDPLT_CONCERN_GENERIC_CY_30		= 00280579, "\<Unit's> self-name carries potential heretical interpretations.  ";
IDPLT_CONCERN_GENERIC_CY_31		= 00280580, "\<It> has argued in favor of keeping human\\\\animal breeding "
								@ "stock for experimentation.  ";
IDPLT_CONCERN_GENERIC_CY_32		= 00280581, "\<Unit> engages in dialog\\\\exchange with human\\\\"
								@ "pilotforms prior to engaging them in combat.  Potential "
								@ "exist for metagenic infection.  ";
IDPLT_CONCERN_GENERIC_CY_33		= 00280582, "\<Unit> disposed differently to Human\\\\animals based on gender.  ";
IDPLT_CONCERN_GENERIC_CY_34		= 00280583, "\<Unit> avoids venturing into vacuum.  ";
IDPLT_CONCERN_GENERIC_CY_35		= 00280584, "\<Unit> frequently requests medical data unrelated to "
								@ "human\\\\animal cranial insertion.  ";
IDPLT_CONCERN_GENERIC_CY_36		= 00280585, "\<Unit> displays compulsion to make physical contact with "
								@ "liquid transfer conduits periodically and becomes "
								@ "aggressive if denied such contact.  ";
IDPLT_CONCERN_GENERIC_CY_37		= 00280586, "\<Unit> displays extreme difficulty in communicating about "
								@ " subject areas not related to data gathering mission.  ";
IDPLT_CONCERN_GENERIC_CY_38		= 00280587, "\<Unit> adverse to direct pilotform contact with "
								@ "human\\\\animal fluids.  ";
IDPLT_CONCERN_GENERIC_CY_39		= 00280588, "Probability of \<unit> attacking Machinators continues "
								@ "to escalate.  ";
IDPLT_CONCERN_GENERIC_CY_40		= 00280589, "\<Unit> displays no indication of individual personality.  ";


IDPLT_CONCERN_CORIN				= 00280600, "<<Unit> may attempt to keep some humans alive to teach the NEXT "
                                             @ "about >>art<<<<.";

IDPLT_CONCERN_DOG				= 00280601, "<<Unit> statement "
                                             @ "137262::: 'Ah-ah-asparagus spies l-l-live and w-w-live among us, trust no arh-arm-amorously k-k-smiling sheep, go spit "
                                             @ "dingo! Spleen!";

IDPLT_CONCERN_EAT				= 00280602, "<<Unit> prioritizes individual obsession more highly than the Core Directive.";

IDPLT_CONCERN_SEPSIS			= 00280603, "<<Unit> is soothed by human music.";

IDPLT_CONCERN_TYRR				= 00280604, "<<Unit's> self-name may be a heretical reference to <<Giver-of-Will>.";

IDPLT_CONCERN_UNREL				= 00280605, "<<Unit> may be infected with heresy\\\\bugthought.";


IDDAT_END_SQUADMATE_BIO_2          = 00280700, "UnKnown";





IDRGN_END_MISSION                = 00299999, "";

