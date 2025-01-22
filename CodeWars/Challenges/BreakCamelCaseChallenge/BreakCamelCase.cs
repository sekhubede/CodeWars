using System.Text;
using System.Linq;

namespace CodeWars.Challenges.BreakCamelCaseChallenge
{
    public class BreakCamelCase
    {
        public static string Solution(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                // Check if the character is uppercase
                if (char.IsUpper(c))
                {
                    // Add a space before the uppercase letter
                    result.Append(' ');
                }

                // Add the character itself
                result.Append(c);
            }

            return result.ToString();
        }

        public static string Solution2(string str)
        {
            return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
        }
    }
}
