namespace CodeWars.Challenges
{
    public static partial class Challenge
    {
        public static int DescendingOrder(int num)
        {
            char[] digits = num.ToString().ToCharArray();

            Array.Sort(digits);
            Array.Reverse(digits);

            string sortedNumStr = new string(digits);

            return int.Parse(sortedNumStr);
        }

        public static int DescendingOrderLinq(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}
