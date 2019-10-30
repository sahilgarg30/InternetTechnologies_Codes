using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int.TryParse(s1, out a);
            int.TryParse(s2, out b);
            Console.WriteLine("Sum : {0} \t Difference : {1} \t Product : {2} \t Division : {3} \t Remainder : {4}", a + b, a - b, a * b, a / b, a % b);
            Console.Read();
        }
    }
}
