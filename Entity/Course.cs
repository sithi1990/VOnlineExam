using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<TraineeCourseEnrollment> TraineeCourseEnrollments { get; set; }
        public virtual ICollection<Examination> Examinations { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
    }
}
