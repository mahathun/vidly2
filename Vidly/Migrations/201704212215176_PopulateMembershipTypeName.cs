namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Pay as go' WHERE id=1");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Monthly' WHERE id=2");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Quarterly' WHERE id=3");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Annualy' WHERE id=4");
        }
        
        public override void Down()
        {
        }
    }
}
