using unitTesting;
namespace uniTesting2
{
    public class UnitTest1
    {
        //[Fact]
        [Theory]
        [InlineData(100,200)]
       // [InlineData(500,300)]
        //[InlineData(800,800)]
        public void TestAdd(int n1,int n2)
        {

           // int n1 = 100, n2 = 200;

            //A/ Act

            Calculator obj = new Calculator();
            int actualResult = obj.Add(n1, n2);
            int expectedResult = 300;

            //A. Assert

            Assert.Equal(expectedResult, actualResult);
        }
    }
}