using System;

namespace RentaAutos.App.Dominio
{
    public class Alquiler
    {
        public int id {get; set;}
        public string codigo {get; set;}
        public DateTime fechaInicio {get; set;}
        public DateTime fechaFin {get; set;}
        public string lugarRecogida {get; set;}
        public string lugarEntrega {get; set;}
        // forma de pago esta en bd como int
        public string formaPago {get; set;}
        public int valorPagar {get; set;}

        //foraneas
        public Usuario usuario {get; set;}
        public Vehiculo vehiculo {get; set;}
        public EstadoEntrega estadoEntrega {get; set;}
        public EstadoAlquiler estadoAlquiler {get; set;}
        public FormaPago formaPagos {get; set;}
    }
}