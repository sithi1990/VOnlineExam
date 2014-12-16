using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Exam
    {
        private int exam_id;

        public int ExamID
        {
            get { return exam_id; }
            set { exam_id = value; }
        }

        private string exam_name;

        public string ExamName
        {
            get { return exam_name; }
            set { exam_name = value; }
        }

        private int passmark;

        public int PassMark
        {
            get { return passmark; }
            set { passmark = value; }
        }

        
    }
}
