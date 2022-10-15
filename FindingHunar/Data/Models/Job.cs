﻿namespace FindingHunar.Data.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Skills { get; set; }
        public string Qualification { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
