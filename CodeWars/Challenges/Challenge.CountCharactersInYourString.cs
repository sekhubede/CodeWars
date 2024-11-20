using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static Dictionary<char, int> GetCharacterCount(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return new Dictionary<char, int>();
            }

            var characterCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (!characterCount.ContainsKey(c))
                {
                    characterCount.Add(c, 1);
                    continue;
                }

                characterCount[c] += 1;
            }

            return characterCount;
        }

        public static Dictionary<char, int> GetCharacterCountEx(string str)
        {
            var characterCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (characterCount.TryGetValue(c, out int count))
                {
                    characterCount[c] = count + 1;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }

            return characterCount;
        }
    }
}
