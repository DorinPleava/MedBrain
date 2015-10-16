using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace MedBrain.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Advice { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual QuestionAnswer QuestionAnswer { get; set; }
    }
}