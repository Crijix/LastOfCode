using GameVariables;
using GameScreen;
using Movement;
using Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    /**********************\
    *                      *
    *                      *
    *         GAME         *
    *                      *
    *                      *
    \**********************/

    class Game : Moves
    {
        public void PlayGame()
        {
            // Player Movement
            var playerPick = new Player();
            playerPick.PlayerGame();

            // AI Movement
            var aiPick = new AI();
            aiPick.AIGame();

            var screen = new EndScreen();

            // Next Turn
            Console.WriteLine("\nWhat will you do next!? (Inventory/Next Turn)");
            Console.Write("Your move: ");
            string nextTurn = Console.ReadLine().ToLower().Trim();

            // TODO not exit application when user type an invalid move
            while (true)
            {
                if (nextTurn == "inventory")
                {

                    Food newFood = new Food();
                    newFood.Inventory();
                    nextTurn = "next";

                }
                if (nextTurn == "next" || nextTurn == "next turn")
                {
                    // Keep playing as long as player have health left
                    while (Moves.playerHealth > 0)
                    {
                        playerPick.PlayerGame();
                        aiPick.AIGame();

                        // If the bot have 0 or below, then the player will win
                        if (Moves.enemyHealth <= 0)
                        {
                            break;
                        }
                        // If the player have 0 or below, then the bot will win
                        else if (Moves.playerHealth <= 0)
                        {

                            Console.Clear();
                            screen.Lose();
                            Environment.Exit(1);
                        }
                    }

                }
                else
                {

                    Console.WriteLine("\nInvaild command. Please enter one of the listed!");
                    Console.Write("Your move: ");
                    nextTurn = Console.ReadLine().ToLower().Trim();

                }
                break; // FIX: If user type wrong move, it will break out of loop and continue the game (A.K.A lose the game)
            }
        }
    } // End of Game

    /**********************\
    *                      *
    *                      *
    *      CHECK GAME      *
    *                      *
    *                      *
    \**********************/

    class CheckGame
    {
        public void Check()
        {
            if (Moves.playerHealth > 0 && Moves.enemyHealth <= 0)
            {
                var screen = new EndScreen();
                Console.Clear();
                screen.Win();
            }
            else
            {
                var screen = new EndScreen();
                Console.Clear();
                screen.Lose();
                Environment.Exit(1);
            }
        }
    } // End of Check
}
