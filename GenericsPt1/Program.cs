using System;

namespace GenericsPt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printservice printservice = new Printservice();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printservice.AddValue(x);
            }

            printservice.Print();
            Console.WriteLine("First: " + printservice.First());
        }
    }
}
