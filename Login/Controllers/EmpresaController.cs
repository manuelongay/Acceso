using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class EmpresaController : Controller
    {
        //
        // GET: /Empresa/
        pruebasvsEntities1 bdprueba = new pruebasvsEntities1();

        public ActionResult Index()
        {
            //var listasociedad = bdprueba.catsociedades;
            //return View(listasociedad.ToList());
            var rsql = from p in bdprueba.catsociedades
                       select new empresa {
                           idsociedad= p.IdSociedad,
                           nomsociedad= p.NomSociedad
                       };
            return View(rsql.ToList());
        }
    }
}
