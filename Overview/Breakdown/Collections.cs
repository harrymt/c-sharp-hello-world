using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overview
{
    internal class Collections
    {
        public Collections()
        {
            HasArrayLists();
        }

        private void HasArrayLists()
        {
            var colors = new ArrayList {"R", "G", "B"};
            Console.WriteLine(colors.Capacity == 4); // Elements it can contain
            Console.WriteLine(colors.Count == 3); // Actual elements it contains
            colors.Remove("R");
            Console.WriteLine(colors.Capacity == 4);
            Console.WriteLine(colors.Count == 2);
            Console.WriteLine(colors.IsFixedSize == false);
            colors.Add("A");
        }
    }
}
