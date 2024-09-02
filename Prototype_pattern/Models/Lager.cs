using BeerPrototype.Interfaces;

namespace BeerPrototype.Models
{
    public class Lager : Beer, IMyCloneable<Lager>
    {
        // Время выдержки
        public int LageringTime { get; set; }

        public Lager(string name, double alcoholPercentage, int lageringTime) : base(name, alcoholPercentage)
        {
            LageringTime = lageringTime;
        }

        public override Beer Clone()
        {
            return new Lager(Name, AlcoholPercentage, LageringTime);
        }

        Lager IMyCloneable<Lager>.Clone()
        {
            return (Lager)((Beer)this).Clone();
        }
    }
}