using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TraineeExamEnrollment
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Marks { get; set; }

        public bool? IsApproved { get; set; }
        public int TraineeID { get; set; }
        public int ExaminationID { get; set; }
        public virtual Examination Examination { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}
