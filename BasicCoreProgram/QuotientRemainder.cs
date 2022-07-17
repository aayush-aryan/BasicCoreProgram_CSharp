using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class QuotientRemainder
    {
        public static void ComputeQuotientRemainder()
        {
            Console.WriteLine("Enter the dividend :");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor :");
            int divisor = int.Parse(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % quotient;

            Console.WriteLine("quotient :" + quotient);
            Console.WriteLine("remainder :" + remainder);

        }
    }
}
