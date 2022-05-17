using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool
{
    internal class Exp : IAdvancedCalculation
    {
        private double result;
        public double CalcWithOnePassedValue(double numberOne)
        {
            result = Math.Exp(numberOne);
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
            Console.WriteLine("In der Mathematik bezeichnet man als Exponentialfunktion eine Funktion der Form x->a^x ");
            Console.WriteLine("mit einer reellen Zahl a > 0 und  a ungleich 1 als Basis (Grundzahl). In der gebräuchlichsten Form sind ");
            Console.WriteLine("dabei für den Exponenten x die reellen Zahlen zugelassen. Im Gegensatz zu den Potenzfunktionen, ");
            Console.WriteLine("bei denen die Basis die unabhängige Größe (Variable) und der Exponent fest vorgegeben ist, ist bei Exponentialfunktionen ");
            Console.WriteLine("der Exponent (auch Hochzahl) des Potenzausdrucks die Variable und die Basis fest vorgegeben. ");
            Console.WriteLine("Darauf bezieht sich auch die Namensgebung. Exponentialfunktionen haben in den Naturwissenschaften, ");
            Console.WriteLine("z. B. bei der mathematischen Beschreibung von Wachstumsvorgängen, eine herausragende Bedeutung. ");
            Console.WriteLine("Als natürliche Exponentialfunktion oder e-Funktion bezeichnet man die Exponentialfunktion e^x");
            Console.WriteLine(" mit der eulerschen Zahl e=2,718281828459 als Basis; gebräuchlich hierfür ist auch die Schreibweise x->exp(x) . ");
            Console.WriteLine("Diese Funktion hat gegenüber den anderen Exponentialfunktionen besondere Eigenschaften. Unter Verwendung des natürlichen ");
            Console.WriteLine("Logarithmus lässt sich mit der Gleichung a^x = e^ x*ln*a jede Exponentialfunktion auf eine solche zur Basis e zurückführen");
        }
    }
}
