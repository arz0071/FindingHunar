using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindingHunar.Data.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int JobId  { get; set; }
        public Job Job { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
