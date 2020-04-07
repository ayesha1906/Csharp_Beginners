using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procedural_Prog
{
    class Exercise_Procedural
    {

        public bool IsConsecutive (List<int> list)
        {
            var num_array = new int[list.Count];
            list.CopyTo(num_array);

            Array.Sort(num_array);

            for(var i =1;i<num_array.Length;i++)
            {
                if (num_array[i] != num_array[i - 1] + 1)
                    return false;
            }
            return true;
        }


        public bool IsConsecutive1(List<int> list) // without making array
        {
            // var num_array = new int[list.Count];
            //list.CopyTo(num_array);

            // Array.Sort(num_array);
            list.Sort();

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] != list[i - 1] + 1)
                    return false;
            }
            return true;
        }

        public bool IsDuplicate(List <int> list)
        {
            var unique = new List<int>();
           // var isdupli = true;
            foreach (var number in list)
            {
                if (!unique.Contains(number))
                    unique.Add(number);
                else
                {
                    // Console.WriteLine("Duplicate value of : {0}", number);
                    return false;
                }

            }
            return true;
            

        }

        public string Time_Validate(String time)
        {
            

            if (String.IsNullOrWhiteSpace(time))
                Console.WriteLine("Invalid Time");

            var components = time.Split(':');

            if (components.Length > 2)
                Console.WriteLine("Invalid Time");
            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minutes = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
                    return "Valid Times";
                else
                    return "Invalid Time";
            }
            catch (Exception)
            {
                return "Invalid ";

            }
        }

        public int Vowel_Count(String input)
        {
            var vowels = new List<char> (){'a' , 'e','i' , 'o', 'u'};
            var count = 0;
            foreach (var charac in input)
            {
                if (vowels.Contains(charac))
                    count++;
            }
            return count;
        }
    


        static void Main(string[] args)
        {
            var obj = new Exercise_Procedural();
             string ans;
              do
              {
                  Console.WriteLine("Enter the choice :\n1.Is Consecutive \n2. Is Duplicate\n3. Time Validation 3\n4. Vowels Count\n");
                  var ch = Convert.ToInt32(Console.ReadLine());

                  switch (ch)
                  {
                      case 1:
                          { 
                              Console.WriteLine("Enter The numbers seperated by hyphen: ");
                              var input = Console.ReadLine();
                              var num = new List<int>();
                              foreach (var n in input.Split('-'))
                                  num.Add(Convert.ToInt32(n));

                             var value= obj.IsConsecutive(num);
                              var msg = (value) ? " Consecutive" : "Not Consecutive";
                              Console.WriteLine(msg);
                                 break;
                          }


                     case 2:
                        {
                            Console.WriteLine("Enter the numbers with hyphen:");
                            var input = Console.ReadLine();

                            if (String.IsNullOrWhiteSpace(input))
                                return;

                            var num = new List<int>();
                            foreach (var n in input.Split('-'))
                                num.Add(Convert.ToInt32(n));

                            var value = obj.IsDuplicate(num);
                            var msg = (value) ? " No Duplicate" : "Duplicate";
                            Console.WriteLine(msg);
                             break;
                        }


                          case 3:
                        {
                            Console.WriteLine("Enter the Time in 24 hour format :");
                            var time = Console.ReadLine();
                            var value = obj.Time_Validate(time);
                            Console.WriteLine(value);
                            break;

                        }

                        case 4:
                        {
                            Console.WriteLine("Enter the word :");
                            var input = Console.ReadLine().ToLower();
                            var value = obj.Vowel_Count(input);
                            Console.WriteLine("Total vowels in the given input are : " + value);

                             break;
                        }


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
