using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegexExamples
{
    public static class RegexBasics
    {
        /*
         Quantifier: is a regex operator which matches preceding/forward char/item 0 or 1 times,
        in other word it says the preceding char 
        */

        public static void Ex1_Quantifier()
        {
            string[] testString = { "color", "colour", "colouur" };
            var rgxStr = "colou?r";//so the color spelling can contain i.e optional char 'u' before '?' char
            Regex rgx = new Regex(rgxStr, RegexOptions.Compiled);
            Console.WriteLine($"Regex pattern is: {rgxStr}");
            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(@$"String is: {testString[i]}; does it match: {rgx.IsMatch(testString[i])}");
            }

            var rgxStr2 = "colou?rs";
            var newStr = "So many colors in this world.";
            var matchProperty = Regex.Match(newStr, rgxStr2);
            Console.WriteLine($"{Environment.NewLine}{newStr}");
            Console.WriteLine($"String is: {newStr} , does it match: {matchProperty.Success}");

            Console.WriteLine($"Regex.Groups: {matchProperty.Groups.Values}");
            Console.WriteLine($"Regex.Index: {matchProperty.Index}");
            Console.WriteLine($"Regex.Length: {matchProperty.Length}");
            Console.WriteLine($"Regex.Name: {matchProperty.Name}");
            Console.WriteLine($"Regex.Value: {matchProperty.Value}");
            Console.WriteLine($"Regex.Captures: {matchProperty.Captures.Count}"); 
        }

        public static void Ex2_Regex_MulipleMatch()
        {
            // Regex engine by default works by scanning text from left to right (this can be changed though), 
            // it always return the first matching pattern (i.e. the left most match)

            var str = "Is red the color?, there are many colors in this world but black colour has it all, colours is an alternative spelling.";
            var rgxStr = "colou?rs?";
            Match m1 = Regex.Match(str,rgxStr);
            var list = GetAllMatched(m1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> GetAllMatched(Match matched)
        {
            List<string> matchedStr = new List<string>();
            var lastIndex = 0;
            var lastLength = 0;
            var lastValue = "";

            while (lastIndex != matched.Index && lastLength != matched.Length && lastValue != matched.Value)
            {
                lastIndex = matched.Index;
                lastLength = matched.Length;
                lastValue = matched.Value;

                matchedStr.Add(matched.Value);
                matched.NextMatch();
            }

            return matchedStr;
        }
    }
}
