// See https://aka.ms/new-console-template for more information
using DevTool;
namespace DevTool
{

    internal class Program
{
        static void Main(string[] args)
        {
            AdvancedCalculator advancedCalculator = new ();

            bool userNotFinished = true;
            double[] userNumbers = new double[2];

            Console.WriteLine("Hallo und herzlich Willkommen beim DevTool");
            while (userNotFinished)
            {
                Console.WriteLine("0 fuer Anwendung beenden");
                Console.WriteLine("1 fuer etwas Berechnen");
                Console.WriteLine("2 fuer eine Rechnung erklären lassen");
                int userinput = int.Parse(Console.ReadLine());
                switch (userinput)
                {
                    case 0:
                        userNotFinished = false;
                        break;
                    case 1:
                        calculationPosisibilities();
                        int whichCalcProcess = int.Parse(Console.ReadLine());
                        switch (whichCalcProcess)
                        {
                            case 0:
                                break;
                            case 1:
                                userNumbers = userNumbersforBasicCalc();
                                Console.WriteLine( "Das Ergebnis von " +userNumbers[0] + " + " + userNumbers[1] + " ist " + advancedCalculator.addCalc(userNumbers[0], userNumbers[1]));
        
                                break;
                            case 2:
                                userNumbers = userNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " - " + userNumbers[1] + " ist " + advancedCalculator.subCalc(userNumbers[0], userNumbers[1]));
                                break;
                            case 3:
                                userNumbers = userNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " * " + userNumbers[1] + " ist " + advancedCalculator.multCalc(userNumbers[0], userNumbers[1]));
                                break;
                            case 4:
                                userNumbers = userNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " / " + userNumbers[1] + " ist " + advancedCalculator.divCalc(userNumbers[0], userNumbers[1]));
                                break;
                            default:
                                Console.WriteLine("nicht vorhanden");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Derzeit nicht verfügbar");
                        break;
                    default:
                        Console.WriteLine("Bitte eine Zahl zwischen 0 und 2 eingeben");
                        break;
                }

            }
        }
 static double[] userNumbersforBasicCalc()
{
    double[] userNumbers = new double[2];
    Console.WriteLine("Bitte erste Zahl eingeben");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Bitte zweite Zahl eingeben");
    int secondNumber = int.Parse(Console.ReadLine());

    userNumbers[0] = firstNumber;
    userNumbers[1] = secondNumber;

    return userNumbers;
}

static void calculationPosisibilities()
{
    Console.WriteLine("0 fuer zurueck zum Menu");
    Console.WriteLine("1 fuer Addition");
    Console.WriteLine("2 fuer Subtraktion");
    Console.WriteLine("3 fuer Multiplikation");
    Console.WriteLine("4 fuer Division");

}

}
}