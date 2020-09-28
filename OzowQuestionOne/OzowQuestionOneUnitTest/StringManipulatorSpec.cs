using Microsoft.VisualStudio.TestTools.UnitTesting;
using OzowQuestionOne;

namespace OzowQuestionOneUnitTest
{
    [TestClass]
    public class StringManipulatorSpec
    {
        private StringManipulator stringManipulator;
        private string validData;
        private string inValidData;

        [TestInitialize]
        public void Init()
        {
            var _stringManipulator = new StringManipulator();
            stringManipulator = _stringManipulator;
            validData = "Hello out there.";
            inValidData = "";
        }

        [TestMethod]
        public void GivenAValidString_WhenOrderingTheString_ReturnAnOrderedString()
        {
            var response = stringManipulator.OrderString(validData);
            Assert.AreEqual("  .Heeehlloorttu", response);
        }

        [TestMethod]
        public void GivenAnEmptyString_WhenOrderingTheString_ReturnAnEmptyString()
        {
            var response = stringManipulator.OrderString(inValidData);
            Assert.AreEqual("", response);
        }

        [TestMethod]
        public void GivenAValidString_WhenRemovingSpacesAndSpecialCharsFromTheString_ReturnStringWithNoSpaces()
        {
            var response = stringManipulator.RemoveSpacesAndSpecialChars(validData);
            Assert.AreEqual("Hellooutthere", response);
        }

        [TestMethod]
        public void GivenAnEmptyString_WhenRemovingSpacesAndSpecialCharsFromTheString_ReturnAnEmptyString()
        {
            var response = stringManipulator.RemoveSpacesAndSpecialChars(inValidData);
            Assert.AreEqual("", response);
        }

        [TestMethod]
        public void GivenAValidString_WhenSettingLowerCaseOnTheString_ReturnStringWithLowerCase()
        {
            var response = stringManipulator.SetLowerCase(validData);
            Assert.AreEqual("hello out there.", response);
        }

        [TestMethod]
        public void GivenAnEmptyString_WhenSettingLowerCaseOnTheString_ReturnAnEmptyString()
        {
            var response = stringManipulator.SetLowerCase(inValidData);
            Assert.AreEqual("", response);
        }
    }
}
