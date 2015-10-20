namespace MedBrain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullQ : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FullQuestions",
                c => new
                    {
                        FullQuestionId = c.Int(nullable: false, identity: true),
                        Question_QuestionId = c.Int(),
                        QuestionAnswer_QuestionAnswerId = c.Int(),
                    })
                .PrimaryKey(t => t.FullQuestionId)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionId)
                .ForeignKey("dbo.QuestionAnswers", t => t.QuestionAnswer_QuestionAnswerId)
                .Index(t => t.Question_QuestionId)
                .Index(t => t.QuestionAnswer_QuestionAnswerId);
            
            AlterColumn("dbo.QuestionAnswers", "CorrectAnswer", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FullQuestions", "QuestionAnswer_QuestionAnswerId", "dbo.QuestionAnswers");
            DropForeignKey("dbo.FullQuestions", "Question_QuestionId", "dbo.Questions");
            DropIndex("dbo.FullQuestions", new[] { "QuestionAnswer_QuestionAnswerId" });
            DropIndex("dbo.FullQuestions", new[] { "Question_QuestionId" });
            AlterColumn("dbo.QuestionAnswers", "CorrectAnswer", c => c.Int(nullable: false));
            DropTable("dbo.FullQuestions");
        }
    }
}
