using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class DarthVaderHead : Head
    {
        public override void Talk()
        {
            Console.WriteLine("KHOOOOH PUUUHRR");
            base.Talk();
            Console.WriteLine("KHOOOOH PUUUHRR");
        }
        // The override access modifier - overrides the original behavior
        public override void Think()
        {
            Console.WriteLine("Am I your father?");
        }
    }
}
