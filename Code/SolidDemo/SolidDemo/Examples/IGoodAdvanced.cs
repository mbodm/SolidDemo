using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.IGoodAdvanced
{
    public interface IFahrzeug
    {
        int FahrzeugGewicht { get; }

        void Fahren();
    }

    public interface IAuto
    {
        int KofferraumGrösse { get; }

        void AirbagAuslösen();
    }

    public interface IBagger
    {
        int BaggerArmLänge { get; }

        void Baggern();
    }

    public sealed class Fahrzeug : IFahrzeug
    {
        public int FahrzeugGewicht { get; private set; }

        public void Fahren()
        {
            // Code ...
        }
    }

    public sealed class Auto : IFahrzeug, IAuto
    {
        private IFahrzeug fahrzeug;

        public Auto(IFahrzeug fahrzeug)
        {
            this.fahrzeug = fahrzeug;

            FahrzeugGewicht = 900;
            KofferraumGrösse = 20;
        }

        public int FahrzeugGewicht { get; private set; }
        public int KofferraumGrösse { get; private set; }

        public void Fahren()
        {
            fahrzeug.Fahren();
        }

        public void AirbagAuslösen()
        {
            // Code ...
        }
    }

    public sealed class Bagger : IFahrzeug, IBagger
    {
        private IFahrzeug fahrzeug;

        public Bagger(IFahrzeug fahrzeug)
        {
            this.fahrzeug = fahrzeug;

            FahrzeugGewicht = 10000;
            BaggerArmLänge = 10;
        }

        public int FahrzeugGewicht { get; private set; }
        public int BaggerArmLänge { get; private set; }

        public void Fahren()
        {
            fahrzeug.Fahren();
        }

        public void Baggern()
        {
            // Code ...
        }
    }
}
