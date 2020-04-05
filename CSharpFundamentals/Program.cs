using System;
using CSharpFundamentals.Math;


namespace CSharpFundamentals
{
    public class Person
    {
        public string fname;
        public string lname;

        public void Introduction()
        {
            Console.WriteLine("My name is "+ fname +" " +lname + "!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Person obj = new Person(); or can  use var to make code more cleaner
            var obj = new Person();
            obj.fname = "Ayesha";
            obj.lname = "Memon";

            obj.Introduction();

            // Another class created in diff folder(Math) in same project
            Calculator calci = new Calculator();
            var result =calci.Add(5, 15);
            Console.WriteLine("Addition = " +result);



        }
    }
}
