using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_1
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int magcialEnergy, int spellNumber)
            : base (name, strength, intelligence, magcialEnergy)
        {
            this.spellNumber = spellNumber;
        }

        public override string Play()
        {
            return base.Play() + $"\nNumber of Spells: {spellNumber}";
        }
    }
}
