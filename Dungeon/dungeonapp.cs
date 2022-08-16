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
            Console.WriteLine("Welcome to the Dungeon!");

            GetPlayerInfo();
            CreateCharacter();
            GameLoop();
            Console.WriteLine("Thanks for playing! Come back soon!");


            #region Terminator
            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            #endregion
        }//end Main()

        private static void GetPlayerInfo()
        {

        }//end GetPlayerInfo

        private static void CreateCharacter()
        {

        }//end CreateCharacter

        private static void GameLoop()
        {
            string choice = string.Empty;
            do
            {
                Console.Write("Do you want to continue? (Y/N) ");
                choice = Console.ReadLine();
                
            } while (choice.ToLower() != "n");

        }//end GameLoop
    }//end class
}//end namespace
