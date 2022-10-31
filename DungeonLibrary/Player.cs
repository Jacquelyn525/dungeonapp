

namespace DungeonLibrary
{
        public sealed class Player : Character 
    {        
        public Race CharacterRace { get; set; }
                        
        private Weapon _equippedWeapon;

        

        public Weapon EquippedWeapon
        {            
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }

        }

        public List <Weapon> AvailableWeapons { get; private set; }

        public Player(string name, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon)
            : base(name, hitChance, block, maxLife, life)
        {
            Weapons();
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            
            switch (CharacterRace)
            {
                case Race.Angel:
                    MaxLife += 10;
                    Life += 10;
                    break;
                case Race.Human:
                    HitChance += (HitChance / 20); 
                    break;
                case Race.Nephilim:
                    Block += 3;
                    HitChance += 5;
                    break;
                case Race.SoullessSam:
                    MaxLife += 5;
                    Life += 5;
                    Block += 5;
                    break;
            }


            //get a random weapon from available weapons

            //set equipped weapon to random weapon
        }

        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Angel:
                    description = "Angel";
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Nephilim:
                    description = "Nephilim";
                    break;
                case Race.SoullessSam:
                    description = "Soulless Sam";
                    break;
                default:
                    break;
            }
            return base.ToString() + $"\nWeapon: {EquippedWeapon.Name}\n" + description;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }
        public override int CalcDamage()
        {           
            Random rand = new Random();
                       
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;
            
        }


        private void Weapons()
        {
            Weapon colt = new Weapon(8, 1, "The Colt", 10, false, WeaponType.Colt);
            Weapon demonBlade = new Weapon(8, 1, "Demon Blade", 10, false, WeaponType.DemonBlade);
            Weapon angelBlade = new Weapon(8, 1, "Angel Blade", 10, false, WeaponType.AngelBlade);
            Weapon shotgun = new Weapon(8, 1, "Shotgun", 10, true, WeaponType.Shotgun);


            AvailableWeapons = new List<Weapon>()
            {
                shotgun,shotgun,shotgun,
                demonBlade,demonBlade,
                angelBlade,angelBlade,
                colt
            };

            return;  
        }
    }
}
