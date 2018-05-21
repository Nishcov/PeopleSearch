namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPictureToDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Picture");
        }
    }
}
