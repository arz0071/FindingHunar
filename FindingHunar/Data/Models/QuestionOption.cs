using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindingHunar.Data.Models
{
    public class QuestionOption
    {
        public int Id { get; set; }
        public bool IsCorrect { get; set; }
        public string Option { get; set; }
    }
}
