using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
