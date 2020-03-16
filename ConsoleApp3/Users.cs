using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Login: {Login}, Password: {Password}";
        }

    }
    public enum Role
    {
        admin=1,
        user=0,
        moderator=69
    }
}
