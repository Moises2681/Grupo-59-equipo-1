using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia
{
    public interface IRepositorioFormaPago
    {
         //Estado Entrega
        FormaPago AddFormaPago(FormaPago formaPago);
        IEnumerable<FormaPago> GetAllFormaPagos();
        FormaPago GetFormaPago(int idFormaPago);
        FormaPago UpdateFormaPago(FormaPago formaPago);
        void DeleteFormaPago(int idFormaPago);  
    }
}