using System;
using System.Collections.Generic;
using System.Text;

namespace UserClass
{
    public class User
    {
        private static List<string> users = new List<string>();

        public void Add(string userName)
        {
            users.Add(userName);
        }

        public int GetUsersCount()
        {
            return users.Count;
        }
    }
}
