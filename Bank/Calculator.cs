namespace Calculator
{
    public class Calculator
    {

        public static int Add(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            int result = int.Parse(numbers);

            return result;
        }
    }
}
