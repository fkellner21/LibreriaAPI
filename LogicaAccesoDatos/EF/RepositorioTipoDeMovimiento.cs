using LogicaAccesoDatos.Excepciones;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.InterfacesRepositorio;


namespace LogicaAccesoDatos.EF
{
    public class RepositorioTipoDeMovimiento : IRepositorioTipoDeMovimiento
    {
        private LibreriaContext _context;
        public RepositorioTipoDeMovimiento(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(TipoDeMovimiento obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullRepositorioException();
            }
            obj.Validar();
            obj.Id = 0;
            _context.TiposDeMovimiento.Add(obj);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            MovimientoDeStock? muv = _context.MovimientosDeStock.FirstOrDefault(m => m.tipo.Id == id);
            if (muv == null)
            {
                TipoDeMovimiento tipo = GetById(id);
                _context.TiposDeMovimiento.Remove(tipo);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullRepositorioException();
            }
        }

        public IEnumerable<TipoDeMovimiento> GetAll()
        {
            IEnumerable<TipoDeMovimiento> respuesta = _context.TiposDeMovimiento.ToList();
            if (respuesta.Count() == 0)
            {
                throw new NotFoundException();
            }
            return respuesta;
        }

        public TipoDeMovimiento GetById(int id)
        {
            if (id == null || id < 0)
            {
                throw new ArgumentNullRepositorioException();
            }
            TipoDeMovimiento? resultado = _context.TiposDeMovimiento.FirstOrDefault(t => t.Id == id);
            if (resultado == null)
            {
                throw new NotFoundException();
            }
            return resultado;
        }

        public void Update(int id, TipoDeMovimiento obj)
        {
            MovimientoDeStock? muv = _context.MovimientosDeStock.FirstOrDefault(m => m.tipo.Id == id);
            if (muv == null)
            {
                TipoDeMovimiento t = GetById(id);
            t.Update(obj);
            _context.TiposDeMovimiento.Update(t);
            _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullRepositorioException();
            }
        }
    }
}
