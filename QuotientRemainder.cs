// C# Program to Compute Quotient and Remainder
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class QuotientRemainder
    {
        public static void CheckQuotientRemainder()
        {
            int divident = 24, divider = 2;
            int quotient = divident / divider;
            int remainder = divident % divider;
            Console.WriteLine("divident: {0}, divider: {1}", divident, divider);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);

        }
    }
}
