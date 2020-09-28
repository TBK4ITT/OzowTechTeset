using System.Text;

namespace OzowQuestionTwo
{
    public interface IGameOfLife
    {
        Status[,] CreateFirstGeneration(int rows, int columns);
        Status[,] CreateNextGeneration(Status[,] arr);
        StringBuilder FormatForDisplay(Status[,] arr);
    }
}