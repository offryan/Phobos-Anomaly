using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Phobos.DTO;


namespace Phobos.DAL
{
    public class UsuarioDAL:Conexao
    {
        //Inserir (cadastrar)
        public void Cadastrar(UsuarioDTO objCad)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Usuario (NomeUsuario,CpfUsuario,SenhaUsuario,DataNascUsuario,TipoUsuario) VALUES (@v1,@v2,@v3,@v4,@v5)", conn);
                cmd.Parameters.AddWithValue("@v1", objCad.NomeUsuario);
                cmd.Parameters.AddWithValue("@v2", objCad.CpfUsuario);
                cmd.Parameters.AddWithValue("@v3", objCad.SenhaUsuario);
                cmd.Parameters.AddWithValue("@v4", objCad.DataNascUsuario);
                cmd.Parameters.AddWithValue("@v5", objCad.DescricaoTipoUsuario);
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
        public List<UsuarioDTO> Listar()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario, NomeUsuario, CpfUsuario, SenhaUsuario, DataNascUsuario, DescricaoTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario=IdTipoUsuario", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>(); //criando a lista vazia

                while (dr.Read())  //estrutura de repetição
                {
                    UsuarioDTO obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NomeUsuario = Convert.ToString(dr["NomeUsuario"]);
                    obj.CpfUsuario = Convert.ToString(dr["CpfUsuario"]);
                    obj.SenhaUsuario = Convert.ToString(dr["SenhaUsuario"]);
                    obj.DataNascUsuario = Convert.ToString(dr["DataNascUsuario"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["DescricaoTipoUsuario"]);

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
        public void Editar(UsuarioDTO objEdita)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Usuario SET NomeUsuario=@v1,CpfUsuario=@v2,SenhaUsuario=@v3,DataNascUsuario=@v4,TipoUsuario=@v5 WHERE IdUsuario=@v6", conn);
                cmd.Parameters.AddWithValue("@v1", objEdita.NomeUsuario);
                cmd.Parameters.AddWithValue("@v2", objEdita.CpfUsuario);
                cmd.Parameters.AddWithValue("@v3", objEdita.SenhaUsuario);
                cmd.Parameters.AddWithValue("@v4", objEdita.DataNascUsuario);
                cmd.Parameters.AddWithValue("@v5", objEdita.DescricaoTipoUsuario);
                cmd.Parameters.AddWithValue("@v6", objEdita.IdUsuario);
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
                cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@v6", conn);
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
        public UsuarioDTO Buscar(int objSeleciona)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdUsuario, NomeUsuario, CpfUsuario, SenhaUsuario, DataNascUsuario, DescricaoTipoUsuario FROM Usuario JOIN TipoUsuario ON TipoUsuario = IdTipoUsuario WHERE IdUsuario = @v6", conn);
                cmd.Parameters.AddWithValue("@v6", objSeleciona);
                dr = cmd.ExecuteReader();

                UsuarioDTO obj = null;//ponteiro
                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NomeUsuario = Convert.ToString(dr["NomeUsuario"]);
                    obj.CpfUsuario = Convert.ToString(dr["CpfUsuario"]);
                    obj.SenhaUsuario = Convert.ToString(dr["SenhaUsuario"]);
                    obj.DataNascUsuario = Convert.ToString(dr["DataNascUsuario"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["DescricaoTipoUsuario"]);
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

        //Autenticar
        public UsuarioDTO Autentica(string objUser, string objSenha)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Usuario WHERE NomeUsuario=@v1 AND SenhaUsuario=@v2", conn);
                cmd.Parameters.AddWithValue("@v1", objUser);
                cmd.Parameters.AddWithValue("@v2", objSenha);
                dr = cmd.ExecuteReader();

                UsuarioDTO obj = null;//ponteiro

                if (dr.Read())
                {
                    obj = new UsuarioDTO();
                    obj.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    obj.NomeUsuario = Convert.ToString(dr["NomeUsuario"]);
                    obj.CpfUsuario = Convert.ToString(dr["CpfUsuario"]);
                    obj.SenhaUsuario = Convert.ToString(dr["SenhaUsuario"]);
                    obj.DataNascUsuario = Convert.ToString(dr["DataNascUsuario"]);
                    obj.DescricaoTipoUsuario = Convert.ToString(dr["TipoUsuario"]);
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

