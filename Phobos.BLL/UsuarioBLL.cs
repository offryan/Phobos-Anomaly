using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phobos.DAL;
using Phobos.DTO;

namespace Phobos.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL objBLL = new UsuarioDAL();

        //cadastrar
        public void CadastrarUsuario(UsuarioDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Excluir
        public void ExcluirUsuario(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Editar
        public void EditarUsuario(UsuarioDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Buscar
        public UsuarioDTO BuscarUsuario(int objModelo)
        {
            return objBLL.Buscar(objModelo);
        }

        //Listar
        public List<UsuarioDTO> ListarUsuario()
        {
            return objBLL.Listar();
        }

        //Autenticar
        public UsuarioDTO AutenticaUser(string objUser, string objSenha)
        {

            UsuarioDTO user = objBLL.Autentica(objUser, objSenha);

            if (user!=null)
            {
                return user;
            }
            else
            {
                throw new Exception("Deu problema!!");
            }

            

        }
    }
}
