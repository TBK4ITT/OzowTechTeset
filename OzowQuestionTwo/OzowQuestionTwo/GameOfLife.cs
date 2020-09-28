using System.Security.Cryptography;
using System.Text;

namespace OzowQuestionTwo
{
    public class GameOfLife : IGameOfLife
    {
        public Status[,] CreateFirstGeneration(int rows, int columns)
        {
            var gameFirst = new Status[rows, columns];

            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    gameFirst[row, column] = (Status)RandomNumberGenerator.GetInt32(0, 2);
                }
            }
            return gameFirst;
        }

        public Status[,] CreateNextGeneration(Status[,] arr)
        {
            var rows = arr.GetLength(0);
            var columns = arr.GetLength(1);
            var nextGenerationArr = new Status[rows, columns];

            for (var row = 1; row < rows - 1; row++)
                for (var column = 1; column < columns - 1; column++)
                {
                    var aliveNeighbors = 0;
                    for (var i = -1; i <= 1; i++)
                    {
                        for (var j = -1; j <= 1; j++)
                        {
                            aliveNeighbors += arr[row + i, column + j] == Status.Alive ? 1 : 0;
                        }
                    }

                    var currentCell = arr[row, column];
                    aliveNeighbors -= currentCell == Status.Alive ? 1 : 0;

                    if (currentCell == Status.Alive && aliveNeighbors < 2 || aliveNeighbors > 3)
                    {
                        nextGenerationArr[row, column] = Status.Dead;
                    }
                    else if (currentCell == Status.Dead && aliveNeighbors == 3)
                    {
                        nextGenerationArr[row, column] = Status.Alive;
                    }
                    else
                    {
                        nextGenerationArr[row, column] = currentCell;
                    }
                }
            return nextGenerationArr;
        }

        public StringBuilder FormatForDisplay(Status[,] arr)
        {
            var displayResult = new StringBuilder();
            for (var row = 0; row < arr.GetLength(0); row++)
            {
                for (var column = 0; column < arr.GetLength(1); column++)
                {
                    var value = arr[row, column];
                    displayResult.Append(value == Status.Alive ? "1" : "0");
                }
                displayResult.Append("\n");
            }
            return displayResult;
        }
    }

    public enum Status {
        Dead,
        Alive
    }
}