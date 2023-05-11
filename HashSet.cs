using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace menu
{
    class teacher
    {
        static void Main()
        {

            bool rgrka = true;
            while (rgrka)
            {
                rgrka = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            HashSet<string> list= new HashSet<string>();
            list.Add("Third");
            list.Add("Second");
            list.Add("First");
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("1) добавка строки");
            Console.WriteLine("2) Размер листа");
            Console.WriteLine("3) Очистить лист");
            Console.WriteLine("4) нахождение");
            Console.WriteLine("5) последнее нахождение");
            Console.WriteLine("6) репит");
            Console.WriteLine("7) контейнерс");
            Console.WriteLine("8) инсерт");
            Console.WriteLine("9) реверсилка");
            Console.WriteLine("10) сортироука");
            Console.Write("\r\nВыберите действие: ");
            switch (Console.ReadLine())
            {
                case "1":
                    добавка_строка(list);
                    return true;
                case "2":
                    dlina(list);
                    return true;
                case "3":
                    chisto(list);
                    return true;
                case "4":
                    ToString(list);
                    return true;
                case "5":
                    enumer(list);
                    return true;
                case "6":
                    репит();
                    return true;
                case "7":
                    контейнерс(list);
                    return true;
                case "8":
                    GetType(list);
                    return true;
                case "9":
                    print(list);
                    return true;
                case "10":
                    hashcode(list);
                    return true;
                default:
                    return true;
                
            }
        }
        
        public static void добавка_строка(HashSet<string> list)
        {
            Console.Clear();
            list.Add(Console.ReadLine());
            foreach (var element  in list)
            {
                Console.Write($"{element}\t");
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }

        public static void dlina(HashSet<string> list)
        {
            Console.Clear();
            Console.WriteLine(list.Count);
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }

        public static void chisto(HashSet<string> list)
        {
            Console.Clear();
            list.Clear();
            foreach (var element  in list)
            {
                Console.Write($"{element}\t");
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
            
        }

        public static void ToString(HashSet<string> list)
        {
            Console.Clear();
            list.ToString();
            Console.WriteLine(list.ToString());
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void enumer(HashSet<string> list)
        {
            Console.Clear();
            Console.WriteLine(list.GetEnumerator());
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void репит()
        {
            Console.Clear();
            Console.Write("Введите строку, из которой будет состоять Hashset");
            string a = Console.ReadLine();
            Console.Write("Введите колво элементов Hashet");
            int l=Convert.ToInt32(Console.ReadLine());
            ArrayList al = ArrayList.Repeat( a, l );
            foreach (var element  in al)
            {
                Console.Write($"{element}\t");
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void контейнерс(HashSet<string> list)
        {
            Console.Clear();
            Console.Write("Введите элемент");
            string f = Console.ReadLine();;
            Console.WriteLine(list.Contains(f));
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void GetType(HashSet<string> list)
        {
            Console.Clear();
            foreach (var element  in list)
            {
                Console.Write(element.GetType());
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void print(HashSet<string> list)
        {
            Console.Clear();
            foreach (var element  in list)
            {
                Console.Write($"{element}\t");
            }
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
        public static void hashcode(HashSet<string> list)
        {
            Console.Clear();
            Console.WriteLine(list.GetHashCode());
            Console.Write("\r\nНажмите Enter, чтобы вернуться в главное меню");
            Console.ReadLine();
        }
    }
}
