using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLowerConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a string to convert:");
            string startString = Console.ReadLine();

            Console.WriteLine("Here is your lower case string:");
            Console.WriteLine(ConvertToLower(startString));
            Console.WriteLine("Here is your upper case string:");
            Console.WriteLine(ConvertToUpper(startString));
            Console.WriteLine("Here is your string with case swapped:");
            Console.WriteLine(ConvertCase(startString));
            Console.ReadLine();

        }

        public static string ConvertToLower(string startString)
        {
            string endString = "";
            int asciiConvert;
            char currentCharacter;

            for (int i = 0; i < startString.Length; i++)
            {
                currentCharacter = startString[i];
                asciiConvert = (int)currentCharacter;
                if (asciiConvert < 91 && asciiConvert > 64)
                    asciiConvert += 32;
                currentCharacter = (char)asciiConvert;
                endString += currentCharacter;
            }

            return endString;
        }

        public static string ConvertToUpper(string startString)
        {
            string endString = "";
            int asciiConvert;
            char currentCharacter;

            for (int i = 0; i < startString.Length; i++)
            {
                currentCharacter = startString[i];
                asciiConvert = (int)currentCharacter;
                if (asciiConvert < 123 && asciiConvert > 96)
                    asciiConvert -= 32;
                currentCharacter = (char)asciiConvert;
                endString += currentCharacter;
            }

            return endString;
        }

        public static string ConvertCase(string startString)
        {
            string endString = "";
            int asciiConvert;
            char currentCharacter;

            for (int i = 0; i < startString.Length; i++)
            {
                currentCharacter = startString[i];
                asciiConvert = (int)currentCharacter;
                if (asciiConvert < 123 && asciiConvert > 96)
                    asciiConvert -= 32;
                else if (asciiConvert < 91 && asciiConvert > 64)
                    asciiConvert += 32;
                currentCharacter = (char)asciiConvert;
                endString += currentCharacter;
            }

            return endString;
        }
    }
}
