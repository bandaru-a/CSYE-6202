using System;
namespace HealthRecordApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Gender genderValue = new Gender();
            int enteredHeight=0, enteredWeight=0;
            DateTime enteredDOB=Convert.ToDateTime("01/01/1900");
            string genderInput, dobInput, heightInput, weightInput;
            HealthProfile hlthProf = new HealthProfile();

            Console.Write("Please enter patient's first name: ");
            hlthProf.FirstName = Console.ReadLine();
            while(!HealthProfileHelper.ValidateFirstName(hlthProf.FirstName))
            {
                Console.Write("Invalid first name. Please enter patient's first name: ");
                hlthProf.FirstName = Console.ReadLine(); 
            }

            Console.Write("Please enter patient's last name: ");
            hlthProf.LastName = Console.ReadLine();
            while(!HealthProfileHelper.ValidateLastName(hlthProf.LastName))
            {
                Console.Write("Invalid last name. Please enter patient's last name: ");
                hlthProf.LastName = Console.ReadLine();
            }

            Console.Write("Please enter gender (Unspecified/Male/Female): ");
            genderInput= Console.ReadLine();
            while (!HealthProfileHelper.ValidateGender(genderInput, ref genderValue))
            {
                Console.Write("Invalid gender.Please enter gender (Unspecified/Male/Female): ");
                genderInput = Console.ReadLine();
            }
            hlthProf.Gender = genderValue;

            Console.Write("Please enter patient's date of birth: ");
            dobInput = Console.ReadLine();
            while(!HealthProfileHelper.ValidateDateOfBirth(dobInput, ref enteredDOB))
            {
                Console.Write("Invalid date of birth.Please enter patient's date of birth: ");
                dobInput = Console.ReadLine();
            }
            hlthProf.DOB = enteredDOB;

            Console.Write("Please enter patient's height: ");
            heightInput = Console.ReadLine();
            while(!HealthProfileHelper.ValidateHeight(heightInput, ref enteredHeight))
            {
                Console.Write("Invalid height. Please enter patient's height: ");
                heightInput = Console.ReadLine();
            }

            hlthProf.HeightInInches = enteredHeight;

            Console.Write("Please enter patient's weight: ");
            weightInput = Console.ReadLine();
            while(!HealthProfileHelper.ValidateWeight(weightInput, ref enteredWeight))
            {
                Console.Write("Invalid weight. Please enter patient's weight: ");
                weightInput = Console.ReadLine();
            }
            hlthProf.WeightInPounds = enteredWeight;

            Console.WriteLine();
            hlthProf.DisplayPatientProfile();

        }
	}
}
