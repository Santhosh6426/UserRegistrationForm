using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationForm
{
    public class Patterns
    {
        /// <summary>
        /// The first name pattern to validate
        /// </summary>
        public static string firstNamePattern = "^([A-Z]{1}[a-zA-Z]{2,})$";
        /// <summary>
        /// Firsts the name check.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        public string NameCheck(string firstName) 
        {
            ///validates First name and prints valid or invalid.
            if (Regex.IsMatch(firstName, firstNamePattern)) 
            {
                return "valid";
            }
            else
            {
                return "invalid!";
            }
        }
        public static string eMailPattern = "^[a-z]+([._+-][0-9a-z]+)*@[0-9a-zA-Z]+.[a-z]{2,4}([.][a-z]{2})$";
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="eMail">The e mail.</param>
        public string EmailCheck(string eMail)
        {
            ///validates First name and prints valid or invalid.
            if (Regex.IsMatch(eMail, eMailPattern ))
            {
                return "valid";
            }
            else
            {
                return "invalid!";
            }
        }
        public static string phoneNoPattern = "^(9?1?)[:space:]?[0-9]{10}$";
        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNum">The phone number.</param>
        public string PhoneNoCheck(string phoneNum)
        {
            ///validates First name and prints valid or invalid.
            if(Regex.IsMatch(phoneNum,phoneNoPattern))
            {
                return "valid";
            }
            else
            {
                return "invalid!";
            }
        }
        /// <summary>
        /// Chceks the password.
        /// </summary>
        /// <param name="password">The password.</param>
        public string PasswordCheck(string password) 
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            ///To validate the password with all the conditions.
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && hasSymbols.IsMatch(password))
            {
                return "valid";
            }
            else
            {
                return "invalid!";
            }
        }
    }
}
