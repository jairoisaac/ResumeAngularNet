using System;
using System.Collections.Generic;

namespace ResumeAngularNet.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Experience = new HashSet<Experience>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
    }
}
