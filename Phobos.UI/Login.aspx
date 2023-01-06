<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Phobos.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.mask.min.js"></script>
    <title>Login</title>
</head>
<body class="bg-dark">
    <form id="form1" runat="server">
    <div class="container bg-dark">
        <br />
        <h1 class="text-light font-weight-light">Phobos Anomaly</h1>
        <br />
        <asp:Label runat="server" Text="Usuário" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" Cssclass="form-control" MaxLength="50" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="Digite o nome do usuário" ForeColor="Red" ControlToValidate="txtUsuario">
        </asp:RequiredFieldValidator>
        <br />
        
        <asp:Label runat="server" Text="Senha" CssClass="text-light lead"/>
        <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" MaxLength="6" runat="server" Width="50%" TextMode="Password"/>
        <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ErrorMessage="Digite a Senha do usuário" ForeColor="Red" ControlToValidate="txtSenha">
        </asp:RequiredFieldValidator>
       
        <br />
        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" CssClass="btn btn-secondary" OnClick="btnEntrar_Click"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary"/>
            
        <br />
        <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead" />
    </div>
 </form>
</body>
</html>
