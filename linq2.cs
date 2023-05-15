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
            int n = array.Length;
            List<int> array1 = new List<int>();
            List<int> array2 = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int r = n / 2;
                if (i < r) array1.Add(array[i]);
                if (i > r) array2.Add(array[i]);
            }
            var firstar = array1.OrderBy(p => p);
            var lastar = array2.OrderByDescending(p => p);
            foreach (int num in lastar)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
