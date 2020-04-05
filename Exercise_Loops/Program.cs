using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loops
{
    public class Loops
    {
        public void Exercise1()
        {
            var count = 0;
            for(var i=1;i<=100;i++)
            {
                if (i % 3 == 0)
                    count += 1;  // count++
            }
            Console.WriteLine("There are total {0} numbers divisible by 3 between 1 to 100 .  ", count);
        }

        public void Exercise2()
        {
            var sum = 0;
            var count = 0;

            while(true)
            {
                Console.WriteLine("Enter a number or 'OK' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                else
                {
                    sum = sum + Convert.ToInt32(input);
                    count++;
                }
            }
                Console.WriteLine("The sum of {0} numbers is {1}" ,count,sum);
        }

        public void Exercise3()
        {
            var fact=1;
            Console.WriteLine("Enter the number to find factorial :");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
                Console.WriteLine("0!=1");
            else
            {
                for (var i = 1; i <= input; i++)
                {
                    fact *=i;
                }
                Console.WriteLine("{0}! = {1}",input,fact);
            }
            
        }

        public void Exercise4()
        {
            var chance = 0;
            var secret_no = new Random().Next(1,10);
            Console.WriteLine(secret_no);
            
            while(chance<4)
            {
                Console.WriteLine("Guess the number (Chance {0}): ",chance);
                var guess = Convert.ToInt32(Console.ReadLine());
                if(guess==secret_no)
                {
                    Console.WriteLine("You Won !! ");
                    break;
                }
                else
                    Console.WriteLine("Wrong Guess ..Try again !!");
                chance++;
            }
            if(chance==4)
                Console.WriteLine("You Lose !! ");
        }

        public void Exercise5()
        {
            Console.WriteLine("Enter series of number with comma :");
            var input = Console.ReadLine();

            var numbers = input.Split(',');
            var max=Convert.ToInt32(numbers[0]);
            foreach (var no in numbers)
            {
                var number = Convert.ToInt32(no);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("The maximum Number is {0} ",max);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Loops();
           string ans;
            do
            {
                Console.WriteLine("Enter the choice :\n1.Divisible by 3\n2.Sum of numbers\n3.Factorial\n4.Find out Game\n5.Maximum Number\n");
                var ch =Convert.ToInt32(Console.ReadLine());

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

                    case 5:
                        obj.Exercise5();
                        break;

                    default:
                        Console.WriteLine("Wrong Choice.");
                        break;
                }
                Console.WriteLine("Continue? (y/n)");
                ans = Console.ReadLine();

            } while (ans=="Y" || ans=="y");
        }
    }
}
