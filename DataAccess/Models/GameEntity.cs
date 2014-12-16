using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    [Table("Game")]
    public class GameEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }    //path to the location on server where a game is stored

        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual List<CommentEntity> Comments { get; set; }
        public virtual UserEntity User { get; set; }     
    }
}
