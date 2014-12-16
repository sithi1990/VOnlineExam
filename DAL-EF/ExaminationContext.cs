using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL_EF
{
    public class ExaminationContext :DbContext
    {
        public ExaminationContext()
            : base("ExaminationContext")
        {
        }
        
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Material> Materials { get; set; }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Trainee> Trainees { get; set; }

        public DbSet<TraineeExamEnrollment> TraineeExamEnrollments { get; set; }
        public DbSet<TraineeCourseEnrollment> TraineeCourseEnrollments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
