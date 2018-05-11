using System;

class Types
{
    public Types()
    {
        GetCodeNameWithNameOf();
    }

    void GetCodeNameWithNameOf()
    {
        Console.WriteLine(nameof(Types));
        Console.WriteLine(nameof(GetCodeNameWithNameOf));
    }
}
