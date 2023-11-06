using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class PersonDetail : Person
    {
        private string placeOfBirth;
        private string currentPlace;
        private DateTime dob;

        public string PlaceOfBirth { get { return placeOfBirth; } set { placeOfBirth = value; } }
        public string CurrentPlace { get { return currentPlace; } set { currentPlace = value; } }

        public DateTime Dob { get { return dob; } set { dob = value; } }

    }

