using Calculator.Business.Contract.Math;
using Xunit;

namespace Calculator.Test
{
    public class MathOperationTest
    {
        private readonly IMathOperation _mathOperation;


        public MathOperationTest(IMathOperation mathOperation)
        {
            _mathOperation = mathOperation;
        }

        [Fact]
        public void Should_Receive_Two_Numbers_And_Return_Sum()
        {
            Assert.Equal("4", _mathOperation.Add("2,2"));
        }
    }
}
