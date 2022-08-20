using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum PlayableRace
    {
        Angel,
        Hunter,
        Nephilim,
        MenofLetters
    }


    public class CharacterModel
    {
        private string _name;
        private int _hitChance;
        private int _block;
        private int _attack;
        private int _defense;
        private int _maxLife = 20;
        private int _life;

        #region properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
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

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
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

        public WeaponModel EquippedWeapon { get; set; } 

        public PlayableRace Race { get; private set; }


        #endregion


        public CharacterModel(string name)
        {
            Random random = new Random();

            this.Name = name;
            Race = (PlayableRace)random.Next(1, Enum.GetValues(typeof(PlayableRace)).Length);
            GenerateWeapon();


            switch (Race)
            {
                case PlayableRace.Angel:
                    MaxLife += 2;
                    Attack += 2;
                    Defense -= 2;
                    Life = MaxLife;
                    break;

                case PlayableRace.Hunter:
                    Attack += 1;
                    Defense += 1;
                    Life = MaxLife;
                    break;

                case PlayableRace.MenofLetters:
                    MaxLife -= 2;
                    Attack += 2;
                    Life = MaxLife;
                    break;

                case PlayableRace.Nephilim:
                    MaxLife += 3;
                    Attack += 3;
                    Defense += 3;
                    Life = MaxLife;
                    break;
                default:
                    Console.WriteLine("Unexpected race in character generation.");
                    break;

            }
        }

        public override string ToString()
        {
            return string.Format("----- {0}-----\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Block: {4}",
                Name,
                Life,
                MaxLife,
                CalcHitChance(),
                Block);
        }
        public virtual int CalcBlock()
        {
            return Block;
        }//end CalcBlock

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//end CalcHitChance

        public virtual int CalcDamage()
        {
            return 0;
        }//end CalcDamage

        public void GenerateWeapon()
        {
            //Random random = new Random();
            //Weapon weapon = (Weapon)random.Next(1, Enum.GetValues(typeof(Weapon)).Length);
            //this.EquippedWeapon = weapon;
            this.EquippedWeapon = new WeaponModel(8, 1, "Demon Blade", 10, false, Weapon.DemonBlade);

        }
    }
}
