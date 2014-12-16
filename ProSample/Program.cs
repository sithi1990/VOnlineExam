using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using DAL;

using ServiceInterfaces;
using Services;
using Entity;

namespace ProSample
{
    class Program
    {
        

        static void Main(string[] args)
        {
            IAppErrors errors=new AppErrors();
            IExamService service = new ExamService(errors,new ExamRepository());
            Examination ex = new Examination();
            ex.Description = "Data By ADO.NET";
            ex.CutOffMark = 24;
            ex.CourseID = 1;
            service.AddNewExam(ex);

            if (errors.IsValid)
             {
                 Console.WriteLine("Success");
             }
            else
             {
                 foreach (Error er in errors.GetErrors())
                 {
                     Console.WriteLine(er.Value);
                 }
             }
             Console.ReadLine();
            
            
            
        }
    }
}
