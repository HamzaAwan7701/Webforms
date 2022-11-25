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
                
                 return "OK"; 

            }
            
               


            
            else
            {
                return "KO";
            }
            return "x";

        }
        public string createuser(string username, string password)
        {
            try
            {

                conn = new SqlConnection(connstr);
                conn.Open();
                string query = "Insert into webform_login values('" + username + "', '" + password + "')";

                cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return "OK";



                }


                conn.Close();
                return "error";



            }
            catch(Exception exp) 
            {
                return "error";
            }
           


        }


        public string deleteuser(string username)
        {
            conn = new SqlConnection(connstr);

            conn.Open();
            string query = "Delete from webform_login where (user_name='"+username+"')";
            cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {

                return "OK";
            }
            else
            {

                return "KO";
            }
            conn.Close();   
        }



        //public updateuser(string username)
        //{ conn = new SqlConnection(connstr);
        //conn.Open();
        //    string query=
        
        
        
        //}
             
 

    }
}