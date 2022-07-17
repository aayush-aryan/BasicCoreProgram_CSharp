using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class PrimeFactors
    {
        
        public static void ComputingPrimeFactors(){
            Console.WriteLine("Enter the Number to calculate Prime Factors:");
            int Number = int.Parse(Console.ReadLine());

            for(int index = 2; index <= Number / 2; index++)
            {
                while (Number % index == 0)
                {
                    Console.WriteLine(index);
                    Number = Number / index;
                }
            }
            if (Number > 2)
            {
                Console.WriteLine(Number);
            }
        }
    }
}
