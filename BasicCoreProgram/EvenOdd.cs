using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Enter the number :");
            int number = int.Parse(Console.ReadLine());
            if(number%2==0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}
