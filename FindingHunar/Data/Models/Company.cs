using System.Collections;
using System.Collections.Generic;

namespace FindingHunar.Data.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location{ get; set; }
        public string Domains { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
