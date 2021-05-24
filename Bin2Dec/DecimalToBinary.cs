using System;

namespace Bin2Dec
{
    class DecimalToBinary
    {
        public static void ConvertDecimalToBinaryMainLoop()
        {
            var @continue = true;
            while (@continue)
            {
                Console.WriteLine("Enter a decimal number: ");
                var userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int decimalNumber))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ConvertDecimalToBinary(decimalNumber) + Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (userInput == "q" || userInput == "Q")
                {
                    @continue = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid decimal number (ie. 34) or q to go back to main menu");
                }
            }
        }

        static string ConvertDecimalToBinary(int decimalNumber)
        {
            string binaryNumber = String.Empty;
            while (decimalNumber != 0)
            {
                var remainder = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binaryNumber += remainder;
            }
            string reversedBinaryNumber = Program.ReverseString(binaryNumber);
            string parsedReversedBinaryNumber = ParseSpaceIntoBinaryNumber(reversedBinaryNumber);
            return parsedReversedBinaryNumber;
        }

        static string ParseSpaceIntoBinaryNumber(string str)
        {
            int pointerIndex = 4;
            while (pointerIndex < str.Length)
            {
                str = str.Insert(pointerIndex, " ");
                pointerIndex += 5;
            }
            return str;
        }
    }
}
