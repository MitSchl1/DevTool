using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Asin : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Asin(numberOne);
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
            Console.WriteLine("Die Arkusfunktionen sind die Umkehrfunktionen der trigonometrischen Winkelfunktionen. ");
            Console.WriteLine("Sie werden verwendet, wenn man aus einer gegebenen Strecke, den zugrundeliegenden Winkel ausrechnen will. ");
            Console.WriteLine("Bei den Arkusfunktionen erfolgt eine Vertauschung von unabhängiger ");
            Console.WriteLine("und abhängiger Variable gegenüber den trigonometrischen Winkelfunktionen. ");
            Console.WriteLine("Asin gibt einen Winkel zurück, dessen Sinus die angegebene Zahl ist.");
            Console.WriteLine("Hinweise:");
            Console.WriteLine("Multiplizieren Sie den Rückgabewert um 180 / PI, um von Radien in Grad zu konvertieren.");
            Console.WriteLine("Diese Methode ruft die zugrunde liegende C - Laufzeit auf, und der genaue Ergebnis - ");
            Console.WriteLine("oder gültige Eingabebereich kann sich zwischen verschiedenen Betriebssystemen oder Architekturen unterscheiden.");
        }
    }
}

