using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationForm
{
    class Patterns
    {
        /// <summary>
        /// The first name pattern to validate
        /// </summary>
        public static string firstNamePattern = "^([A-Z]{1}[a-zA-Z]{2,})$";
        /// <summary>
        /// Firsts the name check.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public void FirstNameCheck(string firstName) 
        {
            ///validates First name and prints valid or invalid.
            if (Regex.IsMatch(firstName, firstNamePattern)) 
            {
                Console.WriteLine( "Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
