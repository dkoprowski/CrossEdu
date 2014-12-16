using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Model
{
    public class Game
    {
        public int gameId { get; set; }
        public string path { get; set; }    //path to the location on server where a game is stored
        public User gameAuthor { get; set; }

        public DateTime releaseDate { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public virtual List<Comment> comments { get; set; }



    }
}
