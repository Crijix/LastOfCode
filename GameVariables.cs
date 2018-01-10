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
        public int attack;
        public int heavy;
        public int defence;

        // Heatlh
        public static int playerHealth = 150;
        public static int enemyHealth = 100; // Default Value for enemies
        public static int[] enemyRNG = { 90, 100, 120 }; // Choose between one of the 3

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
