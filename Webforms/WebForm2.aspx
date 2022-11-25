<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Webforms.WebForm2" %>

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


               


                
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox> 

                </td>
               
         

                <td>  

                    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />



                </td>
           
                </tr>

            <tr>
                
                <td  style="color:mediumspringgreen;"   > <asp:Label ID="Label2" runat="server" Text="User deleted successfully"></asp:Label> </td>

                </tr>
            <tr>
                <td     style="color:tomato;"   >

                    <asp:Label ID="Label3" runat="server" Text="User doesnot exists"></asp:Label>


                </td>
                    
            </tr>

            </table>



       
    </form>
</body>
</html>
