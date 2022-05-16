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
        double CalcWithTwoPassedValues(double numberOne, double numberTwo);

        void CalcWithoutPassedValues();
        double CalcWithOnePassedValue(double numberOne);
    }
}
