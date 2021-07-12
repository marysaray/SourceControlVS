using System;

namespace SourceControlVS
{
    class Program
    {
        /// <summary>
        /// In-Class Example of using source control features.
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            Console.WriteLine("Welcome to Advanced .Net Programming!");

            DisplayMessage();

            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
        /// <summary>
        /// This method refers to the Issue#1 on GitHub for creating a new branch.
        /// </summary>
        static void DisplayMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Completed the new branch exercise.");
            Console.WriteLine();
        }
    }
}
