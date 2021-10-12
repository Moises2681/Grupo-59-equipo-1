using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMarca
    {
          // Marca
        Marca AddMarca(Marca marca);
        IEnumerable<Marca> GetAllMarcas();
        Marca GetMarca(int idMarca);
        Marca UpdateMarca(Marca marca);
        void DeleteMarca(int idMarca); 
    }
}