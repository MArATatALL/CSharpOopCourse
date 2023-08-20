using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    internal class RangeProgram
    {
        static void Main(string[] args)
        {
            double[] interval1 = new double[2] { 13, 18 };
            double[] interval2 = new double[2] { 9, 12 };

            Range range = new Range(interval1, interval2);

            Console.WriteLine("Интервал - пересечение двух интервалов: " + string.Join(" - ", range.GetIntervalIntersection(interval1, interval2)));

            Console.WriteLine("Интервал - объединение двух интервалов: " + string.Join(" - ", range.GetIntervalUnion(interval1, interval2)));

            Console.WriteLine("Интервал - разность двух интервалов: " + string.Join(" - ", range.GetIntervalDifference(interval1, interval2)));
        }
    }
}