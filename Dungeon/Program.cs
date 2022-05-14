using DungeonLibrary;




namespace Dungeon
{
    class Program
    {






        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FULL SCREEN");




            #region Title / Introduction



            Console.Title = "Ro's Palace";





            Console.ReadKey();
            Console.WriteLine(@"                                            
                                          *#%%%@@@@@@@@@@@@@@@@@@@%
                                       #%%@@@@@@@@@@@@@@@@@@@@@@@@%
                                  #%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
                               %%@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@%
                           *%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@
                        ##@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@
                      #%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                   #%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                  %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                 #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                    %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
                   #@@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
                  *#@@ @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@% 
                  *#@@ #@@#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%
                    %# #@@   %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                       @@@     %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#
                       @@@%      %@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%* 
                       %@@        #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#@@@@%   #@@@
                                  #@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##@@@@%+#@@@@@ 
                                   @@@@@@@@@@@@@@@@@@@@@@@@@@    *%@@@@@@@@@@@@%  @@@
                                   @@@@@@@@@@@@@@@@@@@@@@@@    *%@@@@@@@@@@@@@@ #@@@@@
                                   #@@@@@@@@@@@@@@@@@@@@@@@    %@@@@#%@@@@@@@%  @@@@@@
                                   @@@@@@@@@@@@@@@@@@%%@@%#   @@@%*++%@@@%#   %@@@@@@
                                   #@@@@@@@@@@@@@@@@%*+@@@@@   @@@#           #@@@@@@@
                                 @@@@@@@@@@@@@@@@@@@%+++%@@%*   *%**##%%#*****%@@@@@@@@
                              @@@@@@@@@@@@@@@@@@@@@@              %@@@@@@@@@@@@@@@@@@@
                         @@@@@@@@@@@@@@@@@@@@@@@@@@%           ##%%@@@@@@@@@@@@@%
                        @@%@@@@@@@@@@@@@@@@@@@@@@@#          @@@@@@@@@@@@@@%##%@
                       #@@@@@@@@@@@@@@@@@@@@@@@@@@*####*      *@@@@@@@%  
                        %@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@#**#@%@@@@@@@@#
                         %%*%%%@@@@@@@@@@@@@@@@@@@%%@@@@@@@@@@@@@@@@@%%
                       *#@%#      #%@%#    %@@@@#   ###%@@@@@@@@@@@%@%
                       #@#        *#@@%    %@@#        #%%@@@@@%**@%
                        %%           #@@@@@@%               #%**@##
                                        %@#                   #**%%#  
                                 
_   %%%@@@@# @@%   @  @@         %@@@  @@@#              @@#@@%     %%  %#             @%#@@@ @@@@@@@%
__@@@@@@@@@% @@@   @  @  %@%%%%#  #@@@@@@ *#####@ @@@ @@ @@  @@     @*  @@ @@@%* ##*+@ #   @%   @@@
**#%@@@@@%  @@@@#  @@@@ %@@        #@@@@  @@  @@@ @@# *%  @%@@      @*  @@ @    %%  %# @@@**    @@@
      #@@% #@@_@@  @@@@  @@*#+@      @@@  @@  @@% %@# %#  @@ @#     @*#%## @@%# ##@@@@ @%@@     @@@
      %@@% @@@%@@# @@#@@  @          @@@ #@@%@@%# +%% %#  @@ %@#    @*  #* @    @#  #  @*#@@#   @@@
      %@@  @@___@@ @@__@@  @@@@#     @@@          @@@@@%  #%  %#    %#  #% *%%% #   % @@   @@   @@@");
            Console.ReadKey();




            Console.WriteLine("This is Truly a Unjust Game, Your chances of winning are almost none");


            Console.ReadKey();
            Console.Clear();


            #endregion

            //TODO Create a variable to track the score
            int score = 0;



            bool restart = false;

            #region Possible Expansion - Character Creation/Customization



            Console.WriteLine("Choose your character:\nA) Ren/Fool\nB) Morgana/Magician\nC) Ryujii/Chariot\nD) Yusuke/Emperor\nE) Makoto/Priestess\nF) Akechi/Justice\nG) Yoshizawa/Faith\nH) Haru/Empress\n");


            ConsoleKey userRaceChoice = Console.ReadKey(true).Key;
            String userName = Console.ReadLine().ToUpper();







            Console.Clear();


            Race playerRace = new Race();
            WeaponType persona = new WeaponType();

            switch (userRaceChoice)

            {
                case ConsoleKey.A:
                    playerRace = Race.Ren;

                    userName = "Ren";

                    persona = WeaponType.Fool;
                    restart = true;

                    break;

                case ConsoleKey.B:
                    playerRace = Race.Morgana;
                    userName = "Morgana";
                    persona = WeaponType.Magician;
                    restart = true;






                    break;
                case ConsoleKey.C:
                    playerRace = Race.Ryujii;
                    userName = "Rujii";
                    persona = WeaponType.Chariot;
                    restart = true;


                    break;
                case ConsoleKey.D:
                    playerRace = Race.Yusuke;
                    userName = "Yusuke";
                    persona = WeaponType.Emperor;
                    restart = true;
                    break;
                case ConsoleKey.E:
                    playerRace = Race.Makoto;
                    userName = "Makoto";
                    persona = WeaponType.Priestess;
                    restart = true;



                    break;
                case ConsoleKey.F:
                    playerRace = Race.Akechi;
                    userName = "Akechi";
                    persona = WeaponType.Justice;
                    restart = true;

                    break;

                case ConsoleKey.G:
                    playerRace = Race.Yoshizawa;
                    userName = "Yoshizawa";
                    persona = WeaponType.Faith;
                    restart = true;

                    break;
                case ConsoleKey.H:
                    playerRace = Race.Haru;
                    userName = "Haru";
                    persona = WeaponType.Empress;
                    restart = true;

                    break;
                default:
                    break;

            }






            Weapon equippedPersona = new Weapon(1, 8, "Persona", 10, false, persona);





            Player player = new Player(userName, 70, 5, 40, 40, playerRace, equippedPersona);












            #endregion



            #region Main Game Loop


            bool exit = false;

            do
            {
                //TODO Generate a random room
                Console.WriteLine(GetRoom());

                //TODO Select a Monster (at random) for the player to encounter
                #region Monster Objects

                Jackfrost jackfrost = new Jackfrost(@"JackFrost
                   ▓▓▓▓▌▀▓▓▓▓▓▓▓▓▓▓▓▄   ,▄▓▓▓▓▓▓▓▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓,
░░  ░   ░  ░▓▓▄ç  ░▐▓▓▓▌ ╙▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒░▒▄▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▄,░  ░   ░
  ░   ░  ░   ▓▓▓▓▓▄▄▓▓▓▌░  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▀▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░   ░
              ▓▓░▀▓▓▓▓▓U    ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▄
           ▄, └▓▌  `▀▓▓       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▀▀▀ `          ╙▓▓▓▓▓▓▓▓▄
  ░   ░  ░  ▀▓▄▄▓░  ░   ░  ░ ▄▓▓▓▓▓▓▓▓▓▓▓▓▓▓▀▀                      ▀▓▓▓▓▓▓▓W░
░░  ░   ░  ░   ╙▀ ░   ░  ░  ▐▓▓▓▓▓▓▓▓▓▓▀▀`           ▄███▄            `▓▓▓▓▓▓  ░
                           ]▓▓▓▓▓▓▓▓▀`   ▄██▄        █████▄             ▓▓▓▓▌
                           ▓▓▓▓▓▓▓m     ▐█████       ██████               ▀▓▓▓▄
░░  ░   ░  ░   ░  ░   ░  ░]▓▓▓▓▓▓       ▐██████      ▀█████                ▐▓▓▓▓
  ░   ░  ░   ░ .    ░   ░ ▐▓▓▓▓▓         ██████       ▀███▀                 ▀▓▓▓
            . '    `      ▓▓▓▓▓▓         ╙█████               ,,▄▄▄▄         '▀▀
             `░          \╟▓▓▓▓▌           ▀▀▀      ,▄▄▄  █████████
  ░   ░       ░`    ░░    ▐▓▓▓▓                ▐█████████▄████████
                           ▓▓▓▓         ▄▄████▄█████████████████▀         Æ`
           .               ▓▓▓▓      '███████████████████████▀          ╓▓▌
                           ▄▓▓▓µ       `▀████████████████▀▀-          ▄▓▓▓▓═
                          ╙▓▓▓▓M          -▀▀▀▀▀▀▀▀▀▀`             ╓▄▓▓▓▓▓▓▓
  ░   ░  ░ `                                                    ,▄▓▓▓▓▓▓▀▓▓▓▓▓
░   ░   ░  ░░                      `                       ,▄▄▓▓▓▓▓▓▓▓▓▓  ", 25, 25, 50, 20, 2, 8, "The tempature drops quickly, a chilling site!", true);



                Cerberus cerberus = new Cerberus(@"Cerberus

       ,▄▀▀▀▀██▄                                          ╖╢╢╢@╢╫@m  ▒h,
      ╓▀-      `██                                     r  ╓@╩╨╜╜╜▒.   ─╣╢▓W
                ▐▓▌           ,╖g▄▄▓▓▓▓@µ▄╓          ,╢▒@╣╩╜╨ ╨╨╜░╥@@m╖▒╫▓╫▓▓
               ,▓▓         ╥▓▓▓▓▓▓▓▓▓▓▀  - '`▀▓N▄,,  `²╜▒░    ▒▒╫,æ▓▓▒▒ ,║╣╫▓╣╢r
            ▄▄▓▓▀         ▓▓▓▓▀   ,╖  ,╓╖╖,,,    ``         ░▒╥▓▓▓▓▓▓▓▓▒╢╣╢╣▒
      ,▄▓▓▓▓▀▀`        g▓▓▓▀     ]▒▒░ ░░▒▒▓▓╣▒▒▒░░░▒╥@@@▓▓░   ║╣▓░╢▓▓▓╢▓Ñ░║▒╣
    ▄█▓▀              φ▓▓▓       ╣▒▒   ░▒╫▓╣╣╣▒░░   ░▒▒▒╢▒░,╓╢╢╢▓g╣▓▓║▒║`╙▒▓
   ▓▓▀               Æ▓▓▓       ╓░▒▒   ░╫╢▓╣╣╣╢╣▒.,  ░▒╣░▒▒╢▒╢╣▓▓╢╣▒╢╣@,╙▓╨▓
  ]▓▓               g▓▓▌       ║╜ ░░  ╓╢╢▓▓▓▓▓▓▓▓╣╢▒▒▒╢╢▒░▒░╟╢▓▓╣▓╦H▒▒╢╣░ µì
   ▓▓              Æ▓▓▌      ¿▒'   ,╓╢╢╫▓▓▓▓▓╜  ╙▓╣▓╣▓╜ ,╢▒▓╫▓╫▓▓▓▓▓▓▓█╢╜`'
   ╘▓▓Φ╖        ╓@▓▓█╜     ─` ,▒▒▒╢╢▒▓▓▓▓▓▓╜       ▓╣▓,j╫╣╣╣▓╣▓╫▓▓▀
      ╩▓▓▓▓▓▓▓▓▓▓▓▀        ╓▒╥@╜`  ▓▓▓▓▓╜           ╙╣▒ ╟╢▓▓▓
           ``           ¿░╢╢▓      ║▒▓▓▌              ░ ]▒╣╣
                         ║╣Ñ        ╢▒╢▌             ,╣░▒▒╢▓
                       ,╓╣▓         ╙░╟▓             ]▓▓▒▒╫
                        ╢╙▒╔,         ▓▓▓@▓w           ╚▓▒╣╜.
                                                          *╩╝╩"
,                                                          25, 30, 70, 8, 1, 8, "The  ancient guard dog of hades.");

                Genbu genbu = new Genbu(@"Genbu           
                                       ╓▄███▓█▓▓▓█▓█▓▓▓▓█▄,   
                                    ,▄████████████▓▓████████▄          
                                  ╓█████████▓█████████████████╖▓█▓▓             
                                ╓▓█████████████████████████████▓▓█▌             
        ,╓╖╖╖,,            ,▄████▓█▓████▓▓▓███████▓█████▓████████▓▌             
 ▓▓▓@@▓╣▓▓▓▓▓▓▓▒╢╫╣@@╗╖╖╓,╓██████▓██▓▓▓▓▓▓▓██▓█████████████████████▓,           
  ▀▓▓▓▓▓▓▓▓▓▓▓▓╢▓▓▓╢╢╣╢╣╣╣╫╢▓▓▓▓▓▓▓▓▓▓█▓█▓███▓███████████████████▓███▓          
   ,,╣▓▓██▓▓▓▓▓▓╣╫╣╢╢▒▓╣╢╢╢╣▓╢▓▓▓▓▓▓▓▓▓▓▓▓████▓▓█████████████████████▓▌         
  ╙▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓█▓██▓██▓▓██████████▀          
                    ╙╙╙╜▀▀▀▀▀▀▀▓▓▓█████▀`  ╙▀▓██▓▓▓▓▓▓╙'╙▀▀▀███▓█▓╙             
                              ,╓,╓▓▓▓█        ▓█▓▓▓▓▓      '▀██▓▓▓▓╗╖          
                              ╙╨╣╫▀▀▀          ▐█▓▓▓▓▓         ╙▀▀▀╨╩▓╝         
                                               ▓▓▓▓▓▓                        
                                              ╟▓▓▓▓▓`                           
                                             ╜╜╙╜╙╙╙╙"
, 17, 25, 50, 10, 1, 4, "The black warrior, half turle half snake.", 3, 10);

                Satan satan = new Satan(@"Satan
                                           ,,,,,╓╓╥g@▓▓▓▓N∞,⌐─
                                 / ⌐   ╓m▒▒▒▒▒░▄█▓▓▓█▀,«^`
             ,    ,╣ ╓╖N]╗╗    ╓╬²   ╔▓▒▒▒▒▄██████▀*
             ╙▒▒╥@▒▒▒▒▒╫▓▀`  ╥▒▒M ,╦╣╢▒▒▒███▓▓▓▓▓▓▓w                ,
             ,▓m▒▒▒╠╫▓▓▌µ  ╗▒╢▒╥@▓╢╢▒▓████▓▓▓▓▓▓▓▓@╦╦╦╥╖╖╖╓ ,w═ⁿ
            ▄▓▓▓▒▒▓▓▓▀▒╟╦@╢╫▓▓╣╣╢▓▓█▀▀██▓▓╢▓▓╣▒▄█████▀▓▒▒▓▓▓&,
           ▓▓▒╣╟▓▓╫╣▓▓@▓▓▓╣╢▓▓▓██▄█▄█▓▓▓╢▒▄██▓██▓████▀
            ╣▒▓▓▓▓▌╣▓▓▓▓█████▓▓▓▓▓▓▓▓▓▓▒▓█████▓▓▓▓▓▓▓µ
            ▓▓╣▓▓▓▒╣▒▒╫██▓▓▓▓▓▓▓▀,J█▄▄▄████▓╣▓▓▓▓▓▓▓▓▓▓▓▓Φg╗,   ╛
         ,,,,▄▓▓▓▓▓▓▓▓▓▓▓███████▓▓▓▓▓▓▓▓▓▓▓╢▓▓▓▓▓▓▓▓▓▓▓▀▀▀▀█▓▓╗√
 ╙▐▓▓▓▀╙▀▀▀▀▀╣▓╫▓╣▓▓▓▓▓▓▓▓▓╢╣▓▓▓▓▓▓ ╓▓▓▓█▓▓▓████▓▓▓▓▄
               ▄▓▓▀▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓@▒▒▓███▀█▀▀▀█████▓▓▄            ,╓,
        ,▓▓▓@▓▀▀▀   ╙▓▓▓▓▓▓▓▓▓▓▓`▓▓▓▓▓╢▓╣▀       `▓███▓█,,       ▄▓▀▀▀▀█▄
          ═╜       ▓▓╢▓▓╢╫█▓███▓▓▓▓▓██╣▓[   ╔▓▓▓,   █▓▓▓█        ██,    ▀█▄
                      ▓▓▓╣╫╢▓█▓██▓▓▓▓█^ ╣▓▌   ▓▓▓▓▓    ▀▓▓▓█       ▀▓▓▄     '▀▀
                    ╔▓▓▓▓╚▐█▓▓███▓▓▓▓   ╣▓▌    ▓╢▓▓   ,ó▒█▓██       ▐▓█
                   ╒▓▓▀▓▌  █▓█▓█▓▓▓▓    ╣╫▌  ,╗╫╣▓▓╢╢Ñ╨  █▓█▓▄      ▓▓
                  ╓▓▌  ▐▓   ▀███▓▓▓     ╚▓▓▓╢▒╬╝          ▀▓▓▓█▓▄▄▄█▓▌
               ,╓φ▓▓▄▄&█▓▌      '▀        ``                ▀▀█▓▓▓█▀▀ "
, 10, 20, 65, 20, 1, 15, "Then angel of Judgment.", true);



                #endregion

                #region Monster Selection

               
                Monster[] monsters = { jackfrost, genbu, cerberus, satan };

    
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                //Output
                Console.WriteLine("\nThe Creature shows itself: " + monster.Name);

                #endregion

                #region Gameplay Menu Loop

                //Bool (counter) for the gameplay loop
                bool reload = false;

              
                do
                {
                    
                    #region Gameplay Menu

                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player info\n" +
                        "M) Shadow info\n" +
                        "X) Exit\n");


                  
                    ConsoleKey userChoice = Console.ReadKey(true).Key; //Executes on key press

                    //Clear the console
                    Console.Clear();

                    //Use branching logic to execute code based on user's menu selection
                    switch (userChoice)
                    {

                        case ConsoleKey.A:
                            //TODO Combat
                            Combat.DoBattle(player, monster);

                            //Check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                //Use green text to highlight winning combat
                                Console.ForegroundColor = ConsoleColor.Green;

                                //Output the result
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);

                                //Reset the color
                                Console.ResetColor();

                                //Update the score
                                score++;

                                //Flip the reload bool to exit the current menu
                                //loop so we can get a new room & monster
                                reload = true;
                            }

                            break;

                        case ConsoleKey.R:
                            //TODO Run away
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);

                            //Formatting
                            Console.WriteLine();

                            //Flip the reload bool to exit the current menu
                            //and get a new room & monster
                            reload = true;

                            break;

                        case ConsoleKey.P:
                            //TODO Player info
                            Console.WriteLine(player);
                            Console.WriteLine("Shadow defeated: " + score);
                            break;

                        case ConsoleKey.M:
                            //TODO Monster info
                            Console.WriteLine(monster);
                            break;

                        //Allows the user to exit if they hit X OR E
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("Had Enough Prisoner?");

                            //Flip the bool to break from the loop
                            exit = true;
                            break;

                        default:

                            Console.WriteLine("Are you done here?");

                            break;
                    }

                    #endregion

                  
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("You have been defeated by {0}!", monster.Name);

                      
                        exit = true;
                    }
                    

                } while (!exit && !reload); 
                #endregion


            } while (!exit); 

            #endregion

            //Output the final score
            Console.WriteLine("You defeated " + score + " shadow" +
                ((score == 1) ? "." : "s."));




        }//end Main()

        #region GetRoom()

        private static string GetRoom()
        {
            //Create a collection of "rooms"
            string[] rooms =
            {
                "A Shadow rushes you from the side, its presense feels familiar.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine... the dreaded DMV",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair metal music blaring.... This is going to be bad!",
                "The room looks just like the room you are sitting in right now... or does it?",
            };

            //Create a Random object
            Random rand = new Random();

            //Use the Random object's Next() to generate a number based on the length of the array
            int indexNbr = rand.Next(rooms.Length);

            //Create a variable to store the chosen "room"
            string room = rooms[indexNbr];

            //Return the chosen "room" to be displayed in a Console.WriteLine() in the Main()
            return room;
        }

        #endregion

    } //end class

}//end Namespace
