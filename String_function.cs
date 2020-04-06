using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class String_function
    {
        static void Main(string[] args)
        {
            var fullName = "Ayesha Memon  ";
            //trim
            Console.WriteLine("Trim : '{0}'", fullName.Trim()); //removes whitespace at end
            //ToUpper
            Console.WriteLine("To Upper : '{0}'", fullName.Trim().ToUpper());
            //substring or Split
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name : " +firstName);
            Console.WriteLine("Last Name : " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name : " + names[0]);
            Console.WriteLine("Last Name : " + names[1]);

            //replace
           var replace= fullName.Replace("Memon" ,"Khanna");
            Console.WriteLine("After Replace : " +replace);

            var replace1 = fullName.Replace("o", "O");
            Console.WriteLine("After Replace: " + replace1);

            //null er empty validation
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Invalid");

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");

            if (String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");

            //isnullorwhitspace
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");

            //convert to string using its format specifiers
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));  // C is format speicifer of Currency

            float price1= 29.95f;
            Console.WriteLine(price1.ToString("C0")); //C0 is for removing 2 decimal points

            float price2= 29.95f;
            Console.WriteLine(price2.ToString("C1"));//C1is for removing 1 decmal points
        }
    }
}
