namespace MedBrain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQuestionsAndQuestionAnswers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                        Advice = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            CreateTable(
                "dbo.QuestionUsers",
                c => new
                    {
                        Question_QuestionId = c.Int(nullable: false),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Question_QuestionId, t.User_Id })
                .ForeignKey("dbo.Questions", t => t.Question_QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Question_QuestionId)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionUsers", "User_Id", "dbo.User");
            DropForeignKey("dbo.QuestionUsers", "Question_QuestionId", "dbo.Questions");
            DropIndex("dbo.QuestionUsers", new[] { "User_Id" });
            DropIndex("dbo.QuestionUsers", new[] { "Question_QuestionId" });
            DropTable("dbo.QuestionUsers");
            DropTable("dbo.Questions");
        }
    }
}
