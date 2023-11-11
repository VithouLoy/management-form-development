using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management.constant
{
    internal class Query
    {
        public static String buildLikeQuery(string field)
        {
            return string.Format(" {0} LIKE {0} OR {0} IS NULL ", field);
        }
    }
}
