using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Log : ICalculation
    {
        private double result;
        public  void CalcWithOnePassedValue(float numberOne)
        {
            result = Math.Log(numberOne);
            Console.WriteLine(" Der Basis e Log fuer " + numberOne + " ist " + result);
        }

        public  void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public  void CalcWithTwoPassedValues(float numberOne, float numberTwo)
        {
            result = Math.Log(numberOne,numberTwo);
            Console.WriteLine(" Der Basis "+ numberTwo + " Log fuer " + numberOne + " ist " + result);
        }

        public  void Definition()
        {
            throw new NotImplementedException();
        }
    }
}
