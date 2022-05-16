using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public interface IBasicCalculation
    {
         double CalcWithTwoPassedValues(double numberOne, double numberTwo);
         void Definition();
    }
}
