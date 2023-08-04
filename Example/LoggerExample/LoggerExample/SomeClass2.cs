using System;

namespace LoggerExample
{
    // Das hier ist irgendeine Klasse, die Dinge tut (quasi ein "Software-Modul"):

    public sealed class SomeClass2
    {
        private readonly ILogger logger;

        public SomeClass2(ILogger logger)
        {
            // Wir programmieren immer gegen eine Abstraktion (das "D" von SOLID) und machen uns niemals direkt von konkreten Klassen abhängig.
            // Das bedetet: Die Abhängigkeiten in diesem Modul werden NICHT innerhalb des Moduls hier mit "new()" erzeugt, noch werden direkt
            // konkrete Klassen im Konstruktor eingespritzt und verwendet. Stattdessen sagen wir: "Gib mir bitte iiiiirgendein Objekt, das den
            // Vertrag implementiert und mir verspricht, dass ich darauf sicher eine .Log() Methode aufrufen kann". Das nennt man Abstraktion.
            // Die Frage, WIE sich unser Modul hier (bezogen auf Logging) verhalten soll, bestimmen wir nun von "aussen" und dies bedeutet wir
            // müssen dieses Modul hier NICHT anfassen (und ggf. nochmals testen), wenn wir hier künftig ein anderes Logging-Verhalten wollen.

            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void FreakyMethod()
        {
            // Tolle "Modul-eigene" Dinge passieren hier und diese Klasse sollte dabei auch immer das "S" von SOLID beachten!

            logger.Log("Ich bin eine total verrückte Methode!");

            // Tolle "Modul-eigene" Dinge passieren hier und diese Klasse sollte dabei auch immer das "S" von SOLID beachten!
        }
    }
}
