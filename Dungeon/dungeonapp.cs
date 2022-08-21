using DungeonLibrary;
using MonsterLibrary;



namespace Dungeon
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-*-*-*-Welcome to the Supernatural Game!-*-*-*-*-*\n");
            Console.Title = "*-*-*-*-*Supernatural*-*-*-*-*";


            int score = 0;


            Weapon colt = new Weapon(8, 1, "The Colt", 10, false, WeaponType.Colt);

            Console.WriteLine("Hello Hunter! What is your name? ");
            string userName = Console.ReadLine();
            
            var races = Enum.GetValues(typeof(Race));
            int index = 1;
            foreach (var race in races)
            {
                Console.WriteLine($"{index}) {race}");
                index++;
            }
            Console.WriteLine("Please select a race from the list above....");

            int userInput = int.Parse(Console.ReadLine()) - 1;
            Race userRace = (Race)userInput;
            Console.WriteLine(userRace);

            Player player = new Player(userName, 70, 5, 40, 40, userRace, colt);

            Console.Clear();
            Console.WriteLine($"Welcome {player.Name}, your HUNT begins!");
            bool exit = false;

            do
            {



                string room = GetRoom();
                Console.WriteLine(room);


                Monster monster = Monster.GetMonster();

                Console.WriteLine("In this room...." + monster.Name);

                bool reload = false;

                do
                {
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");
                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();

                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("Attack!");

                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                score++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.Beep(700, 500);
                                Console.ResetColor();
                                reload = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.WriteLine("Call Cas, we need healed!\a");
                                exit = true;
                            }
                            break;
                        case "R":
                            Console.WriteLine("Run away!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;
                        case "P":
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters Defeated: " + score);
                            break;

                        case "M":
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.WriteLine("Hunters don't quit...");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Please try again...");
                            break;
                    }

                } while (!exit && !reload);

            } while (!exit);
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s"));
            Console.WriteLine("\n\nThanks for playing! Press any key to exit...");
            Console.ReadKey();


            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion
        }
        private static string GetRoom()
        {
            string[] rooms =
            {


                "You enter an abandoned warehouse and hear footsteps in the distance.",
                "You are investigating a murder when suddenly you turn around and...",
                "The room looks just like the room you are sitting in right now... or does it?",
                "Speeding down the highway you get pulled over and realize that's not really a cop...",
                "The room is dark with an eerie feeling of someone behind you.",
                "You are doing research at a restaurant with your brother when you notice..",
                "Walking into a room the lights flicker on and off with a smell of sulfur...",                

            };
            return rooms[new Random().Next(rooms.Length)];
        }




    }
}
