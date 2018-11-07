using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еxercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var kgDomati = double.Parse(Console.ReadLine());
            var brkasetki = int.Parse(Console.ReadLine());
            var brburkani = int.Parse(Console.ReadLine());

            var obshtoKgLutenica = kgDomati / 5;
            var burkani = obshtoKgLutenica / 0.535;
            var kasetki = burkani / brburkani;

            Console.WriteLine("Total lutenica: {0} kilograms.",Math.Floor(obshtoKgLutenica));
            if(kasetki > brkasetki)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(kasetki - brkasetki));
                Console.WriteLine("{0} jars left.", Math.Floor(burkani - (brkasetki * brburkani)));
            }else
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(brkasetki - kasetki));
                Console.WriteLine("{0} more jars needed.", Math.Floor((brkasetki * brburkani) - burkani));

            }
        }
    }
}
