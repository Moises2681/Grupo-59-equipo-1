using System;
using System.Collections.Generic;
using System.Linq;
using RentaAutos.App.Dominio;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public interface IRepositorioUsuario
    {
           // Usuario
        Usuario AddUsuario(Usuario usuario);
        IEnumerable<Usuario> GetAllUsuarios();
        Usuario GetUsuario(int idUsuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);
    }
}