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
            get; //  { return _name; }
            private set; // { _name = value; }
        }

        public CharacterModel Character { get; set; }

        #endregion properties


        #region CTOR

        public PlayerModel()
        {
            BuildPlayer();
        }

        #endregion CTOR

        void BuildPlayer()
        {
            Console.WriteLine("Please enter your name: ");
            this.Name = Console.ReadLine();
        }

        public void CreateCharacter()
        {
            Console.WriteLine("What do you want to name your character?");
            this.Character = new CharacterModel(Console.ReadLine());
        }
    }
}