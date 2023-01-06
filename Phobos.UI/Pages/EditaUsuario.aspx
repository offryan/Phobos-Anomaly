<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="EditaUsuario.aspx.cs" Inherits="Phobos.UI.Pages.EditaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron jumbotron-fluid bg-dark">
        <div class="container">
            <h1 class="text-light font-weight-light">Edição do Usuário</h1>
            <br />
            <h4 class="text-light lead">Digite o Id do Usuário</h4>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtIdUsuario" runat="server" Width="15%" CssClass="form-control" MaxLength="5"></asp:TextBox>
            
            <br />

            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-warning" OnClick="btnPesquisar_Click"/>
            
            <br />
            
            <asp:Panel ID="pnl2" runat="server">
            
                <h4 class="text-light lead">Nome</h4>
            <asp:TextBox ID="txtNome" runat="server" Width="50%" CssClass="form-control"></asp:TextBox>
           
            
            <h4 class="text-light lead">CPF</h4>
            <asp:TextBox ID="txtCpf" runat="server" Width="50%" CssClass="form-control cpf"></asp:TextBox>
           

            <h4 class="text-light lead">Senha</h4>
            <asp:TextBox ID="txtSenha" runat="server" Width="50%" CssClass="form-control" MaxLength="6"></asp:TextBox>

            <h4 class="text-light lead">Data</h4>
            <asp:TextBox ID="txtData" runat="server" Width="50%" CssClass="form-control"></asp:TextBox>
           

            <asp:Label ID="lblTituloSumir" runat="server" Cssclass="text-light lead" Text="Tipo Usuário"/>
            <asp:TextBox ID="txtTpUsuario" runat="server" Width="50%" CssClass="form-control" MaxLength="13"></asp:TextBox>
               
                </asp:Panel>
         
            
            <br />
            <%--tipo usuario--%>
            <asp:Panel ID="pnl1" runat="server">
            <h4 class="text-light lead">Selecione o Tipo de usuário</h4>
            <asp:RadioButtonList ID="rbl1" runat="server" CssClass="custom-radio text-light">
                <asp:ListItem Value="1" Text="Administrativo" />
                <asp:ListItem Value="2" Text="Outros" />
            </asp:RadioButtonList>
                </asp:Panel>
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluir_Click" OnClientClick= "if ( !confirm('Deseja realmente excluir este registro ? ')) return false"/>
            <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEditar_Click"/>
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-info" OnClick="btnConfirmar_Click"/>
            
            <br />
            <asp:Label ID="lblMensagem" runat="server" Cssclass="text-light font-weight-light"/>
           </div>
        </div>

</asp:Content>
