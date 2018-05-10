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
            StartsNull();
            EmptyStrings();
            Interpolation();
            Concatenation();
        }


        public void StartsNull()
        {
            string startsNull; // null
            startsNull = "a value";
            Console.WriteLine($"Strings start null, but can be assigned {startsNull}");
        }

        public void EmptyStrings()
        {
            string empty = "";
            string alsoEmpty = String.Empty;
            Console.WriteLine($"Use String.Empty for empty strings {empty == alsoEmpty}");
        }

        public void Interpolation()
        {
            var name = "Harry";
            Console.WriteLine($"Hello everyone, my name is {name}!");

            string anotherName = "John";
            Console.WriteLine($"My surname is {anotherName}");
        }

        public void Concatenation()
        {
            string name = "Harry";
            string joiner = " is ";
            string age = "24 years";
            string sentence = name + joiner + age;
            Console.WriteLine(sentence);
        }
    }
}
