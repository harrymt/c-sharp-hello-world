using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        new Strings();
        new DateTimes();
        new Other();
        new ControlFlow();
        Console.Read();
    }
}

class Other { 
    public Other()
    {
        GetCodeNameWithNameOf();
    }

    void GetCodeNameWithNameOf()
    {
        Console.WriteLine(nameof(Other));
        Console.WriteLine(nameof(GetCodeNameWithNameOf));
    }
}
