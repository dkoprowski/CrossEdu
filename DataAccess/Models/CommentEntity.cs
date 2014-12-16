using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("Comment")]
    public class CommentEntity
    {
        public int Id { get; set; }

        public string Content { get; set; }
        public DateTime DateOfPublication { get; set; }
        
        public int GameId { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual GameEntity Game { get; set; }
    }
}
