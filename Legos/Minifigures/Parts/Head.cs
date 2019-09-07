using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{   // The base class is where you label all of your properties
    // abstract - can't be instantiated 
    abstract class Head
    {
        // properties of each 
        public int NumberOfEyes { get; set; }
        public string EyeColor { get; set; }
        public bool HasNose { get; set; }
        public string HairColor { get; set; }
        public bool MouthIsOpen { get; set; }
        public HeadSize Size { get; protected set; }

        /* Virtual - access modifier - can change change the behavior if the output of the classes inheriting it
         * if it's not virtual, you can't modify it */
        // The Console.WriteLine in this method, is the default behavior of the inherited classes
        public virtual void Talk()
        {
            Console.WriteLine("I'm a talking head");
        }

        public abstract void Think();
    }
}
