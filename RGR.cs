using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace g_class
{ class Program
    {
        public static int[] Vector(int[] point1, int[] point2)
        {
            int[] vector = { point2[0] - point1[0], point2[1] - point1[1] };
            return vector;
        }
        public static int Cross(int[] u, int[] v)
        {
            int cross = u[0] * v[1] - u[1] * v[0];
            return cross;
        }
        static void Main()
        {
            int[][] points = new int[10][];
            points[0] = new int [] { -4, -3 };
            points[1] = new int [] { -2, 2 };
            points[2] = new int[] { 1, 1 };
            points[3] = new int[] { 1, -3 };
            points[4] = new int[] { 2, 2 };
            points[5] = new int[] { 2, 4 };
            points[6] = new int[] { 3, -2 };
            points[7] = new int[] { 3, -4 };
            points[8] = new int[] { 5, 1 };
            points[9] = new int[] { 6, 5 };

            int[] min_point = points[0];
            for (int i = 0; i < points.Length; i++)
            {
                if (min_point[1] > points[i][1])
                {
                    min_point = points[i];
                }
            }

            int[][] convex_hull = new int[points.Length][];
            for (int i = 0; i < convex_hull.Length; i++)
            {
                convex_hull[i] = new int[] { Int32.MaxValue, Int32.MaxValue };
            }

            convex_hull[0] = min_point;
            bool yes = true;
            int k = 1;

            while (yes)
            {
                int[] p = convex_hull[k - 1];
                int[] v1 = Vector(p, points[0]);
                int[] q = points[0];

                foreach (int[] point in points)
                {
                    int[] v2 = Vector(p, point);
                    if (Cross(v1,v2) < 0)
                    {
                        v1 = v2;
                        q = point;
                    }
                }

                if (q == p) break;
                else
                {
                    convex_hull[k] = q;
                }

                k += 1;

            }

            Console.WriteLine("Выпуклая оболочка состоит из точек");
            Console.WriteLine($"X\t Y\t"); 

            foreach (int[] point in convex_hull)
            {
                if (point[0] != Int32.MaxValue) Console.WriteLine($"{point[0]}\t {point[1]}\t");
            }
        }
    }
}
