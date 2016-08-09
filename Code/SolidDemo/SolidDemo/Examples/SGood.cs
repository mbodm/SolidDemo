using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.SGood
{
    public sealed class EinspritzAnlage
    {
        public void Einspritzen()
        {
            // Wird Benzin eingespritzt ? Stimmt das Misch-Verhältnis ?
            // Einspritzen.
        }
    }

    public sealed class ZündSystem
    {
        public void Zünden()
        {
            // Funktioniert die Elektrik ? Existiert ein Zünd-Funke an den Zünd-Kerzen ?
            // Zünden.
        }
    }

    public sealed class Motor
    {
        public void Beschleunigen(EinspritzAnlage einspritzAnlage, ZündSystem zündSystem)
        {
            // Allgemeiner (Motor-Eigener) Code ...

            einspritzAnlage.Einspritzen();
            zündSystem.Zünden();
        }
    }
}
