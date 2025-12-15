using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEUsuario
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int Activo { get; set; }
        public List<BERolArq> Roles { get; set; }
        public List<BEPermiso> PermisosDirectos { get; set; }

        public override string ToString()
        {
            return $"{Username}";
        }
    }

}
