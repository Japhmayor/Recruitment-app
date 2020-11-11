using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruitment.ViewModels.Home
{
    public class TrendingJobViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<Job> Trendings { get; set; }
    }
}
