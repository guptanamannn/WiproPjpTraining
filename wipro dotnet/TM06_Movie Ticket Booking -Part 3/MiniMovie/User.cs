using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMovie
{
    class User
    {
        public string UserName;
        public string Password;
        public string UserType;
        public User(string UserName,string Password,string UserType)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.UserType = UserType;
        }
    }
}
