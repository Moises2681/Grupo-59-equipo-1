using System.Collections.Generic;
using System.Linq;

using RentaAutos.App.Dominio;
using RentaAutos.App.Persistencia;

namespace RentaAutos.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext;

        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }
        //CRUD usuario
        Usuario IRepositorioUsuario.AddUsuario(Usuario Usuario)
        {
            var UsuarioAdicionado = _appContext.Usuarios.Add(Usuario);

            _appContext.SaveChanges();
            
            return UsuarioAdicionado.Entity;
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var UsuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.id == usuario.id);
            if(UsuarioEncontrado != null)
            {
                UsuarioEncontrado.cedula = usuario.cedula;
                UsuarioEncontrado.nombre = usuario.nombre;
                UsuarioEncontrado.apellido = usuario.apellido;
                UsuarioEncontrado.direccion = usuario.direccion;
                UsuarioEncontrado.telefono = usuario.telefono;
                UsuarioEncontrado.correo = usuario.correo;
                                
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }
        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var UsuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.id == idUsuario);
            if(UsuarioEncontrado == null)
            return;
            _appContext.Usuarios.Remove(UsuarioEncontrado);
            _appContext.SaveChanges();
        }
        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.FirstOrDefault(p => p.id == idUsuario);
        }
        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios()
        {
            return _appContext.Usuarios;
        }  
    }
}