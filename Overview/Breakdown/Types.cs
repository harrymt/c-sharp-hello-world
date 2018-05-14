using System;

namespace Overview
{
    class Types
    {
        public Types()
        {
            GetCodeNameWithNameOf();
            ByRef();
        }

        void GetCodeNameWithNameOf()
        {
            Console.WriteLine(nameof(Types));
            Console.WriteLine(nameof(GetCodeNameWithNameOf));
        }

        void ByRef()
        {
            string data = "Original data";
            ChangeString(data);
            Console.WriteLine(data); // Original data

            ChangeString(ref data);
            Console.WriteLine(data == null); // data is now a null reference
        }

        static void ChangeString(string str)
        {
            str = null;
        }

        static void ChangeString(ref string str)
        {
            str = null;
        }
    }
}
