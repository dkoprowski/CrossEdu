using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DataAccess.Models
{
    [Table("User")]
    public class UserEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual List<CommentEntity> Comments { get; set; }
        public virtual List<GameEntity> Games { get; set; }

    }
}
