using Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Version 2.1.3

// TODO Make a SNEW Map with diffirent enemies in each (Stronger enemies)
// TODO Make a better Win/Dead screen
// TODO Replace while(true) loop with Try_Catch
// TODO Reset enemy health to default value when you kill an enemy

namespace LastOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            string map = Console.ReadLine().ToLower().Trim();
            while (true)
            {

                if (map == "north")
                {

                    NorthMap newMap = new NorthMap();
                    newMap.GoNorth();
                    break;

                }
                else if (map == "south")
                {

                    SouthMap newMap = new SouthMap();
                    newMap.GoAlpha();
                    break;

                }
                else if (map == "east")
                {

                    EastMap newMap = new EastMap();
                    newMap.GoBeta();
                    break;

                }
                else if (map == "west")
                {

                    WestMap newMap = new WestMap();
                    newMap.GoCharlie();
                    break;

                }
                else
                {

                    Console.Write("\nPlease just choose one of the maps listed: ");
                    map = Console.ReadLine().ToLower().Trim();
                }
            }
            Console.ReadKey();
        } // End of Main

        // Entry Application
        static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Console.ResetColor();

            Console.WriteLine("Hello there adventurer, and welcome to Last of Code!");
            Console.Write("May I please get your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("\nWell {0}, please enjoy your stay!!\n", input);

            Console.Write("Which map do you wish to enter ");
            Console.WriteLine("(North, South, East or West)");
            Console.Write("Your destiny: ");
        }

    } // End of Class Program
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
 * Fix Inventory
 * TODO Make a clean exit if the user types Exit
 * TODO Make it so when the player eats the AI wont attack, or just rework the kill screen for the AI
 * 
 */
