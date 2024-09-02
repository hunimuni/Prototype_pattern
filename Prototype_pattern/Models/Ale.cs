using BeerPrototype.Interfaces;

namespace BeerPrototype.Models
{
    public class Ale : Beer, IMyCloneable<Ale>
    {
        // сорт хмеля
        public string HopVariety { get; set; }

        public Ale(string name, double alcoholPercentage, string hopVariety) : base(name, alcoholPercentage)
        {
            HopVariety = hopVariety;
        }

        public override Beer Clone()
        {
            return new Ale(Name, AlcoholPercentage, HopVariety);
        }

        Ale IMyCloneable<Ale>.Clone()
        {
            return (Ale)((Beer)this).Clone();
        }
    }
}