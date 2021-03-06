using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Tanh : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Tanh(numberOne);
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
            Console.WriteLine("Die Hyperbelfunktionen sind die korrespondierenden Funktionen der trigonometrischen Funktionen");
            Console.WriteLine(" (die auch als Winkel- oder Kreisfunktionen bezeichnet werden), ");
            Console.WriteLine("allerdings nicht am Einheitskreis , sondern an der Einheitshyperbel ");
            Console.WriteLine("Tanh gibt den Hyperbeltangens des angegebenen Winkels zurück.");
            Console.WriteLine("Hinweise:");
            Console.WriteLine("Multiplizieren Sie den Rückgabewert um  PI / 180, um von Grad in Radien zu konvertieren.");
            Console.WriteLine("Diese Methode ruft die zugrunde liegende C - Laufzeit auf, und der genaue Ergebnis - ");
            Console.WriteLine("oder gültige Eingabebereich kann sich zwischen verschiedenen Betriebssystemen oder Architekturen unterscheiden.");
        }
    }
}
