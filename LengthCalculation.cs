using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LengthCalculation
    {
        public static void LineLength()
        {
            double x1, x2, y1, y2;
            x1 = 12d;
            x2 = 13d;
            y1 = 11d;
            y2 = 10d;
            var Line = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(Line);
        }
        

    }
}
