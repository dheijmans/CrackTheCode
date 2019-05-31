using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Frame.BuildTitle();
            Frame.BuildTable();
            bool gameIsOn = true;
            Random random = new Random();
            int code1;
            int code2;
            int code3;
            int code4;
            do
            {
                code1 = random.Next(0, 10);
                code2 = random.Next(0, 10);
                code3 = random.Next(0, 10);
                code4 = random.Next(0, 10);
            } while (code1 == code2 || code1 == code3 || code1 == code4 || code2 == code3 || code2 == code4 || code3 == code4);
            int yPosistion = 27;
            int tries = 1;
            string[] input;
            bool wonGame = false;
            int inputNum1;
            int inputNum2;
            int inputNum3;
            int inputNum4;
                do
                {
                    try
                    {
                        Console.SetCursorPosition(22, 30);
                        input = Console.ReadLine().Split();
                        inputNum1 = int.Parse(input[0]);
                        inputNum2 = int.Parse(input[1]);
                        inputNum3 = int.Parse(input[2]);
                        inputNum4 = int.Parse(input[3]);
                    }
                    catch
                    {
                        Console.SetCursorPosition(22, 30);
                        Console.WriteLine("                                                                                                                                                                                                    ");
                        continue;
                    }
                    if (inputNum1 < 0 || inputNum1 > 9 || inputNum2 < 0 || inputNum2 > 9 || inputNum3 < 0 || inputNum3 > 9 || inputNum4 < 0 || inputNum4 > 9)
                    {
                        Console.SetCursorPosition(22, 30);
                        Console.WriteLine("                                                                                                                                                                                                    ");
                        continue;
                    }
                    if (inputNum1 == inputNum2 || inputNum1 == inputNum3 || inputNum1 == inputNum4 || inputNum2 == inputNum3 || inputNum2 == inputNum4 || inputNum3 == inputNum4)
                    {
                        Console.SetCursorPosition(22, 30);
                        Console.WriteLine("                                                                                                                                                                                                    ");
                        continue;
                    }
                    gameIsOn = IsGameOn(inputNum1, inputNum2, inputNum3, inputNum4, code1, code2, code3, code4, tries);
                    PlaceInput(inputNum1, inputNum2, inputNum3, inputNum4, yPosistion);
                    GiveHint(inputNum1, inputNum2, inputNum3, inputNum4, code1, code2, code3, code4, yPosistion);
                    yPosistion -= 2;
                    tries++;
                    wonGame = WonGame(inputNum1, inputNum2, inputNum3, inputNum4, code1, code2, code3, code4);
                } while (gameIsOn);
                EndScreen(code1, code2, code3, code4, wonGame);
                Console.ReadLine();
                continue;
            }
        }
        private static void EndScreen(int code1, int code2, int code3, int code4, bool wonGame)
        {
            Console.SetCursorPosition(25, 7);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(code1 + "     " + code2 + "     " + code3 + "     " + code4);
            Console.ResetColor();
            Console.SetCursorPosition(4, 30);
            Console.Write("Press 'ENTER' to continue ");
            Console.ReadLine();
            Frame.BuildTitle();
            if (wonGame)
            {
                Frame.BuildWin();
            }
            else
            {
                Frame.BuildLose();
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("    Press 'ENTER' to play again ");
        }
        private static bool WonGame(int inputNum1, int inputNum2, int inputNum3, int inputNum4, int code1, int code2, int code3, int code4)
        {
            if (inputNum1 == code1 && inputNum2 == code2 && inputNum3 == code3 && inputNum4 == code4) return true; return false;
        }
        private static void GiveHint(int inputNum1, int inputNum2, int inputNum3, int inputNum4, int code1, int code2, int code3, int code4, int yPosition)
        {
            int xPosistionGoodPlace = 48;
            int xPosistionGoodNum = 20;
            int goodNum = 0;
            int goodPlace = 0;
            if (inputNum1 == code1)
            {
                goodPlace++;
            }
            else if (inputNum1 == code2 || inputNum1 == code3 || inputNum1 == code4)
            {
                goodNum++;
            }
            if (inputNum2 == code2)
            {
                goodPlace++;
            }
            else if (inputNum2 == code1 || inputNum2 == code3 || inputNum2 == code4)
            {
                goodNum++;
            }
            if (inputNum3 == code3)
            {
                goodPlace++;
            }
            else if (inputNum3 == code1 || inputNum3 == code2 || inputNum3 == code4)
            {
                goodNum++;
            }
            if (inputNum4 == code4)
            {
                goodPlace++;
            }
            else if (inputNum4 == code1 || inputNum4 == code2 || inputNum4 == code3)
            {
                goodNum++;
            }
            for (int i = 0; i < goodPlace; i++)
            {
                Console.SetCursorPosition(xPosistionGoodPlace, yPosition);
                Console.Write("■");
                xPosistionGoodPlace+=2;
            }
            for (int i = 0; i < goodNum; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(xPosistionGoodNum, yPosition);
                Console.Write("■");
                xPosistionGoodNum-=2;
                Console.ResetColor();
            }
        }
        private static bool IsGameOn(int inputNum1, int inputNum2, int inputNum3, int inputNum4, int code1, int code2, int code3, int code4, int tries)
        {
            if (inputNum1 == code1 && inputNum2 == code2 && inputNum3 == code3 && inputNum4 == code4)
            {
                return false;
            }
            else if (tries >= 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PlaceInput(int inputNum1, int inputNum2, int inputNum3, int inputNum4, int yPosition)
        {
            Console.SetCursorPosition(25, yPosition);
            Console.WriteLine(inputNum1);
            Console.SetCursorPosition(31, yPosition);
            Console.WriteLine(inputNum2);
            Console.SetCursorPosition(37, yPosition);
            Console.WriteLine(inputNum3);
            Console.SetCursorPosition(43, yPosition);
            Console.WriteLine(inputNum4);
            Console.SetCursorPosition(22, 30);
            Console.WriteLine("                                                                                                                                                           ");
        }
    }
}
