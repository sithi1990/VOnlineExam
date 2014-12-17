using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int CutOffMark { get; set; }

        public int CourseID { get; set; }
    }
}
