using System; 
using System.Collections.Generic;

namespace practic_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> two = new List<string> { "  1. Убрать дома", "  2. Сходить в магазин за продуктами" };


            day1();
        }

        static void day1()
        {
            List<string> one = new List<string> { "  1.Сходить на манкюр", "  2.Сходить с мамой в кино" };
            Console.WriteLine("\tЗаметки 29.12.2022");
            Console.WriteLine(one[0]);
            Console.WriteLine(one[1]);
            string F = "Время создания";

            int position = 1;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo clavisha = Console.ReadKey();

            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 29.12.2022");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 29.12.2022");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();

                if (clavisha.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    day2();
                }
                else if (clavisha.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    day2();
                }





            }

            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine(one[0] + " ---- Встретиться с друзьями, отдать подарок");
                Console.WriteLine();
                Console.WriteLine(F + ": 31.12.2022 - 13:20:19");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine(one[1] + " ---- Посмотреть обращение президента ");
                Console.WriteLine();
                Console.WriteLine(F + ": 31.12.2022 - 00:00:00");
            }

            Console.ReadKey();
            Console.Clear();
            day1();

            static void day2()
            {

                List<string> two = new List<string> { "  1. Написать друзьям", "  2. Сходить на каток с друзьями" };

                Console.WriteLine("\tЗаметки 05.01.2023");
                Console.WriteLine(two[0]);
                Console.WriteLine(two[1]);
                string F = "Время создания";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 05.01.2023");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 05.01.2023");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }

                    Console.SetCursorPosition(0, position);
                }
            }
        }
    }
}                            