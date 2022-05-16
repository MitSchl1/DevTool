using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Division : IBasicCalculation
    {
        private double result;

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            result = numberOne / numberTwo;
            return result;
        }

        public  void Definition()
        {
            throw new NotImplementedException();
        }

    }
}
