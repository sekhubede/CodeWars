namespace CodeWars
{
    public class Challenge
    {
        public static string RunBreakCamelCase()
        {
            return BreakCamelCase.Solution("camelCasing");
        }

        public static void RunClassicHelloWorld() 
        {
            ClassicHelloWorld.Solution(new string[] { "Greetings from Javatlacati" });
        }

        public static string RunComplementaryDNA()
        {
            return ComplementaryDNA.Solution("ATTGC");
        }

        public static string RunConvertNumberToString()
        {
            return ConvertNumberToString.Solution(123);
        }

        public static Dictionary<char, int> RunCountCharactersInYourString()
        {
            return CountCharactersInYourString.Solution("");
        }

        public static string RunCreatePhoneNumber()
        {
            return CreatePhoneNumber.Solution(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        }

        public static int RunDescendingOrder()
        {
            return DescendingOrder.Solution(42145);
        }

        public static int[] RunDivisors()
        {
            return Divisors.Solution(15);
        }

        public static int RunFindTheStrayNumber()
        {
            return FindTheStrayNumber.Solution(new int[] { 1, 1, 2 });
        }

        public static string RunFizzBuzz()
        {
            return FizzBuzz.Solution(15);
        }

        public static string RunHelloWorld()
        {
            return HelloWorld.Solution();
        }

        public static bool RunIpValidation()
        {
            return IpValidation.Solution("12.255.56.1");
        }

        public static bool RunIsNumberPrime()
        {
            return IsNumberPrime.Solution(7);
        }

        public static int RunNumberOfPeopleInTheBus()
        {
            return NumberOfPeopleInTheBus.Solution(new List<int[]> { new int[] { 10, 0 }, new int[] { 3, 5 }, new int[] { 5, 8 } });
        }

        public static bool RunRegexValidatePinCode()
        {
            return RegexValidatePinCode.Solution("-1.234");
        }

        public static string RunReversedString()
        {
            return ReversedString.Solution("world");
        }

        public static string RunReverseWords()
        {
            return ReverseWords.Solution("This is an example!");
        }
    }
}
