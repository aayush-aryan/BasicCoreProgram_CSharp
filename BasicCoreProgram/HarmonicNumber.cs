using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class HarmonicNumber
    {
        public static void ToPrintNthHarmonicValue()
        {
            double harmonicValue = 0; double numerator = 1.0;
            Console.WriteLine("Enter the Nth harmonic value :");
            int harmonicTerm = Convert.ToInt32(Console.ReadLine());
            for (int index = 1; index <= harmonicTerm; index++)
            {
                harmonicValue = harmonicValue + ((numerator / index));
            }
            Console.WriteLine(harmonicValue);
        }
    }
}
