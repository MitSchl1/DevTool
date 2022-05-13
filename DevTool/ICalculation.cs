using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public interface ICalculation
    {
        public abstract void Definition();
        public abstract void CalcWithTwoPassedValues(float numberOne, float numberTwo);

        public abstract void CalcWithoutPassedValues();
        public abstract void CalcWithOnePassedValue(float numberOne);
    }
}
