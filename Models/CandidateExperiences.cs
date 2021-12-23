using System;

namespace InfoJobs.Models
{
    public class CandidateExperiences
    {

        public int Id { get; set; }

        public string Company { get; set; }

        

        public string Job { get; set; }

        public string Description { get; set; }

        public float Salary { get; set; }

       public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; set; } = null;

        public DateTime InsertDate { get; set; } = DateTime.Now;

        public DateTime? ModifyDate { get; set; } = null;

       public  Candidates Candidates { get; set; }

        public  int IdCandidates { get; set; }

        public CandidateExperiences(int id, string company, string job)
        {
            this.Id = id;
            this.Company = company;
            this.Job = job;
           
        
           
        }

        public CandidateExperiences()
        {
        }
    }
}
