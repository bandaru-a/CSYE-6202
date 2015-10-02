namespace FindingPrimeNumbers
{
	public class FindingPrimeNumbers
	{
		public long FindSumOfPrimeNumbers(int n)
		{
            // your solution goes in here
            long sum = 0;
            int j, count = 0, number = 2, flag = 1;

            while (count < n)
            {
                for (j = 2; j <= (number / 2); j++)
                {
                    if (number % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                    flag = 1;
                }
                if (flag != 0)
                {
                    sum = sum + number;
                    count++;
                }
                number++;
            }
            System.Console.WriteLine("Sum Is" + sum);
            return sum;
		}
	}
}
