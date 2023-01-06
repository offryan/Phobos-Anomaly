using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Phobos.DTO;

namespace Phobos.DAL
{
    public class FilmeDAL:Conexao
    {
        //Cadastrar
        public void Cadastrar(FilmeDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Filme (TituloFilme,GeneroFilme,ProdutoraFilme,UrlImgFilme,ClassificacaoFilme) VALUES (@v1,@v2,@v3,@v4,@v5)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.TituloFilme);
                cmd.Parameters.AddWithValue("@v2", objCad.GeneroFilme);
                cmd.Parameters.AddWithValue("@v3", objCad.ProdutoraFilme);
                cmd.Parameters.AddWithValue("@v4", objCad.UrlImgFilme);
                cmd.Parameters.AddWithValue("@v5", objCad.DescricaoClassificacaoFilme);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Listar
        public List<FilmeDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdFilme,TituloFilme,GeneroFilme,ProdutoraFilme,UrlImgFilme,DescricaoClassificacao FROM Filme JOIN Classificacao ON ClassificacaoFilme=IdClassificacao", conn);
                dr = cmd.ExecuteReader();
                List<FilmeDTO> Lista = new List<FilmeDTO>(); //criando a lista vazia

                while (dr.Read())  //estrutura de repetição
                {
                    FilmeDTO obj = new FilmeDTO();
                    obj.IdFilme = Convert.ToInt32(dr["IdFilme"]);
                    obj.TituloFilme = Convert.ToString(dr["TituloFilme"]);
                    obj.GeneroFilme = Convert.ToString(dr["GeneroFilme"]);
                    obj.ProdutoraFilme = Convert.ToString(dr["ProdutoraFilme"]);
                    obj.UrlImgFilme = Convert.ToString(dr["UrlImgFilme"]);
                    obj.DescricaoClassificacaoFilme = Convert.ToString(dr["DescricaoClassificacao"]);

                    Lista.Add(obj);

                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }



        }

        //Editar
        public void Editar(FilmeDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Filme SET TituloFilme=@v1,GeneroFilme=@v2,ProdutoraFilme=@v3,UrlImgFilme=@v4,ClassificacaoFilme=@v5 WHERE IdFilme=@v6", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.TituloFilme);
                cmd.Parameters.AddWithValue("@v2", objEdita.GeneroFilme);
                cmd.Parameters.AddWithValue("@v3", objEdita.ProdutoraFilme);
                cmd.Parameters.AddWithValue("@v4", objEdita.UrlImgFilme);
                cmd.Parameters.AddWithValue("@v5", objEdita.DescricaoClassificacaoFilme);
                cmd.Parameters.AddWithValue("@v6", objEdita.IdFilme);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao editar o registro!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        //Excluir
        public void Excluir(int objExclui)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Filme WHERE IdFilme=@v6", conn);
                cmd.Parameters.AddWithValue("@v6", objExclui);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir o registro!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Selecionar
        public FilmeDTO Buscar(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdFilme,TituloFilme,GeneroFilme,ProdutoraFilme,UrlImgFilme,DescricaoClassificacao FROM Filme JOIN Classificacao ON ClassificacaoFilme=IdClassificacao WHERE IdFilme=@v6", conn);
                cmd.Parameters.AddWithValue("@v6", objSeleciona);
                dr = cmd.ExecuteReader();

                FilmeDTO obj = null;//ponteiro
                if (dr.Read())
                {
                    obj = new FilmeDTO();
                    obj.IdFilme = Convert.ToInt32(dr["IdFilme"]);
                    obj.TituloFilme = Convert.ToString(dr["TituloFilme"]);
                    obj.GeneroFilme = Convert.ToString(dr["GeneroFilme"]);
                    obj.ProdutoraFilme = Convert.ToString(dr["ProdutoraFilme"]);
                    obj.UrlImgFilme = Convert.ToString(dr["UrlImgFilme"]);
                    obj.DescricaoClassificacaoFilme= Convert.ToString(dr["DescricaoClassificacao"]);
                }
                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao buscar o registro!! " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }


    }
}
