namespace Models
{
    public class PlayerModel
    {
        #region private members

        //private string _name;

        #endregion private members

        #region properties

        public string Name
        {
            get;
            private set;
        }



        public CharacterModel Character { get; set; }

        #endregion properties


        #region CTOR

        public PlayerModel()
        {
            BuildPlayer();
        }

        #endregion CTOR

         public void BuildPlayer()
        {
            Console.WriteLine("Please enter your name: ");
            this.Name = Console.ReadLine();
        }

        public void CreateCharacter()
        {
            Console.WriteLine("What do you want to name your character?");
            this.Character = new CharacterModel(Console.ReadLine());
        }
    
        public string GetRoomDescription()
        {
            string[] description = {
                "The cave is misty and quiet.",
                "In the abandoned warehouse you hear faint screams in the distance.",
                "Walking out in the woods you are suddenly surrounded by eerie black smoke.",
                "The lights flicker on and off.",
                "You wake up in a different reality",
                ""
                
            };

            Random random = new Random();
            /**
             * This is another, more verbose (thus longer) way to do this operation:
                int rooms = description.Length;
                int randomRoomNumber = random.Next(1, rooms) - 1;
                string currentRoomDescription = description[randomRoomNumber];

                return currentRoomDescriptionh;
            */

            return description[random.Next(1, description.Length) - 1];
        }


    }
}