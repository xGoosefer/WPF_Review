using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Review
{
    public class Game
    {
        private string gameName = "Robotic Ascension";
        private string description = "Woahge";
        private string credit = "created by Roberto A Ramirez";

        
        public string Description {get => description; set => description = value;}
        public string Credit { get => credit; set => credit = value; }
        public string GameName { get => gameName; set => gameName = value; }
    }
}
