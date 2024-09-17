using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Part_11___Making_Your_Own_Methods
{
    static class MyMethod
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        public static double GetLeg(double hypotenuse, double a)
        {
            return Math.Sqrt(hypotenuse * hypotenuse - a*a);
        }
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }
        public static double GetRise(Point p1, Point p2)
        {
            return p2.Y - p1.Y;
        }
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }
        public static double GetRun(Point p1, Point p2)
        {
            return p2.X - p1.X;
        }
        public static double GetDistance(double x1, double x2, double y1, double y2)
        {
            return GetHypotenuse(GetRise(y1,y2), GetRun(x1, x2));
        }
        public static double GetDistance(Point p1, Point p2)
        {
            return GetHypotenuse(GetRun(p1,p2),GetRise(p1,p2));
        }
        public static double GetSlope(double x1, double x2, double y1, double y2)
        {
            return GetRise(y1,y2)/GetRun(x1,x2);
        }
        public static double GetSlope(Point p1, Point p2)
        {
            return GetRise(p1,p2)/GetRun(p1 ,p2);
        }
        public static double GetYIntercept(double slope, Point point)
        {
            return point.Y - slope * point.X;
        }
        public static bool IsRight (double a, double b, double c)
        {
            return (a * a == b * b + c * c) || (a * a + b * b == c * c) || (a * a + c * c == b * b);
        }
        public static List<int> GetRandomList(int min, int max, int size)
        {
            Random gen = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(gen.Next(min,max));
            }
            return list;
        }
        public static int[] GetRandomArray(int min, int max, int size)
        {
            Random gen = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gen.Next(min,max);
            }
            return array;
        }
        public static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder();
        }
    }
}
