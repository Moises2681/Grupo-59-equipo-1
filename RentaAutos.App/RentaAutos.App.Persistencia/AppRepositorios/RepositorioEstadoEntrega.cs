using System.Collections.Generic;
using System.Linq;

using RentaAutos.App.Dominio;
using RentaAutos.App.Persistencia;

namespace RentaAutos.App.Persistencia
{
    public class RepositorioEstadoEntrega : IRepositorioEstadoEntrega
    {
        private readonly AppContext _appContext;

        public RepositorioEstadoEntrega(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD de entidad EstadoEntrega
        EstadoEntrega IRepositorioEstadoEntrega.AddEstadoEntrega(EstadoEntrega EstadoEntrega)
        {
            var EstadoEntregaAdicionado = _appContext.EstadoEntregas.Add(EstadoEntrega);
            _appContext.SaveChanges();
            return EstadoEntregaAdicionado.Entity;
        }

        EstadoEntrega IRepositorioEstadoEntrega.UpdateEstadoEntrega(EstadoEntrega estadoEntrega)
        {
            var EstadoEntregaEncontrado = _appContext.EstadoEntregas.FirstOrDefault(p => p.id == estadoEntrega.id);
            if(EstadoEntregaEncontrado != null)
            {
                EstadoEntregaEncontrado.estadoEntrega = estadoEntrega.estadoEntrega;
                                
                _appContext.SaveChanges();
            }
            return EstadoEntregaEncontrado;
        }
        void IRepositorioEstadoEntrega.DeleteEstadoEntrega(int idEstadoEntrega)
        {
            var EstadoEntregaEncontrado = _appContext.EstadoEntregas.FirstOrDefault(p => p.id == idEstadoEntrega);
            if(EstadoEntregaEncontrado == null)
            return;
            _appContext.EstadoEntregas.Remove(EstadoEntregaEncontrado);
            _appContext.SaveChanges();
        }
        EstadoEntrega IRepositorioEstadoEntrega.GetEstadoEntrega(int idEstadoEntrega)
        {
            return _appContext.EstadoEntregas.FirstOrDefault(p => p.id == idEstadoEntrega);
        }
        IEnumerable<EstadoEntrega> IRepositorioEstadoEntrega.GetAllEstadoEntregas()
        {
            return _appContext.EstadoEntregas;
        }     
    }
}