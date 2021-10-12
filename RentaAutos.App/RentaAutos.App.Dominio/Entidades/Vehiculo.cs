using System;

namespace RentaAutos.App.Dominio.Entidades
{
    public class Vehiculo
    {
        public int id {get; set;}
        public string placa {get; set;}
        public int modelo {get; set;}
        public string capacidad {get; set;}
        public string color {get; set;}
        public string imagen {get; set;}

        // foraneas

        public HojaVida hojaVida {get; set;}
        public Marca marca {get; set;}
        public TipoCaja tipoCaja {get; set;}
        public TipoCombustible tipoCombustible {get; set;}
    }
}