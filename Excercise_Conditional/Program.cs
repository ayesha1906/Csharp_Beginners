using System;


namespace Excercise_Conditional
{
    public class Conditional
    {
        public void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 to 10 : ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

        }

        public void Exercise2()
        {
            Console.WriteLine("Enter fisrt number : ");
            var no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            var no2 = Convert.ToInt32(Console.ReadLine());

            var max = (no1 > no2) ? no1 : no2;
            Console.WriteLine("Maximum number : " + max);

        }

        public void Exercise3()
        {
            Console.WriteLine("Enter height of image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? "Landscape" : "Portrait";
            Console.WriteLine("Orientation of Image : " + orientation);

        }

        public void Exercise4()
        {
            Console.WriteLine("Enter the speed limit :");
            var speed_limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of car :");
            var speed_car = Convert.ToInt32(Console.ReadLine());

            if (speed_car < speed_limit)
                Console.WriteLine("OK");
            else
            {
                const int km_perhour = 5;
                var points =(speed_car - speed_limit)/km_perhour;
            
                if (points > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit Points = " + points);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Conditional();
            string ans;
            do
            {
                
                Console.WriteLine("Enter your Choice :\n1.Valid/Invalid\n2.Maximum Number\n3.Orientation\n4.Speed Limit\n");
                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
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
                        Console.WriteLine("Wrong Choice");
                        break;

                }
                Console.WriteLine("Continue ?(y/n)");
                 ans =Console.ReadLine();

            } while(ans=="Y" || ans=="y");
          
           

        }
    }
}
