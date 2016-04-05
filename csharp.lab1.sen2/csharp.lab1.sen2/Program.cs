using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine(text);
            int index = 0;
                
            string[] Words = { "PHP", "CLR", "Microsoft" };

            while (index <= text.Length - 1)
            {
                for (int i = 0; i < Words.Length; i++)
                {
                    string word = Words[i].ToUpper();
                    if (text.IndexOf(Words[i], index, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        Regex.Replace(text, Words[i], new string('*', Words.Length), RegexOptions.IgnoreCase);
                    }
                }
                index++;
            }
            Console.WriteLine(text);
            Console.ReadLine();
        }
        
    } 
}
