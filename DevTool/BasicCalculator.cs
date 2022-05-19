using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class BasicCalculator 
    {
        private Addition add = new();
        private Substraction sub = new();
        private Multiplication mult = new();
        private Division div = new();




        public double AddCalc(double numberOne, double numberTwo)
        {
            return add.CalcWithTwoPassedValues( numberOne, numberTwo);
        }
        public double SubCalc(double numberOne, double numberTwo)
        {
           return  sub.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public double MultCalc(double numberOne, double numberTwo)
        {
            return mult.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public double DivCalc(double numberOne, double numberTwo)
        {
            return div.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
    }
}
