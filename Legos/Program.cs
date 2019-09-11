using Legos.Minifigures;
using Legos.Minifigures.Parts;
using System;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            // object initializer
            var head = new YodaHead
            {
                EyeColor = "Browen",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3
            };

            var torso = new YetiTorso();

            var legs = new ZombieLegs();

            var yodaYetiZombie = new Minifigure(head, torso, legs);
            yodaYetiZombie.Battle();

            var fatHead = new FatHead();
            var pirateTorso = new PirateTorso(HandType.Hook);
            var cebtaurLegs = new CentaurLegs();

            var fatHeadCentaurPirate = new Minifigure(fatHead, pirateTorso, centaurLegs);
            fatHeadCentaurPirate.Battle();

        }
    }
}
