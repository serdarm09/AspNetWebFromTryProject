<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TryProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anasayfa</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4><asp:Label ID="WelcomeMessage" runat="server" Text="Hoş geldiniz!"></asp:Label></h4>
            <asp:Button ID="LoginButton" runat="server" Text="Giriş Yap" OnClick="LoginButton_Click" Visible="False" />
        </div>
    </form>
</body>
</html>

