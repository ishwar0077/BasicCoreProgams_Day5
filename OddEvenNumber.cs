// 8. C# Program to Check Whether a Number is Even or Odd
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class OddEvenNumber
    {
        public static void CheckOddEven()
        {
            Console.WriteLine("Enter the number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
