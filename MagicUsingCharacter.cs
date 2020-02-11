using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_1
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magcialEnergy;

        public int MagcialEnergy { get => magcialEnergy; set => magcialEnergy = value; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magcialEnergy)
            : base(name, strength, intelligence)
        {
            this.magcialEnergy = magcialEnergy;
        }

        public override string Play()
        {
            return base.Play() + $"\nMagicka: {magcialEnergy}";
        }



    }
}
