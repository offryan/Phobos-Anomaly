<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CadastroFilme.aspx.cs" Inherits="Phobos.UI.Pages.CadastroFilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-dark">
        <h1 class="text-light font-weight-light" style="font-size:60px">Cadastro de Filme</h1>
        <br />
        <asp:Label runat="server" Text="Titulo" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtTitulo" Cssclass="form-control" MaxLength="50" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredTitulo" runat="server" ErrorMessage="Digite o nome do filme" ForeColor="Red" ControlToValidate="txtTitulo">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Gênero" CssClass="text-light lead"/>
        <asp:TextBox AutoCompleteType="Disabled" ID="txtGenero" Cssclass="form-control" MaxLength="50" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredGenero" runat="server" ErrorMessage="Digite o Gênero" ForeColor="Red" ControlToValidate="txtGenero">
        </asp:RequiredFieldValidator>
        <br />
        <asp:Label runat="server" Text="Produtora" CssClass="text-light lead"/>
        <asp:TextBox AutoCompleteType="Disabled" ID="txtProdutora" CssClass="form-control" MaxLength="50" runat="server" Width="50%"/>
        <asp:RequiredFieldValidator ID="RequiredProdutora" runat="server" ErrorMessage="Digite a Produtora" ForeColor="Red" ControlToValidate="txtProdutora">
        </asp:RequiredFieldValidator>
        <br />
       
        <asp:Label runat="server" Text="Selecione a classificação" CssClass="text-light lead" />
        <asp:RadioButtonList ID="rbl1" runat="server" CssClass="form-control-range text-light lead">
            <asp:ListItem Value="1" Text="Livre" />
            <asp:ListItem Value="2" Text="+18" />
        </asp:RadioButtonList>
        <br />
       
        <asp:Label runat="server" Text="Selecione a imagem do filme" CssClass="text-light lead" />
       <br />
       <asp:FileUpload ID="flUp1" runat="server" Text="Selecione a imagem" CssClass="btn btn-secondary"/>
       
        <br /><br />
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="btn btn-secondary" OnClick="btnCadastrar_Click"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary"/>
            <a class="btn btn-secondary text-light lead" href="IndexAdm.aspx">Voltar</a>
        <br />
        <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead" />
    </div>

</asp:Content>
