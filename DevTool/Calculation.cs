using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    abstract class Calculation
    {
        private float numberOne;
        private float numberTwo;

        public abstract void Definition();
        public abstract void Calc(float numberOne, float numberTwo);


    }
}
