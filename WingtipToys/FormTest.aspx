<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormTest.aspx.cs" Inherits="WingtipToys.FormTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User name:-<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <br />
            Password:-<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button 1" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Button 2" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
