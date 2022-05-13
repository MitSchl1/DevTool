using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Log10 : IAdvancedCalculation
    {
        private double result;
        public  void CalcWithOnePassedValue(float numberOne)
        {
            result = Math.Log10(numberOne);
            Console.WriteLine(" Der Basis 10 Log fuer " + numberOne + " ist " + result);
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
