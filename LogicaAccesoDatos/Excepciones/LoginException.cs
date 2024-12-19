using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Excepciones
{
    public class LoginException:RepositorioException
    {
        public LoginException():base("Usuario o contraseña incorrecto.") { }
    }
}
