using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Material
    {
        public int ID { get; set; }
        public string MaterialName{ get; set; }
        public string MaterialResourceURL { get; set; }

        public int CourseID { get; set; }
        public virtual Course Courses { get; set; }
    }
}
