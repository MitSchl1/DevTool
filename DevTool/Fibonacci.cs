using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Fibonacci : IAdvancedCalculation
    {
        private int result;
        private int numberOneFib = 1;
        private int numberTwoFib = 0;
        public void CalcWithoutPassedValues()
        {
            for (int x = 1; x < 20; x++)
            {
                result = numberOneFib + numberTwoFib;
                numberTwoFib = numberOneFib;
                numberOneFib = result;
                Console.WriteLine(result);

            }
          
        }

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            throw new NotImplementedException();
        }

        public double CalcWithOnePassedValue(double numberOne)
        {
            throw new NotImplementedException();
        }

        public  void Definition()
        {
            Console.WriteLine();
        }
    }
}
