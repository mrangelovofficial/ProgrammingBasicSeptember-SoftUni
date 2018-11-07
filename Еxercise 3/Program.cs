using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еxercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var teglo = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var km = int.Parse(Console.ReadLine());
            var cena = 0.00;
            var cenaObshto = 0.0;
            var expresscena = 0.0;
            if (teglo < 1)
            {
                cena = 0.03;
            }
            else if (teglo < 10)
            {
                cena = 0.05;
            }else if (teglo < 40)
            {
                cena = 0.10;
            }else if (teglo < 90)
            {
                cena = 0.15;
            }else if (teglo <= 150)
            {
                cena = 0.20;
            }

            if (type == "express")
            {
                if (teglo < 1)
                {
                    expresscena = cena * 0.8;
                }
                else if (teglo < 10)
                {
                    expresscena = cena * 0.4;
                }
                else if (teglo < 40)
                {
                    expresscena = cena * 0.05;
                }
                else if (teglo < 90)
                {
                    expresscena = cena * 0.02;
                }
                else if (teglo <= 150)
                {
                    expresscena = cena * 0.01;
                }
            }

            if(type == "express")
            {
                cenaObshto = cena * km + ((expresscena * teglo) * km);
            }else
            {
                cenaObshto = cena * km;
            }
            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.",teglo,cenaObshto);
        }
    }
}
