using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Rationals rationals = new Rationals();
            Console.WriteLine(rationals.GetRationalNumber(15));

            Console.WriteLine("-------------------");

            

            Console.ReadLine();
        }
    }
}
