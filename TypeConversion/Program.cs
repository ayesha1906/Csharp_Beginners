using System;


namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 365;
            byte b = (byte)i;
            Console.WriteLine(b);

            var number = "1234";
            int s = Convert.ToInt32(number);
            Console.WriteLine(s);

            var str = "false";
            bool tf = Convert.ToBoolean(str);
            Console.WriteLine(tf);

            try
            {
                var no = "1234";
                byte p = Convert.ToByte(number);
                Console.WriteLine(p);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted into byte");
            }
      

           
        }
    }
}
