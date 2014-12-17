using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceInterfaces;
using Entity;
using DALInterfaces;
using DTO;

namespace Services
{
    public class ExamService : IExamService
    {
        private IAppErrors modelerrors;
        private IExamDataAccess  repository;

        public ExamService(IAppErrors modelstate, IExamDataAccess repository)
        {
            this.modelerrors = modelstate;
            this.repository = repository;
        }

        public bool Validate(ExaminationDTO ex)
        {
           
            if (ex.Description == null || ex.Description=="")
                modelerrors.AddError("ExamName", "Please Enter Exam Name");
            if(ex.CutOffMark == 0)
                modelerrors.AddError("PassMark", "Invalid Pass Mark");

            return modelerrors.IsValid;
        }


        public bool AddNewExam(ExaminationDTO ex)
        {
           if(this.Validate(ex))
           {
               repository.AddNew(ex);
               return true;
           }
           return false;
        }

        public bool UpdateExam(ExaminationDTO ex)
        {
            if (this.Validate(ex))
            {
                repository.AddNew(ex);
                return true;
            }
            return false;
        }

        public bool DeleteExam(int examid)
        {
            repository.Delete(examid);
            return true;
        }




      
        public IEnumerable<ExaminationDTO> GetExams()
        {
            return repository.GetExams();
        }
    }
}
