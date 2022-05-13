using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Division : IBasicCalculation
    {
        private float result;

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
