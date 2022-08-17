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
            Console.WriteLine("*-*-*-*-*-Welcome to the Dungeon!-*-*-*-*-*\n");
            Console.Title = "*-*-*-*-*Dungeon Crawler*-*-*-*-*";
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

            do
            {
                if (player.Character is null)
                {
                    Console.WriteLine("Please create a new character.");
                    player.CreateCharacter();
                }
                else
                {
                    #region Inner Loop

                    Console.Clear();
                    string choice = string.Empty;

                    do
                    {
                        // Menu
                        Console.WriteLine("<--Make your next move!-->\n");
                        Console.WriteLine("A. Attack\n" +
                                          "B. Run Away\n" +
                                          "C. Character Info\n" +
                                          "D. Monster Info\n" +
                                          "E. Exit");

                        string action = Console.ReadKey(true).Key.ToString();
                        Console.Clear();

                        switch (action)
                        {
                            case "A":
                                Console.WriteLine("Attack");
                                break;

                            case "B":
                                Console.WriteLine("Run Away");
                                break;

                            case "C":
                                Console.WriteLine("Character Info");
                                break;

                            case "D":
                                Console.WriteLine("Monster Info");
                                break;

                            case "E":
                                Console.WriteLine("Exit");
                                exitGame = true;
                                break;

                            default:
                                Console.WriteLine("Invalid Choice.");
                                break;
                        }

                    } while (!exitGame);

                    #endregion Inner Loop

                }

            } while (!exitGame);





        }//end GameLoop
    }//end class
}//end namespace
