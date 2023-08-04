using System;

namespace LoggerExample
{
    public sealed class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Log to database...

            Console.WriteLine($"Habe in Datenbank geloggt: \"{message}\"");
        }
    }
}
