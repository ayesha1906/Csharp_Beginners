using System;
using System.Collections.Generic;


namespace Exercise4
{
    public class Exercise_Strings
    {
        public static void Exercise_1()
        {
            Console.WriteLine("Enter the numbers with hyphen sepearted :");
            var input = Console.ReadLine();

            var num = new List<int>();
            var numbers = input.Split('-');
            foreach (var no in numbers)
                num.Add(Convert.ToInt32(no));

            num.Sort();

            var flag = true;
            for(var i=1;i< num.Count; i++)
            {
                if (num[i] != num[i-1] +1)
                {
                    flag = false;
                    break;
                }
                
            }
            var msg = (flag) ? "Consecutive" : "Not-Consecutive";
            Console.WriteLine(msg);
        
        }

        public static void Exercise_2()
        {
                Console.WriteLine( "Enter the numbers with hyphen:");
                var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;
            
                var num = new List<int>();
                foreach (var n in input.Split('-'))
                    num.Add(Convert.ToInt32(n));

                var unique = new List<int>();
            var isduplicate = true;
            foreach (var number in num)
            {
                if (!unique.Contains(number))
                    unique.Add(number);
                else
                {
                   // Console.WriteLine("Duplicate value of : {0}", number);
                    isduplicate = false;
                }

            }
            if(isduplicate)
                Console.WriteLine("No Duplicate !");
            else
                Console.WriteLine("Duplicate Found !");
                    
        }
            
        public static void Exercise_3()
        {
            Console.WriteLine("Enter the Time in 24 hour format :");
            var time = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(time))
                Console.WriteLine("Invalid Time");

            var components = time.Split(':');
            
            if(components.Length>2)
                Console.WriteLine("Invalid Time");
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minutes = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
                    Console.WriteLine("Valid Times");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid ");
                
            }
        }

        public static void Exercise_4()
        {
            
            Console.WriteLine("Enter the word :");
            var input= Console.ReadLine().ToLower();

            var vowels = new List<char> (){'a' , 'e','i' , 'o', 'u'};
            var count = 0;
            foreach (var charac in input)
            {
                if (vowels.Contains(charac))
                    count++;
            }
            Console.WriteLine("Total vowels in the given input are : "+count);

        }

        static void Main(string[] args)
        {
            string ans;
            do
            {
                Console.WriteLine("Enter the choice :\n1.Exercise 1 \n2.Exercise 2\n3.Exercise 3\n4.Exercise 4\n");
                var ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Exercise_1();
                        break;

                    case 2:
                        Exercise_2();
                        break;

                    case 3:
                        Exercise_3();
                        break;

                    case 4:
                        Exercise_4();
                        break;

                    default:
                        Console.WriteLine("Wrong Choice.");
                        break;
                }
                Console.WriteLine("Continue? (y/n)");
                ans = Console.ReadLine();

            } while (ans == "Y" || ans == "y");

        }
    }
}
