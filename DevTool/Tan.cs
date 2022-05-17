using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Tan : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Tan(numberOne);
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
            Console.WriteLine("Tangens und Kotangens sind trigonometrische Funktionen ");
            Console.WriteLine("und spielen in der Mathematik und ihren Anwendungsgebieten eine herausragende Rolle. ");
            Console.WriteLine("Der Tangens des Winkels x wird mit tan x bezeichnet, der Kotangens des Winkels x mit cot x . ");
            Console.WriteLine("In älterer Literatur findet man auch die Schreibweisen tg x für den Tangens und ctg x für den Kotangens");

        }

        public void FibonacciSeries()
        {
            int numberOneFib = 1;
            int numberTwoFib = 0;
            int resultFib;
            for (int x = 1; x < 20; x++)
            {
                resultFib = numberOneFib + numberTwoFib;
                numberTwoFib = numberOneFib;
                numberOneFib = resultFib;
                Console.WriteLine(resultFib);

            }
        }
    }
}
