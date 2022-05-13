using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Tan : ICalculation
    {
        private double result;
        public  void CalcWithOnePassedValue(float numberOne)
        {
            result = Math.Tan(numberOne);
            Console.WriteLine(result);
        }

        public  void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public  void CalcWithTwoPassedValues(float numberOne, float numberTwo)
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
