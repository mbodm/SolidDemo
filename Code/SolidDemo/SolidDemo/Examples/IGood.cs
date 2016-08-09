using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidDemo.IGood
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

    public sealed class Auto : IFahrzeug, IAuto
    {
        public int FahrzeugGewicht { get; private set; }
        public int KofferraumGrösse { get; private set; }

        public Auto()
        {
            FahrzeugGewicht = 900;
            KofferraumGrösse = 20;
        }

        public void Fahren()
        {
            // Code ...
        }

        public void AirbagAuslösen()
        {
            // Code ...
        }
    }

    public sealed class Bagger : IFahrzeug, IBagger
    {
        public int FahrzeugGewicht { get; private set; }
        public int BaggerArmLänge { get; private set; }

        public Bagger()
        {
            FahrzeugGewicht = 10000;
            BaggerArmLänge = 10;
        }

        public void Fahren()
        {
            // Code ...
        }

        public void Baggern()
        {
            // Code ...
        }
    }
}
