<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageStudent.aspx.cs" Inherits="module5_5Web.ManageStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 353px; width: 1095px; display: flex;">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <div style="height: 264px; margin-top: 0px">
            <div style="height: 167px; width: 594px">
                <asp:Label ID="Label1" runat="server" BorderColor="#3399FF" BorderStyle="Double" Text="Label" Width="200px"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="209px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <asp:Label ID="Label2" runat="server" BorderColor="#3399FF" BorderStyle="Double" Text="Label" Width="200px"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <asp:Label ID="Label3" runat="server" BorderColor="#3399FF" BorderStyle="Double" Text="Label" Width="200px"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </div>
        </div>
    </form>
</body>
</html>
