using System;

namespace Overview
{
    internal class Program
    {
        private static void EnableBreakdown(bool enable)
        {
            if (!enable) return;
            var b = new Breakdown.Breakdown();
            Console.Read();
        }

        /// <summary>
        /// Entry point of the application.
        /// </summary>
        private static void Main(string[] args)
        {
            EnableBreakdown(false);

        }
    }
}
