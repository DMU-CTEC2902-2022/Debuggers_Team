<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="DebuggerCollege.Views.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblHeading" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Font-Strikeout="False" Text="Please fill in the form below "></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Full Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="154px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblNumber" runat="server" Text="Phone Number"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
