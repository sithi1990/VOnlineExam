using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALInterfaces;
using DAL;
using DAL_TEXT;
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
            IExamService service = new ExamService(errors,new ExamRepository()) ;
            Exam ex = new Exam();
            ex.ExamName = "";
            ex.PassMark = 0;
            service.AddNewExam(ex);

           if (errors.IsValid)
             {
                 foreach (Error er in errors.GetErrors())
                  {
                      Console.WriteLine(er.Value);
                  }
                    
             }
            else
             {
                 Console.WriteLine("Success");
             }
             Console.ReadLine();
            
            
            
        }
    }
}
