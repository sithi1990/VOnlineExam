using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormTest.ServiceReference1;

namespace WebFormTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IExamService serv = new ExamServiceClient();
            GridView1.DataSource = serv.GetExams();
            GridView1.DataBind();
        }
    }
}