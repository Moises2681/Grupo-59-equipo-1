using System.Collections.Generic;
using System.Linq;

using RentaAutos.App.Dominio;
using RentaAutos.App.Persistencia;

namespace RentaAutos.App.Persistencia
{
    public class RepositorioFormaPago : IRepositorioFormaPago
    {
        private readonly AppContext _appContext;

        public RepositorioFormaPago(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD de entidad EstadoEntrega
        FormaPago IRepositorioFormaPago.AddFormaPago(FormaPago FormaPago)
        {
            var FormaPagoAdicionado = _appContext.FormaPagos.Add(FormaPago);
            _appContext.SaveChanges();
            
            return FormaPagoAdicionado.Entity;
        }

        FormaPago IRepositorioFormaPago.UpdateFormaPago(FormaPago formaPago)
        {
            var FormaPagoEncontrado = _appContext.FormaPagos.FirstOrDefault(p => p.id == formaPago.id);
            if(FormaPagoEncontrado != null)
            {
                FormaPagoEncontrado.nombre = formaPago.nombre;
                                
                _appContext.SaveChanges();
            }
            return FormaPagoEncontrado;
        }
        void IRepositorioFormaPago.DeleteFormaPago(int idFormaPago)
        {
            var FormaPagoEncontrado = _appContext.FormaPagos.FirstOrDefault(p => p.id == idFormaPago);
            if(FormaPagoEncontrado == null)
            return;
            _appContext.FormaPagos.Remove(FormaPagoEncontrado);
            _appContext.SaveChanges();
        }
        FormaPago IRepositorioFormaPago.GetFormaPago(int idFormaPago)
        {
            return _appContext.FormaPagos.FirstOrDefault(p => p.id == idFormaPago);
        }
        IEnumerable<FormaPago> IRepositorioFormaPago.GetAllFormaPagos()
        {
            return _appContext.FormaPagos;
        }     
    }
}