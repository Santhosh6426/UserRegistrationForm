/*
*  C# CODING STANDARDS - LINE SPACE
* NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
*/

/******************************************************************************
 *  Compilation:  C:\Users\Santhu\source\repos\UserRegistrationForm\bin\Debug\netcoreapp3.1\UserRegistrationForm.exe
 *  Execution:    UserRegistrationForm.exe
 *  
 *  Purpose: To validate the user inputs in the User Registration Form.
 *
 *  @author  Santhosh V
 *  @version 2019
 *  @since   2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace UserRegistrationForm
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Form!");
            Console.WriteLine("Enter your First Name : ");
            ///Takes First Name
            string takeFirstName = Console.ReadLine();
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.NameCheck(takeFirstName));
            Console.WriteLine("Enter your Last Name : ");
            ///takes Last Name
            string takeLastName = Console.ReadLine();
            ///making use of same method of first name.
            Console.WriteLine(patterns.NameCheck(takeLastName));
            Console.WriteLine("Enter your Email Id : ");
            string takeEmail = Console.ReadLine();
            Console.WriteLine( patterns.EmailCheck(takeEmail));
            ///To check for the Phone number.
            Console.WriteLine("Enter your Phone Number : ");
            string takePhoneNumber = Console.ReadLine();
            Console.WriteLine( patterns.PhoneNoCheck(takePhoneNumber));
            ///To take password
            Console.WriteLine("Enter your Password : ");
            string takePassword = Console.ReadLine();
            Console.WriteLine(patterns.PasswordCheck(takePassword));
        }
    }
}
