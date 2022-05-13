using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public interface IAdvancedCalculation
    {
        void Definition();
        void CalcWithTwoPassedValues(float numberOne, float numberTwo);

        void CalcWithoutPassedValues();
        void CalcWithOnePassedValue(float numberOne);
    }
}
