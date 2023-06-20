using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CalculatorController
    {
        private readonly ICalculator _calculator;
        private readonly string _calculatorType;

        public CalculatorController(ICalculator calculator, string calculatorType)
        {
            _calculator = calculator;
            _calculatorType = calculatorType;
        }

        public void Calculate(int a, int b)
        {
            int result = 0;

            if (_calculatorType == "+")
            {
                result = _calculator.Add(a, b);
            }
            else if (_calculatorType == "-")
            {
                result = _calculator.Subtract(a, b);
            }
            else
            {
                Console.WriteLine("Invalid calculator type.");
                return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
