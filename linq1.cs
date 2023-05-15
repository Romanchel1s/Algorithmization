using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 0, 0, -545, 3, -4, 12, 105, 0, 2, 12 };
            var array1 = from n in array
                          select n;
            Console.WriteLine(array1.Min());
            var array2 = from n in array
                         where n%2==0
                         select n;
            Console.WriteLine(array2.Min());
            Console.ReadLine();
        }
   
