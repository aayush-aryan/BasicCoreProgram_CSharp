using System;

namespace BasicCoreProgram
{
    class Program
    {
        public static int choice;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Choice :");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoin.FlippingCoin();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOFTwo.PrintTableOFTwo();
                    break;
                case 4:
                    HarmonicNumber.ToPrintNthHarmonicValue();
                    break;
                case 5:
                    PrimeFactors.ComputingPrimeFactors();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

        }
    }
}
