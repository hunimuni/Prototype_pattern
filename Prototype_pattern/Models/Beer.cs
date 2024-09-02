using BeerPrototype.Interfaces;

namespace BeerPrototype.Models
{
    public abstract class Beer : IMyCloneable<Beer>, ICloneable
    {
        public string Name { get; set; }
        public double AlcoholPercentage { get; set; }

        protected Beer(string name, double alcoholPercentage)
        {
            Name = name;
            AlcoholPercentage = alcoholPercentage;
        }

        public abstract Beer Clone();

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}