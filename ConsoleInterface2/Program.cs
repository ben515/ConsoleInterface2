using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterface2
{
    public class Vector:IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector()
        {
            X = 0;
            Y = 0;
        }
        public Vector(int vX,int vY)
        {
            X = vX;
            Y = vY;
        }
        public void Show()
        {
            Console.Write("({0},{1})  ", X, Y);
        }
        int IComparable.CompareTo(object obj)
        {
            Vector v = (Vector)obj;
            return (X * X + Y * Y) - (v.X * v.X + v.Y * v.Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vecArray = { new Vector(20, 10),
                new Vector(50, 20),
                new Vector(90,40),
                new Vector(10,10),
                new Vector(40,30) };
            Console.WriteLine("排序前 ...");
            for (int i  = 0;i <= vecArray.GetUpperBound(0);i++)
            {
                vecArray[i].Show();
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(vecArray);

            Console.WriteLine("排序後 ...");
            for(int i = 0;  i<= vecArray.GetUpperBound(0); i++)
            {
                vecArray[i].Show();
            }
            Console.Read();
        }
    }
}
