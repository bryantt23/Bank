using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Empty_String_Returns_Zero()
        {
            //Arrange
            int expected = 0;

            //Act
            int actual = Calculator.Calculator.Add("");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Single_Number_Zero_Returns_Its_Value()
        {
            //Arrange
            int expected = 0;

            //Act
            int actual = Calculator.Calculator.Add("0");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Single_Number_One_Returns_Its_Value()
        {
            //Arrange
            int expected = 1;

            //Act
            int actual = Calculator.Calculator.Add("1");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Single_Number_FiveHundredSeventyFour_Returns_Its_Value()
        {
            //Arrange
            int expected = 574;

            //Act
            int actual = Calculator.Calculator.Add("574");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Two_Comma_Separated_Numbers_Returns_Their_Sum()
        {
            //Arrange
            int expected = 3;

            //Act
            int actual = Calculator.Calculator.Add("1,2");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Three_Comma_Separated_Numbers_Returns_Their_Sum()
        {
            //Arrange
            int expected = 321;

            //Act
            int actual = Calculator.Calculator.Add("1,20,300");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Three_Comma_Separated_And_NewLineSeparated_Numbers_Returns_Their_Sum()
        {
            //Arrange
            int expected = 321;

            //Act
            int actual = Calculator.Calculator.Add("1,20\n300");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Three_NewLineSeparated_Numbers_Returns_Their_Sum()
        {
            //Arrange
            int expected = 1015;

            //Act
            int actual = Calculator.Calculator.Add("500\n0\n515");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
