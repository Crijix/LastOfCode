using GameVariables;
using GameScreen;
using Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movement
{
    /**********************\
    *                      *
    *                      *
    *    PLAYER MOVEMENT   *
    *                      *
    *                      *
    \**********************/

    class Player : KillScreen
    {
        public string playerPick = "";

        /// <summary>
        /// Plays the game for the player
        /// </summary>
        public void PlayerGame()
        {

            // Player
            Console.Write("\nChoose a move (Attack/Heavy/Defence/Inventory): ");
            string input = Console.ReadLine().ToLower().Trim();

            playerPick = input;

            // TODO Try_Catch
            while (true)
            {
                if (input == "attack")
                {

                    Moves move = new Moves();
                    move.MoveRNG();

                    TopScreen();

                    // Player attack output
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYour move: Attack");
                    Moves.enemyHealth -= move.attack;
                    Console.WriteLine("You did {0} damage to the enemy!", move.attack);
                    Console.ResetColor();
                    break;

                }
                else if (input == "heavy")
                {

                    Moves move = new Moves();
                    move.MoveRNG();

                    TopScreen();

                    // Player attack output
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYour move: Heavy");
                    Moves.enemyHealth -= move.heavy;
                    Console.WriteLine("You did {0} damage to the enemy!", move.heavy);
                    Console.ResetColor();
                    break;

                }
                else if (input == "defence")
                {

                    Moves move = new Moves();
                    move.MoveRNG();

                    TopScreen();

                    // Player attack output
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYour move: Defence");
                    Moves.enemyHealth -= move.defence;
                    Console.WriteLine("You did {0} damage to the enemy!", move.defence);
                    Console.ResetColor();
                    break;

                }
                else if (input == "inventory")
                {

                    Food newFood = new Food();
                    newFood.Inventory();
                    break;

                }
                else
                {

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

    class AI : KillScreen
    {
        public int AIPick;

        /// <summary>
        /// Plays the game for the AI
        /// </summary>
        public void AIGame()
        {

            Random botRNG = new Random();
            int botPick = botRNG.Next(1, 4);

            AIPick = botPick;

            Moves move = new Moves
            {
                attack = 1,
                heavy = 2,
                defence = 3
            };

            if (botPick == 1)
            {

                move.MoveRNG();
                // AI attack output
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nThe enemy's move: Attack");
                Console.WriteLine();
                Console.WriteLine("The enemy did {0} damage to you!", move.attack);
                Console.ResetColor();

                Moves.playerHealth -= move.attack;

                Status iStatus = new Status();
                iStatus.ShowStatus();

                BottomScreen();
            }
            else if (botPick == 2)
            {

                move.MoveRNG();
                // AI attack output
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nThe enemy's move: Heavy");
                Console.WriteLine();
                Console.WriteLine("The enemy did {0} damage to you!", move.heavy);
                Console.ResetColor();

                Moves.playerHealth -= move.heavy;

                Status iStatus = new Status();
                iStatus.ShowStatus();

                BottomScreen();
            }
            else if (botPick == 3)
            {

                move.MoveRNG();
                // AI attack output
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nThe enemy's move: Defence");
                Console.WriteLine();
                Console.WriteLine("The enemy did {0} damage to you!", move.defence);
                Console.ResetColor();

                Moves.playerHealth -= move.defence;

                Status iStatus = new Status();
                iStatus.ShowStatus();

                BottomScreen();
            }
            Console.WriteLine();
        }
    } // End of AI
}
