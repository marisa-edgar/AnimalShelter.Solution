using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Benson", Species = "Dog", Breed = "Lab", Age = 7, Gender = "Female" },
                  new Animal { AnimalId = 2, Name = "Pops", Species = "Dog", Breed = "Pit Bull", Age = 1, Gender = "Female" },
                  new Animal { AnimalId = 3, Name = "Trash Boat", Species = "Dog", Breed = "Shiba Inu", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 4, Name = "Rigby", Species = "Cat", Breed = "Spinx", Age = 4, Gender = "Male" },
                  new Animal { AnimalId = 5, Name = "Mordechai", Species = "Dog", Breed = "Greyhound", Age = 3, Gender = "Male" },
                  new Animal { AnimalId = 6, Name = "Margret", Species = "Dog", Breed = "Boston Terrier", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 7, Name = "Eileen", Species = "Cat", Breed = "Domestic Shorthair", Age = 3, Gender = "Female" },
                  new Animal { AnimalId = 8, Name = "Skips", Species = "Cat", Breed = "Manx", Age = 6, Gender = "Male" }
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
