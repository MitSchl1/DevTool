using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class BasicCalculator 
    {
        public void addCalc(float numberOne, float numberTwo)
        {
            Addition add = new();
            add.CalcWithTwoPassedValues( numberOne, numberTwo);
        }
        public void subCalc(float numberOne, float numberTwo)
        {
            Substraction sub = new();
            sub.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public void multCalc(float numberOne, float numberTwo)
        {
            Multiplication mult = new();
            mult.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public void divCalc(float numberOne, float numberTwo)
        {
            Division div = new();
            div.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
    }
}
