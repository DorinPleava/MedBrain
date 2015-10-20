using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedBrain.Models
{
    public class FullQuestion
    {
        public int FullQuestionId { get; set; }
        public Question Question { get; set; }
        public QuestionAnswer QuestionAnswer { get; set; }

    }
}
