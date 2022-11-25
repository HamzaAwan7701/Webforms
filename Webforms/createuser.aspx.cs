using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class createuser : System.Web.UI.Page
    {

        Sqldata data= new Sqldata();
        string ans = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible= false;
            Label3.Visible= false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            ans = data.createuser(txtusername.Text, txtpassword.Text);
            if (ans == "OK")
            {
                Label3.Visible = true;

            }
            else if (ans=="error")
            {

                Label4.Visible = true; 
            }


        }
    }
}