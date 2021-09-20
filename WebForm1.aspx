<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Value A"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Value B"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Them" />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Subtract Them" />
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiply Them" />
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Divide Them" />
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" style="height: 29px" Text="Complete All Calculations" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="margin-bottom: 0px" Text="Clear All Values" />
        </p>
    </form>
</body>
</html>
