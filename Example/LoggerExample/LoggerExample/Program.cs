using System;

namespace LoggerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("LoggerExample (to demonstrate Interfaces and the \"D\" of SOLID principles)");
            Console.WriteLine();

            // Dies könnte auch aus einem DI-Container kommen:

            ILogger databaseLogger = new DatabaseLogger();
            ILogger textfileLogger = new TextfileLogger();

            SomeClass1 someClass1 = new SomeClass1(databaseLogger);
            SomeClass2 someClass2 = new SomeClass2(textfileLogger);

            // Hier kommt unsere "Business-Logic", also der "Software-Kern", wo alle Module genutzt werden:

            someClass1.CoolMethod();
            someClass2.FreakyMethod();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
