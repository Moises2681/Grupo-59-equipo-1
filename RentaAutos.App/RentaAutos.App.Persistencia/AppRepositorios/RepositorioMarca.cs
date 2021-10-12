using System.Collections.Generic;
using System.Linq;

using RentaAutos.App.Dominio;
using RentaAutos.App.Persistencia;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioMarca : IRepositorioMarca
    {
        private readonly AppContext _appContext;

        public RepositorioMarca(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD Marca
        Marca IRepositorioMarca.AddMarca(Marca Marca)
        {
            var MarcaAdicionado = _appContext.Marcas.Add(Marca);

            _appContext.SaveChanges();
            
            return MarcaAdicionado.Entity;
        }

        Marca IRepositorioMarca.UpdateMarca(Marca marca)
        {
            var MarcaEncontrado = _appContext.Marcas.FirstOrDefault(p => p.id == marca.id);
            if(MarcaEncontrado != null)
            {
                MarcaEncontrado.marca = marca.marca;
                                
                _appContext.SaveChanges();
            }
            return MarcaEncontrado;
        }
        void IRepositorioMarca.DeleteMarca(int idMarca)
        {
            var MarcaEncontrado = _appContext.Marcas.FirstOrDefault(p => p.id == idMarca);
            if(MarcaEncontrado == null)
            return;
            _appContext.Marcas.Remove(MarcaEncontrado);
            _appContext.SaveChanges();
        }
        Marca IRepositorioMarca.GetMarca(int idMarca)
        {
            return _appContext.Marcas.FirstOrDefault(p => p.id == idMarca);
        }
        IEnumerable<Marca> IRepositorioMarca.GetAllMarcas()
        {
            return _appContext.Marcas;
        }     
    }
}