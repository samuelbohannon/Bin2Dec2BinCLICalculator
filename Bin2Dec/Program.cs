using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programLoop = true;
            while (programLoop)
            {
                DisplayMenu();
                var userInputForFeature = Console.ReadLine();
                if (userInputForFeature == "a" || userInputForFeature == "A") DecimalToBinary.ConvertDecimalToBinaryMainLoop();
                if (userInputForFeature == "b" || userInputForFeature == "B") BinaryToDecimal.ConvertBinaryToDecimalMainLoop();
                if (userInputForFeature == "q" || userInputForFeature == "Q") programLoop = false;
            }
            Console.WriteLine("Come back soon!");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Would you like to...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t(a) Convert Decimal to Binary");
            Console.WriteLine("\t(b) Convert Binary to Decimal");
            Console.WriteLine("\t(q) Quit");
            Console.Write(" --- ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string ReverseString(string str)
        {
            char[] stringArray = str.ToCharArray();
            string reversedString = String.Empty;
            for (var i = stringArray.Length - 1; i > -1; i--)
            {
                reversedString += stringArray[i];
            }
            return new String(reversedString);
        }
    }
}
