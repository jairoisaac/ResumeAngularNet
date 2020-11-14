using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeAngularNet.Models
{
    public class Company
    {
        public string company { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public virtual ICollection<CompanyItem> ExperienceItems { get; set; }
    }
}
