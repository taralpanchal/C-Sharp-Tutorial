using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalchar = 0;
            var summerizeword = new List<string>();

            foreach (var word in words)
            {
                summerizeword.Add(word);

                totalchar += word.Length + 1;

                if (totalchar > maxLength)
                    break;
            }
            return String.Join(" ", summerizeword) + "...";


        }

    }
}
