using static cphw_02_17.InputOutput;

namespace cphw_02_17;

public static class LastDigit
{
    public static readonly string? Number = Input();
    public static object GetLastDigit(string? number)
    {
        if (number != "") return number![^1];
        return "None";
    }
}