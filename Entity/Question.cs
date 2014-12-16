using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Question
    {
        public int ID { get; set; }
        public string QuestionDescription { get; set; }
        public int CorrectAnsID { get; set; }

        public int ExaminationID { get; set; }

        public virtual Examination Examination { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
    }
}
