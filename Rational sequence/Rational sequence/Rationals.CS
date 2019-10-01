using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_sequence
{
    // Q all rational numbers (quotients)    //Q={a/b|a∈Z,b∈N}
    public class Rationals : IEnumerable
    {
        int[] array = new int[] { 1, 3, 5, 7, 9 };
        public Rationals()
        {

        }
        
        public string Rational(long n)
        {
            return "Hvad nu?";
        }
        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
