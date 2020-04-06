using System;
using System.Collections.Generic;

namespace Summarizing
{
   public class StringUtility
    {
        public static string SummarizeText(string text, int maxlength = 20)
        {
            //const int maxlength = 20;
            if (text.Length < maxlength)
                return text;

            /*
            Console.WriteLine(sentence.Substring(0, maxlength));
            Console.WriteLine(sentence.Substring( maxlength+1,maxlength));
            by this our string of length 20 will not be even since we can get half words
        */

            var words = text.Split(' ');
            var totalChar = 0;
            var summarywords = new List<string>();


            foreach (var word in words)
            {
                summarywords.Add(word);

                totalChar += word.Length + 1;
                if (totalChar > maxlength)
                    break;

            }

            return String.Join(" ", summarywords) + "..."; ;


        }
    }
}
