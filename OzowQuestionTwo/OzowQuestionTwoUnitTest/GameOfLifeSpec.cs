using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzowQuestionTwo;
using System.Runtime.InteropServices.ComTypes;

namespace OzowQuestionTwoUnitTest
{
    [TestClass]
    public class GameOfLifeSpec
    {
        private GameOfLife gameOfLife;

        [TestInitialize]
        public void Init()
        {
            var _gameOfLife = new GameOfLife();
            gameOfLife = _gameOfLife;
        }

        [TestMethod]
        public void GivenValidRowAndColumnData_WhenCreatingANewGeneration_ReturnGameOfLifeArray()
        {
            int rows = 10;
            int columns = 20;
            var res = gameOfLife.CreateFirstGeneration(rows, columns);
            Assert.IsNotNull(res);
            Assert.AreEqual(10, res.GetLength(0));
            Assert.AreEqual(20, res.GetLength(1));
        }

        [TestMethod]
        public void GivenInValidRowAndColumnData_WhenCreatingANewGeneration_ReturnGameOfLifeEmptyArray()
        {
            int rows = 0;
            int columns = 0;
            var res = gameOfLife.CreateFirstGeneration(rows, columns);
            Assert.AreEqual(0,res.GetLength(0));
            Assert.AreEqual(0, res.GetLength(1));
        }

        [TestMethod]
        public void GivenValidArray_WhenCreatingTheNextGeneration_ReturnGameOfLifeArray()
        {
            int rows = 10;
            int columns = 20;
            var res = gameOfLife.CreateFirstGeneration(rows, columns);
            Assert.IsNotNull(res);
            Assert.AreEqual(10, res.GetLength(0));
            Assert.AreEqual(20, res.GetLength(1));
        }

        [TestMethod]
        public void GivenInValidArray_WhenCreatingTheNextGeneration_ReturnGameOfLifeEmptyArray()
        {
            int rows = 0;
            int columns = 0;
            var res = gameOfLife.CreateFirstGeneration(rows, columns);
            Assert.AreEqual(0, res.GetLength(0));
            Assert.AreEqual(0, res.GetLength(1));
        }

        [TestMethod]
        public void GivenAValidArray_WhenFormatingForDisplay_ReturnGameOfLifeArray()
        {
            int rows = 10;
            int columns = 20;
            var res = gameOfLife.CreateFirstGeneration(rows, columns);
            var testResult = gameOfLife.FormatForDisplay(res);
            Assert.IsNotNull(testResult);
        }

        [TestMethod]
        public void GivenAnInValidArray_WhenFormatingForDisplay_ReturnGameOfLifeEmptyArray()
        {
            int rows = 0;
            int columns = 0;
            var res = gameOfLife.CreateFirstGeneration(rows, columns);
            var testResult = gameOfLife.FormatForDisplay(res);
            Assert.AreEqual("", testResult.ToString());
        }
    }
}
