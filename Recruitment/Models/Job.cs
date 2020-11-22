using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//this class models the Job object
namespace Recruitment.Models
{
    public class Job
    {
        public int Id { get; set; }

        // The title of the job
        [Required, MaxLength(225), Display(Name = "Job Title", Prompt = "Job Title")]
        public string Title { get; set; }

        // The description of the job
        [Required, Display(Name = "Job Description", Prompt = "Job Description")]
        public string Description { get; set; }

        // The address of the job location
        [Required, Display(Name = "Location", Prompt = "Location")]
        public string Location { get; set; }

        // The type of the job(fulltime, parttime or internships)
        [Required(ErrorMessage = "Type is required"), Display(Name = "Type", Prompt = "Type")]
        public string Type { get; set; }

        // Expiration date of the job
        [Required, Display(Name = "Last Date", Prompt = "Last Date")]
        public DateTime LastDate { get; set; }

        // Name of Company or Org. offering the job
        [Required, Display(Name = "Company Name", Prompt = "Company Name")]
        public string CompanyName { get; set; }

        // Some detail about the company
        [Required, Display(Name = "Company Description", Prompt = "Company Description")]
        public string CompanyDescription { get; set; }

        // The website address of the company
        [Display(Name = "Website", Prompt = "Website")]
        [Url]
        public string Website { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool Filled { get; set; } = false;

        public User User { get; set; }

        public List<Applicant> Applicants { get; set; }
    }
}





