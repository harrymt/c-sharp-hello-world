using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Strings s = new Strings();
            s.Interpolation();
            Console.Read();
        }
    }

    class Strings {
        public void Interpolation()
        {
            var name = "Harry";
            Console.WriteLine($"Hello everyone, my name is {name}!");
        }
    }
}
