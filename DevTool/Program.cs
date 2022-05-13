// See https://aka.ms/new-console-template for more information
using DevTool;
using System.Data.SqlClient;

Addition add = new();
Fibonacci sub = new();
Multiplication multiplication = new();
Division division = new();

bool userNotFinished = true;
float[] userNumbers = new float[2];

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
                    userNumbers = userNumbersforStandardCalc();
                    add.CalcWithTwoPassedValues(userNumbers[0], userNumbers[1]);
                    break;
                case 2:
                    userNumbers = userNumbersforStandardCalc();
                    sub.CalcWithTwoPassedValues(userNumbers[0], userNumbers[1]);
                    break;
                case 3:
                    userNumbers = userNumbersforStandardCalc();
                    multiplication.CalcWithTwoPassedValues(userNumbers[0], userNumbers[1]);
                    break;
                case 4:
                    userNumbers = userNumbersforStandardCalc();
                    division.CalcWithTwoPassedValues(userNumbers[0], userNumbers[1]);
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
 float[] userNumbersforStandardCalc()
{
    float[] userNumbers = new float[2];
    Console.WriteLine("Bitte erste Zahl eingeben");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Bitte zweite Zahl eingeben");
    int secondNumber = int.Parse(Console.ReadLine());

    userNumbers[0] = firstNumber;
    userNumbers[1] = secondNumber;

    return userNumbers;
}

void calculationPosisibilities()
{
    Console.WriteLine("0 fuer zurueck zum Menu");
    Console.WriteLine("1 fuer Addition");
    Console.WriteLine("2 fuer Subtraktion");
    Console.WriteLine("3 fuer Multiplikation");
    Console.WriteLine("4 fuer Division");

}


