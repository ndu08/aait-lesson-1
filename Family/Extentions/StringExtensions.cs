using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyStats.Extentions
{
    public static class StringExtensions
    {
        public static string SayHello(this string name)
        {
            return $"Hello {name}.";
        }

        // Create IsValidZipCode Extension Method to check if zip is 5 or 9 digits
        public static string IsValidZipCode1(this string zipCode)
        {
            string zip1 = string.Format(zipCode);
            return zip1;
        }
        public static bool IsValidZipCode(this string zip)
        {

         //   return zip.Length == 5 || zip.Length == 9;    just to check if zip 5 or 9 characters long

            var isValid = zip.Length == 5 || zip.Length == 9;

            if (isValid)
            {
                if (!Int32.TryParse(zip, out int n))
                {
                    isValid = false;
                }
            }
            return isValid;
        } 
    }
}
