using System;
using System.Collections.Generic;
using System.Linq;
namespace deligates
{
    class Program
    {
        delegate double ActionMath(double number_1, double number_2, double number_3);

        public static void Main()
        {
            ActionMath math;
            Console.WriteLine("Введите первое число:");
            var number_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var number_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            var number_3 = Convert.ToDouble(Console.ReadLine());
            Menu();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    math = (x, y, z) => x + y + z;
                    var result_1 = math(number_1, number_2, number_3);
                    Console.WriteLine(result_1);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D2:
                    math = (x, y, z) => x * y * z;
                    var result_2 = math(number_1, number_2, number_3);
                    Console.WriteLine(result_2);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    math = (x, y, z) =>
                    {
                        double[] abc = { x, y, z };
                        var result_3 = abc.Min();
                        return result_3;
                    };
                    var final = math(number_1, number_2, number_3);
                    Console.WriteLine(final);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    math = (x, y, z) =>
                    {
                        double[] abc = { x, y, z };
                        var result_3 = abc.Max();
                        return result_3;
                    };
                    var final1 = math(number_1, number_2, number_3);
                    Console.WriteLine(final1);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    math = (x, y, z) => (x + y + z) / 3;
                    var f = math(number_1, number_2, number_3);
                    Console.WriteLine(f);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine("бб");
                    break;
            }

        }

        public static void Menu()
        {
            Console.WriteLine("МЕНЮ\n" +
                              "1. Сложить\n" +
                              "2. Перемножить\n" +
                              "3. Мин \n" +
                              "4. Макс \n" +
                              "5. Ср. арифм \n");
        }


    }


}
