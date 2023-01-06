<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ConsultaFilme.aspx.cs" Inherits="Phobos.UI.Pages.ConsultaFilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="jumbotron jumbotron-fluid bg-dark">
    <div class="container bg-dark">
        <h1 class="text-light font-weight-light" style="font-size:60px">Consulta de Filme</h1>
        <br />
        
                <asp:GridView runat="server" ID="dgv1" CssClass="table table-hover table-striped text-center" GridLines="None" AutoGenerateColumns="false" BackColor="silver">
                    <Columns>
                        <asp:BoundField DataField="IdFilme" HeaderText="Id" />
                        <asp:BoundField DataField="TituloFilme" HeaderText="Titulo" />
                        <asp:BoundField DataField="GeneroFilme" HeaderText="Genero" />
                        <asp:BoundField DataField="ProdutoraFilme" HeaderText="Produtora" />
                        <asp:ImageField DataImageUrlField="UrlImgFilme" HeaderText="Imagem" ControlStyle-Width="100" ControlStyle-Height="100" />
                        
                        

                    </Columns>
                </asp:GridView>
                 <p>                                       
                    <a href="/index.aspx" class="btn btn-default">Voltar</a>
                    <br /><br /><br />
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                   
                </p>
         </div>
    </div>
   

</asp:Content>
