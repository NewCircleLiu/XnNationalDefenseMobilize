namespace XnNationalDefenseMobilize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeForCommQus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CommonQues", "question_release_time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CommonQues", "question_release_time");
        }
    }
}
