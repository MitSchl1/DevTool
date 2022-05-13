using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Cos : IAdvancedCalculation
    {
        private double result;
        public  void CalcWithOnePassedValue(float numberOne)
        {
            result = Math.Cos(numberOne);
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
    }
}
