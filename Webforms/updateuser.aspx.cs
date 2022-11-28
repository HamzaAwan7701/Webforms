using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class updateuser : System.Web.UI.Page
    {
        Sqldata data = new Sqldata();
        string ans;
        string ans1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            update_btn.Visible = false;
            txtpassword.Visible = false;


        }

        protected void search_btn_Click(object sender, EventArgs e)
        {

            ans = data.update_search(txtusername.Text);
            if (ans == "OK")
            {
                Label2.Visible = true;
                txtpassword.Visible = true;


                update_btn.Visible = true;

            }


        }








        protected void update_btn_Click(object sender, EventArgs e)
        {

            ans1 = data.updateuser(txtusername.Text, txtpassword.Text);

            if (ans1 == "true")
            {
                Label3.Visible = true;
            }
            else if (ans1 == "false")
            {
                Label4.Visible = true;
            }


        }
    }
}