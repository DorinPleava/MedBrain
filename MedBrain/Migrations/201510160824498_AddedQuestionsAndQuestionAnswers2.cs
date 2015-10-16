namespace MedBrain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedQuestionsAndQuestionAnswers2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionAnswers",
                c => new
                    {
                        QuestionAnswerId = c.Int(nullable: false),
                        AnswerText = c.String(),
                        CorrectAnswer = c.String(),
                    })
                .PrimaryKey(t => t.QuestionAnswerId)
                .ForeignKey("dbo.Questions", t => t.QuestionAnswerId)
                .Index(t => t.QuestionAnswerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionAnswers", "QuestionAnswerId", "dbo.Questions");
            DropIndex("dbo.QuestionAnswers", new[] { "QuestionAnswerId" });
            DropTable("dbo.QuestionAnswers");
        }
    }
}
