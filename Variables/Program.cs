using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number =2;               //using var instead of primitive data type 
            var count = 10;
            var totalPrice = 20.65f;
            var character = 'A';
            var fname = "Ayesha Memon";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(fname);
            Console.WriteLine(isWorking);

            //Format Strings

            Console.WriteLine("Min and Max value of Byte using format Specifier: {0} {1} ", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min and Max value of float using format Specifier: {0} {1} ", float.MinValue, float.MaxValue);
            Console.WriteLine("Min and Max value of Int using format Specifier: {0} {1} ", int.MinValue, int.MaxValue);


        }
    }
}
