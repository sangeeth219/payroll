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
    public partial class employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\payroll.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);

            String sqlSelectQuery = "select * from employee where UserName='" + username + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
              TextBox6.Text=(dr["Name"].ToString());
               TextBox7.Text=(dr["role"].ToString());
               TextBox8.Text = (dr["Id"].ToString());
               TextBox9.Text = (dr["UserName"].ToString());
               TextBox10.Text = (dr["Dept"].ToString());
               TextBox11.Text = (dr["Country"].ToString());
               TextBox12.Text = (dr["State"].ToString());
               TextBox13.Text = (dr["City"].ToString());
            }
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("payrollslip.aspx", true);
        }
    }
}