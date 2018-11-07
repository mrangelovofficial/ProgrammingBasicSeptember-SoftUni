using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еxercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dyljina = int.Parse(Console.ReadLine());
            var shirochina = int.Parse(Console.ReadLine());
            var visochina = double.Parse(Console.ReadLine());
            var cena = double.Parse(Console.ReadLine());
            var teglo = double.Parse(Console.ReadLine());

            var dyljinanamrejata = 0.0;
            var cenanamrejata = 0.0;
            var ploshtnamrejata = 0.0;
            var teglonamrejata = 0.0;


            dyljinanamrejata = 2 * dyljina + 2 * shirochina;
            cenanamrejata = dyljinanamrejata * cena;
            ploshtnamrejata = dyljinanamrejata * visochina;
            teglonamrejata = ploshtnamrejata * teglo;

            Console.WriteLine(dyljinanamrejata);
            Console.WriteLine("{0:f2}",cenanamrejata);
            Console.WriteLine("{0:f3}",teglonamrejata);
        }
    }
}
