using System;
using System.Collections.Generic;

namespace ResumeAngularNet.Models
{
    public partial class ExperienceItem
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string DateIni { get; set; }
        public string DateFin { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Experience Company { get; set; }
    }
}
