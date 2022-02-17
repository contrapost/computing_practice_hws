using static cphw_02_17.InputOutput;

namespace cphw_02_17;

internal static class Program
{
    private static void Main()
    {
        // Hypotenuse task
        Print("Type in a two following lines size of your triangle's legs!");
        var a = Hypotenuse.A;
        var b = Hypotenuse.B;
        Print(">>>>>>>>>>>>>>>\nHere is your hypotenuse: " + Hypotenuse.GetHyp(a, b));
    }
}