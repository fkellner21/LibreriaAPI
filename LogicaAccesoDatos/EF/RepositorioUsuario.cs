using LogicaAccesoDatos.Excepciones;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.EF
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private LibreriaContext _context;
        public RepositorioUsuario(LibreriaContext libreriaContext)
        {
            _context = libreriaContext;
        }


        public Usuario GetById(int id)
        {
            if (id == null || id < 0)
            {
                throw new ArgumentNullRepositorioException();
            }
            Usuario? resultado = _context.Usuarios.FirstOrDefault(usu => usu.Id == id);
            if (resultado == null)
            {
                throw new NotFoundException();
            }
            return resultado;
        }

        public Usuario? Login(string email, string password)
        {
            Usuario resultado = _context.Usuarios.FirstOrDefault(usu => usu.Email == email && usu.PasswordHash == password);
            if(resultado != null)
            {
                return resultado;
            }
            else
            {
                throw new LoginException();
            }
        }

        public Usuario GetByEmail(string email)
        {
            Usuario resultado = _context.Usuarios.FirstOrDefault(usu => usu.Email == email);
            if (resultado != null)
            {
                return resultado;
            }
            throw new NotFoundException();
        }
    }
}
