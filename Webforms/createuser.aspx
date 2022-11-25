<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createuser.aspx.cs" Inherits="Webforms.createuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>


        </td>
    </tr>

    <tr> 
        <td>
            <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />

        </td>



    </tr>

    <tr>     


        <td   style="color:mediumspringgreen;"  > <asp:Label ID="Label3" runat="server" Text="User created successfully"></asp:Label> 



        </td>
    </tr>
    <tr>
<td    style="color:tomato;" >    

    <asp:Label ID="Label4" runat="server" Text="User creation failed"></asp:Label>

</td>



    </tr>

</table>





        </div>
    </form>


</body>

</html>
