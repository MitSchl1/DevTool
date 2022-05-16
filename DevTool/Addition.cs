using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Addition : IBasicCalculation

    {
        private double result;
        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            result = numberOne + numberTwo;
            return result;
        }

        public void Definition()
        {
            Console.WriteLine("Die Addition (lateinisch additio, von addere „hinzufügen“), ");
            Console.WriteLine("umgangssprachlich auch Plus-Rechnen oder Und-Rechnen genannt, ");
            Console.WriteLine("ist eine der vier Grundrechenarten in der Arithmetik. Die Addition ");
            Console.WriteLine("basiert auf dem Vorgang des Zählens. Deshalb verwendet man für den Vorgang,");
            Console.WriteLine(" eine Addition auszuführen, neben Addieren auch den Ausdruck Zusammenzählen. ");
            Console.WriteLine("Das Rechenzeichen für die Addition ist das Pluszeichen „+“. ");
            Console.WriteLine("Es wurde 1489 von Johannes Widmann eingeführt. Die Addition bildet zusammen ");
            Console.WriteLine("mit der Subtraktion die Rechenart 1. Stufe, wegen der Rechenzeichen + und - auch Strichrechnung genannt");
               
        }
    }
}
