using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Tan : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Tan(numberOne);
            return result;  
        }

        public  void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            throw new NotImplementedException();
        }

        public  void Definition()
        {
            throw new NotImplementedException();
        }

        public void FibonacciSeries()
        {
            int numberOneFib = 1;
            int numberTwoFib = 0;
            int resultFib;
            for (int x = 1; x < 20; x++)
            {
                resultFib = numberOneFib + numberTwoFib;
                numberTwoFib = numberOneFib;
                numberOneFib = resultFib;
                Console.WriteLine(resultFib);

            }
        }
    }
}
