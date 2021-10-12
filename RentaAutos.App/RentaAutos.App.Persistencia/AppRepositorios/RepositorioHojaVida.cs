using System.Collections.Generic;
using System.Linq;

using RentaAutos.App.Dominio;
using RentaAutos.App.Persistencia;

namespace RentaAutos.App.Persistencia
{
    public class RepositorioHojaVida : IRepositorioHojaVida
    {
        private readonly AppContext _appContext;

        public RepositorioHojaVida(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD de entidad EstadoEntrega
        HojaVida IRepositorioHojaVida.AddHojaVida(HojaVida HojaVida)
        {
            var HojaVidaAdicionado = _appContext.HojaVidas.Add(HojaVida);

            _appContext.SaveChanges();
            
            return HojaVidaAdicionado.Entity;
        }

        HojaVida IRepositorioHojaVida.UpdateHojaVida(HojaVida hojaVida)
        {
            var HojaVidaEncontrado = _appContext.HojaVidas.FirstOrDefault(p => p.id == hojaVida.id);
            if(HojaVidaEncontrado != null)
            {
                HojaVidaEncontrado.codigo = hojaVida.codigo;
                HojaVidaEncontrado.fechaTecnomecanica = hojaVida.fechaTecnomecanica;
                HojaVidaEncontrado.fechaSoat = hojaVida.fechaSoat;
                                
                _appContext.SaveChanges();
            }
            return HojaVidaEncontrado;
        }
        void IRepositorioHojaVida.DeleteHojaVida(int idHojaVida)
        {
            var HojaVidaEncontrado = _appContext.HojaVidas.FirstOrDefault(p => p.id == idHojaVida);
            if(HojaVidaEncontrado == null)
            return;
            _appContext.HojaVidas.Remove(HojaVidaEncontrado);
            _appContext.SaveChanges();
        }
        HojaVida IRepositorioHojaVida.GetHojaVida(int idHojaVida)
        {
            return _appContext.HojaVidas.FirstOrDefault(p => p.id == idHojaVida);
        }
        IEnumerable<HojaVida> IRepositorioHojaVida.GetAllHojaVidas()
        {
            return _appContext.HojaVidas;
        }     
    }
}