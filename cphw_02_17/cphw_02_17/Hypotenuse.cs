using static cphw_02_17.InputOutput;
// using static cphw_02_17.InputCheck;

namespace cphw_02_17;

public static class Hypotenuse
{
    public static readonly int A = Convert.ToInt32(Input());
    public static readonly int B = Convert.ToInt32(Input());
    public static object GetHyp(int a, int b) => Math.Sqrt(a * a + b * b);
}