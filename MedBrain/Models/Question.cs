using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace MedBrain.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionText { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionAdvice { get; set; }
        public bool QuestionReceived { get; set; }
        public bool QuestionAnsweredCorrectly { get; set; }
        public bool QuestionExpired { get; set; }
        public DateTime QuestionReceivedDate { get; set; }
        public DateTime QuestionAnsweredDate { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionOptionsVariant1 { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionOptionsVariant2 { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionOptionsVariant3 { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionOptionsVariant4 { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionOptionsVariant5 { get; set; }
        [DataType(DataType.MultilineText)]
        public string QuestionOptionsVariant6 { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual QuestionAnswer QuestionAnswer { get; set; }
    }
}