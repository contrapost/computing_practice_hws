using static cphw_02_17.InputOutput;

namespace cphw_02_17;

public class NextEven
{
    public static readonly int Number = Convert.ToInt32(Input());
    public static object GetNextEven(int number)
    {
        if (number % 2 == 0) return number + 2;
        return number + 1;
    }

}