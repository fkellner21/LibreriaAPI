using LogicaDeNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio.InterfacesRepositorio
{
    public interface IRepositorioUsuario 
    {
        public Usuario Login(string email, string password); 
        public Usuario GetByEmail(string email);
        public Usuario GetById(int id);
    }
}
