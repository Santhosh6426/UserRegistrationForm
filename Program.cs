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
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Form!");
            Console.WriteLine("Enter your First Name : ");
            string takeFirstName=Console.ReadLine();
            Patterns patterns = new Patterns();
            patterns.FirstNameCheck(takeFirstName);
        }
    }
}
