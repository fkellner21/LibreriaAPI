using LogicaAccesoDatos.Excepciones;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.InterfacesRepositorio;


namespace LogicaAccesoDatos.EF
{
    public class RepositorioArticulo : IRepositorioArticulo
    {
        private LibreriaContext _context;
        public RepositorioArticulo(LibreriaContext context)
        {
            _context = context;
        }

        public IEnumerable<Articulo> GetAll()
        {
            IEnumerable<Articulo> respuesta = _context.Articulos
                                              .OrderBy(articulo=>articulo.Nombre)
                                              .ToList();
            if (respuesta.Count() == 0)
            {
                throw new NotFoundException();
            }
            return respuesta;
        }

        public Articulo GetById(int id)
        {
            if (id == null || id < 0)
            {
                throw new ArgumentNullRepositorioException();
            }
            Articulo? resultado = _context.Articulos.FirstOrDefault(art => art.Id == id);
            if (resultado == null)
            {
                throw new NotFoundException();
            }
            return resultado;
        }
    }
}
