<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TryProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş Sayfası</title>  
    <style>
        .container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-form {
            max-width: 400px;
            width: 100%;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .form-label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .form-control {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 3px;
        }

        .btn {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }

        .btn:hover {
            background-color: #0056b3;
        }

        .error-message {
            color: red;
            margin-top: 10px;
        }

        .register-link {
            display: block;
            text-align: center;
            margin-top: 10px;
            color: #007bff;
        }

        .register-link:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class="container">
        <form id="form1" runat="server" class="login-form">
            <h2>Login</h2>
            <div>
                <asp:Label ID="UsernameLabel" runat="server" Text="Username:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="UsernameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="PasswordLabel" runat="server" Text="Password:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" CssClass="btn" />
            </div>
            <div>
                <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Text="" CssClass="error-message"></asp:Label>
            </div>
            <div>
                <asp:HyperLink ID="RegisterLink" runat="server" NavigateUrl="~/Register.aspx" Text="Hesabınız yoksa oluşturunuz!" CssClass="register-link" />
            </div>
        </form>
    </div>
</body>
</html>
