using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[3];
            var numbers = new int[3] {0,2,4};

            foreach (var no in numbers)
                Console.WriteLine(no);

            numbers[0] = 6;

            foreach (var no in numbers)
                Console.WriteLine(no);

            //array of bool
            var flags = new bool[3];
            flags[0] = true;

            foreach (var value in flags)
                Console.WriteLine(value);

            //array of strings
            var names = new string[3] { "Jack", "Jill", "John" };

            foreach (var name in names)
                Console.WriteLine(name);

        }
    }
}
