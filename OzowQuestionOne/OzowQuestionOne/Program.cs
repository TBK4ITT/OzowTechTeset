using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace OzowQuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your text here: ");
            var readLine = Console.ReadLine();

            Console.WriteLine("Sorted string: " + SortEnteredString(readLine));

            Console.ReadLine();
        }

        public static string SortEnteredString(string input)
        {
            var stringManipulator = new StringManipulator();

            var readLine = stringManipulator.SetLowerCase(input);

            readLine = stringManipulator.RemoveSpacesAndSpecialChars(readLine);

            readLine = stringManipulator.OrderString(readLine);

            return readLine;
        }
    }
}
