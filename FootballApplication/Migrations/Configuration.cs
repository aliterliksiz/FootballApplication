namespace FootballApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballApplication.FootballContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FootballApplication.FootballContext context)
        {
            context.Teams.AddOrUpdate
                (
                new Team { Id = 1, Name = "Galatasaray", FoundationYear = 1905},
                new Team { Id = 2, Name = "Fenerbahçe", FoundationYear = 1907 },
                new Team { Id = 3, Name = "Beşiktaş", FoundationYear = 1903 }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
