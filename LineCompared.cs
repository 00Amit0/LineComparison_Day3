using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineCompared
    {
        public static void LineLengthIs()
        {
            double a1, a2, b1, b2, x1, x2, y1, y2;
            a1 = 10d;
            a2 = 12d;
            b1 = 13d;
            b2 = 11d;
            x1 = 12d;
            x2 = 13d;
            y1 = 11d;
            y2 = 10d;
            var Line1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(Line1);
            var Line2 = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
            Console.WriteLine(Line2);
            if (Line1 == Line2)
            {
                Console.WriteLine("Lines are equal");
            }
            else if(Line1 > Line2)
            {
                Console.WriteLine("Line1 is greater");
            }
            else
            {
                Console.WriteLine("Line2 is greater");
            }
        }
    }
}
