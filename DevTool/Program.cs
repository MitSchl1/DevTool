// See https://aka.ms/new-console-template for more information
using DevTool;
namespace DevTool
{

    internal class Program
    {
        static void Main(string[] args)
        {
            AdvancedCalculator advancedCalculator = new();
            AdvancedDescriptor advancedDescriptor = new();
            NumberConverter numberConverter = new ();

            bool userNotFinished = true;
            double[] userNumbers = new double[2];
            double userNumber;
            int userNumberForConvertation;

            Console.WriteLine("Hallo und herzlich Willkommen beim DevTool");
            Console.WriteLine("Das DevTool besteht aus einem Taschenrechner, einem Descriptor und einem Zahlenkonverter. " );
            Console.WriteLine("Der Taschenrechner beherrscht die vier Grundrechenarten Addition, Subtraktion, Multiplikation und Division " );
            Console.WriteLine("sowie Trigonomische und Logarithmische Funktionen. " );
            Console.WriteLine("Der Zahlenkonverter, konvertiert Zahlen vom Dezimalsystem in ein anderes Zahlensystem ");
            Console.WriteLine("Der Descriptor ist zum beschreiben der Mathematischen Operationen zuständig. ");
            Console.WriteLine("Hallo und herzlich Willkommen beim DevTool");


            while (userNotFinished)
            {
                Console.WriteLine("0 fuer Anwendung beenden");
                Console.WriteLine("1 fuer etwas Berechnen");
                Console.WriteLine("2 fuer eine Rechnung erklären lassen");
                Console.WriteLine("3 um eine Zahl zu konvertieren");
                int userinput = GetUserDecision();
                switch (userinput)
                {
                    case 0:
                        userNotFinished = false;
                        break;
                    case 1:
                        CalculationPosisibilities();
                        int whichCalcProcess = GetUserDecision();
                        switch (whichCalcProcess)
                        {
                            case 0:
                                break;
                            case 1:
                                userNumbers = UserNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " + " + userNumbers[1] + " ist " + advancedCalculator.AddCalc(userNumbers[0], userNumbers[1]));
                                break;
                            case 2:
                                userNumbers = UserNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " - " + userNumbers[1] + " ist " + advancedCalculator.SubCalc(userNumbers[0], userNumbers[1]));
                                break;
                            case 3:
                                userNumbers = UserNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " * " + userNumbers[1] + " ist " + advancedCalculator.MultCalc(userNumbers[0], userNumbers[1]));
                                break;
                            case 4:
                                userNumbers = UserNumbersforBasicCalc();
                                Console.WriteLine("Das Ergebnis von " + userNumbers[0] + " / " + userNumbers[1] + " ist " + advancedCalculator.DivCalc(userNumbers[0], userNumbers[1]));
                                break;
                            case 5:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Sinus berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Sinus von " + userNumber + " ist " + advancedCalculator.SinCalc(userNumber));
                                break;
                            case 6:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Cosinus berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Cosinus von " + userNumber + " ist " + advancedCalculator.CosCalc(userNumber));
                                break;
                            case 7:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Tangens berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Tangens von " + userNumber + " ist " + advancedCalculator.TanCalc(userNumber));
                                break;
                            case 8:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Logarithums zur Basis 2 berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Logarithums zur Basis 2 von " + userNumber + " ist " + advancedCalculator.Log2Calc(userNumber));
                                break;
                            case 9:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher  der Logarithums zur Basis 10 berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Logarithums zur Basis 10 von " + userNumber + " ist " + advancedCalculator.Log10Calc(userNumber));
                                break;
                            case 10:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Logarithums zur Basis E  berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Logarithums zur Basis E von " + userNumber + " ist " + advancedCalculator.LogECalc(userNumber));
                                break;
                            case 11:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der Logarithmus berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Bitte die Basis angeben");
                                double logBase = GetUserDecisionAsDouble();
                                Console.WriteLine("Der Logarithmus zur Basis " + logBase + " von " + userNumber + " ist " + advancedCalculator.LogCalcToAnyBase(userNumber, logBase));
                                break;
                            case 12:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der ASinus berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der ASinus von " + userNumber + " ist " + advancedCalculator.AsinCalc(userNumber));
                                break;
                            case 13:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der AKosinus berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der AKosinus von " + userNumber + " ist " + advancedCalculator.AcosCalc(userNumber));
                                break;
                            case 14:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der ATangens berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der ATangens von " + userNumber + " ist " + advancedCalculator.AtanCalc(userNumber));
                                break;
                            case 15:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der SinusH berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der SinusH von " + userNumber + " ist " + advancedCalculator.SinhCalc(userNumber));
                                break;
                            case 16:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der CosinusH berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der CosinusH von " + userNumber + " ist " + advancedCalculator.CoshCalc(userNumber));
                                break;
                            case 17:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der TangensH berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der TangensH von " + userNumber + " ist " + advancedCalculator.TanhCalc(userNumber));
                                break;
                            case 18:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der ASinusH berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der ASinusH von " + userNumber + " ist " + advancedCalculator.AsinhCalc(userNumber));
                                break;
                            case 19:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der AKosinusH berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der AKosinusH von " + userNumber + " ist " + advancedCalculator.AcosHCalc(userNumber));
                                break;
                            case 20:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher der ATangensH berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Der ATangensH von " + userNumber + " ist " + advancedCalculator.AtanhCalc(userNumber));
                                break;
                            case 21:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher die Wurzel berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("Die Wurzel von " + userNumber + " ist " + advancedCalculator.SqrtCalc(userNumber));
                                break;
                            case 22:
                                Console.WriteLine("Bitte die Zahl eingeben von welcher die Wurzel berechnet werden soll");
                                userNumber = GetUserDecisionAsDouble();
                                Console.WriteLine("e hoch " + userNumber + " ist " + advancedCalculator.ExpCalc(userNumber));
                                break;
                            case 23:
                                userNumbers = UserNumbersforBasicCalc();
                                Console.WriteLine("Die Potenz von " + userNumbers[0] + " hoch " + userNumbers[1] + " ist " + advancedCalculator.PowCalc(userNumbers[0], userNumbers[1]));
                                break;
                            default:
                                Console.WriteLine("nicht vorhanden");
                                break;
                        }
                        break;
                    case 2:
                        CalculationPosisibilities();
                        int whichDescription = GetUserDecision();
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

