using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class AdvancedCalculator : BasicCalculator
    {
        private Sin sin = new();
        private Cos cos = new();
        private Tan tan = new ();
        private Log log = new ();
        private Log10 log10 = new ();  
        private Log2 log2 = new ();

        public double SinCalc(double numberOne)
        {
           return sin.CalcWithOnePassedValue(numberOne);
        }
        public double CosCalc(double numberOne)
        {
            return cos.CalcWithOnePassedValue(numberOne);
        }
        public double TanCalc(double numberOne)
        {
            return tan.CalcWithOnePassedValue(numberOne);
        }
        public double Log10Calc(double numberOne)
        {
            return log10.CalcWithOnePassedValue(numberOne);
        }
        public double Log2Calc(double numberOne)
        {
            return log2.CalcWithOnePassedValue(numberOne);
        }
        public double LogECalc(double numberOne)
        {
            return log.CalcWithOnePassedValue(numberOne);
        }
        public double LogCalcToAnyBase(double numberOne, double numberTwo)
        {
            return log.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
    }
}
