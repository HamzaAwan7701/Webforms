using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Sqldata data = new Sqldata();
        string ans;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible= false;  
            Label3.Visible= false;  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           
            ans=data.deleteuser(txtusername.Text);  
            if(ans=="OK")
            {
                Label2.Visible= true;
                

            }
            else
            {
                    Label3.Visible= true;

            }


        }
    }
}