using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Files
{
    public class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public User(int id, string name, string address, string contact)
        {
            Id = id;
            Name = name;
            Address = address;
            Contact = contact;
        }

        public string GetUserInfo()
        {
            return $"Id: {Id}, Name: {Name}, Address: {Address} and Contact: {Contact}.";
        }
    }
}
