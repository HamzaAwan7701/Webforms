<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Webforms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  
        <table>


            <tr>


                <td>

                    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>


                </td>
                    
          


                <td>

                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>


                </td>

                </tr>
            <tr>
                <td>

                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>


                </td>
                

                
               
                <td>

                    <asp:TextBox ID="txtpassword" runat="server" OnTextChanged="txtpassword_TextChanged"></asp:TextBox>


                </td>



                </tr>
                  <tr> 
                      <td>     
                          <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />


                      </td>
                    
                      


                  </tr>
            <tr>  


                <td>   

                </td>
                <td style="color:Tomato;" >     <asp:Label ID="Label3" runat="server"       Text="Incorrect Username or Password"></asp:Label>            </td>
            </tr>


          
            <tr> 
                <td> 

                </td>
                <td  style="color:mediumspringgreen;"    >   <asp:Label ID="Label4" runat="server" Text="Logged in Successfully"></asp:Label>     </td>
            </tr>

        </table>


    </form>
</body>
</html>
