<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="EditaFilme.aspx.cs" Inherits="Phobos.UI.Pages.EditaFilme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container bg-dark">
        <h1 class="text-light font-weight-light" style="font-size: 60px">Editar Filme</h1>
        <br />
        <h4 class="text-light lead">Digite o Id do Filme</h4>
        <asp:TextBox AutoCompleteType="Disabled" ID="txtIdFilme" runat="server" Width="15%" CssClass="form-control" MaxLength="5"></asp:TextBox>
        <br />
        <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-warning" OnClick="btnPesquisar_Click" />
        <br />
        <asp:Label runat="server" Text="Titulo" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtTitulo" CssClass="form-control" MaxLength="50" runat="server" Width="50%" />

        <br />
        <asp:Label runat="server" Text="Gênero" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtGenero" CssClass="form-control" MaxLength="50" runat="server" Width="50%" />

        <br />
        <asp:Label runat="server" Text="Produtora" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtProdutora" CssClass="form-control" MaxLength="50" runat="server" Width="50%" />

        <br />

        <asp:Panel ID="pnlCampos" runat="server">

        <asp:Label runat="server" Text="URL" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtUrl" CssClass="form-control" MaxLength="50" runat="server" Width="50%" />

        <br />

        <asp:Label runat="server" Text="Classificação" CssClass="text-light lead" />
        <asp:TextBox AutoCompleteType="Disabled" ID="txtClassificacao" CssClass="form-control" MaxLength="50" runat="server" Width="50%" />
            </asp:Panel>
        <br />

        <asp:Panel ID="pnlEditar" runat="server">
            <asp:Label runat="server" Text="Selecione a classificação" CssClass="text-light lead" />
            <asp:RadioButtonList ID="rbl1" runat="server" CssClass="form-control-range text-light lead">
                <asp:ListItem Value="1" Text="Livre" />
                <asp:ListItem Value="2" Text="+18" />
            </asp:RadioButtonList>
            <br />

            <asp:Label runat="server" Text="Selecione a imagem do filme" CssClass="text-light lead" />
            <br />
            <asp:FileUpload ID="flUp1" runat="server" Text="Selecione a imagem" CssClass="btn btn-secondary" />
        </asp:Panel>
        <br />
        <br />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-secondary" OnClick="btnEditar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary" OnClick="btnCancelar_Click" />
        <a class="btn btn-secondary text-light lead" href="IndexAdm.aspx">Voltar</a>

        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-secondary" OnClick="btnConfirmar_Click" />
        <br />
        <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead" />
    </div>

</asp:Content>
