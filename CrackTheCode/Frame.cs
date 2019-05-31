using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCode
{
    class Frame
    {
        internal static void BuildTitle()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"   ___               _      _   _              ___          _
  / __\ __ __ _  ___| | __ | |_| |__   ___    / __\___   __| | ___
 / / | '__/ _` |/ __| |/ / | __| '_ \ / _ \  / /  / _ \ / _` |/ _ \
/ /__| | | (_| | (__|   <  | |_| | | |  __/ / /__| (_) | (_| |  __/
\____/_|  \__,_|\___|_|\_\  \__|_| |_|\___| \____/\___/ \__,_|\___|
");
            Console.ResetColor();
        }
        internal static void BuildTable()
        { 
            Console.WriteLine(@"

                      ┌─────┬─────┬─────┬─────┐
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      ├─────┼─────┼─────┼─────┤
                      │     │     │     │     │
                      └─────┴─────┴─────┴─────┘

    Enter your guess: ");
            Console.SetCursorPosition(25, 7);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("*     *     *     *");
            Console.ResetColor();
            Console.SetCursorPosition(60, 10);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("■ ");
            Console.ResetColor();
            Console.WriteLine("= The number is correct, but not in the correct place");
            Console.SetCursorPosition(60, 8);
            Console.WriteLine("■ = The number is correct and also in the correct place");
        }
        internal static void BuildWin()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
                        
                          YOU WON THE GAME!");
        }
        internal static void BuildLose()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
                        
                          YOU LOST THE GAME!");
        }
    }
}
