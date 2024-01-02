using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3PracticeProject3
{
    public partial class ClassesRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            SqlConnection con = new SqlConnection("server=LAPTOP-KP6PKP4L;database=phase3practiceproj1SchoolDb;trusted_connection=true;");
            try
            {

                SqlCommand cmd = new SqlCommand("insert into Classes(ClassId,ClassName) values(@ClassId,@ClassName) ", con);
                cmd.Parameters.AddWithValue("@ClassId", int.Parse(ClassId.Text));
                cmd.Parameters.AddWithValue("@ClassName", ClassName.Text);
               
                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Class Record Inserted!!!";


            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
            finally { con.Close(); }
        }
    }
}