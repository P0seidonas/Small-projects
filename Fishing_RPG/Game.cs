// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Fishing_RPG
{
    internal class Game
    {

        private static void Main(string[] args)
        {
            Game program = new(); //Creating new object
            program.MenuSelector(0);
            int selectedItem = program.MenuSelector(1); //method for getting an item from menu screen translated to a number
            //Console.WriteLine("                                                                                                                                                                                        \r\n                            ░░░░░░░░░░░░░░░░░░░░                                                                                                                                        \r\n                            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                          ░░    ░░                                                                                            \r\n                            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                                    \r\n                            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                              \r\n                          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                                  \r\n                          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                          \r\n                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                    \r\n                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                              \r\n                  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                        \r\n                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                  \r\n              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                              \r\n        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                            \r\n      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                          \r\n      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    \r\n    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              \r\n    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░          \r\n    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      \r\n  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    \r\n  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  \r\n  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      ██    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\r\n            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  \r\n              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      \r\n                  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░          \r\n                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                \r\n                      ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                \r\n                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                      \r\n                            ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                        \r\n                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                            \r\n                                        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                \r\n                                                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                                                \r\n                                                      ░░░░░░░░░░░░░░░░░░░░░░░░░░                ░░░░░░░░░░░░░░░░░░                                                                      \r\n                                                        ░░░░░░░░░░░░░░░░░░░░                                                                                                            \r\n");

            return;
            
        }

        private int MenuSelector(int Item)
        {
            bool gameEnd = false;
            string[] MenuItems;
            string? headerText;
            int currentItem = 0; //selected current

            switch (Item)
            {
                case 1:
                    MainText pondListprovider = new MainText();
                    MenuItems = pondListprovider.GetFishingPond();
                    headerText = "Choose a fishing pond: \n";
                    break;
                default:
                    MainText menuItemsProvider = new MainText();//Create Text class object to get menu items
                    MenuItems = menuItemsProvider.GetMenuText(); //Get menu items string
                    headerText = "Choose your next action: \n";
                    break;
            }

            while (!gameEnd)
            {
                Console.Clear(); // Clear the console
                
                MainText textFile = new(); //Create Text class object to get main title item
                textFile.GameName(); //Display game name

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(headerText); //Display header text

                for (int i = 0; i < MenuItems.Length; i++) // Print lines with or without highlighting based on the current line index
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    
                    if (i == currentItem)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue; //Highlight line color
                        Console.WriteLine($"    {MenuItems[i]}"); //Display menu text
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.WriteLine($"    {MenuItems[i]}");
                    }

                    if (i == MenuItems.Length - 1)
                    {
                        Console.WriteLine("\n\n");
                        MainText BottomImage = new MainText();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(BottomImage.GetBottomImages());
                        Console.ResetColor();
                    }
                    
                }

                // Capture arrow key input
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow && currentItem > 0)
                {
                    currentItem--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && currentItem < MenuItems.Length - 1)
                {
                    currentItem++;
                }
                Console.WriteLine("");
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (currentItem)
                    {
                        case 0:
                            MenuSelector(1);
                            break;
                        case 1:
                            Console.Clear();
                            FishingPonds();
                            break;
                        case 3:
                            DeleteSave();
                            break;
                        default:
                            break;
                    }
                }

                //Capture escape key input for end of the game
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    gameEnd = true;
                }
            }

            return -1; // Provides a default value to return if none of the conditions are met
        }

        private void FishingPonds()
        {
            //Method variables
            bool gameEnd = false, //bool for infinite loop for constant button monitoring
                cancelButton = false; //bool for canceling the console key
            int caughtFishID = 0; //fish caught by ID in list

            Console.Clear(); // Clear the console
            MainText textFile = new(); //Create Text class object to get main title item
            textFile.GameName(); //Display game nam

            List<Fish_DataBase> PondFishList = new List<Fish_DataBase>(); //list for saving fish information
            InitializingFish(PondFishList); //method for intializing fish parameters to class

            Console.WriteLine("         ,%&& %&& %\r\n       ,%&%& %&%& %&\r\n      %& %&% &%&% % &%\r\n     % &%% %&% &% %&%&,\r\n     &%&% %&%& %& &%& %\r\n    %%& %&%& %&%&% %&%%&\r\n    &%&% %&% % %& &% %%&\r\n    && %&% %&%& %&% %&%'\r\n     '%&% %&% %&&%&%%'%\r\n      % %& %& %&% &%%\r\n        `\\%%.'  /`%&'\r\n          |    |            /`-._           _\\\\/\r\n          |,   |_          /     `-._ ..--~`_\r\n          |;   |_`\\_      /  ,\\\\.~`  `-._ -  ^\r\n          |;:  |/^}__..-,@   .~`    ~    `o ~\r\n          |;:  |(____.-'     '.   ~   -    `    ~\r\n          |;:  |  \\ / `\\       //.  -    ^   ~\r\n          |;:  |\\ /' /\\_\\_        ~. _ ~   -   //-\r\n        \\\\/;:   \\'--' `---`           `\\\\//-\\\\///");
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Press Space to START FISHING: \n");

            Console.ForegroundColor = ConsoleColor.Yellow;



            while (!gameEnd)
            {
                cancelButton = false;
                // Capture space key input
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    caughtFishID = FishingAction(); //getting caught fish ID
                    Fish_DataBase firstFish = PondFishList[caughtFishID];
                    FishRarityColorOutput(firstFish.FishRarity);

                    Inventory.ReadData(firstFish);//Write fish data into txt file


                    Console.WriteLine($"\n You caught: {firstFish.FishSpecies}!");

                    Console.ForegroundColor = ConsoleColor.Yellow;


                    cancelButton = true;
                }

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    MenuSelector(1);
                }

            }

        }
        static void OpenInventory()
        {
            Console.Clear();
            Console.WriteLine("Inventory opened");
        }
        static void GoToUpgrades()
        {
            Console.Clear();
            Console.WriteLine("Upgrade your stuff");
        }
        static void GoToStore()
        {
            Console.Clear();
            Console.WriteLine("Sell your fish and buy BOOTS!");
        }
        static void DeleteSave()
        {
            Inventory.DeleteAllData();
            Console.Clear();
            for (int i = 0; i < 8; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("YOUR FISHES ARE GONE");
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            //Console.Clear();
        }

        static void InitializingFish(List<Fish_DataBase> PondFishList)
        {
            Fish_DataBase pondFish1 = new Fish_DataBase("BASS", 1.5f, 10.99f, "common");
            Fish_DataBase pondFish2 = new Fish_DataBase("BLUEGILL", 2.0f, 12.99f, "uncommon");
            Fish_DataBase pondFish3 = new Fish_DataBase("CARP", 1.8f, 9.49f, "rare");
            Fish_DataBase pondFish4 = new Fish_DataBase("PERCH", 1.8f, 9.49f, "epic");
            Fish_DataBase pondFish5 = new Fish_DataBase("PIKE", 1.8f, 9.49f, "legendary");

            PondFishList.Add(pondFish1);
            PondFishList.Add(pondFish2);
            PondFishList.Add(pondFish3);
            PondFishList.Add(pondFish4);
            PondFishList.Add(pondFish5);
        }

        static void SavingInstance(List<Fish_DataBase> FishData)
        {

        }

        static int FishingAction()
        {
            int CaughtFish;
            Dictionary<string, int> ConvertRarityToWeight = new Dictionary<string, int>
            {
                { "common", 100},
                { "uncommon", 62},
                { "rare", 31},
                { "epic", 12},
                { "legendary", 1}
            };

            Console.Write("Fishing");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }

            Random rnd = new Random();
            int getFish = rnd.Next(69, 70);
            //Console.WriteLine("SKAICUKAS: {0}", getFish);
            switch (getFish)
            {
                case int rarity when (rarity == 69):
                    CaughtFish = 4;
                    if (rarity == 69)
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            //KAdanors icookint vaivorykste :)

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("PYZDA SENIIIII!!!!!");
                            Thread.Sleep(100);
                        }

                    }
                    break;

                case int rarity when (rarity >= 1 && rarity < 11):
                    CaughtFish = 3;
                    break;

                case int rarity when (rarity >= 11 && rarity < 29):
                    CaughtFish = 2;
                    break;

                case int rarity when (rarity >= 29 && rarity < 60):
                    CaughtFish = 1;
                    break;

                case int rarity when (rarity >= 60 && rarity != 69 && rarity < 104):
                    
                    CaughtFish = 0;
                    break;

                default:
                    CaughtFish = -1;
                    Console.WriteLine("DINGO ZUVIS");
                    break;
            }


            return CaughtFish;
        }

        static void FishRarityColorOutput(string rarity)
        {
            Dictionary<string, ConsoleColor> ConvertRarityToColor = new Dictionary<string, ConsoleColor>
            {
                { "common", ConsoleColor.DarkGray },
                { "uncommon", ConsoleColor.DarkGreen},
                { "rare", ConsoleColor.Cyan},
                { "epic", ConsoleColor.Red},
                { "legendary", ConsoleColor.Magenta}
            };

            

            Console.ForegroundColor = ConvertRarityToColor[rarity];
            return;
        }

    }
}