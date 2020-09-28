using System.Linq;
using System.Text.RegularExpressions;

namespace OzowQuestionOne
{
    public class StringManipulator : IStringManipulator
    {
        public string OrderString(string input)
        {
            if(input != string.Empty)
            {
                return string.Concat(input.OrderBy(s => s));
            }
            else
            {
                return input;
            } 
        }

        public string RemoveSpacesAndSpecialChars(string input)
        {
            if (input != string.Empty)
            {
                return Regex.Replace(input, @"[^a-zA-Z]", string.Empty);
            }
            else
            {
                return input;
            }
        }

        public string RemoveSpecialChars(string input)
        {
            if (input != string.Empty)
            {
                return input.Replace(" ", string.Empty);
            }
            else
            {
                return input;
            }
        }

        public string SetLowerCase(string input)
        {
            if (input != string.Empty)
            {
                return input.ToLower();
            }
            else
            {
                return input;
            }
        }
    }
}