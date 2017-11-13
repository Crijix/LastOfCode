using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hej med dig!

// TODO Make a SNEW Map with diffirent enemies in each (Stronger enemies)
// TODO Make a better Win/Dead screen
// TODO Replace while(true) loop with Try_Catch
// TODO DRY on kill screen

namespace LastOfCode
{
    class Program
    {
        static void Main(string[] args) {

            Intro();
            string map = Console.ReadLine().ToLower().Trim();
            while (true) {

                if (map == "north") {

                    NorthMap newMap = new NorthMap();
                    newMap.North();
                    break;

                } else if (map == "south") {

                    SouthMap newMap = new SouthMap();
                    newMap.Alpha();
                    break;
                    
                } else if (map == "east") {

                    EastMap newMap = new EastMap();
                    newMap.Beta();
                    break;

                } else if (map == "west") {

                    WestMap newMap = new WestMap();
                    newMap.Charlie();
                    break;

                } else {

                    Console.Write("\nPlease just choose one of the maps listed: ");
                    map = Console.ReadLine().ToLower().Trim();
                }
            }
            Console.ReadKey();
        } // End of Main

        // Entry Application
        static void Intro() {

            var arr = new[]
                {
                    @" __          ___           _______.___________.     ______    _______      ______   ______    _______   _______ ",
                    @"|  |        /   \         /       |           |    /  __  \  |   ____|    /      | /  __  \  |       \ |   ____|",
                    @"|  |       /  ^  \       |   (----`---|  |----`   |  |  |  | |  |__      |  ,----'|  |  |  | |  .--.  ||  |__   ",
                    @"|  |      /  /_\  \       \   \       |  |        |  |  |  | |   __|     |  |     |  |  |  | |  |  |  ||   __|  ",
                    @"|  `----./  _____  \  .----)   |      |  |        |  `--'  | |  |        |  `----.|  `--'  | |  '--'  ||  |____ ",
                    @"|_______/__/     \__\ |_______/       |__|         \______/  |__|         \______| \______/  |_______/ |_______|",
                };

            Console.WindowWidth = 115;
            foreach (string line in arr)
            Console.WriteLine(line);
            Console.WriteLine();

            Console.WriteLine("Hello there adventurer, and welcome to Last of Code!");
            Console.Write("May I please get your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("\nWell {0}, please enjoy your stay!!\n", input);

            Console.Write("Which map do you wish to enter ");
            Console.WriteLine("(North, South, East or West)");
            Console.Write("Your destiny: ");
        }

    } // End of Main

    /**********************\
    *                      *
    *                      *
    *     ATTACK MOVES     *
    *                      *
    *                      *
    \**********************/

    class Moves
    {
        // VARIABLES

        // Moves
        public int attack;
        public int heavy;
        public int defence;

        // Heatlh
        // TODO Make playerHealth not go above 100
        public static int playerHealth = 100;
        public static int botHealth = 100;

        // Attack Generator
        public void MoveRNG() {

            Random rng = new Random();
            attack = rng.Next(10, 30);
            heavy = rng.Next(20, 40);
            defence = rng.Next(1, 20);
        }
    } // End of Moves

    /**********************\
    *                      *
    *                      *
    *    PLAYER MOVEMENT   *
    *                      *
    *                      *
    \**********************/

    class Player
    {
        public void PlayerGame() {

                // Player
                Console.Write("\nChoose a move (Attack/Heavy/Defence/Inventory): ");
                string input = Console.ReadLine().ToLower().Trim();

            // TODO Try_Catch
            while (true) {
                if (input == "attack") {

                    Moves move = new Moves();
                    move.MoveRNG();

                    Console.WriteLine("Your move: Attack");
                    Moves.botHealth -= move.attack;
                    Console.WriteLine("\n================ KILL SCREEN ================");
                    Console.WriteLine("\nYou did {0} damage to the enemy", move.attack);
                    Console.WriteLine("The enemy's health remaining: {0}", Moves.botHealth);
                    break;

                } else if (input == "heavy") {

                    Moves move = new Moves();
                    move.MoveRNG();

                    Console.WriteLine("Your move: Heavy");
                    Moves.botHealth -= move.heavy;
                    Console.WriteLine("\n================ KILL SCREEN ================");
                    Console.WriteLine("\nYou did {0} damage to the enemy", move.heavy);
                    Console.WriteLine("The enemy's health remaining: {0}", Moves.botHealth);
                    break;

                } else if (input == "defence") {

                    Moves move = new Moves();
                    move.MoveRNG();

                    Console.WriteLine("Your move: Defence");
                    Moves.botHealth -= move.defence;
                    Console.WriteLine("\n================ KILL SCREEN ================");
                    Console.WriteLine("\nYou did {0} damage to the enemy", move.defence);
                    Console.WriteLine("The enemy's health remaining: {0}", Moves.botHealth);
                    break;

                } else if (input == "inventory") {

                    Food newFood = new Food();
                    newFood.Inventory();
                    break;

                } else {

                    Console.WriteLine("Please enter one of the moves listed!");
                    Console.Write("\nChoose an move (Attack/Heavy/Defence/Inventory): ");
                    input = Console.ReadLine().ToLower().Trim();
                }
            }
        }
    } // End of Player

