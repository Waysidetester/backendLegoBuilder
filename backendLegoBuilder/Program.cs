/* Classes: Heads, Torsos, Legs, Accessories, and mini-figures */

using System;
using backendLegoBuilder.Legos;
using backendLegoBuilder.Legos.Heads;
using backendLegoBuilder.Legos.Torsos;

namespace backendLegoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myDogHead = new Dog();
            var martinHead = new Bald();
            var astronaught = new Astronaut();
            Console.WriteLine(astronaught.Talk());

            var fitTorso = new FitTorso(2, Sex.Female, Legos.Colors.Freckles);

            Console.Write(fitTorso.Sex);

            var minifigure = new Minifiguer(martinHead, fitTorso);

            minifigure.Greet();

            Console.ReadKey();
        }
    }
}
