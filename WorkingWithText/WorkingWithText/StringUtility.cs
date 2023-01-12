using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {

            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');
            var totalCharacter = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacter += word.Length + 1;
                if (totalCharacter > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";
        }
    }
}
