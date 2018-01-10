using GameVariables;
using GameScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
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
        /// <summary>
        /// Takes the items from inventory and displays it to the player
        /// </summary>
        public void Inventory()
        {
            Bag newBag = new Bag();
            Moves move = new Moves();
            newBag.FoodBag();

            string[] items = { "Bread", "Water", "Cookie" };

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n================= INVENTORY =================");
            Console.ResetColor();

            Console.WriteLine("\nYour Inventory: ");
            Console.WriteLine(" - {0} (Gives you {1} health back.)", items[0], newBag.bread);
            Console.WriteLine("     In bagpack: {0}", Bag.iBread);
            Console.WriteLine(" - {0} (Gives you {1} health back.)", items[1], newBag.water);
            Console.WriteLine("     In bagpack: {0}", Bag.iWater);
            Console.WriteLine(" - {0} (Gives you {1} health back.)", items[2], newBag.cookie);
            Console.WriteLine("     In bagpack: {0}", Bag.iCookie);
            Console.WriteLine();

            Console.WriteLine("Please enter the item you wish to take, or type Exit");
            Console.Write("Item: ");
            string userInput = Console.ReadLine().ToLower().Trim();


            if (userInput == "bread")
            {
                Bag newFood = new Bag();

                // Check to see if player have any left in inventory
                if (Bag.iBread >= 1)
                {
                    Moves.playerHealth += newBag.bread;
                    Bag.iBread -= 1;
                }
                else if (Bag.iBread <= 0) // Just to make sure VS not being a fucboi
                {
                    newFood.EmptyFood();
                }

            }
            else if (userInput == "water")
            {

                Bag newFood = new Bag();

                // Check to see if player have any left in inventory
                if (Bag.iWater >= 1)
                {
                    Moves.playerHealth += newBag.water;
                    Bag.iWater -= 1;
                    // TODO break out of inventory when player heals
                }
                else
                {
                    newFood.EmptyFood();
                }

            }
            else if (userInput == "cookie")
            {

                Bag newFood = new Bag();

                // Check to see if player have any left in inventory
                if (Bag.iCookie >= 1)
                {
                    Moves.playerHealth += newBag.cookie;
                    Bag.iCookie -= 1;
                    // TODO break out of inventory when player heals
                }
                else
                {
                    newFood.EmptyFood();
                }
            }
            else
            {

                // TODO break out of the loop and back to the game

            }

            // Allow player not to heal more than 150
            if (Moves.playerHealth > 150)
            {
                Moves.playerHealth = 150;
            }

            // FIX: Prints out no matter what
            Console.WriteLine("You have used {0} and your health have been restored to {1}", userInput, Moves.playerHealth);

            KillScreen screen = new KillScreen();
            screen.BottomScreen();

        }
    } // End of Food

    /**********************\
    *                      *
    *                      *
    *       BACKPACK       *
    *                      *
    *                      *
    \**********************/

    /// <summary>
    /// Holds the variables for the inventory
    /// </summary>
    class Bag
    {
        // CLASS VARIABLES
        public int bread;
        public int water;
        public int cookie;

        // Amount of food available
        public static int iBread = 1;
        public static int iWater = 2;
        public static int iCookie = 3;

        /// <summary>
        /// Holds the value of food for each item
        /// </summary>
        public void FoodBag()
        {

            // Value of Items
            bread = 20;
            water = 10;
            cookie = 15;

        }

        public void EmptyFood()
        {
            Console.WriteLine("\nYou're out of that item!");
            Console.Write("Inventory or Exit back to game: ");
            string itemPick = Console.ReadLine().ToLower().Trim();

            while (true)
            {
                if (itemPick == "inventory")
                {
                    Food goInventory = new Food();
                    goInventory.Inventory();
                }
                else if (itemPick == "exit")
                {
                    // TODO let the player go back to the game
                }
                else
                {
                    // If the user didn't enter a valid move
                    Console.WriteLine("\nPlease just pick one of the moves");
                    Console.Write("Move: ");
                    string userPick = Console.ReadLine().ToLower().Trim();

                    itemPick = userPick;
                }
            }
        }
    } // End of Bagpack
}
