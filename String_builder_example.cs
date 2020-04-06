using System;
using System.Text;


namespace String_builder
{
    class String_builder_example
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            Console.WriteLine(builder);
            builder.Replace('-', '+');
            Console.WriteLine(builder);
            builder.Remove(0, 10);
            Console.WriteLine(builder);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine();

            var builder1 = new StringBuilder("Hellooo Ayesha");
            builder1.Append('-', 10);         //we can do this to make code more readable
            builder1.AppendLine();
            builder1.Append("Header");
            builder1.AppendLine();
            builder1.Append('-', 10);

            Console.WriteLine(builder1);
            builder1.Replace('-', '+');
            Console.WriteLine(builder1);
            builder1.Remove(0, 10);
            Console.WriteLine(builder1);

            builder1.Insert(0, new string('-', 10));
            Console.WriteLine(builder1);

            Console.WriteLine("First Char "+ builder1[0]);
        }
    }
}
