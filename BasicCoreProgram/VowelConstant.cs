using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class VowelConstant
    {
        public static void CheckVowelConstant()
        {
            Console.WriteLine("Enter the Alphabet : ");
            string strAlphabet = Console.ReadLine();

            if (strAlphabet.ToUpper() == "A" || strAlphabet.ToUpper() == "E" ||
                strAlphabet.ToUpper() == "I" || strAlphabet.ToUpper() == "O" || strAlphabet.ToUpper() == "U")
            {
                Console.WriteLine(strAlphabet + " is Vowel");
            }
            else
            {
                Console.WriteLine(strAlphabet + "  is Consonants");
            }


        }
    }
}
