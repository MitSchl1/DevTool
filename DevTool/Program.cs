// See https://aka.ms/new-console-template for more information
using DevTool;
namespace DevTool
{

    internal class Program
    {
        static void Main(string[] args)
        {
            AdvancedCalculator advancedCalculator = new();
            AdvancedDescriptor advancedDescriptor = new ();

            bool userNotFinished = true;
            double[] userNumbers = new double[2];
            double userNumber;

            Console.WriteLine("Hallo und herzlich Willkommen beim DevTool");
            while (userNotFinished)
            {
                Console.WriteLine("0 fuer Anwendung beenden");
                Console.WriteLine("1 fuer etwas Berechnen");
                Console.WriteLine("2 fuer eine Rechnung erklären lassen");
                Console.WriteLine("3 um weitere Tools anzuzeigen");
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
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " + " + userNumbers[1] + " ist " + advancedCalculator.addCalc(userNumbers[0], userNumbers[1]));

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
                            case 5:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Sinus berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Sinus von " + userNumber + " ist " + advancedCalculator.SinCalc(userNumber));
                                break;
                            case 6:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Cosinus berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Cosinus von " + userNumber + " ist " + advancedCalculator.CosCalc(userNumber));
                                break;
                            case 7:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Tangens berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Tangens von " + userNumber + " ist " + advancedCalculator.TanCalc(userNumber));
                                break;
                            case 8:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Logarithums zur Basis 2 berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Logarithums zur Basis 2 von " + userNumber + " ist " + advancedCalculator.Log2Calc(userNumber));
                                break;
                            case 9:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher  der Logarithums zur Basis 10 berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Logarithums zur Basis 10 von " + userNumber + " ist " + advancedCalculator.Log10Calc(userNumber));
                                break;
                            case 10:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Logarithums zur Basis E  berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Logarithums zur Basis E von " + userNumber + " ist " + advancedCalculator.LogECalc(userNumber));
                                break;
                            case 11:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Logarithmus berechnet werden soll");
                                userNumber = double.Parse(Console.ReadLine());
                                Console.WriteLine("Bitte die Basis angeben");
                                double logBase = double.Parse(Console.ReadLine());
                                Console.WriteLine("Der Logarithmus zur Basis " + logBase + " von " + userNumber + " ist " + advancedCalculator.LogCalcToAnyBase(userNumber, logBase));
                                break;
                            default:
                                Console.WriteLine("nicht vorhanden");
                                break;
                        }
                        break;
                    case 2:
                        calculationPosisibilities();
                        int whichDescription = int.Parse(Console.ReadLine());
                        switch (whichDescription)
                        {
                            case 0:
                                break;
                            case 1:
                                advancedDescriptor.AddDescription();
                                break;
                            case 2:
                                advancedDescriptor.SubDescription();
                                break;
                            case 3:
                                advancedDescriptor.MultDescription();
                                break;
                            case 4:
                                advancedDescriptor.DivDescription();
                                break;
                            case 5:
                                advancedDescriptor.SinDescription();
                                break;
                            case 6:
                                advancedDescriptor.CosDescription();
                                break;
                            case 7:
                                advancedDescriptor.TanDescription();
                                break;
                            case 8:
                                advancedDescriptor.LogDescription();
                                break;
                            case 9:
                                advancedDescriptor.LogDescription();
                                break;
                            case 10:
                                advancedDescriptor.LogDescription();
                                break;
                            case 11:
                                advancedDescriptor.LogDescription();
                                break;
                            default:
                                Console.WriteLine("nicht vorhanden");
                                break;
                        }
                        break;
                    case 3:
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
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Bitte zweite Zahl eingeben");
            double secondNumber = double.Parse(Console.ReadLine());

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
            Console.WriteLine("5 fuer Sinus");
            Console.WriteLine("6 fuer Cosinus");
            Console.WriteLine("7 fuer Tangens");
            Console.WriteLine("8 fuer Logarithmus zur Basis 2");
            Console.WriteLine("9 fuer Logarithmus zur Basis 10");
            Console.WriteLine("10 fuer Logarithmus zur Basis E");
            Console.WriteLine("11 fuer Logarithmus zu einer beliebigen Basis");

        }

    }
}