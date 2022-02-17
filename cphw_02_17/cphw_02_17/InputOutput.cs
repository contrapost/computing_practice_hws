namespace cphw_02_17;

public static class InputOutput
{
    public static void PrintLn(object @string) => Console.WriteLine(@string);
    public static void Print(object @string) => Console.Write(@string);
    public static string? Input() => Console.ReadLine();
}