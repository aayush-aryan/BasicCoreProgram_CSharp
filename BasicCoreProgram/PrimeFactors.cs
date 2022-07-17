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

            for(int i = 2; i <= Number / 2; i++)
            {
                while (Number % i == 0)
                {
                    Console.WriteLine(i);
                    Number = Number / i;
                }
            }
            if (Number > 2)
            {
                Console.WriteLine(Number);
            }
        }
    }
}
