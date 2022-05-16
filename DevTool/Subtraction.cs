using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Substraction : IBasicCalculation
    {
        private double result;
        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            result = numberOne - numberTwo;
            return result;
        }

        public  void Definition()
        {
            Console.WriteLine("Die Subtraktion (von lat. subtrahere „wegziehen“, „entfernen“), ");
            Console.WriteLine("umgangssprachlich auch Minus-Rechnen genannt, ist eine der vier Grundrechenarten ");
            Console.WriteLine("der Arithmetik. Unter der Subtraktion versteht man das Abziehen einer Zahl von");
            Console.WriteLine(" einer anderen. Mathematisch handelt es sich bei der Subtraktion um eine ");
            Console.WriteLine("zweistellige Verknüpfung. Die Subtraktion ist die Umkehroperation der Addition. ");
            Console.WriteLine("Das Rechenzeichen für die Subtraktion ist das Minuszeichen „−“.");
        }
    }
}
