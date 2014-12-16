using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Trainee
    {
        public int ID { get; set; }
        public string TraineeName { get; set; }//

        public virtual ICollection<TraineeExamEnrollment> TraineeExamEnrollments { get; set; }
        public virtual ICollection<TraineeCourseEnrollment> TraineeCourseEnrollments { get; set; }
    }
}
