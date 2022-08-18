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
        public MonsterRace Race { get; set; }

        public int HitPoints { get; set; } = 15;

        public int Attack { get; set; } = 13;

        public int Defense { get; set; } = 9;

        public MonsterModel()
        {
            Random random = new Random();
            Race = (MonsterRace)random.Next(1, Enum.GetValues(typeof(MonsterRace)).Length);

            switch (Race)
            {
                case MonsterRace.Demon:
                    break;

                case MonsterRace.Leviathan:
                    break;

                case MonsterRace.Djinn:
                    break;

                case MonsterRace.Phistaco:
                    break;
                default:
                    Console.WriteLine("Unexpected race in monster generation.");
                    break;

            }
        }
    }


}
