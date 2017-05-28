namespace GamesCatalog.Migrations
{
    using GamesCatalog.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GamesCatalog.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GamesCatalog.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(i => i.Title,
                new Game
                {
                    Title = "Bioshock",
                    ReleaseDate = 2007,
                    Genre = "FPS",
                    MetacriticScore = 96
                },
                new Game
                {
                    Title = "Bioshock 2",
                    ReleaseDate = 2010,
                    Genre = "FPS",
                    MetacriticScore = 88
                },
                new Game
                {
                    Title = "Bioshock Infinite",
                    ReleaseDate = 2013,
                    Genre = "FPS",
                    MetacriticScore = 94
                },
                new Game
                {
                    Title = "Fallout New Vegas",
                    ReleaseDate = 2010,
                    Genre = "RPG",
                    MetacriticScore = 84
                }
                );
        }
    }
}
