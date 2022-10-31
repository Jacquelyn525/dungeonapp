
namespace DungeonLibrary
{
    public class Weapon 
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;


        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Weapon(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;


            switch (Type)
            {
                case WeaponType.Colt:
                    maxDamage += 50;
                    minDamage += 50;
                    break;
                case WeaponType.DemonBlade:
                    maxDamage += 10;
                    minDamage += 5;
                    bonusHitChance += 2;
                    break;
                case WeaponType.AngelBlade:
                    maxDamage += 30;
                    minDamage += 20;
                    bonusHitChance += 5;
                    break;
                case WeaponType.Shotgun:
                    maxDamage += 15;
                    minDamage += 5;
                    isTwoHanded = true;
                    break;
            }
        }

        public void InfoDisplay() {

            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Damage range: " + this.MinDamage.ToString() + "-" + this.MaxDamage.ToString());

        }


        public override string ToString()
        {
            string description = "";
            switch (Type)
            {
                case WeaponType.Colt:
                    description = "Colt";
                    break;
                case WeaponType.DemonBlade:
                    description = "Demon Blade";
                    break;
                case WeaponType.AngelBlade:
                    description = "Angel Blade";
                    break;
                case WeaponType.Shotgun:
                    description = "Shotgun";
                    break;
            }
            return base.ToString() + description;
        }
    }
}
