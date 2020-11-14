using System;
using System.Collections.Generic;

namespace ResumeAngularNet.Models
{
    public partial class Education
    {
        public int Id { get; set; }
        public string Institution { get; set; }
        public string Title { get; set; }
        public string DateIni { get; set; }
        public string DateFin { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int? Contact { get; set; }
    }
}
