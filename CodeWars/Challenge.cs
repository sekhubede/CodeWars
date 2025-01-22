using CodeWars.Challenges.BreakCamelCaseChallenge;
using CodeWars.Challenges.ClassicHelloWorldChallenge;

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

        public static void ClassicHelloWorld(string[] args) => Console.WriteLine("Hello World!");
    }
}
