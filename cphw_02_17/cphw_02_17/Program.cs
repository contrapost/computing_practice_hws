using static cphw_02_17.InputOutput;

namespace cphw_02_17;

internal static class Program
{
    private static void Main()
    {
        // Hypotenuse task;
        Print("Task 1. \nType here your 'a' and 'b' legs: ");
        var a = Hypotenuse.A;
        var b = Hypotenuse.B;
        PrintLn(">>>>>>>>>>>>>>>\nHere is your hypotenuse: " + Hypotenuse.GetHyp(a, b));
        // Last digit task;
        Print("\nTask 5. \nType your number here: ");
        var num = LastDigit.Number;
        PrintLn(">>>>>>>>>>>>>>>\nHere is your number's last digit: " + LastDigit.GetLastDigit(num));
        // Next even number task;
        Print("\nTask 9. \nType your number here: ");
        var evenChecked = NextEven.Number;
        PrintLn(">>>>>>>>>>>>>>>\nHere is your number's next even: " + NextEven.GetNextEven(evenChecked));
        // Get days task;
        Print("\nTask 10. \nType your distance and daily distance here: ");
        var distance = Route.Distance;
        var dailyDistance = Route.DailyDistance;
        PrintLn(">>>>>>>>>>>>>>>\nHere is your transport passage time in days: " 
                + Route.GetTime(distance, dailyDistance));
        // Get digits' sum task;
        Print("\nTask 8. \nType your number here: ");
        var numberForSum = DigitsCount.Number;
        PrintLn(">>>>>>>>>>>>>>>\nHere is sum of digits of your number: " + 
                DigitsCount.GetDigitsSum(numberForSum));
    }
}