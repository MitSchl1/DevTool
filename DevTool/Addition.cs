using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Addition : Calculation

    {
        private float result;
        public override void Calc(float numberOne, float numberTwo)
        {
            result = numberOne + numberTwo;
            Console.WriteLine(result);
        }

        public override void Definition()
        {
            throw new NotImplementedException();
        }
    }
}
