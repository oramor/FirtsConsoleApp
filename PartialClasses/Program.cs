internal class Program
{
    public static void Main()
    {
        var a = new A();
        a.PrintHello();
        a.PrintBye();
    }
}

partial class A : IA
{
    public void PrintHello() { Console.WriteLine("Hello!"); }
}

partial class A : IA
{
    public void PrintBye() { Console.WriteLine("Bye!"); }
}

partial interface IA
{
    void PrintHello();
}

partial interface IA
{
    void PrintBye();
}