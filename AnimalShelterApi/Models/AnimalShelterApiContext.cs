using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Matilda", AgeYears = 0, AgeMonths = 6, Sex = "Female", Breed = "Domestic Short Hair", Weight = 3, Coloring = "Orange/White", Description = "Playful orange kitten Matilda came to us with her brother Rexie", DateAvailable = "4/10/2023" },
          new Cat { CatId = 2, Name = "Rexie",AgeYears = 0, AgeMonths = 6, Sex = "Male", Breed = "Domestic Short Hair", Weight = 4, Coloring = "Gray/White", Description = "Mellow kitten Rexie came to us with his sister Matilda", DateAvailable = "4/10/2023"  }
        );
        builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Danny", AgeYears = 2, AgeMonths = 6, Sex = "Male", Breed = "Boxer/Mix", Weight = 60, Coloring = "Brown/White", Description = "Fun guy Danny loves chasing bugs and taking naps", DateAvailable = "4/15/2023" },
          new Dog { DogId = 2, Name = "Mary", AgeYears = 0, AgeMonths = 9, Sex = "Female", Breed = "Labrador", Weight = 35, Coloring = "Yellow", Description = "Mary is a sweet puppy who loves playing with kittens Matilda and Rexie", DateAvailable = "4/16/2023"  }
        );
    }
  }
}