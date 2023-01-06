using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.BLL;
using Phobos.DTO;

namespace Phobos.UI.Pages
{
    public partial class EditaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Enabled = false;
            btnConfirmar.Visible = false;
        }
        protected void Limpar()
        {
            txtIdUsuario.Text =
            txtNome.Text =
            txtCpf.Text =
            txtData.Text =
            txtSenha.Text =
            txtTpUsuario.Text = string.Empty;
            SetFocus(txtIdUsuario);

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtIdUsuario.Text);
            UsuarioDTO objPesquisa = new UsuarioDTO();//modelo
            UsuarioBLL objPesqBLL = new UsuarioBLL();//metodo

            objPesquisa = objPesqBLL.BuscarUsuario(codigo);

            if (objPesquisa != null)
            {
                txtNome.Text = objPesquisa.NomeUsuario;
                txtCpf.Text = objPesquisa.CpfUsuario;
                txtData.Text = objPesquisa.DataNascUsuario;
                txtSenha.Text = objPesquisa.SenhaUsuario;
                txtTpUsuario.Text = objPesquisa.DescricaoTipoUsuario;
            }
            else
            {
                lblMensagem.Text = "Não rolou a busca!!";
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            int codigo = Convert.ToInt32(txtIdUsuario.Text);
            UsuarioDTO objExclui = new UsuarioDTO();//modelo
            UsuarioBLL objExcluiBLL = new UsuarioBLL();//metodo
            objExcluiBLL.ExcluirUsuario(codigo);
            Limpar();
            lblMensagem.Text = "Registro Excluido com sucesso!!";

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Enabled = true;
            lblTituloSumir.Visible = false;
            txtTpUsuario.Visible = false;
            btnConfirmar.Visible = true;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioDTO objModelo = new UsuarioDTO();//modelo
            UsuarioBLL objEditaBLL = new UsuarioBLL();//metodo
            objModelo.NomeUsuario = txtNome.Text;
            objModelo.CpfUsuario = txtCpf.Text;
            objModelo.SenhaUsuario = txtSenha.Text;
            objModelo.DataNascUsuario = txtData.Text;
            objModelo.DescricaoTipoUsuario = rbl1.SelectedValue;
            objModelo.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            objEditaBLL.EditarUsuario(objModelo);
            lblMensagem.Text = "Usuário atualizado com sucesso!!";


        }
    }
}