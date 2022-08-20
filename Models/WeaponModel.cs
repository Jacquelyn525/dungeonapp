using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum Weapon
    {
        None,
        Shotgun,
        DemonBlade,
        Colt,
        AngelBlade
    }
    public class WeaponModel
    {
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private bool _isTwoHanded;
        private Weapon _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public Weapon Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int BonusHitChance { get; set; }

        public WeaponModel(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded, Weapon weapon)
        {            
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = weapon;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\n{4}\t\t{5}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                Type,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }

    }
}
