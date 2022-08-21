using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    internal class Lucifer : Monster
    {
        public bool IsAngry { get; set; }

        public Lucifer()
        {
            //we could set default values for a weak version of a dragon

        }

        public Lucifer(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage,
            string description, bool isAngry)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsAngry = isAngry;
        }//end FQ CTOR

        //To generate a "parent-compliant ctor", make sure the document is saved,
        //right click on Monster (parent class)
        //Select Quick Actions and Refactorings
        //Generate Constructor Class(params)
        //Add any unique params and handle assignment.

        public override int CalcBlock()
        {
            int result = Block;
            if (IsAngry)
            {
                result += Block / 2;
            }
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + (IsAngry ? "Fire!" : "Where's the fire?");
        }
    }
}
