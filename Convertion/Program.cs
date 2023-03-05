using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                const double CM_PER_INCH = 2.54;
                const int INCH_PER_YARD = 36;
                const int INCH_PER_FOOT = 12;

                Console.WriteLine("Enter a length in centimeters:");
                double cm = double.Parse(Console.ReadLine());

                // Convert cm to inches and round to nearest inch
                int inches = (int)Math.Round(cm / CM_PER_INCH);

                // Convert inches to yards, feet, and remaining inches
                int yards = inches / INCH_PER_YARD;
                int feet = (inches % INCH_PER_YARD) / INCH_PER_FOOT;
                int remainingInches = inches % INCH_PER_FOOT;

                // Output result
                Console.WriteLine($"{yards} yards, {feet} feet, {remainingInches} inches");
            }
    }
}
