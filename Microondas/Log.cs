using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    class Log
    {

        private string log;

        public void add(string log)
        {
            this.log = log + "\n" + this.log;
        }

        public string getLog()
        {
            return log;
        }
    }
}
