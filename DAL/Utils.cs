using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BCrypt.Net;
namespace DAL
{
    public class Utils
    {
		public static string convertToUnSign(string s)
		{
			Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
			string temp = s.Normalize(NormalizationForm.FormD);
			return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
		}
		private static string GetRandomSalt()
		{
			return BCrypt.Net.BCrypt.GenerateSalt(12);
		}

		public static string HashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
		}

		public static bool ValidatePassword(string password, string correctHash)
		{
			try
			{
				return BCrypt.Net.BCrypt.Verify(password, correctHash);
			}
			catch(Exception)
			{
				return false;
			}
		}
		public static bool ValidateRowversion(byte[] correctRowVersion, string rowVersion_stored)
		{
			return BitConverter.ToUInt64(correctRowVersion, 0).ToString().Equals(rowVersion_stored);
		}
	}
}
