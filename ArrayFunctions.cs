using System;

namespace Arrays_Func
{
    class ArrayFunctions
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            //length
            Console.WriteLine("Length : "+ numbers.Length);  //non-static method rest all methods in program are static 

            //Indexof
            var index= Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 : "+index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("After Clear : ");
            foreach(var n in numbers)
                Console.WriteLine(n);

            var str = new string[] { "John", "Julie", "elsa" ,"Anna"};
            Array.Clear(str, 0, 3);
            Console.WriteLine("After Clear : ");
            foreach (var name in str)
                Console.WriteLine(name);

            //Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("After Copy : ");
            foreach (var n in another)
                Console.WriteLine(n);

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("After Sort : ");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("After Reverse : ");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
