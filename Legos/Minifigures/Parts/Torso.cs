using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    // The torso class is the base class for the torso
    abstract class Torso
    {
        public HandType HandType { get; set; }
        public abstract bool ChestHair { get; }
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }

        // abstract means every class must have these methods
        // virtual class has the method, but anyone can override the default behavior
        public abstract void Flex();
        public abstract void Fight();
    }
}
