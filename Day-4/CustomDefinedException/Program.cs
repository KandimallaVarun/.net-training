using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDefinedException
{

    class PasswordException : Exception
    {
        public PasswordException(string message) : base(message)
        {
        }
    }

    class ValidatePassword
    {
        public void Validate(string password)
        {
            if (password.Length < 8)
            {
                throw new PasswordException("Password must be at least 8 characters long.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String password = Console.ReadLine();

            try
            {
                ValidatePassword validatePassword = new ValidatePassword();
                validatePassword.Validate(password);
                Console.WriteLine("Password is valid.");
            }
            catch (PasswordException ex)
            {
                Console.WriteLine($"Password validation failed: {ex.Message}");
            }
        }
    }
    
}
