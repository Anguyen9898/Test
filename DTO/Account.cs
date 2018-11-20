using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Account
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Account(string user, string pass)
        {
            this.UserName = user;
            this.PassWord = pass;
        }
    }
}
