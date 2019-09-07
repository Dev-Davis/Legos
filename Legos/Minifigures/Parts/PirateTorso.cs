using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateTorso
    {
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }
        public HandType HandType { get; set; }
        // Member - Expression body member
        public bool ChestHair => true;

        public PirateTorso(HandType handType)
        {
            HandType = handType;
            Shirt = "Froofy with ruffles";
        }

        public void Flex()
        {
            Console.WriteLine("The porate torso flexed swashbucklingly");
        }

        public void Fight()
        {
            Console.WriteLine("Waves a sword around");
        }
    }

    enum HandType
    {
        Regular,
        Hook,
        None
    }
}
