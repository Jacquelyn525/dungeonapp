﻿using DungeonLibrary;



namespace MonsterLibrary
{
    public class Combat
    {        

        public static void DoAttack(Character attacker, Character defender)
        {            
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(300); 
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {                
                int damageDelt = attacker.CalcDamage();

                defender.Life -= damageDelt;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDelt} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }
        public static void DoBattle(Player player, Monster monster)
        {            
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}