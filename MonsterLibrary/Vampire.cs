using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    internal class Vampire : Monster
    {
        public bool IsBitey { get; set; }

        public Vampire()
        {
            

        }

        public Vampire(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage,
            string description, bool isBitey)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsBitey = isBitey;
        }

        public override int CalcBlock()
        {
            int result = Block;
            if (IsBitey)
            {
                result += Block / 3;
            }
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + (IsBitey ? "Blah buh Blah!" : "Blah");
        }
    }
}
