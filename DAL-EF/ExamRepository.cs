using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Entity;
using System.Data.Entity;

namespace DAL_EF
{
    public class ExamRepository : IExamDataAccess
    {
        ExaminationContext context = new ExaminationContext();
        public void AddNew(Examination ex)
        {
            context.Examinations.Add(ex);
            context.SaveChanges();
        }

        public void Update(Examination ex)
        {
            context.Entry(ex).State = EntityState.Modified;
            context.SaveChanges();
            
        }

        public void Delete(int examid)
        {
            Examination sub = context.Examinations.Find(examid);
            context.Examinations.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<Examination> GetExams()
        {
            return context.Examinations.ToList<Examination>();
        }


      
    }
}
