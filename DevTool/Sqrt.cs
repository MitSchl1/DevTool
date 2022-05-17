using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Sqrt : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Sqrt(numberOne);
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
            Console.WriteLine("In der Mathematik versteht man unter Wurzelziehen oder Radizieren ");
            Console.WriteLine("die Bestimmung der Unbekannten x in der Potenz Hierbei ist n  eine natürliche Zahl(meist größer als 1)");
            Console.WriteLine(" und a ein Element aus einem Körper(häufig eine nichtnegative reelle Zahl).");
            Console.WriteLine(" Das Ergebnis des Wurzelziehens bezeichnet man als Wurzel oder Radikal(von lat. radix „Wurzel“). ");
            Console.WriteLine("Das Radizieren ist eine Umkehrung des Potenzierens. Im Fall  n = 2 spricht man von Quadratwurzeln, bei  n = 3 ");
            Console.WriteLine("von Kubikwurzeln. Wurzeln werden mit Hilfe des Wurzelzeichens notiert, ");
            Console.WriteLine("im Beispiel ist  x = n sqrt(a) die Wurzel bzw.das Radikal");
        }
    }
}
