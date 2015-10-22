namespace MedBrain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MorePropsQandA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "QuestionAdvice", c => c.String());
            AddColumn("dbo.Questions", "QuestionReceived", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "QuestionAnsweredCorrectly", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "QuestionExpired", c => c.Boolean(nullable: false));
            AddColumn("dbo.Questions", "QuestionReceivedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Questions", "QuestionAnsweredDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant1", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant2", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant3", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant4", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant5", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant6", c => c.String());
            AddColumn("dbo.QuestionAnswers", "CorrectAnswerString", c => c.String());
            AddColumn("dbo.QuestionAnswers", "CustomAnswer", c => c.String());
            AddColumn("dbo.QuestionAnswers", "CorrectAnswerExplication", c => c.String());
            DropColumn("dbo.Questions", "Advice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "Advice", c => c.String());
            DropColumn("dbo.QuestionAnswers", "CorrectAnswerExplication");
            DropColumn("dbo.QuestionAnswers", "CustomAnswer");
            DropColumn("dbo.QuestionAnswers", "CorrectAnswerString");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant6");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant5");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant4");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant3");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant2");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant1");
            DropColumn("dbo.Questions", "QuestionAnsweredDate");
            DropColumn("dbo.Questions", "QuestionReceivedDate");
            DropColumn("dbo.Questions", "QuestionExpired");
            DropColumn("dbo.Questions", "QuestionAnsweredCorrectly");
            DropColumn("dbo.Questions", "QuestionReceived");
            DropColumn("dbo.Questions", "QuestionAdvice");
        }
    }
}
