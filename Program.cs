using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Password Registration System!");
                Console.WriteLine("Let's get started!");
                EmailValidate();
                PasswordValidate();
                run = Continue();
            }
        }

        static void EmailValidate()
        {
            bool run = true;

            while (run == true)
            {
                List<string> Email = new List<string>();
                Console.Write("Please enter a valid email address: ");
                string userEmail = Console.ReadLine();
                Email.Add(userEmail);
                try
                {
                    if (Regex.IsMatch(userEmail, @"^[A-z0-9]{3,30}@[a-z]{3,10}.[a-z]{2,3}$"))
                    {
                        Console.WriteLine("Your email address was successfully added!");
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid email address, please try again.");
                    }
                }
                catch (FormatException)
                {

                }
            }
        }
        static void PasswordValidate()
        {
            bool run = true;
            while (run == true)
            {
                List<string> Password = new List<string>();
                Console.WriteLine("Please create a password");
                Console.WriteLine("Your password must contain at least five characters long , contain at least one upper case letter and contain at least one number");
                Console.Write("Password: ");
                string userPassword = Console.ReadLine();
                Password.Add(userPassword);
                try
                {
                    if (Regex.IsMatch(userPassword, @"^[A-z0-9]{5,25}$"))
                    {
                        Console.WriteLine("Your password was successfully added!");
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid password, please try again.");
                    }
                }
                catch (FormatException)
                {
                }
            }
            Console.WriteLine("Congratulations! Your information has been successfully added to to the system!");
        }
        public static bool Continue()
        {
            Console.Write("Would you like to continue the program? y/n: ");
            string input = Console.ReadLine().ToLower();
            bool end;
            if (input == "y")
            {
                end = true;
                Console.Clear();
            }
            else if (input == "n")
            {
                end = false;
                Console.WriteLine("Goodbye! Thanks for coming!");
            }
            else
            {
                Console.WriteLine("I'm sorry, that is not a valid response. Please enter Y or N");
                end = Continue();
            }
            return end;
        }
    }
}
