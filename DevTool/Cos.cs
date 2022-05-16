using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Cos : IAdvancedCalculation
    {
        private double result;
        public  double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Cos(numberOne);
            return result;
        }

        public void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            throw new NotImplementedException();
        }

        public void Definition()
        {
            Console.WriteLine("Sinus- und Kosinusfunktion sind elementare mathematische Funktionen.");
            Console.WriteLine(" Vor Tangens und Kotangens, Sekans und Kosekans bilden sie die wichtigsten trigonometrischen Funktionen. ");
            Console.WriteLine("Sinus und Kosinus werden unter anderem in der Geometrie für Dreiecksberechnungen in der ebenen ");
            Console.WriteLine("und sphärischen Trigonometrie benötigt. Der Kosinus ist das Verhältnis ");
            Console.WriteLine("der Länge der Ankathete (das ist jene Kathete, die einen Schenkel des Winkels bildet) zur Länge der Hypotenuse");
        }
    }
}
