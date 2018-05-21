namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotationsToCustomerClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "Address", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "City", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "State", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.People", "Interests", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Interests", c => c.String());
            AlterColumn("dbo.People", "State", c => c.String());
            AlterColumn("dbo.People", "City", c => c.String());
            AlterColumn("dbo.People", "Address", c => c.String());
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
        }
    }
}
