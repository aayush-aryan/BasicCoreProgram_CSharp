using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class SwapTwoNumbers
    {
        public static void NumberSwapping()
        {
            Console.WriteLine("Enter the number1 :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2 :");
            int number2 = int.Parse(Console.ReadLine());

            number1 = (number1 * number2);
            number2 = number1 / number2;
            number1 = number1 / number2;

            Console.WriteLine("number1 :" + number1);
            Console.WriteLine("number2 :" + number2);


        }

    }
}
