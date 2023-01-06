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
    public partial class EditaFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlEditar.Visible = false;
            btnEditar.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        protected void Block()
        {
            txtTitulo.Enabled = false;
            txtGenero.Enabled = false;
            txtProdutora.Enabled = false;
            txtUrl.Enabled = false;
            txtClassificacao.Enabled = false;
        }

        protected void DesBlock()
        {
            txtTitulo.Enabled = true;
            txtGenero.Enabled = true;
            txtProdutora.Enabled = true;
          
        }
        protected void Limpar()
        {
            txtIdFilme.Text =
           txtTitulo.Text =
           txtGenero.Text =
           txtProdutora.Text =
           txtUrl.Text =
           txtClassificacao.Text = string.Empty;
            SetFocus(txtIdFilme);
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Block();
            btnEditar.Enabled = true;
            int codigo = Convert.ToInt32(txtIdFilme.Text);
            FilmeDTO objPesquisa = new FilmeDTO();//modelo
            FilmeBLL objPesqBLL = new FilmeBLL();//metodo

            objPesquisa = objPesqBLL.BuscarFilme(codigo);

            if (objPesquisa != null)
            {
                txtTitulo.Text = objPesquisa.TituloFilme;
                txtGenero.Text = objPesquisa.GeneroFilme;
                txtProdutora.Text = objPesquisa.ProdutoraFilme;
                txtUrl.Text= objPesquisa.UrlImgFilme;
                txtClassificacao.Text = objPesquisa.DescricaoClassificacaoFilme;
            }
            else
            {
                lblMensagem.Text = "Não rolou a busca!!";
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            DesBlock();
            pnlCampos.Visible = false;
            pnlEditar.Visible = true;
            txtIdFilme.Enabled = false;
            btnEditar.Enabled = false;
            btnConfirmar.Enabled = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            FilmeDTO objPesquisa = new FilmeDTO();//modelo
            FilmeBLL objPesqBLL = new FilmeBLL();//metodo
            objPesquisa.IdFilme = Convert.ToInt32(txtIdFilme.Text);
            objPesquisa.TituloFilme = txtTitulo.Text;
            objPesquisa.GeneroFilme = txtGenero.Text;
            objPesquisa.ProdutoraFilme = txtProdutora.Text;
            objPesquisa.DescricaoClassificacaoFilme = rbl1.SelectedValue;
            if (flUp1.HasFile)
            {
                string str = flUp1.FileName;
                flUp1.PostedFile.SaveAs(Server.MapPath("~/Imagens" + "/" + str));
                string CaminhoImg = "~/Imagens" + "/" + str.ToString();
                objPesquisa.UrlImgFilme = CaminhoImg;

                objPesqBLL.EditarFilme(objPesquisa);

                lblMensagem.Text = "Filme " + objPesquisa.TituloFilme + " editado com sucesso!!";
                Limpar();
            }
        }
    }
}