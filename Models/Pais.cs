using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Aaron_Mayhua_Najarro_POOII.Models
{
    public class Pais
    {
        public string idPais { get; set; }
        public string nombre { get; set; }

        public Pais() { }

        public Pais(string idPais, string nombre)
        {
            this.idPais = idPais;
            this.nombre = nombre;
        }
    }
}