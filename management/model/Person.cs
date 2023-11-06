using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Person
    {
        private int id;
        private string firstname;
        private string lastname;
        private string gender;
        private string phone;
        private string email;

        public int Id { get { return id; } set { id = value; } }
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        public string Gender { get { return gender; } set { gender = value; } }
    }
