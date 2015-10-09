using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

        static void Main(string[] args)
        {
            // your implementation here
            Double totalCost = 0.0;
            while (1 == 1)
            {
                Console.Write("Please enter purchased gas type, Q/q to quit: ");
                string userInput = Console.ReadLine();
                if (!UserEnteredSentinelValue(userInput))
                {
                    if (UserEnteredValidGasType(userInput))
                    {
                        GasType gasType = GasTypeMapper(userInput.ToCharArray()[0]);
                        Console.Write("Please enter purchased gas amount, Q/q to quit: ");
                        userInput = Console.ReadLine();
                        if (!UserEnteredSentinelValue(userInput))
                        {
                            if (UserEnteredValidAmount(userInput))
                            {
                                CalculateTotalCost(gasType, Convert.ToInt16(userInput), ref totalCost);
                            }
                        }

                    }
                }

            } // end while


        }

        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
        {
            var result = false;
            if (!string.IsNullOrEmpty(userInput) && userInput.ToUpper() == "Q")
            {
                Console.WriteLine("Application terminated");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                result = true;
            }
            else
                result = false;
            return result;

        }

        // use this method to parse and check the characters entered
        // this does not conform 
        public static bool UserEnteredValidGasType(string userInput)
        {
            var result = false;

            if (!string.IsNullOrEmpty(userInput) && (userInput.ToUpper() == "R" || userInput.ToUpper() == "M" || userInput.ToUpper() == "P" || userInput.ToUpper() == "D"))
            {
                result = true;
            }
            else
                result = false;

            return result;
        }

        // use this method to parse and check the double type entered
        // please use Double.TryParse() method 
        public static bool UserEnteredValidAmount(string userInput)
        {
            var result = false;
            Double dblValue;
            // your implementation here
            result = Double.TryParse(userInput, out dblValue);
            return result;
        }

        // use this method to map a valid char entry to its enum representation
        // e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
        // this mapping "must" be used within CalculateTotalCost() method later on
        public static GasType GasTypeMapper(char c)
        {
            GasType gasType = GasType.None;
            // your implementation here
            if (c.ToString().ToUpper() == "R")
            {
                gasType = GasType.RegularGas;
            }
            else if (c.ToString().ToUpper() == "M")
            {
                gasType = GasType.MidgradeGas;
            }
            else if (c.ToString().ToUpper() == "P")
            {
                gasType = GasType.PremiumGas;
            }
            else if (c.ToString().ToUpper() == "D")
            {
                gasType = GasType.DieselFuel;
            }

            return gasType;
        }

        public static double GasPriceMapper(GasType gasType)
        {
            var result = 0.0;

            // your implementation here
            switch (gasType)
            {
                case GasType.RegularGas:
                    result = 1.94;
                    break;
                case GasType.PremiumGas:
                    result = 2.24;
                    break;
                case GasType.MidgradeGas:
                    result = 2;
                    break;
                case GasType.DieselFuel:
                    result = 2.17;
                    break;
            }
            return result;
        }

        public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
        {
            // your implementation here
            double Price = GasPriceMapper(gasType);
            totalCost = Price * gasAmount;
            Console.WriteLine("You bought " + gasAmount + " gallons of " + gasType + " at " + Price);
            Console.WriteLine("Your total cost for this purchase is : " + totalCost);

        }
    }
}
