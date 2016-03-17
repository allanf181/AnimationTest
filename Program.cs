using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AnimationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SpaceInvaders";
            ConsoleSpiner spin = new ConsoleSpiner();
            Console.Write("Carregando....");
            int SpinTime = 0;
            while (SpinTime < 1000)
            {
                spin.Turn();
                SpinTime = SpinTime + 1;
                Thread.Sleep(1);
            }
            Console.Clear();
            Console.WriteLine("Carregado.");
            Console.WriteLine("Precione qualquer tecla para iniciar a animação...");
            int Frame = 250;
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            for (; ; )
            {
                //inicio frame 1/2
                Console.Write("\n");//1
                Console.Write("\n");//2
                Console.Write("\n");//3
                int block = 0;//4
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//4 AH AI
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("          ");//4 AJ -- AS
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//4 AT AU
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-4
                block = 0;//5
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//5 AH AI
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("          ");//5 AJ -- AS
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//5 AT AU
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-5
                block = 0;//6
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//6 AJ Ak
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("      ");//6 AL -- AQ
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//6 AR AS
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-6
                block = 0;//7
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//7 AJ Ak
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("      ");//7 AL -- AQ
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//7 AR AS
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-7
                block = 0;//8
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkCyan;//8 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-8
                block = 0;//9
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkCyan;//9 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-9
                block = 0;//10
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkCyan;//10 AF -- AI
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;//10 AJ AK
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//10 AL -- AQ
                while (block < 6)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//10 AR AS
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//10 AT -- AW
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-10
                block = 0;//11
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkCyan;//11 AF -- AI
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;//11 AJ AK
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//11 AL -- AQ
                while (block < 6)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//11 AR AS
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//11 AT -- AW
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-11
                block = 0;//12
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//12 AD -- AY
                while (block < 22)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-12
                block = 0;//13
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//13 AD -- AY
                while (block < 22)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-13
                block = 0;//14
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//14 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//14 AF AG
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//14 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//14 AV AW
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//14 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-14
                block = 0;//15
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//15 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//15 AF AG
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//15 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//15 AV AW
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//15 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-15
                block = 0;//16
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//16 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//16 AF AG
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//16 AH AI
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//16 AJ -- AS
                while (block < 10)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//16 AT AU
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//16 AV AW
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//16 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-16
                block = 0;//17
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//17 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//17 AF AG
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//17 AH AI
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//17 AJ -- AS
                while (block < 10)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//17 AT AU
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//17 AV AW
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//17 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-17
                block = 0;//18
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("    ");//18 AJ -- AM
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("  ");//18 AN AO
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("    ");//18 AP -- AS
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-18
                block = 0;//19
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("    ");//19 AJ -- AM
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("  ");//19 AN AO
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("    ");//19 AP -- AS
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 35)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-19
                Thread.Sleep(Frame);
                Console.Clear();
                //inicio frame 2/2
                Console.Write("\n");//31
                Console.Write("\n");//32
                Console.Write("\n");//33
                block = 0;//34
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//34 AH AI
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("          ");//34 AJ -- AS
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//34 AT AU
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-34
                block = 0;//35
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//35 AH AI
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("          ");//35 AJ -- AS
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//35 AT AU
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-35
                block = 0;//36
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//36 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//36 AF -- AI
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//36 AJ AK
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//36 AL -- AQ
                while (block < 6)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//36 AR AS
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//36 AT -- AW
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//36 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-36
                block = 0;//37
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//37 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//37 AF -- AI
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//37 AJ AK
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//37 AL -- AQ
                while (block < 6)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//37 AR AS
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//37 AT -- AW
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//37 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-37
                block = 0;//38
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//38 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//38 AF AG
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//38 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//38 AV AW
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//38 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-38
                block = 0;//39
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//39 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;//39 AF AG
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//39 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//39 AV AW
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//39 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-39
                block = 0;//40
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//40 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//40 AF -- AI
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;//40 AJ AK
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//40 AL -- AQ
                while (block < 6)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//40 AR AS
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//40 AT -- AW
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//40 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-40
                block = 0;//41
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//41 AD AE
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//41 AF -- AI
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.White;//41 AJ AK
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//41 AL -- AQ
                while (block < 6)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;//41 AR AS
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.DarkCyan;//41 AT -- AW
                Console.Write("    ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;//41 AX AY
                Console.Write("  ");
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-41
                block = 0;//42
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//42 AD -- AY
                while (block < 22)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-42
                block = 0;//43
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//43 AD -- AY
                while (block < 22)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 29)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-43
                block = 0;//44
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//44 AF -- AW
                while (block < 18)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-44
                block = 0;//45
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;//45 AF -- AW
                while (block < 18)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-45
                block = 0;//46
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//46 AH AI
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("          ");//46 AJ -- AS
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//46 AT AU
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-46
                block = 0;//47
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//47 AH AI
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("          ");//47 AJ -- AS
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//47 AT AU
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 33)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-47
                block = 0;//48
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//48 AF AG
                Console.BackgroundColor = ConsoleColor.White;//48 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//48 AV AW
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-48
                block = 0;//49
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//49 AF AG
                Console.BackgroundColor = ConsoleColor.White;//49 AH -- AU
                while (block < 14)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ");//49 AV AW
                Console.BackgroundColor = ConsoleColor.White;
                while (block < 31)
                {
                    Console.Write(" ");
                    block = block + 1;
                }
                block = 0;//-49
                Thread.Sleep(Frame);
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
    public class ConsoleSpiner
    {
        int counter;
        public ConsoleSpiner()
        {
            counter = 0;
        }
        public void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}
