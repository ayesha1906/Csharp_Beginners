using System;


namespace StringsFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName="Ayesha";
            String lastName = "Memon"; //using String class
            string name= "Ashu";      //using string datatype

            var fullName= firstName + " "+ lastName;
            Console.WriteLine(fullName);

            var myFullName= string.Format("My name is {0} {1}", firstName,lastName); //access using format method
            Console.WriteLine(myFullName);

            var names = new string[3] { "Harry", "Edward", "Elena" };  //using join method 
            var formattedNames = string.Join(", ", names); 
            Console.WriteLine(formattedNames);

            var formattedNames1 = string.Join(": ", names);
            Console.WriteLine(formattedNames1);

            var text = "Hi Ayesha\nCheck the paths\nc:\\folder1\\folder\\myProgram\nc:\\folder2\\folder\\program2"; //using escape characters
            Console.WriteLine(text);
            Console.WriteLine();
            //using verbarium string
            var text1 = @"Hi Ayesha
Check the paths
c:\folder1\folder\myProgram
c:\folder2\folder\program2";
            Console.WriteLine(text1);

        }
    }
}
