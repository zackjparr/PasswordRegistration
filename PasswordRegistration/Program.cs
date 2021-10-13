using System;
using System.Collections.Generic;
using System.Linq;

namespace PasswordRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();

            string username = GetUsername("Enter a username: ");
            string password = GetPassword("Enter a password: ");
            bool userValid = UsernameValidate(username);
            bool passValid = PasswordValidate(password);

            if (userValid == true && passValid == true && !usernames.Contains(username))
                {
                    usernames.Add(username);
                    passwords.Add(password);
                    Console.WriteLine($"Username: {username}\nPassword: {password}\nSuccessfully registered!");
                }
            else
                {
                    Console.WriteLine("Please enter valid inputs.");
                }
        }

        public static string GetUsername(string prompt)
        {
            Console.WriteLine(prompt);
            string usernameOutput = Console.ReadLine();

            return usernameOutput;
        }

        public static string GetPassword(string prompt)
        {
            Console.WriteLine(prompt);
            string passwordOutput = Console.ReadLine();

            return passwordOutput;
        }

        public static bool UsernameValidate(string uname) 
        {

            if (uname.Length >= 7 && uname.Length <= 12 && uname.Any(char.IsLetter) && uname.Any(char.IsNumber))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid username. Must be between 7 and 12 characters, and contain 1 letter and number.");
                return false;
            }
        }
        public static bool PasswordValidate(string pword)
        {

            if (pword.Any(char.IsUpper) && pword.Any(char.IsLower) && pword.Any(char.IsNumber) && pword.Length >= 7 && pword.Length <= 12)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Please enter a valid password. Must contain one lowercase, one uppercase, 1 number, and be between 7 and 12 characters.");
                return false;
            }
        }

        //public static bool Continue()
        //{
        //    string answer = GetInput("Would you like to continue? y/n");

        //    if (answer == "y")
        //    {
        //        return true;
        //    }
        //    else if (answer == "n")
        //    {
        //        Console.WriteLine("Goodbye!");
        //        return false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("I'm sorry I didn't understand");
        //        Console.WriteLine("Let's try again.");
        //        return Continue();
        //    }
        //}

        //public static string GetInput(string prompt)
        //{
        //    Console.WriteLine(prompt);
        //    string output = Console.ReadLine();
        //    return output;
        }

        //public static bool DuplicateUser(string username)
        //{
        //    if (usernames.Contains(username) == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Username already exists!");
        //    }
        //}


    }

