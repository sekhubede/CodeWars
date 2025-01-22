namespace CodeWars.Challenges.DivisorsChallenge
{
    public class Divisors
    {
        public static int[] Solution(int n)
        {
            var divisors = new List<int>();

            for (int i = 2; i <= n / 2; i++) // Only check up to n / 2
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                }
            }

            // Check if any divisors were found
            return divisors.Count > 0 ? divisors.ToArray() : null;
        }

        public static int[] Solution2(int n)
        {
            var divisors = Enumerable.Range(2, n - 2).Where(x => n % x == 0).ToArray();
            return divisors.Length == 0 ? null : divisors;
        }
    }
}
