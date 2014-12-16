using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Model
{
    public class Comment
    {
        public int commentId { get; set; }

        public string content { get; set; }
        public User commentAuthor { get; set; }
        public DateTime dateOfPublication { get; set; }



    }
}
