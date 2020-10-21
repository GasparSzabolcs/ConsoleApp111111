using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111111
{
    class Program
    {

        static Random r = new Random();
        static void Main(string[] args)
        {
            var t = new int[10];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(10, 100);
                Console.Write($"{t[i]}, ");
            }


            Console.ReadKey();

        }
    }
}
