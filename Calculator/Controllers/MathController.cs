using Calculator.Business.Contract.Math;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {


        private readonly IMathOperation _mathOperation;


        public MathController(IMathOperation mathOperation)
        {
            _mathOperation = mathOperation;
        }

        /// <summary>
        /// Sum of numbers
        /// </summary>
        /// <param name="numbers">Numbers separated by ','</param>
        /// <returns>sum of numbers</returns>
        [HttpGet]
        public ActionResult Add(string numbers)
        {
            try
            {

                return Ok(_mathOperation.Add(numbers));

            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
