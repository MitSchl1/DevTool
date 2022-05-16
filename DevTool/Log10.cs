using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Log10 : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Log10(numberOne);
            return result;
        }

        public  void CalcWithoutPassedValues()
        {
            throw new NotImplementedException();
        }

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            throw new NotImplementedException();
        }

        public  void Definition()
        {
            Console.WriteLine("Als Logarithmus (Plural: Logarithmen; von altgriechisch λόγος lógos, „Verständnis, Lehre, Verhältnis“,");
            Console.WriteLine(" und ἀριθμός, arithmós, „Zahl“) einer Zahl bezeichnet man den Exponenten, mit dem eine vorher festgelegte Zahl, ");
            Console.WriteLine("die Basis, potenziert werden muss, um die gegebene Zahl, den Numerus, zu erhalten. ");
            Console.WriteLine("Logarithmen sind nur für positive reelle Zahlen definiert, auch die Basis muss positiv sein. ");
            Console.WriteLine("Der Logarithmus einer positiven reellen Zahl x zur Basis b ist also der Wert des Exponenten. ");
            Console.WriteLine("Mit Logarithmen lassen sich sehr stark wachsende Zahlenreihen übersichtlich darstellen, ");
            Console.WriteLine("da der Logarithmus für große Zahlen viel langsamer steigt als die Zahlen selbst.durch Logarithmieren ");
            Console.WriteLine("kann man eine Multiplikation durch die viel weniger rechenintensive Addition ersetzen. ");
            Console.WriteLine("Auch beschreiben Logarithmen auf mathematisch elegante Weise viele technische Prozesse sowie Phänomene der Natur ");
            Console.WriteLine("wie etwa das Verhalten einer Halbleiter-Diode, die Spirale eines Schneckenhauses ");
            Console.WriteLine("oder die Wahrnehmung unterschiedlicher Lautstärken durch das menschliche Ohr.");
        }
    }
}
