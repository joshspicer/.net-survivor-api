namespace survivorapi2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;


    using survivorapi2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<survivorapi2.Models.survivorapi2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(survivorapi2.Models.survivorapi2Context context)
        {

            Player ravi = new Player() { Id = 1, Name = "Ravi", Hometown = "Niskyuna, NY", Major = "Supply Chain", Year = "5th Year" };
            Player caitlyn = new Player() { Id = 2, Name = "Caitlyn", Hometown = "Portland, OR", Major = "Biology", Year = "1st Year" };
            Player lindsey = new Player() { Id = 3, Name = "Lindsey", Hometown = "Wilmington, MA", Major = "Business", Year = "1st Year" };
            Player josh = new Player() { Id = 4, Name = "Josh", Hometown = "Whitman, MA", Major = "Computer Science", Year = "3rd Year" };
            Player alex = new Player() { Id = 5, Name = "Alex", Hometown = "Athens, Greece", Major = "TV Production", Year = "5th Year" };


            context.Players.AddOrUpdate(x => x.Id, ravi, caitlyn, lindsey, josh, alex);

            ICollection<Player> tigrisPlayers = new List<Player>();
            tigrisPlayers.Add(ravi);
            tigrisPlayers.Add(caitlyn);

            ICollection<Player> azurePlayers = new List<Player>();
            azurePlayers.Add(josh);
            azurePlayers.Add(lindsey);
            azurePlayers.Add(alex);

            Tribe tigris = new Tribe()
            {
                Id = 1, Name = "Tigris", Color = "orange", players = tigrisPlayers
            };

            Tribe azure = new Tribe()
            {
                Id = 2,
                Name = "Azure",
                Color = "blue",
                players = azurePlayers
            };

            context.Tribes.AddOrUpdate(x => x.Id, tigris, azure);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
