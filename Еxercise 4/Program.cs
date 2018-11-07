using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Еxercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var Poor = 0.0;
            var Satisfactory = 0.0;
            var Good = 0.0;
            var VeryGood = 0.0;
            var Excellent = 0.0;

            for (int i = 0; i < n; i++)
            {
                var Mark = double.Parse(Console.ReadLine());
                
                if(Mark <= 22.5)
                {
                    Poor++;
                }else if (Mark <= 40.5)
                {
                    Satisfactory++;
                }else if (Mark <= 58.5)
                {
                    Good++;
                }else if (Mark <= 76.5)
                {
                    VeryGood++;
                }else if (Mark <= 100)
                {
                    Excellent++;
                }
            }
            Poor = (Poor / n) * 100;
            Satisfactory = (Satisfactory / n) * 100;
            Good = (Good / n) * 100;
            VeryGood = (VeryGood / n) * 100;
            Excellent = (Excellent / n) * 100;


            Console.WriteLine("{0:f2}% poor marks",Poor);
            Console.WriteLine("{0:f2}% satisfactory marks", Satisfactory);
            Console.WriteLine("{0:f2}% good marks", Good);
            Console.WriteLine("{0:f2}% very good marks", VeryGood);
            Console.WriteLine("{0:f2}% excellent marks", Excellent);
        }

    }
}
