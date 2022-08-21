using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    internal class Djinn : Monster
    {
        public bool IsBlue { get; set; }

        public Djinn()
        {


        }

        public Djinn(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage,
            string description, bool isBlue)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsBlue = isBlue;
        }
        

        public override int CalcBlock()
        {
            int result = Block;
            if (IsBlue)
            {
                result += Block / 2;
            }
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + (IsBlue ? "Oh no!" : "Well dang...");
        }
    }
}
