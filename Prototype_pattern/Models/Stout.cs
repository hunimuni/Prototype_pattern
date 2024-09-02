using BeerPrototype.Interfaces;

namespace BeerPrototype.Models
{
    public class Stout : Beer, IMyCloneable<Stout>
    {
        // Имперский стаут
        public bool IsImperial { get; set; }

        public Stout(string name, double alcoholPercentage, bool isImperial) : base(name, alcoholPercentage)
        {
            IsImperial = isImperial;
        }

        public override Beer Clone()
        {
            return new Stout(Name, AlcoholPercentage, IsImperial);
        }

        Stout IMyCloneable<Stout>.Clone()
        {
            return (Stout)((Beer)this).Clone();
        }
    }
}