    /**********************\
    *                      *
    *                      *
    *     AI MOVEMENT      *
    *                      *
    *                      *
    \**********************/

    class AI
    {
        public void AIGame() {

            Random botRNG = new Random();
            int botPick = botRNG.Next(1, 4);

            Moves move = new Moves {
                attack = 1,
                heavy = 2,
                defence = 3
            };

            if (botPick == 1) {

                move.MoveRNG();
                Console.Write("\nThe enemy's move: Attack");
                Console.WriteLine();
                Console.WriteLine("The enemy did {0} damage to you!", move.attack);
                Moves.playerHealth -= move.attack;
                Console.Write("Your remaining health: {0}", Moves.playerHealth);
                Console.WriteLine("\n=============================================\n");

            } else if (botPick == 2) {

                move.MoveRNG();
                Console.Write("\nThe enemy's move: Heavy");
                Console.WriteLine();
                Console.WriteLine("The enemy did {0} damage to you!", move.heavy);
                Moves.playerHealth -= move.heavy;
                Console.Write("Your remaining health: {0}", Moves.playerHealth);
                Console.WriteLine("\n=============================================\n");

            } else if (botPick == 3) {

                move.MoveRNG();
                Console.Write("\nThe enemy's move: Defence");
                Console.WriteLine();
                Console.WriteLine("The enemy did {0} damage to you!", move.defence);
                Moves.playerHealth -= move.defence;
                Console.Write("Your remaining health: {0}", Moves.playerHealth);
                Console.WriteLine("\n\n=============================================\n");
            }
            Console.WriteLine();
        }
    } // End of AI

    /**********************\
    *                      *
    *                      *
    *       BACKPACK       *
    *                      *
    *                      *
    \**********************/

    class Bag
    {
        // CLASS VARIABLES
        public int bread;
        public int water;
        public int cookie;

        public void FoodBag() {

            // Value of Items
            bread = 20;
            water = 10;
            cookie = 15;

        }
    } // End of Bagpack

    /**********************\
    *                      *
    *                      *
    *      INVENTORY       *
    *                      *
    *                      *
    \**********************/

    class Food
    {
        // Inventory Screen
        public void Inventory() {

            // TODO Continue the game when the player eats
            Bag newBag = new Bag();
            Moves move = new Moves();
            newBag.FoodBag();

            // TODO Have only certain amout of items on player
            string[] items = { "Bread", "Water", "Cookie" };
            Console.WriteLine("\nYour Inventory: ");
            Console.WriteLine(" - {0} (Gives you {1} health back.)", items[0], newBag.bread);
            Console.WriteLine(" - {0} (Gives you {1} health back.)", items[1], newBag.water);
            Console.WriteLine(" - {0} (Gives you {1} health back.)", items[2], newBag.cookie);
            Console.WriteLine();
            Console.WriteLine("Please enter the item you wish to take, or type Exit");
            Console.Write("Item: ");
            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "bread") {

                Moves.playerHealth += newBag.bread;

            }
            else if (userInput == "water") {

                Moves.playerHealth += newBag.water;

            }
            else if (userInput == "cookie") {

                Moves.playerHealth += newBag.cookie;

            }
            else {

                // TODO break out of the loop and back to the game

            }

            // FIX: Prints out no matter what
            Console.WriteLine("You have used {0} and your health have been restored to {1}", userInput, Moves.playerHealth);

        } // End of Food
    }

    /**********************\
    *                      *
    *                      *
    *      End Screen      *
    *                      *
    *                      *
    \**********************/

