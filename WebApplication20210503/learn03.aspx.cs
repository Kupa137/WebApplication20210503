using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20210503
{
    public partial class learn03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["txtbox"] += Session["userName"]+":"+TextBox1.Text+"<br/>";
            Label1.Text =Convert.ToString(Application["txtbox"]);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(Application["txtbox"]);

        }

        protected void BtnUserName_Click(object sender, EventArgs e)
        {
            Session["userName"] = userInput.Text;
        }
    }
}