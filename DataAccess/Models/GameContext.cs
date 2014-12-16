using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataAccess.Models
{
    public class GameContext : DbContext
    {
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
    }
}
