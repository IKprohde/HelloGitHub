using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldGIT101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);
            Console.ReadKey();
        }
    }
}
