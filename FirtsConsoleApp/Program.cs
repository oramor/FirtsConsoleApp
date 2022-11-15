internal class Program
{
    private static void Main()
    {
        var s = Convert.ToString((int)SomeEnum.Two);
        Console.WriteLine(s);

        var c = new ExeptionCultureNode() {
            En_US = "dfdf",
            Ru_RU = "sdssd"
        };
    }
}

enum SomeEnum
{
    One = 1,
    Two = 2,
    Three = 4
}

interface ICultureNode
{
    public string Ru_RU { get; init; }
    public string En_US { get; init; }
    public string En_CA { get; init; }
}

class ExeptionCultureNode : ICultureNode
{
    public string Ru_RU { get; init; }
    public string En_US { get; init; }
    public required string En_CA { get; init; }
}