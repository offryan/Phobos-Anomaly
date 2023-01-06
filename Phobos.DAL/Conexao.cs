using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // adicionando os recursos

namespace Phobos.DAL
{
    public class Conexao
    {
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        protected void Conectar()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocaldb;Initial Catalog=PhobosAnomaly;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
 
        }

        protected void Desconectar()
        {
            try
            {
               
                conn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


    }
}
