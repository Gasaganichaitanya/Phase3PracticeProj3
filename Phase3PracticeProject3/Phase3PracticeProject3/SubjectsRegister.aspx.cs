using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3PracticeProject3
{
    public partial class SubjectsRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            SqlConnection con = new SqlConnection("server=LAPTOP-KP6PKP4L;database=phase3practiceproj1SchoolDb;trusted_connection=true;");
            try
            {

                SqlCommand cmd = new SqlCommand("insert into Subjects(SubjectId,SubjectName,TeacherName) values(@SubjectId,@SubjectName,@TeacherName) ", con);
                cmd.Parameters.AddWithValue("@SubjectId", int.Parse(subjectid.Text));
                cmd.Parameters.AddWithValue("@SubjectName", subjectname.Text);
                cmd.Parameters.AddWithValue("@TeacherName", teachername.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Subjects Record Inserted!!!";


            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
            finally { con.Close(); }
        }
    }
}