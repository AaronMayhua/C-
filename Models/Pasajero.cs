using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Aaron_Mayhua_Najarro_POOII.Models
{
    public class Pasajero
    {
        public int idPasajero { get; set; }
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string tipoDocumento { get; set; }
        public string numDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string nombrePais { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }


        // Constructor Vacio
        public Pasajero() { }

        // Constructor con Parametros 
        public Pasajero(int idPasajero, string nombre, string aPaterno, string aMaterno, string tipoDocumento, string numDocumento, DateTime fechaNacimiento, string nombrePais, string telefono, string email)
        {
            this.idPasajero = idPasajero;
            this.nombre = nombre;
            this.aPaterno = aPaterno;
            this.aMaterno = aMaterno;
            this.tipoDocumento = tipoDocumento;
            this.numDocumento = numDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.nombrePais = nombrePais;
            this.telefono = telefono;
            this.email = email;
        }
    }
}