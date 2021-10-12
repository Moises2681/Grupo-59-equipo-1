using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia
{
    public interface IRepositorioAlquiler
    {
        // Alquiler
        Alquiler AddAlquiler(Alquiler alquiler);
        IEnumerable<Alquiler> GetAllAlquileres();
        Alquiler GetAlquiler(int idAlquiler);
        Alquiler UpdateAlquiler(Alquiler alquiler);
        void DeleteAlquiler(int idAlquiler);   
        
     
    }
}