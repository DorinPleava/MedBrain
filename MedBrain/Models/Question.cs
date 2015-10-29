using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace MedBrain.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAdvice { get; set; }
        public bool QuestionReceived { get; set; }
        public bool QuestionAnsweredCorrectly { get; set; }
        public bool QuestionExpired { get; set; }
        public DateTime QuestionReceivedDate { get; set; }
        public DateTime QuestionAnsweredDate { get; set; }
        public string QuestionOptionsVariant1 { get; set; }
        public string QuestionOptionsVariant2 { get; set; }
        public string QuestionOptionsVariant3 { get; set; }
        public string QuestionOptionsVariant4 { get; set; }
        public string QuestionOptionsVariant5 { get; set; }
        public string QuestionOptionsVariant6 { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual QuestionAnswer QuestionAnswer { get; set; }
    }
}