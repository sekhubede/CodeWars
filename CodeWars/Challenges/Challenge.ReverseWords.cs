using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public partial class Challenge
    {
        public static string ReverseWords(string str)
        {
            var newString = str.Split(' ');

            var sb = new StringBuilder();

            for (int i = 0; i < newString.Length; i++)
            {
                var revWord = new string(newString[i].Reverse().ToArray());

                sb.Append(revWord).Append(" ");

            }

            return sb.ToString().TrimEnd();
        }

        public static string ReverseWords_Linq(string str) => 
            string.Join(" ", str.Split(' ')
                .Select(word => new string(word.Reverse().ToArray())));
    }
}
