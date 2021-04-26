using Calculator.Business.Contract.Math;
using System;
using System.Text.RegularExpressions;

namespace Calculator.Business.Implementation
{
    public class MathOperation : IMathOperation
    {
        private const char COMA = ',';
        private const string PARAMENTER_NUMBER_REGEX_PATTERN = "/^[0-9,]*$/";
        public string Add(string numbers)
        {
            if (CorrectFormatParamenter(numbers))
            {
                var numbersArray = numbers.Split(COMA);
                float result = 0; ;
                foreach (var number in numbersArray)
                {
                    result = result + int.Parse(number);
                }
                return result.ToString();
            }
            throw new ArgumentException(Constants.Exceptions.InvalidNumbersArgument);
        }

        private bool CorrectFormatParamenter(string numbers)
        {
            Regex regex = new Regex(PARAMENTER_NUMBER_REGEX_PATTERN);
            return regex.IsMatch(numbers);
        }
    }
}
