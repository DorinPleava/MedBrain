namespace MedBrain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestVariantsInQuestModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "QuestionOptionsVariant1", c => c.String());
            AddColumn("dbo.Questions", "QuestionOptionsVariant2", c => c.String());
            AddColumn("dbo.Questions", "QuestionOptionsVariant3", c => c.String());
            AddColumn("dbo.Questions", "QuestionOptionsVariant4", c => c.String());
            AddColumn("dbo.Questions", "QuestionOptionsVariant5", c => c.String());
            AddColumn("dbo.Questions", "QuestionOptionsVariant6", c => c.String());
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant1");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant2");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant3");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant4");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant5");
            DropColumn("dbo.QuestionAnswers", "QuestionOptionsVariant6");
        }
        
        public override void Down()
        {
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant6", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant5", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant4", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant3", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant2", c => c.String());
            AddColumn("dbo.QuestionAnswers", "QuestionOptionsVariant1", c => c.String());
            DropColumn("dbo.Questions", "QuestionOptionsVariant6");
            DropColumn("dbo.Questions", "QuestionOptionsVariant5");
            DropColumn("dbo.Questions", "QuestionOptionsVariant4");
            DropColumn("dbo.Questions", "QuestionOptionsVariant3");
            DropColumn("dbo.Questions", "QuestionOptionsVariant2");
            DropColumn("dbo.Questions", "QuestionOptionsVariant1");
        }
    }
}
