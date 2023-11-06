using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Student : PersonDetail
    {
        private string position;
        private string profile;

        public string Position {  get { return position; } set {  position = value; } }

        public string Profile { get { return profile; } set { profile = value; } }
    }
