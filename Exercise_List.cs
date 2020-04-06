using System;
using System.Collections.Generic;


namespace Lists
{
    class Exercise_Lists
    {
        public void Exercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter the name or press enter to quit : ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;
                else
                    names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0} , {1} and {2} others liked your post .", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} liked your post .", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} liked your post .", names[0]);
            else
                Console.WriteLine();
        }

        public void Exercise2()
        {

            Console.WriteLine("Enter a name :");
            var name = Console.ReadLine();
            var length = name.Length;
            var array = new char[length];
            for (var i = length; i > 0; i--)
                array[length - i] = name[i - 1];

            var reverse = new string(array);
            Console.WriteLine("Reversed String is : " + reverse);

        }

        public void Exercise3()
        {
            var num = new List<int>();

            while (num.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (num.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                num.Add(number);
            }

            num.Sort();
            Console.WriteLine("The Sorted Numbers are :");
            foreach (var n in num)
                Console.WriteLine(n);

        }

        public void Exercise4()
        {
            var num = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter Number or enter 'quit' to stop : ");
                var number = Console.ReadLine();

                if (number.ToLower() == "quit")
                    break;
                num.Add(Convert.ToInt32(number));
            }
            var uniques = new List<int>();
            foreach (var n in num)
            {
                if (!uniques.Contains(n))
                    uniques.Add(n);
            }
            foreach (var i in uniques)
                Console.WriteLine(i);

        }


        static void Main(string[] args)
        {
            var obj = new Lists();
            string ans;
            do
            {
                Console.WriteLine("Enter the choice :\n1.Exercise 1 \n2.Exercise 2\n3.Exercise 3\n4.Exercise 4\n");
                var ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        obj.Exercise1();
                        break;

                    case 2:
                        obj.Exercise2();
                        break;

                    case 3:
                        obj.Exercise3();
                        break;

                    case 4:
                        obj.Exercise4();
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
