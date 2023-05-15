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
            //int[] array = { 1, 0, 0, -545, 3, -4, 12, 105, 0, 2, 12 };
            List<int> array = new List<int> { 1, 0, 0, -545, 3, -4, 12, 105, 0, 2, 12 };
            Console.WriteLine(array.Min());
            var array1 = from n in array
                         where n % 2 == 0
                         select n;
            List<int> helper = new List<int>();
            foreach (int num in array1)
            {
                helper.Add(num);
            }
            array = helper;
            Console.WriteLine(array.Min());
            Console.ReadLine();
        }
    }
}
   
