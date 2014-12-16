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
        void AddNew(Examination ex);
        void Update(Examination ex);
        void Delete(int examid);
        IEnumerable<Examination> GetExams();
    }
}
