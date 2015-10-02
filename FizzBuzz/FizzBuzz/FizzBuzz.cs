namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            // your solution/implementation should go in here
            if (number == 0)
            {
                return "0";
            }

            if (number % 3 == 0)
            {
                System.Console.WriteLine("Fizz");
                result = "Fizz";
            }
            else if (number % 5 == 0)
            {
                System.Console.WriteLine("Buzz");
                result = "Buzz";
            }
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                System.Console.WriteLine("FizzBuzz");
                result = "FizzBuzz";
            }

            return result;
            
		}
	}
}
