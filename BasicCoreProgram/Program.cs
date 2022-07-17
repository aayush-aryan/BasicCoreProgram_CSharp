﻿using System;

namespace BasicCoreProgram
{
    class Program
    {
        public static int choice;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Choice : \nFlipCoin: 1\nLeapyear : 2\nPowerOFTwo: 3\nHarmonicNumber: " +
                "4\nPrimeFactors :5\nQuotientsRemainder :6" + "\nSwapTwoNumbers :7\nEvenOdd :8\nVowelConsonant :9" +
                "\nLargestNumber :10");
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
                case 6:
                    QuotientRemainder.ComputeQuotientRemainder();
                    break;
                case 7:
                    SwapTwoNumbers.NumberSwapping();
                    break;
                case 8:
                    EvenOdd.CheckEvenOdd();
                    break;
                case 9:
                    VowelConstant.CheckVowelConstant();
                    break;
                case 10:
                    LargestNumber.ComputingLargestNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

        }
    }
}
