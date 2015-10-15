using System;

namespace HealthRecordApp
{
	public class HealthProfileHelper
	{
        

        public static bool ValidateFirstName(string firstName)
		{
            if (string.IsNullOrWhiteSpace(firstName))
            {
                return false;
            }
            else
                return true;
                
		}

		public static bool ValidateLastName(string lastName)
		{
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
                return true;
            
		}

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{
            Gender gndr;
            try
            {
                gndr = (Gender)Enum.Parse(typeof(Gender), enteredGender);
            }
            catch
            {
                return false;
            }
            patientGender = gndr;            
            return true;
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
           DateTime result;
           if(DateTime.TryParse(enteredDOB,out result))
            {
                if (result > DateTime.Now)
                    return false;
                patientDOB = DateTime.Parse(enteredDOB, new System.Globalization.CultureInfo("en-US", true));
                return true;
            }
            return false;
        }

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
            int result;
            if(!int.TryParse(heightInString, out result))
            {
                    return false;
            }
            else
            {
                if (result <= 0)
                {
                    return false;
                }
                else
                {
                    patientHeight = result;
                    return true;
                }
            }
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            int result;
            if (!int.TryParse(weightInString, out result))
            {                
                return false;
            }
            else
            {
                if (result <= 0)
                {
                    return false;
                }
                else
                {
                    patientWeight = result;
                    return true;
                }
            }
        }

	}
}
