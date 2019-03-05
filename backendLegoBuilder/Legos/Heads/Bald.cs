using System;
using System.Collections.Generic;
using System.Text;

namespace backendLegoBuilder.Legos.Heads
{
    class Bald : Head
    {
        // Props
        public int ShineLevel { get; set; }
        public bool HasToupe { get; set; }

        // Fields

        // Constructor

        //Methods
        public void HairCut(HairLength newLength)
        {
            HairLength = HairLength.CompletelyBald;
        }

        public override string Talk()
        {
            return "I puty the fool";
        }
    }
}
