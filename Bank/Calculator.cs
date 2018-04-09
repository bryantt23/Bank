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

            string[] nums = numbers.Split(',');

            int result = 0;

            foreach(string n in nums){
                result+=int.Parse(n);
            }

            return result;
        }
    }
}
