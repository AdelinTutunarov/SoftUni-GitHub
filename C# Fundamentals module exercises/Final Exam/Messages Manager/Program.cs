using System;
using System.Collections.Generic;

namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int capacity = int.Parse(Console.ReadLine());
            string[] cmd = Console.ReadLine().Split("=");
            while (cmd[0] != "Statistics")
            {
                switch (cmd[0])
                {
                    case "Add":
                        if (!Exists(users, cmd[1]))
                        {
                            User user = new User(cmd[1], int.Parse(cmd[2]), int.Parse(cmd[3]));
                            users.Add(user);
                        }
                        break;
                    case "Message":
                        if(Exists(users,cmd[1]) && Exists(users, cmd[2]))
                        {
                            bool check = false;
                            foreach (var user in users)
                            {
                                if (user.userName == cmd[1])
                                {
                                    if (user.receivedMessages + user.sentMessages < capacity)
                                    {
                                        user.sentMessages++;
                                        check = true;
                                        if (user.receivedMessages + user.sentMessages == capacity)
                                        {
                                            users.Remove(user);
                                            Console.WriteLine($"{user.userName} reached the capacity!");
                                        }
                                    }
                                    break;
                                }
                            }
                            if (check)
                            {
                                foreach (var user in users)
                                {
                                    if (user.userName == cmd[2])
                                    {
                                        if (user.receivedMessages + user.sentMessages < capacity)
                                        {
                                            user.receivedMessages++;
                                            if (user.receivedMessages + user.sentMessages == capacity)
                                            {
                                                users.Remove(user);
                                                Console.WriteLine($"{user.userName} reached the capacity!");
                                            }
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    case "Empty":
                        if (cmd[1] == "All")
                        {
                            users.RemoveRange(0,users.Count);
                        }
                        else
                        {
                            foreach (var user in users)
                            {
                                if (cmd[1] == user.userName)
                                {
                                    users.Remove(user);
                                    break;
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }

                cmd = Console.ReadLine().Split("=");
            }
            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.userName} - {user.receivedMessages + user.sentMessages}");
            }
        }

        private static bool Exists(List<User> users, string v)
        {
            bool check = false;
            foreach (var user in users)
            {
                if (user.userName == v) check = true;
            }
            return check;
        }
    }
    class User
    {
        public string userName { get; set; }
        public int receivedMessages { get; set; }
        public int sentMessages { get; set; }
        public User(string name, int received, int sent)
        {
            userName = name;
            receivedMessages = received;
            sentMessages = sent;
        }
    }

}
