using System;
using System.Reflection.Emit;

namespace Pract3
{
    internal class Program
    {
        static void Main()
        {
            Octava1();
        }

        static void Octava1()
        {
            Console.Clear();
            Console.WriteLine("Первая октава");
            int stop = 1;
            int[] oct1 = new int[12];
            for (int i = 0; i < oct1.Length; i++)
            {
                oct1[i] = 2000 + 50 * i;
            }
            while (stop != 0)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.A)
                {
                    zvuk(oct1[0]);
                }

                if (key.Key == ConsoleKey.S)
                {
                    zvuk(oct1[1]);
                }

                if (key.Key == ConsoleKey.D)
                {
                    zvuk(oct1[2]);
                }

                if (key.Key == ConsoleKey.Q)
                {
                    zvuk(oct1[3]);
                }

                if (key.Key == ConsoleKey.W)
                {
                    zvuk(oct1[4]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    zvuk(oct1[5]);
                }

                if (key.Key == ConsoleKey.F)
                {
                    zvuk(oct1[6]);
                }

                if (key.Key == ConsoleKey.G)
                {
                    zvuk(oct1[7]);
                }

                if (key.Key == ConsoleKey.H)
                {
                    zvuk(oct1[8]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    zvuk(oct1[9]);
                }

                if (key.Key == ConsoleKey.T)
                {
                    zvuk(oct1[10]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    zvuk(oct1[11]);
                }

                if (key.Key == ConsoleKey.F2)
                {
                    Octava2();
                }

                if (key.Key == ConsoleKey.F3)
                {
                    Octava3();
                }

                if (key.Key == ConsoleKey.F4)
                {
                    Octava4();
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    stop = 0;
                }
            }

        }

        static void Octava2()
        {
            Console.Clear();
            Console.WriteLine("Малая октава");
            int stop = 1;
            int[] oct2 = new int[12];
            for (int i = 0; i < oct2.Length; i++)
            {
                oct2[i] = 1400 + 50 * i;
            }

            while (stop != 0)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.A)
                {
                    zvuk(oct2[0]);
                }

                if (key.Key == ConsoleKey.S)
                {
                    zvuk(oct2[1]);
                }

                if (key.Key == ConsoleKey.D)
                {
                    zvuk(oct2[2]);
                }

                if (key.Key == ConsoleKey.Q)
                {
                    zvuk(oct2[3]);
                }

                if (key.Key == ConsoleKey.W)
                {
                    zvuk(oct2[4]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    zvuk(oct2[5]);
                }

                if (key.Key == ConsoleKey.F)
                {
                    zvuk(oct2[6]);
                }

                if (key.Key == ConsoleKey.G)
                {
                    zvuk(oct2[7]);
                }

                if (key.Key == ConsoleKey.H)
                {
                    zvuk(oct2[8]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    zvuk(oct2[9]);
                }

                if (key.Key == ConsoleKey.T)
                {
                    zvuk(oct2[10]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    zvuk(oct2[11]);
                }

                if (key.Key == ConsoleKey.F1)
                {
                    Octava1();
                }

                if (key.Key == ConsoleKey.F3)
                {
                    Octava3();
                }

                if (key.Key == ConsoleKey.F4)
                {
                    Octava4();
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    stop = 0;
                }
            }
        }

        static void Octava3()
        {
            Console.Clear();
            Console.WriteLine("Большая октава");
            int stop = 1;
            int[] oct3 = new int[12];
            for (int i = 0; i < oct3.Length; i++)
            {
                oct3[i] = 800 + 50 * i;
            }

            while (stop != 0)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.A)
                {
                    zvuk(oct3[0]);
                }

                if (key.Key == ConsoleKey.S)
                {
                    zvuk(oct3[1]);
                }

                if (key.Key == ConsoleKey.D)
                {
                    zvuk(oct3[2]);
                }

                if (key.Key == ConsoleKey.Q)
                {
                    zvuk(oct3[3]);
                }

                if (key.Key == ConsoleKey.W)
                {
                    zvuk(oct3[4]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    zvuk(oct3[5]);
                }

                if (key.Key == ConsoleKey.F)
                {
                    zvuk(oct3[6]);
                }

                if (key.Key == ConsoleKey.G)
                {
                    zvuk(oct3[7]);
                }

                if (key.Key == ConsoleKey.H)
                {
                    zvuk(oct3[8]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    zvuk(oct3[9]);
                }

                if (key.Key == ConsoleKey.T)
                {
                    zvuk(oct3[10]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    zvuk(oct3[11]);
                }

                if (key.Key == ConsoleKey.F1)
                {
                    Octava1();
                }

                if (key.Key == ConsoleKey.F2)
                {
                    Octava2();
                }

                if (key.Key == ConsoleKey.F4)
                {
                    Octava4();
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    stop = 0;
                }
            }
        }

        static void Octava4()
        {
            Console.Clear();
            Console.WriteLine("Контр октава");
            int stop = 1;
            int[] oct4 = new int[12];
            for (int i = 0; i < oct4.Length; i++)
            {
                oct4[i] = 200 + 50 * i;
            }

            while (stop != 0)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.A)
                {
                    zvuk(oct4[0]);
                }

                if (key.Key == ConsoleKey.S)
                {
                    zvuk(oct4[1]);
                }

                if (key.Key == ConsoleKey.D)
                {
                    zvuk(oct4[2]);
                }

                if (key.Key == ConsoleKey.Q)
                {
                    zvuk(oct4[3]);
                }

                if (key.Key == ConsoleKey.W)
                {
                    zvuk(oct4[4]);
                }

                if (key.Key == ConsoleKey.E)
                {
                    zvuk(oct4[5]);
                }

                if (key.Key == ConsoleKey.F)
                {
                    zvuk(oct4[6]);
                }

                if (key.Key == ConsoleKey.G)
                {
                    zvuk(oct4[7]);
                }

                if (key.Key == ConsoleKey.H)
                {
                    zvuk(oct4[8]);
                }

                if (key.Key == ConsoleKey.R)
                {
                    zvuk(oct4[9]);
                }

                if (key.Key == ConsoleKey.T)
                {
                    zvuk(oct4[10]);
                }

                if (key.Key == ConsoleKey.Y)
                {
                    zvuk(oct4[11]);
                }

                if (key.Key == ConsoleKey.F1)
                {
                    Octava1();
                }

                if (key.Key == ConsoleKey.F2)
                {
                    Octava2();
                }

                if (key.Key == ConsoleKey.F3)
                {
                    Octava3();
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    stop = 0;
                }
            }
        }

        static void zvuk(int oct)
        {

            Console.Beep(oct, 150);
            Console.Clear();
        }



    }
}