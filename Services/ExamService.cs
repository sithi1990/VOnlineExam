using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceInterfaces;
using Entity;
using DALInterfaces;

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

        public bool Validate(Examination ex)
        {
           
            if (ex.Description == null || ex.Description=="")
                modelerrors.AddError("ExamName", "Please Enter Exam Name");
            if(ex.CutOffMark == 0)
                modelerrors.AddError("PassMark", "Invalid Pass Mark");

            return modelerrors.IsValid;
        }


        public void AddNewExam(Examination ex)
        {
           if(this.Validate(ex))
           {
               repository.AddNew(ex);
           }
        }

        public void UpdateExam(Entity.Examination ex)
        {
            throw new NotImplementedException();
        }

        public void DeleteExam(int examid)
        {
            throw new NotImplementedException();
        }


       
    }
}
