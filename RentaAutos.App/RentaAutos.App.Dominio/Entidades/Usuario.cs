using System;

namespace RentaAutos.App.Dominio
{
    public class Usuario
    {
        public int id {get; set;}
        public string cedula {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public string direccion {get; set;}
        public string telefono {get; set;}
        public string correo {get; set;}
    }
}