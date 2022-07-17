using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter the year :");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                Console.WriteLine("{0} is a Leap Year :", Year);
            else 
                Console.WriteLine("{0} is not a Leap Year :", Year);
           
        }
    }
}
