using System;
using System.Collections.Generic;
using System.Linq;

namespace CIDM3312Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedCommands.CreateSeedData();

            //Where Problems
            Console.WriteLine("\nConnect to the database and show all records in the Books table.\n");
            WhereCommands.Problem1();
            Console.WriteLine("\nConnect to the database and show all records of Books Published by APress\n");
            WhereCommands.Problem2();
        }
    }
}
