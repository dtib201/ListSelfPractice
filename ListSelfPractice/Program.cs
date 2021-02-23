using System;
using System.Collections.Generic;


namespace ListSelfPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // practice declaring and initialising a generic list.
            List<string> names = new List<string>();

            names.Add("Fred");
            names.Add("Barney");
            names.Add("Wilma");
            names.Add("Dino");

            // Try adding elements of different data types to the List and note whether a compiler or a runtime error occurs.
            //names.Add(12);  // Compile Error, expected string received int

            // Practice displaying only specific List elements as well as displaying all the elements of the List.
            Console.WriteLine(names[1]);
            Console.WriteLine(names[3]);

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
