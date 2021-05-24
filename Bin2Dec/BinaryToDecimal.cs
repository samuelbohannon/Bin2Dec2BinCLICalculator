using System;
using System.Text.RegularExpressions;


namespace Bin2Dec
{
    class BinaryToDecimal
    {
        public static void ConvertBinaryToDecimalMainLoop()
        {
            var @continue = true;
            while (@continue)
            {
                Console.WriteLine("Enter a binary number: ");
                var binaryNumber = Console.ReadLine().Trim();
                Console.WriteLine(binaryNumber);
                if (ValidateBinary(binaryNumber))
                {
                    double decimalNumber = ConvertBinaryToDecimal(binaryNumber);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(decimalNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (binaryNumber == Convert.ToString('q'))
                    {
                        @continue = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid binary number (ie. 101001) or q to go back to main menu");
                    }
                }
            }

        }

        static double ConvertBinaryToDecimal(string binaryNumber)
        {
            var reversedBinaryNumber = Program.ReverseString(binaryNumber);
            char[] reversedBinaryNumberArray = reversedBinaryNumber.ToCharArray();
            double decimalNumber = 0;
            for (var i = 0; i < reversedBinaryNumberArray.Length; i++)
            {
                int binaryDigit= Convert.ToInt32(reversedBinaryNumberArray[i]) - 48;
                if (binaryDigit == 1)
                {
                    decimalNumber += Math.Pow(2,i); 
                }
            }
            return decimalNumber;
        }

        static bool ValidateBinary(string binaryNumber)
        {
            var isBinaryNumber = Regex.IsMatch(binaryNumber, "^[01]+$");
            if (isBinaryNumber) return true;
            return false;
        }
    }
}
