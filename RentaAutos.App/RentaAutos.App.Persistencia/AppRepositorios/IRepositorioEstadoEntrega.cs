using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia
{
    public interface IRepositorioEstadoEntrega
    {
         //Estado Entrega
        EstadoEntrega AddEstadoEntrega(EstadoEntrega estadoEntrega);
        IEnumerable<EstadoEntrega> GetAllEstadoEntregas();
        EstadoEntrega GetEstadoEntrega(int idEstadoEntrega);
        EstadoEntrega UpdateEstadoEntrega(EstadoEntrega estadoEntrega);
        void DeleteEstadoEntrega(int idEstadoEntrega);  
    }
}