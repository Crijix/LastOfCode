using Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameVariables
{
    /**********************\
    *                      *
    *                      *
    *    CLASS VARIABLES   *
    *                      *
    *                      *
    \**********************/

    /// <summary>
    /// Stores the variables inside a class
    /// </summary>
    class Moves
    {
        // VARIABLES

        // Moves
        private int _attack;
        private int _heavy;
        private int _defence;

        // Heatlh
        private static int _playerHealth = 150;
        private static int _enemyHealth = 100; // Default Value for enemies
        private static int[] _enemyRNG = { 90, 100, 120 }; // Choose between one of the 3

        // HEALTH GET AND SETTERS
        public static int playerHealth
        {
            get { return _playerHealth; }
            set { _playerHealth = value; }
        }

        public static int enemyHealth 
        {

            get { return _enemyHealth; }
            set 
            {
                if (value <= 0)
                {
                    _enemyHealth = 0;
                } else
                {
                    _enemyHealth = value;
                }
            }
        }

        private static int[] enemyRNG 
        {
            get { return _enemyRNG; }
            set { _enemyRNG = value; }
        }

        // MOVES GET AND SETTERS
        public int attack 
        {
            get { return _attack; }
            set { _attack = value; }
        }
        
        public int heavy 
        {
            get { return _heavy; }
            set { _heavy = value; }
        }

        public int defence 
        {
            get { return _defence; }
            set { _defence = value; }
        }

        // Attack Generator
        /// <summary>
        /// Generate random numbers for the attack moves
        /// </summary>
        public void MoveRNG()
        {
            Random rng = new Random();
            attack = rng.Next(10, 30);
            heavy = rng.Next(20, 40);
            defence = rng.Next(1, 20);
        }

        // Random Health Generator
        public void HealthRNG()
        {
            Random rng = new Random();
            int hIndex = rng.Next(0, enemyRNG.Length);

            enemyHealth = enemyRNG[hIndex];
            //Console.WriteLine("HEALTH: {0}", enemyRNG[hIndex]);
        }

    } // End of Moves

    class Counter
    {
        public Counter()
        {
            // TODO Make attacks counter each other
            var Players = new Player();
            var Bot = new AI();
            if (Players.playerPick == "attack" && Bot.AIPick == 3)
            {

            }
        }
    }

    /**********************\
    *                      *
    *                      *
    *       ENEMIES        *
    *                      *
    *                      *
    \**********************/

    // Initialize Enemies
    class EnemyHealth
    {
        public EnemyHealth(int health = 100)
        {
            Moves.enemyHealth = health;
        }
    }

    public class SpawnEnemy
    {
        public string Name { get; set; }
        public string Type { get; set; }

    } // End of ENEMIES
}
