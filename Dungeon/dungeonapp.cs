using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;



namespace Dungeon
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-*-*-*-Welcome to the Supernatural Game!-*-*-*-*-*\n");
            Console.Title = "*-*-*-*-*Supernatural*-*-*-*-*";
            GameLoop();
            Console.WriteLine("Thanks for playing! Come back soon!");


            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion
        }//end Main()

        private static void GameLoop()
        {
            PlayerModel player = new PlayerModel();
            bool exitGame = false;
            // a new game has begun with the creation of the player.


            do // this do loop represents the life (and eventual death) of your character.
            {

                if (player.Character is null) // does the player have a living character?  If no (due to death or new game, then make one)
                {
                    // your new character is born inside here.
                    Console.WriteLine("Please create a new character.");
                    player.CreateCharacter();
                }
                else
                {
                    // inside here is the story of your character.
                    // upon first creation of the character we can assume he/she has just set foot inside the dungeon.
                    // or the character has either 'ran' from an enounter with a monster or has 'beaten' a monster in combat

                    #region Inner Loop

                    Console.Clear();
                    string choice = string.Empty;

                    string currentRoom = player.GetRoomDescription();
                    MonsterModel monster = new MonsterModel();
                    // a new room (theme) and encounter (monster to fight) must now be generated before entering the combat loop.

                    do
                    {
                        // Menu
                        Console.WriteLine(currentRoom + "\n\nYou see a " + monster.Race + " standing in the shadow.\n\n");
                        Console.WriteLine("<--Make your next move!-->\n");
                        Console.WriteLine("A. Attack\n" +
                                          "R. Run Away\n" +
                                          "C. Character Info\n" +
                                          "M. Monster Info\n" +
                                          "W. Weapon Info\n" +
                                          "E. Exit");

                        choice = Console.ReadKey(true).Key.ToString();
                        Console.Clear();

                        switch (choice)
                        {
                            case "A":
                                Console.WriteLine("Attack");
                                break;

                            case "R":
                                Console.WriteLine("Run Away");
                                break;

                            case "C":
                                Console.WriteLine("Character Info");
                                DisplayCharacterInfo(player.Character);
                                break;

                            case "M":
                                Console.WriteLine("Monster Info");
                                DisplayMonsterInfo(monster);
                                break;

                            case "W":
                                Console.WriteLine("Weapon Info");
                                DisplayWeaponInfo(player.Character.EquippedWeapon);
                                break;

                            case "E":
                                Console.WriteLine("Exit");
                                exitGame = true;
                                break;

                            default:
                                Console.WriteLine("Invalid Choice.");
                                break;
                        }

                    } while (exitGame != true && choice.ToLower() != "r");

                    if (choice.ToLower() == "r")
                    {
                        Console.WriteLine("You ran away!! \n\nPress Q to quit \nPress any other key to enter another room.");
                        string selection = Console.ReadKey(true).Key.ToString();
                        
                        if (selection.ToLower() == "q")
                        {
                            exitGame = true;
                        }

                    }
                    #endregion Inner Loop

                }

            } while (!exitGame);





        }//end GameLoop

        static void DisplayCharacterInfo(CharacterModel character)
        {
            Console.Clear();

            Console.WriteLine($"Name:      {character.Name}");
            Console.WriteLine($"Race:      {character.Race}");
            Console.WriteLine($"Life:      {character.Life}");
            Console.WriteLine($"Attack:    {character.Attack}");
            Console.WriteLine($"Defense:   {character.Defense}");
            


            Console.WriteLine("");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        static void DisplayMonsterInfo(MonsterModel monster)
        {
            Console.Clear();

            Console.WriteLine($"Race:       {monster.Race}");
            Console.WriteLine($"Life:       {monster.Life}");
            Console.WriteLine($"Attack:     {monster.Attack}");
            Console.WriteLine($"Defense:    {monster.Defense}");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
        }

        static void DisplayWeaponInfo(WeaponModel weapon)
        {
            Console.Clear();

            Console.WriteLine($"Name:             {weapon.Name}");
            Console.WriteLine($"MinDamage:        {weapon.MinDamage}");
            Console.WriteLine($"MaxDamage:        {weapon.MaxDamage}");
            Console.WriteLine($"Is Two Handed:    {weapon.IsTwoHanded}");

            Console.WriteLine("");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Console.Clear();

        }

    }//end class
}//end namespace
