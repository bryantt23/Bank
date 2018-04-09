using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void Support_Custom_Delimiter_And_Return_Proper_Sum()
        {
            //Arrange
            int expected = 3;

            //Act
            int actual = Calculator.Calculator.Add("//;\n1;2");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Support_Custom_Delimiter_Asterisk_And_Return_Proper_Sum()
        {
            //Arrange
            int expected = 26;

            //Act
            int actual = Calculator.Calculator.Add("//*\n1*2,14\n9");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Throw_Exception_For_Negative_Numbers()
        {
            try
            {
                Calculator.Calculator.Add("-1,2,-3");

                // Test fails if it makes it this far
                Assert.Fail("Expected exception was not thrown.");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Negatives not allowed: -1, -3", ex.Message);
            }
        }

        [TestMethod]
        public void Ignore_Numbers_Larger_Than_1000_Return_Proper_Sum()
        {
            //Arrange
            int expected = 1026;

            //Act
            int actual = Calculator.Calculator.Add("//*\n1111*2000000,14\n12,1000");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delimiter_Can_Be_Of_Any_Length_And_Return_Proper_Sum()
        {
            //Arrange
            int expected = 6;

            //Act
            int actual = Calculator.Calculator.Add("//***\n1***2***3");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Delimiter_With_Large_Numbers_Can_Be_Of_Any_Length_And_Return_Proper_Sum()
        {
            //Arrange
            int expected = 366;

            //Act
            int actual = Calculator.Calculator.Add("//????\n111????222????33");

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
