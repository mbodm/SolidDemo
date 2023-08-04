using System;

namespace LoggerExample
{
    public sealed class TextfileLogger : ILogger
    {
        public void Log(string message)
        {
            // Log to text file...

            Console.WriteLine($"Habe in Textdatei geloggt: \"{message}\"");
        }
    }
}
