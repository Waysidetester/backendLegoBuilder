using System;
using System.Collections.Generic;
using System.Text;
using backendLegoBuilder.Legos.Heads;
using backendLegoBuilder.Legos.Torsos;

namespace backendLegoBuilder.Legos
{
    class Minifiguer
    {
        public Head Head { get; set; }
        public Torso Body { get; set; }

        public Minifiguer(Head head, Torso body)
        {
            Head = head;
            Body = body;
        }

        //public void Eat()
        //{
        //    Head.Chew();
        //    Body.Digest();
        //}

        public void Greet()
        {
            Body.Wave();
            Head.Talk();
        }
    }
}
