using System.Collections.Generic;
using System.Linq;

using RentaAutos.App.Dominio;
using RentaAutos.App.Persistencia;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioTipoCaja : IRepositorioTipoCaja
    {
        private readonly AppContext _appContext;

        public RepositorioTipoCaja(AppContext appContext)
        {
            _appContext = appContext;
        }
            //CRUD Tipo Caja
        TipoCaja IRepositorioTipoCaja.AddTipoCaja(TipoCaja TipoCaja)
        {
            var TipoCajaAdicionado = _appContext.TipoCajas.Add(TipoCaja);

            _appContext.SaveChanges();
            
            return TipoCajaAdicionado.Entity;
        }

        TipoCaja IRepositorioTipoCaja.UpdateTipoCaja(TipoCaja tipoCaja)
        {
            var TipoCajaEncontrado = _appContext.TipoCajas.FirstOrDefault(p => p.id == tipoCaja.id);
            if(TipoCajaEncontrado != null)
            {
                TipoCajaEncontrado.marca = tipoCaja.marca;
                                
                _appContext.SaveChanges();
            }
            return TipoCajaEncontrado;
        }
        void IRepositorioTipoCaja.DeleteTipoCaja(int idTipoCaja)
        {
            var TipoCajaEncontrado = _appContext.TipoCajas.FirstOrDefault(p => p.id == idTipoCaja);
            if(TipoCajaEncontrado == null)
            return;
            _appContext.TipoCajas.Remove(TipoCajaEncontrado);
            _appContext.SaveChanges();
        }
        TipoCaja IRepositorioTipoCaja.GetTipoCaja(int idTipoCaja)
        {
            return _appContext.TipoCajas.FirstOrDefault(p => p.id == idTipoCaja);
        }
        IEnumerable<TipoCaja> IRepositorioTipoCaja.GetAllTipoCajas()
        {
            return _appContext.TipoCajas;
        }  
    }
}