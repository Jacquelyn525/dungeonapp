using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Demon : Monster
    {
        public bool IsUgly { get; set; }

        public Demon()
        {
            

        }

        public Demon(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage,
            string description, bool isUgly)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsUgly = isUgly;
        }

        public override int CalcBlock()
        {
            int result = Block;
            if (IsUgly)
            {
                result += Block / 2;
            }
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + (IsUgly ? "Ugly!" : "Not so Ugly...");
        }


    }
}
