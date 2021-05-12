using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20210503
{
    public partial class learn02 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //string st1 = Request.ApplicationPath;
            //Label1.Text = st1;

            Application.Lock();
            Application["count"] = Convert.ToInt32(Application["count"]) + 1;
            Application.UnLock();
            Label1.Text = "讀取了" + Convert.ToString(Application["count"]) + "次";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string st1 = Request.Form["txtb1"];
            //string st1 = Request.QueryString["inp1"];
            //Label1.Text = st1;
        }

        static int count = 0;

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            count++;
            Label_t.Text = "" + count;
        }
    }
}