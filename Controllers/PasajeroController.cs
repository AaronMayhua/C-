using EF_Aaron_Mayhua_Najarro_POOII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_Aaron_Mayhua_Najarro_POOII.Controllers
{
    public class PasajeroController : Controller
    {
        // GET: Pasajero

        // Variable Global Pais
        DaoPais daoPais = new DaoPais();
        IEnumerable<Pais> listarPais = new List<Pais>();

        // Variable Global DaoPasajero
        DaoPasajero daoPasajero = new DaoPasajero();


        [HttpGet]
        public ActionResult Create()
        {
            listarPais = daoPais.listarPais();
            ViewBag.Pais = new SelectList(listarPais, "idPais", "nombre");

            return View(new Pasajero());
        }

        // POST Pasajero
        public ActionResult Create(Pasajero obj)
        {
            ViewBag.mensaje = daoPasajero.CrearPasajero(obj);
            listarPais = daoPais.listarPais();
            ViewBag.Pais = new SelectList(listarPais, "idPais", "nombre", obj.nombrePais);
            // Este return me devuelve un obj
            return View(obj);
        }

    }
}