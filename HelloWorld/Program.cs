using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            new Strings();
            Console.Read();
        }
    }

    class Strings {
        public Strings()
        {
            Interpolation();
            StartsNull();
        }

        public void Interpolation()
        {
            var name = "Harry";
            Console.WriteLine($"Hello everyone, my name is {name}!");

            string anotherName = "John";
            Console.WriteLine($"My surname is {anotherName}");
        }
        
        public void StartsNull()
        {
            string startsNull; // null
            startsNull = "a value";
            Console.WriteLine($"Strings start null, but can be assigned {startsNull}");
        }
    }
}
