using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia
{
    public interface IRepositorioEstadoAlquiler
    {
         //Estado Alquiler
        EstadoAlquiler AddEstadoAlquiler(EstadoAlquiler estadoAlquiler);
        IEnumerable<EstadoAlquiler> GetAllEstadoAlquileres();
        EstadoAlquiler GetEstadoAlquiler(int idEstadoAlquiler);
        EstadoAlquiler UpdateEstadoAlquiler(EstadoAlquiler estadoAlquiler);
        void DeleteEstadoAlquiler(int idEstadoAlquiler);   
    }
}