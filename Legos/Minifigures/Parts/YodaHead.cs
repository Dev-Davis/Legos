using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YodaHead : Head
    {
        // Overriding works in the base class
        public bool HasEars { get; private set; }

        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }

        public override void Talk()
        {
            // Base is the thing inherited from
            //base.Talk();)
            Console.WriteLine("Talking head, I am.");
        }

        public void Battle()
        {
            HasEars = false;
        }

        // anything that inherits from Head must have a method signature that looks like that without abstract
        public override void Think()
        {
            Console.WriteLine("There is no try...");
        }
    }
}
