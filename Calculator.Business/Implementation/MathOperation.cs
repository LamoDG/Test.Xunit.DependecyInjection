using Calculator.Business.Contract.Math;

namespace Calculator.Business.Implementation
{
    public class MathOperation : IMathOperation
    {
        private char COMA = ',';

        public string Add(string numbers)
        {

            var numbersArray = numbers.Split(COMA);
            float result = 0; ;
            foreach (var number in numbersArray)
            {
                result = result + int.Parse(number);
            }

            return result.ToString();

        }
    }
}
