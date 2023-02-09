using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class FileLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to file");
        }
    }
}
