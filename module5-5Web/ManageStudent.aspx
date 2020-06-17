<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageStudent.aspx.cs" Inherits="module5_5Web.ManageStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 728px; width: 1114px; display: flex;">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <div style="height: 400px; margin-top: 0px">
            <div style="height: 200px; width: 594px">
                <asp:Label ID="Label1" runat="server" BorderColor="#3399FF" BorderStyle="Double" Text="First Name" Width="200px" Height="50px"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="50px" Width="200px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Find" Height="50px" OnClick="Button1_Click" Width="100px" />
                <asp:Label ID="Label2" runat="server" BorderColor="#3399FF" BorderStyle="Double" Text="Last Name" Width="200px" Height="50px"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Height="50px" Width="200px"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Delete" Height="50px" OnClick="Button2_Click" Width="100px" />
                <asp:Label ID="Label3" runat="server" BorderColor="#3399FF" BorderStyle="Double" Text="Major" Width="200px" Height="50px"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="major" DataValueField="major" Height="50px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBCS %>" SelectCommand="SELECT DISTINCT major FROM student"></asp:SqlDataSource>
                <asp:Button ID="Button3" runat="server" Text="Button" />
                <br />
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Update" />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Add" />
                <asp:GridView ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
