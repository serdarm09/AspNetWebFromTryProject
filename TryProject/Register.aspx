<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TryProject.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kayıt Sayfası</title>
    <style>
        .container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .register-form {
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

        .login-link {
            display: block;
            text-align: center;
            margin-top: 10px;
            color: #007bff;
        }

        .login-link:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class="container">
         
        <form id="form1" runat="server" class="register-form">
                <h2>Login</h2>
            <div>
                <asp:TextBox ID="UserMail" runat="server" CssClass="form-control" Height="30px" Width="380px" TextMode="Email" placeholder="E-posta Adresi"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="UserName" runat="server" CssClass="form-control" Height="30px" Width="380px" OnTextChanged="TextBox3_TextChanged" placeholder="Kullanıcı Adı"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="UserPassword" runat="server" CssClass="form-control" Height="30px" Width="380px" TextMode="Password" OnTextChanged="TextBox2_TextChanged" placeholder="Şifre"></asp:TextBox>
            </div>
            <div style="margin-top: 10px">
                <asp:Button ID="ButtonR" runat="server" CssClass="btn btn-primary" OnClick="Button1_Click" Text="Kayıt Ol" Width="380px" />
            </div>
            <div>
                <asp:HyperLink ID="RegisterLink" runat="server" NavigateUrl="~/Login.aspx" Text="Hesabınız varsa giriş yapın!" CssClass="login-link" />
            </div>
            <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red" CssClass="error-message"></asp:Label>
        </form>
    </div>
</body>
</html>
