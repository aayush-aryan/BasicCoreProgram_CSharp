using System;

namespace BasicCoreProgram
{
    class Program
    {
        public static int choice;

        static void Main(string[] args)
        {
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoin.FlippingCoin();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                default:
                    Console.WriteLine( "Invalid Choice");
                    break;

            }
            
        }
    }
}
