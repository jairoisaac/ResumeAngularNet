using System;
using System.Collections.Generic;

namespace ResumeAngularNet.Models
{
    public partial class Experience
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? Contact { get; set; }
        public virtual Contact ContactNavigation { get; set; }
        public virtual ICollection<ExperienceItem> ExperienceItem { get; set; }
    }
}
