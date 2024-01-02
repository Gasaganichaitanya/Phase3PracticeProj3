using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase3PracticeProject3
{
    public partial class ClassesDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=LAPTOP-KP6PKP4L;database=phase3practiceproj1SchoolDb;trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("select * from  Classes", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                LblMsg.Text = "Number of Classes are:" + ds.Tables[0].Rows.Count;
                gvClasses.DataSource = ds.Tables[0];
                gvClasses.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
            finally { }
        }
    }
}