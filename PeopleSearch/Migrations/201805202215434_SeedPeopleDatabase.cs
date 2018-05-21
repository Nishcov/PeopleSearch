namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedPeopleDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "City", c => c.String());
            AddColumn("dbo.People", "State", c => c.String());
            AddColumn("dbo.People", "Zip", c => c.Int(nullable: false));
            AddColumn("dbo.People", "Interests", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Interests");
            DropColumn("dbo.People", "Zip");
            DropColumn("dbo.People", "State");
            DropColumn("dbo.People", "City");
        }
    }
}
