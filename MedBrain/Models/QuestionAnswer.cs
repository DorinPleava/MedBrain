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
     
        [Required]
        public byte CorrectAnswer { get; set; }
        public string CorrectAnswerString { get; set; }
        public string CustomAnswer { get; set; }
        public string CorrectAnswerExplication { get; set; }
        public virtual Question Question { get; set; }
    }
}