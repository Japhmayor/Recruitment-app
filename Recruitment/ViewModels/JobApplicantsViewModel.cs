using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.ViewModels
{
    public class JobApplicantsViewModel
    {
        public Job Job { get; set; }

        public List<Applicant> Applicants { get; set; }

    }
}
