namespace FindingHunar.Data.Models
{
    public class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int JobId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public Job Job { get; set; }
    }
}
