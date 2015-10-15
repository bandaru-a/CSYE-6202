using System;
namespace HealthRecordApp
{
	public enum Gender
	{
		Unspecified,
		Male,
		Female
	}

	public class HealthProfile
	{
        
		private const int UnknownValue = -1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }
        public int pateintAge;

        #region Methods

        public int CalculateAge()
		{
            int years;
            try
            {
                System.DateTime birth = DOB;
                System.DateTime today = System.DateTime.Now;
                System.TimeSpan span = today - birth;
                System.DateTime age = System.DateTime.MinValue + span;
                // Make adjustment due to MinValue equalling 1/1/1
                years = age.Year - 1;
            }
            catch
            {
                return UnknownValue;
            }
            pateintAge = years;
            return pateintAge;

		}

		public int CalculateMaxHeartRate()
		{
            if (pateintAge == -1)
                return UnknownValue;
            else
                return (220- pateintAge);
		}

		public decimal CalculateBMI()
		{
            decimal patientBMI;
            try
            {
                patientBMI = (decimal)(WeightInPounds * 703) / (HeightInInches * HeightInInches);
            }
            catch
            {
                return UnknownValue;
            }
            return decimal.Round(patientBMI,2);
		}

		public void DisplayPatientProfile()
		{
            int age = CalculateAge();
            decimal BMI = CalculateBMI();
            int heartRate = CalculateMaxHeartRate();
            Console.WriteLine("Displaying Patient Profile:");
            Console.WriteLine("===========================");
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Height: " + HeightInInches + " inches");
            Console.WriteLine("Weight: " + WeightInPounds + " pounds");
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Max Heart Rate: " + heartRate);
            Console.WriteLine("BMI: " + BMI);
            Console.Write("Press any key to continue...");
            Console.Read();
		}

		#endregion
	}
}
