using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALInterfaces
{
    public interface IExamDataAccess
    {
        void AddNew(Exam ex);
        void Update(Exam ex);
        void Delete(int examid);
        List<Exam> GetExams();
    }
}
