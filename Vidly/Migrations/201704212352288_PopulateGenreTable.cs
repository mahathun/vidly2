namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (1, 'Romance')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (3, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (4, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
