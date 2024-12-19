using Azure;
using LogicaAccesoDatos.Excepciones;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.InterfacesRepositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAccesoDatos.EF
{
    public class RepositorioMovimientoDeStock : IRepositorioMovimientoDeStock
    {
        private LibreriaContext _context;
        public RepositorioMovimientoDeStock(LibreriaContext context)
        {
            _context = context;
        }
        public void Add(MovimientoDeStock obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullRepositorioException();
            }
            obj.Validar();
            obj.Id = 0;
            _context.MovimientosDeStock.Add(obj);
            _context.SaveChanges();
        }

        public IEnumerable<MovimientoDeStock> GetAll(int page=0)
        {
            IEnumerable<MovimientoDeStock> respuesta = _context.MovimientosDeStock.
                                                        Include(m => m.ejecutor).Include(m => m.tipo).
                                                        Include(m => m.articulo).
                                                        Skip(page * ParametrosGenerales.pageSize).
                                                        Take(ParametrosGenerales.pageSize).
                                                        ToList();
            if (respuesta.Count() == 0)
            {
                throw new NotFoundException();
            }
            return respuesta;
        }
        public int GetCount()
        {
            return _context.MovimientosDeStock.AsEnumerable().ToList().Count();
        }
        public int GetCountFiltro(int idArticulo, int idTipo)
        {
            return _context.MovimientosDeStock.
                    Where(m => m.articulo.Id == idArticulo && m.tipo.Id == idTipo).AsEnumerable().ToList().Count();
        }
        public int GetCountPorFecha(DateTime desde, DateTime hasta)
        {
            return _context.MovimientosDeStock.
                    Where(m => m.fecha >= desde && m.fecha <= hasta).Select(m => m.articulo).
                    Distinct().ToList().Count();
        }
        public IEnumerable<MovimientoDeStock> GetAllXArtTipoPagl(int idArticulo, int idTipo, int page=0)
        {
            if (idArticulo == null || idArticulo < 0)
            {
                throw new ArgumentNullRepositorioException();
            }
            Articulo? resultado = _context.Articulos.FirstOrDefault(art => art.Id == idArticulo);
            if (resultado == null)
            {
                throw new NotFoundException();
            }
            if (idTipo == null || idTipo < 0)
            {
                throw new ArgumentNullRepositorioException();
            }
            TipoDeMovimiento? tipo = _context.TiposDeMovimiento.FirstOrDefault(t => t.Id == idTipo);
            if (tipo == null)
            {
                throw new NotFoundException();
            }
            return _context.MovimientosDeStock.
                    Where(m=>m.articulo.Id == idArticulo && m.tipo.Id==idTipo).
                    Include(m=>m.ejecutor).Include(m=>m.tipo).Include(m=>m.articulo).
                    OrderByDescending(m=>m.fecha).ThenBy(m=>m.cantidad).
                    Skip(page * ParametrosGenerales.pageSize).
                    Take(ParametrosGenerales.pageSize).
                    ToList();
        }

        public MovimientoDeStock GetById(int id)
        {
            if (id == null || id < 0)
            {
                throw new ArgumentNullRepositorioException();
            }
            MovimientoDeStock? resultado = _context.MovimientosDeStock.Include(m => m.ejecutor)
                                                                      .Include(m => m.tipo).Include(m => m.articulo)
                                                                      .FirstOrDefault(m => m.Id == id);
            if (resultado == null)
            {
                throw new NotFoundException();
            }
            return resultado;
        }

        public IEnumerable<Articulo> GetPorFecha(DateTime desde, DateTime hasta, int page)
        {
            if(desde==null||hasta==null)
            {
                throw new ArgumentNullRepositorioException();
            }
            IEnumerable<Articulo> res = _context.MovimientosDeStock.
                    Where(m=>m.fecha>=desde && m.fecha<=hasta).
                    Select(m=>m.articulo).
                    Distinct().
                    Skip(page * ParametrosGenerales.pageSize).
                    Take(ParametrosGenerales.pageSize).
                    ToList();
            if(res == null)
            {
                throw new NotFoundException();
            }
            return res;
        }

        public IEnumerable<Resultado> ResumenPorAnio()
        {
            var resumen = _context.MovimientosDeStock
                .GroupBy(m=> new {Anio = m.fecha.Year, Movimiento = m.tipo.Nombre },
                (key, group) => new
                {
                    key.Anio,
                    key.Movimiento,
                    Total = group.Sum(m=>m.cantidad)
                }).OrderBy(r=>r.Anio)
                .ThenBy(r=>r.Movimiento)
                .ToList();
            var totalesAnuales = resumen
                .GroupBy(resumen=> resumen.Anio)
                .Select(g=> new
                {
                    Anio = g.Key,
                    Movimientos = g.Select(m=> new {Tipo = m.Movimiento, Cantidad = m.Total }),
                    CantidadAnual = g.Sum(r=>r.Total)
                }).ToList();

            var res = new List<Resultado>();
            foreach (var item in totalesAnuales)
            {
                var unResumen = new Resultado
                {
                    Anio = item.Anio,
                    CantidadAnual = item.CantidadAnual,
                    resultadoAnual = new List<ResultadoAnual>()
                };
                foreach(var tipo in item.Movimientos)
                {
                    unResumen.resultadoAnual.Add(new ResultadoAnual
                    {
                        Movimiento = tipo.Tipo,
                        Cantidad = tipo.Cantidad
                    });
                }
                res.Add(unResumen);
            }
            return res;
        }
    }
}
