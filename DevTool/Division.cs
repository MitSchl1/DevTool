using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    public class Division : IBasicCalculation
    {
        private double result;

        public double CalcWithTwoPassedValues(double numberOne, double numberTwo)
        {
            result = numberOne / numberTwo;
            return result;
        }

        public  void Definition()
        {
            Console.WriteLine("Die Division ist eine der vier Grundrechenarten der Arithmetik. ");
            Console.WriteLine("Sie ist die Umkehroperation der Multiplikation. Die Division wird umgangssprachlich auch als Teilen bezeichnet. ");
            Console.WriteLine("Ein Dividend wird durch einen Divisor geteilt, das Resultat wird Quotient genannt. ");
            Console.WriteLine("Die schriftliche Division ist die Methode des Teilens mit Stift und Papier. ");
            Console.WriteLine("Sie wird im Schulunterricht der Grundschule gelehrt. Als Rechenzeichen für die Division werden der Doppelpunkt '':'' ");
            Console.WriteLine(" (Rechnen mit Zahlen, in der Mathematik wird das Zeichen in anderer Bedeutung verwendet), ");
            Console.WriteLine("das Obelus-Zeichen, der Schrägstrich ''' / ''  und die Bruchstrich-Schreibweise verwendet.");
        }

    }
}
