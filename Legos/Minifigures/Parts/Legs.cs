using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class Legs
    {
        public int NumberOfLegs { get; set; }
        public PantLength PantLength { get; set; }
        public bool BareFoot { get; set; }
        public int VerticalLeap { get; set; }

        public void Kick()
        {
            UseLegs("kick");
        }

        public void Dance()
        {
            UseLegs("dance");
        }

        public void Walk()
        {
            UseLegs("walk");
        }

        private void UseLegs(string activity)
        {
            var shoesOrBareFoot = BareFoot ? "without shoes" : "with shoes";

            // use return to get out of a method
            if (NumberOfLegs <= 0)
            {
                Console.WriteLine("No legs, can't walk");
                return;
            }

            Console.WriteLine($"The {NumberOfLegs} legs {activity} {shoesOrBareFoot} while wearing {PantLength}");
        }

    }

    enum PantLength
    {
        Shorts,
        Pants,
        Capris,
        None
    }
}
