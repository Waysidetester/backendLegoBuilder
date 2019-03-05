using System;
namespace backendLegoBuilder.Legos.Torsos
{
    class Skeleton : Torso
    {
        public Skeleton(int numOfArms) :base(numOfArms, Sex.Shrug, Colors.Bone, "Bone-y")
        {
        }

        public void Rattle()
        {
            Console.WriteLine("Rattle, Rattlle...");
            this.Wave();
        }
    }
}
