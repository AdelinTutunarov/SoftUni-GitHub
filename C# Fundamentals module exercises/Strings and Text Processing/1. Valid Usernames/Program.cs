using System;

namespace _1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool valid = true;
                    for (int i = 0; i < username.Length; i++)
                    {
                        if(!(username[i] == '-' || username[i] == '_' || char.IsLetterOrDigit(username[i])))
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
