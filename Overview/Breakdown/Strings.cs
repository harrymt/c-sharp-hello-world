using System;
using System.Text;

namespace Overview
{
    class Strings
    {
        public Strings()
        {
            StartsNull();
            EmptyStrings();
            Interpolation();
            Concatenation();
            UseStringBuilderForComplexConcats();
            HasNormalBuiltIns();
        }

        void StartsNull()
        {
            string startsNull; // null
            startsNull = "a value";
            Console.WriteLine($"Strings start null, but can be assigned {startsNull}");
        }

        void EmptyStrings()
        {
            string empty = "";
            string alsoEmpty = String.Empty;
            Console.WriteLine($"Use String.Empty for empty strings {empty == alsoEmpty}");

            if (String.IsNullOrEmpty(empty))
            {
                Console.WriteLine($"Static methods for checking if strings are both null or empty");
            }
        }

        void Interpolation()
        {
            var name = "Harry";
            Console.WriteLine($"Hello everyone, my name is {name}!");

            string anotherName = "John";
            Console.WriteLine($"My surname is {anotherName}");
        }

        void Concatenation()
        {
            string name = "Harry";
            string joiner = " is ";
            string age = "24 years";
            string sentence = name + joiner + age;
            Console.WriteLine(sentence);
        }

        void UseStringBuilderForComplexConcats()
        {
            string name = "Harry";
            string surname = "Mumford-Turner";
            string dog = "bernie";
            StringBuilder sb = new StringBuilder();
            sb.Append(name)
                .Append(surname)
                .Append(dog);
            Console.WriteLine(sb.ToString());
        }

        void HasNormalBuiltIns()
        {
            string upper = "make me upper case".ToUpper();
            string lower = "MAKE ME LOWER CASE".ToLower();
            string has = " has ".Trim();
            string usual = "usual   ".TrimEnd();
            string padding = " padding functions".TrimStart();
        }
    }
}
