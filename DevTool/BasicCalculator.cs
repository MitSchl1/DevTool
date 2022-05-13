using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class BasicCalculator 
    {
        private Addition add = new ();
        private Substraction sub = new();
        private Multiplication mult = new();
        private Division div = new();


        public void addCalc(float numberOne, float numberTwo)
        {
            add.CalcWithTwoPassedValues( numberOne, numberTwo);
        }
        public void subCalc(float numberOne, float numberTwo)
        {
            sub.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public void multCalc(float numberOne, float numberTwo)
        {
            mult.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public void divCalc(float numberOne, float numberTwo)
        {
            div.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
    }
}
