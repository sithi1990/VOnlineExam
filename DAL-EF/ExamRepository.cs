using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using Entity;
using System.Data.Entity;
using DTO;
using AutoMapper;

namespace DAL_EF
{
    public class ExamRepository : IExamDataAccess
    {
        ExaminationContext context = new ExaminationContext();
        public void AddNew(ExaminationDTO ex)
        {
            
            context.Examinations.Add(Map(ex));
            context.SaveChanges();
        }

        public void Update(ExaminationDTO ex)
        {
            context.Entry(Map(ex)).State = EntityState.Modified;
            context.SaveChanges();
            
        }

        public void Delete(int examid)
        {
            Examination sub = context.Examinations.Find(examid);
            context.Examinations.Remove(sub);
            context.SaveChanges();
        }

        public IEnumerable<ExaminationDTO> GetExams()
        {
            
            List<Examination> exams= context.Examinations.ToList<Examination>();
            return Map(exams);
        }

        private Examination Map(ExaminationDTO dto)
        {
            Mapper.CreateMap<ExaminationDTO, Examination>();
            return Mapper.Map<Examination>(dto);
        }

        private List<ExaminationDTO> Map(List<Examination> entity)
        {
            List<ExaminationDTO> dtos = new List<ExaminationDTO>();
            foreach(var x in entity)
            {
                Mapper.CreateMap<Examination, ExaminationDTO>();
                ExaminationDTO dto = Mapper.Map<ExaminationDTO>(x);
                dtos.Add(dto);
            
            }
            return dtos;
        }

      
    }
}
