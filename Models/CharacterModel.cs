using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CharacterModel
    {
        public string Name
        {
            get; 
            private set; 
        }

        public CharacterModel(string name)
        {
            this.Name = name;
        }
    }
}
