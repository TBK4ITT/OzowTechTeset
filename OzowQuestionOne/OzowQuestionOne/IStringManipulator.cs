namespace OzowQuestionOne
{
    internal interface IStringManipulator
    {
        string OrderString(string input);
        string RemoveSpacesAndSpecialChars(string input);
        string SetLowerCase(string input);
    }
}