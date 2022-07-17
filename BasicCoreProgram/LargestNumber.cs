using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class LargestNumber
    {
        public static void ComputingLargestNumber()
        {
            Console.WriteLine("Enter the number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int maxNumber = number1;
            if (maxNumber < number2)
            {
                maxNumber = number2;
            }
            if (maxNumber < number3)
            {
                maxNumber = number3;
            }
            Console.WriteLine(maxNumber);

        }
    }
}
