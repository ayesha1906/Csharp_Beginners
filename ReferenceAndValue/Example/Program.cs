using System;

namespace ReferenceAndValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types: making chnge in one will not impact other variable
            int a = 10;                   
            int b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}  ", a, b));

            //refence type: chnges in each othr will impact 
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            foreach (var element in array2)
                Console.Write( element+" ");
            Console.WriteLine();

            foreach (var element in array1)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
