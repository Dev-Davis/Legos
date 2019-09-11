using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YetiTorso : Torso
    {
        public override bool ChestHair => true;

        public YetiTorso()
        {
            HandType = HandType.None;
            Shirt = "None";
            NumberOfArms = 2;
        }

        public override void Flex()
        {
            Console.WriteLine("The yeti torso flexes menacingly with no hands.");
        }

        public override void Fight()
        {
            Console.WriteLine("The yeti torso smacks you with his nubs.");
        }
    }
}
