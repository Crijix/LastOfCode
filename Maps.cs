using PlayGame;
using GameVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maps
{
    /**********************\
    *                      *
    *                      *
    *      NORTH MAP       *
    *                      *
    *                      *
    \**********************/

    class NorthMap : Game
    {
        /// <summary>
        /// Enters the North Map
        /// </summary>
        public void goNorth()
        {
            // Encounter
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou walk into a forrest and see a monster!");
            Console.WriteLine("The monster you encounter is a wolf");
            Console.WriteLine("It's trying to attack you!\n");
            Console.ResetColor();

            PlayGame();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou see another monster!!");
            Console.WriteLine("It's a lion and it is attacking you!\n");
            Console.ResetColor();

            Moves.enemyHealth = 100;

            PlayGame();

            CheckGame Game = new CheckGame();
            Game.Check();
        }
    } // End of North

    /**********************\
    *                      *
    *                      *
    *      SOUTH MAP       *
    *                      *
    *                      *
    \**********************/

    class SouthMap : Game
    {
        /// <summary>
        /// Enters the South Map
        /// </summary>
        public void goAlpha()
        {
            // Initialize new enemy
            EnemyHealth zombie = new EnemyHealth(150);

            // Encounter
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYou walk into a deep dark cave and see a monster!");
            Console.WriteLine("The monster you encounter is a zombie");
            Console.WriteLine("It's comming towards you!\n");
            Console.ResetColor();

            PlayGame();

            CheckGame Game = new CheckGame();
            Game.Check();
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

    class EastMap : Game
    {
        /// <summary>
        /// Enters the East Map
        /// </summary>
        public void goBeta()
        {
            // Initialize new enemy
            SpawnEnemy monsterVampire = new SpawnEnemy()
            {
                Name = "Dr. Lul"
            };
            HealthRNG(); // Spawning with random health

            // Encounter
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*** ALERT! ***");
            Console.WriteLine("\nYou walk into a deep dark cave and see a monster!");
            Console.WriteLine("The monster you encounter is {0}", monsterVampire.Name);
            Console.WriteLine("It's comming towards you!\n");
            Console.ResetColor();

            PlayGame();

            // Initialize enemy
            SpawnEnemy monsterWerewolf = new SpawnEnemy()
            {
                Name = "The Werewolf, Jerry"
            };
            EnemyHealth Werewolf = new EnemyHealth(110);

            System.Threading.Thread.Sleep(1000);

            // Encounter
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** ALERT! ***");
            Console.WriteLine("\nYou walked too far inside the cave and encounter a new monster!");
            Console.WriteLine("The monster you encounter is {0}!", monsterWerewolf.Name);
            Console.WriteLine("It's comming towards you!\n");
            Console.ResetColor();

            PlayGame();

            CheckGame Game = new CheckGame();
            Game.Check();

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
        /// <summary>
        /// Enters the West Map
        /// </summary>
        public void goCharlie()
        {

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
        /// <summary>
        /// Prints out a message saying the game is under development
        /// </summary>
        public void Develop()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nUNDER DEVELOPMENT");
            Console.ResetColor();
            Console.WriteLine("Please consider donating to the developer to support the game!\n");
            Console.WriteLine("This is in Alpha 2.1.3, You may encounter bugs and glitches.");
            Console.WriteLine("Report any bugs to the developer!");

        }
    }
}
