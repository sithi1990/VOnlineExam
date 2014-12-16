using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace ServiceInterfaces
{
    public interface IExamService
    {
        void AddNewExam(Examination ex);
        void UpdateExam(Examination ex);
        void DeleteExam(int examid);
        bool Validate(Examination exam);
    }
}
