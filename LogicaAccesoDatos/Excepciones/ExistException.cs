using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.Excepciones
{
    public class ExistException:RepositorioException
    {
        public ExistException() : base("Identificador existente en el sistema.") { }
    }
}
