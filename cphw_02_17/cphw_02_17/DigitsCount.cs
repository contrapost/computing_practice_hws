using static cphw_02_17.InputOutput;

namespace cphw_02_17;

public static class DigitsCount
{
    public static readonly int Number= Convert.ToInt32(Input());
    public static int GetDigitsSum(int number)
    {
        var sumOfDigits = 0;
        while (number > 0)
        {
            sumOfDigits += number % 10;
            number /= 10;
        }
        return sumOfDigits;
    }
}