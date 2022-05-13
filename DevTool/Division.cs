using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Division : ICalculation
    {
        private float result;
        public void CalcWithOnePassedValue(float numberOne)
        {
            throw new NotImplementedException();
        }

        public void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public void CalcWithTwoPassedValues(float numberOne, float numberTwo)
        {
            result = numberOne / numberTwo;
            Console.WriteLine(result);
        }

        public  void Definition()
        {
            throw new NotImplementedException();
        }

    }
}
