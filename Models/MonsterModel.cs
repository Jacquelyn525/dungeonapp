using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum MonsterRace
    {
        Demon,
        Leviathan,
        Djinn,
        Phistaco,
    }

    public class MonsterModel
    {
        private int _life;
        private string _name;
        private int _attack;
        private int _defense;
        private int _maxLife = 20;

        
        public MonsterRace Race { get; set; }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value > MaxLife)
                {
                    _life = MaxLife;
                }
                else
                {
                    _life = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 
           

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        } 

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        } 

       

        public MonsterModel()
        {
            Random random = new Random();
            Race = (MonsterRace)random.Next(1, Enum.GetValues(typeof(MonsterRace)).Length);

            switch (Race)
            {
                case MonsterRace.Demon:
                    MaxLife += 1;
                    Attack += 2;
                    Defense -= 2;
                    Life = MaxLife;
                    break;

                case MonsterRace.Leviathan:
                    MaxLife += 3;
                    Attack += 2;
                    Defense -= 1;
                    Life = MaxLife;
                    break;

                case MonsterRace.Djinn:
                    MaxLife += 1;
                    Attack += 2;
                    Defense -= 2;
                    Life = MaxLife;
                    break;

                case MonsterRace.Phistaco:
                    MaxLife += 1;
                    Attack += 1;
                    Defense -= 3;
                    Life = MaxLife;
                    break;
                default:
                    Console.WriteLine("Unexpected race in monster generation.");
                    break;

            }
        }
    }


}
