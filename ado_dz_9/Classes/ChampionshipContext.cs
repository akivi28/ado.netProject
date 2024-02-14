using ado_dz_9.Classes;
using Microsoft.EntityFrameworkCore;

namespace ado_dz_7.Classes
{
    public class СhampionshipContext : DbContext
    {
        public DbSet<Team> Teams { get; set; } = default!;
        public DbSet<Player> Players { get; set; } = default!;
        public DbSet<Game> Games { get; set; } = default!;
        public DbSet<Country> Countries { get; set; } = default!;
        public DbSet<Goal> Goals { get; set; } = default!;
        public СhampionshipContext() : base() { }
        public СhampionshipContext(DbContextOptions<СhampionshipContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Сhampionship3;Integrated Security=True;";
                optionsBuilder.UseSqlServer(connStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasOne(t => t.HomeTeam)
                .WithMany(t => t.HomeGames)
                .HasForeignKey(t => t.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Game>()
                .HasOne(t => t.AwayTeam)
                .WithMany(t => t.AwayGames)
                .HasForeignKey(t => t.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}