using System;
using System.Collections.Generic;

namespace Lists_func
{
    class List_fucntions
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            //adding one more number i.e 1
            numbers.Add(1);
            foreach (var i in numbers)
                Console.WriteLine(i);

            Console.WriteLine();

            //add range
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var i in numbers)
                Console.WriteLine(i);

            Console.WriteLine();

            //indexof
            Console.WriteLine("Index of 5: " + numbers.IndexOf(5));
            //lastindexof
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            //count
            Console.WriteLine();
            Console.WriteLine("Count : "+numbers.Count);

            //remove
            Console.WriteLine();
            Console.WriteLine("After removong 2: ");
            numbers.Remove(2);
            foreach (var no in numbers)
                Console.WriteLine(no);

            Console.WriteLine();
            Console.WriteLine("After removong 1: ");
            for (var i=0;i<numbers.Count;i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            Console.WriteLine();
            foreach (var no in numbers)
                Console.WriteLine(no);

            //clear
            numbers.Clear(); //removes all elemts from list
            Console.WriteLine();
            Console.WriteLine("Count : " + numbers.Count);
        }
    }
}
