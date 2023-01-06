using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Phobos.BLL;

namespace Phobos.UI.Pages
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioBLL objModelo = new UsuarioBLL();
            dgv1.DataSource = objModelo.ListarUsuario(); //popular o objeto
            dgv1.DataBind(); //imprimir na tela
        }
    }
}