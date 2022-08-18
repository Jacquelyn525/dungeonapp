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

    public enum Weapon
    {
        None,
        Shotgun,
        DemonBlade,
        Colt,
        AngelBlade
    }

    public class CharacterModel
    {
        #region properties
        public string Name { get; private set; }

        public int HitPoints { get; set; } = 18;

        public int Attack { get; set; } = 14;

        public int Defense { get; set; } = 10;

        public PlayableRace Race { get; private set; }

        public Weapon Weapon { get; set; } = Weapon.None;
        #endregion


        public CharacterModel(string name)
        {
            Random random = new Random();

            this.Name = name;
            Race = (PlayableRace)random.Next(1, Enum.GetValues(typeof(PlayableRace)).Length);


            switch (Race)
            {
                case PlayableRace.Angel:
                    HitPoints += 2;
                    Attack += 2;
                    Defense -= 2;
                    break;

                case PlayableRace.Hunter:
                    Attack += 1;
                    Defense += 1;
                    break;

                case PlayableRace.MenofLetters:
                    HitPoints -= 2;
                    Attack += 2;
                    break;

                case PlayableRace.Nephilim:
                    HitPoints += 3;
                    Attack += 3;
                    Defense += 3;
                    break;
                default:
                    Console.WriteLine("Unexpected race in character generation.");
                    break;

            }
        }

    }
}
