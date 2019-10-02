using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_sequence
{
    class Rationals
    {
        public Rationals()
        {

        }

      

        public string GetRationalNumber(int nPlace)
        {
            Console.WriteLine("n:" + nPlace);
            var ln = Convert.ToInt32((-1 + Math.Sqrt(1 + 8 * nPlace)) / 2);
            Console.WriteLine("ln: " + ln);
            //finding sn:
            var sn = (ln * (ln + 1)) / 2;
            Console.WriteLine("sn: " + sn);

            //calculating Numerator mn of nPlace:
            var nm = (nPlace - sn) + 1;
            Console.WriteLine("nm: " + nm);

            //calculating Denominator dn of nPlace
            var dn = ln - (nPlace - sn) + 1;
            Console.WriteLine("dn: " + dn);

            return $"{ nm.ToString()}  / {dn.ToString()}";
        }


        //equations for gettet the Rational number given a specific place. 

        //1.  ln = (-1 + √(1 + 8n))/2

        //2.  Line including n starts at sn:
        //        sn = ln(ln + 1)2
        //       e.g.   s17 = (5 · 6)/2 = 15
        //3.  How to find the Numerator and denominator
        //        3A Numerator mn of n:
        //           mn = (n − sn) + 1
        //           e.g.  m17 = (17 − 15) + 1 = 3
        //
        //        3B Denominator dn of n
        //           dn = ln − (n − sn) + 1
        //           e.g.  d17 = 5 − (17 − 15) + 1 = 5 − 2 + 1 = 4

        // Source  
        // https://datsoftlyngby.github.io/soft2019fall/DM/week-37/03-sequences-handouts.pdf   (page 39-40 for example)



    }
}
