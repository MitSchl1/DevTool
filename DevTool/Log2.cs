using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Log2 : IAdvancedCalculation
    {
        private double result;
        public  void CalcWithOnePassedValue(float numberOne)
        {
            result = Math.Log2(numberOne);
            Console.WriteLine(" Der Basis 2 Log fuer " + numberOne + " ist " + result);
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
    }
}
