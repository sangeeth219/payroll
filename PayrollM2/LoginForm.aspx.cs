
using System.Collections.Generic;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

namespace PayrollM2
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                string username = txtUserName.Text;
                string password = txtPassword.Text;

                if (username == "aa" && password == "aa123")
                {
                    Session["currentusertype"] = "employee";
                    Response.Redirect("employee.aspx", false);
                }

                String source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\payroll.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(source);
                    SqlDataAdapter adp = new SqlDataAdapter("select * from employee where UserName='" + username + "' and Password='" + password + "'", con);
                    con.Open();
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count >= 1)
                    {
                        Session["currentusertype"] = "Employee";
                        Session["currentusername"] = username;
                        Session["currentuserpassword"] = password;
                        Session["currentemployeeid"] = Convert.ToInt32(dt.Rows[0]["employeeid"]);
                        Session["currentemployeename"] = Convert.ToString(dt.Rows[0]["name"]);
                        Response.Redirect("employee.aspx", true);
                    }
                   
                }

            
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
            /*
            String source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\DatabaseTrail2.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            String sqlSelectQuery = "SELECT * FROM Student WHERE Id = " + int.Parse(IdBox.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                NameBox.Text = (dr["Name"].ToString());
                TimeBox.Text = (dr["time"].ToString());
            }
            con.Close();
            */

        }
    }
}