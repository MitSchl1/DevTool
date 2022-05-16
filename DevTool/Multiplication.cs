using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Multiplication : IBasicCalculation
    {
        private double result;
        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            result = numberOne * numberTwo;
            return result;
        }

        public  void Definition()
        {
            Console.WriteLine("Die Multiplikation (lateinisch multiplicatio, von multiplicare ‚vervielfachen‘, auch Malnehmen genannt) ");
            Console.WriteLine("ist eine der vier Grundrechenarten in der Arithmetik. Ihre Umkehroperation ist die Division (das Teilen). ");
            Console.WriteLine("Das Rechenzeichen für die Multiplikation ist das Malzeichen „·“ bzw. „×“");
        }
    }
}
