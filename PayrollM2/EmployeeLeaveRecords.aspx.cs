using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace PayrollM2
{
    public partial class EmployeeLeaveRecords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\payroll.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            String sqlSelectQuery = "select * from Leave where Id='" + Id + "'";;
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = (dr["Id"].ToString());
                TextBox2.Text = (dr["Name"].ToString());
                TextBox3.Text = (dr["Days"].ToString());
                
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("payrollslip.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Clear();
                Response.Redirect("LoginForm.aspx");
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}