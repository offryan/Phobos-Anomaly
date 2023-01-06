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
    public partial class CadastroFilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Limpar()
        {
            txtTitulo.Text =
            txtGenero.Text =
            txtProdutora.Text = string.Empty;
            rbl1.ClearSelection();
            SetFocus(txtTitulo);
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            //criando objeto modelo
            FilmeDTO objCad = new FilmeDTO();

            //preenchendo com valores do formulario
            objCad.TituloFilme = txtTitulo.Text;
            objCad.GeneroFilme = txtGenero.Text;
            objCad.ProdutoraFilme = txtProdutora.Text;
            objCad.DescricaoClassificacaoFilme = rbl1.SelectedValue;

            //cadastrando a imagem
            if (flUp1.HasFile)
            {
                string str = flUp1.FileName;
                flUp1.PostedFile.SaveAs(Server.MapPath("~/Imagens" + "/" + str));
                string CaminhoImg = "~/Imagens" + "/" + str.ToString();
                objCad.UrlImgFilme = CaminhoImg;

                //criando objeto cadastra
                FilmeBLL objBLL = new FilmeBLL();
                objBLL.CadastrarFilme(objCad);

                lblMensagem.Text = "Filme " + objCad.TituloFilme + " cadastrado com sucesso!!";
                Limpar();
            }
            else
            {
                lblMensagem.Text = "Ops... Deu merda ai!!";
            }
        }
    }
}