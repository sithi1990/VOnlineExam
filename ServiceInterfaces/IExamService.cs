using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DTO;
namespace ServiceInterfaces
{
    public interface IExamService
    {
        bool AddNewExam(ExaminationDTO ex);
        bool UpdateExam(ExaminationDTO ex);
        bool DeleteExam(int examid);
        IEnumerable<ExaminationDTO> GetExams();
        bool Validate(ExaminationDTO exam);
    }
}
