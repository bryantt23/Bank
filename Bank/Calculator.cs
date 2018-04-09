using System;

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

            string[] numbers = input.Split(new string[] { ",", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            foreach (string number in numbers)
            {
                sum += int.Parse(number);
            }

            return sum;
        }
    }
}
