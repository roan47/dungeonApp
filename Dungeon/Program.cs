using DungeonLibrary;




namespace Dungeon
{
    class Program
    {
       
            

       


        static void Main(string[] args)
        {


          


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

          

           

            #region Possible Expansion - Character Creation/Customization
           

            Console.WriteLine("Choose your character:\nA) Ren/Fool\nB) Morgana/Magician\nC) Ryujii/Chariot\nD) Yusuke/Emperor\nE) Makoto/Priestess\nF) Akechi/Justice\nG) Yoshizawa/Faith\nH) Haru/Empress\n");
            
            string userRaceChoice = Console.ReadLine().ToUpper();
            
            String userName = Console.ReadLine().ToUpper();

            






            Race playerRace = new Race();
            WeaponType persona = new WeaponType();

           switch (userRaceChoice)
               
            {
                case "A":
                    playerRace = Race.Ren;

                    userName = "Ren";

                    persona = WeaponType.Fool;

                    break;

                case "B":
                    playerRace = Race.Morgana;
                    userName = "Morgana";
                    persona = WeaponType.Magician;






                    break;
                case "C":
                    playerRace = Race.Ryujii;
                    userName = "Rujii";
                    persona = WeaponType.Chariot;


                    break;
                case "D":
                    playerRace = Race.Yusuke;
                    userName = "Yusuke";
                    persona = WeaponType.Emperor;
                    break;
                case "E":
                    playerRace = Race.Makoto;
                    userName = "Makoto";
                    persona = WeaponType.Priestess;



                    break;
                case "F":
                    playerRace = Race.Akechi;
                    userName = "Akechi";
                    persona = WeaponType.Justice;

                    break;

                case "H":
                    playerRace = Race.Yoshizawa;
                    userName = "Yoshizawa";
                    persona = WeaponType.Faith;

                    break;
                case "I":
                    playerRace = Race.Haru;
                    userName = "Haru";
                    persona = WeaponType.Empress;

                    break;
                default:
                    break;

            }


            Weapon equippedPersona = new Weapon(1, 8, "Persona", 10, false, persona);





            Player player = new Player(userName, 70, 5, 40, 40, playerRace,equippedPersona);












            #endregion



            #region Main Game Loop

            
            bool exit = false;

                    do
                    {
                        //TODO Generate a random room
                        Console.WriteLine(GetRoom());

                        //TODO Select a Monster (at random) for the player to encounter
                        #region Monster Objects

                        Jackfrost jackfrost = new Jackfrost("JackFrost", 25, 25, 50, 20, 2, 8,
                           "The tempature drops quickly, a chilling site!", true);



                        Cerberus cerberus = new Cerberus("Cerberus", 25, 30, 70, 8, 1, 8, "The  ancient guard dog of hades.");

                        Genbu genbu = new Genbu("Genbu", 17, 25, 50, 10, 1, 4,
                            "The black warrior, half turle half snake.", 3, 10);

                        Satan satan = new Satan("Satan", 10, 20, 65, 20, 1, 15, "Then angel of Judgment.", true);



                        #endregion

                        #region Monster Selection

                        //Add the monsters to a collection
                        Monster[] monsters = { jackfrost, genbu, cerberus, satan };

                        //Pick one at random to place in the room
                        Random rand = new Random();
                        int randomNbr = rand.Next(monsters.Length);
                        Monster monster = monsters[randomNbr];

                        //Output
                        Console.WriteLine("\nThe Creature shows itself: " + monster.Name);

                        #endregion

                        #region Gameplay Menu Loop

                        //Bool (counter) for the gameplay loop
                        bool reload = false;

                        //Create the gameplay loop
                        do
                        {
                            //Create the gameplay menu
                            #region Gameplay Menu

                            //Prompt the user
                            Console.Write("\nPlease choose an action:\n" +
                                "A) Attack\n" +
                                "R) Run away\n" +
                                "P) Player info\n" +
                                "M) Shadow info\n" +
                                "X) Exit\n");


                            //Capture the user's menu selection
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

                            //Check the Player's life
                            if (player.Life <= 0)
                            {
                                Console.WriteLine("You have been defeated by {0}!", monster.Name);

                                //Flip the exit bool to end the game
                                exit = true;
                            }


                        } while (!exit && !reload); //Condition - while exit AND reload are NOT true, keep looping

                        #endregion


                    } while (!exit); //Condition for loop - While exit is NOT true, keep looping

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

    }//end class

}//end Namespace
