using System;

namespace FirstConsoleProject
{
    /// <summary>
    /// Class Program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Int32.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to First Console Project");
            Console.Read();
            Console.ReadLine();
        }
    }
}