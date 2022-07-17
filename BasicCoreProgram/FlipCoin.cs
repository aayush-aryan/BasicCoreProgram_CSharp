using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    class FlipCoin
    {
        public static void FlippingCoin()
        {
            int tails = 0, heads = 0;

            Console.WriteLine("Enter Number Of Times You want to flip the coin");
            int coinFlipNumber = Convert.ToInt32(Console.ReadLine());

            for (int Index = 0; Index < coinFlipNumber; Index++)
            {
                Random random = new Random();
                int HTCheck = random.Next(0, 2);
                if (HTCheck < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }

            }
            double headPerCent = ((heads * 100) / coinFlipNumber);
            double tailPerCent = ((tails * 100) / coinFlipNumber);
            Console.WriteLine("Percentage Of Head : " + headPerCent);
            Console.WriteLine("Percentage Of Tail :" + tailPerCent);
        }

    }
}
