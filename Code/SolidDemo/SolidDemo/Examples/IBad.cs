using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.IBad
{
    public interface IFahrzeug
    {
        // Erste Version.
        int FahrzeugGewicht { get; }
        void Fahren();

        // Später für ein Auto hinzugefügt.
        int KofferraumGrösse { get; }
        void AirbagAuslösen();

        // Noch später für einen Bagger hinzugefügt.
        int BaggerArmLänge { get; }
        void Baggern();
    }

    public sealed class Auto : IFahrzeug
    {
        public int FahrzeugGewicht { get; private set; }
        public int KofferraumGrösse { get; private set; }
        public int BaggerArmLänge { get; private set; }

        public Auto()
        {
            FahrzeugGewicht = 900;
            KofferraumGrösse = 20;
            BaggerArmLänge = 0; // Hat ein Auto nicht.
        }

        public void Fahren()
        {
            // Code ...
        }

        public void AirbagAuslösen()
        {
            // Code ...
        }

        public void Baggern()
        {
            throw new NotImplementedException(); // Kann ein Auto nicht.
        }
    }

    public sealed class Bagger : IFahrzeug
    {
        public int FahrzeugGewicht { get; private set; }
        public int KofferraumGrösse { get; private set; }
        public int BaggerArmLänge { get; private set; }

        public Bagger()
        {
            FahrzeugGewicht = 10000;
            KofferraumGrösse = 0; // Hat ein Bagger nicht.
            BaggerArmLänge = 10;
        }

        public void Fahren()
        {
            // Code ...
        }

        public void AirbagAuslösen()
        {
            throw new NotImplementedException(); // Kann ein Bagger nicht.
        }

        public void Baggern()
        {
            // Code ...
        }
    }
}
