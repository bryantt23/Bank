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

    }
}
