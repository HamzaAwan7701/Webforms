using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webforms
{
    public class Sqldata
    {

        const string connstr = @"Data Source=DESKTOP-G3SCMV3;Initial Catalog=testing_4;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable tb = new DataTable();

        public string validateuser(string username, string password)
        {

            conn= new SqlConnection(connstr); 
            conn.Open();
          string query="select * from webform_login where (user_name= '"+username+"' and password='"+password+"')";
            cmd=new SqlCommand(query,conn);
            adpt=new SqlDataAdapter(cmd);
            adpt.Fill(tb);
            if (tb.Rows.Count>0)
            {
                if (username == "Hamza" && password == "123"|| (username == "Asad" && password == "123")) 
                { return "OK"; }

            }
            
               


            
            else
            {
                return "KO";
            }
            return "x";

        }


    }
}