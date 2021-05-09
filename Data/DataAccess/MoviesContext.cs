using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Data.DataAccess
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                    new Movie()
                    {
                        MovieId = 1,
                        MovieName = "Sonic The Hedgehog",
                        MainCharacter = "Sonic",
                        DurationInMinutes = 100
                    },
                    new Movie() {
                        MovieId = 2,
                        MovieName = "Demon Slayer: Kimetsu no Yaiba the Movie: Mugen Train",
                        MainCharacter = "Kamado Tanjiro",
                        DurationInMinutes = 120
                    },
                    new Movie() {
                        MovieId = 3,
                        MovieName = "Howl's Moving Castle",
                        MainCharacter = "Howl Jenkins Pendragon",
                        DurationInMinutes = 200
                    },
                    new Movie() {
                        MovieId = 4,
                        MovieName = "Soul",
                        MainCharacter = "Joe Gardner",
                        DurationInMinutes = 107
                    },
                    new Movie() {
                        MovieId = 5,
                        MovieName = "EVANGELION 3.0 YOU CAN (NOT) REDO",
                        MainCharacter = "Shinji Ikari",
                        DurationInMinutes = 106
                    },
                    new Movie() {
                        MovieId = 6,
                        MovieName = "The Last: Naruto the Movie",
                        MainCharacter = "Naruto Uzumaki",
                        DurationInMinutes = 112
                    },
                    new Movie()
                    {
                        MovieId = 7,
                        MovieName = "Godzila vs. Kong",
                        MainCharacter = "Godzila",
                        DurationInMinutes = 113
                    },
                    new Movie()
                    {
                        MovieId = 8,
                        MovieName = "The Hunger Games",
                        MainCharacter = "Katniss Everdeen",
                        DurationInMinutes = 146
                    },
                    new Movie()
                    {
                        MovieId = 9,
                        MovieName = "1917",
                        MainCharacter = "William Schofield",
                        DurationInMinutes = 119
                    },
                    new Movie()
                    {
                        MovieId = 10,
                        MovieName = "Megamente",
                        MainCharacter = "Megamente",
                        DurationInMinutes = 96
                    },
                    new Movie()
                    {
                        MovieId = 11,
                        MovieName = "Spirited Away",
                        MainCharacter = "Chihiro Ogino",
                        DurationInMinutes = 125
                    },
                    new Movie()
                    {
                        MovieId = 12,
                        MovieName = "Titanic",
                        MainCharacter = "Jack",
                        DurationInMinutes = 269
                    },
                    new Movie()
                    {
                        MovieId = 13,
                        MovieName = "Kimi no Nawa",
                        MainCharacter = "Taki Tachibana",
                        DurationInMinutes = 112
                    },
                    new Movie()
                    {
                        MovieId = 14,
                        MovieName = "9",
                        MainCharacter = "9",
                        DurationInMinutes = 81
                    }
                );
        }
    }
}
