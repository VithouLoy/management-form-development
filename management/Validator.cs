using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management
{
    internal class Validator
    {
        private Validator() { }

        public static bool isValueProvidedNotEmpty(string val)
        {
            return val.Trim().Length != 0;
        }

    }
}
