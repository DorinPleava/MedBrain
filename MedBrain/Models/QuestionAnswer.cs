using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
namespace MedBrain.Models
{
  
    public class QuestionAnswer
    {
        [Key, ForeignKey("Question")]
        public int QuestionAnswerId { get; set; }
        public string AnswerText { get; set; }
        public string CorrectAnswer { get; set; }
        public virtual Question Question { get; set; }
    }
}