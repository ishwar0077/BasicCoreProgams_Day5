// 7. C# Program to Swap Two Numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class SwapTwoNumber
    {
        public static void Swap()
        {
            int a = 10, b = 5;
            Console.WriteLine("Numbers before swap a = {0} and b = {1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Numbers after swap a = {0} and b = {1}", a, b);

        }
    }
}
