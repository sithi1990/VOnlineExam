using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Examination
    {

        public int ID { get; set; }
        public string Description { get; set; }
        public int CutOffMark { get; set; }

        public int CourseID { get; set; }
        public virtual ICollection<TraineeExamEnrollment> TraineeExamEnrollments { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual Course Course { get; set; }
        
    }
}
