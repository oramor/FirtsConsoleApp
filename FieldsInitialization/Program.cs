// See https://aka.ms/new-console-template for more information
var a = new A();
//a.Print();

internal class B
{
    int _v2;

    internal B()
    {
        _v2 = 2;
    }

    internal B(int i)
        : this()
    {
    }

    internal B(string s)
        : this()
    {
    }

    public virtual void Print()
    {

    }
}

internal class A
{
    int _v1 = 1;

    internal A()
    {
    }

    internal A(int i)
    {
    }

    internal A(string s)
    {
    }

    //public override void Print()
    //{
    //    Console.WriteLine(_v1);
    //}
}