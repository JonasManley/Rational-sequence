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
            foreach (var item in rationals)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
