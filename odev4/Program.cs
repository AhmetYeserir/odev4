using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;int b = 12; int c = 18; int d = 23;int e = 45;int f = 55;int g = 76;
            Console.WriteLine(d == f && g > e && a<b);
            Console.ReadLine();
            Console.WriteLine(d>=d && e != c);
            Console.ReadLine();
            int x = 20; int y = 13; int z = 42;
            Console.WriteLine(x > y && z == y && z < x);
            Console.ReadLine();
            Console.WriteLine(z>x && y<x);
            Console.ReadLine();
            Console.WriteLine(x != z || y <= z);
            Console.ReadLine();


            











        }
    }
}
