using BeerPrototype.Models;

namespace BeerPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Ale originalAle = new Ale("IPA", 6.5, "Cascade");
            Ale clonedAle = (Ale)originalAle.Clone();

            Console.WriteLine($"Оригинальный Ale: {originalAle.Name}, ABV: {originalAle.AlcoholPercentage}%, Hop: {originalAle.HopVariety}");
            Console.WriteLine($"Склонированный Ale: {clonedAle.Name}, ABV: {clonedAle.AlcoholPercentage}%, Hop: {clonedAle.HopVariety}");

            Lager originalLager = new Lager("Pilsner", 4.8, 6);
            Lager clonedLager = (Lager)originalLager.Clone();

            Console.WriteLine("\n");

            Console.WriteLine($"Оригинальный Lager: {originalLager.Name}, ABV: {originalLager.AlcoholPercentage}%, Lagering Time: {originalLager.LageringTime} weeks");
            Console.WriteLine($"Склонированный Lager: {clonedLager.Name}, ABV: {clonedLager.AlcoholPercentage}%, Lagering Time: {clonedLager.LageringTime} weeks");

            Stout originalStout = new Stout("Russian Imperial Stout", 9.0, true);
            Stout clonedStout = (Stout)originalStout.Clone();

            Console.WriteLine("\n");

            Console.WriteLine($"Оригинальный Stout: {originalStout.Name}, ABV: {originalStout.AlcoholPercentage}%, Imperial: {originalStout.IsImperial}");
            Console.WriteLine($"Склонированный Stout: {clonedStout.Name}, ABV: {clonedStout.AlcoholPercentage}%, Imperial: {clonedStout.IsImperial}");

            Console.WriteLine("\n");

            // Используем ICloneable
            Beer clonedBeer = (Beer)((ICloneable)originalAle).Clone();
            Console.WriteLine($"Склонированный Beer с ICloneable: {clonedBeer.Name}, ABV: {clonedBeer.AlcoholPercentage}%");
        }
    }
}