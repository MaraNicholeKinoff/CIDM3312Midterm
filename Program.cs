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
            Console.WriteLine("\nConnect to the database and show all records of Books Published by Apress.\n");
            WhereCommands.Problem2();
            Console.WriteLine("\nConnect to the database and show all records of Books whose author's first name is the shortest.\n");
            WhereCommands.Problem3();

            //Find Problems
            Console.WriteLine("\nConnect to the database and find the first book by an author named Adam and print that record to the screen.\n");
            FindCommands.Problem1();
            Console.WriteLine("\nConnect to the database and find the first book whose page count is greater than 1000.\n");
            FindCommands.Problem2();

            //Ordery By Problems
            Console.WriteLine("\nConnect to the database and show all Books sorted by Author's last name.\n");
            OrderByCommands.Problem1();
            Console.WriteLine("\nConnect to the database and show all Books sorted by book title descending.\n");
            OrderByCommands.Problem2();

            //Ordery By Problems
            Console.WriteLine("\nConnect to the database and show all Books Grouped by publisher.\n");
            GroupByCommands.Problem1();
            Console.WriteLine("\nConnect to the database and show all Books Grouped by publisher and sorted by Author's last name.\n");
            GroupByCommands.Problem2();
        }
    }
}
