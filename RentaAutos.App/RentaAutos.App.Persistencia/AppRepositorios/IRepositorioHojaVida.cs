using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia
{
    public interface IRepositorioHojaVida
    {
         // Hoja de vida
        HojaVida AddHojaVida(HojaVida hojaVida);
        IEnumerable<HojaVida> GetAllHojaVidas();
        HojaVida GetHojaVida(int idHojaVida);
        HojaVida UpdateHojaVida(HojaVida hojaVida);
        void DeleteHojaVida(int idHojaVida); 
    }
}