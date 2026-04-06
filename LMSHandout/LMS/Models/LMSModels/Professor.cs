using System;
using System.Collections.Generic;

namespace LMS.Models.LMSModels
{
    public partial class Professor
    {
        public Professor()
        {
            Classes = new HashSet<Class>();
        }

        public string UId { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateOnly Dob { get; set; }
        public uint WorksInId { get; set; }

        public virtual Department WorksIn { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}
