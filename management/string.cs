using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management
{
    internal class @string
    {
        private @string() { }

        public static bool NonNull(string val)
        {
            return val.Trim().Length != 0;
        }

        public static bool IsNullOrEmpty(string val)
        {
            return !NonNull(val);
        }

    }
}
