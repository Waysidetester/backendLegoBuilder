using System;
using System.Collections.Generic;
using System.Text;

namespace backendLegoBuilder.Legos.Torsos
{
    class FitTorso : Torso
    {
        public FitTorso(int numberOfArms, Sex sex, Colors color)
            : base(numberOfArms, sex, color, "OMG, so fit. It's lit.")
        {
        }

        public void Crunch(int howManyCrunches)
        {
            FitnessOfAbdomen += ", and more fit";
            Console.WriteLine($"I just did {howManyCrunches} bruh. CROSSFIT!");
        }

        public override void Wave()
        {
            base.Wave();
            Console.WriteLine("('')__/");
        }
    }
}
