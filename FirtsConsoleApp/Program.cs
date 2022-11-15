internal class Program
{
    private static void Main()
    {
        var s = Convert.ToString((int)SomeEnum.Two);
        Console.WriteLine(s);
    }
}

enum SomeEnum
{
    One = 1,
    Two = 2,
    Three = 4
}