using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using DALInterfaces;
using System.Data;

namespace DAL
{
    public class ExamRepository : IExamDataAccess
    {
        SqlConnection con = Connection.GetConnection();

        public void AddNew(Exam ex)
        {

            SqlCommand com = new SqlCommand("sp_add_exam @1,@2", con);
            com.Parameters.AddWithValue("@1", ex.ExamName);
            com.Parameters.AddWithValue("@2", ex.PassMark);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


        }

        public void Update(Exam ex)
        {
            SqlCommand com = new SqlCommand("sp_update_exam @1,@2,@3", con);
            com.Parameters.AddWithValue("@1", ex.ExamID);
            com.Parameters.AddWithValue("@2", ex.ExamName);
            com.Parameters.AddWithValue("@3", ex.PassMark);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


        }

        public void Delete(int examid)
        {
            SqlCommand com = new SqlCommand("sp_add_exam @1", con);
            com.Parameters.AddWithValue("@1", examid);           
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


        }



        
        //public List<Exam> GetExams()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("sp_get_all_exams", con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    List<Exam> exam = new List<Exam>();
        //    foreach(DataRow dr in dt.Rows)
        //    {
        //       // exam.Add()
        //    }
        //}


        public List<Exam> GetExams()
        {
            throw new NotImplementedException();
        }
    }
}
