using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
namespace MedBrain.Models
{
  
    public class QuestionAnswer
    {
        [Key, ForeignKey("Question")]
        public int QuestionAnswerId { get; set; }
        public string QuestionOptionsVariant1 { get; set; }
        public string QuestionOptionsVariant2 { get; set; }
        public string QuestionOptionsVariant3 { get; set; }
        public string QuestionOptionsVariant4 { get; set; }
        public string QuestionOptionsVariant5 { get; set; }
        public string QuestionOptionsVariant6 { get; set; }
        public byte CorrectAnswer { get; set; }
        public string CorrectAnswerString { get; set; }
        public string CustomAnswer { get; set; }
        public string CorrectAnswerExplication { get; set; }
        public virtual Question Question { get; set; }
    }
}