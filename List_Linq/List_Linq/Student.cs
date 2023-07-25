using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Linq
{
    public class Student
    {
        private string id;
        private string name;
        private string address;
        private string email;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        public Student(string id, string name, string address, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Email = email;
        }

        public Student()
        {
        }

        public override string? ToString()
        {
            return Id + " " + Name + " " + Address + " " + Email;
        }
    }
}
