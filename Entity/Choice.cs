using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Choice
    {
        public int ID { get; set; }
        public string ChoiceDescription { get; set; }
        public int QuestionID { get; set; }

        public Question Question { get; set; }


    }
}
