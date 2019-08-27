using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PachiMaze.Models;

namespace PachiMaze.AspNetCore.NewDb.Models
{
    public class PachiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=pachimaze;Username=pachimaze;Password=null");

        public DbSet<Score> Score { get; set; }
    }
}
