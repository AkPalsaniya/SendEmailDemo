<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mailDemo.aspx.cs" Inherits="sendEmailDemo.mailDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Subject <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br />
            Message <asp:TextBox ID="txtMsg" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnSent" runat="server" Text="Send" OnClick="btnSent_Click"/>


        </div>
    </form>
</body>
</html>
