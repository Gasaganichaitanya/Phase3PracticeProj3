using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3PracticeProject3
{
    public partial class StudentsRegister : System.Web.UI.Page
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

                SqlCommand cmd = new SqlCommand("insert into Student(StudentName,StudentRollNo,ClassId,SubjectId) values(@StudentName,@StudentRollNo,@ClassId,@SubjectId) ", con);
                cmd.Parameters.AddWithValue("@StudentName", TxtStdntName.Text);
                cmd.Parameters.AddWithValue("@StudentRollNo", int.Parse(TxtStdntRollno.Text));
                cmd.Parameters.AddWithValue("@ClassId", int.Parse(TxtClassId.Text));
                cmd.Parameters.AddWithValue("@SubjectId", int.Parse(TxtSubjectId.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Student Record Inserted!!!";


            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
            finally { con.Close(); }
        }
    }
}