    class EndScreen
    {
        public void Lose() {

            var loseArr = new[] {

                    @"██╗   ██╗ ██████╗ ██╗   ██╗    ██████╗ ██╗███████╗██████╗ ██╗",
                    @"╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔══██╗██║██╔════╝██╔══██╗██║",
                    @" ╚████╔╝ ██║   ██║██║   ██║    ██║  ██║██║█████╗  ██║  ██║██║",
                    @"  ╚██╔╝  ██║   ██║██║   ██║    ██║  ██║██║██╔══╝  ██║  ██║╚═╝",
                    @"   ██║   ╚██████╔╝╚██████╔╝    ██████╔╝██║███████╗██████╔╝██╗",
                    @"   ╚═╝    ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝╚══════╝╚═════╝ ╚═╝",
                };
            Console.WindowWidth = 115;
            foreach (string printLine in loseArr)
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + printLine.Length / 2) + "}", printLine);

        }

        public void Win() {

            var winArr = new[] {

                    @"██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗██╗",
                    @"╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║██║",
                    @" ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║██║",
                    @"  ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║╚═╝",
                    @"   ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║██╗",
                    @"   ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝",
                };
            Console.WindowWidth = 115;
            foreach (string printLine in winArr)
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + printLine.Length / 2) + "}", printLine);

        }
    } // End of Screen

    /**********************\
    *                      *
    *                      *
    *      NORTH MAP       *
    *                      *
    *                      *
    \**********************/

    class NorthMap
    {
        public void North() {

            // Encounter
            Console.WriteLine("\nYou walk into a forrest and see a monster!");
            Console.WriteLine("The monster you encounter is a wolf");
            Console.WriteLine("It's trying to attack you!\n");

            // Player Movement
            Player playerPick = new Player();
            playerPick.PlayerGame();

            // AI Movement
            AI aiPick = new AI();
            aiPick.AIGame();

            EndScreen screen = new EndScreen();

            // Next Turn
            Console.WriteLine("\nWhat will you do next!? (Inventory/Next Turn)");
            Console.Write("Your move: ");
            string nextTurn = Console.ReadLine().ToLower().Trim();
            while (true) {
                if (nextTurn == "inventory") {

                    Food newFood = new Food();
                    newFood.Inventory();
                    nextTurn = "next";

                }
                if (nextTurn == "next" || nextTurn == "next turn") {

                    while (Moves.playerHealth > 0) {
                        playerPick.PlayerGame();
                        aiPick.AIGame();

                        if (Moves.botHealth <= 0) {

                            Console.Clear();
                            screen.Win();
                            break;

                        } else if (Moves.playerHealth <= 0) {

                            Console.Clear();
                            screen.Lose();
                            break;
                        }
                    }

                } else {

                    Console.WriteLine("\nInvaild command. Please enter one of the listed!");
                    Console.Write("Your move: ");
                    nextTurn = Console.ReadLine().ToLower().Trim();

                }
                break;
            }

        }
    } // End of North

    /**********************\
    *                      *
    *                      *
    *      SOUTH MAP       *
    *                      *
    *                      *
    \**********************/

    class SouthMap
    {
        public void Alpha() {

            Development newDevelop = new Development();
            newDevelop.Develop();

        }
        // TODO Complete the map duh
    } // End of South

    /**********************\
    *                      *
    *                      *
    *       East Map       *
    *                      *
    *                      *
    \**********************/

    class EastMap
    {
        public void Beta() {

            Development newDevelop = new Development();
            newDevelop.Develop();

        }
    } // End of East

    /**********************\
    *                      *
    *                      *
    *       West MAP       *
    *                      *
    *                      *
    \**********************/

    class WestMap
    {
        public void Charlie() {

            Development newDevelop = new Development();
            newDevelop.Develop();

        }
    } // End of West

    /**********************\
    *                      *
    *                      *
    *      DEVELOPMENT     *
    *                      *
    *                      *
    \**********************/

    class Development
    {
        public void Develop() {

            Console.WriteLine("\nUNDER DEVELOPMENT");
            Console.WriteLine("Please consider donating to the developer to support the game!\n");
            Console.WriteLine("This is in Alpha 2.0.3, You may encounter bugs and glitches.");
            Console.WriteLine("Report any bugs to the developer!");

        }
    }
}
/*
 * TODO Make each attacks counter each other
 * 
 * Counter:
 * Attack > Defence
 * Heavy > Attack
 * Defence > Heavy
 */
/*
 * Fix Inventory:
 * TODO Make a clean exit if the user types Exit
 * TODO Make it so when the player eats the AI wont attack, or just rework the kill screen for the AI
 * 
 */
