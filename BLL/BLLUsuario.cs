using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class BLLUsuario
    {
        MPPUsuario mapper;

        public BLLUsuario()
        {
            mapper = new MPPUsuario();
        }

        public bool AgregarUsuario(BEUsuario oUsuario)
        {
            return mapper.AgregarUsuario(oUsuario);
        }

        public bool ModificarUsuario(BEUsuario oUsuario)
        {
            return mapper.ModificarUsuario(oUsuario);
        }

        public bool EliminarUsuario(BEUsuario oUsuario)
        {
            return mapper.EliminarUsuario(oUsuario);
        }

        public bool VerificarUsernameExistente(BEUsuario oUsuario)
        {
            var usuarios = mapper.ListarUsuariosActivos();

            bool usernameOcupado = usuarios.Any(u =>
                u.Username.Equals(oUsuario.Username, StringComparison.OrdinalIgnoreCase)
                && u.Id != oUsuario.Id); // excluye al mismo usuario

            if (usernameOcupado)
            {
                throw new InvalidOperationException("Ya existe un usuario registrado con ese mismo nombre de usuario.");
            }

            return false;
        }

        public bool VerificarAdmin(BEUsuario oUsuario)
        {
            bool bAdmin = oUsuario.Id==1;
            if (bAdmin)
            {
                throw new InvalidOperationException("No se puede eliminar al usuario administrador del sistema.");
            }
            return false;
        }

        public bool VerificarAutoEliminacion(BEUsuario oUsuarioEliminado, BEUsuario oUsuarioLogeado)
        {
            bool bAdmin = oUsuarioEliminado.Id==oUsuarioLogeado.Id;
            if (bAdmin)
            {
                throw new InvalidOperationException("Un usuario no se puede eliminar a si mismo");
            }
            return false;
        }

        public bool VerificarUsuarioExistente(BEUsuario oUsuario)
        {
            var usuarios = mapper.ListarUsuariosActivos();

            bool existe = usuarios.Any(u =>
                u.Username.Equals(oUsuario.Username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == oUsuario.Password);
            if (!existe)
            {
                throw new InvalidOperationException("Username o Password incorrectos. Ingreselos nuevamente.");
            }
            return existe;
        }

        public BEUsuario TraerUsuario(BEUsuario oUsuario)
        {
            var usuarios = mapper.ListarUsuariosActivos();//breakpoint para ver arbol de roles y permisos

            // Busca el primer usuario con mismo username y password encriptado
            var usuarioEncontrado = usuarios.FirstOrDefault(u =>
                u.Username.Equals(oUsuario.Username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == oUsuario.Password);

            return usuarioEncontrado; 
        }

        public List<BEUsuario> ListarUsuariosActivos()
        {
            return mapper.ListarUsuariosActivos();
        }
        public List<BEUsuario> ListarUsuarios()
        {
            return mapper.ListarUsuarios();
        }
        public bool AsignarUsuarioRol(BEUsuario oUsuario, BERolArq oRolArq)
        {
            if (!mapper.AsignarUsuarioRol(oUsuario, oRolArq))
            {
                throw new InvalidOperationException("Rol ya asignado al usuario");
            }
            return true;
        }

        public bool DesasignarUsuarioRol(BEUsuario oUsuario, BERolArq oRolArq)
        {
            return mapper.DesasignarUsuarioRol(oUsuario, oRolArq);
        }

        public bool AsignarUsuarioPermiso(BEUsuario oUsuario, BEPermiso oPermiso)
        {
            if (!mapper.AsignarUsuarioPermiso(oUsuario, oPermiso))
            {
                throw new InvalidOperationException("Permiso directo ya asignado al usuario");
            }
            return true;
        }

        public bool DesasignarUsuarioPermiso(BEUsuario oUsuario, BEPermiso oPermiso)
        {
            return mapper.DesasignarUsuarioPermiso(oUsuario, oPermiso);
        }
    }
}
