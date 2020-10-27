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
    }
}
