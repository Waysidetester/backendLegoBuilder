using System;
using System.Collections.Generic;
using System.Text;

namespace backendLegoBuilder.Legos.Torsos
{
    class Scaly : Torso
    {
        public Scaly()
            : base(4, Sex.Other, Colors.Red, "Hard as a rock")
        {

        }

        public override void Wave()
        {
            Console.WriteLine(@"Fragile waving\0/");
        }
    }
}
