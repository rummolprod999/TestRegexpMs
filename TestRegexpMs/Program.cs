using System;
using System.Text.RegularExpressions;

namespace TestRegexpMs
{
    public static class TestRegexpMs
    {
        public static void Main()
        {
            var input = "capybara,squirrel,chipmunk,porcupine,gopher," +
                        "beaver,groundhog,hamster,guinea pig,gerbil," +
                        "chinchilla,prairie dog,mouse,rat";
            var pattern = @"\G(\w+\s?\w*),?";
            var match = Regex.Match(input, pattern);
            while (match.Success)
            {
                Console.WriteLine(match.Groups[1].Value);
                match = match.NextMatch();
            }

            pattern = @"\G(\(\d\))";
            input = "(1)(3)(5)[7](9)";
            match = Regex.Match(input, pattern);
            while (match.Success)
            {
                Console.WriteLine(match.Groups[1].Value);
                match = match.NextMatch();
            }
        }
    }
}