using System;
using System.Collections.Generic;

namespace Summarizing
{
    class Summarizing_Text
    {
        
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really really  long text.";
            var summary = StringUtility.SummarizeText(sentence); //(sentence, 30) if user exxplicitly defines max length else inbuilt is 20
            Console.WriteLine(summary);
        }
    }
}
