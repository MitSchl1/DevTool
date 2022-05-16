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




        public double addCalc(double numberOne, double numberTwo)
        {
            return add.CalcWithTwoPassedValues( numberOne, numberTwo);
        }
        public double subCalc(double numberOne, double numberTwo)
        {
           return  sub.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public double multCalc(double numberOne, double numberTwo)
        {
            return mult.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public double divCalc(double numberOne, double numberTwo)
        {
            return div.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
    }
}
