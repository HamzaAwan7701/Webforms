using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Webforms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ans;
        Sqldata data=new Sqldata(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible= false;  
            Label4.Visible= false;  
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {


            ans = data.validateuser(txtusername.Text, txtpassword.Text);
            if (ans == "OK")
            {
                Label4.Visible = true;
                
            
            }
            else if (ans=="KO")
            {

                Label3.Visible= true;   

            }


        }

        protected void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}