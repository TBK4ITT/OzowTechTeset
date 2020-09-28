using System;
using System.Text;
using System.Threading;

namespace OzowQuestionTwo
{
    
    public class Program
    {
        private static GameOfLife gameOfLife;
        public static void Main()
        {
            gameOfLife = new GameOfLife();
            Console.WriteLine("Please enter the number of rows: ");
            var gameRows = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the number of columns: ");
            var gameColumns = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the number of generations: ");
            var gameGenerations = Convert.ToInt16(Console.ReadLine());

            var gameArray = FirstGeneration(gameRows, gameColumns);
            Console.Clear();

            while (gameGenerations > 0)
            {
                DisplayNextGeneration(gameArray);
                gameArray = GetNextGeneration(gameArray);
                gameGenerations--;
            }
            Console.WriteLine("Game Over!");
            Console.ReadLine();
        }

        private static Status[,] GetNextGeneration(Status[,] arr)
        {
            return gameOfLife.CreateNextGeneration(arr);
        }

        private static void DisplayNextGeneration(Status[,] arr)
        {
            var displayResult = gameOfLife.FormatForDisplay(arr);
            
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(displayResult.ToString());
            Thread.Sleep(1000);
        }

        private static Status[,] FirstGeneration(int rows, int columns)
        {
            return gameOfLife.CreateFirstGeneration(rows, columns);
        } 
    }
}
