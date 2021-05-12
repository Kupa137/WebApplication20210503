using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20210503
{
    public partial class learn01 : System.Web.UI.Page
    {
        static int temp=2;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    paperStone();

            //}
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {       
                
            paperStone();
            Label3.Text =""+ temp;       
        }

        public void paperStone()
        {
            Random ran = new Random();
            temp = ran.Next(0, 3);
            if (temp == 0) Image1.ImageUrl = "~/images/0.jpg";//~是指根目錄//石頭
            else if (temp == 1) Image1.ImageUrl = "~/images/2.jpg";//剪刀
            else if (temp == 2) Image1.ImageUrl = "~/images/5.jpg";//布
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = "玩家出:石頭";
            if (temp == 0) Label2.Text = "safe";
            else if (temp == 1) Label2.Text = "win";
            else if (temp == 2) Label2.Text = "lose"; Label3.Text = "" + temp;

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = "玩家出:剪刀";
            if (temp == 0) Label2.Text = "lose";
            else if (temp == 1) Label2.Text = "safe";
            else if (temp == 2) Label2.Text = "win"; Label3.Text = "" + temp;

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = "玩家出:布";
            if (temp == 0) Label2.Text = "win";
            else if (temp == 1) Label2.Text = "lose";
            else if (temp == 2) Label2.Text = "safe"; Label3.Text = "" + temp;


        }
    }
}