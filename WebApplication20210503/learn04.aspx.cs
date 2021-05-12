using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication20210503
{
    public partial class learn04 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;
            //SqlConnection connection = new SqlConnection(s_data);
            //SqlCommand command = new SqlCommand($"SELECT * FROM [Customers2]", connection);
            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while(reader.Read())
            //    {
            //        Label1.Text +="<div>"+reader[1].ToString()+"</div>";
            //    }
            //}
            //connection.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = Request.Form["in1"];
            Session["str"] = Request.Form["in1"].ToString();
            //Label1.Text = Session["str"].ToString();
            Response.Redirect("Handler1.ashx");


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string username = txtusername.Text;
            SqlCommand command = new SqlCommand($"SELECT * FROM [users] where name='"+username+"'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if(reader.Read())
                {
                    if (reader["password"].ToString() == txtpassword.Text)
                    {
                        Label2.Text = "ok";
                    }
                    else Label2.Text = "no";
                }
            }
            else { Label2.Text = "no this user"; }


            connection.Close();
        }

        protected void btnNewAccount_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"insert into[users](name,password)values(@name,@password)";//@是代預存，方便之後大量寫入時用
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);


            command.Parameters.Add("@name",SqlDbType.NVarChar);//設定代預存的型別
            command.Parameters["@name"].Value = txtInputUsername.Text;//決定寫入的值

            command.Parameters.Add("@password", SqlDbType.NVarChar);
            command.Parameters["@password"].Value = txtInputPassword.Text;


            command.ExecuteNonQuery();

            connection.Close();
           
        }
    }
}