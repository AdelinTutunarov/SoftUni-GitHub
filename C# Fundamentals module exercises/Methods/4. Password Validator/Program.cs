using System;
using System.Linq;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            ValidatePassowrd(pass);
        }

        static bool NumberOfCharrCheck(string a)
        {
            return a.Length >= 6 && a.Length <= 10;
        }

        static bool NumberOfDigitsCheck(string a)
        {
            return a.Count(digits => "0123456789".Contains(digits)) >= 2;
        }

        static bool ContentCheck(string a)
        {
            foreach(char symbol in a)
            {
                if (!char.IsLetterOrDigit(symbol)) return false;
            }
            return true;
        }

        static void ValidatePassowrd(string a)
        {
            if (!NumberOfCharrCheck(a)) Console.WriteLine("Password must be between 6 and 10 characters");
            if (!ContentCheck(a)) Console.WriteLine("Password must consist only of letters and digits");
            if (!NumberOfDigitsCheck(a)) Console.WriteLine("Password must have at least 2 digits");
            if (NumberOfCharrCheck(a) && ContentCheck(a) && NumberOfDigitsCheck(a)) Console.WriteLine("Password is valid");
        }
    }
}
