using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio.Entidades;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioEstadoAlquiler : IRepositorioEstadoAlquiler
    {
        private readonly AppContext _appContext;

        public RepositorioEstadoAlquiler(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD de entidad EstadoAlquiler
        EstadoAlquiler IRepositorioEstadoAlquiler.AddEstadoAlquiler(EstadoAlquiler EstadoAlquiler)
        {
            var EstadoAlquilerAdicionado = _appContext.EstadoAlquileres.Add(EstadoAlquiler);
            _appContext.SaveChanges();
            return EstadoAlquilerAdicionado.Entity;
        }

        EstadoAlquiler IRepositorioEstadoAlquiler.UpdateEstadoAlquiler(EstadoAlquiler estadoAlquiler)
        {
            var EstadoAlquilerEncontrado = _appContext.EstadoAlquileres.FirstOrDefault(p => p.id == estadoAlquiler.id);
            if(EstadoAlquilerEncontrado != null)
            {
                EstadoAlquilerEncontrado.estadoAlquiler = estadoAlquiler.estadoAlquiler;
                                
                _appContext.SaveChanges();
            }
            return EstadoAlquilerEncontrado;
        }
        void IRepositorioEstadoAlquiler.DeleteEstadoAlquiler(int idEstadoAlquiler)
        {
            var EstadoAlquilerEncontrado = _appContext.EstadoAlquileres.FirstOrDefault(p => p.id == idEstadoAlquiler);
            if(EstadoAlquilerEncontrado == null)
            return;
            _appContext.EstadoAlquileres.Remove(EstadoAlquilerEncontrado);
            _appContext.SaveChanges();
        }
        EstadoAlquiler IRepositorioEstadoAlquiler.GetEstadoAlquiler(int idEstadoAlquiler)
        {
            return _appContext.EstadoAlquileres.FirstOrDefault(p => p.id == idEstadoAlquiler);
        }
        IEnumerable<EstadoAlquiler> IRepositorioEstadoAlquiler.GetAllEstadoAlquileres()
        {
            return _appContext.EstadoAlquileres;
        }
    }
}