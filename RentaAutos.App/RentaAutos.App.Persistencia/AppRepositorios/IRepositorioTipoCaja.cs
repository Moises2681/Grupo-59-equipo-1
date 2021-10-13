using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioTipoCaja
    {
          // Tipo Caja
        TipoCaja AddTipoCaja(TipoCaja tipoCaja);
        IEnumerable<TipoCaja> GetAllTipoCajas();
        TipoCaja GetTipoCaja(int idTipoCaja);
        TipoCaja UpdateTipoCaja(TipoCaja tipoCaja);
        void DeleteTipoCaja(int idTipoCaja);
    }
}