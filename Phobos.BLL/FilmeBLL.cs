using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phobos.DAL;
using Phobos.DTO;

namespace Phobos.BLL
{
    public class FilmeBLL
    {
        FilmeDAL objBLL = new FilmeDAL();

        //cadastrar
        public void CadastrarFilme(FilmeDTO objModelo)
        {
            objBLL.Cadastrar(objModelo);
        }

        //Excluir
        public void ExcluirFilme(int objModelo)
        {
            objBLL.Excluir(objModelo);
        }

        //Editar
        public void EditarFilme(FilmeDTO objModelo)
        {
            objBLL.Editar(objModelo);
        }

        //Buscar
        public FilmeDTO BuscarFilme(int objModelo)
        {
            return objBLL.Buscar(objModelo);
        }

        //Listar
        public List<FilmeDTO> ListarFilme()
        {
            return objBLL.Listar();
        }

        



        
    }
}
