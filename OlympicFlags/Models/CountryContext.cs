using Microsoft.EntityFrameworkCore;
//CountryContext model
namespace OlympicFlags.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
               new Category { CategoryId = "i", Name = "Indoor" },
               new Category { CategoryId = "o", Name = "Outdoor" }
            );
            modelBuilder.Entity<Game>().HasData(
              new Game { GameId = "s", Name = "Summer Olympics" },
              new Game { GameId = "w", Name = "Winter Olympics" },
              new Game { GameId = "p", Name = "Paralympics" },
              new Game { GameId = "y", Name = "Youth Olympics" }
            );
            modelBuilder.Entity<Sport>().HasData(
       new Sport { SportId = "a", Name = "Archery" },
       new Sport { SportId = "b", Name = "Bobsleigh" },
       new Sport { SportId = "bd", Name = "Breakdancing" },
       new Sport { SportId = "cs", Name = "Canoe Sprint" },
       new Sport { SportId = "c", Name = "Curling" },
       new Sport { SportId = "d", Name = "Diving" },
       new Sport { SportId = "r", Name = "Road Cycling" },
       new Sport { SportId = "s", Name = "Skateboarding" }
  );
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, Name = "Austria", CategoryId = "o", GameId = "p", SportId = "cs", LogoImage = "Austria.png" },
                new Country { CountryId = 2, Name = "Brazil", CategoryId = "o", GameId = "s", SportId = "r", LogoImage = "Brazil.png" },
                new Country { CountryId = 3, Name = "Canada", CategoryId = "i", GameId = "w", SportId = "c", LogoImage = "Canada.png" },
                new Country { CountryId = 4, Name = "China", CategoryId = "i", GameId = "s", SportId = "d", LogoImage = "China.png" },
                new Country { CountryId = 5, Name = "Cyrpus", CategoryId = "i", GameId = "y", SportId = "bd", LogoImage = "Cyprus.png" },
                new Country { CountryId = 6, Name = "Finland", CategoryId = "o", GameId = "y", SportId = "s", LogoImage = "Finland.png" },
                new Country { CountryId = 7, Name = "France", CategoryId = "i", GameId = "y", SportId = "bd", LogoImage = "France.png" },
                new Country { CountryId = 8, Name = "Germany", CategoryId = "i", GameId = "s", SportId = "d", LogoImage = "Germany.png" },
                new Country { CountryId = 9, Name = "Great Britian", CategoryId = "i", GameId = "w", SportId = "c", LogoImage = "Great Britain.png" },
                new Country { CountryId = 10, Name = "Italy", CategoryId = "o", GameId = "w", SportId = "b", LogoImage = "Italy.png" },
                new Country { CountryId = 11, Name = "Jamaica", CategoryId = "o", GameId = "w", SportId = "b", LogoImage = "Jamaica.png" },
                new Country { CountryId = 12, Name = "Japan", CategoryId = "o", GameId = "w", SportId = "b", LogoImage = "Japan.png" },
                new Country { CountryId = 13, Name = "Mexico", CategoryId = "i", GameId = "s", SportId = "d", LogoImage = "Mexico.png" },
                new Country { CountryId = 14, Name = "Netherlands", CategoryId = "o", GameId = "s", SportId = "r", LogoImage = "Netherlands.png" },
                new Country { CountryId = 15, Name = "Pakistan", CategoryId = "o", GameId = "p", SportId = "cs", LogoImage = "Pakistan.png" },
                new Country { CountryId = 16, Name = "Portugal", CategoryId = "o", GameId = "y", SportId = "s", LogoImage = "Portugal.png" },
                new Country { CountryId = 17, Name = "Russia", CategoryId = "i", GameId = "y", SportId = "bd", LogoImage = "Russia.png" },
                new Country { CountryId = 18, Name = "Slovakia", CategoryId = "o", GameId = "y", SportId = "s", LogoImage = "Slovakia.png" },
                new Country { CountryId = 19, Name = "Sweden", CategoryId = "i", GameId = "w", SportId = "c", LogoImage = "Sweden.png" },
                new Country { CountryId = 20, Name = "Thailand", CategoryId = "i", GameId = "p", SportId = "a", LogoImage = "Thailand.png" },
                new Country { CountryId = 21, Name = "Ukraine", CategoryId = "i", GameId = "p", SportId = "a", LogoImage = "Ukraine.png" },
                new Country { CountryId = 22, Name = "Uruguay", CategoryId = "i", GameId = "p", SportId = "a", LogoImage = "Uruguay.png" },
                new Country { CountryId = 23, Name = "USA", CategoryId = "o", GameId = "s", SportId = "r", LogoImage = "USA.png" },
                new Country { CountryId = 24, Name = "Zimbabwe", CategoryId = "o", GameId = "s", SportId = "cs", LogoImage = "Zimbabwe.png" }
                );
        }
    }
}
