using System;
using System.Collections.Generic;

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

            if (input.Length>2 && input.Substring(0, 2).Equals("//"))
            {
                regex = new string[] { ",", "\r", "\n" ,input.Substring(2,1) };
                input = input.Substring(2);
            }

            string[] numbers = input.Split(regex, StringSplitOptions.RemoveEmptyEntries);

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
                    sum += value;
                }                
            }

            if (negativeNumbers.Count > 0)
            {
                throw new Exception(String.Join(", ", negativeNumbers.ToArray()));
            }

            return sum;
        }
    }
}
