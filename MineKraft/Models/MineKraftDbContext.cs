using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineKraft.DbLib.Models
{
    internal class MineKraftDbContext : IdentityDbContext
    {
        public DbSet<Topic> Topics { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Question> Questions { get; set; }

        public MineKraftDbContext(DbContextOptions<MineKraftDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
