namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1,'Jazz')");
            Sql("INSERT INTO Genres VALUES (2,'Blues')");
            Sql("INSERT INTO Genres VALUES (3,'Rock')");
            Sql("INSERT INTO Genres VALUES (4,'Country')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
