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
        private Acos acos = new();
        private Acosh acosh = new();
        private Asin asin = new();
        private Asinh asinh = new();
        private Atan atan = new();
        private Atanh atanh = new();
        private Cosh cosh = new();
        private Sinh sinh = new();
        private Tanh tanh = new();
        private Sqrt sqrt = new();
        private Exp exp = new();
        private Pow pow = new();


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
        public double AcosCalc(double numberOne)
        {
            return acos.CalcWithOnePassedValue(numberOne);
        }
        public double AsinCalc(double numberOne)
        {
            return asin.CalcWithOnePassedValue(numberOne);
        }
        public double AtanCalc(double numberOne)
        {
            return atan.CalcWithOnePassedValue(numberOne);
        }
        public double TanhCalc(double numberOne)
        {
            return tanh.CalcWithOnePassedValue(numberOne);
        }
        public double CoshCalc(double numberOne)
        {
            return cosh.CalcWithOnePassedValue(numberOne);
        }
        public double SinhCalc(double numberOne)
        {
            return sinh.CalcWithOnePassedValue(numberOne);
        }
        public double AcosHCalc(double numberOne)
        {
            return acosh.CalcWithOnePassedValue(numberOne);
        }
        public double AsinhCalc(double numberOne)
        {
            return asinh.CalcWithOnePassedValue(numberOne);
        }
        public double AtanhCalc(double numberOne)
        {
            return atanh.CalcWithOnePassedValue(numberOne);
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
        public double SqrtCalc(double numberOne)
        {
            return sqrt.CalcWithOnePassedValue(numberOne);
        }
        public double PowCalc(double numberOne, double numberTwo)
        {
            return pow.CalcWithTwoPassedValues(numberOne, numberTwo);
        }
        public double ExpCalc(double numberOne)
        {
            return exp.CalcWithOnePassedValue(numberOne);
        }
    }
}
