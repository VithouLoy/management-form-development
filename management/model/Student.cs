using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.model
{
    internal class Student
    {
        private int id;
        private string firstname;
        private string lastname;
        private DateTime dob;
        private string position;
        private string phone;
        private string email;
        private string placeOfBirth;
        private string currentPlace;
        private string gender;

        public int Id { get { return id; } set { id = value; } }
        public string Firstname { get {  return firstname; } set {  firstname = value; } }
        public string Lastname { get { return lastname; } set {  lastname = value; } }
        public DateTime Dob { get {  return dob; } set {  dob = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PlaceOfBirth { get { return placeOfBirth; } set { placeOfBirth = value; } }
        public string CurrentPlace { get { return currentPlace; } set { currentPlace = value; } }
        public string Gender { get { return gender; } set { gender = value; } }    
        public string Position { get { return position; } set {  position = value; } }
    }
}
