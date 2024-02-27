using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("digite um numero:");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) { Console.WriteLine("seu numero é par"); }
            else { Console.WriteLine("seu numero é impar"); }
        }
    }
}
