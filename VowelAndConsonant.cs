// 9. C# Program to Check Whether an Alphabet is Vowel or Consonant
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public  class VowelAndConsonant
    {
        public static void CheckType()
        {
            Console.WriteLine("Enter the character: ");
            char ch = Convert.ToChar (Console.ReadLine());
            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Character is Vowel" + ch);

            }
            else
            {
                Console.WriteLine("Character is not Vowel" + ch);
            }
        }
    }
}
