using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindingHunar.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int AssessmentId { get; set; }
        public string Title { get; set; }
        public Assessment Assessment { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
    }
}
