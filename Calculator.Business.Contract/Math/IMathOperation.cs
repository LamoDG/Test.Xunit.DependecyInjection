using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Business.Contract.Math
{
    public interface IMathOperation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numbers">Numbers separated by ','</param>
        /// <returns>Sum of numbers</returns>
        string Add(string numbers);
    }
}
