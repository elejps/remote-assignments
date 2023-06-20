using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AdvancedCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            int sum = a ^ b;
            int carry = (a & b) << 1;

            int result = Add(sum, carry);

            return result;
        }

        public int Subtract(int a, int b)
        {
            return Add(a, Add(~b, 1));
        }
    }
}
