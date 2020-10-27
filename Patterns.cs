using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string eMailPattern = "^[a-z]+([._+-][0-9a-z]+)*@[0-9a-zA-Z]+.[a-z]{2,4}([.][a-z]{2})$";
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="eMail">The e mail.</param>
        public void EmailCheck(string eMail)
        {
            ///validates First name and prints valid or invalid.
            if (Regex.IsMatch(eMail, eMailPattern ))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public static string phoneNoPattern = "^(9?1?)[:space:]?[0-9]{10}$";
        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNum">The phone number.</param>
        public void PhoneNoCheck(string phoneNum)
        {
            ///validates First name and prints valid or invalid.
            if (Regex.IsMatch(phoneNum, phoneNoPattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        /// <summary>
        /// Chceks the password.
        /// </summary>
        /// <param name="password">The password.</param>
        public void PasswordCheck(string password) 
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            ///To validate the password with all the conditions.
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && hasSymbols.IsMatch(password)) 
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
