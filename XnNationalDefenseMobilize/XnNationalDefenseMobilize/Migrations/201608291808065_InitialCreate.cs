namespace XnNationalDefenseMobilize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommonQues",
                c => new
                    {
                        question_id = c.Int(nullable: false, identity: true),
                        question_content = c.String(),
                        question_answer = c.String(),
                    })
                .PrimaryKey(t => t.question_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CommonQues");
        }
    }
}
