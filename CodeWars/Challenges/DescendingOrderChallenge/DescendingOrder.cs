namespace CodeWars.Challenges.DescendingOrderChallenge
{
    public class DescendingOrder
    {
        public static int Solution(int num)
        {
            char[] digits = num.ToString().ToCharArray();

            Array.Sort(digits);
            Array.Reverse(digits);

            string sortedNumStr = new string(digits);

            return int.Parse(sortedNumStr);
        }

        public static int Solution2(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}
