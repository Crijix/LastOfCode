using GameVariables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScreen
{
    /**********************\
    *                      *
    *                      *
    *        STATUS        *
    *                      *
    *                      *
    \**********************/

    /// <summary>
    /// Display the health remaining from both player and AI
    /// </summary>
    class Status
    {
        public void ShowStatus()
        {

            Console.WriteLine("\n");
            Console.WriteLine("    PLAYER HEALTH       |       ENEMY HEALTH        ");
            Console.WriteLine("          {0}           |           {1}             ", Moves.playerHealth, Moves.enemyHealth);
        }
    } // End of Status

    /**********************\
    *                      *
    *                      *
    *      KILL SCREEN     *
    *                      *
    *                      *
    \**********************/

    /// <summary>
    /// Display the top and bottom frame
    /// </summary>
    class KillScreen
    {
        public void TopScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n================ KILL SCREEN ================");
            Console.ResetColor();
        }

        public void BottomScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n=============================================\n");
            Console.ResetColor();
        }
    } // End of KillScreen

    /**********************\
    *                      *
    *                      *
    *      End Screen      *
    *                      *
    *                      *
    \**********************/

    class EndScreen
    {
        public void Lose()
        {

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

        public void Win()
        {

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
}
