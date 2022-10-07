// 10. C# Program to Find the Largest Among Three Numbers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public static class LargestNumber
    {
        public static void CheckLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Entet the first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entet the Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entet the third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("First number is greatest among them");
                }
                else
                {
                    Console.WriteLine("third number is greatest among them");

                }
            }
            else if(num2 > num3)
            {
                Console.WriteLine("second number is greatest among them");
            }
            else
            {
                Console.WriteLine("third number is greatest among them");
            }
        }
    }
}
