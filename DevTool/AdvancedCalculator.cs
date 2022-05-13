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

        public void SinCalc(float numberOne)
        {
            sin.CalcWithOnePassedValue(numberOne);
        }
        public void CosCalc(float numberOne)
        {
            cos.CalcWithOnePassedValue(numberOne);
        }
        public void TanCalc(float numberOne)
        {
            tan.CalcWithOnePassedValue(numberOne);
        }
        public void Log10Calc(float numberOne)
        {
            log10.CalcWithOnePassedValue(numberOne);
        }
        public void Log2Calc(float numberOne)
        {
            log2.CalcWithOnePassedValue(numberOne);
        }
        public void LogECalc(float numberOne)
        {
            log.CalcWithOnePassedValue(numberOne);
        }
        public void LogCalcToAnyBase(float numberOne, float numberTwo)
        {
            log.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
    }
}
