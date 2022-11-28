<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateuser.aspx.cs" Inherits="Webforms.updateuser" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>


                </td>
                <td>
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>


                </td>
                <td>
                    &emsp;
                    <asp:Button ID="search_btn" runat="server" Text="Search Username" OnClick="search_btn_Click" />


                </td>

            </tr>

            <tr>
                <td>


                    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>

                </td>

                <td>

                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>


                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <br />
                    <br />


                </td>
                <td>
                    &ensp;&ensp;&ensp;
                    <asp:Button ID="update_btn" runat="server" Text="Update User" OnClick="update_btn_Click" />

                </td>

            </tr>
            <tr>

                <td   style="color:limegreen;" >
                    <asp:Label ID="Label3" runat="server" Text="User updated successfully"></asp:Label>

                </td>
            </tr>
            <tr>

                <td style="color:tomato;"    >
                    <asp:Label ID="Label4" runat="server" Text="User update failed"></asp:Label>

                </td>
            </tr>
        </table>



    </form>
</body>
</html>
