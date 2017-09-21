using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortugalVistoCheckerTraySystem
{
    static class Global
    {
        private static int _interval;
        private static string _lastResult;
        private static DateTime _lastExecution;
        private static DateTime _nextExecution;

        public static int Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        public static string LastResult
        {
            get { return _lastResult; }
            set { _lastResult = value; }
        }

        public static DateTime LastExecution
        {
            get { return _lastExecution; }
            set { _lastExecution = value; }
        }

        public static DateTime NextExecution
        {
            get { return _nextExecution; }
            set { _nextExecution = value; }
        }
    }
}
