using System.Runtime.CompilerServices;
using unitTesting;

namespace TestProject1
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            //A. Arrange
            int n1 = 100, n2 = 200;

            //A/ Act

            Calculator obj = new Calculator();
            int actualResult = obj.Add(n1, n2);
            int expectedResult = 300;

            //A. Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSub()
        {
            int n1 = 200, n2 = 100;
            Calculator obj = new Calculator();
            int actualResult = obj.Sub(n1, n2);
            int expectedResult = 100;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMul()
        {
            int n1 = 200, n2 = 5;
            Calculator obj = new Calculator();
            int actualResult = obj.Mul(n1, n2);
            int expectedResult = 1000;
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void TestDiv()
        {
            int n1 = 200, n2 = 5;
            Calculator obj = new Calculator();
            //int actualResult = obj.Mul(n1, n2);
            //int expectedResult = 1000;
            //Assert.AreEqual(expectedResult, actualResult);
            string actualErrMsg=Assert.ThrowsException<MyAppException>(()=>obj.Divide(n1, n2)).Message;
            string expectedErrMsg = "denominator must not be 0";
            Assert.AreEqual(expectedErrMsg, actualErrMsg);  
        }
    
}
}