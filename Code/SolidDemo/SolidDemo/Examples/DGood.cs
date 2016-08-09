using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.DGood
{
    public interface ILogger
    {
        void Log(string text);
    }

    public sealed class TextFileLogger : ILogger
    {
        public void Log(string text)
        {
            // Code ...
        }
    }

    public sealed class SomeClass
    {
        private ILogger logger;

        public SomeClass(ILogger logger)
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
