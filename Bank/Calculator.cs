using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Calculator
    {

        public static int Add(string input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            string[] regex = new string[] { ",", "\r", "\n" };
            
            List<string> delimiters = new List<string>(regex);

            if (input.Length > 2 && input.IndexOf("[")>-1)
            {
                var pattern = @"\[(.*?)\]";
                var matches = Regex.Matches(input, pattern);

                foreach (Match m in matches)
                {
                    delimiters.Add(m.Groups[1].ToString());
                    Console.WriteLine(m.Groups[1]);
                }
                int indexClosingBracket = input.IndexOf("]");
                delimiters.Add(input.Substring(2, 1));
                input = input.Substring(indexClosingBracket+1);
            }

            string[] numbers = input.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            List<int> negativeNumbers = new List<int>();

            foreach (string number in numbers)
            {
                int value = int.Parse(number);
                if (value < 0)
                {
                    negativeNumbers.Add(value);
                }
                else
                {
                    if (value <= 1000)
                    {
                        sum += value;
                    }
                }
            }

            if (negativeNumbers.Count > 0)
            {
                throw new Exception("Negatives not allowed: " + String.Join(", ", negativeNumbers.ToArray()));
            }

            return sum;
        }
    }
}
