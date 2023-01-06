using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.BLL;
using Phobos.DTO;

namespace Phobos.UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //pegando informação digitada pelo usuario
                string objUser = txtUsuario.Text;
                string objSenha = txtSenha.Text;

                //instanciando objeto DTO
                UsuarioDTO objModelo = new UsuarioDTO();
                UsuarioBLL objValida = new UsuarioBLL();
                objModelo = objValida.AutenticaUser(objUser, objSenha);
                if (objModelo != null)
                {
                    switch (objModelo.DescricaoTipoUsuario)
                    {
                        case "1":
                            Session["Usuario"] = txtUsuario.Text.Trim();
                            Response.Redirect("/Pages/IndexAdm.aspx");
                            break;
                        case "2":
                            Session["Usuario"] = txtUsuario.Text.Trim();
                            Response.Redirect("/Pages/IndexUser.aspx");
                            break;
                    }

                }
                else
                {
                    lblMensagem.Text = "Deu Problema denovo!!";
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Usuario não cadastrado!! " + ex.Message;
            }
           
        }
    }
}