using Legos.Minifigures.Parts;

namespace Legos.Minifigures
{
    class Minifigure
    {
        // properties
        Head _head;

        Torso _torso;

        Legs _legs;

        public Minifigure(Head head, Torso torso, Legs legs)
        {
            _head = head;
            _torso = torso;
            _legs = legs;
        }

        public void Battle()
        {
            _legs.Walk();
            _head.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }

    }
}
