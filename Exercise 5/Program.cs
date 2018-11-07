using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 3 * n + 6;
            var height = 3 * n + 1;

            var secondwidth = width - n;
            var rowsForJava = height - (n * 2 + 3);
            var rowCounter = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}~ ~ ~",new string(' ',n));
            }

            Console.WriteLine(new string('=', width - 1));

            for (int i = 1; i <= rowsForJava; i++)
            {
                if ((Math.Floor(rowsForJava / 2.0)) == rowCounter)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|", new string('~', (secondwidth - 6) / 2), new string(' ', width - secondwidth - 1));

                }
                else
                {
                    Console.WriteLine("|{0}|{1}|",new string('~',secondwidth - 2),new string(' ',width - secondwidth - 1));
                }
                rowCounter++;
            }





            Console.WriteLine(new string('=', width - 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/",new string(' ',i), new string('@', secondwidth - (i*2) - 2) );
            }
            Console.WriteLine(new string('=',secondwidth));




        }
    }
}
