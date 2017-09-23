using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugalVisaSEFCheckerTraySystem
{
    static class Global
    {
        public static int Interval
        {
            get;
            set;
        }

        public static string LastResult
        {
            get;
            set;
        }

        public static DateTime LastExecution
        {
            get;
            set;
        }

        public static DateTime NextExecution
        {
            get;
            set;
        }
    }
}
