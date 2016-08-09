using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.DBad
{
    public sealed class TextFileLogger
    {
        public void Log(string text)
        {
            // Code ...
        }
    }

    public sealed class SomeClass
    {
        private TextFileLogger logger;

        public SomeClass(TextFileLogger logger)
        {
            this.logger = logger;
        }

        private void SomeMethod()
        {
            // Code ...
            logger.Log("error 0815");
            // Code ...
        }
    }
}
