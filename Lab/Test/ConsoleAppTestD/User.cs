using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestD
{
    internal class User
    {
        public string Name;
        public int Age;
        public string Email;
        public string City;
        public User(string name, int age, string email, string city)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.City = city;
        }
        public void UpdateDetails(string name, int age, string email, string city)
        {
            Name = name;
            Age = age;
            Email = email;
            City = city;
        }
    }
}