                            case 12:
                                advancedDescriptor.AsinDescription();
                                break;
                            case 13:
                                advancedDescriptor.AcosDescription();
                                break;
                            case 14:
                                advancedDescriptor.AtanDescription();
                                break;
                            case 15:
                                advancedDescriptor.SinhDescription();
                                break;
                            case 16:
                                advancedDescriptor.CoshDescription();
                                break;
                            case 17:
                                advancedDescriptor.TanhDescription();
                                break;
                            case 18:
                                advancedDescriptor.AsinhDescription();
                                break;
                            case 19:
                                advancedDescriptor.AcoshDescription();
                                break;
                            case 20:
                                advancedDescriptor.AtanhDescription();
                                break;
                            case 21:
                                advancedDescriptor.SqrtDescription();
                                break;
                            case 22:
                                advancedDescriptor.ExpDescription();
                                break;
                            case 23:
                                advancedDescriptor.PowDescription();
                                break;
                            default:
                                Console.WriteLine("nicht vorhanden");
                                break;
                        }
                        break;
                    case 3:
                        ConvertPosisibilities();
                        int whichConvertation = GetUserDecision();
                        switch (whichConvertation)
                        {
                            case 0:
                                break;
                            case 2:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Binaersystem ist: " + numberConverter.ConvertFromDecimalsystemToBinaersystem(userNumberForConvertation));
                                break; 
                            case 3:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Ternaersystem ist: " + numberConverter.ConvertFromDecimalsystemToTernaersystem(userNumberForConvertation));
                                break;
                            case 4:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Quatenaersystem ist: " + numberConverter.ConvertFromDecimalsystemToQuatenaersystem(userNumberForConvertation));
                                break;
                            case 5:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Quinaersystem ist: " + numberConverter.ConvertFromDecimalsystemToQuinaersystem(userNumberForConvertation));
                                break;
                            case 6:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Senaersystem ist: " + numberConverter.ConvertFromDecimalsystemToSenaersystem(userNumberForConvertation));
                                break;
                            case 7:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Septenaersystem ist: " + numberConverter.ConvertFromDecimalsystemToSeptenaersystem(userNumberForConvertation));
                                break;
                            case 8:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Oktalsystem ist: " + numberConverter.ConvertFromDecimalsystemToOktalsystem(userNumberForConvertation));
                                break;
                            case 9:
                                Console.WriteLine("Bitte die Zahl eingeben welche konvertiert werden soll");
                                userNumberForConvertation = GetUserDecision();
                                Console.WriteLine(userNumberForConvertation + " im Nonaersystem ist: " + numberConverter.ConvertFromDecimalsystemToNonaersystem(userNumberForConvertation));
                                break;
                            default:
                                Console.WriteLine("nicht vorhanden");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Bitte eine Zahl zwischen 0 und 2 eingeben");
                        break;
                }

            }
        }
        static double[] UserNumbersforBasicCalc()
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

        static void CalculationPosisibilities()
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
            Console.WriteLine("12 fuer ASinus");
            Console.WriteLine("13 fuer ACosinus");
            Console.WriteLine("14 fuer ATangens");
            Console.WriteLine("15 fuer SinusH");
            Console.WriteLine("16 fuer CosinusH");
            Console.WriteLine("17 fuer TangensH");
            Console.WriteLine("18 fuer ASinusH");
            Console.WriteLine("19 fuer ACosinusH");
            Console.WriteLine("20 fuer ATangensH");
            Console.WriteLine("21 fuer Wurzel");
            Console.WriteLine("22 fuer Exponent");
            Console.WriteLine("23 fuer Potenz");
        }
        static void ConvertPosisibilities()
        {
            Console.WriteLine("0 fuer zurueck zum Menu");
            Console.WriteLine("2 fuer Dezimal in Binaer");
            Console.WriteLine("3 fuer Dezimal in Ternaer");
            Console.WriteLine("4 fuer Dezimal in Quatenaer");
            Console.WriteLine("5 fuer Dezimal in Quniaer");
            Console.WriteLine("6 fuer Dezimal in Senaer");
            Console.WriteLine("7 fuer Dezimal in Septenaer");
            Console.WriteLine("8 fuer Dezimal in Oktal");
            Console.WriteLine("9 fuer Dezimal in Nonaer");
        }

         static int GetUserDecision()
        {
            int userDecision;
            string user = Console.ReadLine();
            if (!int.TryParse(user, out userDecision))
            {

            }
            return userDecision;
        }

        static double GetUserDecisionAsDouble()
        {
            double userDecision;
            string user = Console.ReadLine();
            if (!double.TryParse(user, out userDecision))
            {

            }
            return userDecision;
        }
    }
}
