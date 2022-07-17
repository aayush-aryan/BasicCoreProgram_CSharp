using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class PowerOFTwo
    {
        public static void PrintTableOFTwo()
        {
            int num = 1;
            Console.WriteLine("Enter A number less than 31 :");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table Of power of Two are :");
            for (int index = 0; index < number; index++)
            {
                num = (num * 2);
                Console.WriteLine(num);
            }
        }
    }
}
