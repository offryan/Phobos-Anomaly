using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phobos.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string CpfUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string DataNascUsuario { get; set; }
        public string DescricaoTipoUsuario { get; set; }
    }
}
