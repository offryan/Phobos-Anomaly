<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="Phobos.UI.Pages.ConsultaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron jumbotron-fluid bg-dark">
        <div class="container">
            <asp:GridView ID="dgv1" runat="server" GridLines="None" CssClass="table table-hover table-striped text-center" AutoGenerateColumns="false" BackColor="Silver">
                <Columns>
                    <asp:BoundField DataField="IdUsuario" HeaderText="Id_Usuario"/>
                    <asp:BoundField DataField="NomeUsuario" HeaderText="Nome"/>
                    <asp:BoundField DataField="CpfUsuario" HeaderText="CPF"/>
                    <asp:BoundField DataField="SenhaUsuario" HeaderText="Senha"/>
                    <asp:BoundField DataField="DataNascUsuario" HeaderText="Data"/>
                    <asp:BoundField DataField="DescricaoTipoUsuario" HeaderText="Descrição"/>
                </Columns>


            </asp:GridView>
            
            <br />
            
        </div>
        
    </div>
</asp:Content>
