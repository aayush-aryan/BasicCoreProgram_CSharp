using System;

namespace BasicCoreProgram
{
    class Program
    {
        public static int choice;

       
        static void Main(string[] args)
        {
            //int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoin.FlippingCoin();
                    break;
                default:
                    Console.WriteLine( "Invalid Choice");
                    break;




            }
            
        }
    }
}
