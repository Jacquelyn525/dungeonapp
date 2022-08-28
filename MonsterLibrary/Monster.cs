using System;
using DungeonLibrary;


namespace MonsterLibrary
{
    public class Monster : Character 
    {
        
        public int MaxDamage { get; set; }

        public string Description { get; set; }

        private int _minDamage;
        
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (true)
                {
                    _minDamage = 1;
                }
                else if (value < 1)
                {
                    _minDamage = 1;
                }
                else
                {
                    _minDamage = value;
                }                             

            }
        } 
       
        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) 
            : base(name, hitChance, block, maxLife, life)
        {            
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        
        public Monster()// this is a default constructor, need it to make a default "monster"
        {         
             //ask why this?                                                                         

        }

        
        public override string ToString()
        {
            return $@"
******* MONSTER *******
{Name}
Life: {Life} of {MaxLife}
Damage: {MinDamage} - {MaxDamage}
Block: {Block}
Description:
{Description}
";
        }
        public override int CalcDamage()
        {            
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

        public static Monster GetMonster()
        {            
            Vampire vampire = new Vampire("Gordon", 30, 30, 70, 8, 8, 1, "The most hated vamp ever.", true);
            Djinn djinn = new Djinn("Brigitta", 17, 25, 50, 10, 4, 1, "Beautiful with a poisonus touch.", true);
            Lucifer archAngel = new Lucifer("Lucifer", 10, 20, 65, 20, 15, 1, "The father of hell.", true);
            Demon demon = new Demon("Abaddon", 25, 25, 50, 20, 8, 2, "She is quite the firey redhead.",true);
            

            List<Monster> monsters = new List<Monster>()
            {
                
                vampire,vampire,vampire,
               djinn,djinn,
                archAngel,
                demon, demon, 
            };
            
            return monsters[new Random().Next(monsters.Count)];
        }

    }
}
