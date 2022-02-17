using static cphw_02_17.InputOutput;

namespace cphw_02_17;

public static class Route
{
    public static readonly int Distance = Convert.ToInt32(Input());
    public static readonly int DailyDistance = Convert.ToInt32(Input());

    public static object GetTime(int dist, int dayDist)
    {
        if (dist == dayDist || dist < dayDist) return 1;
        if (dist % dayDist == 0) return dist / dayDist;
        return dist / dayDist + 1;
    }
}