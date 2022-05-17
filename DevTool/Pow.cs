using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Pow : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            throw new NotImplementedException();
        }

        public void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            result = Math.Pow(numberOne,numberTwo);
            return result;
        }

        public void Definition()
        {
            Console.WriteLine("Eine Potenz (von lateinisch potentia ‚Vermögen, Macht‘) ist das Ergebnis des Potenzierens (der Exponentiation), ");
            Console.WriteLine("das wie das Multiplizieren seinem Ursprung nach eine abkürzende Schreibweise für eine wiederholte mathematische ");
            Console.WriteLine("Rechenoperation ist. Wie beim Multiplizieren ein Summand wiederholt addiert wird, so wird beim Potenzieren ein ");
            Console.WriteLine("Faktor wiederholt multipliziert. Dabei heißt die Zahl, die zu multiplizieren ist, Basis. ");
            Console.WriteLine("Wie oft diese Basis als Faktor auftritt, wird durch den Exponenten angegeben.");
        }
    }
}
