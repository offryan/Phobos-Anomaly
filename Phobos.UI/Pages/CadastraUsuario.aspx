<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CadastraUsuario.aspx.cs" Inherits="Phobos.UI.Pages.CadastroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron jumbotron-fluid bg-dark">
     <div class="container bg-dark">
        <h1 class="text-light font-weight-light">Cadastro de Usuário</h1>
        <br />
        <asp:Label runat="server" Text="Nome" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" Cssclass="form-control" MaxLength="50" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="Digite o nome do usuário" ForeColor="Red" ControlToValidate="txtUsuario">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="CPF" CssClass="text-light lead"/>
        <asp:TextBox AutoCompleteType="Disabled" ID="txtCpfUsuario" Cssclass="form-control cpf" MaxLength="14" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredCpf" runat="server" ErrorMessage="Digite o CPF do usuário" ForeColor="Red" ControlToValidate="txtCpfUsuario">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Senha" CssClass="text-light lead"/>
        <asp:TextBox AutoCompleteType="Disabled" ID="txtSenhaUsuario" CssClass="form-control" MaxLength="6" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ErrorMessage="Digite a Senha do usuário" ForeColor="Red" ControlToValidate="txtSenhaUsuario">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Data" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtDataNscUsuario" CssClass="form-control placeholderDate" MaxLength="10" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredData" runat="server" ErrorMessage="Digite a data" ForeColor="Red" ControlToValidate="txtDataNscUsuario">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Selecione o tipo de usuário" CssClass="text-light lead" />
        <asp:RadioButtonList ID="rbl1" runat="server" CssClass="form-control-range text-light lead">
            <asp:ListItem Value="1" Text="Administrador" />
            <asp:ListItem Value="2" Text="Outros" />
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-secondary" OnClick="btnCadastrar_Click"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary" />
            <a class="btn btn-secondary text-light lead" href="IndexAdm.aspx">Voltar</a>
        <br />
        <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead" />
    </div>
        </div>

</asp:Content>
